Imports System.Data.SqlClient

Public Class frmVouchers
    Dim lctitle As String = "Form Student Vouchers"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges As Boolean
    Dim dt As DataTable
    ' Dim dacourse As SqlDataAdapter
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        Dim cnsql As SqlConnection
        Dim da As SqlDataAdapter
        Dim dr As DataRow
        Dim strsql As String
        Dim ctr As Control
        Dim drsql As SqlDataReader
        Dim cmsql As SqlCommand

        Try
            If cbStudent.SelectedIndex < 1 Then ErrorProvider1.SetError(cbStudent, "Select Student First") : Exit Try

            If cbYear.Text.Trim = "" Then ErrorProvider1.SetError(cbYear, "Select A Year") : Exit Try

            GroupBox1.Visible = True
            'ClearControls(Me, "cbStudent", ErrorProvider1)

            For Each ctr In GroupBox1.Controls
                If ctr.GetType Is GetType(TextBox) Then
                    ctr.BackColor = Color.Brown : ctr.ForeColor = Color.White
                    ctr.Text = ""
                Else
                    If ctr.GetType Is GetType(CheckBox) Then
                        CType(ctr, CheckBox).Checked = False
                    End If
                End If
            Next
            Timer1.Stop()

            btnshow.BackColor = Color.Brown : btnshow.ForeColor = Color.White

            strsql = "select max(std_name) as [Name], SUM(vch_total) +(SUM(isnull(Disc_DiscManount,0))) -  case when isnull(max(Std_Special),'')='Y' then isnull(max(Spc_Amount),0) else 0 end as [TotalW%],"
            strsql &= "sum(std_Price) as [Total],MAX(Vch_year) as [Year], "
            strsql &= "MAX(vch_month) as [Month] ,MAX(vch_paid) as [Paid] "
            strsql &= "from tbl_vouchers "
            strsql &= "left join tbl_Students on std_id=vch_stdid "
            strsql &= "left join tbl_SpecMonths on Spc_Month=Vch_NumMonth and Spc_Year=Vch_year "
            strsql &= "left join tbl_ProfStdMnthDisc on Disc_ProfStdId=vch_stdid and Disc_Type='Std' and Disc_Year=Vch_year and Disc_Month=Vch_NumMonth "
            strsql &= "where std_status='A' and std_id='" & cbStudent.SelectedValue & "' and Vch_year='" & cbYear.Text & "' "
            strsql &= "group by vch_stdid,Vch_year,vch_month "

            cnsql = New SqlConnection(constr)
            cnsql.Open()
            dt = New DataTable
            da = New SqlDataAdapter(strsql, cnsql)
            da.Fill(dt)

            For Each dr In dt.Rows
                If dr.Item(4) = "January" Then
                    TxtJan.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkJan.Checked = True : TxtJan.BackColor = Color.Gold : TxtJan.ForeColor = Color.Brown
                    Else
                        ChkJan.Checked = False : TxtJan.BackColor = Color.Brown : TxtJan.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "February" Then
                    TxtFeb.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkFeb.Checked = True : TxtFeb.BackColor = Color.Gold : TxtFeb.ForeColor = Color.Brown
                    Else
                        ChkFeb.Checked = False : TxtFeb.BackColor = Color.Brown : TxtFeb.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "March" Then
                    TxtMar.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkMar.Checked = True : TxtMar.BackColor = Color.Gold : TxtMar.ForeColor = Color.Brown
                    Else
                        ChkMar.Checked = False : TxtMar.BackColor = Color.Brown : TxtMar.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "April" Then
                    TxtApr.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkApr.Checked = True : TxtApr.BackColor = Color.Gold : TxtApr.ForeColor = Color.Brown
                    Else
                        ChkApr.Checked = False : TxtApr.BackColor = Color.Brown : TxtApr.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "May" Then
                    TxtMay.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkMay.Checked = True : TxtMay.BackColor = Color.Gold : TxtMay.ForeColor = Color.Brown
                    Else
                        ChkMay.Checked = False : TxtMay.BackColor = Color.Brown : TxtMay.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "June" Then
                    TxtJune.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkJune.Checked = True : TxtJune.BackColor = Color.Gold : TxtJune.ForeColor = Color.Brown
                    Else
                        ChkJune.Checked = False : TxtJune.BackColor = Color.Brown : TxtJune.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "July" Then
                    TxtJul.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkJuly.Checked = True : TxtJul.BackColor = Color.Gold : TxtJul.ForeColor = Color.Brown
                    Else
                        ChkJuly.Checked = False : TxtJul.BackColor = Color.Brown : TxtJul.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "August" Then
                    TxtAug.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkAug.Checked = True : TxtAug.BackColor = Color.Gold : TxtAug.ForeColor = Color.Brown
                    Else
                        ChkAug.Checked = False : TxtAug.BackColor = Color.Brown : TxtAug.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "September" Then
                    TxtSep.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkSep.Checked = True : TxtSep.BackColor = Color.Gold : TxtSep.ForeColor = Color.Brown
                    Else
                        ChkSep.Checked = False : TxtSep.BackColor = Color.Brown : TxtSep.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "October" Then
                    TxtOct.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkOct.Checked = True : TxtOct.BackColor = Color.Gold : TxtOct.ForeColor = Color.Brown
                    Else
                        ChkOct.Checked = False : TxtOct.BackColor = Color.Brown : TxtOct.ForeColor = Color.White
                    End If

                End If

                If dr.Item(4) = "November" Then
                    TxtNov.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkNov.Checked = True : TxtNov.BackColor = Color.Gold : TxtNov.ForeColor = Color.Brown
                    Else
                        ChkNov.Checked = False : TxtNov.BackColor = Color.Brown : TxtNov.ForeColor = Color.White
                    End If
                End If

                If dr.Item(4) = "December" Then
                    TxtDec.Text = " " & dr.Item(1) & " $"
                    If dr.Item(5).ToString.Trim = "Y" Then
                        ChkDec.Checked = True : TxtDec.BackColor = Color.Gold : TxtDec.ForeColor = Color.Brown
                    Else
                        ChkDec.Checked = False : TxtDec.BackColor = Color.Brown : TxtDec.ForeColor = Color.White
                    End If
                End If

            Next

            strsql = "select Crs_Desc, prf_name+' '+prf_lname as [Name] "
            strsql &= "from tbl_profStdCrs "
            strsql &= "inner join tbl_professors on PrS_Prf=Prf_id "
            strsql &= "inner join tbl_courses on Prs_Crs=Crs_Code "
            strsql &= "where PrS_Stdid =" & cbStudent.SelectedValue

            cmsql = New SqlCommand(strsql, cnsql)
            drsql = cmsql.ExecuteReader

            lblCrs.Text = "" : LblProf.Text = ""

            While drsql.Read
                lblCrs.Text = lblCrs.Text & drsql.Item("Crs_Desc") & " - "
                LblProf.Text = LblProf.Text & drsql.Item("Name") & " - "
            End While

            lblCrs.Text = lblCrs.Text.Substring(0, lblCrs.Text.Length - 2)
            LblProf.Text = LblProf.Text.Substring(0, LblProf.Text.Length - 2)

            Pnlhide.SendToBack() : Pnlhide.Visible = False
            grpInfo.BringToFront() : grpInfo.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            drsql = Nothing : da = Nothing : cmsql = Nothing
        End Try
    End Sub

    Private Sub frmVouchers_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuVoucher.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmVouchers_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmVouchers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmVouchers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            'EnableDisable1(Me, False)
            'readonlyy1(Me, True)

            GroupBox1.Visible = False
            If lcView = False Then
                EnableMenuButton(Me, False, {btnClose})
            End If
            btnCancel.Enabled = False : btnSave.Enabled = False : btnshow.Enabled = False
            cbStudent.Enabled = False : cbYear.Enabled = False
            Pnlhide.BringToFront() : Pnlhide.Visible = True



            Dim strsql As String
            Dim cnsql As SqlConnection
            Dim da As SqlDataAdapter
            Dim dt As DataTable
            Try
                strsql = "select -20 as Std_id , 'Select A Student' as name  union select Std_id , cast(Std_id as varchar(9)) +'  -  ' + std_name+' '+std_Lname as [name] "
                strsql &= "from tbl_Students "
                strsql &= "Inner join tbl_profStdCrs on PrS_Stdid=std_id "
                strsql &= "Inner Join tbl_vouchers on std_id=vch_stdid "
                strsql &= "where std_status = 'A' "
                cnsql = New SqlConnection(constr)
                cnsql.Open()
                da = New SqlDataAdapter(strsql, cnsql)
                dt = New DataTable
                da.Fill(dt)

                Dim col As New AutoCompleteStringCollection
                Dim i As Integer

                For i = 0 To dt.Rows.Count - 1
                    col.Add(dt.Rows(i)("name").ToString())
                Next
                'TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
                'TextBox1.AutoCompleteCustomSource = col
                'TextBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "")
            End Try


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
            strsql = "select -20 as Std_id , 'Select A Student' as name  union select Std_id , cast(Std_id as varchar(9)) +'  -  ' + std_name+' '+std_Lname as [name] "
            strsql &= "from tbl_Students "
            strsql &= "Inner join tbl_profStdCrs on PrS_Stdid=std_id "
            strsql &= "Inner Join tbl_vouchers on std_id=vch_stdid "
            strsql &= "where std_status = 'A' "
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            da = New SqlDataAdapter(strsql, cnsql)
            dt = New DataTable
            da.Fill(dt)

            cbStudent.DataSource = dt

            cbStudent.ValueMember = "Std_id"
            cbStudent.DisplayMember = "name"

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            ' EnableDisable1(Me, True)
            cbStudent.Enabled = True : cbYear.Enabled = True : cbMonth.Enabled = True
            btnSave.Enabled = True : btnCancel.Enabled = True
            fillComboBox() : btnshow.Enabled = True : btnModify.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub EnableDisable1(ByRef _Prt As Control, ByVal _Val As Boolean)
        Dim ctr As Control
        Try
            For Each ctr In _Prt.Controls
                If ctr.GetType Is GetType(TextBox) OrElse ctr.GetType Is GetType(PictureBox) OrElse ctr.GetType _
Is GetType(RadioButton) OrElse ctr.GetType Is GetType(CheckBox) OrElse ctr.GetType Is GetType(DateTimePicker) OrElse _
 ctr.GetType Is GetType(ComboBox) OrElse ctr.GetType Is GetType(MaskedTextBox) Then
                    ctr.Enabled = _Val
                ElseIf ctr.Controls.Count > 0 Then
                    EnableDisable(ctr, _Val)
                End If
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ctr = Nothing
        End Try
    End Sub

    Public Sub readonlyy1(ByRef _Prt As Control, ByVal _Val As Boolean)
        Dim ctr As Control
        Try
            For Each ctr In _Prt.Controls
                If ctr.GetType Is GetType(TextBox) Then
                    CType(ctr, TextBox).ReadOnly = _Val
                    'If _Val = True Then
                    '    ctr.BackColor = SystemColors.Control
                    'Else
                    '    ctr.BackColor = SystemColors.Window
                    'End If
                ElseIf ctr.Controls.Count > 0 Then
                    readonlyy(ctr, _Val)
                End If

            Next
        Catch ex As Exception
            Throw ex
        Finally
            ctr = Nothing
        End Try
    End Sub

    
    Private Sub cbStudent_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbStudent.SelectedIndexChanged
        Dim ctr As Control
        Try
            ErrorProvider1.SetError(cbStudent, "")

            For Each ctr In GroupBox1.Controls
                If ctr.GetType Is GetType(TextBox) Then
                    ctr.BackColor = Color.Brown : ctr.ForeColor = Color.White
                    ctr.Text = ""
                Else
                    If ctr.GetType Is GetType(CheckBox) Then
                        CType(ctr, CheckBox).Checked = False
                    End If
                End If
            Next
            cbMonth.SelectedIndex = -1
            Pnlhide.BringToFront() : Pnlhide.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbYear.SelectedIndexChanged
        Try
            ErrorProvider1.SetError(cbYear, "")

            For Each ctr In GroupBox1.Controls
                If ctr.GetType Is GetType(TextBox) Then
                    ctr.BackColor = Color.Brown : ctr.ForeColor = Color.White
                    ctr.Text = ""
                Else
                    If ctr.GetType Is GetType(CheckBox) Then
                        CType(ctr, CheckBox).Checked = False
                    End If
                End If
            Next

            If cbYear.Text <> "" AndAlso cbStudent.SelectedIndex > 0 Then
                Timer1.Start()
            End If
            cbMonth.SelectedIndex = -1
            Pnlhide.BringToFront() : Pnlhide.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Pnlhide.BringToFront() : Pnlhide.Visible = True
            ClearControls(Me, , ErrorProvider1) : cbMonth.Enabled = False
            EnableMenuButton(Me, True)
            btnCancel.Enabled = False : btnSave.Enabled = False
            cbStudent.Enabled = False : cbYear.Enabled = False
            btnshow.Enabled = False : Timer1.Stop()
            cbMonth.SelectedIndex = -1
            cbYear.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoopSearch1_TxtChanged(sender As Object, e As EventArgs) Handles LoopSearch1.TxtChanged
        MsgBox("")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String
        Try
            If MessageBox.Show("Are you sure do you want to Save", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                              MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then


                If cbMonth.Text.Trim = "" Then
                    MessageBox.Show("Select The Month.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cbMonth.Focus() : Exit Try
                End If

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                strsql = "Select top 1 1 from tbl_vouchers where vch_month='" & cbMonth.Text.Trim & "' and Vch_year='" & cbYear.Text.Trim & "' and vch_paid='Y' and vch_stdid=" & cbStudent.SelectedValue
                cmsql = New SqlCommand(strsql, cnsql)

                If Not cmsql.ExecuteScalar Is Nothing Then
                    MessageBox.Show("The --" & cbMonth.Text.Trim & "-- of the --" & cbYear.Text.Trim & "-- Is Alraedy Paid By Student", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbMonth.Focus() : Exit Try
                End If

                strsql = "select top 1 1 from tbl_vouchers where vch_month='" & cbMonth.Text.Trim & "' and Vch_year='" & cbYear.Text.Trim & "' and vch_paid='N'  and vch_stdid=" & cbStudent.SelectedValue
                cmsql.CommandText = strsql

                If cmsql.ExecuteScalar Is Nothing Then
                    MessageBox.Show("Nothing to paid in this month", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbMonth.Focus() : Exit Try
                End If

                

                strsql = "Update tbl_vouchers set vch_paid='Y'  "
                strsql &= "where vch_month='" & cbMonth.Text.Trim & "' and Vch_year='" & cbYear.Text.Trim & "' and vch_stdid=" & cbStudent.SelectedValue

                cmsql.CommandText = strsql
                cmsql.ExecuteNonQuery()

                MessageBox.Show("Saved successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnModify_Click(btnModify, New System.EventArgs)
                cbMonth.Text = "" : TxtTot.Text = "" : cbYear.Text = "" : cbMonth.SelectedIndex = -1 : cbYear.SelectedIndex = -1
                Pnlhide.Visible = True : Pnlhide.BringToFront()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub cbMonth_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMonth.SelectedIndexChanged
        Try
            Select Case cbMonth.Text
                Case "January" : TxtTot.Text = TxtJan.Text.Trim
                Case "February" : TxtTot.Text = TxtFeb.Text.Trim
                Case "March" : TxtTot.Text = TxtMar.Text.Trim
                Case "April" : TxtTot.Text = TxtApr.Text.Trim
                Case "May" : TxtTot.Text = TxtMay.Text.Trim
                Case "June" : TxtTot.Text = TxtJune.Text.Trim
                Case "July" : TxtTot.Text = TxtJul.Text.Trim
                Case "August" : TxtTot.Text = TxtAug.Text.Trim
                Case "September" : TxtTot.Text = TxtSep.Text.Trim
                Case "October" : TxtTot.Text = TxtOct.Text.Trim
                Case "November" : TxtTot.Text = TxtNov.Text.Trim
                Case "December" : TxtTot.Text = TxtDec.Text.Trim
            End Select
           
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
   
End Class