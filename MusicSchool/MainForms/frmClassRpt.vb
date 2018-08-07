Imports System.Data.SqlClient

Public Class frmClassRpt
    Dim lctitle As String = "Courses Report"
    Dim lcStep, lcmode As String
    Dim lcView, Lclocked As Boolean
    Dim RptTmp As String
    Dim dtProf, dtCour As DataTable
    Public Overloads Sub show(ByVal _Steps As String)
        Try
            lcStep = _Steps
            Me.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillTdbCrs()
        Dim cnsql As SqlConnection
        Dim Dasql As SqlDataAdapter
        Dim strsql As String
        Dim i As Integer

        Try


            strsql = "select 'True' as [Chk] , Crs_Code as [Code] , Crs_Desc as [Desc] from tbl_courses where Crs_Actice='A' order by Crs_Code "

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            Dasql = New SqlDataAdapter(strsql, cnsql)

            dtCour = New DataTable

            Dasql.Fill(dtCour)

            TdbCourse.DataSource = dtCour.DefaultView


            TdbCourse.CaptionStyle.BackColor = Color.Wheat
            TdbCourse.CaptionStyle.ForeColor = Color.Maroon
            TdbCourse.CaptionStyle.Font = New Font("calibri", 12, FontStyle.Bold)

            With TdbCourse.Splits(0)
                .ColumnCaptionHeight = 25
                '.CaptionStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                '.CaptionStyle.ForeColor = Color.Maroon


                .DisplayColumns("Chk").DataColumn.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                .DisplayColumns("Chk").DataColumn.Caption = ""
                .DisplayColumns("Chk").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Chk").Width = 20
                .DisplayColumns("Chk").AllowSizing = False
                .DisplayColumns("Chk").Locked = False


                .DisplayColumns("Code").DataColumn.Caption = "Code"
                .DisplayColumns("Code").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                .DisplayColumns("Code").Width = 60
                .DisplayColumns("Code").AllowSizing = False
                .DisplayColumns("Code").Locked = True


                .DisplayColumns("Desc").DataColumn.Caption = "Description"
                .DisplayColumns("Desc").Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
                .DisplayColumns("Desc").Width = 180
                .DisplayColumns("Desc").AllowSizing = False
                .DisplayColumns("Desc").Locked = True


            End With


            For Each column In TdbCourse.Splits(0).DisplayColumns
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.Font = New Font("calibri", 12, FontStyle.Bold)
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.BackColor = Color.FromArgb(255, 255, 192)
                TdbCourse.Splits(0).DisplayColumns(i).HeadingStyle.ForeColor = Color.Maroon
                i = i + 1
            Next




        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            Dasql = Nothing
        End Try
    End Sub
End Class