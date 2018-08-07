Imports System.Data.SqlClient
Public Class frmUsers
    Private lcStep, lcmode As String
    Private lctitle As String = "Users Form"
    Private lcView As Boolean
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuUser.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            readonlyy(Me, False)
            EnableDisable(Me, True)
            EnableMenuButton(Me, False, {btnCancel, btnClose, btnSave})

            'Lclocked = True
            lcmode = "Add"
            Txt_Code.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try

            EnableDisable(Me, True)
            readonlyy(Me, True)
            Txt_Code.ReadOnly = False
            lcmode = "Modify"
            EnableMenuButton(Me, True, {btnadd, btnModify, btnDelete})
            Txt_Code.Focus() : btncode.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            EnableDisable(Me, True)
            readonlyy(Me, True)
            Txt_Code.ReadOnly = False
            lcmode = "Delete"
            EnableMenuButton(Me, True, {btnadd, btnModify, btnDelete})
            Txt_Code.Focus() : btncode.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            ClearControls(Me, , ErrorProvider1)
            EnableDisable(Me, False)
            EnableMenuButton(Me, True)
            btnCancel.Enabled = False : btnSave.Enabled = False
            Txt_Code.ReadOnly = False : btncode.Enabled = False
            lcmode = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmUsers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3 : If btnadd.Enabled Then btnadd_Click(btnadd, Nothing)
                Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                Case Keys.F5 : If btnDelete.Enabled Then btnDelete_Click(btnDelete, New System.EventArgs)
                Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                Case Keys.F10 : If btnSave.Enabled Then btnSave_Click(btnSave, New System.EventArgs)
                Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txtboxEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Code.Enter, TxtName.Enter, TxtPass1.Enter, TxtPass2.Enter
        Try
            'If CType(sender, TextBox).ReadOnly = False Then
            CType(sender, TextBox).BackColor = Color.Bisque
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtboxLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Code.Leave, TxtName.Leave, TxtPass1.Leave, TxtPass2.Leave
        Try
            'If CType(sender, TextBox).ReadOnly = False Then
            CType(sender, TextBox).BackColor = Color.White
            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txt_textChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Code.TextChanged, TxtName.TextChanged, TxtPass1.TextChanged, TxtPass2.TextChanged
        Try
            If CType(sender, TextBox).Name = "Txt_Code" Then
                ClearControls(Me, "Txt_Code", ErrorProvider1)
            End If
            ErrorProvider1.SetError(CType(sender, TextBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction
        Dim Menus() As String
        Dim i As Integer
        Try
            If MessageBox.Show("Are you sure do you want to Save", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                check(Me, ErrorProvider1)
                If check(Me, ErrorProvider1) = False Then Exit Try

                Menus = getmenuname()

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                trsql = cnsql.BeginTransaction

                If lcmode = "Add" Then
                    strsql = "Insert into tbl_users values ('" & Txt_Code.Text.Trim.Replace("'", "''") & "','" & TxtPass1.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "'" & TxtName.Text.Trim.Replace("'", "''") & "','A', getdate() )"

                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                    strsql = ""
                    For i = 1 To Menus.GetUpperBound(0)
                        strsql &= "Insert into tbl_privileges values ('" & Txt_Code.Text.Trim.Replace("'", "''") & "','" & Menus(i) & "','N');"
                    Next

                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                ElseIf lcmode = "Modify" Then
                    strsql = "Update tbl_users set usr_pass='" & TxtPass1.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "usr_name='" & TxtName.Text.Trim.Replace("'", "''") & "' "
                    strsql &= "where usr_code='" & Txt_Code.Text.Trim & "'"
                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                Else
                    strsql = "Update tbl_users set usr_status='N' where usr_code='" & Txt_Code.Text.Trim & "'"
                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                    strsql = "delete from tbl_privileges where priv_usr='" & Txt_Code.Text.Trim & "'"
                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()

                End If

                trsql.Commit()
                If lcmode = "Add" Then
                    MessageBox.Show("User added successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_Code.Text = ""
                ElseIf lcmode = "Modify" Then
                    MessageBox.Show("User Modified successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_Code.Text = "" : readonlyy(Me, True) : Txt_Code.ReadOnly = False : Txt_Code.Focus()
                Else
                    MessageBox.Show("User Deleted successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_Code.Text = "" : readonlyy(Me, True) : Txt_Code.ReadOnly = False : Txt_Code.Focus()
                End If
            End If
        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing : trsql = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncode.Click
        Dim width() As Integer
        width = {70, 300}
        Try
            Dim frm As search
            Dim strsql As String
            Dim val As String
            'If lcmode = "" 'Then Lclocked = True
            strsql = "select usr_code as [User code],usr_name as [User name] from tbl_users  "
            strsql &= "where usr_status='A' and usr_code <>'SU' "
            frm = New search
            frm.ShowDialog(strsql, val, False, width)
            If lcmode = "Modify" Or lcmode = "Delete" Then
                Txt_Code.Text = val
                Txt_Code_Validating(Txt_Code, New System.ComponentModel.CancelEventArgs)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

           If lcView = False Then
                EnableMenuButton(Me, False, {btnClose})
            End If
            btnCancel.Enabled = False : btnSave.Enabled = False
            btncode.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Txt_Code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_Code.Validating
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader
        Dim strsql As String

        Try
            If Txt_Code.Text.Trim <> "" Then
                If Txt_Code.Text.Trim = "SU" Then
                    MessageBox.Show("Forbidden To use 'SU' User", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True : Txt_Code.Text = "" : Exit Try
                End If

                strsql = "select usr_code from tbl_users where usr_code='" & Txt_Code.Text.Trim & "' And usr_status='A' "
                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                cmsql.ExecuteScalar()

                If lcmode = "Add" Then
                    If Not cmsql.ExecuteScalar Is Nothing Then
                        MessageBox.Show("This User Already Exist", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True : Txt_Code.Text = ""
                    End If
                Else
                    If cmsql.ExecuteScalar Is Nothing Then
                        MessageBox.Show("Invalid User Code", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        e.Cancel = True : Txt_Code.Text = ""
                    Else
                        strsql = "select * from tbl_users where usr_code='" & Txt_Code.Text.Trim.Replace("'", "''") & "'"
                        cmsql.CommandText = strsql
                        drsql = cmsql.ExecuteReader
                        drsql.Read()
                        TxtName.Text = drsql.Item("usr_name")
                        TxtPass1.Text = drsql.Item("usr_pass")
                        TxtPass2.Text = drsql.Item("usr_pass")
                        drsql.Close()
                        If lcmode = "Modify" Then
                            readonlyy(Me, False)
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If lblpa.Text.Trim.Substring(0, 1) = "S" Then
                TxtPass1.PasswordChar = ""
                TxtPass2.PasswordChar = ""
                lblpa.Text = "Hide Password"
            Else
                TxtPass1.PasswordChar = "*"
                TxtPass2.PasswordChar = "*"
                lblpa.Text = "Show Password"
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtPass2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtPass2.Validating
        Try
            If TxtPass2.Text.Trim <> "" Then
                If TxtPass1.Text.Trim <> "" Then
                    If TxtPass2.Text.Trim <> TxtPass1.Text.Trim Then
                        ErrorProvider1.SetError(TxtPass2, "Password Didn't Match") : e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class