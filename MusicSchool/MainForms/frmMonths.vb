Imports System.Data.SqlClient

Public Class frmMonths
    Dim lctitle As String = "Form Special Months"
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

    Private Sub frmMonths_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuSpecialMonth.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub frmMonths_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    Try
    '        If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
    '            e.Cancel = True : Exit Try
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub frmMonths_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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


    Private Sub frmMonths_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ' If usercode <> "SU" Then
            '    If getPrivliges(usercode, lcStep) = Nothing OrElse getPrivliges(usercode, lcStep) = False Then
            '        lcView = False
            '    Else
            '        lcView = True
            '    End If
            'Else
            '    lcView = True
            'End If

            If lcStep = "&B- Special Months" Then
                EnableDisable(Me, False, False)
                btnSave.Visible = False : btnSave.SendToBack()
                btnClose.Visible = True : btnClose.BringToFront()
                filldata()
            Else
                btnSave.Visible = True : btnSave.BringToFront()
                btnClose.Visible = False : btnClose.SendToBack()
            End If


            LblYear.Text = Now.Year

            'If lcView = False Then
            '    EnableMenuButton(Me, False, {btnClose})
            'End If
            'btnCancel.Enabled = False : btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        EnableDisable(Me, True, False)
        btnCancel.Enabled = True
        btnModify.Enabled = False
        LblYear.Text = Now.Year
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            ClearControls(Me, "", Nothing)
            'EnableMenuButton(Me, True)
            btnCancel.Enabled = False : btnSave.Enabled = False
            btnModify.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim ctr As Control
        Dim strsql As String
        Dim cnsql As sqlconnection
        Dim cmsql As sqlcommand

        Try
            For Each ctr In grpMonths.Controls
                If ctr.GetType Is GetType(CheckBox) Then
                    If CType(ctr, CheckBox).Checked = True AndAlso TxtTot.Text.Trim = "" Then
                        MessageBox.Show("Specify The discount Amount First", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TxtTot.Focus() : Exit Try
                    End If
                End If
            Next


            cnsql = New SqlConnection(constr)
            cnsql.Open()


            For Each ctr In grpMonths.Controls
                If ctr.GetType Is GetType(CheckBox) Then
                    If CType(ctr, CheckBox).Checked = True Then
                        strsql = "Insert into  tbl_SpecMonths select "
                        strsql &= CInt(LblYear.Text.Trim) & "," & CType(ctr, CheckBox).Tag & "," & TxtTot.Text.Trim

                        cmsql = New SqlCommand(strsql, cnsql)
                        cmsql.ExecuteNonQuery()
                    End If
                End If
            Next


            DialogResult = Windows.Forms.DialogResult.OK
            MessageBox.Show(" Done , Now Proceeding to the Next Step", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtTot_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTot.Enter
        CType(sender, TextBox).BackColor = Color.Bisque
    End Sub

    Private Sub TxtTot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTot.KeyPress
        Try
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = keyPressValid(e.KeyChar, "Integer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TxtTot_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTot.Leave
        CType(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub filldata()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader

        Try

            strsql = "select * from tbl_SpecMonths where Spc_Year=" & Now.Year

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)
            drsql = cmsql.ExecuteReader()

            If drsql.HasRows = True Then

                While drsql.Read


                    Select Case drsql.Item("Spc_Month")
                        Case 1 : ChkJan.Checked = True : If ChkJan.Checked = True Then TxtJan.BackColor = Color.Gold
                        Case 2 : ChkFeb.Checked = True : If ChkFeb.Checked = True Then TxtFeb.BackColor = Color.Gold
                        Case 3 : ChkMar.Checked = True : If ChkMar.Checked = True Then TxtMar.BackColor = Color.Gold
                        Case 4 : ChkApr.Checked = True : If ChkApr.Checked = True Then TxtApr.BackColor = Color.Gold
                        Case 5 : ChkMay.Checked = True : If ChkMay.Checked = True Then TxtMay.BackColor = Color.Gold
                        Case 6 : ChkJune.Checked = True : If ChkJune.Checked = True Then TxtJune.BackColor = Color.Gold
                        Case 7 : ChkJuly.Checked = True : If ChkJuly.Checked = True Then TxtJul.BackColor = Color.Gold
                        Case 8 : ChkAug.Checked = True : If ChkAug.Checked = True Then TxtAug.BackColor = Color.Gold
                        Case 9 : ChkSep.Checked = True : If ChkSep.Checked = True Then TxtSep.BackColor = Color.Gold
                        Case 10 : ChkOct.Checked = True : If ChkOct.Checked = True Then TxtOct.BackColor = Color.Gold
                        Case 11 : ChkNov.Checked = True : If ChkNov.Checked = True Then TxtNov.BackColor = Color.Gold
                        Case 12 : ChkDec.Checked = True : If ChkDec.Checked = True Then TxtDec.BackColor = Color.Gold
                    End Select

                    TxtTot.Text = drsql.Item("Spc_Amount")

                End While

                drsql.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : drsql = Nothing
        End Try
    End Sub
End Class