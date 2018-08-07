Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmRooms
    Dim lctitle As String = "Form Rooms"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation As Boolean

    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRooms_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuRooms.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRooms_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRooms_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3 : If btnadd.Enabled Then btnadd_Click(btnadd, Nothing)
                Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                Case Keys.F5 : If btnDelete.Enabled Then btnDelete_Click(btnDelete, New System.EventArgs)
                Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                Case Keys.F9 : If btnSearch.Enabled Then btnSearch_Click(btnCancel, New System.EventArgs)
                Case Keys.F10 : If btnSave.Enabled Then btnSave_Click(btnSave, New System.EventArgs)
                Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            TxtNo.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            Dim iptr As IntPtr = FindWindow(vbNullString, "Calculator")
            If iptr <> IntPtr.Zero Then
                PostMessage(iptr, Wm_close, IntPtr.Zero, IntPtr.Zero)
            End If
            readonlyy(Me, False)
            EnableDisable(Me, True)
            EnableMenuButton(Me, False, {btnCancel, btnClose, btnSave, btnSearch})
            txtusrstmp.Text = usercode
            txtmode.Text = "ADD"
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = True
            lcmode = "Add"
            rbIndiv.Checked = True
            Txt_Code.Focus()
            TxtNo.Enabled = False
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
            txtmode.Text = "Modify"
            txtusrstmp.Text = usercode
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = False
            Txt_Code.Focus()
            TxtNo.Enabled = False
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

            txtmode.Text = "Delete"
            txtusrstmp.Text = usercode
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = False
            Txt_Code.Focus()
            TxtNo.Enabled = False
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
            txtusrstmp.Text = "----"
            txtmode.Text = "----"
            txtDstmp.Text = "----"
            lcmode = ""
            rbIndiv.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim width() As Integer
        width = {70, 300, 300, 150, 50}
        Try
            Dim frm As search
            Dim strsql As String
            Dim val As String
            If lcmode = "" Then Lclocked = True

            strsql = "select Rom_code as [Code] , Rom_Name as [Description]  , Rom_Note as [Notes],Rom_NoStd as [# Of Students],  "
            strsql &= "case when Rom_Type='I' then 'Individual' else 'Group' End as [Type] "
            strsql &= "from  dbo.tbl_Room where Rom_Active='A' "

            frm = New search
            frm.ShowDialog(strsql, val, Lclocked, width)
            If lcmode = "Modify" Or lcmode = "Delete" Then
                Txt_Code.Text = val
                Txt_Code_Validating(Txt_Code, New CancelEventArgs)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Try
            If MessageBox.Show("Are you sure do you want to Save", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                check(Me, ErrorProvider1)
                If check(Me, ErrorProvider1) = False Then Exit Try
                If RbGrp.Checked = True AndAlso TxtNo.Text = "" Then Exit Try


                cnsql = New SqlConnection(constr)
                cnsql.Open()

                If lcmode = "Add" Then
                    strsql = "insert into tbl_Room select '" & Txt_Code.Text.Trim & "', '" & Txt_desc.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "'" & txtNotes.Text.Trim.Replace("'", "''") & "'," & IIf(rbIndiv.Checked = True, "'I'", "'G'") & ","
                    strsql &= IIf(rbIndiv.Checked = True, "1", TxtNo.Text.Trim) & ", "
                    strsql &= "'A','" & usercode & "',getdate() "


                    cmsql = New SqlCommand(strsql, cnsql)
                    cmsql.ExecuteNonQuery()
                ElseIf lcmode = "Modify" Then
                    strsql = "Update tbl_Room set Rom_Name='" & Txt_desc.Text.Trim.Replace("'", "''") & "',"
                    'strsql &= "Crs_Price=" & txtprice.Text.Trim.Replace("'", "''") & ","
                    strsql &= "Rom_Note='" & txtNotes.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "Rom_Type=" & IIf(rbIndiv.Checked = True, "'I'", "'G'") & ","

                    If RbGrp.Checked = True Then
                        strsql &= "Rom_NoStd=" & TxtNo.Text.Trim.Replace("'", "''") & ","
                    Else
                        strsql &= "Rom_NoStd= 1 ,"
                    End If

                    strsql &= "Rom_DateStmp= getdate () ,"
                    strsql &= "Rom_UsrStmp='" & usercode.Trim & "' "
                    strsql &= "where Rom_code='" & Txt_Code.Text.Trim & "'"
                    cmsql = New SqlCommand(strsql, cnsql)
                    cmsql.ExecuteNonQuery()

                Else
                    strsql = " Update tbl_Room set Rom_Active='N' , "
                    strsql &= " Rom_code=(select top 1 substring(Rom_code,0,4) + cast(ROW_NUMBER() over "
                    strsql &= "(partition by substring(Rom_code,0,4) order by substring(Rom_code,0,4)) as varchar) "
                    strsql &= "from dbo.tbl_Room where  substring(Rom_code,0,4)='" & Txt_Code.Text.Trim & "' order by Rom_code desc)  "
                    strsql &= " where Rom_code='" & Txt_Code.Text.Trim & "'"
                    cmsql = New SqlCommand(strsql, cnsql)
                    cmsql.ExecuteNonQuery()

                End If
                If lcmode = "Add" Then
                    MessageBox.Show("Room added successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_Code.Text = "" : Txt_Code.Focus()
                ElseIf lcmode = "Modify" Then
                    MessageBox.Show("Room Modified successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_Code.Text = "" : readonlyy(Me, True) : Txt_Code.ReadOnly = False : Txt_Code.BackColor = SystemColors.Window : Txt_Code.Focus()
                Else
                    MessageBox.Show("Room Deleted successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_Code.Text = "" : readonlyy(Me, True) : Txt_Code.ReadOnly = False : Txt_Code.BackColor = SystemColors.Window : Txt_Code.Focus()
                End If
            End If
        Catch ex As Exception
            If ex.Message.ToString.Contains("The UPDATE statement conflicted with the REFERENCE constraint") = True Then
                MessageBox.Show("Cannot Deleted , This Room is Reserved ! ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Txt_Code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Code.TextChanged
        Try
            ClearControls(Me, "Txt_Code", ErrorProvider1)
            If lcmode = "Add" Then
                rbIndiv.Checked = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Txt_Code_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_Code.Validating
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand

        Try
            If lcmode = "Add" Then
                strsql = "select Rom_code from tbl_Room where Rom_code='" & Txt_Code.Text.Trim & "' and Rom_Active='A' "

                cnsql = New SqlConnection(constr)
                cnsql.Open()
                cmsql = New SqlCommand(strsql, cnsql)

                If Not cmsql.ExecuteScalar Is Nothing Then
                    MessageBox.Show("Room--- " & Txt_Code.Text.Trim & " ---  Already Exist Choose Another Code", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True : Exit Try
                End If

            End If

            If Txt_Code.Text.Trim <> "" AndAlso lcmode <> "Add" Then
                Populate()
                If lcCancelvalidation = True Then
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub
    Private Sub txt_textChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Code.TextChanged, Txt_desc.TextChanged, txtNotes.TextChanged, TxtNo.TextChanged
        Try
            ErrorProvider1.SetError(CType(sender, TextBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtboxEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Code.Enter, Txt_desc.Enter, txtNotes.Enter, TxtNo.Enter
        Try
            If CType(sender, TextBox).ReadOnly = False Then
                CType(sender, TextBox).BackColor = Color.Bisque
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtboxLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Code.Leave, Txt_desc.Leave, txtNotes.Leave, TxtNo.Leave
        Try
            If CType(sender, TextBox).ReadOnly = False Then
                CType(sender, TextBox).BackColor = Color.White
                If lcmode = "Add" Then Txt_Code.BackColor = System.Drawing.SystemColors.Control
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNo.KeyPress
        Try
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = keyPressValid(e.KeyChar, "Integer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbIndiv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIndiv.CheckedChanged, RbGrp.CheckedChanged
        Try
            If rbIndiv.Checked = True Then
                TxtNo.Text = ""
                TxtNo.Enabled = False
            Else
                TxtNo.Enabled = Enabled
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Populate()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader
        Try
            strsql = "select Rom_code from tbl_Room where Rom_code='" & Txt_Code.Text.Replace("'", "''").Trim & "' and Rom_Active='A' "

            cnsql = New SqlConnection(constr)
            cnsql.Open()
            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteScalar()

            If cmsql.ExecuteScalar = Nothing Then
                MessageBox.Show("Incorrect Room Code.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lcCancelvalidation = True : Exit Try
            End If
            lcCancelvalidation = False
            strsql = "select * from tbl_Room where Rom_code= '" & Txt_Code.Text.Replace("'", "''").Trim & "'"
            cmsql.CommandText = strsql
            drsql = cmsql.ExecuteReader()
            drsql.Read()

            With drsql
                Txt_desc.Text = .Item("Rom_Name")
                txtNotes.Text = .Item("Rom_Note")

                If .Item("Rom_Type").ToString = "I" Then
                    rbIndiv.Checked = True : TxtNo.Enabled = False
                Else
                    RbGrp.Checked = True
                    TxtNo.Text = .Item("Rom_NoStd").ToString
                End If

            End With
            drsql.Close()

            If lcmode = "Modify" Then
                EnableDisable(Me, True)
                readonlyy(Me, False)
            End If

            If lcmode = "Delete" Then
                rbIndiv.AutoCheck = False
                RbGrp.AutoCheck = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub
End Class