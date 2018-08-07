Imports System.Data.SqlClient

Public Class frmInfo
    Private SessionId, ProfId As Integer
    Private NewNode, Addstud As Boolean
    Private data As String

    Private Sub btnCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLOSE.Click
        Me.Close()
    End Sub
    Public Overloads Function ShowDialog(ByVal _SessNode As Integer, ByVal _ProfId As Integer, _
                                                ByVal _NewNode As Boolean, Optional ByVal _Data As String = "", Optional ByVal _Addstud As Boolean = False) As DialogResult

        Try
            SessionId = _SessNode
            ProfId = _ProfId
            NewNode = _NewNode
            data = _Data
            Addstud = _Addstud
            Me.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub frmInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader
        Dim strsql As String

        Try
            If NewNode = False Then

                strsql = "select Ses_StartTime,Ses_EndTime,std_name+ ' ' + std_Lname as [name] , Crs_Desc, Rom_Name "
                strsql &= "from tbl_sessions "
                strsql &= "left join tbl_courses on Ses_CrsCode=Crs_Code "
                strsql &= "left join tbl_Students on Ses_StdId=std_id "
                strsql &= "left join tbl_Classes on Cls_Prof=Ses_ProfId and Cls_Session=Ses_Counter "
                strsql &= "Left join tbl_Room on Rom_code=Cls_Room "
                strsql &= " Where Ses_ProfId=" & ProfId & " And Ses_Counter=" & SessionId

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                cmsql = New SqlCommand(strsql, cnsql)
                drsql = cmsql.ExecuteReader

                drsql.Read()
                LblStartTime.Text = CDate(data.ToString.Split("|"c)(0)).ToString("hh:mm tt")
                LblEndTime.Text = CDate(data.ToString.Split("|"c)(1)).ToString("hh:mm tt")

                If Addstud = False Then
                    LblStudent.Text = IIf(drsql.Item("name") Is DBNull.Value, "", drsql.Item("name"))
                Else
                    LblStudent.Text = data.ToString.Split("|"c)(2)
                End If

                LblCourse.Text = IIf(drsql.Item("Crs_Desc") Is DBNull.Value, "", drsql.Item("Crs_Desc"))
                LblRoom.Text = IIf(drsql.Item("Rom_Name") Is DBNull.Value, "", drsql.Item("Rom_Name"))
                drsql.Close()
            Else

                LblStartTime.Text = CDate(data.ToString.Split("|"c)(0)).ToString("hh:mm tt")
                LblEndTime.Text = CDate(data.ToString.Split("|"c)(1)).ToString("hh:mm tt")

                cnsql = New SqlConnection(constr)
                cnsql.Open()

                strsql = "select Crs_Desc from tbl_courses where Crs_Code='" & data.ToString.Split("|"c)(2) & "'"
                cmsql = New SqlCommand(strsql, cnsql)
                LblCourse.Text = cmsql.ExecuteScalar.ToString



                strsql = "select Rom_Name from tbl_Room where Rom_code='" & data.ToString.Split("|"c)(3) & "'"
                cmsql.CommandText = strsql
                LblRoom.Text = cmsql.ExecuteScalar.ToString


            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : drsql = Nothing
        End Try
    End Sub
End Class