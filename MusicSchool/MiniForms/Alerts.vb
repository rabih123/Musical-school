Imports System.Data.SqlClient

Public Class Alerts

    Private Sub Alerts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand


        Try

            strsql = "Select isnull(Count(vch_stdid),0) as [Cnt] from tbl_vouchers where Vch_year=" & Now.Year & " And Vch_NumMonth=" & Now.Month & " And vch_paid='N' "
            strsql &= " And Exists (select top 1 1 from tbl_Students where std_id=vch_stdid and std_status='A' )"

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)

            If Not cmsql.ExecuteScalar Is Nothing Then
                LblText.Text = "you have " & cmsql.ExecuteScalar & " pending students payments"
            End If


            Timer1.Start()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If LblColr.BackColor = Color.White Then
                'LblPhoto.Width = 55
                'LblPhoto.Height = 45
                LblColr.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
                LblText.ForeColor = System.Drawing.Color.FromArgb(255, 255, 192)

            Else
                'LblPhoto.Width = 70
                'LblPhoto.Height = 58
                LblColr.BackColor = Color.White
                LblText.ForeColor = Color.White
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub LblPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblPhoto.Click, LblText.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim Fields(4, 1) As String
        Dim frm As frmPrintTmp
        Try
            Me.Cursor = Cursors.WaitCursor

            cnsql = New SqlConnection(constr)
            cnsql.Open()


            strsql = "if exists (select top 1 1 from sys.tables where name='" & "TmpAlertRep" & "') drop table " & "TmpAlertRep"

            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteNonQuery()

            strsql = "Select * into " & "TmpAlertRep" & " From( "
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
            strsql &= " end >= " & Now.Month & " and "
            strsql &= "  Case vch_month "
            strsql &= " when 'January' then 1 when 'February' then 2 when 'March' then 3 when 'April' then 4 "
            strsql &= " when 'May' then 5 when 'June' then 6 when 'July' then 7 when 'August' then 8 "
            strsql &= " when 'September' then 9 when 'October' then 10 when 'November' then 11 when 'December' then 12 "
            strsql &= " end <= " & Now.Month & " and Vch_year='" & Now.Year & "' and std_status='A' And vch_paid='N' "
            strsql &= " group by vch_stdid,vch_month,Vch_year "
            strsql &= " )tbl "

            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()




            strsql = "select * from " & "TmpAlertRep" & " order  by Mnth, name "

            Fields(0, 0) = "foStatus"
            Fields(0, 1) = "'N'"


            Fields(1, 0) = "foMonth1" : Fields(1, 1) = "'" & Now.ToString("MMMM") & "'"
            Fields(2, 0) = "foMonth2" : Fields(2, 1) = "'" & Now.ToString("MMMM") & "'"
            Fields(3, 0) = "foYear" : Fields(3, 1) = "'" & Now.Year & "'"
            Fields(4, 0) = "foUsrName" : Fields(4, 1) = "'" & username & "'"
            frm = New frmPrintTmp

            frm.ShowDialog("rptStdPayments.rpt", strsql, Fields)

            strsql = "if exists (select top 1 1 from sys.tables where name='" & "TmpAlertRep" & "') drop table " & "TmpAlertRep"
            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()

            Me.Cursor = Cursors.Default

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LblText_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblText.MouseHover
        Try
            LblText.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Timer1.Stop() : LblColr.BackColor = Color.White : LblText.ForeColor = Color.White
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LblText_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblText.MouseLeave
        Try
            LblText.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Timer1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class