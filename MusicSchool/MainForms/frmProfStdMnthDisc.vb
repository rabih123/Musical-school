Imports System.Data.SqlClient

Public Class frmProfStdMnthDisc
    Dim lctitle As String = "Professors \ Students Monthly Discounts"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked, lcCancelvalidation, lcchanges As Boolean
    Dim dtDet As DataTable

    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProfStdMnthDisc_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuProfStdMnthDisc.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmProfStdMnthDisc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            btnModify.Enabled = False
            btnCancel.Enabled = True
            btnSave.Enabled = True
            btnClose.Enabled = True
            EnableDisable(Me, True)

            btnChk.Enabled = True
            btnUnchk.Enabled = True
            cbMonth.Enabled = True
            cbMonth.SelectedIndex = Now.Month - 1
            btnShow.Enabled = True
            btnAppply.Enabled = True

            rb_CheckedChanged(rbProf, New System.EventArgs)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            lcchanges = False



            ClearControls(Me, "", Nothing)
            EnableDisable(Me, False)



            btnModify.Enabled = True
            btnCancel.Enabled = False
            btnSave.Enabled = False
            btnClose.Enabled = True
            btnAppply.Enabled = False
            rbProf.Checked = True

            btnChk.Enabled = False
            btnUnchk.Enabled = False


            cbMonth.Text = ""
            cbMonth.SelectedIndex = -1

            cbMonth.Enabled = False
            btnShow.Enabled = False
            tdbdet.ClearFields()
            dtDet = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmProfStdMnthDisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dr As DataRow
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction

        Try

            If lcchanges = False Then
                MessageBox.Show("No Changes Made To Save.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If


            If MessageBox.Show("Are you sure do you want to save ?", lctitle, _
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cnsql = New SqlConnection(constr)
                cnsql.Open()


                trsql = cnsql.BeginTransaction

                For Each dr In dtDet.Rows
                    If dr.RowState = DataRowState.Modified Then

                        If dr.Item("Oldchk") = "True" AndAlso dr.Item("Chk") = "True" Then

                            strsql = " Update tbl_ProfStdMnthDisc set "
                            strsql &= "Disc_DiscManount=" & IIf(dr.Item("Amnt") Is DBNull.Value, "NULL", dr.Item("Amnt")) & ", "
                            strsql &= "Disc_Notes=" & IIf(dr.Item("Notes") Is DBNull.Value, "NULL", "'" & dr.Item("Notes") & "'")
                            strsql &= " Where Disc_RecId=" & dr.Item("Disc_RecId")

                        ElseIf dr.Item("Oldchk") = "False" AndAlso dr.Item("Chk") = "True" Then

                            strsql = " Insert Into tbl_ProfStdMnthDisc select "
                            strsql &= "'" & IIf(rbProf.Checked = True, "Prof", "Std") & "'," & dr.Item("Id") & ","
                            strsql &= " " & Now.Year & "," & cbMonth.SelectedIndex + 1 & "," & IIf(dr.Item("Amnt") Is DBNull.Value, "NULL", dr.Item("Amnt")) & ","
                            strsql &= " " & IIf(dr.Item("Notes") Is DBNull.Value, "NULL", "'" & dr.Item("Notes") & "'")


                        ElseIf dr.Item("OldChk") = "True" AndAlso dr.Item("Chk") = "False" Then

                            strsql = "delete from tbl_ProfStdMnthDisc "
                            strsql &= " Where Disc_RecId=" & dr.Item("Disc_RecId")


                        End If


                        cmsql = New SqlCommand(strsql, cnsql, trsql)
                        cmsql.ExecuteNonQuery()

                    End If




                Next
                trsql.Commit()


                MessageBox.Show("Modifications Successfully saved ", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCancel_Click(btnCancel, New System.EventArgs)
            End If


        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql.Close() : cnsql = Nothing
            cmsql = Nothing : trsql = Nothing
        End Try
    End Sub

    Private Sub frmProfStdMnthDisc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            btnCancel.Enabled = False
            btnSave.Enabled = False
            btnClose.Enabled = True
            btnChk.Enabled = False
            btnUnchk.Enabled = False
            btnAppply.Enabled = False
            btnShow.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TxtDisc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdisc.Enter
        CType(sender, TextBox).BackColor = Color.Bisque
    End Sub

    Private Sub TxtDisc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdisc.Leave
        CType(sender, TextBox).BackColor = Color.White
    End Sub

    Private Sub btnChk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChk.Click
        Dim dr As DataRow

        Try
            If dtDet Is Nothing Then Exit Try
            If dtDet.Rows.Count <= 0 Then Exit Try

            For Each dr In dtDet.Rows
                dr.Item("Chk") = "True"
            Next

            lcchanges = True
            tdbdet.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUnchk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnchk.Click
        Dim dr As DataRow

        Try

            If dtDet Is Nothing Then Exit Try
            If dtDet.Rows.Count <= 0 Then Exit Try

            For Each dr In dtDet.Rows
                dr.Item("Chk") = "False"
                dr.Item("Amnt") = DBNull.Value
                dr.Item("Notes") = ""
            Next

            lcchanges = True
            tdbdet.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbProf.CheckedChanged, rbStd.CheckedChanged
        Try
            If sender Is rbProf Then
                rbProf.BackColor = Color.Gold
                rbStd.BackColor = Color.White
            Else
                rbStd.BackColor = Color.Gold
                rbProf.BackColor = Color.White
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim dasql As SqlDataAdapter
        Dim i As Integer
        Dim dr As DataRow

        Try
            If cbMonth.SelectedIndex < 0 Then
                MessageBox.Show("Select the Month First.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbMonth.Focus() : cbMonth.DroppedDown = True
                Exit Try
            End If

            If tdbdet.Splits(0).Rows.Count <= 0 OrElse (tdbdet.Splits(0).Rows.Count > 0 AndAlso MessageBox.Show("Do You Want To Discard the selected Data.", lctitle, _
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then



                If rbProf.Checked = True Then

                    strsql = "select "
                    strsql &= "case when Disc_ProfStdId Is null then 'False' Else 'True' End as [OldChk],"
                    strsql &= "case when Disc_ProfStdId Is null then 'False' Else 'True' End as [Chk],Disc_RecId,"
                    strsql &= "prf_id as [Id] ,prf_name+' '+prf_lname as [Name], Disc_DiscManount as [Amnt]  , Disc_Notes as [Notes]  "
                    strsql &= "from tbl_professors  "
                    strsql &= "left join tbl_ProfStdMnthDisc on  Disc_ProfStdId=prf_id and Disc_Type='Prof' and Disc_Month=" & cbMonth.SelectedIndex + 1
                    strsql &= "where prf_status='A' "
                    strsql &= "And Not Exists (select Top 1 1 from Tbl_ProfPayments where Pay_ProfId=prf_id "
                    strsql &= " and Pay_Month=" & cbMonth.SelectedIndex + 1 & " And Pay_year=" & Now.Year & " ) "

                Else

                    strsql = "select "
                    strsql &= "case when Disc_ProfStdId Is null then 'False' Else 'True' End as [OldChk],"
                    strsql &= "case when Disc_ProfStdId Is null then 'False' Else 'True' End as [Chk],Disc_RecId,"
                    strsql &= "std_id as [Id] ,std_name+' '+std_Lname as [Name], Disc_DiscManount as [Amnt]  , Disc_Notes as [Notes]  "
                    strsql &= "from tbl_students  "
                    strsql &= "left join tbl_ProfStdMnthDisc on  Disc_ProfStdId=std_id and Disc_Type='Std' and Disc_Month=" & cbMonth.SelectedIndex + 1
                    strsql &= "where std_status='A' "
                    strsql &= "And  exists (select Top 1 1 from tbl_vouchers where Vch_year=" & Now.Year & " "
                    strsql &= "and Vch_NumMonth=" & cbMonth.SelectedIndex + 1 & " and vch_stdid=std_id and Vch_Paid='N') "

                End If

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                dasql = New SqlDataAdapter(strsql, cnsql)

                dtDet = New DataTable

                dasql.Fill(dtDet)

                tdbdet.DataSource = dtDet.DefaultView


                If rbProf.Checked Then
                    tdbdet.Caption = "Professors"
                Else
                    tdbdet.Caption = "Students"
                End If

                With tdbdet.Splits(0)
                    .ColumnCaptionHeight = 25
                    .CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .CaptionStyle.ForeColor = Color.Maroon

                    

                    .DisplayColumns("OldChk").AllowSizing = False
                    .DisplayColumns("OldChk").Visible = False
                    .DisplayColumns("OldChk").Width = 0

                    .DisplayColumns("Chk").DataColumn.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                    .DisplayColumns("Chk").DataColumn.Caption = ""
                    .DisplayColumns("Chk").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Chk").Width = 20
                    .DisplayColumns("Chk").AllowSizing = False
                    .DisplayColumns("Chk").Locked = False


                    .DisplayColumns("Disc_RecId").AllowSizing = False
                    .DisplayColumns("Disc_RecId").Visible = False
                    .DisplayColumns("Disc_RecId").Width = 0

                    .DisplayColumns("Name").DataColumn.Caption = "Name"
                    .DisplayColumns("Name").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                    .DisplayColumns("Name").Width = 250
                    .DisplayColumns("Name").AllowSizing = False
                    .DisplayColumns("Name").Locked = True


                    .DisplayColumns("Id").DataColumn.Caption = "Id #"
                    .DisplayColumns("Id").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Id").Width = 80
                    .DisplayColumns("Id").AllowSizing = False
                    .DisplayColumns("Id").Locked = True


                    .DisplayColumns("Amnt").DataColumn.Caption = "Discount $"
                    .DisplayColumns("Amnt").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    .DisplayColumns("Amnt").Width = 100
                    .DisplayColumns("Amnt").AllowSizing = False
                    .DisplayColumns("Amnt").Locked = False
                    .DisplayColumns("Amnt").Style.BackColor = Color.LightBlue
                    .DisplayColumns("Amnt").DataColumn.DataWidth = 6


                    .DisplayColumns("Notes").DataColumn.Caption = "Remarks"
                    .DisplayColumns("Notes").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                    .DisplayColumns("Notes").Width = 400
                    .DisplayColumns("Notes").AllowSizing = False
                    .DisplayColumns("Notes").Locked = False
                    .DisplayColumns("Notes").Style.BackColor = Color.LightBlue
                    .DisplayColumns("Notes").DataColumn.DataWidth = 100







                End With


                For Each column In tdbdet.Splits(0).DisplayColumns
                    tdbdet.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                    tdbdet.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                    tdbdet.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                    i = i + 1
                Next

            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbdet_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbdet.AfterColUpdate
        Try
            If e.Column.DataColumn.DataField = "Chk" Then
                If e.Column.DataColumn.Text = "False" Then
                    tdbdet.Splits(0).DisplayColumns("Amnt").DataColumn.Text = ""
                    tdbdet.Splits(0).DisplayColumns("Notes").DataColumn.Text = ""
                End If
            End If

            lcchanges = True
            tdbdet.UpdateData()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbdet_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbdet.AfterUpdate

    End Sub

    Private Sub tdbdet_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles tdbdet.FetchRowStyle
        Try
            If tdbdet.Splits(0).DisplayColumns("chk").DataColumn.CellText(e.Row) = "True" Then
                e.CellStyle.BackColor = Color.LightSalmon
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbdet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbdet.KeyPress
        Try
            If tdbdet.FilterActive = False Then
                If tdbdet.Splits(0).DisplayColumns(tdbdet.Col).DataColumn.DataField = "Amnt" Then

                    If Asc(e.KeyChar) <> 43 AndAlso Asc(e.KeyChar) <> 45 AndAlso _
                        Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 Then
                        If Not IsNumeric(e.KeyChar) Then
                            e.Handled = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tdbdet_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbdet.RowColChange
        Try
            If tdbdet.Splits(0).DisplayColumns("chk").DataColumn.Text = "False" Then
                tdbdet.Splits(0).DisplayColumns("Amnt").Locked = True
                tdbdet.Splits(0).DisplayColumns("Notes").Locked = True
            Else
                tdbdet.Splits(0).DisplayColumns("Amnt").Locked = False
                tdbdet.Splits(0).DisplayColumns("Notes").Locked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAppply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppply.Click
        Dim dr As DataRow

        Try
            If txtdisc.Text.Trim = "" Then Exit Try

            For Each dr In dtDet.Select("Chk='True'" & IIf(dtDet.DefaultView.RowFilter = "", "", " And " & dtDet.DefaultView.RowFilter))
                dr.Item("Amnt") = txtdisc.Text.Trim
            Next

            tdbdet.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class