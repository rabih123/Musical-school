Imports System.Data.SqlClient

Public Class frmSchIncProf
    Dim lctitle As String = "Form School Payment \ Income Report"
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

    Private Sub frmSchIncProf_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuScholPayInc.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchIncProf_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchIncProf_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            RptTmp = frmMain.MnuScholPayInc.Text.Replace(" ", "").Substring(3).Replace("&&", "_") & "_" & usercode

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
        Dim Fields(3, 1) As String


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

            strsql &= " select distinct  Vch_year , Vch_NumMonth , vch_month ,  Crs_Desc , MAX(Crs_Price) as [CrsPrice] , COUNT( distinct vch_stdid)as [StdCount] , "
            strsql &= " (select COUNT(PrfCrs_Prof)from tbl_ProfCourse where PrfCrs_Crs=vch_Course ) as [ProfCount] , "
            strsql &= " Max(ProfAmnt) as [ProfAmount], isnull(Max([StdAmount]),0) as [StdAmount] ,  "
            strsql &= "  isnull(Max(cast([StdAmount]as decimal(18,2))),0)-Max(cast(ProfAmnt as decimal(18,2))) as [NetProfit], "


            If ChkPay.Checked = False Then
                strsql &= "  0  as [MonthPay] "
            Else
                strsql &= " case when ROW_NUMBER() over  (partition by Vch_year , vch_month order by   vch_NumMonth desc )= 1 then  "
                strsql &= "  isnull((select SUM(Pay_Amount) from tbl_payments where Pay_Year=Vch_year And Pay_Month=vch_NumMonth),0) Else 0 End  as [MonthPay] "
            End If

            strsql &= " from tbl_vouchers "
            strsql &= " Left join tbl_profStdCrs on vch_Course=prs_Crs and vch_stdid=PrS_Stdid and vch_prof=PrS_Prf "
            strsql &= " left join tbl_courses on Crs_Code=vch_Course "
            strsql &= " Left join Tbl_ProfPayments on Pay_ProfId=PrS_Prf and Vch_year=Pay_Year  "
            strsql &= " 			and Pay_Month=vch_NumMonth "
            strsql &= " left join tbl_SpecMonths on Spc_Month=Vch_NumMonth and Spc_Year=Vch_year "
            strsql &= " left join tbl_ProfStdMnthDisc on Disc_ProfStdId=vch_stdid  "
            strsql &= " 		 and Disc_Year=Vch_year and Disc_Month=Vch_NumMonth "
            strsql &= " left join tbl_Students on std_id=vch_stdid  "
            strsql &= " Left join ( "
            strsql &= " select distinct  [Month],Crs_code as [Crscode] , "
            strsql &= " sum (isnull([Amnt], [ProfPerc] * (([ReplaSess] + [Sessions]) - [MissingSess] - [HolidaySess]) +  "
            strsql &= " 	isnull([Disc], 0))) as ProfAmnt "
            strsql &= " from ( "
            strsql &= " select distinct PrS_Prf ,[Month] ,Crs_code ,max(PrfCrs_Price) AS [ProfPerc] , "
            strsql &= "  COUNT(PrS_Stdid) as [StdCount]  , max([SessCount]) as [Sessions] , "
            strsql &= " (select COUNT(*) from tbl_ReplaSession where MngSess_ProfId=max(PrS_Prf)  "
            strsql &= " and MngSess_Course=Prs_Crs and DATEPart(MM,MngSess_StrDate)=[MONTH]) as [MissingSess],  "
            strsql &= " (select COUNT(*) from tbl_ReplaSession  where MngSess_RplcProf=max(PrS_Prf)  "
            strsql &= " and MngSess_Course=Prs_Crs and DATEPart(MM,MngSess_StrDate)=[MONTH] ) as [ReplaSess],  "
            strsql &= " (select COUNT(Vct_RecId) from tbl_vacations where month(Vct_Startdate)=[MONTH] "
            strsql &= " and YEAR(Vct_Startdate)= " & cbYear.Text & " ) as [Holiday],isnull(max([HlidaySess]),0) as [HolidaySess],  "
            strsql &= " (select Disc_DiscManount from tbl_ProfStdMnthDisc  where Disc_Type='Prof' And Disc_Year= " & cbYear.Text & "  "
            strsql &= " and Disc_Month=[MONTH] and disc_ProfStdId=max(PrS_Prf)) as [Disc] , "
            strsql &= " case when not max(Pay_ProfId) IS null then 'Y' Else 'N' End as [Profpay] , max(Pay_amount) as [Amnt]   "
            strsql &= " from  tbl_profStdCrs  "
            strsql &= " right join ( "
            strsql &= " select 1 as [Month] Union select 2 as [Month]  "
            strsql &= " Union select 3 as [Month] Union select 4 as [Month] Union select 5 as [Month]  "
            strsql &= " Union select 6 as [Month] Union select 7 as [Month] Union select 8 as [Month]  "
            strsql &= " Union select 9 as [Month] Union select 10 as [Month] Union select 11 as [Month]  "
            strsql &= " Union select 12 as [Month] )A on 1=1 And MONTH(prs_datestmp) <=[Month] "
            strsql &= "      "
            strsql &= " Left Join Tbl_ProfPayments on Pay_ProfId=PrS_Prf and Pay_Month=[MONTH] and Pay_Year=" & cbYear.Text & "  "
            strsql &= " inner join tbl_courses on Prs_Crs=Crs_Code   "
            strsql &= " inner join tbl_ProfCourse on PrfCrs_Crs=Prs_Crs and PrfCrs_Prof=PrS_Prf   "
            strsql &= " inner join tbl_professors on prf_id=PrS_Prf   "
            strsql &= " left join (   "
            strsql &= " select SUM([SessCount]) as [SessCount] , Ses_CrsCode , [ProfCode] , [Month] as  "
            strsql &= " SessMnth from(  select Ses_ProfId as [ProfCode] , Ses_CrsCode ,[Month],  "
            strsql &= " COUNT(Ses_Counter)* dbo.GetNoDayInMonth(DATEPart(Dw,Ses_StartTime)-1,[Month]," & cbYear.Text & ") as [SessCount]  "
            strsql &= " from  tbl_sessions  "
            strsql &= " right join ( select 1 as [Month] Union select 2 as [Month] Union select 3 as "
            strsql &= " [Month] Union select 4 as [Month] Union select 5 as [Month] Union select 6 as  "
            strsql &= " [Month] Union select 7 as [Month] Union select 8 as [Month] Union select 9 as  "
            strsql &= " [Month] Union select 10 as [Month] Union select 11 as [Month] Union select 12 as [Month] )A on 1=1  "
            strsql &= " inner join tbl_profStdCrs on Ses_StdId=PrS_Stdid and Ses_CrsCode=Prs_Crs and Ses_ProfId=PrS_Prf "
            strsql &= " where(Ses_CrsCode Is Not null And Ses_StdId Is Not null) And MONTH(prs_datestmp) <=[Month] "
            strsql &= " group by Ses_ProfId,Ses_CrsCode, Ses_StartTime,[Month]  )tb  "
            strsql &= " group by Ses_CrsCode,[ProfCode],[Month]  )tbl on [ProfCode]=PrS_Prf and Ses_CrsCode=Prs_Crs and SessMnth=[MONTH]    "
            strsql &= " Left join (   "
            strsql &= " select COUNT(Ses_Counter) as [HlidaySess],Ses_CrsCode as [CrsCode], "
            strsql &= " Ses_ProfId as [ProfId] ,[Month] as [HolidMonth]   "
            strsql &= " from tbl_sessions   "
            strsql &= " right join ( select 1 as [Month] Union select 2 as [Month] Union select 3 as [Month] "
            strsql &= " Union select 4 as [Month] Union select 5 as [Month] Union select 6 as [Month]  "
            strsql &= " Union select 7 as [Month] Union select 8 as [Month] Union select 9 as [Month]  "
            strsql &= " Union select 10 as [Month] Union select 11 as [Month] Union select 12 as [Month])A on 1=1  "
            strsql &= " where  not Ses_StdId is null   "
            strsql &= " and  exists ( "
            strsql &= " select datepart(dw,Vct_Startdate)-1,* from tbl_vacations  "
            strsql &= " where(Year(Vct_Startdate) = " & cbYear.Text & "  And Month(Vct_Startdate) = [Month])  "
            strsql &= " and datepart(dw,Vct_Startdate)=datepart(dw,Ses_StartTime))  "
            strsql &= " group by Ses_ProfId,Ses_CrsCode,[Month]) tbl2 on [ProfId]=PrS_Prf and [CrsCode]= "
            strsql &= " Ses_CrsCode and [HolidMonth]=[Month]  "
            strsql &= " group by PrS_Prf , Prs_Crs,Crs_code,Ses_CrsCode,[ProfCode],[Month],Pay_Month  )tbl   "
            strsql &= " group by  [Month],Crs_code "
            strsql &= " )TbA on [Month]=Vch_NumMonth and Crscode=vch_Course  "
            strsql &= "  "
            strsql &= " Left join ( "
            strsql &= " select   Vch_NumMonth as [StdMonth] , vch_Course as [StdCrs] , COUNT(vch_stdid) as [Count],  "
            strsql &= " SUM(vch_total) +(SUM(isnull(Disc_DiscManount,0))) -   "
            strsql &= " case when isnull(max(Std_Special),'')='Y' then isnull(max(Spc_Amount),0) else 0 end as [StdAmount] "
            strsql &= " from dbo.tbl_vouchers  "
            strsql &= " left join tbl_Students on std_id=vch_stdid  "
            strsql &= " left join tbl_SpecMonths on Spc_Month=Vch_NumMonth and Spc_Year=Vch_year  "
            strsql &= " left join tbl_ProfStdMnthDisc on Disc_ProfStdId=vch_stdid and Disc_Type='Std'  "
            strsql &= " 					and Disc_Year=Vch_year and Disc_Month=Vch_NumMonth  "
            strsql &= " where Vch_year=" & cbYear.Text & " and std_status='A'  "

            If ChkStdPay.Checked = False Then
                strsql &= " And [vch_paid]='Y' "
            End If
            strsql &= " group by Vch_NumMonth ,vch_month ,Vch_year , vch_Course  "
            strsql &= " )TbA2 on [StdMonth]=Vch_NumMonth and [StdCrs]=vch_Course "

          



            strsql &= "  "
            strsql &= " Where Crs_Actice='A' and std_status='A' and Vch_year=" & cbYear.Text & "   "
            strsql &= " and Vch_NumMonth >=" & Mnth1 & " and Vch_NumMonth <=" & Mnth2 & ""
            strsql &= "  "
            strsql &= " group by Vch_year ,Vch_NumMonth,  vch_month ,vch_Course , Crs_Desc "

            strsql &= ")tblFin "

            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()


            strsql = "select * from " & RptTmp & " order  by vch_month asc "

            '  Fields(0, 0) = "foStatus"
            'If rbNotPaid.Checked = True Then
            ''    Fields(0, 1) = "'N'"
            ''ElseIf RbPaid.Checked = True Then
            'Fields(0, 1) = "'Y'"
            'Else
            'Fields(0, 1) = "'ALL'"
            'End If

            Fields(0, 0) = "foMonth1" : Fields(0, 1) = "'" & cbMonthFrom.Text & "'"
            Fields(1, 0) = "foMonth2" : Fields(1, 1) = "'" & CbMonthTo.Text & "'"
            Fields(2, 0) = "foYear" : Fields(2, 1) = "'" & cbYear.Text & "'"
            Fields(3, 0) = "foUsrName" : Fields(3, 1) = "'" & username & "'"
            frm = New frmPrintTmp

            frm.ShowDialog("rptSchoolIncome.rpt", strsql, Fields)

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
End Class