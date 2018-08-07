Imports System.Data.SqlClient

Public Class frmPayments
    Dim lctitle As String = "Monthly Payments"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges As Boolean
    Dim dtPay As DataTable

    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPayments_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuMonthPaym.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPayments_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPayments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

 

    Private Sub frmPayments_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            btnshow.Enabled = False
            tdbpay.Parent = Me
            tdbpay.Visible = False
            tdbpay.BackColor = SystemColors.Control
            tdbpay.Top = GroupBox2.Height + 30
            tdbpay.Left = 0
            tdbpay.Width = Me.Width - 5
            tdbpay.Height = 250
            btnCopy.Enabled = False
            btnCopy.Visible = False
            ToolTip1.SetToolTip(btnCopy, "Copy payments from previous month" & vbCrLf)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            cbYear.Enabled = True : cbMonth.Enabled = True
            btnSave.Enabled = False : btnCancel.Enabled = True
            btnshow.Enabled = True : btnModify.Enabled = False
            cbYear.Text = Now.Year
            cbMonth.SelectedIndex = Now.Month - 1
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String

        Try

            If MessageBox.Show("Are you sure do you want to Save", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                             MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then



                For Each dr As DataRow In dtPay.Rows
                    If dr.RowState = DataRowState.Added OrElse dr.RowState = DataRowState.Modified Then
                        If dr.Item("Pay_Desc").ToString.Trim = "" OrElse dr.Item("Pay_Amount").ToString.Trim = "" Then
                            MessageBox.Show("Please Fill All Missing data In the Grid", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            tdbpay.Row = 0 : tdbpay.Row = 0 : Exit Try
                        End If
                    End If
                Next



                cnsql = New SqlConnection(constr)
                cnsql.Open()

                For Each dr As DataRow In dtPay.Rows
                    If dr.RowState = DataRowState.Added Then
                        strsql = "Insert Into tbl_payments "
                        strsql &= " Select '" & cbYear.Text.Trim & "' , '" & cbMonth.SelectedIndex + 1 & "' , "
                        strsql &= "(select isnull(max(Pay_ID),0 )+1 from tbl_payments where Pay_Year='" & cbYear.Text.Trim & "' And Pay_Month='" & cbMonth.SelectedIndex + 1 & "') ,"
                        strsql &= "'" & dr.Item("Pay_Desc") & "' , " & dr.Item("Pay_Amount") & "  "

                        cmsql = New SqlCommand(strsql, cnsql)
                        cmsql.ExecuteNonQuery()

                    ElseIf dr.RowState = DataRowState.Modified Then
                        strsql = " update  tbl_payments set "
                        strsql &= " Pay_Desc='" & dr.Item("Pay_Desc") & "' , Pay_Amount=" & dr.Item("Pay_Amount") & " "
                        strsql &= " Where  Pay_Year='" & cbYear.Text.Trim & "' And Pay_Month='" & cbMonth.SelectedIndex + 1 & "'"
                        strsql &= " And Pay_ID=" & dr.Item("Pay_ID") & " "

                        cmsql = New SqlCommand(strsql, cnsql)
                        cmsql.ExecuteNonQuery()

                    ElseIf dr.RowState = DataRowState.Deleted Then
                        strsql = " Delete from   tbl_payments  "
                        strsql &= " Where  Pay_Year='" & cbYear.Text.Trim & "' And Pay_Month='" & cbMonth.SelectedIndex + 1 & "'"
                        strsql &= " And Pay_ID=" & dr.Item("Pay_ID", DataRowVersion.Original) & " "

                        cmsql = New SqlCommand(strsql, cnsql)
                        cmsql.ExecuteNonQuery()

                    End If
                Next




             

                MessageBox.Show("Saved successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearControls(Me, , Nothing) : cbMonth.Enabled = False
                EnableMenuButton(Me, True)
                btnCancel.Enabled = False : btnSave.Enabled = False
                cbYear.Enabled = False
                btnshow.Enabled = False
                cbMonth.SelectedIndex = -1
                cbYear.SelectedIndex = -1
                tdbpay.Visible = False
                btnCopy.Visible = False
                lcchanges = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearControls(Me, , Nothing) : cbMonth.Enabled = False
        EnableMenuButton(Me, True)
        btnCancel.Enabled = False : btnSave.Enabled = False
        cbYear.Enabled = False
        btnshow.Enabled = False
        cbMonth.SelectedIndex = -1
        cbYear.SelectedIndex = -1
        tdbpay.Visible = False
        lcchanges = False
        btnCopy.Enabled = False
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        tdbpay.Visible = True
        btnSave.Enabled = True
        fillDt()
        cbMonth.Enabled = False : cbYear.Enabled = False

        If dtPay.Rows.Count = 0 Then
            btnCopy.Visible = True
            btnCopy.Enabled = True
        End If
      
        lcchanges = False
    End Sub


    Private Sub fillDt()
        Dim cnsql As SqlConnection
        Dim dasql As SqlDataAdapter
        Dim strsql As String
        Dim i As Integer


        Try


            strsql = "  select Pay_ID , Pay_Desc , Pay_Amount  "
            strsql &= " from  tbl_payments  "
            strsql &= " where Pay_Year='" & cbYear.Text & "' "
            strsql &= " and Pay_Month='" & cbMonth.SelectedIndex + 1 & "' "

            cnsql = New SqlConnection(constr)
            cnsql.Open()


            dasql = New SqlDataAdapter(strsql, cnsql)
            dtPay = New DataTable

            dasql.Fill(dtPay)

            tdbpay.DataSource = dtPay.DefaultView
            tdbpay.Splits(0).RecordSelectorWidth = 30
            tdbpay.AllowAddNew = True
            tdbpay.AllowDelete = True
            tdbpay.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Silver
            tdbpay.RowHeight = 22
            tdbpay.ColumnFooters = True
            tdbpay.FooterStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            tdbpay.FooterStyle.ForeColor = Color.Maroon

            tdbpay.FooterStyle.Font = New System.Drawing.Font("Calibri", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            With tdbpay.Splits(0)
                .CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .CaptionStyle.ForeColor = Color.Maroon
                .ColumnCaptionHeight = 25
                .ColumnFooterHeight = 25

                With .DisplayColumns("Pay_ID")
                    .Visible = False
                    .AllowSizing = False : .Width = 0
                End With

                With .DisplayColumns("Pay_Desc")
                    .Width = 500 : .Locked = False
                    .DataColumn.DataWidth = 100
                    .DataColumn.Caption = "Description"
                    .Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                End With

                With .DisplayColumns("Pay_Amount")
                    .Width = 150 : .Locked = False
                    .DataColumn.NumberFormat = "N2"
                    .DataColumn.Caption = "Amount ($) "
                    .DataColumn.DataWidth = 7
                    .Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .ButtonFooter = True
                End With

            End With

            If dtPay.Rows.Count > 0 Then
                tdbpay.Splits(0).DisplayColumns("Pay_Amount").DataColumn.FooterText = dtPay.Compute("Sum(Pay_Amount)", "")
            End If


            For Each column In tdbpay.Splits(0).DisplayColumns
                tdbpay.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                tdbpay.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 10, FontStyle.Bold)
                tdbpay.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                tdbpay.Splits(0).DisplayColumns(i).Style.VerticalAlignment = C1.Win.C1TrueDBGrid.AlignVertEnum.Center
                i = i + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If cnsql.State = ConnectionState.Open Then cnsql.Close() : cnsql = Nothing
            dasql = Nothing
        End Try
    End Sub

    Private Sub tdbpay_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbpay.AfterColEdit
        lcchanges = True
    End Sub

    Private Sub tdbpay_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbpay.AfterColUpdate
        Try

            If e.Column Is tdbpay.Splits(0).DisplayColumns("Pay_Amount") Then
                tdbpay.UpdateData()
                tdbpay.Splits(0).DisplayColumns("Pay_Amount").DataColumn.FooterText = dtPay.Compute("Sum(Pay_Amount)", "")
            End If
           
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbpay_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbpay.AfterDelete
        tdbpay.Splits(0).DisplayColumns("Pay_Amount").DataColumn.FooterText = dtPay.Compute("Sum(Pay_Amount)", "")
    End Sub

    Private Sub tdbpay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbpay.KeyDown
        Try
            If tdbpay.SelectedRows.Count <> 1 Then Exit Try

            If e.KeyCode = Keys.Delete Then
                If MessageBox.Show("Do You want to delete the selected record ?", lctitle, MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub tdbpay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbpay.KeyPress
        Try
            If tdbpay.Splits(0).DisplayColumns(tdbpay.Col).DataColumn.DataField = "Pay_Amount" Then
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

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader
        Dim dr As DataRow

        Try
            If MessageBox.Show("Do You want to Copy Previous Payments ?", lctitle, MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                strsql = "  select Pay_ID , Pay_Desc , Pay_Amount  "
                strsql &= " from  tbl_payments  "
                strsql &= " where Pay_Year='" & cbYear.Text & "' "
                strsql &= " and Pay_Month='" & cbMonth.SelectedIndex & "' "

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                drsql = cmsql.ExecuteReader

                If drsql.HasRows Then
                    While drsql.Read
                        dr = dtPay.NewRow
                        dr.Item("Pay_ID") = drsql.Item("Pay_ID")
                        dr.Item("Pay_Desc") = drsql.Item("Pay_Desc")
                        dr.Item("Pay_Amount") = drsql.Item("Pay_Amount")

                        dtPay.Rows.Add(dr)

                    End While
                End If
                If drsql.IsClosed = False Then drsql.Close()

                btnCopy.Enabled = False
                btnCopy.Visible = False
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing : drsql = Nothing
        End Try

    End Sub
End Class