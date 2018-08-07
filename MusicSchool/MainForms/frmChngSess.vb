Imports System.Data.SqlClient

Public Class frmChngSess
    Dim lctitle As String = "Changing Student Sessions"
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

    Private Sub frmChngSess_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuChgStdSess.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmChngSess_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        btnModify.Enabled = False
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnClose.Enabled = True
        EnableDisable(Me, True)

        cbStudent.Enabled = False
        cbProff.Enabled = False

        FillCbCourse()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            lcchanges = False
            rbSameProf.Checked = True

            ClearControls(Me, "", Nothing)
            EnableDisable(Me, False)

            cbStudent.DataSource = Nothing
            cbStudent.Enabled = False

            CbCourse.DataSource = Nothing
            CbCourse.Enabled = False

            LblProf.Text = ""
            LblProf.Tag = ""


            btnModify.Enabled = True
            btnCancel.Enabled = False
            btnSave.Enabled = False
            btnClose.Enabled = True

            rbSameProf.Checked = True


            tdbSess.ClearFields()
            dtsess = Nothing

            pnlSess.Visible = False
            pnlSess.SendToBack()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dr As DataRow
        Dim Changes As Boolean
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction

        Try

            If Not dtsess Is Nothing Then
                For Each dr In dtsess.Rows
                    If dr.RowState = DataRowState.Modified Then
                        Changes = True
                    End If
                Next

                If Changes = False Then
                    MessageBox.Show("No Changes Made To Save.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Try

                End If

            ElseIf CbCourse.SelectedIndex = 0 Then
                MessageBox.Show("select the Course.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CbCourse.Focus() : CbCourse.DroppedDown = True
                Exit Try

            ElseIf cbStudent.SelectedIndex = 0 Then
                MessageBox.Show("Select The Student.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbStudent.Focus() : cbStudent.DroppedDown = True
                Exit Try
            End If



            cnsql = New SqlConnection(constr)
            cnsql.Open()


            trsql = cnsql.BeginTransaction


            For Each dr In dtsess.Rows
                If dr.RowState = DataRowState.Modified Then

                    strsql = "Update tbl_sessions set Ses_Status='N' , Ses_StdId=NULL Where "
                    strsql &= "Ses_ProfId=" & dr.Item("prf_id") & " And Ses_CrsCode='" & CbCourse.SelectedValue & "'"
                    strsql &= " And Ses_Counter=" & dr.Item("OldCnt") & ";"

                    strsql &= "Update tbl_sessions set Ses_Status='B' , Ses_StdId=" & cbStudent.SelectedValue & " Where "

                    If rbSameProf.Checked = True Then
                        strsql &= "Ses_ProfId=" & dr.Item("prf_id") & " And Ses_CrsCode='" & CbCourse.SelectedValue & "'"
                    Else
                        strsql &= "Ses_ProfId=" & cbProff.SelectedValue & " And Ses_CrsCode='" & CbCourse.SelectedValue & "'"
                    End If

                    strsql &= " And Ses_Counter=" & dr.Item("NewCnt") & " "

                    If rbOtherProf.Checked = True Then
                        strsql &= " ; Update tbl_profStdCrs set PrS_Prf=" & cbProff.SelectedValue & " , prs_datestmp=getdate() "
                        strsql &= " Where Prs_Crs='" & CbCourse.SelectedValue & "' And PrS_Stdid=" & cbStudent.SelectedValue
                    End If

                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                End If
            Next


            trsql.Commit()

            MessageBox.Show("Modifications Successfully saved ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
           
            btnCancel_Click(btnCancel, New System.EventArgs)

        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : cmsql = Nothing : trsql = Nothing
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmChngSess_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmChngSess_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            pnlSess.Visible = False
            pnlSess.SendToBack()



        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub fillCbProff()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Try
            strsql = "Select -5 as prf_id ,'Select an Professor' as prf_name from tbl_instruments "
            strsql &= "union select prf_id,prf_name+ ' '+ prf_lname as prf_name  from tbl_professors  "
            strsql &= "inner join  tbl_ProfCourse on PrfCrs_Prof=prf_id "
            strsql &= " where prf_status='A' and PrfCrs_Crs='" & CbCourse.SelectedValue & "'"
            strsql &= " And prf_id not in(" & LblProf.Tag.ToString & ")"

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

    Private Sub fillCBStd()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Try
            strsql = "select -20 as Std_id , 'Select A Student' as name  union select distinct Std_id , "
            strsql &= "cast(Std_id as varchar(9)) +'  -  ' + std_name+' '+std_Lname as [name] from tbl_Students "
            strsql &= "Inner Join tbl_profStdCrs on PrS_Stdid=std_id and Prs_Crs='" & CbCourse.SelectedValue & "'"
            strsql &= "where std_status = 'A' "
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            da = New SqlDataAdapter(strsql, cnsql)
            dt = New DataTable
            da.Fill(dt)

            cbStudent.DataSource = dt

            cbStudent.ValueMember = "Std_id"
            cbStudent.DisplayMember = "name"

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub Cb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbCourse.Click, cbStudent.Click
        Try
            If CType(sender, ComboBox).SelectedIndex > 0 AndAlso lcchanges = True Then

                If MessageBox.Show("Do you want to Discard changes without saving ", lctitle, MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    Exit Try
                Else
                    ClearForm()
                    lcchanges = False : CType(sender, ComboBox).DroppedDown = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOtherProf.CheckedChanged, rbSameProf.CheckedChanged
        Try
            If sender Is rbOtherProf Then
                cbProff.Enabled = True
                fillCbProff()
            Else
                cbProff.Enabled = False
                cbProff.DroppedDown = False
                cbProff.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbCourse.SelectedIndexChanged
        Try
            If CbCourse.SelectedIndex > 0 Then
                fillCBStd()
                cbStudent.Enabled = True
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
    Private Sub cbStudent_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbStudent.SelectedIndexChanged
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader

        Try
            If cbStudent.SelectedIndex > 0 Then

                strsql = "select PrS_Prf , prf_name+' '+prf_lname as [Name] from tbl_profStdCrs "
                strsql &= "inner join tbl_professors on PrS_Prf=prf_id where PrS_Stdid=" & cbStudent.SelectedValue & " and Prs_Crs='" & CbCourse.SelectedValue & "'"

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                drsql = cmsql.ExecuteReader

                LblProf.Text = ""
                LblProf.Tag = ""

                If drsql.HasRows = True Then
                    While drsql.Read
                        LblProf.Text = LblProf.Text & drsql.Item("Name") & " | "
                        LblProf.Tag = LblProf.Tag & drsql.Item("PrS_Prf") & ","
                    End While

                    LblProf.Text = LblProf.Text.Substring(0, LblProf.Text.Length - 3)
                    LblProf.Tag = LblProf.Tag.Substring(0, LblProf.Tag.Length - 1)
                End If


                fillGrid()


                lcchanges = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : drsql = Nothing
        End Try
    End Sub
    Private Sub fillgrid()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim dasql As SqlDataAdapter
        Dim i As Integer

        Try
            strsql = "select prf_id,Ses_Counter as [OldCnt], prf_name+' '+prf_lname as Name  ,DATEname(WEEKDAY,Ses_StartTime) as [Day], "
            strsql &= "Ses_StartTime, Ses_EndTime , NULL as [NewProfName],NULL as [NewCnt] , NULL as [NewDay] , NULL as [NewStrTime] , "
            strsql &= " NULL as [NewEdTime] , NuLL as [NewStrDate] , NULL as [NewEdDate] ,'Y' as [Show]  "
            strsql &= "from tbl_sessions  "
            strsql &= "inner join  tbl_professors on Ses_ProfId=prf_id "
            strsql &= "where Ses_StdId=" & cbStudent.SelectedValue & " and Ses_CrsCode='" & CbCourse.SelectedValue & "'  "

            strsql &= " Union "
            strsql &= "select  NULL,NULL ,NULL,NULL,NULL,NULL,'s',11,'dd',getdate(),getdate(),getdate(),getdate(),'N' "

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            dasql = New SqlDataAdapter(strsql, cnsql)

            dtsess = New DataTable
            dasql.Fill(dtsess)

            tdbSess.DataSource = dtsess.DefaultView
            dtsess.DefaultView.RowFilter = "Show='Y'"

            With tdbSess.Splits(0)
                .ColumnCaptionHeight = 25
                .CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .CaptionStyle.ForeColor = Color.Maroon

                .DisplayColumns("prf_id").AllowSizing = False
                .DisplayColumns("prf_id").Visible = False
                .DisplayColumns("prf_id").Width = 0

                .DisplayColumns("OldCnt").AllowSizing = False
                .DisplayColumns("OldCnt").Visible = False
                .DisplayColumns("OldCnt").Width = 0

                .DisplayColumns("NewCnt").AllowSizing = False
                .DisplayColumns("NewCnt").Visible = False
                .DisplayColumns("NewCnt").Width = 0

                .DisplayColumns("Show").AllowSizing = False
                .DisplayColumns("Show").Visible = False
                .DisplayColumns("Show").Width = 0

                .DisplayColumns("Ses_StartTime").DataColumn.Caption = "Start Time"
                .DisplayColumns("Ses_StartTime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Ses_StartTime").Width = 90
                .DisplayColumns("Ses_StartTime").DataColumn.NumberFormat = ("hh:mm tt")
                .DisplayColumns("Ses_StartTime").Style.BackColor = Color.LightCyan
                .DisplayColumns("Ses_StartTime").AllowSizing = False

                .DisplayColumns("Ses_EndTime").DataColumn.Caption = "End Time"
                .DisplayColumns("Ses_EndTime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Ses_EndTime").Width = 90
                .DisplayColumns("Ses_EndTime").DataColumn.NumberFormat = ("hh:mm tt")
                .DisplayColumns("Ses_EndTime").Style.BackColor = Color.LightCyan
                .DisplayColumns("Ses_EndTime").AllowSizing = False

                .DisplayColumns("Day").DataColumn.Caption = "Day"
                .DisplayColumns("Day").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Day").Width = 90
                .DisplayColumns("Day").Style.BackColor = Color.LightCyan
                .DisplayColumns("Day").AllowSizing = False


                .DisplayColumns("Name").DataColumn.Caption = "Professor Name"
                .DisplayColumns("Name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                .DisplayColumns("Name").Width = 120
                .DisplayColumns("Name").AllowSizing = False
                .DisplayColumns("Name").Style.BackColor = Color.LightCyan



                .DisplayColumns("NewProfName").DataColumn.Caption = "Professor Name"
                .DisplayColumns("NewProfName").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                .DisplayColumns("NewProfName").Width = 120
                .DisplayColumns("NewProfName").AllowSizing = False
                .DisplayColumns("NewProfName").Style.BackColor = Color.LightYellow

                .DisplayColumns("NewDay").DataColumn.Caption = "Day"
                .DisplayColumns("NewDay").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("NewDay").Width = 90
                .DisplayColumns("NewDay").Style.BackColor = Color.LightYellow
                .DisplayColumns("NewDay").AllowSizing = False



                .DisplayColumns("NewEdTime").DataColumn.Caption = "End Time"
                .DisplayColumns("NewEdTime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("NewEdTime").Width = 90
                .DisplayColumns("NewEdTime").DataColumn.NumberFormat = ("hh:mm tt")
                .DisplayColumns("NewEdTime").Style.BackColor = Color.LightYellow
                .DisplayColumns("NewEdTime").AllowSizing = False


                .DisplayColumns("NewStrTime").DataColumn.Caption = "Start Time"
                .DisplayColumns("NewStrTime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("NewStrTime").Width = 90
                .DisplayColumns("NewStrTime").DataColumn.NumberFormat = ("hh:mm tt")
                .DisplayColumns("NewStrTime").Style.BackColor = Color.LightYellow
                .DisplayColumns("NewStrTime").AllowSizing = False


                .DisplayColumns("NewStrDate").AllowSizing = False
                .DisplayColumns("NewStrDate").Visible = False
                .DisplayColumns("NewStrDate").Width = 0


                .DisplayColumns("NewEdDate").AllowSizing = False
                .DisplayColumns("NewEdDate").Visible = False
                .DisplayColumns("NewEdDate").Width = 0


            End With


            For Each column In tdbSess.Splits(0).DisplayColumns
                tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                i = i + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            dasql = Nothing
        End Try
    End Sub

    Private Sub ClearForm()
        Try

            If Me.ActiveControl Is cbStudent Then
                rbSameProf.Checked = True
            ElseIf Me.ActiveControl Is CbCourse Then
                rbSameProf.Checked = True
                cbStudent.DataSource = Nothing
                cbStudent.Enabled = False
            End If

            LblProf.Text = ""
            LblProf.Tag = ""
            tdbSess.ClearFields()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pnlSess.Visible = False
        pnlSess.SendToBack()
    End Sub

    Private Sub tdbSess_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbSess.DoubleClick
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim dasql As SqlDataAdapter
        Dim dt As DataTable
        Dim i As Integer

        Try

            If tdbSess.SelectedRows.Count = 1 Then

                If rbOtherProf.Checked = True AndAlso cbProff.SelectedIndex = 0 Then
                    MessageBox.Show("Select The Replacement Professor.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cbProff.Focus() : cbProff.DroppedDown = True : Exit Try
                End If

                strsql = "select Top 1 1 from tbl_sessions "

                If rbSameProf.Checked = False Then
                    strsql &= "where Ses_ProfId=" & cbProff.SelectedValue & " "
                    strsql &= "and Ses_CrsCode='" & CbCourse.SelectedValue & "' and Ses_StdId is null "
                Else
                    strsql &= "where Ses_ProfId=" & tdbSess.Splits(0).DisplayColumns("prf_id").DataColumn.Text & " "
                    strsql &= "and Ses_CrsCode='" & CbCourse.SelectedValue & "' and Ses_StdId is null "
                End If


                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)

                If cmsql.ExecuteScalar Is Nothing OrElse cmsql.ExecuteScalar.ToString = "" Then
                    If rbSameProf.Checked = True Then
                        MessageBox.Show("No Available Sessions For This Professor: " & tdbSess.Splits(0).DisplayColumns(1).DataColumn.Text, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        MessageBox.Show("No Available Sessions For The selected Professor:" & cbProff.Text, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                    Exit Try
                End If

                If rbSameProf.Checked = True Then
                    lblSelecProf.Text = tdbSess.Splits(0).DisplayColumns(1).DataColumn.Text
                Else
                    lblSelecProf.Text = cbProff.Text
                End If

                strsql = "select Ses_ProfId , DATENAME(WEEKDAY,ses_startTime) as [Day] , Ses_StartTime as [strTime] ,"
                strsql &= "Ses_EndTime as [endtime] ,  Ses_StartTime as [strDate] ,Ses_EndTime as [enddate] ,Ses_Counter "
                strsql &= "from tbl_sessions "
                strsql &= "inner join tbl_professors on prf_id=Ses_ProfId "
                If rbSameProf.Checked = True Then
                    strsql &= "where Ses_CrsCode='" & CbCourse.SelectedValue & "' and Ses_ProfId=" & tdbSess.Splits(0).DisplayColumns(0).DataColumn.Text
                Else
                    strsql &= "where Ses_CrsCode='" & CbCourse.SelectedValue & "' and Ses_ProfId=" & cbProff.SelectedValue
                End If

                strsql &= " and Ses_StdId is null "
                strsql &= "order by prf_name, DATEpart(DW,ses_startTime) "

                dasql = New SqlDataAdapter(strsql, cnsql)
                dt = New DataTable

                dasql.Fill(dt)

                TdbAvSess.DataSource = dt.DefaultView

                With TdbAvSess.Splits(0)
                    .ColumnCaptionHeight = 25
                    .CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .CaptionStyle.ForeColor = Color.Maroon

                    .DisplayColumns("Ses_ProfId").AllowSizing = False
                    .DisplayColumns("Ses_ProfId").Visible = False
                    .DisplayColumns("Ses_ProfId").Width = 0

                    .DisplayColumns("strDate").AllowSizing = False
                    .DisplayColumns("strDate").Visible = False
                    .DisplayColumns("strDate").Width = 0

                    .DisplayColumns("Ses_Counter").AllowSizing = False
                    .DisplayColumns("Ses_Counter").Visible = False
                    .DisplayColumns("Ses_Counter").Width = 0


                    .DisplayColumns("enddate").AllowSizing = False
                    .DisplayColumns("enddate").Visible = False
                    .DisplayColumns("enddate").Width = 0

                    .DisplayColumns("strTime").DataColumn.Caption = "Start Time"
                    .DisplayColumns("strTime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("strTime").Width = 120
                    .DisplayColumns("strTime").DataColumn.NumberFormat = ("hh:mm tt")
                    .DisplayColumns("strTime").AllowSizing = False

                    .DisplayColumns("endtime").DataColumn.Caption = "End Time"
                    .DisplayColumns("endtime").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("endtime").Width = 120
                    .DisplayColumns("endtime").DataColumn.NumberFormat = ("hh:mm tt")
                    .DisplayColumns("endtime").AllowSizing = False

                    .DisplayColumns("Day").DataColumn.Caption = "Day"
                    .DisplayColumns("Day").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Day").Width = 150
                    .DisplayColumns("Day").AllowSizing = False
                    .DisplayColumns("Day").Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Free



                End With


                For Each column In TdbAvSess.Splits(0).DisplayColumns
                    TdbAvSess.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    TdbAvSess.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                    TdbAvSess.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                    i = i + 1
                Next


                pnlSess.Visible = True
                pnlSess.BringToFront()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cnsql = Nothing : dasql = Nothing : dt = Nothing
        End Try
    End Sub

    Private Sub TdbAvSess_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TdbAvSess.DoubleClick
        Try

            If TdbAvSess.SelectedRows.Count = 1 Then

                If MessageBox.Show("Are You Sure Do You Want To Replace The Current Session With this New Session", _
                                   lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    tdbSess.Splits(0).DisplayColumns("NewStrDate").DataColumn.Text = TdbAvSess.Splits(0).DisplayColumns("strDate").DataColumn.Text
                    tdbSess.Splits(0).DisplayColumns("NewEdDate").DataColumn.Text = TdbAvSess.Splits(0).DisplayColumns("enddate").DataColumn.Text
                    tdbSess.Splits(0).DisplayColumns("NewDay").DataColumn.Text = TdbAvSess.Splits(0).DisplayColumns("Day").DataColumn.Text
                    tdbSess.Splits(0).DisplayColumns("NewStrTime").DataColumn.Text = TdbAvSess.Splits(0).DisplayColumns("strTime").DataColumn.Text
                    tdbSess.Splits(0).DisplayColumns("NewEdTime").DataColumn.Text = TdbAvSess.Splits(0).DisplayColumns("endtime").DataColumn.Text

                    tdbSess.Splits(0).DisplayColumns("NewCnt").DataColumn.Text = TdbAvSess.Splits(0).DisplayColumns("Ses_Counter").DataColumn.Text

                    If rbSameProf.Checked = True Then
                        tdbSess.Splits(0).DisplayColumns("NewProfName").DataColumn.Text = tdbSess.Splits(0).DisplayColumns("prf_name").DataColumn.Text
                    Else
                        tdbSess.Splits(0).DisplayColumns("NewProfName").DataColumn.Text = cbProff.SelectedText
                    End If


                    tdbSess.UpdateData()

                    Button1_Click(Button1, New System.EventArgs)

                Else
                    Exit Try
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class