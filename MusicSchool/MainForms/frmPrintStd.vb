Imports System.Data.SqlClient
Public Class frmPrintStd
    Dim lctitle As String = "Form Students report"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked As Boolean
    Dim RptTmp As String
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
            frmMain.MnuRptStd.Checked = False
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
            btnCancel.Enabled = False : btnShow.Enabled = False

            RptTmp = frmMain.MnuRptStd.Text.Replace(" ", "").Substring(3) & "_" & usercode

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            EnableDisable(Me, True)
            btnShow.Enabled = True : btnCancel.Enabled = True
            btnModify.Enabled = False : cbYear.Text = Now.Year
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
                Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                Case Keys.F10 : If btnShow.Enabled Then btnShow_Click(btnShow, New System.EventArgs)
                Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            RbAll.Checked = True
            cbMonthFrom.Text = "" : CbMonthTo.Text = "" : cbMonthFrom.SelectedIndex = -1 : CbMonthTo.SelectedIndex = -1
            cbYear.SelectedIndex = -1
            btnCancel.Enabled = False : btnShow.Enabled = False : btnModify.Enabled = True
            ErrorProvider1.SetError(cbMonthFrom, "") : ErrorProvider1.SetError(CbMonthTo, "")
            EnableDisable(Me, False)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strsql As String
        Dim Mnth1, Mnth2 As Integer
        Dim frm As frmPrintTmp
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim Fields(4, 1) As String


        Try
            If cbMonthFrom.Text = "" Then ErrorProvider1.SetError(cbMonthFrom, "Select Start Month")
            If CbMonthTo.Text = "" Then ErrorProvider1.SetError(CbMonthTo, "Select End Month")
            If cbYear.Text = "" Then ErrorProvider1.SetError(cbYear, "Select The Year")

            If cbMonthFrom.Text = "" OrElse CbMonthTo.Text = "" OrElse cbYear.Text = "" Then Exit Try

            Select Case cbMonthFrom.Text
                Case "January" : Mnth1 = 1
                Case "February" : Mnth1 = 2
                Case "March" : Mnth1 = 3
                Case "April" : Mnth1 = 4
                Case "May" : Mnth1 = 5
                Case "June" : Mnth1 = 6
                Case "July" : Mnth1 = 7
                Case "August" : Mnth1 = 8
                Case "September" : Mnth1 = 9
                Case "October" : Mnth1 = 10
                Case "November" : Mnth1 = 11
                Case "December" : Mnth1 = 12
            End Select

            Select Case CbMonthTo.Text
                Case "January" : Mnth2 = 1
                Case "February" : Mnth2 = 2
                Case "March" : Mnth2 = 3
                Case "April" : Mnth2 = 4
                Case "May" : Mnth2 = 5
                Case "June" : Mnth2 = 6
                Case "July" : Mnth2 = 7
                Case "August" : Mnth2 = 8
                Case "September" : Mnth2 = 9
                Case "October" : Mnth2 = 10
                Case "November" : Mnth2 = 11
                Case "December" : Mnth2 = 12
            End Select


            If Mnth1 > Mnth2 Then
                MessageBox.Show("From Month Must be less or equal to the second month ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbMonthFrom.Focus() : Exit Try
            End If

            strsql = "if exists (select top 1 1 from sys.tables where name='" & RptTmp & "') drop table " & RptTmp

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteNonQuery()

            strsql = "Select * into " & RptTmp & " From( "
            strsql &= " select vch_stdid ,max(std_name+' '+std_Lname) as [Name],Max(std_phoneno) as [Phone] ,vch_month,"
            strsql &= " COUNT(vch_stdid) as [Count]," ' SUM(vch_total) as [Amount] , "
            strsql &= "  SUM(vch_total) +(SUM(isnull(Disc_DiscManount,0))) -  case when isnull(max(Std_Special),'')='Y' then isnull(max(Spc_Amount),0) else 0 end as [Amount], "
            strsql &= "Max(vch_paid) as [Paid],case  vch_month "
            strsql &= "when 'January' then 1 when 'February' then 2 when 'March' then 3 when 'April' then 4 "
            strsql &= "when 'May' then 5 when 'June' then 6 when 'July' then 7 when 'August' then 8 "
            strsql &= "when 'September' then 9 when 'October' then 10 when 'November' then 11 when 'December' then 12 end as [Mnth] "
            strsql &= "  from dbo.tbl_vouchers "
            strsql &= " left join tbl_Students on std_id=vch_stdid "
            strsql &= " left join tbl_SpecMonths on Spc_Month=Vch_NumMonth and Spc_Year=Vch_year "
            strsql &= " left join tbl_ProfStdMnthDisc on Disc_ProfStdId=vch_stdid and Disc_Type='Std' and Disc_Year=Vch_year and Disc_Month=Vch_NumMonth "
            strsql &= "  where "
            strsql &= " Case vch_month "
            strsql &= " when 'January' then 1 when 'February' then 2 when 'March' then 3 when 'April' then 4 "
            strsql &= " when 'May' then 5 when 'June' then 6 when 'July' then 7 when 'August' then 8 "
            strsql &= " when 'September' then 9 when 'October' then 10 when 'November' then 11 when 'December' then 12 "
            strsql &= " end >= " & Mnth1 & " and "
            strsql &= "  Case vch_month "
            strsql &= " when 'January' then 1 when 'February' then 2 when 'March' then 3 when 'April' then 4 "
            strsql &= " when 'May' then 5 when 'June' then 6 when 'July' then 7 when 'August' then 8 "
            strsql &= " when 'September' then 9 when 'October' then 10 when 'November' then 11 when 'December' then 12 "
            strsql &= " end <= " & Mnth2 & " and Vch_year='" & cbYear.Text & "' and std_status='A' "
            If rbNotPaid.Checked = True Then
                strsql &= "And vch_paid='N'"
            ElseIf RbPaid.Checked Then
                strsql &= "And vch_paid='Y'"
            End If
            strsql &= " group by vch_stdid,vch_month,Vch_year "
            'strsql &= " order by Mnth, name"
            strsql &= " )tbl "

            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()


            strsql = "select * from " & RptTmp & " order  by Mnth, name "

            Fields(0, 0) = "foStatus"
            If rbNotPaid.Checked = True Then
                Fields(0, 1) = "'N'"
            ElseIf RbPaid.Checked = True Then
                Fields(0, 1) = "'Y'"
            Else
                Fields(0, 1) = "'ALL'"
            End If

            Fields(1, 0) = "foMonth1" : Fields(1, 1) = "'" & cbMonthFrom.Text & "'"
            Fields(2, 0) = "foMonth2" : Fields(2, 1) = "'" & CbMonthTo.Text & "'"
            Fields(3, 0) = "foYear" : Fields(3, 1) = "'" & cbYear.Text & "'"
            Fields(4, 0) = "foUsrName" : Fields(4, 1) = "'" & username & "'"
            frm = New frmPrintTmp

            frm.ShowDialog("rptStdPayments.rpt", strsql, Fields)

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

    Private Sub cbMont_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMonthFrom.SelectedIndexChanged, CbMonthTo.SelectedIndexChanged, cbYear.SelectedIndexChanged
        Try
            ErrorProvider1.SetError(CType(sender, ComboBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class