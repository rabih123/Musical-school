Imports System.Data.SqlClient
Public Class frmschLoad
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

    Private Sub frmschLoad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmload.MnuProfSched.Checked = False
    End Sub


    Private Sub frmschLoad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If usercode <> "SU" Then
                If getPrivliges(usercode, lcStep) = Nothing OrElse getPrivliges(usercode, lcStep) = False Then
                    BtnCnt.Enabled = False
                Else
                    BtnCnt.Enabled = True
                End If
            Else
                BtnCnt.Enabled = True
            End If

            fillComboBox()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillComboBox()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Try
            strsql = "Select -5 as prf_id ,'Select an Professor' as prf_name from tbl_professors union select prf_id,prf_name+ ' '+ prf_lname as prf_name  from tbl_professors  where prf_status='A' "
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            da = New SqlDataAdapter(strsql, cnsql)
            dt = New DataTable
            da.Fill(dt)

            CbProff.DataSource = dt

            CbProff.ValueMember = "prf_id"
            CbProff.DisplayMember = "prf_name"


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            da = Nothing
        End Try
    End Sub

    Private Sub BtnCnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCnt.Click
        Try
            If CbProff.SelectedIndex > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Choose The Professor", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class