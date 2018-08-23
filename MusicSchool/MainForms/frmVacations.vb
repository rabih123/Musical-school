Imports System.Data.SqlClient

Public Class frmVacations
    Dim lctitle As String = "Form Holidays"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges As Boolean
    Dim dtHolidays As DataTable
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dr As DataRow

        Try
            If txtReason.Text.Trim = "" Then
                MessageBox.Show("Please Fill Reason First", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtReason.Focus() : Exit Try
            End If


            If MessageBox.Show("Are You Sure Do You Want To Add This Holiday " & vbCrLf & _
                            "Starting : " & CDate(MntStrdate.SelectionRange.Start).ToString("dd/MM/yyyy") & vbCrLf & _
                            "Ending   : " & CDate(MnthEndDate.SelectionRange.End).ToString("dd/MM/yyyy"), lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then


                dr = dtHolidays.NewRow

                dr.Item(0) = dtHolidays.Rows.Count
                dr.Item(1) = CDate(MntStrdate.SelectionRange.Start)
                dr.Item(2) = CDate(MnthEndDate.SelectionRange.Start)
                dr.Item(3) = IIf(rbFulday.Checked, "Full", "Half")
                dr.Item(4) = txtReason.Text.Trim

                dtHolidays.Rows.Add(dr)

                lcchanges = True
                txtReason.Text = ""
                MntStrdate.SelectionRange.Start = Now.Date
                MnthEndDate.SelectionRange.Start = Now.Date

            Else
                Exit Try
            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MntStrdate_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MntStrdate.DateChanged, MnthEndDate.DateChanged
        Try
            If MnthEndDate.SelectionRange.Start.Month <> MntStrdate.SelectionRange.Start.Month Then
                If sender Is MntStrdate Then
                    MnthEndDate.SelectionStart = MntStrdate.SelectionStart
                Else
                    MntStrdate.SelectionStart = MnthEndDate.SelectionStart
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmVacations_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuHolidays.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmVacations_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmVacations_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        btnModify.Enabled = False
        btnCancel.Enabled = True
        btnSave.Enabled = True
        btnClose.Enabled = True
        BtnPrvs.Enabled = True
        btnAdd.Enabled = True
        lcchanges = False
        MntStrdate.Enabled = True
        MnthEndDate.Enabled = True
        EnableDisable(Me, True)
        fillGrid()
        rbFulday.Checked = True
        MntStrdate.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearControls(Me, "", Nothing)
        btnModify.Enabled = True
        btnCancel.Enabled = False
        btnSave.Enabled = False
        btnClose.Enabled = True
        lcchanges = False
        MntStrdate.SelectionRange.Start = Now.Date
        MnthEndDate.SelectionRange.Start = Now.Date
        MntStrdate.Enabled = False
        MnthEndDate.Enabled = False

        tdbHolid.ClearFields()
        dtHolidays = Nothing
        BtnPrvs.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dr As DataRow
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand

        Try

            If dtHolidays.Rows.Count = 0 Then Exit Try

            If lcchanges = False Then
                MessageBox.Show("No Changes Made To Save.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            If MessageBox.Show("Are yous ure do you want to save ?", lctitle, _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand("select 1", cnsql)
                cmsql.ExecuteNonQuery()

                For Each dr In dtHolidays.Rows
                    If dr.RowState = DataRowState.Added Then
                        strsql = "Insert into tbl_vacations select '" & CDate(dr.Item(1)).ToString("MM/dd/yyyy") & "',"
                        strsql &= "'" & CDate(dr.Item(2)).ToString("MM/dd/yyyy") & "','" & dr.Item(3).ToString.Substring(0, 1) & "',"
                        strsql &= "'" & dr.Item(4).ToString.Replace("'", "''") & "'"

                        cmsql.CommandText = strsql
                        cmsql.ExecuteNonQuery()

                    ElseIf dr.RowState = DataRowState.Deleted Then
                        strsql = "delete from tbl_vacations where Vct_RecId=" & dr.Item(0, DataRowVersion.Original)
                        cmsql.CommandText = strsql
                        cmsql.ExecuteNonQuery()
                    End If

                Next



                MessageBox.Show("Modifications Successfully saved ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCancel_Click(btnCancel, New System.EventArgs)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
       
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmVacations_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            MntStrdate.Enabled = False
            MnthEndDate.Enabled = False

            If lcView = False Then
                EnableMenuButton(Me, False, {btnClose})
            End If

            btnCancel.Enabled = False
            btnSave.Enabled = False
            btnClose.Enabled = True

            btnAdd.Enabled = False
            BtnPrvs.Enabled = False

            MntStrdate.MinDate = "01/01/" & Now.Year
            MntStrdate.MaxDate = "12/31/" & Now.Year

            MnthEndDate.MinDate = "01/01/" & Now.Year
            MnthEndDate.MaxDate = "12/31/" & Now.Year

            MntStrdate.SelectionRange.Start = Now.Date
            MnthEndDate.SelectionRange.Start = Now.Date

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtReason_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReason.Enter
        Try
            CType(sender, TextBox).BackColor = Color.Bisque
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtReason_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReason.Leave
        Try
            CType(sender, TextBox).BackColor = Color.White
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MnthEndDate_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MnthEndDate.DateSelected, MntStrdate.DateSelected
        Try
            If sender Is MnthEndDate Then
                If e.Start < MntStrdate.SelectionRange.Start Then
                    MessageBox.Show("End Date Must Be Less Or Equal To Start Date", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    MnthEndDate.SelectionStart = MntStrdate.SelectionStart
                End If
            Else
                If e.Start > MnthEndDate.SelectionRange.Start Then
                    MessageBox.Show("Start Date Must Be Less Or Equal To End Date", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    MntStrdate.SelectionStart = MnthEndDate.SelectionStart
                End If
            End If

            CType(sender, MonthCalendar).Refresh()

            If DateDiff(DateInterval.Day, MntStrdate.SelectionRange.Start, MnthEndDate.SelectionRange.Start) > 0 Then
                rbHalfDay.Enabled = False
            Else
                rbHalfDay.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillGrid()
        Dim cnsql As SqlConnection
        Dim dasql As SqlDataAdapter
        Dim strsql As String
        Dim i As Integer

        Try

            strsql = "Select Vct_RecId , convert(datetime,convert(varchar(10),Vct_Startdate,101)) as [StrDate] , "
            strsql &= "convert(datetime,convert(varchar(10),vct_EndDate,101)) as [Enddate] , case Vct_Type when'F' Then 'Full' when 'H' then 'Half'End AS [Type] ,Vct_desc  "
            strsql &= "from tbl_vacations where year(Vct_Startdate)=" & Now.Year

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            dasql = New SqlDataAdapter(strsql, cnsql)
            dtHolidays = New DataTable

            dasql.Fill(dtHolidays)

            tdbHolid.DataSource = dtHolidays.DefaultView

            With tdbHolid.Splits(0)
                .ColumnCaptionHeight = 25
                .CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .CaptionStyle.ForeColor = Color.Maroon

                .DisplayColumns("Vct_RecId").DataColumn.Caption = ""
                .DisplayColumns("Vct_RecId").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Vct_RecId").Width = 0
                .DisplayColumns("Vct_RecId").Visible = False
                .DisplayColumns("Vct_desc").AllowSizing = False

                .DisplayColumns("StrDate").DataColumn.Caption = "Start Date"
                .DisplayColumns("StrDate").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("StrDate").Width = 110
                .DisplayColumns("StrDate").DataColumn.NumberFormat = ("dd/MM/yyyy")

                .DisplayColumns("Enddate").DataColumn.Caption = "End Date"
                .DisplayColumns("Enddate").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Enddate").Width = 110
                .DisplayColumns("Enddate").DataColumn.NumberFormat = ("dd/MM/yyyy")

                .DisplayColumns("Type").DataColumn.Caption = "Type"
                .DisplayColumns("Type").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Type").Width = 80


                .DisplayColumns("Vct_desc").DataColumn.Caption = "Description"
                .DisplayColumns("Vct_desc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                .DisplayColumns("Vct_desc").Width = 400
                .DisplayColumns("Vct_desc").AllowSizing = True



            End With


            For Each column In tdbHolid.Splits(0).DisplayColumns
                tdbHolid.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                tdbHolid.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                tdbHolid.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                i = i + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            If Not dasql Is Nothing Then dasql = Nothing
        End Try
    End Sub

    Private Sub tdbHolid_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles tdbHolid.BeforeDelete
        Try

            If tdbHolid.SelectedRows.Count <> 1 Then Exit Try

            If MessageBox.Show("Are You Sure Do You Want To Delete Record ? ", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                tdbHolid.UpdateData()
                lcchanges = True
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnPrvs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrvs.Click
        Dim width() As Integer
        width = {70, 100, 100, 120, 250}
        Try
            Dim frm As search
            Dim strsql As String
            Dim val As String

            strsql = " select YEAR(Vct_Startdate) as [Year] , convert(varchar(10),Vct_Startdate,103) as [Start Date],"
            strsql &= " convert(varchar(10),vct_EndDate,103)  as [End Date] ,case when  Vct_Type ='H' Then 'Half Day' Else 'Full Day' End as [Type],Vct_desc as [Reason]"
            strsql &= " from tbl_vacations where YEAR(Vct_Startdate)=YEAR(GETDATE())-1 order by YEAR(Vct_Startdate) "

            frm = New search


            frm.ShowDialog(strsql, val, True, width)
            frm.tdbsearch.Splits(0).DisplayColumns(0).Merge = C1.Win.C1TrueDBGrid.ColumnMergeEnum.Free

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class