Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Module MainModule

#If DEBUG Then
    Public constr As String = "server=RMG-PC\SQLEXPRESS;User Id=SA ; Password=rabih_123123; database = MusicSchool "
#Else
        Public constr As String = "server=RMG-PC\SQLEXPRESS;User Id=SA ; Password=rabih_123123; database = MusicSchool "
#End If

    'Public constr As String = "server=USER-PC\RABIH;Integrated Security=yes; database = MusicSchool "
    '  Public constr As String = "server=RH-PC\SQLEXPRESS;Integrated Security=yes; database = MusicSchool "
    Public username, usercode As String
    Public dtsession As DataTable
    Private frmload As frmMain

    <DllImport("user32.dll", EntryPoint:="FindWindow", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function FindWindow( _
        ByVal lpclassName As String, ByVal lpWindowname As String) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function PostMessage( _
        ByVal hwnd As IntPtr, ByVal msg As UInteger, ByVal wparam As IntPtr, ByVal Lparam As IntPtr) As IntPtr
    End Function
    Public Wm_close As Integer = &H10

    Public Function getPrivliges(ByVal _user As String, ByVal _steps As String)
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String
        Try
            strsql = "select priv_view from tbl_privileges where priv_usr='" & _user & "' and priv_form='" & _steps & "'"
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            cmsql = New SqlCommand(strsql, cnsql)

            If cmsql.ExecuteScalar Is Nothing Then
                Return Nothing
            Else
                If cmsql.ExecuteScalar.ToString = "N" Then
                    Return False
                Else
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If cnsql.State = ConnectionState.Open Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Function

    Public Sub EnableMenuButton(ByRef _control As Control, ByVal _val As Boolean, Optional ByRef _listcontrol As Array = Nothing)
        Dim ctr As Control
        Try
            For Each ctr In _control.Controls
                If ctr.GetType Is GetType(Button) Then
                    If Not ctr.Tag = Nothing Then
                        If ctr.Tag.ToString = "button" Then
                            ctr.Enabled = _val
                        End If
                    End If
                End If
            Next

            If Not _listcontrol Is Nothing Then
                For i = 0 To _listcontrol.GetUpperBound(0)
                    If _listcontrol(0).GetType Is GetType(Button) Then
                        CType(_listcontrol(i), Button).Enabled = Not _val
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        Finally
            ctr = Nothing : If Not _listcontrol Is Nothing Then _listcontrol = Nothing
        End Try
    End Sub

    Public Sub ClearControls(ByRef _Prt As Control, Optional ByVal exp As String = "", Optional ByVal ep As ErrorProvider = Nothing)
        Dim ctr As Control
        Try
            For Each ctr In _Prt.Controls
                If exp = "" OrElse ctr.Name <> exp Then
                    If ctr.GetType Is GetType(TextBox) Then
                        CType(ctr, TextBox).Text = "" : If Not ep Is Nothing Then ep.SetError(ctr, "")
                    ElseIf ctr.GetType Is GetType(RadioButton) Then
                        CType(ctr, RadioButton).Checked = False
                    ElseIf ctr.GetType Is GetType(MaskedTextBox) Then
                        CType(ctr, MaskedTextBox).Text = ""
                    ElseIf ctr.GetType Is GetType(CheckBox) Then
                        CType(ctr, CheckBox).Checked = False
                    ElseIf ctr.GetType Is GetType(ComboBox) AndAlso ctr.Text <> "" Then
                        CType(ctr, ComboBox).SelectedIndex = -1
                    ElseIf ctr.GetType Is GetType(PictureBox) Then
                        ' CType(ctr, PictureBox).Image = Nothing
                    ElseIf ctr.GetType Is GetType(DateTimePicker) Then
                        CType(ctr, DateTimePicker).Value = Now.ToString("dd/MM/yyyy HH:mm")
                    ElseIf ctr.Controls.Count > 0 Then
                        ClearControls(ctr, exp, ep)
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ctr = Nothing
        End Try
    End Sub
    Public Sub EnableDisable(ByRef _Prt As Control, ByVal _Val As Boolean, Optional ByVal DefaultBckClr As Boolean = True)
        Dim ctr As Control
        Try
            For Each ctr In _Prt.Controls
                If ctr.GetType Is GetType(TextBox) OrElse ctr.GetType Is GetType(PictureBox) OrElse ctr.GetType _
Is GetType(RadioButton) OrElse ctr.GetType Is GetType(CheckBox) OrElse ctr.GetType Is GetType(DateTimePicker) OrElse _
 ctr.GetType Is GetType(ComboBox) OrElse ctr.GetType Is GetType(MaskedTextBox) Then
                    ctr.Enabled = _Val
                    If ctr.GetType Is GetType(CheckBox) OrElse ctr.GetType Is GetType(RadioButton) Then
                        If _Val = False Then
                            ctr.BackColor = SystemColors.Control
                        Else
                            ctr.BackColor = Color.Transparent
                        End If
                    Else
                        If _Val = False Then
                            If DefaultBckClr = True Then
                                ctr.BackColor = SystemColors.Control
                            End If
                        Else
                            If DefaultBckClr = True Then
                                ctr.BackColor = SystemColors.Window
                            End If
                        End If
                    End If

                ElseIf ctr.Controls.Count > 0 Then
                    EnableDisable(ctr, _Val, DefaultBckClr)
                End If
            Next
        Catch ex As Exception
            Throw ex
        Finally
            ctr = Nothing
        End Try
    End Sub

    Public Sub readonlyy(ByRef _Prt As Control, ByVal _Val As Boolean)
        Dim ctr As Control
        Try
            For Each ctr In _Prt.Controls
                If ctr.GetType Is GetType(TextBox) Then
                    CType(ctr, TextBox).ReadOnly = _Val
                    If _Val = True Then
                        ctr.BackColor = SystemColors.Control
                    Else
                        ctr.BackColor = SystemColors.Window
                    End If
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

    Public Sub uncheckStripMneu(ByRef _menu As Form, ByVal _name As String)
        Dim menuItem, menuItem2 As ToolStripMenuItem
        Dim ctr As Control

        Try
            For Each ctr In _menu.Controls
                If ctr.GetType Is GetType(ToolStripMenuItem) Then
                    For Each menuItem In _menu.MainMenuStrip.Items
                        If menuItem.Tag = Nothing Then
                            For Each menuItem2 In menuItem.DropDownItems
                                If menuItem2.Tag.ToString = "Menu" Then
                                    If menuItem2.Name = _name Then
                                        menuItem2.Checked = False
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Function check(ByRef _Prt As Control, ByRef ep As ErrorProvider)
        Dim ctr As Control
        Dim x As Integer
        Try
            For Each ctr In _Prt.Controls
                If ctr.GetType Is GetType(TextBox) Then
                    If CType(ctr, TextBox).Enabled = True AndAlso CType(ctr, TextBox).Text.Trim = "" Then
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

    Public Function keyPressValid(ByVal _char As Char, ByVal _type As String) As Boolean
        Try
            If _type = "Integer" Then
                If Not Char.IsNumber(_char) Then
                    Return True
                End If
            ElseIf _type = "Decimal" Then
                If Not Char.IsNumber(_char) AndAlso (Not Char.IsNumber(_char) AndAlso _char <> ".") Then
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getstudentid() As Integer
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String
        Try
            strsql = "select max(std_id) from tbl_students where SUBSTRING(cast(std_id as varchar(10)),1,4)=" & Now.Year
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            cmsql = New SqlCommand(strsql, cnsql)
            If cmsql.ExecuteScalar Is Nothing Or cmsql.ExecuteScalar Is DBNull.Value Then
                Return CInt(Now.Year & "0001")
            Else
                Return CInt(cmsql.ExecuteScalar.ToString) + 1
            End If

        Catch ex As Exception
            Throw ex
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Function

    Public Function getProfId() As Integer
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String
        Try
            strsql = "select Isnull(Max(prf_id),0) from tbl_professors "
            cnsql = New SqlConnection(constr)
            cnsql.Open()
            cmsql = New SqlCommand(strsql, cnsql)

            Return CInt(cmsql.ExecuteScalar.ToString) + 1

        Catch ex As Exception
            Throw ex
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing
        End Try
    End Function

    Public Function getmenuname()
        Dim mnu, mnu2 As ToolStripMenuItem
        Dim frm As frmMain
        Dim tbl() As String
        Dim i As Integer
        Try
            frm = New frmMain
            For Each mnu In frmMain.MenuStrip1.Items
                For Each mnu2 In mnu.DropDownItems
                    If mnu2.DropDownItems.Count = 0 Then
                        If tbl Is Nothing Then ReDim tbl(0)
                        ReDim Preserve tbl(tbl.GetUpperBound(0) + 1)
                        tbl(tbl.GetUpperBound(0)) = mnu2.Text
                    End If
                Next
            Next

            Return tbl
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub main()
        Try
            frmload = New frmMain
            frmload.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Module
