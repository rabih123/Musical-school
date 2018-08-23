Imports System.Data.SqlClient
Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Public Class frmCourses
    Dim lctitle As String = "Form Courses"
    Dim lcStep, lcmode, SessCount As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges As Boolean
    Dim dtcourse As DataTable
    Dim dacourse As SqlDataAdapter

    Public Event aa()

    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCourses_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuCourses.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCourses_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCourses_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Try
                Select Case e.KeyCode
                    'Case Keys.F3 : If btnadd.Enabled Then btnadd_Click(btnadd, Nothing)
                    Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                        'Case Keys.F5 : If btnDelete.Enabled Then btnDelete_Click(btnDelete, New System.EventArgs)
                    Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                        'Case Keys.F9 : If btnSearch.Enabled Then btnSearch_Click(btnCancel, New System.EventArgs)
                    Case Keys.F10 : If btnSave.Enabled Then btnSave_Click(btnSave, New System.EventArgs)
                    Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
                End Select
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCourses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            btnCancel.Enabled = False : btnSave.Enabled = False

            'MusicSchool.frmCourses.Events.RemoveHandler(CbProff_MouseWheel)
            lcchanges = False
            'tdbcourses_FetchCellStyle(tdbcourses, C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs)

            AddHandler tdbcourses.FetchCellStyle, AddressOf tdbcourses_FetchCellStyle
            Button1.Enabled = False
            BtnSchedule.Enabled = False
            CbCourse.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            GrpMode.Visible = True
            GrpMode.BringToFront()
            RbAdd.Enabled = True : RbDelete.Enabled = True
            RbAdd.BackColor = Color.FromArgb(192, 192, 255)
            RbDelete.BackColor = Color.FromArgb(192, 192, 255)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fillComboBox()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Try
            strsql = "Select -5 as prf_id ,'Select an Professor' as prf_name "
            strsql &= "union select prf_id,prf_name+ ' '+ prf_lname as prf_name  from tbl_professors  "
            strsql &= "inner join tbl_ProfCourse on PrfCrs_Prof=prf_id "
            strsql &= " where prf_status='A' and PrfCrs_Crs='" & CbCourse.SelectedValue & "'"

            cnsql = New SqlConnection(constr)
            cnsql.Open()
            da = New SqlDataAdapter(strsql, cnsql)
            dt = New DataTable
            da.Fill(dt)

            CbProff.DataSource = dt

            CbProff.ValueMember = "prf_id"
            CbProff.DisplayMember = "prf_name"


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub CbProff_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbProff.Click
        Try
            If CbProff.SelectedIndex > 0 Then
                If lcchanges = True Then
                    If MessageBox.Show("Do you want to Discard changes without saving ", lctitle, MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                        Exit Try
                    Else
                        CbProff.DroppedDown = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   

    Private Sub CbProff_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbProff.SelectedIndexChanged
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim i As Integer
        Try
            If Me.ActiveControl Is CbProff AndAlso CbProff.SelectedIndex > 0 Then
                dtsession = Nothing
                lblsess.BackColor = Color.White : sestimer.Stop()
                'If lcchanges = True Then
                '    If MessageBox.Show("Do you want to Discard changes without saving ", lctitle, MessageBoxButtons.YesNo, _
                '                       MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                '        Exit Try
                '    End If
                'End If

                strsql = " select case when not PrS_Stdid is null and PrS_Prf= " & CbProff.SelectedValue & " then 'True' else 'False'  end as [OldChk], "
                strsql &= "case when not PrS_Stdid is null and PrS_Prf= " & CbProff.SelectedValue & " then 'True' else 'False'  end as [Chk],"
                strsql &= "std_id,std_name +' ' + std_Lname as [Name] ,std_age, Std_Sex, Std_Special," & CDbl(LblPrice.Text.Trim.Replace("$", "")) & " as Crs_Price , isnull(prs_disc,0)  as [Perc],isnull(Crs_Price+prs_disc, Crs_Price) as [prcw%] ," ',Prfid , case when Prfid= " & CbProff.SelectedIndex & " then null else  prfname end  as  prfname "
                strsql &= "(select STUFF((select '; '+ cast(Crs_Desc as varchaR(10))+' '  "
                strsql &= "from  tbl_profStdCrs  "
                strsql &= "left join dbo.tbl_courses on Prs_Crs=Crs_Code "
                strsql &= "where(Crs_Code <> '" & CbCourse.SelectedValue & "' And PrS_Stdid = std_id)  FOR XML PATH('')),1,1,'')) as  OtherCourses,  "

                strsql &= "(select STUFF((select '; '+ cast(prf_name as varchaR(10))+' '  from tbl_profStdCrs "
                strsql &= "left join dbo.tbl_professors on PrS_Prf=prf_id "
                strsql &= "where(PrS_Prf <> " & CbProff.SelectedValue & " And PrS_Stdid = std_id)  "
                strsql &= "FOR XML PATH('')),1,1,'')) as  prfname "

                strsql &= " from tbl_Students "
                strsql &= "left join dbo.tbl_profStdCrs on  PrS_Stdid=std_id  and  PrS_Prf=" & CbProff.SelectedValue & " And Prs_Crs='" & CbCourse.SelectedValue & "'"
                strsql &= "left join dbo.tbl_professors on PrS_Prf=prf_id and  prf_status='A'  "
                strsql &= "Left Join tbl_courses on Crs_Code='" & CbCourse.SelectedValue & "' "
                strsql &= " Where std_status='A' "
                'strsql &= "left join  ( "
                'strsql &= "select PrS_Stdid as [Stdid], PrS_Prf as [Prfid],prf_name as [prfname] from tbl_profStd "
                'strsql &= "left join dbo.tbl_professors on PrS_Prf=prf_id "
                'strsql &= " where  PrS_Prf= " & CbProff.SelectedIndex & ")  t on Stdid=PrS_Stdid "
                'strsql &= "where(PrS_Prf = " & CbProff.SelectedIndex & "  Or Not PrS_Prf Is null Or PrS_Prf Is null) "

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                dtcourse = New DataTable
                dacourse = New SqlDataAdapter(strsql, cnsql)
                dacourse.Fill(dtcourse)



                tdbcourses.DataSource = dtcourse.DefaultView

                tdbcourses.Enabled = True
                Button1.Enabled = True
                With tdbcourses.Splits(0)
                    .ColumnCaptionHeight = 25
                    .CaptionStyle.HorizontalAlignment = AlignHorzEnum.Center
                    .CaptionStyle.ForeColor = Color.Maroon

                    .DisplayColumns("oldchk").Visible = False
                    .DisplayColumns("oldchk").AllowSizing = False

                    .DisplayColumns("Chk").DataColumn.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                    .DisplayColumns("Chk").Locked = False
                    .DisplayColumns("Chk").DataColumn.Caption = ""
                    .DisplayColumns("Chk").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("Chk").Width = 50
                    .DisplayColumns("Chk").AllowSizing = False

                    .DisplayColumns("std_id").Locked = True
                    .DisplayColumns("std_id").DataColumn.Caption = "Id"
                    .DisplayColumns("std_id").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("std_id").Width = 75
                    .DisplayColumns("std_id").AllowSizing = False


                    .DisplayColumns("Name").Locked = True
                    .DisplayColumns("Name").DataColumn.Caption = "Full Name"
                    .DisplayColumns("Name").Style.HorizontalAlignment = AlignHorzEnum.Near
                    .DisplayColumns("Name").Width = 200
                    .DisplayColumns("Name").AllowSizing = True

                    .DisplayColumns("std_age").Locked = True
                    .DisplayColumns("std_age").DataColumn.Caption = "Age"
                    .DisplayColumns("std_age").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("std_age").Width = 50
                    .DisplayColumns("std_age").AllowSizing = False


                    .DisplayColumns("Std_Sex").Locked = True
                    .DisplayColumns("Std_Sex").DataColumn.Caption = "Sex"
                    .DisplayColumns("Std_Sex").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("Std_Sex").Width = 50
                    .DisplayColumns("Std_Sex").AllowSizing = False

                    .DisplayColumns("Std_Special").Locked = True
                    .DisplayColumns("Std_Special").DataColumn.Caption = "Special"
                    .DisplayColumns("Std_Special").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("Std_Special").Width = 70
                    .DisplayColumns("Std_Special").AllowSizing = False

                    .DisplayColumns("Crs_Price").Locked = True
                    .DisplayColumns("Crs_Price").DataColumn.Caption = "Price"
                    .DisplayColumns("Crs_Price").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("Crs_Price").Width = 50
                    .DisplayColumns("Crs_Price").AllowSizing = False

                    .DisplayColumns("Perc").Locked = False
                    .DisplayColumns("Perc").DataColumn.Caption = "Discount In $ "
                    .DisplayColumns("Perc").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("Perc").Width = 100
                    .DisplayColumns("Perc").AllowSizing = False
                    .DisplayColumns("Perc").Style.BackColor = Color.LightPink

                    .DisplayColumns("prcw%").Locked = True
                    .DisplayColumns("prcw%").DataColumn.Caption = "Price with Discount "
                    .DisplayColumns("prcw%").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("prcw%").Width = 130
                    .DisplayColumns("prcw%").AllowSizing = False

                    '.DisplayColumns("Prfid").Visible = False
                    '.DisplayColumns("Prfid").AllowSizing = False

                    .DisplayColumns("OtherCourses").Locked = True
                    .DisplayColumns("OtherCourses").DataColumn.Caption = "Other Courses"
                    .DisplayColumns("OtherCourses").Style.HorizontalAlignment = AlignHorzEnum.Near
                    .DisplayColumns("OtherCourses").Width = 150
                    .DisplayColumns("OtherCourses").AllowSizing = True
                    .DisplayColumns("OtherCourses").Style.BackColor = Color.Beige

                    .DisplayColumns("prfname").Locked = True
                    .DisplayColumns("prfname").DataColumn.Caption = "Other Professor"
                    .DisplayColumns("prfname").Style.HorizontalAlignment = AlignHorzEnum.Near
                    .DisplayColumns("prfname").Width = 150
                    .DisplayColumns("prfname").AllowSizing = True
                    .DisplayColumns("prfname").Style.BackColor = Color.Beige



                End With


                For Each column In tdbcourses.Splits(0).DisplayColumns
                    tdbcourses.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    tdbcourses.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                    tdbcourses.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                    tdbcourses.Splits(0).DisplayColumns(i).HeadingStyle.BackColor = Color.Gold
                    i = i + 1
                Next

                tdbcourses.Splits(0).DisplayColumns("prfname").DataColumn.FilterText = ""
                studentcount()
                SessionsCount()

                'getInfo()

            End If
            lcchanges = False
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
        End Try
    End Sub

    Private Sub CbProff_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CbProff.MouseWheel
        OnMouseWheel(e)
    End Sub

    Private Sub tdbcourses_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles tdbcourses.BeforeColEdit
        Try
            If RbAdd.Checked = True Then
                If e.Column.DataColumn.DataField = "Chk" Then
                    If e.Column.DataColumn.Text = "False" Then e.Cancel = True : Exit Try
                End If

                If e.Column.DataColumn.DataField = "Chk" AndAlso e.Column.DataColumn.Text = "True" AndAlso tdbcourses.FilterActive = False Then
                    If CInt(lblsess.Text.Split(" / ")(0)) >= SessCount Then
                        MessageBox.Show(" No More Available Sessions For This Professor , Save And Choose Anothher Professor Or Add New Sessions", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True
                    End If
                End If
            Else
                If e.Column.DataColumn.DataField = "Chk" Then
                    If e.Column.DataColumn.Text = "True" Then e.Cancel = True : Exit Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub tdbcourses_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles tdbcourses.BeforeColUpdate
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim frm As frmSchedules
        Dim dr As DataRow
        Try
            If e.ColIndex = 1 Then

              
                If e.Column.DataColumn.Text = "True" Then

                    strsql = "Select Top 1 1 from tbl_profStdCrs where Prs_Crs='" & CbCourse.SelectedValue & "' And PrS_Stdid=" & tdbcourses.Splits(0).DisplayColumns("std_id").DataColumn.Text
                    cnsql = New SqlConnection(constr)
                    cnsql.Open()

                    cmsql = New SqlCommand(strsql, cnsql)
                    If Not cmsql.ExecuteScalar Is Nothing Then
                        If MessageBox.Show("This Studnets is Already Attending This Course Dou you Want to continue ", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                            e.Cancel = True : Exit Try
                        End If

                    End If


                    'If tdbcourses.Splits(0).DisplayColumns("prfname").DataColumn.Text <> "" Then
                    '    If MessageBox.Show("This Studnets is  Attending Another Class With --" & tdbcourses.Splits(0).DisplayColumns("prfname").DataColumn.Text & "-- Dou you Want to continue", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    '        e.Cancel = True : Exit Try
                    '    End If

                    'End If



                    If MessageBox.Show("Are You Sure Do You Want To Continue ?", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If dtsession Is Nothing Then
                            dtsession = New DataTable
                            dtsession.Columns.Add("StdId", GetType(Integer))
                            dtsession.Columns.Add("StdName", GetType(String))
                            dtsession.Columns.Add("SessId", GetType(Integer))
                            dtsession.Columns.Add("Sts", GetType(String))
                            ' N:New -- O:Old 
                        End If

                        dr = dtsession.NewRow

                        dr.Item("StdId") = tdbcourses.Splits(0).DisplayColumns("std_id").DataColumn.Text
                        dr.Item("StdName") = tdbcourses.Splits(0).DisplayColumns("Name").DataColumn.Text
                        dr.Item("Sts") = "N"
                        dtsession.Rows.Add(dr)

                        frm = New frmSchedules
                        frm.StartPosition = FormStartPosition.CenterScreen
                        frm.Show(lcStep, CbProff.SelectedValue, CbProff.Text, True, CbCourse.SelectedValue)
                        Me.Refresh()
                        lblsess.Text = (CInt(lblsess.Text.Split(" / ")(0)) + 1) & " / " & SessCount

                        If CInt(lblsess.Text.Split(" / ")(0)) = SessCount Then
                            sestimer.Start()
                            RaiseEvent aa()
                        End If
                    Else
                        e.Cancel = True
                    End If


                ElseIf e.ColIndex = 8 Then
                    If tdbcourses.Splits(0).DisplayColumns("Perc").DataColumn.Text = "" Then
                        tdbcourses.Splits(0).DisplayColumns("Perc").DataColumn.Text = 0.0
                    End If
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing : cmsql = Nothing
            frm = Nothing : dr = Nothing
        End Try
    End Sub

    Private Sub tdbcourses_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles tdbcourses.FetchRowStyle
        Try
            'For i = 0 To e.Row
            '    If tdbcourses.Splits(0).DisplayColumns("prfname").DataColumn.Text <> "" Then
            '        If tdbcourses.Splits(0).DisplayColumns("Prfid").DataColumn.Text <> CbProff.SelectedIndex Then
            '            e.CellStyle.BackColor = Color.Aqua
            '            MsgBox(e.Row)
            '        End If
            '    End If
            'Next
            If tdbcourses.Splits(0).DisplayColumns("chk").DataColumn.CellText(e.Row) = "True" AndAlso _
                    tdbcourses.Splits(0).DisplayColumns("prfname").DataColumn.CellText(e.Row) = "" Then
                e.CellStyle.BackColor = Color.LightSalmon
            ElseIf tdbcourses.Splits(0).DisplayColumns("OtherCourses").DataColumn.CellText(e.Row) <> "" Then
                e.CellStyle.BackColor = Color.Yellow
            ElseIf tdbcourses.Splits(0).DisplayColumns("prfname").DataColumn.CellText(e.Row) <> "" AndAlso _
                    tdbcourses.Splits(0).DisplayColumns("chk").DataColumn.CellText(e.Row) = "False" Then
                ' If tdbcourses.Splits(0).DisplayColumns("Prfid").DataColumn.Text <> CbProff.SelectedIndex Then
                e.CellStyle.BackColor = Color.LightBlue
                'End If
            ElseIf tdbcourses.Splits(0).DisplayColumns("chk").DataColumn.CellText(e.Row) = "True" AndAlso _
                    tdbcourses.Splits(0).DisplayColumns("prfname").DataColumn.CellText(e.Row) <> "" Then
                e.CellStyle.BackColor = Color.LightGreen
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        If Me.ActiveControl Is CbProff Then
            mwe.Handled = True
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction
        Dim dr, dr2, dr3 As DataRow
        Dim totalSum As Integer = 0
        Dim Perc As Integer = 0

        Try

            If MessageBox.Show("Are yous ure do you want to save ?", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                If CbCourse.SelectedIndex <= 0 Then
                    MessageBox.Show("Please Select A Course First", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CbCourse.DroppedDown = True : CbCourse.Focus() : Exit Try
                End If

                If CbProff.SelectedIndex <= 0 Then
                    MessageBox.Show("Please Select A professor First", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CbProff.DroppedDown = True : CbProff.Focus() : Exit Try
                End If


                If dtcourse.Select("chk=true").Length = 0 AndAlso LblMode.Text = "ADD" Then
                    MessageBox.Show("No students Selected", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Try
                End If


                cnsql = New SqlConnection(constr)
                cnsql.Open()


                trsql = cnsql.BeginTransaction

                For Each dr In dtcourse.Rows
                    If dr.Item("oldchk") = "False" AndAlso dr.Item("chk") = "True" Then
                        totalSum = 0 : Perc = 0


                        strsql = "Insert into tbl_profStdCrs select "
                        strsql &= "'" & CbCourse.SelectedValue & "'," & dr.Item("std_id") & "," & CbProff.SelectedValue & " , " & dr.Item("Crs_Price") & ","
                        strsql &= dr.Item("Perc") & ",NULL,NULL,NULL,getdate(),'" & usercode & "',1 "

                        cmsql = New SqlCommand(strsql, cnsql, trsql)
                        cmsql.ExecuteNonQuery()



                        '''' get Total to apid of a student with %
                        For Each dr2 In dtcourse.Select("std_id=" & dr.Item("std_id"))
                            totalSum = totalSum + dr.Item("prcw%") : Perc = Perc + dr.Item("Perc")
                        Next

                        Perc = Perc / dtcourse.Select("std_id=" & dr.Item("std_id")).Length
                        ''end 


                        strsql = ""
                        For i = Now.Month To 12
                            strsql &= "Insert into tbl_vouchers values(" & dr.Item("std_id") & "," & CbProff.SelectedValue & "," & Now.Year & ",'" & CDate(DateSerial(Now.Year, i, 1)).ToString("MMMM") & "',"
                            strsql &= CInt(totalSum) & "," & CInt(Perc) & ",'N', getdate() ,'" & usercode & "','" & CbCourse.SelectedValue & "'," & i & ");"
                        Next

                        cmsql.CommandText = strsql
                        cmsql.ExecuteNonQuery()


                        If Not dtsession Is Nothing Then
                            For Each dr3 In dtsession.Select("StdId=" & dr.Item("std_id"))
                                strsql = "Update  tbl_sessions set Ses_StdId=" & dr.Item("std_id") & " where Ses_ProfId=" & CbProff.SelectedValue & " ANd "
                                strsql &= "Ses_Counter=" & dr3.Item(2).ToString
                            Next

                            cmsql.CommandText = strsql
                            cmsql.ExecuteNonQuery()
                        End If


                        'strsql = "Update tbl_vouchers "
                        'strsql &= "set vch_total =  vch_total - (spc_Amount / case when  isnull(cnt,0) >0 then cnt else 1 end) "
                        'strsql &= "from tbl_vouchers "
                        'strsql &= "left join ( "
                        'strsql &= "select max(vch_total) as [tot] , max(spc_Amount) as spc_Amount  , max(vch_stdid) as [stdid], "
                        'strsql &= "COUNT(vch_Course) as[cnt]  from  tbl_vouchers "
                        'strsql &= "inner join tbl_SpecMonths on Spc_Month=vch_numMonth and Spc_Year=YEAR(getdate()) "
                        'strsql &= "where vch_stdid=" & dr.Item("std_id") & " "
                        'strsql &= "= group by vch_stdid)tbl on [stdid]=vch_stdid "
                        'strsql &= "where vch_stdid=" & dr.Item("std_id") & " "

                        'cmsql.CommandText = strsql
                        'cmsql.ExecuteNonQuery()

                    ElseIf dr.Item("oldchk") = "True" AndAlso dr.Item("chk") = "True" And dr.RowState = DataRowState.Modified Then
                        totalSum = 0 : Perc = 0

                        strsql = "Update tbl_profStdCrs set prs_disc=" & dr.Item("Perc") & ",  prs_usrstmp= '" & usercode & "'"
                        strsql &= "where PrS_Prf=" & CbProff.SelectedValue & " and  PrS_Stdid=" & dr.Item("std_id")

                        cmsql = New SqlCommand(strsql, cnsql, trsql)
                        cmsql.ExecuteNonQuery()


                        '''' get Total to apid of a student with %
                        For Each dr2 In dtcourse.Select("std_id=" & dr.Item("std_id"))
                            totalSum = totalSum + dr.Item("prcw%") : Perc = Perc + dr.Item("Perc")
                        Next

                        Perc = Perc / dtcourse.Select("std_id=" & dr.Item("std_id")).Length
                        ''end 

                        strsql = " update tbl_vouchers set vch_perc=" & Perc & ", vch_total=" & totalSum & "where vch_stdid=" & dr.Item("std_id")
                        strsql &= "and vch_prof=" & CbProff.SelectedValue & "and Vch_year=" & Now.Year & " and vch_paid='N'"

                        cmsql.CommandText = strsql
                        cmsql.ExecuteNonQuery()

                    ElseIf dr.Item("oldchk") = "True" AndAlso dr.Item("chk") = "False" Then
                        strsql = "delete from tbl_profStdCrs where PrS_Stdid=" & dr.Item("std_id") & "And PrS_Prf=" & CbProff.SelectedValue

                        cmsql = New SqlCommand(strsql, cnsql, trsql)
                        cmsql.ExecuteNonQuery()

                        strsql = "delete from tbl_vouchers where vch_stdid=" & dr.Item("std_id") & "and vch_prof=" & CbProff.SelectedValue & "and Vch_year=" & Now.Year & " and vch_paid='N'"
                        cmsql.CommandText = strsql
                        cmsql.ExecuteNonQuery()


                      
                        strsql = "Update tbl_sessions set Ses_StdId=NULL  Where Ses_StdId=" & dr.Item("std_id") & " And Ses_ProfId=" & CbProff.SelectedValue & "  "
                        strsql &= " And Ses_CrsCode='" & CbCourse.SelectedValue & "'"


                        cmsql.CommandText = strsql
                        cmsql.ExecuteNonQuery()


                    End If
                Next
                trsql.Commit()

                MessageBox.Show("Modifications Successfully saved ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

                dtcourse.Clear() : CbProff.SelectedIndex = 0
                lcchanges = False : studentcount()
                dtsession = Nothing
            End If
        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing : trsql = Nothing
        End Try
    End Sub

    Private Sub tdbcourses_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbcourses.RowColChange
        Try 
            If dtcourse.Rows.Count >= 1 AndAlso tdbcourses.FilterActive = False Then
                If tdbcourses.Splits(0).DisplayColumns("chk").DataColumn.Text = False Then
                    tdbcourses.Splits(0).DisplayColumns("Perc").Locked = True
                Else
                    tdbcourses.Splits(0).DisplayColumns("Perc").Locked = False
                End If


                If tdbcourses.Splits(0).DisplayColumns("chk").DataColumn.Text = "True" Then

                    tdbcourses.Splits(0).DisplayColumns("chk").AddCellStyle(CellStyleFlag.CurrentCell, tdbcourses.Style)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbcourses_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbcourses.AfterColUpdate
        Try
            If tdbcourses.Splits(0).DisplayColumns(tdbcourses.Col).DataColumn.DataField = "Perc" Then
                If tdbcourses.Splits(0).DisplayColumns("Perc").DataColumn.Text.Trim = "" Then tdbcourses.Splits(0).DisplayColumns("Perc").DataColumn.Text = 0
                If tdbcourses.Splits(0).DisplayColumns("Perc").DataColumn.Text = 0 Then
                    tdbcourses.Splits(0).DisplayColumns("prcw%").DataColumn.Text = tdbcourses.Splits(0).DisplayColumns("Crs_Price").DataColumn.Text
                Else
                    tdbcourses.Splits(0).DisplayColumns("prcw%").DataColumn.Text = CDbl(tdbcourses.Splits(0).DisplayColumns("Crs_Price").DataColumn.Text) + _
                       CDbl(tdbcourses.Splits(0).DisplayColumns("Perc").DataColumn.Text)
                End If
            End If

            If e.Column.DataColumn.Text = "False" Then
                lblsess.BackColor = Color.White : lblsess.ForeColor = Color.Firebrick
                sestimer.Stop()
                lblsess.Text = (CInt(lblsess.Text.Split(" / ")(0)) - 1) & " / " & SessCount
            End If
            tdbcourses.UpdateData()
            studentcount()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbcourses_ColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbcourses.ColEdit
        lcchanges = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            If Not dtcourse Is Nothing Then dtcourse.Clear()
            CbProff.SelectedIndex = -1
            CbCourse.SelectedIndex = -1
            lcchanges = False : studentcount() : Button1.Enabled = False : btnModify.Enabled = True : btnCancel.Enabled = False : btnSave.Enabled = False
            ClearControls(Me, "", Nothing) : CbProff.Enabled = False : tdbcourses.Enabled = False
            BtnSchedule.Enabled = False
            LblCount.Text = "" : LblPrice.Text = "" : LblProfNO.Text = "" : LblStudentNo.Text = ""
            If Not dtsession Is Nothing Then dtsession = Nothing
            lblsess.Text = "" : lblsess.BackColor = Color.White : sestimer.Stop()
            GrpMode.Visible = False
            GrpMode.SendToBack()
            RbAdd.Checked = True
            LblMode.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbcourses_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles tdbcourses.FetchCellStyle
        Try
            If e.Col = 1 Then
                If tdbcourses.Splits(0).DisplayColumns("chk").DataColumn.Text = "True" Then
                    e.CellStyle.BackColor = Color.Firebrick
                Else
                    'e.CellStyle.BackColor = System
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub studentcount()
        Try
            If Not dtcourse Is Nothing AndAlso dtcourse.Rows.Count = 0 Then
                LblCount.Text = "0 / 0"
            Else
                LblCount.Text = dtcourse.DefaultView.ToTable.Compute("count(std_id)", "chk=true") & "/" & dtcourse.DefaultView.Count
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub getInfo()
    '    Dim strsql As String
    '    Dim cnsql As SqlConnection
    '    Dim cmsql As SqlCommand
    '    Dim drsql As SqlDataReader
    '    Try
    '        strsql = "select "
    '        strsql &= "case when not scd_MondFrom IS null then  scd_MondFrom else '-----------'end as scd_MondFrom,"
    '        strsql &= "case when not scd_TueFrom IS null then  scd_TueFrom else '------------'end as scd_TueFrom,"
    '        strsql &= "case when not scd_WedFrom IS null then  scd_WedFrom else '-----------'end as scd_WedFrom,"
    '        strsql &= "case when not scd_ThurFrom IS null then  scd_ThurFrom else '-----------'end as scd_ThurFrom,"
    '        strsql &= "case when not scd_FridFrom IS null then  scd_FridFrom else '-----------'end as scd_FridFrom,"
    '        strsql &= "case when not scd_SatFrom IS null then  scd_SatFrom else '-----------'end as scd_SatFrom,"

    '        strsql &= "case when not scd_Mondto IS null then  scd_Mondto else '-----------'end as scd_Mondto,"
    '        strsql &= "case when not scd_Tueto IS null then  scd_Tueto else '-----------'end as scd_Tueto,"
    '        strsql &= "case when not scd_Wedto IS null then  scd_Wedto else '-----------'end as scd_Wedto,"
    '        strsql &= "case when not scd_Thurto IS null then  scd_Thurto else '-----------'end as scd_Thurto,"
    '        strsql &= "case when not scd_Fridto IS null then  scd_Fridto else '-----------'end as scd_Fridto,"
    '        strsql &= "case when not scd_Satto IS null then  scd_Satto else '-----------'end as scd_Satto "

    '        strsql &= "from tbl_schedule where scd_ProfID= " & CbProff.SelectedValue

    '        cnsql = New SqlConnection(constr)
    '        cnsql.Open()

    '        cmsql = New SqlCommand(strsql, cnsql)
    '        drsql = cmsql.ExecuteReader

    '        LblSchedHeader.Text = "Monday     Tuesday     Wednesday     Thursday     Friday     Saturday"

    '        If drsql.HasRows Then
    '            drsql.Read()
    '            LblSched.Text = drsql.Item("scd_MondFrom") & "          " & drsql.Item("scd_TueFrom") & "         " & drsql.Item("scd_WedFrom") & "          " & drsql.Item("scd_ThurFrom") & "         " & drsql.Item("scd_FridFrom") & "         " & drsql.Item("scd_SatFrom") & vbCrLf
    '            LblSched.Text &= drsql.Item("scd_Mondto") & "          " & drsql.Item("scd_Tueto") & "         " & drsql.Item("scd_Wedto") & "          " & drsql.Item("scd_Thurto") & "         " & drsql.Item("scd_Fridto") & "         " & drsql.Item("scd_Satto") & vbCrLf
    '            drsql.Close()
    '        End If


    '        strsql = "select "
    '        Button1.Enabled = True
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
    '        cmsql = Nothing : drsql = Nothing
    '    End Try
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If dtcourse.DefaultView.RowFilter.Length = 0 Then
                dtcourse.DefaultView.RowFilter = "Chk= 'True' or (chk='False' and  prfname is null)"
                Button1.Text = "+"
            Else
                dtcourse.DefaultView.RowFilter = ""
                Button1.Text = "-"
            End If
            studentcount()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup
        ToolTip1.UseAnimation = True
    End Sub

    Private Sub Button1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Enter
        ToolTip1.SetToolTip(Button1, "")
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        Try
            Button1.BackColor = Color.Yellow : Button1.ForeColor = Color.Black
            If Button1.Text = "-" Then
                ToolTip1.SetToolTip(Button1, "Show Only Students Not registred with other Courses")
            Else
                ToolTip1.SetToolTip(Button1, "Show All Students ")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Crimson : Button1.ForeColor = Color.White
    End Sub

    Private Sub FillCbCourse()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim Dasql As SqlDataAdapter
        Dim Dt As DataTable

        Try
            strsql = "select '' as [Code],'Select A Course' as [Desc] union select Crs_Code,Crs_Desc from dbo.tbl_courses where Crs_Actice='A'"
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            Dasql = New SqlDataAdapter(strsql, cnsql)
            Dt = New DataTable
            Dasql.Fill(Dt)

            CbCourse.DataSource = Dt

            CbCourse.ValueMember = "Code"
            CbCourse.DisplayMember = "Desc"

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            Dasql = Nothing : Dt = Nothing
        End Try
    End Sub

    Private Sub CbCourse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbCourse.Click
        Try
            If CbCourse.SelectedIndex > 0 Then

                If MessageBox.Show("Do you want to Discard changes without saving ", lctitle, MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    Exit Try
                Else
                    CbCourse.DroppedDown = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbCourse.SelectedIndexChanged
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader
        Dim strsql As String
        Try
            If CbCourse.SelectedIndex > 0 Then
                dtsession = Nothing
                If Not dtcourse Is Nothing Then dtcourse.Clear() : studentcount()
                lblsess.BackColor = Color.White : sestimer.Stop()

                strsql = " select Crs_Code,cast(min(Crs_Price)as numeric(4,0)) as [Price],COUNT(PrfCrs_Prof) as [#Prof], "
                strsql &= "(select COUNT(PrS_Stdid) from tbl_profStdCrs left join tbl_Students on std_id=PrS_Stdid  where Prs_Crs=Crs_Code And std_status='A') as [#Students]  "
                strsql &= "from dbo.tbl_courses "
                strsql &= "left join tbl_ProfCourse on PrfCrs_Crs=Crs_Code "
                strsql &= "where Crs_Code= '" & CbCourse.SelectedValue & "' "
                strsql &= "group by Crs_Code"
                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                drsql = cmsql.ExecuteReader

                If drsql.HasRows Then
                    drsql.Read()

                    LblPrice.Text = drsql.Item("Price") & "  $"
                    LblProfNO.Text = drsql.Item("#Prof")
                    LblStudentNo.Text = drsql.Item("#Students")

                    drsql.Close()
                End If
                CbProff.Enabled = True : BtnSchedule.Enabled = True
                fillComboBox()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : drsql = Nothing
        End Try
    End Sub

    Private Sub BtnSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSchedule.Click
        Dim frm As frmSchedules
        Try
            frm = New frmSchedules
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show("&B-Students Courses", CbProff.SelectedValue, CbProff.Text, , CbCourse.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SessionsCount()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand

        Try

            strsql = "select  cast((select COUNT(Ses_ProfId) from tbl_sessions t where Ses_StdId is not  null "
            strsql &= "and  t.Ses_ProfId=tbl_sessions.Ses_ProfId And t.Ses_CrsCode=tbl_sessions.Ses_CrsCode) as varchar(8))  "
            strsql &= "+'|' + cast(COUNT(Ses_ProfId) as varchar(8)) from tbl_sessions "
            strsql &= "where Ses_ProfId = " & CbProff.SelectedValue & " And Ses_CrsCode='" & CbCourse.SelectedValue & "'"
            strsql &= " group by Ses_ProfId,Ses_CrsCode "
            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)


            If cmsql.ExecuteScalar Is Nothing Then
                SessCount = 0
            Else
                SessCount = cmsql.ExecuteScalar.ToString.Split("|"c)(1)
            End If



            lblsess.Text = "" : lblsess.BackColor = Color.White : lblsess.ForeColor = Color.Firebrick : sestimer.Stop()

            If Not cmsql.ExecuteScalar Is Nothing Then
                If CInt(cmsql.ExecuteScalar.ToString.Split("|"c)(0)) >= SessCount Then
                    sestimer.Start()
                End If
            End If


            If cmsql.ExecuteScalar Is Nothing Then
                lblsess.Text = "0 / " + SessCount
                sestimer.Start()
            Else
                lblsess.Text = cmsql.ExecuteScalar.ToString.Split("|"c)(0) + " / " + SessCount
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub sestimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sestimer.Tick
        If lblsess.BackColor = Color.White Then
            lblsess.BackColor = Color.Firebrick
            lblsess.ForeColor = Color.White
        Else
            lblsess.BackColor = Color.White
            lblsess.ForeColor = Color.Firebrick
        End If
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            EnableDisable(Me, True)
            btnSave.Enabled = True : btnCancel.Enabled = True
            FillCbCourse() : btnModify.Enabled = False
            CbProff.Enabled = False
            GrpMode.Visible = False
            GrpMode.SendToBack()
            If RbAdd.Checked = True Then
                LblMode.Text = "ADD"
            Else
                LblMode.Text = "Remove"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbcourses_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbcourses.KeyPress
        Try
            If tdbcourses.FilterActive = False Then


                If Asc(e.KeyChar) <> 43 AndAlso Asc(e.KeyChar) <> 45 AndAlso _
                    Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 Then
                    If Not IsNumeric(e.KeyChar) Then
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class