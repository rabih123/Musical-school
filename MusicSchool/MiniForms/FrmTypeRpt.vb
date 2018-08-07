Public Class FrmTypeRpt
    Private lcStep As String
    Public Overloads Function ShowDialog(ByVal _Steps As String) As DialogResult
        Try
            lcStep = _Steps
            Me.ShowDialog()
            ' Me.DialogResult = Me.ShowDialog()
            Return Me.DialogResult

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub FrmTypeRpt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rbDay.Focus()
    End Sub
End Class