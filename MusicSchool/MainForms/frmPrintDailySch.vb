Imports System.Data.SqlClient
Public Class frmPrintDailySch
    Dim lctitle As String = "Form Daily School Schedule."
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked As Boolean
    Dim RptTmp As String
    Dim dtProf, dtCour As DataTable
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub frmPrintStd_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuDaiSchoolSch.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPrintStd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPrintStd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim today As Date = Now.Date
        Dim dayIndex As Integer = Now.DayOfWeek
        Dim daydiff As Integer = dayIndex - DayOfWeek.Monday

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

            'EnableDisable(Me, False)

            If lcView = False Then
                EnableMenuButton(Me, False, {btnClose})
            End If

            btnShow.Enabled = lcView


            LblYear.Text = Now.Year : LblMonth.Text = MonthName(Now.Month)

            If dayIndex < DayOfWeek.Monday Then
                dayIndex += 7
            End If



            LblStrDate.Text = CDate(today.AddDays(-daydiff)).ToString("dd/MM/yyyy")
            LblEndDate.Text = Format(CDate(today.AddDays(-daydiff)).AddDays(5), "dd/MM/yyyy")

            fillTdbProf() : fillTdbCrs()

            RptTmp = frmMain.MnuDaiSchoolSch.Text.Replace(" ", "").Substring(3) & "_" & usercode

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            EnableDisable(Me, True)
            btnShow.Enabled = True 'btnCancel.Enabled = True
            ' btnModify.Enabled = False : cbYear.Text = Now.Year
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmProfPay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                ' Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                ' Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                Case Keys.F10 : If btnShow.Enabled Then btnShow_Click(btnShow, New System.EventArgs)
                Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        RbAll.Checked = True
    '        cbMonthFrom.Text = "" : CbMonthTo.Text = "" : cbMonthFrom.SelectedIndex = -1 : CbMonthTo.SelectedIndex = -1
    '        cbYear.SelectedIndex = -1
    '        btnCancel.Enabled = False : btnShow.Enabled = False : btnModify.Enabled = True
    '        ErrorProvider1.SetError(cbMonthFrom, "") : ErrorProvider1.SetError(CbMonthTo, "")
    '        EnableDisable(Me, False)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strsql As String
        Dim frm As frmPrintTmp
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim Fields(0, 1) As String
        Dim ctrl As Control
        Dim chkChecked As Boolean = False
        Dim strPrfo As String
        Dim strCor As String
        Dim strDay As String
        Dim dr As DataRow

        Try

            If dtProf.Select("Chk=True").Length <= 0 Then
                MessageBox.Show("Select At Least One Professor", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tdbProf.Focus() : tdbProf.Col = 0 : tdbProf.Row = 0 : Exit Try
            End If

            If dtCour.Select("Chk=True").Length <= 0 Then
                MessageBox.Show("Select At Least One Course", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TdbCourse.Focus() : TdbCourse.Col = 0 : TdbCourse.Row = 0 : Exit Try
            End If


            For Each ctrl In Pnldate.Controls
                If ctrl.GetType Is GetType(CheckBox) Then
                    If CType(ctrl, CheckBox).Checked = True Then
                        chkChecked = True : Exit For
                    End If
                End If
            Next

            If chkChecked = False Then
                MessageBox.Show("Select At Least One Day", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ChkMond.Focus() : Exit Try
            End If

            strPrfo = ""
            For Each dr In dtProf.Select("Chk=True")
                strPrfo = strPrfo & dr.Item("prf_id") & ","
            Next
            strPrfo = strPrfo.Substring(0, strPrfo.Length - 1)



            strCor = ""
            For Each dr In dtCour.Select("Chk=True")
                strCor = strCor & "'" & dr.Item("Code") & "',"
            Next
            strCor = strCor.Substring(0, strCor.Length - 1)



            strDay = ""
            For Each ctrl In Pnldate.Controls
                If ctrl.GetType Is GetType(CheckBox) Then
                    If CType(ctrl, CheckBox).Checked = True Then
                        strDay = strDay & CType(ctrl, CheckBox).Tag & ","
                    End If
                End If
            Next
            strDay = strDay.Substring(0, strDay.Length - 1)




            strsql = "if exists (select top 1 1 from sys.tables where name='" & RptTmp & "') drop table " & RptTmp

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteNonQuery()


            strsql = "Select * into " & RptTmp & " From ("
            strsql &= " select distinct datepart(dw,Ses_StartTime)-1 as [DW],datename(dw,Ses_StartTime) as [Day], Ses_ProfId , prf_name +' '+prf_lname as [ProfName], "
            strsql &= "Ses_StartTime as [StrTime] ,Ses_EndTime as [EndTime] , Ses_CrsCode, Crs_Desc as [CrsName] , Rom_Name , std_id, "
            strsql &= "std_name+' '+std_Lname as [StdName] , case when not Vct_desc IS null then 'Y' Else 'N' end as [Vacation]  , Vct_desc , "
            strsql &= "case when  MngSess_ProfId Is not null then 'Y' else 'N' End as [Missing] "
            strsql &= "from tbl_sessions  "
            strsql &= "right join ( "
            strsql &= "select 1 as [Day] union select 2 as [Day] "
            strsql &= "union select 3 as [Day]  union select 4 as [Day] "
            strsql &= "union select 5 as [Day]  union select 6 as [Day] "
            strsql &= ")t on [Day]=datepart(dw,Ses_StartTime)-1 "
            strsql &= "Inner join tbl_professors on prf_id=Ses_ProfId  "
            strsql &= "Left join tbl_Classes on Cls_Session=Ses_Counter and Ses_ProfId=Cls_Prof  "
            strsql &= "left join tbl_Room on Rom_code=Cls_Room "
            strsql &= "left join tbl_courses on Crs_Code=Ses_CrsCode "
            strsql &= "left join tbl_Students on Ses_StdId=std_id  "
            strsql &= "Left Join tbl_vacations on Vct_Startdate=CONVERT(datetime,CONVERT(varchar(10),Ses_StartTime,101))  "
            strsql &= "Left join tbl_ReplaSession on MngSess_ProfId=Ses_ProfId and MngSess_StrDate=Ses_StartTime  "

            strsql &= "where  Ses_ProfId in(" & strPrfo & ") "
            strsql &= " And Day in (" & strDay & ") "
            strsql &= " And Ses_CrsCode in (" & strCor & ") "


            strsql &= ")TBL "
            'strsql &= "order by datepart(dw,Ses_StartTime)-1 , Ses_StartTime  "



            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()






            strsql = "select * from " & RptTmp & "  "

            If ChkStd.Checked = False Then
                strsql &= "Where Not std_id is null "
            End If


            strsql &= " order by DW , "

            If rbTime.Checked Then
                strsql &= " StrTime "
            ElseIf rbCourse.Checked Then
                strsql &= " Ses_CrsCode "
            ElseIf RbProff.Checked Then
                strsql &= " Ses_ProfId "
            Else
                strsql &= " std_id "
            End If

            


            'Fields(0, 0) = "foStatus"
            'If rbNotPaid.Checked = True Then
            '    Fields(0, 1) = "'N'"
            'ElseIf RbPaid.Checked = True Then
            '    Fields(0, 1) = "'Y'"
            'Else
            '    Fields(0, 1) = "'ALL'"
            'End If

            'Fields(1, 0) = "foMonth1" : Fields(1, 1) = "'" & cbMonthFrom.Text & "'"
            'Fields(2, 0) = "foMonth2" : Fields(2, 1) = "'" & CbMonthTo.Text & "'"
            'Fields(3, 0) = "foYear" : Fields(3, 1) = "'" & cbYear.Text & "'"
            Fields(0, 0) = "foUsrName" : Fields(0, 1) = "'" & username & "'"

            frm = New frmPrintTmp

            frm.ShowDialog("rptDailySched.rpt", strsql, Fields)

            strsql = "if exists (select top 1 1 from sys.tables where name='" & RptTmp & "') drop table " & RptTmp
            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub fillTdbProf()
        Dim cnsql As SqlConnection
        Dim Dasql As SqlDataAdapter
        Dim strsql As String
        Dim i As Integer

        Try


            strsql = "select 'True' as [Chk], prf_id , prf_name +' '+ prf_lname as [name]  from tbl_professors where prf_status='A' order by prf_id"

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            Dasql = New SqlDataAdapter(strsql, cnsql)

            dtProf = New DataTable

            Dasql.Fill(dtProf)

            tdbProf.DataSource = dtProf.DefaultView


            tdbProf.CaptionStyle.BackColor = Color.Wheat
            tdbProf.CaptionStyle.ForeColor = Color.Maroon
            tdbProf.CaptionStyle.Font = New Font("calibri", 12, FontStyle.Bold)

            With tdbProf.Splits(0)
                .ColumnCaptionHeight = 25
                '.CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                '.CaptionStyle.ForeColor = Color.Maroon


                .DisplayColumns("Chk").DataColumn.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                .DisplayColumns("Chk").DataColumn.Caption = ""
                .DisplayColumns("Chk").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Chk").Width = 20
                .DisplayColumns("Chk").AllowSizing = False
                .DisplayColumns("Chk").Locked = False


                .DisplayColumns("prf_id").DataColumn.Caption = "Prof ID"
                .DisplayColumns("prf_id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("prf_id").Width = 70
                .DisplayColumns("prf_id").AllowSizing = False
                .DisplayColumns("prf_id").Locked = True


                .DisplayColumns("Name").DataColumn.Caption = "Prof Name"
                .DisplayColumns("Name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                .DisplayColumns("Name").Width = 185
                .DisplayColumns("Name").AllowSizing = False
                .DisplayColumns("Name").Locked = True


            End With


            For Each column In tdbProf.Splits(0).DisplayColumns
                tdbProf.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                tdbProf.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                tdbProf.Splits(0).DisplayColumns(i).HeadingStyle.BackColor = Color.FromArgb(255, 255, 192)
                tdbProf.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                i = i + 1
            Next




        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            Dasql = Nothing
        End Try
    End Sub


    Private Sub fillTdbCrs()
        Dim cnsql As SqlConnection
        Dim Dasql As SqlDataAdapter
        Dim strsql As String
        Dim i As Integer

        Try


            strsql = "select 'True' as [Chk] , Crs_Code as [Code] , Crs_Desc as [Desc] from tbl_courses where Crs_Actice='A' order by Crs_Code "

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            Dasql = New SqlDataAdapter(strsql, cnsql)

            dtCour = New DataTable

            Dasql.Fill(dtCour)

            TdbCourse.DataSource = dtCour.DefaultView


            TdbCourse.CaptionStyle.BackColor = Color.Wheat
            TdbCourse.CaptionStyle.ForeColor = Color.Maroon
            TdbCourse.CaptionStyle.Font = New Font("calibri", 12, FontStyle.Bold)

            With TdbCourse.Splits(0)
                .ColumnCaptionHeight = 25
                '.CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                '.CaptionStyle.ForeColor = Color.Maroon


                .DisplayColumns("Chk").DataColumn.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                .DisplayColumns("Chk").DataColumn.Caption = ""
                .DisplayColumns("Chk").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Chk").Width = 20
                .DisplayColumns("Chk").AllowSizing = False
                .DisplayColumns("Chk").Locked = False


                .DisplayColumns("Code").DataColumn.Caption = "Code"
                .DisplayColumns("Code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Code").Width = 60
                .DisplayColumns("Code").AllowSizing = False
                .DisplayColumns("Code").Locked = True


                .DisplayColumns("Desc").DataColumn.Caption = "Description"
                .DisplayColumns("Desc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                .DisplayColumns("Desc").Width = 180
                .DisplayColumns("Desc").AllowSizing = False
                .DisplayColumns("Desc").Locked = True


            End With


            For Each column In TdbCourse.Splits(0).DisplayColumns
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.BackColor = Color.FromArgb(255, 255, 192)
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                i = i + 1
            Next




        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            Dasql = Nothing
        End Try
    End Sub
    
  
    Private Sub btnChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkProf.Click, BtnChkStd.Click
        Dim dr As DataRow

        Try
            If sender Is btnChkProf Then
                If dtProf Is Nothing Then Exit Try
                If dtProf.Rows.Count <= 0 Then Exit Try

                For Each dr In dtProf.Select(dtProf.DefaultView.RowFilter)
                    dr.Item("Chk") = "True"
                Next

                tdbProf.Refresh()
            Else
                If dtCour Is Nothing Then Exit Try
                If dtCour.Rows.Count <= 0 Then Exit Try

                For Each dr In dtCour.Select(dtCour.DefaultView.RowFilter)
                    dr.Item("Chk") = "True"
                Next
                TdbCourse.Refresh()
            End If
           

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUnchk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnchkProf.Click, btnUnchStd.Click
        Dim dr As DataRow

        Try
            If sender Is btnUnchkProf Then
                If dtProf Is Nothing Then Exit Try
                If dtProf.Rows.Count <= 0 Then Exit Try

                For Each dr In dtProf.Select(dtProf.DefaultView.RowFilter)
                    dr.Item("Chk") = "False"
                Next

                tdbProf.Refresh()
            Else
                If dtCour Is Nothing Then Exit Try
                If dtCour.Rows.Count <= 0 Then Exit Try

                For Each dr In dtCour.Select(dtCour.DefaultView.RowFilter)
                    dr.Item("Chk") = "False"
                Next
                TdbCourse.Refresh()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class