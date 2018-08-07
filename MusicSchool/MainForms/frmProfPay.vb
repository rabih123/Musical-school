Imports System.Data.SqlClient
Public Class frmProfPay
    Dim lctitle As String = "Form Professor Payments"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges As Boolean
    Dim dt As DataTable

    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProfPay_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuProfPay.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProfPay_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProfPay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmProfPay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            readonlyy(Me, True)

            btnshow.Enabled = False

            If lcView = False Then
                EnableMenuButton(Me, False, {btnClose})
            End If

            btnCancel.Enabled = False : btnSave.Enabled = False
            PanlHide.Visible = True : PanlHide.BringToFront()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            cbProff.Enabled = True : cbYear.Enabled = True : cbMonth.Enabled = True
            btnSave.Enabled = False : btnCancel.Enabled = True
            fillComboBox() : btnshow.Enabled = True : btnModify.Enabled = False
            cbYear.Text = Now.Year
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
            strsql = "Select -5 as prf_id ,'Select an Professor' as prf_name  union select prf_id,prf_name+ ' '+ prf_lname as prf_name  from tbl_professors  where prf_status='A' "
            strsql &= "and Exists (select top 1 1 from tbl_profStdCrs where prs_Prf=prf_id ) "
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

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim dasql As SqlDataAdapter
        Dim strsql As String
        Dim i As Integer

        Try
            If cbProff.SelectedIndex < 1 Then ErrorProvider1.SetError(cbProff, "Select Professor First") : Exit Try

            If cbYear.Text.Trim = "" Then ErrorProvider1.SetError(cbYear, "Select A Year") : Exit Try
            If cbMonth.Text.Trim = "" Then ErrorProvider1.SetError(cbMonth, "Select A Month") : Exit Try

            PanlHide.Visible = False : PanlHide.SendToBack()

            Timer1.Stop()
            btnshow.BackColor = Color.Brown : btnshow.ForeColor = Color.White

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            'strsql = "select count(PrS_Stdid) from tbl_profStd "
            'strsql &= "inner join  tbl_Students on std_id=PrS_Stdid "
            'strsql &= "where PrS_Prf=" & cbProff.SelectedValue & " and std_status='A' "

            'cmsql = New SqlCommand(strsql, cnsql)
            'lblstdNo.Text = cmsql.ExecuteScalar.ToString

            'strsql = "select prf_perc from tbl_professors where prf_id=" & cbProff.SelectedValue
            'cmsql.CommandText = strsql

            'lblPerc.Text = cmsql.ExecuteScalar.ToString

            

            'strsql = "select cast(sum(Prs_price)* " & IIf(lblPayd.Text = "Yes", lblOldperc.Text.Trim, lblPerc.Text.Trim) & "/100 as decimal(18,2)) as [Amnt] "
            'strsql &= "from tbl_profStd "
            'strsql &= "inner join  tbl_Students on std_id=PrS_Stdid "
            'strsql &= "inner join tbl_professors on prf_id=PrS_Prf "
            'strsql &= "where PrS_Prf=" & cbProff.SelectedValue & " and std_status='A' "


            'cmsql.CommandText = strsql

            'lblAmount.Text = cmsql.ExecuteScalar.ToString & "  $"



            strsql = "select Crs_Desc , isnull(max(PrfCrs_Price),0) AS [ProfPerc] , isnull(COUNT(PrS_Stdid),0) as [StdCount]  , isnull(max([SessCount]),0) as [Sessions] ,"
            strsql &= "isnull((select COUNT(*) from tbl_ReplaSession "
            strsql &= "where MngSess_ProfId=max(PrS_Prf) and MngSess_Course=Prs_Crs and DATEPart(MM,MngSess_StrDate)=" & cbMonth.SelectedIndex + 1 & " ),0) as [MissingSess], "
            strsql &= "isnull((select COUNT(*) from tbl_ReplaSession "
            strsql &= "where MngSess_RplcProf=max(PrS_Prf) and MngSess_Course=Prs_Crs and DATEPart(MM,MngSess_StrDate)=" & cbMonth.SelectedIndex + 1 & "),0) as [ReplaSess], "
            strsql &= "isnull((select COUNT(Vct_RecId) from tbl_vacations "
            strsql &= "where month(Vct_Startdate)=" & cbMonth.SelectedIndex + 1 & " And YEAR(Vct_Startdate)=" & cbYear.Text & " ),0) as [Holiday],isnull(max([HlidaySess]),0) as [HolidaySess],"
            strsql &= "isnull((select + Disc_DiscManount from tbl_ProfStdMnthDisc "
            strsql &= "where Disc_Type='Prof' And Disc_Year=" & cbYear.Text & " and Disc_Month=" & cbMonth.SelectedIndex + 1 & " and disc_ProfStdId=max(PrS_Prf)),0) as [Disc] "
            strsql &= "from  tbl_profStdCrs  "
            strsql &= "inner join tbl_courses on Prs_Crs=Crs_Code  "
            strsql &= "inner join tbl_ProfCourse on PrfCrs_Crs=Prs_Crs and PrfCrs_Prof=PrS_Prf  "

            strsql &= "left join ( "
            strsql &= "select SUM([SessCount]) as [SessCount] , Ses_CrsCode , [ProfCode] from( "
            strsql &= "select Ses_ProfId as [ProfCode] , Ses_CrsCode , "
            strsql &= "COUNT(Ses_Counter)* dbo.GetNoDayInMonth(DATEPart(Dw,Ses_StartTime)-1," & cbMonth.SelectedIndex + 1 & "," & cbYear.Text & ") as [SessCount]  "
            strsql &= "from   tbl_sessions  "
            strsql &= "inner join tbl_profStdCrs on Ses_StdId=PrS_Stdid and Ses_CrsCode=Prs_Crs and Ses_ProfId=PrS_Prf "
            strsql &= "where(Ses_CrsCode Is Not null And Ses_StdId Is Not null) And MONTH(prs_datestmp) <=" & cbMonth.SelectedIndex + 1 & "  "
            strsql &= "group by Ses_ProfId,Ses_CrsCode, Ses_StartTime  "
            strsql &= ")tb group by Ses_CrsCode,[ProfCode]  "
            strsql &= ")tbl on [ProfCode]=PrS_Prf and Ses_CrsCode=Prs_Crs  "

            strsql &= "Left join ( "
            strsql &= "select COUNT(Ses_Counter) as [HlidaySess],Ses_CrsCode as [CrsCode]  from "
            strsql &= "tbl_sessions  "
            strsql &= "where not Ses_StdId is null and Ses_ProfId= " & cbProff.SelectedValue & " and  exists (select datepart(dw,Vct_Startdate)-1,* from tbl_vacations "
            strsql &= "where(Year(Vct_Startdate) = " & cbYear.Text & " And Month(Vct_Startdate) = " & cbMonth.SelectedIndex + 1 & ") "
            strsql &= "and datepart(dw,Vct_Startdate)=datepart(dw,Ses_StartTime))  "
            strsql &= "group by Ses_CrsCode) tbl2 on [CrsCode]=Ses_CrsCode  "
            strsql &= "where PrS_Prf =" & cbProff.SelectedValue & " And MONTH(prs_datestmp) <=" & cbMonth.SelectedIndex + 1 & " "
            strsql &= "group by Prs_Crs,Crs_Desc,Ses_CrsCode,[ProfCode]  "



            dasql = New SqlDataAdapter(strsql, cnsql)

            dt = New DataTable
            dasql.Fill(dt)

            tdbSess.DataSource = dt.DefaultView


            With tdbSess.Splits(0)
                .CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .CaptionStyle.ForeColor = Color.Maroon



                .DisplayColumns("Crs_Desc").DataColumn.Caption = "Course"
                .DisplayColumns("Crs_Desc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Crs_Desc").Width = 130
                .DisplayColumns("Crs_Desc").AllowSizing = False
                .DisplayColumns("Crs_Desc").Locked = True


                .DisplayColumns("ProfPerc").DataColumn.Caption = "Prof % ($/Sess)"
                .DisplayColumns("ProfPerc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("ProfPerc").Width = 100
                .DisplayColumns("ProfPerc").AllowSizing = False
                .DisplayColumns("ProfPerc").Locked = True


                .DisplayColumns("StdCount").DataColumn.Caption = "Student Counts"
                .DisplayColumns("StdCount").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("StdCount").Width = 100
                .DisplayColumns("StdCount").AllowSizing = False
                .DisplayColumns("StdCount").Locked = True


                .DisplayColumns("Sessions").DataColumn.Caption = "# Of Sessions"
                .DisplayColumns("Sessions").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Sessions").Width = 100
                .DisplayColumns("Sessions").AllowSizing = False
                .DisplayColumns("Sessions").Locked = True

                .DisplayColumns("MissingSess").DataColumn.Caption = "# Of Missing Sessions"
                .DisplayColumns("MissingSess").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("MissingSess").Width = 100
                .DisplayColumns("MissingSess").AllowSizing = False
                .DisplayColumns("MissingSess").Locked = True

                .DisplayColumns("ReplaSess").DataColumn.Caption = "# Of Repl Sessions"
                .DisplayColumns("ReplaSess").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("ReplaSess").Width = 100
                .DisplayColumns("ReplaSess").AllowSizing = False
                .DisplayColumns("ReplaSess").Locked = True

                .DisplayColumns("Holiday").DataColumn.Caption = "Holidays"
                .DisplayColumns("Holiday").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Holiday").Width = 100
                .DisplayColumns("Holiday").Merge = True
                .DisplayColumns("Holiday").AllowSizing = False
                .DisplayColumns("Holiday").Locked = True


                .DisplayColumns("HolidaySess").DataColumn.Caption = "# Holiday Sessions"
                .DisplayColumns("HolidaySess").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("HolidaySess").Width = 100
                .DisplayColumns("HolidaySess").AllowSizing = False
                .DisplayColumns("HolidaySess").Locked = True


                .DisplayColumns("Disc").DataColumn.Caption = "Discount  (+/-)"
                .DisplayColumns("Disc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Disc").Width = 60
                .DisplayColumns("Disc").AllowSizing = False
                .DisplayColumns("Disc").Locked = True
                .DisplayColumns("Disc").Merge = True

            End With


            For Each column In tdbSess.Splits(0).DisplayColumns
                tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 10, FontStyle.Bold)
                tdbSess.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                tdbSess.Splits(0).DisplayColumns(i).Style.VerticalAlignment = C1.Win.C1TrueDBGrid.AlignVertEnum.Center
                i = i + 1
            Next


            tdbSess.Splits(0).DisplayColumns("Crs_Desc").DataColumn.FooterText = "Totals"
            tdbSess.Splits(0).DisplayColumns("Crs_Desc").FooterStyle.BackColor = SystemColors.Control

            If Not dt Is Nothing AndAlso dt.Rows.Count >= 1 Then
                tdbSess.Splits(0).DisplayColumns("ProfPerc").DataColumn.FooterText = dt.Compute("sum(ProfPerc)", "")
                tdbSess.Splits(0).DisplayColumns("StdCount").DataColumn.FooterText = dt.Compute("sum(StdCount)", "")
                tdbSess.Splits(0).DisplayColumns("Sessions").DataColumn.FooterText = dt.Compute("sum(Sessions)", "")
                tdbSess.Splits(0).DisplayColumns("MissingSess").DataColumn.FooterText = dt.Compute("sum(MissingSess)", "")
                tdbSess.Splits(0).DisplayColumns("ReplaSess").DataColumn.FooterText = dt.Compute("sum(ReplaSess)", "")
                tdbSess.Splits(0).DisplayColumns("HolidaySess").DataColumn.FooterText = dt.Compute("sum(HolidaySess)", "")
                tdbSess.Splits(0).DisplayColumns("Disc").DataColumn.FooterText = dt.Rows(0)("Disc").ToString
            End If
          


            strsql = "select Pay_amount from Tbl_ProfPayments where Pay_Year=" & cbYear.Text & " and Pay_month=" & cbMonth.SelectedIndex + 1 & " and Pay_ProfId=" & cbProff.SelectedValue
            cmsql = New SqlCommand(strsql, cnsql)

            If Not cmsql.ExecuteScalar Is Nothing Then
                lblPayd.Text = "Yes" : Label5.Text = "Amount Paid"
                lblAmount.Text = cmsql.ExecuteScalar & " $ "
            Else
                lblPayd.Text = "NO" : Label5.Text = "Amount To Pay"

                lblAmount.Text = 0
                If Not dt Is Nothing AndAlso dt.Rows.Count >= 1 Then
                    For j As Integer = 0 To dt.Rows.Count - 1
                        lblAmount.Text = CDbl(lblAmount.Text) + CDbl(dt.Compute("sum(ProfPerc)", "Crs_Desc='" & dt.Rows(j)("Crs_Desc").ToString & "'")) * _
                               ((CInt(dt.Compute("sum(Sessions)", "Crs_Desc='" & dt.Rows(j)("Crs_Desc").ToString & "'") - CInt(dt.Compute("sum(MissingSess)", "Crs_Desc='" & dt.Rows(j)("Crs_Desc").ToString & "'")) - dt.Compute("sum(HolidaySess)", "Crs_Desc='" & dt.Rows(j)("Crs_Desc").ToString & "'"))) + _
                                          dt.Compute("sum(ReplaSess)", "Crs_Desc='" & dt.Rows(j)("Crs_Desc").ToString & "'"))
                    Next

                    lblAmount.Text = lblAmount.Text + CDbl(dt.Rows(0)("Disc").ToString) & " $ "
                End If
               

            End If


          


            btnSave.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            PanlHide.BringToFront() : PanlHide.Visible = True
            ClearControls(Me, , ErrorProvider1) : cbMonth.Enabled = False
            EnableMenuButton(Me, True)
            btnCancel.Enabled = False : btnSave.Enabled = False
            cbProff.Enabled = False : cbYear.Enabled = False
            btnshow.Enabled = False : Timer1.Stop()
            cbMonth.SelectedIndex = -1
            cbYear.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbYear.SelectedIndexChanged
        Try
            ErrorProvider1.SetError(cbYear, "")

            If cbYear.Text <> "" AndAlso cbProff.SelectedIndex > 0 AndAlso cbMonth.Text <> "" Then
                Timer1.Start()
            End If
            'cbYear.SelectedIndex = -1
            PanlHide.BringToFront() : PanlHide.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMonth.SelectedIndexChanged
        Try
            ErrorProvider1.SetError(cbMonth, "")

            If cbMonth.Text <> "" AndAlso cbProff.SelectedIndex > 0 AndAlso cbYear.Text <> "" Then
                Timer1.Start()
            End If
            'cbMonth.SelectedIndex = -1
            PanlHide.BringToFront() : PanlHide.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Timer1.Interval = 1000
            If btnshow.BackColor = Color.Brown Then
                btnshow.BackColor = Color.White : btnshow.ForeColor = Color.Brown
            Else
                btnshow.BackColor = Color.Brown : btnshow.ForeColor = Color.White
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbProff_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProff.SelectedIndexChanged
        Try
            ErrorProvider1.SetError(cbProff, "")
            If cbMonth.Text <> "" AndAlso cbProff.SelectedIndex > 0 AndAlso cbYear.Text <> "" Then
                Timer1.Start()
            End If
            PanlHide.BringToFront() : PanlHide.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String

        Try

            If lblPayd.Text.Trim = "Yes" Then
                MessageBox.Show("You Have Already Paid To this Professor for the selected Month", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            If MessageBox.Show("Are you sure do you want to Save", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                             MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then


                strsql = "Insert into Tbl_ProfPayments select " & cbProff.SelectedValue & "," & cbYear.Text & "," & cbMonth.SelectedIndex + 1 & ","
                strsql &= "'" & cbMonth.Text & "'," & lblAmount.Text.Trim.Replace("$", "") & ",'Y',getdate(),'" & usercode & "',"
                strsql &= "  " & tdbSess.Splits(0).DisplayColumns("ProfPerc").DataColumn.FooterText / tdbSess.Splits(0).Rows.Count & ","
                strsql &=((CInt(dt.Compute("sum(Sessions)", "") - CInt(dt.Compute("sum(MissingSess)", "")) - dt.Compute("sum(HolidaySess)", ""))) + _
                                  dt.Compute("sum(ReplaSess)", ""))

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                cmsql.ExecuteNonQuery()

                MessageBox.Show("Saved successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnModify_Click(btnModify, New System.EventArgs)
                cbMonth.Text = "" : cbYear.Text = "" : cbMonth.SelectedIndex = -1 : cbYear.SelectedIndex = -1
                PanlHide.Visible = True : PanlHide.BringToFront()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class