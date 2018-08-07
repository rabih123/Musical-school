Imports System.Data.SqlClient
Imports C1.Win.C1TrueDBGrid

Public Class search
    Private returns As String
    Private Locked As Boolean
    Dim dt As DataTable
    Dim da As SqlDataAdapter
    Dim cn As SqlConnection


    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Searching ... 1 \ " & tdbsearch.Splits(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'Dim a, s As Integer
        's = 0
        'For i As Integer = 0 To dgv.ColumnCount
        '    a = dgv.RowHeadersWidth.ToString()
        '    s = s + a
        'Next
        'dgv.Top = 20
        'dgv.Width = (s + s)
        'Me.Width = (s + s + 15)
        'Me.AutoSize = False
    End Sub

    Public Overloads Function ShowDialog(ByVal Strsql As String, ByRef _Returns As String, Optional ByVal _Locked As Boolean = True, Optional ByVal _width As Array = Nothing) As DialogResult
        Dim i As Integer = 0
        Try
            dt = New DataTable
            cn = New SqlConnection(constr)
            cn.Open()

            da = New SqlDataAdapter(Strsql, cn)
            da.Fill(dt)


            tdbsearch.DataSource = dt.DefaultView


            Locked = _Locked

            For Each column In tdbsearch.Splits(0).DisplayColumns
                tdbsearch.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                tdbsearch.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                tdbsearch.Splits(0).DisplayColumns(i).Width = _width(i)

                If dt.Columns(i).DataType.ToString = "System.String" Then
                    tdbsearch.Splits(0).DisplayColumns(i).Style.HorizontalAlignment = AlignHorzEnum.Near
                Else
                    tdbsearch.Splits(0).DisplayColumns(i).Style.HorizontalAlignment = AlignHorzEnum.Center
                End If

                i = i + 1
            Next
            tdbsearch.CaptionHeight = 30
            i = 0
            For Each row In tdbsearch.Splits(0).Rows

            Next
            'For Each column In tdbsearch.Splits(0).DisplayColumns
            '    If tdbsearch.Splits(0).DisplayColumns(i).DataColumn.Value.GetType Is GetType(System.String) Then
            '        tdbsearch.Splits(0).DisplayColumns(i).DataColumn.FilterOperator.Replace("*", "%")
            '    End If
            'Next
            tdbsearch.Splits(0).ColumnCaptionHeight = 22

            Me.ShowDialog()




            _Returns = returns


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Function

    Private Sub tdbsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbsearch.DoubleClick
        Try
            If Locked = False Then
                'If tdbsearch.Splits(0).FilterActive = False Then
                If tdbsearch.SelectedRows.Count = 1 Then
                    returns = tdbsearch.Splits(0).DisplayColumns(0).DataColumn.Text
                    DialogResult = Windows.Forms.DialogResult.OK
                End If
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub tdbsearch_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbsearch.Enter
        Try
            Dim tdb As C1TrueDBGrid
            tdb = New C1TrueDBGrid
            tdb.Style.BackColor = Color.FromArgb(255, 255, 192)
            tdb.Style.ForeColor = Color.Black
            tdbsearch.Splits(0).SelectedStyle.BackColor = Color.FromArgb(255, 255, 192)
            tdbsearch.Splits(0).SelectedStyle.ForeColor = Color.Black
            tdbsearch.Splits(0).AddCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.CurrentCell, tdb.Style)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub tdbsearch_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbsearch.RowColChange
        Try
            Me.Text = "Searching ... " & tdbsearch.Bookmark + 1 & " \ " & tdbsearch.Splits(0).Rows.Count
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
