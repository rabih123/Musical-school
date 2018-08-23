Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.IO

Public Class frmStudents
    Dim lctitle As String = "Form Students"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation As Boolean
    Dim im As String = "NULL"
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmStudents_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            frmload.MnuStudents.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmStudents_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            'If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
            'e.Cancel = True : Exit Try
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmStudents_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3 : If btnadd.Enabled Then btnadd_Click(btnadd, Nothing)
                Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                Case Keys.F5 : If btnDelete.Enabled Then btnDelete_Click(btnDelete, New System.EventArgs)
                Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                Case Keys.F9 : If btnSearch.Enabled Then btnSearch_Click(btnCancel, New System.EventArgs)
                Case Keys.F10 : If btnSave.Enabled Then btnSave_Click(btnSave, New System.EventArgs)
                Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
                Case Keys.Escape : LblPhoto.Visible = False : LblPhoto.SendToBack()
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmStudents_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            txtusrstmp.Text = "----"
            txtmode.Text = "----"
            txtDstmp.Text = "----"
            LblPhoto.Visible = False
            LblPhoto.SendToBack()

            BtnPhoto.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            readonlyy(Me, False)
            EnableDisable(Me, True)
            Txt_id.ReadOnly = True
            EnableMenuButton(Me, False, {btnCancel, btnClose, btnSave, btnSearch})
            txtusrstmp.Text = usercode
            txtmode.Text = "ADD"
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = True
            lcmode = "Add"
            txtName.Focus()

            Txt_id.Text = getstudentid()
            rbMale.Checked = True
            BtnPhoto.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtboxEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtage.Enter, Txt_id.Enter, txtLname.Enter, txtAdrs.Enter, txtRem.Enter, TxtPhone.Enter, txtName.Enter
        Try
            If CType(sender, TextBox).ReadOnly = False Then
                CType(sender, TextBox).BackColor = Color.Bisque
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_id.KeyPress, txtage.KeyPress
        Try
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = keyPressValid(e.KeyChar, "Integer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtboxLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtage.Leave, Txt_id.Leave, txtLname.Leave, txtAdrs.Leave, txtRem.Leave, TxtPhone.Leave, txtName.Leave
        Try
            If CType(sender, TextBox).ReadOnly = False Then
                CType(sender, TextBox).BackColor = Color.White
                If lcmode = "Add" Then Txt_id.BackColor = System.Drawing.SystemColors.Control
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim width() As Integer
        width = {70, 150, 150, 50, 50, 150, 200, 200, 50}
        Try
            Dim frm As search
            Dim strsql As String
            Dim val As String
            If lcmode = "" Then Lclocked = True
            strsql = "select std_id as [Student id],std_name as [Name],std_Lname as [Last Name], "
            strsql &= "std_age as [Age], Std_Sex as [Sex],std_phoneno as [Phone #],std_address as [Address], "
            strsql &= "std_remarq as [Remark] ,Case When Std_Special='Y' then 'Yes' else 'No' End as [Special] from tbl_Students where std_status='A' "
            frm = New search
            frm.ShowDialog(strsql, val, Lclocked, width)
            If lcmode = "Modify" Or lcmode = "Delete" Then
                Txt_id.Text = val
                Txt_id_Validating(Txt_id, New CancelEventArgs)
                txtName.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim ms As MemoryStream
        Dim ArrImg() As Byte
        Dim trsql As SqlTransaction

        Try
            If MessageBox.Show("Are you sure do you want to Save", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                check(Me, ErrorProvider1)
                If check(Me, ErrorProvider1) = False Then Exit Try

                If txtage.Text.Trim = "" Then
                    Exit Try
                End If

                cnsql = New SqlConnection(constr)
                cnsql.Open()
                trsql = cnsql.BeginTransaction


                'If txtPrice.Text.Trim <> txtPrice.Tag Then
                '    strsql = "select top 1 1 from tbl_vouchers where vch_stdid=" & Txt_id.Text.Trim
                '    cmsql = New SqlCommand(strsql, cnsql)

                '    If Not cmsql.ExecuteScalar Is Nothing Then
                '        MessageBox.Show("This Student Have Vouchers Registred You cant Change the Price Here Change it from the courses form.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '        txtPrice.Text = txtPrice.Tag : Exit Try
                '    End If

                'End If

                If lcmode = "Add" Then
                    strsql = "insert into tbl_Students select " & Txt_id.Text.Trim & ", '" & txtName.Text.Trim.Replace("'", "''") & "','" & txtLname.Text.Trim.Replace("'", "''") & "',"
                    strsql &= txtage.Text.Trim & "," & IIf(rbfemale.Checked, "'F'", "'M'").ToString & ",'" & TxtPhone.Text.Trim.Replace("'", "''") & "','" & txtAdrs.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "'" & txtRem.Text.Trim.Replace("'", "''") & "', NULL ,"
                    strsql &= IIf(ChkSpecial.Checked = True, "'Y'", "'N'") & ","
                    strsql &= "'A', getdate() ,'" & usercode & "'"

                    If Not pb.Image Is Nothing Then
                        strsql &= "," & im & " "
                    Else
                        strsql &= ",NULL "
                    End If

                    cmsql = New SqlCommand(strsql, cnsql, trsql)

                    If Not pb.Image Is Nothing Then
                        If im = "@Image" Then
                            ms = New MemoryStream
                            pb.Image.Save(ms, pb.Image.RawFormat)
                            ArrImg = ms.GetBuffer
                            cmsql.Parameters.Add("@Image", SqlDbType.Image).Value = ArrImg
                        End If
                    End If
                    cmsql.ExecuteNonQuery()


                ElseIf lcmode = "Modify" Then
                    strsql = "Update tbl_Students set std_name='" & txtName.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "std_Lname='" & txtLname.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "std_age=" & txtage.Text.Trim.Replace("'", "''") & ","
                    strsql &= "std_sex=" & IIf(rbfemale.Checked, "'F'", "'M'") & ","
                    strsql &= "std_phoneno='" & TxtPhone.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "std_address='" & txtAdrs.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "std_remarq='" & txtRem.Text.Trim.Replace("'", "''") & "',"
                    'strsql &= "std_Price=" & txtPrice.Text.Trim & ","
                    strsql &= "Std_Special=" & IIf(ChkSpecial.Checked = True, "'Y'", "'N'") & " "
                    ' strsql &= "std_datestmp= getdate () ,"
                    ' strsql &= "std_usrstmp='" & usercode.Trim & "' "

                    If Not pb.Image Is Nothing Then
                        strsql &= ",std_Image=" & im & " "
                    Else
                        strsql &= ",std_Image=NULL "
                    End If

                    strsql &= "where std_id=" & Txt_id.Text.Trim
                    cmsql = New SqlCommand(strsql, cnsql, trsql)

                    If Not pb.Image Is Nothing Then
                        If im = "@Image" Then
                            ms = New MemoryStream
                            pb.Image.Save(ms, pb.Image.RawFormat)
                            ArrImg = ms.GetBuffer
                            cmsql.Parameters.Add("@Image", SqlDbType.Image).Value = ArrImg
                        End If
                    End If

                    cmsql.ExecuteNonQuery()

                Else
                    strsql = "Update tbl_Students set std_status='D' where std_id=" & Txt_id.Text.Trim
                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()


                    strsql = "Update tbl_sessions set Ses_StdId=NULL  Where Ses_StdId=" & Txt_id.Text.Trim
                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()


                    strsql = " delete from tbl_profStdCrs where PrS_Stdid=" & Txt_id.Text.Trim
                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()

                End If
                trsql.Commit()

                If lcmode = "Add" Then
                    MessageBox.Show("Student added successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_id.Text = "" : Txt_id.Text = getstudentid() : txtName.Focus()
                ElseIf lcmode = "Modify" Then
                    MessageBox.Show("Student Modified successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_id.Text = "" : readonlyy(Me, True) : Txt_id.ReadOnly = False : Txt_id.BackColor = SystemColors.Window : Txt_id.Focus()
                Else
                    MessageBox.Show("Student Deleted successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_id.Text = "" : readonlyy(Me, True) : Txt_id.ReadOnly = False : Txt_id.BackColor = SystemColors.Window : Txt_id.Focus()
                End If
            End If
        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            ClearControls(Me, , ErrorProvider1)
            EnableDisable(Me, False)

            EnableMenuButton(Me, True)
            btnCancel.Enabled = False : btnSave.Enabled = False
            txtusrstmp.Text = "----"
            txtmode.Text = "----"
            txtDstmp.Text = "----"
            lcmode = ""
            'txtPrice.Tag = ""

            LblPhoto.Visible = False
            LblPhoto.SendToBack()
            BtnPhoto.Enabled = False
            pb.Image = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_id.TextChanged
        Try
            ClearControls(Me, "Txt_id", ErrorProvider1) ' txtPrice.Tag = ""
            LblPhoto.Visible = False
            LblPhoto.SendToBack()
            pb.Image = Nothing
            rbMale.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            EnableDisable(Me, True)
            readonlyy(Me, True)
            Txt_id.ReadOnly = False
            lcmode = "Modify"
            EnableMenuButton(Me, True, {btnadd, btnModify, btnDelete})
            rbfemale.Enabled = False : rbMale.Enabled = False
            txtmode.Text = "Modify"
            txtusrstmp.Text = usercode
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = False
            Txt_id.Focus()
            BtnPhoto.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Populate()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader
        Dim ms As MemoryStream
        Dim arrImg() As Byte

        Try
            strsql = "select std_id from tbl_Students where std_id=" & Txt_id.Text.Replace("'", "''").Trim & " and std_status='A' "

            cnsql = New SqlConnection(constr)
            cnsql.Open()
            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteScalar()

            If cmsql.ExecuteScalar = Nothing Then
                MessageBox.Show("Incorrect Student Id!", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lcCancelvalidation = True : Exit Try
            End If
            lcCancelvalidation = False
            strsql = "select * from tbl_Students where std_id= " & Txt_id.Text.Replace("'", "''").Trim
            cmsql.CommandText = strsql
            drsql = cmsql.ExecuteReader()
            drsql.Read()

            With drsql
                txtName.Text = .Item("std_name")
                txtLname.Text = .Item("std_Lname")
                TxtPhone.Text = .Item("std_phoneno")
                txtAdrs.Text = .Item("std_address")
                txtRem.Text = .Item("std_remarq")
                'txtPrice.Text = .Item("std_Price")
                'txtPrice.Tag = .Item("std_Price")
                txtage.Text = .Item("std_age")
                If .Item("Std_Sex") = "M" Then
                    rbMale.Checked = True
                Else
                    rbfemale.Checked = True
                End If

                If Not .Item("Std_Special") Is DBNull.Value Then
                    If .Item("Std_Special") = "Y" Then
                        ChkSpecial.Checked = True
                    Else
                        ChkSpecial.Checked = False
                    End If
                Else
                    ChkSpecial.Checked = False
                End If

                If drsql.Item("std_Image") Is DBNull.Value Then
                    pb.Image = Nothing : im = "NULL"
                Else
                    arrImg = CType(drsql.Item("std_Image"), Byte())
                    MS = New MemoryStream(arrImg)
                    pb.Image = Image.FromStream(MS)
                End If

            End With
            drsql.Close()

            If lcmode = "Modify" Then
                EnableDisable(Me, True)
                readonlyy(Me, False)
            End If

            If lcmode = "Delete" Then
                ChkSpecial.AutoCheck = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub Txt_id_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_id.Validating
        Try
            If Txt_id.Text.Trim <> "" AndAlso lcmode <> "Add" Then
                Populate()
                If lcCancelvalidation = True Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            EnableDisable(Me, True)
            readonlyy(Me, True)
            Txt_id.ReadOnly = False
            lcmode = "Delete"
            EnableMenuButton(Me, True, {btnadd, btnModify, btnDelete})
            rbfemale.Enabled = False : rbMale.Enabled = False
            txtmode.Text = "Delete"
            txtusrstmp.Text = usercode
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = False
            Txt_id.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txt_textChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtage.TextChanged, Txt_id.TextChanged, txtLname.TextChanged, txtAdrs.TextChanged, txtRem.TextChanged, TxtPhone.TextChanged, txtName.TextChanged
        Try
            ErrorProvider1.SetError(CType(sender, TextBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  
    Private Sub btnopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnopen.Click
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            pb.ImageLocation = ofd.FileName
            im = "@Image"
        End If
    End Sub

    Private Sub BtnPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPhoto.Click
        LblPhoto.Visible = True
        LblPhoto.BringToFront()
    End Sub
End Class