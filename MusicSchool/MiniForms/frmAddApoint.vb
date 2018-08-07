Imports System.Data.SqlClient

Public Class frmAddApoint

    Private StartTime, EndTime As Date
    Private ProfId As String
    Private AppData(,) As String

    Public Overloads Function ShowDialog(ByVal _StrTime As Date, ByVal _EndTime As Date, _
                                           ByVal _ProfId As String, ByRef _Data(,) As String) As DialogResult

        Try
            StartTime = _StrTime
            EndTime = _EndTime
            ProfId = _ProfId
            AppData = _Data
            Me.ShowDialog()
            If Me.DialogResult = Windows.Forms.DialogResult.OK Then
                _Data = AppData
            End If
            Return Me.DialogResult
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub txtMond1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtstartTime.KeyDown
        Dim val As String

        Try
            val = CType(sender, MaskedTextBox).Text.Replace(":", "")

            If e.KeyData.ToString.Substring(0, 1) = "D" Then
                If val.Trim.Length = 0 Then
                    If e.KeyData <> Keys.D1 AndAlso e.KeyData <> Keys.D0 Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 1 AndAlso val.Substring(0, 1) = 1 Then
                    If e.KeyData <> Keys.D1 AndAlso e.KeyData <> Keys.D2 AndAlso e.KeyData <> Keys.D0 Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 2 Then
                    If (e.KeyValue > 53 OrElse e.KeyValue < 48) Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 4 Then
                    If e.KeyValue <> Keys.A AndAlso e.KeyValue <> Keys.P Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 6 Then
                    If e.KeyValue <> Keys.M Then
                        e.SuppressKeyPress = True
                    End If
                End If
            Else
                If val.Trim.Length = 0 Then
                    If (e.KeyData <> Keys.NumPad1 AndAlso e.KeyData <> Keys.NumPad0) Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 1 AndAlso val.Substring(0, 1) = 1 Then
                    If e.KeyData <> Keys.NumPad1 AndAlso e.KeyData <> Keys.NumPad2 AndAlso e.KeyData <> Keys.NumPad0 Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 2 Then
                    If e.KeyValue > 102 OrElse e.KeyValue < 96 Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 4 Then
                    If e.KeyValue <> Keys.A AndAlso e.KeyValue <> Keys.P Then
                        e.SuppressKeyPress = True
                    End If
                ElseIf val.Trim.Length = 6 Then
                    If e.KeyValue <> Keys.M Then
                        e.SuppressKeyPress = True
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.No

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourse.Click
        Dim strsql1 As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim width() As Integer
        width = {70, 300, 300, 150, 50}
        Try

            If txtstartTime.Text.Trim.Length <> 8 Then MessageBox.Show("Please insert Start Time First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try
            If txtstartTime.Text.Trim.Length <> 8 Then MessageBox.Show("Please insert End Time First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try

            Dim frm As search
            Dim strsql As String
            Dim val As String


            strsql = "select Crs_Code as [Code],Crs_Desc as [Description] ,cast(Crs_Price as numeric(18,0)) as [Price/$] ,Crs_Notes as [Notes], "
            strsql &= "case when Crs_type='I' then 'Individual' else 'Group' End as [Type] "
            strsql &= "from  dbo.tbl_courses "
            strsql &= "Inner join tbl_ProfCourse on Crs_Code=PrfCrs_Crs "
            strsql &= "where Crs_Actice='A' And PrfCrs_Prof=" & ProfId

            frm = New search
            frm.ShowDialog(strsql, val, False, width)

            If val <> "" Then
                LblCourse.Tag = val
                strsql1 = "Select Crs_Desc from tbl_courses where Crs_Code='" & val & "'"

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql1, cnsql)
                LblCourse.Text = cmsql.ExecuteScalar().ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub btnRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoom.Click
        Dim strsql1 As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim width() As Integer
        width = {70, 300, 300, 150, 50}
        Try

            If txtstartTime.Text.Trim.Length <> 8 Then MessageBox.Show("Please insert Start Time First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try
            If txtstartTime.Text.Trim.Length <> 8 Then MessageBox.Show("Please insert End Time First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try

            Dim frm As search
            Dim strsql As String
            Dim val As String


            strsql = "select Rom_code as [Code] , Rom_Name as [Description]  , Rom_Note as [Notes],Rom_NoStd as [# Of Students],  "
            strsql &= "case when Rom_Type='I' then 'Individual' else 'Group' End as [Type] "
            strsql &= "from  dbo.tbl_Room where Rom_Active='A' "
            'strsql &= "And not exists ( select top 1 1 from tbl_Classes "
            'strsql &= "inner join  tbl_sessions on Cls_Session=Ses_Counter  "
            'strsql &= "where Cls_Room=Rom_code   "
            'strsql &= " and (dateadd(minute,2,'" & (StartTime.ToString("yyyy-MM-dd ") & CDate(txtstartTime.Text.Trim).ToString("HH:mm")) & "') > Ses_StartTime "
            'strsql &= " And dateadd(minute,2,'" & (StartTime.ToString("yyyy-MM-dd ") & CDate(txtstartTime.Text.Trim).ToString("HH:mm")) & "') < Ses_EndTime))"


            frm = New search
            frm.ShowDialog(strsql, val, False, width)

            If val <> "" Then
                lblRoom.Tag = val
                strsql1 = "Select Rom_Name from tbl_Room where Rom_code='" & val & "'"

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql1, cnsql)
                lblRoom.Text = cmsql.ExecuteScalar().ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub frmAddApoint_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtstartTime.Text = StartTime.ToString("hh:mm tt")
            TxtEndTime.Text = EndTime.ToString("hh:mm tt")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtstartTime_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtstartTime.Validating, TxtEndTime.Validating
        Try
            If CType(sender, MaskedTextBox).Text.Trim.Length <> 8 AndAlso Me.ActiveControl.Name <> "btnCLOSE" Then
                MessageBox.Show("Invalid Time Format", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True : Exit Try
            End If

            If CType(sender, MaskedTextBox) Is txtstartTime Then
                If CDate(CDate(txtstartTime.Text.Trim).ToString("hh:mm tt")).TimeOfDay.TotalMinutes < CDate("08:00 AM").TimeOfDay.TotalMinutes Then
                    MessageBox.Show("Start time Must Be Greater than --  08:00 AM  --", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If

            If CType(sender, MaskedTextBox) Is TxtEndTime Then
                If CDate(CDate(TxtEndTime.Text.Trim).ToString("hh:mm tt")).TimeOfDay.TotalMinutes > CDate("09:00 PM").TimeOfDay.TotalMinutes Then
                    MessageBox.Show("Start time Must Be Less than --  09:00 PM  --", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If

            'If CType(sender, MaskedTextBox) Is TxtEndTime Then
            If CDate(StartTime.ToString("yyyy-MM-dd ") & CDate(txtstartTime.Text.Trim).ToString("hh:mm tt")).TimeOfDay.TotalMinutes >= _
                CDate(EndTime.ToString("yyyy-MM-dd ") & CDate(TxtEndTime.Text.Trim).ToString("hh:mm tt")).TimeOfDay.TotalMinutes Then
                MessageBox.Show("End time Must Be Greater than Start Time", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtboxEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstartTime.Enter, TxtEndTime.Enter
        Try
            If CType(sender, MaskedTextBox).ReadOnly = False Then
                CType(sender, MaskedTextBox).BackColor = Color.Bisque
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtboxLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtstartTime.Leave, TxtEndTime.Leave
        Try
            If CType(sender, MaskedTextBox).ReadOnly = False Then
                CType(sender, MaskedTextBox).BackColor = Color.White
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            If txtstartTime.Text.Trim.Length <> 8 Then MessageBox.Show("Please insert Start Time First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try
            If txtstartTime.Text.Trim.Length <> 8 Then MessageBox.Show("Please insert End Time First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try

            If LblCourse.Text.Trim = "" Then MessageBox.Show("Please Select A Course ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try
            If lblRoom.Text.Trim = "" Then MessageBox.Show("Please Select A Room ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Try

            If AppData Is Nothing Then
                ReDim AppData(4, 0)
            Else
                ReDim Preserve AppData(4, AppData.GetUpperBound(1) + 1)
            End If

            AppData(0, AppData.GetUpperBound(1)) = CDate(StartTime.ToString("yyyy-MM-dd ") & CDate(txtstartTime.Text).ToString("hh:mm tt"))
            AppData(1, AppData.GetUpperBound(1)) = CDate(EndTime.ToString("yyyy-MM-dd ") & CDate(TxtEndTime.Text).ToString("hh:mm tt"))
            AppData(2, AppData.GetUpperBound(1)) = LblCourse.Tag
            AppData(3, AppData.GetUpperBound(1)) = lblRoom.Tag
            AppData(4, AppData.GetUpperBound(1)) = "N"


            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class