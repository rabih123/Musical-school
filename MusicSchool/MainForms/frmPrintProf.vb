Imports System.Data.SqlClient
Public Class frmPrintProf
    Dim lctitle As String = "Form Professors report"
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
            frmload.MnuProfRpt.Checked = False
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

            RptTmp = frmMain.MnuProfRpt.Text.Replace(" ", "").Substring(3) & "_" & usercode

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



            strsql &= "select PrS_Prf,[ProfName],[Month],Crs_Desc,[ProfPerc],[StdCount],[Sessions], "
            strsql &= "[MissingSess], [ReplaSess], [Holiday], [HolidaySess], [Disc], [Profpay], "
            strsql &= "isnull([Amnt], [ProfPerc] * (([ReplaSess] + [Sessions]) - [MissingSess] - [HolidaySess]) + "
            strsql &= " isnull(case when ROW_NUMBER() over (partition by PrS_Prf order by PrS_Prf)=1 Then [Disc] Else 0 End , 0)) as amnt, "
            strsql &= " ROW_NUMBER() over (Partition by [Month],PrS_Prf order by [Month],PrS_Prf ) as [Cnt] "
            strsql &= "from ( "
            strsql &= "select distinct PrS_Prf , max(prf_name)+' '+max(prf_lname) as [ProfName],[Month] ,Crs_Desc , max(PrfCrs_Price) AS [ProfPerc] , "
            strsql &= "COUNT(PrS_Stdid) as [StdCount]  , max([SessCount]) as [Sessions] ,"
            strsql &= "(select COUNT(*) from tbl_ReplaSession "
            strsql &= "where MngSess_ProfId=max(PrS_Prf) and MngSess_Course=Prs_Crs and DATEPart(MM,MngSess_StrDate)=[MONTH]) as [MissingSess], "
            strsql &= "(select COUNT(*) from tbl_ReplaSession  "
            strsql &= "where MngSess_RplcProf=max(PrS_Prf) and MngSess_Course=Prs_Crs and DATEPart(MM,MngSess_StrDate)=[MONTH] ) as [ReplaSess], "
            strsql &= "(select COUNT(Vct_RecId) from tbl_vacations "
            strsql &= "where month(Vct_Startdate)=[MONTH] and YEAR(Vct_Startdate)=" & cbYear.Text & " ) as [Holiday],isnull(max([HlidaySess]),0) as [HolidaySess], "
            strsql &= "(select Disc_DiscManount from tbl_ProfStdMnthDisc "
            strsql &= "where Disc_Type='Prof' And Disc_Year=" & cbYear.Text & " and Disc_Month=[MONTH] and disc_ProfStdId=max(PrS_Prf)) as [Disc] ,"
            strsql &= "case when not max(Pay_ProfId) IS null then 'Y' Else 'N' End as [Profpay] , max(Pay_amount) as [Amnt] "
            strsql &= " from  tbl_profStdCrs "
            strsql &= "right join ("
            strsql &= "select 1 as [Month] Union select 2 as [Month] Union select 3 as [Month] Union "
            strsql &= "select 4 as [Month] Union select 5 as [Month] Union select 6 as [Month] Union "
            strsql &= "select 7 as [Month] Union select 8 as [Month] Union select 9 as [Month] Union "
            strsql &= "select 10 as [Month] Union select 11 as [Month] Union select 12 as [Month] "
            strsql &= ")A on 1=1 And MONTH(prs_datestmp) <=[Month]  "
            strsql &= "Left Join Tbl_ProfPayments on Pay_ProfId=PrS_Prf and Pay_Month=[MONTH] and Pay_Year=" & cbYear.Text & " "
            strsql &= "inner join tbl_courses on Prs_Crs=Crs_Code  "
            strsql &= "inner join tbl_ProfCourse on PrfCrs_Crs=Prs_Crs and PrfCrs_Prof=PrS_Prf  "
            strsql &= "inner join tbl_professors on prf_id=PrS_Prf  "
            strsql &= "left join (  "
            strsql &= "select SUM([SessCount]) as [SessCount] , Ses_CrsCode , [ProfCode] , [Month] as SessMnth from(  "
            strsql &= "select Ses_ProfId as [ProfCode] , Ses_CrsCode ,[Month], "
            strsql &= "COUNT(Ses_Counter)* dbo.GetNoDayInMonth(DATEPart(Dw,Ses_StartTime)-1,[Month]," & cbYear.Text & ") as [SessCount]  "
            strsql &= "from  tbl_sessions "
            strsql &= "right join ( "
            strsql &= "select 1 as [Month] Union select 2 as [Month] Union select 3 as [Month] Union "
            strsql &= "select 4 as [Month] Union select 5 as [Month] Union select 6 as [Month] Union "
            strsql &= "select 7 as [Month] Union select 8 as [Month] Union select 9 as [Month] Union "
            strsql &= "select 10 as [Month] Union select 11 as [Month] Union select 12 as [Month] "
            strsql &= ")A on 1=1  "
            strsql &= " inner join tbl_profStdCrs on Ses_StdId=PrS_Stdid and Ses_CrsCode=Prs_Crs and Ses_ProfId=PrS_Prf "
            strsql &= " where(Ses_CrsCode Is Not null And Ses_StdId Is Not null)  And MONTH(prs_datestmp) <=[Month]  "
            strsql &= "group by Ses_ProfId,Ses_CrsCode, Ses_StartTime,[Month]  "
            strsql &= ")tb group by Ses_CrsCode,[ProfCode],[Month]  "
            strsql &= ")tbl on [ProfCode]=PrS_Prf and Ses_CrsCode=Prs_Crs and SessMnth=[MONTH]   "

            strsql &= "Left join (  "
            strsql &= "select COUNT(Ses_Counter) as [HlidaySess],Ses_CrsCode as [CrsCode],Ses_ProfId as [ProfId] ,[Month] as [HolidMonth]  from "
            strsql &= "tbl_sessions  "
            strsql &= "right join ( "
            strsql &= "select 1 as [Month] Union select 2 as [Month] Union select 3 as [Month] Union "
            strsql &= "select 4 as [Month] Union select 5 as [Month] Union select 6 as [Month] Union "
            strsql &= "select 7 as [Month] Union select 8 as [Month] Union select 9 as [Month] Union "
            strsql &= "select 10 as [Month] Union select 11 as [Month] Union select 12 as [Month]"
            strsql &= ")A on 1=1 "
            strsql &= "where  not Ses_StdId is null  and  exists (select datepart(dw,Vct_Startdate)-1,* from tbl_vacations "
            strsql &= "where(Year(Vct_Startdate) = " & cbYear.Text & " And Month(Vct_Startdate) = [Month]) "
            strsql &= "and datepart(dw,Vct_Startdate)=datepart(dw,Ses_StartTime))  "
            strsql &= "group by Ses_ProfId,Ses_CrsCode,[Month]) tbl2 on [ProfId]=PrS_Prf and [CrsCode]=Ses_CrsCode and [HolidMonth]=[Month]  "


            strsql &= "where [Month] >= " & Mnth1 & " and [Month] <=" & Mnth2 & " "

          

            strsql &= "group by PrS_Prf , Prs_Crs,Crs_Desc,Ses_CrsCode,[ProfCode],[Month],Pay_Month  "
            strsql &= ")tbl "
            'strsql &= "order  by PrS_Prf,[MONTH] "
            strsql &= " )tbl5 "

            If rbNotPaid.Checked = True Then
                strsql &= "where Profpay='N'"
            ElseIf RbPaid.Checked Then
                strsql &= "where Profpay='Y'"
            End If

            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()


            strsql = "select * from " & RptTmp & " order  by [MONTH],PrS_Prf "

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

            frm.ShowDialog("rptProfPayments.rpt", strsql, Fields)

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