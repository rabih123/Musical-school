
Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class frmProff
    Dim lctitle As String = "Form Professors"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation As Boolean
    Dim dt As DataTable
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProff_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuProff.Checked = False
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
            Txt_id.Text = getProfId() : TxtName.Focus()
            fillCourses()
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
            txtmode.Text = "Modify"
            txtusrstmp.Text = usercode
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = False
            Txt_id.Focus()
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
            txtmode.Text = "Delete"
            txtusrstmp.Text = usercode
            txtDstmp.Text = Now.ToString("dd/MM/yyyy  hh:mm tt")
            Lclocked = False
            Txt_id.Focus()
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
            PnlCrs.Controls.Clear()
            txtusrstmp.Text = "----"
            txtmode.Text = "----"
            txtDstmp.Text = "----"
            lcmode = ""
            Txt_id.Tag = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim width() As Integer
        width = {70, 150, 150, 100, 150, 150, 70}
        Try
            Dim frm As search
            Dim strsql As String
            Dim val As String
            If lcmode = "" Then Lclocked = True
            strsql = "select prf_id as [Professor id],prf_name as [Name],prf_lname as [Last Name], "
            strsql &= "prf_tel as [Phone #],prf_addres as [Address],PrfCrs_Crs as [Instrument] , "
            strsql &= "PrfCrs_Price as [Prof %] from tbl_professors "
            strsql &= "Inner join tbl_ProfCourse on PrfCrs_Prof=prf_id "
            strsql &= "where prf_status='A' "
            frm = New search
            frm.ShowDialog(strsql, val, Lclocked, width)
            If lcmode = "Modify" Or lcmode = "Delete" Then
                Txt_id.Text = val
                Txt_id_Validating(Txt_id, New CancelEventArgs)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmProff_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProff_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmProff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtboxEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_id.Enter, Txt_id.Enter, txtAdress.Enter, txtLname.Enter, TxtName.Enter, txtPhone.Enter
        Try
            If CType(sender, TextBox).ReadOnly = False Then
                CType(sender, TextBox).BackColor = Color.Bisque
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtboxLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_id.Leave, Txt_id.Leave, txtAdress.Leave, txtLname.Leave, TxtName.Leave, txtPhone.Leave
        Try
            If CType(sender, TextBox).ReadOnly = False Then
                CType(sender, TextBox).BackColor = Color.White
                If lcmode = "Add" Then Txt_id.BackColor = System.Drawing.SystemColors.Control
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txt_textChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdress.TextChanged, txtLname.TextChanged, TxtName.TextChanged, txtPhone.TextChanged
        Try
            ErrorProvider1.SetError(CType(sender, TextBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillCourses()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim da As SqlDataAdapter

        Dim dr As DataRow
        Dim txt As TextBox
        Dim chk As CheckBox
        Dim i As Integer
        Try
            strsql = "Select case when not PrfCrs_Price IS null Then 'Y' else 'N' End as [Checked],"
            strsql &= "case when not PrfCrs_Price IS null Then 'Y' else 'N' End as [OldChecked], "
            strsql &= "Crs_Code , Crs_Desc ,PrfCrs_Price  from tbl_courses "
            strsql &= "left join tbl_ProfCourse on Crs_Code=PrfCrs_Crs and PrfCrs_Prof=" & IIf(Txt_id.Text.Trim = "", "NULL", Txt_id.Text.Trim)
            strsql &= " Where Crs_Actice='A' "
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            da = New SqlDataAdapter(strsql, cnsql)
            dt = New DataTable
            da.Fill(dt)

            'CbInstruments.DataSource = dt

            'CbInstruments.ValueMember = "ins_id"
            'CbInstruments.DisplayMember = "ins_desc"
            i = 5
            For Each dr In dt.Rows
                chk = New CheckBox
                chk.Name = "Chk" & dr.Item("Crs_Code")
                chk.Text = dr.Item("Crs_Desc")

                chk.BackColor = Color.FromArgb(255, 255, 128)

                If dr.Item("Checked") = "Y" Then
                    chk.Checked = True
                    chk.BackColor = Color.Red
                    chk.ForeColor = Color.White
                Else
                    chk.Checked = False
                End If

                chk.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
                'ChkEnter(chk, New System.EventArgs)
                AddHandler chk.CheckedChanged, AddressOf ChkEnter

                chk.Left = 5
                chk.Width = 80
                chk.Top = i


                PnlCrs.Controls.Add(chk)

                txt = New TextBox
                txt.Name = "Txt" & dr.Item("Crs_Code")
                txt.Text = IIf(dr.Item("PrfCrs_Price") Is DBNull.Value, "", dr.Item("PrfCrs_Price"))
                txt.Font = New System.Drawing.Font("Calibri", 10.25!, System.Drawing.FontStyle.Bold)
                txt.Left = 100
                txt.Top = i
                txt.MaxLength = 4
                txt.BackColor = Color.White
                txt.ForeColor = Color.Red
                txt.TextAlign = HorizontalAlignment.Center

                If dr.Item("Checked") = "Y" Then
                    txt.ReadOnly = False
                Else
                    txt.ReadOnly = True
                End If
                AddHandler txt.KeyPress, AddressOf TxtPerc_KeyPress
                AddHandler txt.Enter, AddressOf txtboxEnter
                AddHandler txt.Leave, AddressOf txtboxLeave
                AddHandler txt.TextChanged, AddressOf Txt_

                PnlCrs.Controls.Add(txt)

                i = i + 30
            Next



        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            da = Nothing : txt = Nothing : chk = Nothing
        End Try
    End Sub

    Private Sub TxtPerc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) <> 8 Then

                If CType(sender, TextBox).Text.Contains(".") = True AndAlso e.KeyChar = "." Then
                    e.Handled = True : Exit Try
                End If

                e.Handled = keyPressValid(e.KeyChar, "Decimal")
                If e.Handled = True Then Exit Try
                'If TxtPerc.Text.Trim <> "" Then
                '    If TxtPerc.Text.Trim + e.KeyChar > 100 OrElse TxtPerc.Text.Trim + e.KeyChar <= 0 Then
                '        e.Handled = True
                '    End If
                'End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction
        Dim ctr As Control

        Try
            If MessageBox.Show("Are you sure do you want to Save", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                               MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

               

                Lccheck(Me, ErrorProvider1)
                If Lccheck(Me, ErrorProvider1) = False Then Exit Try

                If CheckCourses(1) = False Then
                    MessageBox.Show("Select At Least One Course ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Try
                End If

                CheckCourses(2)
                If CheckCourses(2) = False Then Exit Try

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                trsql = cnsql.BeginTransaction

                If lcmode = "Add" Then
                    strsql = "Insert into tbl_professors values ('" & TxtName.Text.Trim.Replace("'", "''") & "','" & txtLname.Text.Trim.Replace("'", "''") & "',NULL,"
                    strsql &= "'" & txtPhone.Text.Trim.Replace("'", "''") & "','" & txtAdress.Text.Trim.Replace("'", "''") & "',NULL,'A',getdate(), '" & usercode & "')"

                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                    For Each ctr In PnlCrs.Controls
                        If ctr.GetType Is GetType(TextBox) Then
                            If CType(ctr, TextBox).Text.Trim <> "" Then
                                strsql = "Insert into tbl_ProfCourse select " & Txt_id.Text.Trim & ",'" & CType(ctr, TextBox).Name.Remove(0, 3) & "',"
                                strsql &= CType(ctr, TextBox).Text.Trim & " "
                                cmsql.CommandText = strsql
                                cmsql.ExecuteNonQuery()
                            End If
                        End If
                    Next

                ElseIf lcmode = "Modify" Then
                    strsql = "Update tbl_professors set prf_name='" & TxtName.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "prf_lname='" & txtLname.Text.Trim.Replace("'", "''") & "',"
                    'strsql &= "prf_InstId=" & CbInstruments.SelectedValue & ","
                    strsql &= "prf_tel='" & txtPhone.Text.Trim.Replace("'", "''") & "',"
                    strsql &= "prf_addres='" & txtAdress.Text.Trim.Replace("'", "''") & "',"
                    'strsql &= "prf_perc=" & TxtPerc.Text.Trim.Replace("'", "''") & ","
                    strsql &= "prf_datestmp= getdate () ,"
                    strsql &= "prf_usrstmp='" & usercode.Trim & "' "
                    strsql &= "where prf_id=" & Txt_id.Text.Trim
                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                    strsql = "Delete from tbl_ProfCourse where PrfCrs_Prof=" & Txt_id.Text.Trim
                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()

                    For Each ctr In PnlCrs.Controls
                        If ctr.GetType Is GetType(TextBox) Then
                            If CType(ctr, TextBox).Text.Trim <> "" Then
                                strsql = "Insert into tbl_ProfCourse select " & Txt_id.Text.Trim & ",'" & CType(ctr, TextBox).Name.Remove(0, 3) & "',"
                                strsql &= CType(ctr, TextBox).Text.Trim & " "
                                cmsql.CommandText = strsql
                                cmsql.ExecuteNonQuery()
                            End If
                        End If
                    Next

                Else
                    strsql = "Update tbl_professors set prf_status='D' where prf_id=" & Txt_id.Text.Trim
                    cmsql = New SqlCommand(strsql, cnsql, trsql)
                    cmsql.ExecuteNonQuery()

                    strsql = "Delete from tbl_ProfCourse where PrfCrs_Prof=" & Txt_id.Text.Trim
                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()


                End If

                trsql.Commit()

                If lcmode = "Add" Then
                    MessageBox.Show("Professor added successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_id.Text = "" : Txt_id.Text = getProfId() : fillCourses()
                ElseIf lcmode = "Modify" Then
                    MessageBox.Show("Professor Modified successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_id.Text = "" : readonlyy(Me, True) : Txt_id.ReadOnly = False : Txt_id.BackColor = SystemColors.Window : Txt_id.Focus()
                Else
                    MessageBox.Show("Professor Deleted successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Txt_id.Text = "" : readonlyy(Me, True) : Txt_id.ReadOnly = False : Txt_id.BackColor = SystemColors.Window : Txt_id.Focus()
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

    Private Sub Txt_id_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_id.Validating
        Try
            If Txt_id.Text.Trim <> "" AndAlso lcmode <> "Add" Then
                If Txt_id.Text.Trim <> Txt_id.Tag Then
                    Populate()
                End If
                If lcCancelvalidation = True Then
                    e.Cancel = True
                End If
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
        Dim ctr As Control

        Try
            strsql = "select prf_id from tbl_professors where prf_id=" & Txt_id.Text.Replace("'", "''").Trim & " and prf_status='A' "

            cnsql = New SqlConnection(constr)
            cnsql.Open()
            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteScalar()

            If cmsql.ExecuteScalar = Nothing Then
                MessageBox.Show("Incorrect Professor Id!", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lcCancelvalidation = True : Exit Try
            End If
            lcCancelvalidation = False
            strsql = "select * from tbl_professors where prf_id= " & Txt_id.Text.Replace("'", "''").Trim
            cmsql.CommandText = strsql
            drsql = cmsql.ExecuteReader()
            drsql.Read()

            With drsql
                TxtName.Text = .Item("prf_name")
                txtLname.Text = .Item("prf_lname")
                txtPhone.Text = .Item("prf_tel")
                txtAdress.Text = .Item("prf_addres")
                'TxtPerc.Text = .Item("prf_perc")
                'CbInstruments.SelectedValue = .Item("prf_InstId")
            End With
            drsql.Close()

            If lcmode = "Modify" Then
                EnableDisable(Me, True)
                readonlyy(Me, False)
            End If

            fillCourses()

            If lcmode = "Delete" Then
                readonlyy(Me, True)
                For Each ctr In PnlCrs.Controls
                    If ctr.GetType Is GetType(CheckBox) Then
                        CType(ctr, CheckBox).AutoCheck = False
                    End If
                Next
                Txt_id.ReadOnly = False
            End If

            Txt_id.Tag = Txt_id.Text.Trim

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing : ctr = Nothing : drsql = Nothing
        End Try
    End Sub

    Private Sub Txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_id.TextChanged
        Try
            ClearControls(Me, "Txt_id", ErrorProvider1)
            PnlCrs.Controls.Clear()
            Txt_id.Tag = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Txt_(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ErrorProvider1.SetError(CType(sender, TextBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Txt_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_id.KeyPress
        Try
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = keyPressValid(e.KeyChar, "Integer")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChkEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ctrl As Control
        Try
            If CType(sender, CheckBox).Checked = True Then

                CType(sender, CheckBox).BackColor = Color.Red
                CType(sender, CheckBox).ForeColor = Color.White

                For Each ctrl In PnlCrs.Controls
                    If ctrl.GetType Is GetType(TextBox) Then
                        If CType(ctrl, TextBox).Name.Remove(0, 3) =
                                    CType(sender, CheckBox).Name.Remove(0, 3) Then
                            CType(ctrl, TextBox).ReadOnly = False
                            CType(ctrl, TextBox).Focus()
                        End If
                    End If
                Next
            Else
                For Each ctrl In PnlCrs.Controls

                    CType(sender, CheckBox).BackColor = Color.Transparent
                    CType(sender, CheckBox).ForeColor = Color.Black

                    If ctrl.GetType Is GetType(TextBox) Then
                        If CType(ctrl, TextBox).Name.Remove(0, 3) = CType(sender, CheckBox).Name.Remove(0, 3) Then
                            CType(ctrl, TextBox).ReadOnly = True
                            CType(ctrl, TextBox).Text = ""
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            Throw ex
        Finally
            ctrl = Nothing
        End Try
    End Sub

    Public Function Lccheck(ByRef _Prt As Control, ByRef ep As ErrorProvider)
        Dim ctr As Control
        Dim x As Integer
        Try
            For Each ctr In _Prt.Controls
                If ctr.Name <> "PnlCrs" Then
                    If ctr.GetType Is GetType(TextBox) Then
                        If CType(ctr, TextBox).Text = "" Then
                            ep.SetError(ctr, "Please Fill this Field")
                            x = 1
                        End If
                    ElseIf ctr.GetType Is GetType(MaskedTextBox) Then
                        If CType(ctr, MaskedTextBox).Text = "" Then
                            ep.SetError(ctr, "Please Fill this Field")
                            x = 1
                        End If
                    ElseIf ctr.Controls.Count > 0 Then
                        check(ctr, ep)
                    End If
                End If
            Next
            If (x = 1) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            ctr = Nothing
        End Try
    End Function

    Private Function CheckCourses(ByVal _Case As Integer) As Boolean
        Dim ctr, ctr2 As Control
        Dim x As Integer
        Try
            '''' Case 1  To Check If A Course IS SELECTED
            '''' cASE 2 To Check If the selected course if his  price is set
            If _Case = 1 Then
                For Each ctr In PnlCrs.Controls
                    If ctr.GetType Is GetType(CheckBox) Then
                        If CType(ctr, CheckBox).Checked = True Then
                            PnlCrs.Focus()
                            Return True
                        End If
                    End If
                Next
            ElseIf _Case = 2 Then
                For Each ctr In PnlCrs.Controls
                    If ctr.GetType Is GetType(CheckBox) Then
                        If CType(ctr, CheckBox).Checked = True Then

                            For Each ctr2 In PnlCrs.Controls
                                If ctr2.GetType Is GetType(TextBox) Then
                                    If CType(ctr2, TextBox).Name.Remove(0, 3) = CType(ctr, CheckBox).Name.Remove(0, 3) Then
                                        If CType(ctr2, TextBox).Text = "" Then
                                            ErrorProvider1.SetError(ctr2, "Please Fill the Price")
                                            x = 1
                                        End If
                                    End If
                                End If
                            Next

                        End If
                    End If
                Next

                If x = 1 Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            ctr = Nothing : ctr2 = Nothing
        End Try

    End Function
End Class