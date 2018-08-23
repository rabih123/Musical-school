Imports System.Data.SqlClient
Public Class frmlogin
    'Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
    '    Dim strsql As String
    '    Dim cnsql As SqlConnection
    '    Dim cmsql As SqlCommand
    '    Dim dr As SqlDataReader
    '    Try
    '        If txt1.Text.Trim = "" Then
    '            MessageBox.Show("Please enter user name", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            txt1.Focus()
    '        ElseIf txt2.Text.Trim = "" Then
    '            MessageBox.Show("Please enter password", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '            txt2.Focus()
    '        Else
    '            strsql = "select * from tbl_users where usr_code='" & txt1.Text.Trim.Replace("'", "''") & "' and [usr_status]='A' "
    '            cnsql = New SqlConnection(constr)
    '            cnsql.Open()
    '            cmsql = New SqlCommand(strsql, cnsql)
    '            dr = cmsql.ExecuteReader
    '            dr.Read()
    '            If dr.HasRows = True Then
    '                If txt2.Text = dr.Item("usr_pass") Then
    '                    usercode = dr.Item("usr_code").ToString.Trim
    '                    username = dr.Item("usr_name")
    '                    Me.DialogResult = Windows.Forms.DialogResult.OK
    '                Else
    '                    MessageBox.Show("Incorrect password !", "Loggin Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                    txt2.Focus() : txt2.SelectAll()
    '                End If
    '            Else
    '                MessageBox.Show("Username Does Not Exist !", "Loggin Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                txt1.Focus() : txt1.SelectAll()
    '            End If
    '        End If
    '        If Not dr Is Nothing Then dr.Close() : dr = Nothing
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, "Form Loggin", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
    '        cmsql = Nothing
    '    End Try
    'End Sub
    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Button1_Click(btnLogin, Nothing)
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Form Loggin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmlogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            ' frmMain.PnlPass.Visible = False
            '  pnlInfo.Visible = Pb.Visible = False
            Application.DoEvents()
            pnlInfo.Top = (Me.Height / 2) - (pnlInfo.Height / 2) + 30
            pnlInfo.Left = (Me.Width / 2) - (pnlInfo.Width / 2) - 25
            Pb.Top = Me.Top + 30
            Pb.Left = (Me.Width / 2) - (Pb.Width / 2) - 25
            ' pnlInfo.Visible = Pb.Visible = True
            txt1.Focus()
            Application.DoEvents()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Form Loggin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1.Enter, txt2.Enter
        CType(sender, TextBox).BackColor = Color.Bisque
    End Sub

    Private Sub txt1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1.Leave, txt2.Leave
        CType(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim dr As SqlDataReader
        Try
            If txt1.Text.Trim = "" Then
                MessageBox.Show("Please enter user name", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt1.Focus()
            ElseIf txt2.Text.Trim = "" Then
                MessageBox.Show("Please enter password", "login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt2.Focus()
            Else
                strsql = "select * from tbl_users where usr_code='" & txt1.Text.Trim.Replace("'", "''") & "' and [usr_status]='A' "
                cnsql = New SqlConnection(constr)
                cnsql.Open()
                cmsql = New SqlCommand(strsql, cnsql)
                dr = cmsql.ExecuteReader
                dr.Read()
                If dr.HasRows = True Then
                    If txt2.Text = dr.Item("usr_pass") Then
                        usercode = dr.Item("usr_code").ToString.Trim
                        username = dr.Item("usr_name")

                        frmload = New frmMain
                        frmload.Show()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Hide()
                    Else
                        MessageBox.Show("Incorrect password !", "Loggin Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt2.Focus() : txt2.SelectAll()
                    End If
                Else
                    MessageBox.Show("Username Does Not Exist !", "Loggin Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt1.Focus() : txt1.SelectAll()
                End If
            End If
            If Not dr Is Nothing Then dr.Close() : dr = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Form Loggin", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub frmlogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        pnlInfo.Visible = True : Pb.Visible = True : txt1.Focus()
    End Sub
End Class