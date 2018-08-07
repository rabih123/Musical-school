Imports System.Data.SqlClient

Public Class frmProfManSess
    Dim lctitle As String = "Managing Professors Sessions"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges As Boolean
    Dim dtsess As DataTable

    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProfManSess_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuMangProfSes.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProfManSess_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillCbProff()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Try
            strsql = "Select -5 as prf_id ,'Select an Professor' as prf_name  "
            strsql &= "union select prf_id,prf_name+ ' '+ prf_lname as prf_name  from tbl_professors  "
            strsql &= "inner join  tbl_ProfCourse on PrfCrs_Prof=prf_id "
            strsql &= " where prf_status='A' "
            'strsql &= " And prf_id not in(" & LblProf.Tag.ToString & ")"

            cnsql = New SqlConnection(constr)
            cnsql.Open()
            da = New SqlDataAdapter(strsql, cnsql)
            dt = New DataTable
            da.Fill(dt)

            cbProff.DataSource = dt

            cbProff.ValueMember = "prf_id"
            cbProff.DisplayMember = "prf_name"


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            btnModify.Enabled = False
            btnCancel.Enabled = True
            btnSave.Enabled = True
            btnClose.Enabled = True
            EnableDisable(Me, True)
            Mnthdate.Enabled = True
            btnChk.Enabled = True
            btnUnchk.Enabled = True
            btnShow.Enabled = True

            cbProff.Enabled = True
            cbMonth.Enabled = False
            cbMonth.SelectedIndex = Now.Month - 1
            BtnPrvs.Enabled = True

            fillCbProff()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            lcchanges = False

            Mnthdate.MinDate = CDate(Now.Month & "/" & Now.Day & "/" & Now.Year)
            Mnthdate.MaxDate = CDate(Now.Month + IIf(Now.Month = 12, 0, 1) & "/" & Date.DaysInMonth(Now.Year, cbMonth.SelectedIndex + 1) & "/" & Now.Year)
            Mnthdate.SelectionStart = CDate(cbMonth.SelectedIndex + 1 & "/" & Now.Day & "/" & Now.Year)

            ClearControls(Me, "", Nothing)
            EnableDisable(Me, False)

           
            BtnPrvs.Enabled = False
            btnModify.Enabled = True
            btnCancel.Enabled = False
            btnSave.Enabled = False
            btnClose.Enabled = True
            Mnthdate.Enabled = False
            btnChk.Enabled = False
            btnUnchk.Enabled = False

            cbMonth.Text = ""
            cbMonth.SelectedIndex = -1
            cbProff.DataSource = Nothing
            btnShow.Enabled = False
            tdbSess.ClearFields()
            dtsess = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dr As DataRow
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction

        Try


            If cbProff.SelectedIndex <= 0 Then
                MessageBox.Show("Select the Professor First.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbProff.Focus() : cbProff.DroppedDown = True
                Exit Try
            End If

            If dtsess.Rows.Count = 0 Then Exit Try

            If lcchanges = False Then
                MessageBox.Show("No Changes Made To Save.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            If TxtReason.Text.Trim = "" Then
                MessageBox.Show("Enter the reason.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtReason.Focus() : Exit Try
            End If

            If MessageBox.Show("Are yous ure do you want to save ?", lctitle, _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cnsql = New SqlConnection(constr)
                cnsql.Open()


                trsql = cnsql.BeginTransaction

                For Each dr In dtsess.Rows
                    If dr.RowState = DataRowState.Modified Then

                        If dr.Item("Oldchk") = "True" AndAlso dr.Item("Chk") = "True" Then
                            strsql = "Update tbl_ReplaSession set  MngSess_RplcProf=" & IIf(dr.Item("MngSess_RplcProf") Is DBNull.Value, "NULL", dr.Item("MngSess_RplcProf")) & ","
                            strsql &= "MngSess_Note='" & TxtReason.Text.Trim & "'"
                            strsql &= " Where MngSess_Recid=" & dr.Item("MngSess_Recid")
                        ElseIf dr.Item("Oldchk") = "False" AndAlso dr.Item("Chk") = "True" Then
                            strsql = "Insert into tbl_ReplaSession select "
                            strsql &= " " & cbProff.SelectedValue & ",'" & CDate(dr.Item("Ses_StartTime")).ToString("MM/dd/yyyy HH:mm:ss") & "',"
                            strsql &= "'" & CDate(dr.Item("Ses_EndTime")).ToString("MM/dd/yyyy HH:mm:ss") & "',"
                            strsql &= "'" & TxtReason.Text.Trim.Replace("'", "''") & "',"
                            strsql &= " " & IIf(dr.Item("MngSess_RplcProf") Is DBNull.Value, "NULL", dr.Item("MngSess_RplcProf")) & ", "
                            strsql &= " '" & dr.Item("Crs_Code") & "' "
                        ElseIf dr.Item("OldChk") = "True" AndAlso dr.Item("Chk") = "False" Then
                            strsql = "Delete from tbl_ReplaSession where MngSess_Recid=" & dr.Item("MngSess_Recid")
                        End If


                        cmsql = New SqlCommand(strsql, cnsql, trsql)
                        cmsql.ExecuteNonQuery()

                    End If




                Next
                trsql.Commit()


                MessageBox.Show("Modifications Successfully saved ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCancel_Click(btnCancel, New System.EventArgs)
            End If
        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing : trsql = Nothing
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmProfManSess_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                Case Keys.F10 : If btnSave.Enabled Then btnSave_Click(btnSave, New System.EventArgs)
                Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmProfManSess_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If usercode <> "SU" Then
                If getPrivliges(usercode, lcStep) = Nothing OrElse getPrivliges(usercode, lcStep) = False Then
                    lcView = False
                Else
                    lcView = True
                End If
            Else
                lcView = True
            End If

            EnableDisable(Me, False)


            If lcView = False Then
                EnableMenuButton(Me, False, {btnClose})
            End If

            btnCancel.Enabled = False
            btnSave.Enabled = False
            btnClose.Enabled = True
            btnChk.Enabled = False
            btnUnchk.Enabled = False
            Mnthdate.Enabled = False
            btnShow.Enabled = False
            BtnPrvs.Enabled = False
           
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbProff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProff.Click
        Try
            If CType(sender, ComboBox).SelectedIndex > 0 AndAlso lcchanges = True Then

                If MessageBox.Show("Do you want to Discard changes without saving ", lctitle, MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    Exit Try
                Else
                    ClearControls(Me, "", Nothing) : cbMonth.SelectedIndex = -1
                    tdbSess.ClearFields()
                    lcchanges = False : CType(sender, ComboBox).DroppedDown = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbMonth_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMonth.SelectedIndexChanged
        Try
            If cbMonth.SelectedIndex < 0 Then Exit Try

            Mnthdate.MinDate = CDate(cbMonth.SelectedIndex + 1 & "/" & Now.Day & "/" & Now.Year)
            Mnthdate.MaxDate = CDate(cbMonth.SelectedIndex + 1 & "/" & Date.DaysInMonth(Now.Year, cbMonth.SelectedIndex + 1) & "/" & Now.Year)
            Mnthdate.SelectionStart = CDate(cbMonth.SelectedIndex + 1 & "/" & Now.Day & "/" & Now.Year)

            Mnthdate.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
    Private Sub TxtReason_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtReason.Enter
        CType(sender, TextBox).BackColor = Color.Bisque
    End Sub

    Private Sub TxtReason_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtReason.Leave
        CType(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim dasql As SqlDataAdapter
        Dim i As Integer
        Dim dr As DataRow

        Try
            If cbProff.SelectedIndex < 0 Then
                MessageBox.Show("Select the Professor First.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbProff.Focus() : cbProff.DroppedDown = True
                Exit Try
            End If


            If tdbSess.Splits(0).Rows.Count <= 0 OrElse (tdbSess.Splits(0).Rows.Count > 0 AndAlso MessageBox.Show("Do You Want To Discard the selected Data.", lctitle, _
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then
                TxtReason.Text = ""

                strsql = "  select MngSess_Recid, case when MngSess_ProfId IS null then 'False' Else 'True' End as [Chk] ,"
                strsql &= " case when MngSess_ProfId IS null then 'False' Else 'True' End as [OldChk],"
                strsql &= " DATENAME(WEEKDAY,ses_startTime) as [Day]," ', Ses_StartTime , Ses_EndTime , "
                strsql &= "convert(datetime,convert(varchar(10),dateadd(week, datediff(week, Ses_StartTime, '" & Mnthdate.SelectionStart.Date & "'), "
                strsql &= " Ses_StartTime),101)+' '+ CONVERT(varchar(10),Ses_StartTime,108)) as Ses_StartTime ,"
                strsql &= "convert(datetime,convert(varchar(10),dateadd(week, datediff(week, Ses_EndTime, '" & Mnthdate.SelectionStart.Date & "'), "
                strsql &= " Ses_EndTime),101)+' '+ CONVERT(varchar(10),Ses_EndTime,108)) as Ses_EndTime ,"
                strsql &= " Crs_Desc , std_id ,std_name + ' '+ std_Lname as [Name] , MngSess_RplcProf , prf_name + ' ' + prf_lname as [PrfName],MngSess_Note,Crs_Code "
                strsql &= "  from tbl_sessions  "
                strsql &= " left join tbl_Students on Ses_StdId=std_id "
                strsql &= " left join tbl_courses on Crs_Code=Ses_CrsCode "
                strsql &= " left join tbl_ReplaSession on MngSess_ProfId=Ses_ProfId and MngSess_StrDate=convert(datetime,convert(varchar(10),dateadd(week, datediff(week, Ses_StartTime, '" & Mnthdate.SelectionStart.Date & "'), "
                strsql &= " Ses_StartTime),101)+' '+ CONVERT(varchar(10),Ses_StartTime,108)) "
                strsql &= " and MngSess_ProfId=" & cbProff.SelectedValue & ""
                strsql &= " left join tbl_professors on prf_id=MngSess_RplcProf "

                'strsql &= " where Ses_ProfId=" & cbProff.SelectedValue & " and convert(datetime,convert(varchar(10),Ses_StartTime,101)) >='" & Mnthdate.SelectionStart.Date & "' "
                'strsql &= " and convert(datetime,convert(varchar(10),Ses_StartTime,101)) <='" & Mnthdate.SelectionEnd.Date & "'"


                strsql &= "where Ses_ProfId=" & cbProff.SelectedValue & " and "
                strsql &= "convert(datetime,convert(varchar(10),dateadd(week, datediff(week, Ses_StartTime, '" & Mnthdate.SelectionStart.Date & "'),"
                strsql &= " Ses_StartTime),101)) >='" & Mnthdate.SelectionStart.Date & "' And "
                strsql &= "convert(datetime,convert(varchar(10),DATEADD(week, DATEDIFF(week, Ses_EndTime, '" & Mnthdate.SelectionEnd.Date & "'),"
                strsql &= " Ses_EndTime),101))  <='" & Mnthdate.SelectionEnd.Date & "' "
                strsql &= " and not std_id is null"
                strsql &= " order by  DATEpart(DW,ses_startTime) , Ses_StartTime"


                cnsql = New SqlConnection(constr)
                cnsql.Open()

                dasql = New SqlDataAdapter(strsql, cnsql)

                dtsess = New DataTable

                dasql.Fill(dtsess)

                tdbSess.DataSource = dtsess.DefaultView

                With tdbSess.Splits(0)
                    .ColumnCaptionHeight = 25
                    .CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .CaptionStyle.ForeColor = Color.Maroon


                    .DisplayColumns("MngSess_Recid").AllowSizing = False
                    .DisplayColumns("MngSess_Recid").Visible = False
                    .DisplayColumns("MngSess_Recid").Width = 0

                    .DisplayColumns("OldChk").AllowSizing = False
                    .DisplayColumns("OldChk").Visible = False
                    .DisplayColumns("OldChk").Width = 0

                    .DisplayColumns("Chk").DataColumn.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                    .DisplayColumns("Chk").DataColumn.Caption = ""
                    .DisplayColumns("Chk").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Chk").Width = 20
                    .DisplayColumns("Chk").AllowSizing = False
                    .DisplayColumns("Chk").Locked = False


                    .DisplayColumns("Day").DataColumn.Caption = "Day"
                    .DisplayColumns("Day").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Day").Width = 90
                    .DisplayColumns("Day").AllowSizing = False
                    .DisplayColumns("Day").Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Free
                    .DisplayColumns("Day").Locked = True

                    .DisplayColumns("Ses_StartTime").DataColumn.Caption = "Start Time"
                    .DisplayColumns("Ses_StartTime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Ses_StartTime").Width = 90
                    .DisplayColumns("Ses_StartTime").DataColumn.NumberFormat = ("hh:mm tt")
                    .DisplayColumns("Ses_StartTime").AllowSizing = False
                    .DisplayColumns("Ses_StartTime").Locked = True

                    .DisplayColumns("Ses_EndTime").DataColumn.Caption = "End Time"
                    .DisplayColumns("Ses_EndTime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Ses_EndTime").Width = 90
                    .DisplayColumns("Ses_EndTime").DataColumn.NumberFormat = ("hh:mm tt")
                    .DisplayColumns("Ses_EndTime").AllowSizing = False
                    .DisplayColumns("Ses_EndTime").Locked = True


                    .DisplayColumns("Crs_Desc").DataColumn.Caption = "Course"
                    .DisplayColumns("Crs_Desc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                    .DisplayColumns("Crs_Desc").Width = 100
                    .DisplayColumns("Crs_Desc").AllowSizing = False
                    .DisplayColumns("Crs_Desc").Locked = True


                    .DisplayColumns("std_id").DataColumn.Caption = "Student Id"
                    .DisplayColumns("std_id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("std_id").Width = 80
                    .DisplayColumns("std_id").AllowSizing = False
                    .DisplayColumns("std_id").Locked = True


                    .DisplayColumns("Name").DataColumn.Caption = "Student Name"
                    .DisplayColumns("Name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                    .DisplayColumns("Name").Width = 140
                    .DisplayColumns("Name").AllowSizing = False
                    .DisplayColumns("Name").Locked = True


                    .DisplayColumns("MngSess_RplcProf").AllowSizing = False
                    .DisplayColumns("MngSess_RplcProf").Visible = False
                    .DisplayColumns("MngSess_RplcProf").Width = 0

                    .DisplayColumns("PrfName").DataColumn.Caption = "Replacemnet Professor "
                    .DisplayColumns("PrfName").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                    .DisplayColumns("PrfName").Width = 240
                    .DisplayColumns("PrfName").AllowSizing = False
                    .DisplayColumns("PrfName").Locked = False
                    .DisplayColumns("PrfName").Style.BackColor = Color.LightBlue
                    .DisplayColumns("PrfName").Style.ForeColor = Color.Gold
                    .DisplayColumns("PrfName").Button = True
                    .DisplayColumns("PrfName").ButtonAlways = True

                    .DisplayColumns("MngSess_Note").AllowSizing = False
                    .DisplayColumns("MngSess_Note").Visible = False
                    .DisplayColumns("MngSess_Note").Width = 0

                    .DisplayColumns("Crs_Code").AllowSizing = False
                    .DisplayColumns("Crs_Code").Visible = False
                    .DisplayColumns("Crs_Code").Width = 0
                  

                



                End With


                For Each column In tdbSess.Splits(0).DisplayColumns
                    tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                    tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                    i = i + 1
                Next


                For Each dr In dtsess.Rows
                    If Not dr.Item("MngSess_Note") Is DBNull.Value Then TxtReason.Text = dr.Item("MngSess_Note")
                Next


            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            dasql = Nothing
        End Try
    End Sub

    Private Sub tdbSess_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbSess.AfterColUpdate
        Try
            If e.Column.DataColumn.DataField = "Chk" AndAlso e.Column.DataColumn.Text = "False" Then
                tdbSess.Splits(0).DisplayColumns("PrfName").DataColumn.Text = ""
                tdbSess.Splits(0).DisplayColumns("MngSess_RplcProf").DataColumn.Text = ""
            End If

            lcchanges = True
            tdbSess.UpdateData()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

  
    Private Sub tdbSess_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbSess.ButtonClick
        Dim strsql As String
        Dim width() As Integer
        width = {70, 150, 150, 100, 150, 150, 70}
        Dim frm As search
        Dim val As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand


        Try
            If tdbSess.Splits(0).DisplayColumns("Chk").DataColumn.Text = "False" Then
                MessageBox.Show("Check The Record First", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            strsql = "select prf_id as [Professor id],prf_name as [Name],prf_lname as [Last Name], "
            strsql &= "prf_tel as [Phone #],prf_addres as [Address],Crs_Desc as [Instrument] , "
            strsql &= "PrfCrs_Price as [Prof %] "
            strsql &= "from tbl_professors "
            strsql &= "Inner join tbl_ProfCourse on PrfCrs_Prof=prf_id "
            strsql &= "inner join tbl_courses on Crs_Code=PrfCrs_Crs "
            strsql &= "where prf_status='A' and prf_id <> " & cbProff.SelectedValue
            strsql &= "And PrfCrs_Crs='" & tdbSess.Splits(0).DisplayColumns("Crs_Code").DataColumn.Text & "'"

            frm = New search
            frm.ShowDialog(strsql, val, False, width)


            If Not val = Nothing AndAlso val.Trim <> "" Then
                tdbSess.Splits(0).DisplayColumns("MngSess_RplcProf").DataColumn.Text = val

                strsql = "select prf_name +' ' + prf_lname from tbl_professors where prf_id=" & val

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                tdbSess.Splits(0).DisplayColumns("PrfName").DataColumn.Text = cmsql.ExecuteScalar

                lcchanges = True
            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : frm = Nothing
        End Try
    End Sub

    Private Sub tdbSess_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles tdbSess.FetchRowStyle
        Try
            If tdbSess.Splits(0).DisplayColumns("chk").DataColumn.CellText(e.Row) = "True"  Then
                e.CellStyle.BackColor = Color.LightSalmon
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub tdbSess_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbSess.KeyPress
        Try
            If tdbSess.Splits(0).DisplayColumns(tdbSess.Col).DataColumn.DataField = "PrfName" Then


                If Asc(e.KeyChar) <> 8 Then e.Handled = True : Exit Try

                If tdbSess.Splits(0).DisplayColumns(tdbSess.Col).DataColumn.Text <> "" AndAlso _
                    MessageBox.Show("Are You sure do you want to remove this professor", lctitle, _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    e.Handled = True : Exit Try
                End If



                CType(tdbSess.Controls(2), TextBox).SelectAll()

                tdbSess.Splits(0).DisplayColumns("MngSess_RplcProf").DataColumn.Text = ""
                tdbSess.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChk.Click
        Dim dr As DataRow

        Try

            If dtsess Is Nothing Then Exit Try
            If dtsess.Rows.Count <= 0 Then Exit Try

            For Each dr In dtsess.Select(dtsess.DefaultView.RowFilter)
                dr.Item("Chk") = "True"
            Next

            lcchanges = True
            tdbSess.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUnchk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnchk.Click
        Dim dr As DataRow

        Try
            If dtsess Is Nothing Then Exit Try
            If dtsess.Rows.Count <= 0 Then Exit Try

            For Each dr In dtsess.Select(dtsess.DefaultView.RowFilter)
                dr.Item("Chk") = "False"
                dr.Item("MngSess_RplcProf") = DBNull.Value
                dr.Item("prfname") = ""
            Next


            lcchanges = True
            tdbSess.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnPrvs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrvs.Click
        Dim width() As Integer
        width = {80, 70, 80, 80, 200, 250, 250, 200}
        Try
            Dim frm As search
            Dim strsql As String
            Dim val As String


            strsql = "   select convert(varchar(10),MngSess_StrDate,103) as [Date] , DATENAME(WEEKDAY,MngSess_StrDate) as [Day]," ', Ses_StartTime , Ses_EndTime , "
            strsql &= "  CONVERT(varchar(10),MngSess_StrDate,108) as [Start time] ,"
            strsql &= "  CONVERT(varchar(10),MngSess_EndDate,108) as [End Time] ,"
            strsql &= "  Crs_Desc as [Course] , "
            strsql &= "  A1.prf_name + ' ' + A1.prf_lname as [Professor],MngSess_Note as [Notes] ,A2.prf_name + ' ' + A2.prf_lname as [Replacement Professor]  "
            strsql &= "  from tbl_ReplaSession  "
            strsql &= " left join tbl_courses on Crs_Code=MngSess_Course "
            strsql &= " left join tbl_professors A1 on A1.prf_id=MngSess_ProfId "
            strsql &= " left join tbl_professors A2 on A2.prf_id=MngSess_RplcProf "


            strsql &= "where "
            strsql &= "Month(MngSess_StrDate)=" & Now.Month & "  "
            strsql &= " order by  DATEpart(DW,MngSess_StrDate) , MngSess_StrDate "

            frm = New search


            frm.ShowDialog(strsql, val, True, width)
            frm.tdbsearch.Splits(0).DisplayColumns(0).Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Free

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class