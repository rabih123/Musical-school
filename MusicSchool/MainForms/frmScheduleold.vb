Imports System.Data.SqlClient
Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid
Public Class frmScheduleold

    Dim lctitle As String = "Form Schedule"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges, NewSched As Boolean
    Dim dtSchd As DataTable
    Dim daSchd As SqlDataAdapter
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchedule_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuProfSched.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchedule_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchedule_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Try
                Select Case e.KeyCode
                    'Case Keys.F3 : If btnadd.Enabled Then btnadd_Click(btnadd, Nothing)
                    Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                        'Case Keys.F5 : If btnDelete.Enabled Then btnDelete_Click(btnDelete, New System.EventArgs)
                    Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                        'Case Keys.F9 : If btnSearch.Enabled Then btnSearch_Click(btnCancel, New System.EventArgs)
                    Case Keys.F10 : If btnSave.Enabled Then btnSave_Click(btnSave, New System.EventArgs)
                    Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
                End Select
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            btnCancel.Enabled = False : btnSave.Enabled = False

            lcchanges = False
            CbProff.BackColor = Color.White
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            CbProff.Enabled = True : btnModify.Enabled = False
            'EnableDisable(Me, True)
            btnSave.Enabled = True : btnCancel.Enabled = True
            fillComboBox()
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
            strsql = "Select -5 as prf_id ,'Select an Professor' as prf_name from tbl_instruments union select prf_id,prf_name+ ' '+ prf_lname as prf_name  from tbl_professors where prf_status='A' "
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            ClearControls(Me, , ErrorProvider1) : CbProff.SelectedIndex = 0 : EnableDisable(Me, False)
            btnCancel.Enabled = False : btnSave.Enabled = False : btnModify.Enabled = True : NewSched = False : TxtNotes.BackColor = System.Drawing.SystemColors.Control
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Overrides Sub OnMouseWheel(ByVal e As MouseEventArgs)
        Dim mwe As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        If Me.ActiveControl Is CbProff Then
            mwe.Handled = True
        End If
    End Sub

    Private Sub CbProff_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CbProff.MouseWheel
        OnMouseWheel(e)
    End Sub

    Private Sub CbProff_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbProff.SelectedIndexChanged
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader

        Try
            'ClearControls(Me, , ErrorProvider1)
            If CbProff.SelectedIndex > 0 Then

                ChkMonday.Enabled = True : Chktue.Enabled = True : Chkwed.Enabled = True : chkThur.Enabled = True : chkFrid.Enabled = True : chkSat.Enabled = True
                ChkMonday.Checked = False : Chktue.Checked = False : Chkwed.Checked = False : chkThur.Checked = False : chkFrid.Checked = False : chkSat.Checked = False
                TxtNotes.Enabled = True : TxtNotes.Text = "" : TxtNotes.BackColor = Color.White

                strsql = "Select * from tbl_schedule where scd_ProfID = " & CbProff.SelectedValue
                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                drsql = cmsql.ExecuteReader()

                If drsql.HasRows Then
                    drsql.Read()

                    If drsql.Item("scd_Mond") = "N" OrElse drsql.Item("scd_Mond") Is DBNull.Value Then
                        ChkMonday.Checked = False
                    Else
                        ChkMonday.Checked = True
                        txtMond1.Text = drsql.Item("scd_MondFrom") : txtMond2.Text = drsql.Item("scd_MondTo")
                    End If

                    If drsql.Item("scd_Tue") Is DBNull.Value OrElse drsql.Item("scd_Tue") = "N" Then
                        Chktue.Checked = False
                    Else
                        Chktue.Checked = True
                        TxtTue1.Text = drsql.Item("scd_TueFrom") : Txttue2.Text = drsql.Item("scd_TueTo")
                    End If

                    If drsql.Item("scd_Wed") Is DBNull.Value OrElse drsql.Item("scd_Wed") = "N" Then
                        Chkwed.Checked = False
                    Else
                        Chkwed.Checked = True
                        txtwed1.Text = drsql.Item("scd_WedFrom") : txtwed2.Text = drsql.Item("scd_WedTo")
                    End If

                    If drsql.Item("scd_Thur") Is DBNull.Value OrElse drsql.Item("scd_Thur") = "N" Then
                        chkThur.Checked = False
                    Else
                        chkThur.Checked = True
                        txtthur1.Text = drsql.Item("scd_ThurFrom") : txtThur2.Text = drsql.Item("scd_ThurTo")
                    End If

                    If drsql.Item("scd_Frid") Is DBNull.Value OrElse drsql.Item("scd_Frid") = "N" Then
                        chkFrid.Checked = False
                    Else
                        chkFrid.Checked = True
                        txtFrid1.Text = drsql.Item("scd_FridFrom") : txtFrid2.Text = drsql.Item("scd_FridTo")
                    End If

                    If drsql.Item("scd_Sat") Is DBNull.Value OrElse drsql.Item("scd_Sat") = "N" Then
                        chkSat.Checked = False
                    Else
                        chkSat.Checked = True
                        txtSat1.Text = drsql.Item("scd_SatFrom") : txtSat2.Text = drsql.Item("scd_SatTo")
                    End If

                    If Not drsql.Item("Scd_Note") Is DBNull.Value Then
                        TxtNotes.Text = drsql.Item("Scd_Note")
                    End If

                    drsql.Close()
                    NewSched = False
                Else
                    NewSched = True
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : drsql = Nothing
        End Try
    End Sub

    Private Sub ChkMonday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMonday.CheckedChanged, Chktue.CheckedChanged, Chkwed.CheckedChanged, chkThur.CheckedChanged, chkFrid.CheckedChanged, chkSat.CheckedChanged
        Dim chk As CheckBox
        Try
            chk = CType(sender, CheckBox)

            Select Case chk.Name
                Case "ChkMonday"
                    If chk.Checked = True Then
                        pnlMond.BackColor = Color.LightCoral
                        txtMond1.Enabled = True : txtMond2.Enabled = True
                        txtMond1.BackColor = Color.White : txtMond2.BackColor = Color.White
                    Else
                        pnlMond.BackColor = System.Drawing.SystemColors.Control
                        txtMond1.Text = "" : txtMond2.Text = ""
                        txtMond1.Enabled = False : txtMond2.Enabled = False
                        txtMond1.BackColor = System.Drawing.SystemColors.Control : txtMond2.BackColor = System.Drawing.SystemColors.Control
                        ErrorProvider1.SetError(txtMond1, "") : ErrorProvider1.SetError(txtMond2, "")
                    End If

                Case "Chktue"
                    If chk.Checked = True Then
                        pnlTue.BackColor = Color.LightCoral
                        TxtTue1.Enabled = True : Txttue2.Enabled = True
                        TxtTue1.BackColor = Color.White : Txttue2.BackColor = Color.White
                    Else
                        pnlTue.BackColor = System.Drawing.SystemColors.Control
                        TxtTue1.Text = "" : Txttue2.Text = ""
                        TxtTue1.Enabled = False : Txttue2.Enabled = False
                        TxtTue1.BackColor = System.Drawing.SystemColors.Control : Txttue2.BackColor = System.Drawing.SystemColors.Control
                        ErrorProvider1.SetError(TxtTue1, "") : ErrorProvider1.SetError(Txttue2, "")
                    End If

                Case "Chkwed"
                    If chk.Checked = True Then
                        pnlWed.BackColor = Color.LightCoral
                        txtwed1.Enabled = True : txtwed2.Enabled = True
                        txtwed1.BackColor = Color.White : txtwed2.BackColor = Color.White
                    Else
                        pnlWed.BackColor = System.Drawing.SystemColors.Control
                        txtwed1.Text = "" : txtwed2.Text = ""
                        txtwed1.Enabled = False : txtwed2.Enabled = False
                        txtwed1.BackColor = System.Drawing.SystemColors.Control : txtwed2.BackColor = System.Drawing.SystemColors.Control
                        ErrorProvider1.SetError(txtwed1, "") : ErrorProvider1.SetError(txtwed2, "")
                    End If

                Case "chkThur"
                    If chk.Checked = True Then
                        pnlThur.BackColor = Color.LightCoral
                        txtthur1.Enabled = True : txtThur2.Enabled = True
                        txtthur1.BackColor = Color.White : txtThur2.BackColor = Color.White
                    Else
                        pnlThur.BackColor = System.Drawing.SystemColors.Control
                        txtthur1.Text = "" : txtThur2.Text = ""
                        txtthur1.Enabled = False : txtThur2.Enabled = False
                        txtthur1.BackColor = System.Drawing.SystemColors.Control : txtThur2.BackColor = System.Drawing.SystemColors.Control
                        ErrorProvider1.SetError(txtthur1, "") : ErrorProvider1.SetError(txtThur2, "")
                    End If

                Case "chkFrid"
                    If chk.Checked = True Then
                        pnlFrid.BackColor = Color.LightCoral
                        txtFrid1.Enabled = True : txtFrid2.Enabled = True
                        txtFrid1.BackColor = Color.White : txtFrid2.BackColor = Color.White
                    Else
                        pnlFrid.BackColor = System.Drawing.SystemColors.Control
                        txtFrid1.Text = "" : txtFrid2.Text = ""
                        txtFrid1.Enabled = False : txtFrid2.Enabled = False
                        txtFrid1.BackColor = System.Drawing.SystemColors.Control : txtFrid2.BackColor = System.Drawing.SystemColors.Control
                        ErrorProvider1.SetError(txtFrid1, "") : ErrorProvider1.SetError(txtFrid2, "")
                    End If

                Case "chkSat"
                    If chk.Checked = True Then
                        pnlSat.BackColor = Color.LightCoral
                        txtSat1.Enabled = True : txtSat2.Enabled = True
                        txtSat1.BackColor = Color.White : txtSat2.BackColor = Color.White
                    Else
                        pnlSat.BackColor = System.Drawing.SystemColors.Control
                        txtSat1.Text = "" : txtSat2.Text = ""
                        txtSat1.Enabled = False : txtSat2.Enabled = False
                        txtSat1.BackColor = System.Drawing.SystemColors.Control : txtSat2.BackColor = System.Drawing.SystemColors.Control
                        ErrorProvider1.SetError(txtSat1, "") : ErrorProvider1.SetError(txtSat2, "")
                    End If

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            chk = Nothing
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand

        Try
            If MessageBox.Show("Are yous ure do you want to save ?", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If LenghtTime() = False Then Exit Try

                cnsql = New SqlConnection(constr)
                cnsql.Open()


                If NewSched = True Then
                    strsql = "Insert into tbl_schedule values(" & CbProff.SelectedValue & "," & IIf(ChkMonday.Checked = True, "'Y'", "'N'") & ","
                    strsql &= IIf(txtMond1.Enabled = False, "null", "'" & txtMond1.Text.Trim & "'") & "," & IIf(txtMond2.Enabled = False, "null", "'" & txtMond2.Text.Trim & "'") & ","
                    strsql &= IIf(Chktue.Checked = True, "'Y'", "'N'") & ","
                    strsql &= IIf(TxtTue1.Enabled = False, "null", "'" & TxtTue1.Text.Trim & "'") & "," & IIf(Txttue2.Enabled = False, "null", "'" & Txttue2.Text.Trim & "'") & ","
                    strsql &= IIf(Chkwed.Checked = True, "'Y'", "'N'") & ","
                    strsql &= IIf(txtwed1.Enabled = False, "null", "'" & txtwed1.Text.Trim & "'") & "," & IIf(txtwed2.Enabled = False, "null", "'" & txtwed2.Text.Trim & "'") & ","
                    strsql &= IIf(chkThur.Checked = True, "'Y'", "'N'") & ","
                    strsql &= IIf(txtthur1.Enabled = False, "null", "'" & txtthur1.Text.Trim & "'") & "," & IIf(txtThur2.Enabled = False, "null", "'" & txtThur2.Text.Trim & "'") & ","
                    strsql &= IIf(chkFrid.Checked = True, "'Y'", "'N'") & ","
                    strsql &= IIf(txtFrid1.Enabled = False, "null", "'" & txtFrid1.Text.Trim & "'") & "," & IIf(txtFrid2.Enabled = False, "null", "'" & txtFrid2.Text.Trim & "'") & ","
                    strsql &= IIf(chkSat.Checked = True, "'Y'", "'N'") & ","
                    strsql &= IIf(txtSat1.Enabled = False, "null", "'" & txtSat1.Text.Trim & "'") & "," & IIf(txtSat2.Enabled = False, "null", "'" & txtSat2.Text.Trim & "'")
                    strsql &= ",'" & TxtNotes.Text.Trim.Replace("'", "''") & "','" & usercode & "',getdate() )"
                    cmsql = New SqlCommand(strsql, cnsql)
                    cmsql.ExecuteNonQuery()
                    NewSched = False
                Else
                    strsql = "Update tbl_schedule set "
                    strsql &= "[scd_Mond] = " & IIf(ChkMonday.Checked = True, "'Y'", "'N'") & ","
                    strsql &= "[scd_MondFrom]= " & IIf(txtMond1.Enabled = False, "null", "'" & txtMond1.Text.Trim & "'") & ","
                    strsql &= "[scd_MondTo]= " & IIf(txtMond2.Enabled = False, "null", "'" & txtMond2.Text.Trim & "'") & ","
                    strsql &= "[scd_Tue]= " & IIf(Chktue.Checked = True, "'Y'", "'N'") & ","
                    strsql &= "[scd_TueFrom]= " & IIf(TxtTue1.Enabled = False, "null", "'" & TxtTue1.Text.Trim & "'") & ","
                    strsql &= "[scd_TueTo]= " & IIf(Txttue2.Enabled = False, "null", "'" & Txttue2.Text.Trim & "'") & ","
                    strsql &= "[scd_Wed]= " & IIf(Chkwed.Checked = True, "'Y'", "'N'") & ","
                    strsql &= "[scd_WedFrom]= " & IIf(txtwed1.Enabled = False, "null", "'" & txtwed1.Text.Trim & "'") & ","
                    strsql &= "[scd_WedTo]= " & IIf(txtwed2.Enabled = False, "null", "'" & txtwed2.Text.Trim & "'") & ","
                    strsql &= "[scd_Thur]= " & IIf(chkThur.Checked = True, "'Y'", "'N'") & ","
                    strsql &= "[scd_ThurFrom]= " & IIf(txtthur1.Enabled = False, "null", "'" & txtthur1.Text.Trim & "'") & ","
                    strsql &= "[scd_ThurTo]= " & IIf(txtThur2.Enabled = False, "null", "'" & txtThur2.Text.Trim & "'") & ","
                    strsql &= "[scd_Frid]= " & IIf(chkFrid.Checked = True, "'Y'", "'N'") & ","
                    strsql &= "[scd_FridFrom]= " & IIf(txtFrid1.Enabled = False, "null", "'" & txtFrid1.Text.Trim & "'") & ","
                    strsql &= "[scd_FridTo]= " & IIf(txtFrid2.Enabled = False, "null", "'" & txtFrid2.Text.Trim & "'") & ","
                    strsql &= "[scd_Sat]= " & IIf(chkSat.Checked = True, "'Y'", "'N'") & ","
                    strsql &= "[scd_SatFrom]= " & IIf(txtSat1.Enabled = False, "null", "'" & txtSat1.Text.Trim & "'") & ","
                    strsql &= "[scd_SatTo]= " & IIf(txtSat2.Enabled = False, "null", "'" & txtSat2.Text.Trim & "'") & ","
                    strsql &= "[Scd_Note]= '" & TxtNotes.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "[scd_usrStamp]= '" & usercode & "',"
                    strsql &= "[scd_datstamp]= getdate() "
                    strsql &= "Where [scd_ProfID]=" & CbProff.SelectedValue
                    cmsql = New SqlCommand(strsql, cnsql)
                    cmsql.ExecuteNonQuery()
                End If

                MessageBox.Show("Profressor Schedule Updated . ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCancel_Click(sender, New EventArgs)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub txtMond1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMond1.KeyDown, txtMond2.KeyDown, TxtTue1.KeyDown, Txttue2.KeyDown, txtwed1.KeyDown, txtwed2.KeyDown, txtthur1.KeyDown, txtThur2.KeyDown, txtFrid1.KeyDown, txtFrid2.KeyDown, txtSat1.KeyDown, txtSat2.KeyDown
        Dim val As String

        Try
            val = CType(sender, MaskedTextBox).Text.Replace(":", "")

            If e.KeyData.ToString.Substring(0, 1) = "D" Then
                If val.Trim.Length = 0 Then
                    If e.KeyData <> Keys.D1 AndAlso e.KeyData <> Keys.D0 Then
                        e.SuppressKeyPress = True
                    End If
                    'ElseIf val.Trim.Length = 1 Then
                    'If e.KeyData <> Keys.D1 AndAlso e.KeyData <> Keys.D2 AndAlso e.KeyData <> Keys.D0 Then
                    'e.SuppressKeyPress = True
                    'End If
                ElseIf val.Trim.Length = 2 Then
                    If (e.KeyValue > 53 OrElse e.KeyValue < 48) Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 4 Then
                    If e.KeyValue <> Keys.A AndAlso e.KeyValue <> Keys.P Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 6 Then
                    If e.KeyValue <> Keys.M Then
                        e.SuppressKeyPress = True
                    End If
                End If
            Else
                If val.Trim.Length = 0 Then
                    If (e.KeyData <> Keys.NumPad1 AndAlso e.KeyData <> Keys.NumPad0) Then
                        e.SuppressKeyPress = True
                    End If
                    'ElseIf val.Trim.Length = 1 Then
                    'If e.KeyData <> Keys.NumPad1 AndAlso e.KeyData <> Keys.NumPad2 AndAlso e.KeyData <> Keys.NumPad0 Then
                    'e.SuppressKeyPress = True
                    ' End If
                ElseIf val.Trim.Length = 2 Then
                    If e.KeyValue > 102 OrElse e.KeyValue < 96 Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 4 Then
                    If e.KeyValue <> Keys.A AndAlso e.KeyValue <> Keys.P Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 6 Then
                    If e.KeyValue <> Keys.M Then
                        e.SuppressKeyPress = True
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function LenghtTime() As Boolean
        Dim ctr As Control
        Dim flg As Boolean = True
        Try
            For Each ctr In Me.Controls
                If ctr.GetType Is GetType(MaskedTextBox) Then
                    If ctr.Text.Trim.Length < 8 AndAlso ctr.Enabled = True Then
                        ctr.Focus() : ErrorProvider1.SetError(ctr, "Invalid Time Format") : flg = False
                    End If
                End If
            Next
            Return flg
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub txt_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMond2.MouseUp, txtMond1.MouseUp, TxtTue1.MouseUp, Txttue2.MouseUp, txtwed1.MouseUp, txtwed2.MouseUp, txtthur1.MouseUp, txtThur2.MouseUp, txtFrid1.MouseUp, txtFrid2.MouseUp, txtSat1.MouseUp, txtSat2.MouseUp
        If CType(sender, MaskedTextBox).Text.Trim.Length = 1 Then
            CType(sender, MaskedTextBox).SelectionStart = 0
            CType(sender, MaskedTextBox).Select(0, 0)
            'txtMond2.SelectionLength = 8
            'SendKeys.Send("{HOME}")
        End If
    End Sub

    Private Sub chk_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMond2.TextChanged, txtMond1.TextChanged, TxtTue1.TextChanged, Txttue2.TextChanged, txtwed1.TextChanged, txtwed2.TextChanged, txtthur1.TextChanged, txtThur2.TextChanged, txtFrid1.TextChanged, txtFrid2.TextChanged, txtSat1.TextChanged, txtSat2.TextChanged
        Try
            ErrorProvider1.SetError(CType(sender, MaskedTextBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtMond1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtMond1.MaskInputRejected

    End Sub
End Class