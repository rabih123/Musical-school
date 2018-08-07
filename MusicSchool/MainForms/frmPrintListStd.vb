Imports System.Data.SqlClient
Public Class frmPrintListStd
    Dim lctitle As String = "Form List Of Students."
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked As Boolean
    Dim RptTmp As String
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub frmPrintStd_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmMain.MnuLstAdmStd.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPrintStd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                e.Cancel = True : Exit Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPrintStd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            ' EnableDisable(Me, False)

            'If lcView = False Then
            '    EnableMenuButton(Me, False, {btnClose})
            'End If

            btnShow.Enabled = lcView

            RptTmp = frmMain.MnuLstAdmStd.Text.Replace(" ", "").Substring(3) & "_" & usercode

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            EnableDisable(Me, True)
            btnShow.Enabled = True ': btnCancel.Enabled = True
            '  btnModify.Enabled = False : cbYear.Text = Now.Year
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmProfPay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            Select Case e.KeyCode
                ' Case Keys.F4 : If btnModify.Enabled Then btnModify_Click(btnModify, New System.EventArgs)
                'Case Keys.F8 : If btnCancel.Enabled Then btnCancel_Click(btnCancel, New System.EventArgs)
                Case Keys.F10 : If btnShow.Enabled Then btnShow_Click(btnShow, New System.EventArgs)
                Case Keys.F12 : If btnClose.Enabled Then btnClose_Click(btnClose, New System.EventArgs)
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        RbAll.Checked = True
    '        'cbMonthFrom.Text = "" : CbMonthTo.Text = "" : cbMonthFrom.SelectedIndex = -1 : CbMonthTo.SelectedIndex = -1
    '        'cbYear.SelectedIndex = -1
    '        btnCancel.Enabled = False
    '        btnShow.Enabled = False : btnModify.Enabled = True
    '        ErrorProvider1.SetError(cbMonthFrom, "") : ErrorProvider1.SetError(CbMonthTo, "")
    '        EnableDisable(Me, False)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim strsql As String
        Dim frm As frmPrintTmp
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim Fields(3, 1) As String


        Try


            If CDate(TxtStartdate.Value) > CDate(TxtEnddate.Value) Then
                MessageBox.Show("Start Date Must Be <= To End date", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtStartdate.Focus() : Exit Try
            End If



            strsql = "if exists (select top 1 1 from sys.tables where name='" & RptTmp & "') drop table " & RptTmp

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteNonQuery()



            strsql = "Select * into " & RptTmp & " From( "

            strsql &= "select std_id , std_name+' '+std_Lname as [Name] , std_age as [Age] , Std_Sex [Sex] ,std_phoneno as [Phone] ,"
            strsql &= "std_address as [Address] , std_remarq as [Rmk]   , Crs_Desc as [CrsCode] , prf_name +' '+prf_lname as [Prf_Name] ,"
            strsql &= "Std_Special as [Special] , CONVERT(datetime,CONVERT(varchar(10),std_datestmp,101)) as [AdmDate] "
            strsql &= "from tbl_Students "
            strsql &= "left join tbl_profStdCrs on PrS_Stdid=std_id "
            strsql &= "left join tbl_courses on Crs_Code=Prs_Crs "
            strsql &= "left join tbl_professors on PrS_Prf=prf_id "
            strsql &= "where std_status='A' "

            If chkallStd.Checked = False Then
                strsql &= "And   CONVERT(datetime,CONVERT(varchar(10),std_datestmp,101)) >= '" & CDate(TxtStartdate.Value).ToString("MM/dd/yyyy") & "' And "
                strsql &= "CONVERT(datetime,CONVERT(varchar(10),std_datestmp,101)) <= '" & CDate(TxtEnddate.Value).ToString("MM/dd/yyyy") & "'  "
                'strsql &= "order by std_Id "
            End If
            strsql &= " )tbl "



            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()


            strsql = "select * from " & RptTmp & " order  by std_Id "

            Fields(0, 0) = "foAllStd"
            If chkallStd.Checked = True Then
                Fields(0, 1) = "'Y'"
            Else
                Fields(0, 1) = "'N'"
            End If

            Fields(1, 0) = "foEnddate" : Fields(1, 1) = "'" & CDate(TxtEnddate.Value).ToString("dd/MM/yyyy") & "'"
            Fields(2, 0) = "foStrDate" : Fields(2, 1) = "'" & CDate(TxtStartdate.Value).ToString("dd/MM/yyyy") & "'"


            Fields(3, 0) = "foUsrName" : Fields(3, 1) = "'" & username & "'"
            frm = New frmPrintTmp

            frm.ShowDialog("rptLstStudents.rpt", strsql, Fields)

            strsql = "if exists (select top 1 1 from sys.tables where name='" & RptTmp & "') drop table " & RptTmp
            cmsql.CommandText = strsql
            cmsql.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub cbMont_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            ErrorProvider1.SetError(CType(sender, ComboBox), "")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkallStd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkallStd.CheckedChanged
        Try
            If chkallStd.Checked = True Then
                TxtStartdate.Enabled = False
                TxtEnddate.Enabled = False
            Else
                TxtStartdate.Enabled = True
                TxtEnddate.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class