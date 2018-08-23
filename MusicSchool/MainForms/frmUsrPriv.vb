Imports System.Data.SqlClient
Imports C1.Win.C1TrueDBGrid
Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class frmUsrPriv
    Private lcStep, lcmode As String
    Private lctitle As String = "Users Privileges Form"
    Private lcView, lcchanges As Boolean
    Dim dtPriv As DataTable
    Dim daPriv As SqlDataAdapter
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsrPriv_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuPrivUser.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsrPriv_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmUsrPriv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub frmUsrPriv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            EnableDisable(Me, True)
            btnSave.Enabled = True : btnCancel.Enabled = True
            fillComboBox() : tdbPriv.Enabled = True
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
            strsql = "Select 0 as cnt , '' as usr_name ,'Select an User' as usr_code from tbl_users union select 1 as cnt, usr_name,usr_code as usr_code   from tbl_users  where usr_status='A' and usr_code <> 'SU' order by cnt "
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            da = New SqlDataAdapter(strsql, cnsql)
            dt = New DataTable
            da.Fill(dt)

            CbUser.DataSource = dt

            CbUser.ValueMember = "usr_name"
            CbUser.DisplayMember = "usr_code"

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            dtPriv.Clear() : CbUser.SelectedIndex = 0
            btnModify.Enabled = True : btnCancel.Enabled = False : btnSave.Enabled = False
            lcchanges = False : tdbPriv.Enabled = False : CbUser.Enabled = False : LblUsrName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CbUser_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbUser.SelectedIndexChanged
        Dim strsql As String
        Dim cnsql As SqlConnection
        Try
            If CbUser.SelectedIndex > 0 Then
                LblUsrName.Text = CbUser.SelectedValue

                strsql = "Select priv_id,case when priv_view='Y' then 'True' else 'False' end as [chk] ,substring(priv_form,2,len(priv_form)) as [priv_form] from tbl_privileges where priv_usr='" & CbUser.Text & "'"
                cnsql = New SqlConnection(constr)
                cnsql.Open()

                daPriv = New SqlDataAdapter(strsql, cnsql)
                dtPriv = New DataTable

                daPriv.Fill(dtPriv)
                tdbPriv.DataSource = dtPriv.DefaultView

                With tdbPriv.Splits(0)
                    .ColumnCaptionHeight = 25
                    .CaptionStyle.HorizontalAlignment = AlignHorzEnum.Center
                    .CaptionStyle.ForeColor = Color.Maroon

                    .DisplayColumns("priv_id").Visible = False
                    .DisplayColumns("priv_id").AllowSizing = False

                    .DisplayColumns("Chk").DataColumn.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                    .DisplayColumns("Chk").Locked = False
                    .DisplayColumns("Chk").DataColumn.Caption = ""
                    .DisplayColumns("Chk").Style.HorizontalAlignment = AlignHorzEnum.Center
                    .DisplayColumns("Chk").Width = 50
                    .DisplayColumns("Chk").AllowSizing = False


                    .DisplayColumns("priv_form").Locked = True
                    .DisplayColumns("priv_form").DataColumn.Caption = "Step Name"
                    .DisplayColumns("priv_form").Style.HorizontalAlignment = AlignHorzEnum.Near
                    .DisplayColumns("priv_form").Width = 600
                    .DisplayColumns("priv_form").AllowSizing = True
                    .DisplayColumns("priv_form").HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center
                End With

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String
        Dim dr As DataRow
        Try
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            For Each dr In dtPriv.Rows
                If dr.RowState = DataRowState.Modified Then
                    strsql = "Update tbl_privileges set priv_view='" & IIf(dr.Item(1).ToString = "True", "Y", "N") & "' where priv_id=" & dr.Item(0) & " and priv_usr='" & CbUser.Text & "'"
                    cmsql = New SqlCommand(strsql, cnsql)
                    cmsql.ExecuteNonQuery()
                End If
            Next
            dtPriv.AcceptChanges()



            MessageBox.Show("Priviliges Updated successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub tdbPriv_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles tdbPriv.FetchRowStyle
        Try
            If tdbPriv.Splits(0).DisplayColumns(tdbPriv.Col).DataColumn.DataField = "priv_id" Then
                tdbPriv.Col = 1
            End If
            If tdbPriv.Splits(0).DisplayColumns(tdbPriv.Col).DataColumn.DataField = "chk" Then
                If tdbPriv.Splits(0).DisplayColumns(1).DataColumn.CellValue(e.Row) = "True" Then
                    e.CellStyle.BackColor = Color.LightSkyBlue : e.CellStyle.ForeColor = Color.LightYellow
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
End Class