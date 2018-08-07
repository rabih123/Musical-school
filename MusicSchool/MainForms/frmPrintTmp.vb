Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms.CrystalReportViewer
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared


Public Class frmPrintTmp
    Private lctitle As String = "Form Print Preview"
    Private ReportName As String
    Private strsql As String
    Private FoFields(,) As String
    Public Overloads Function ShowDialog(ByVal _rptName As String, ByVal _Query As String, ByVal _Fofields(,) As String) As DialogResult
        Try
            ReportName = _rptName
            strsql = _Query : FoFields = _Fofields
            Me.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub frmPrintTmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CreateRptViewer()
            Label1.BringToFront()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub CreateRptViewer()
        Dim Viewer As New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Dim rpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        Try
#If DEBUG Then
            'rpt.Load(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6) & "\..\..\" & ReportName)
            'With crConnectionInfo
            '    .ServerName = "USER-PC\RABIH"
            '    '.ServerName = "RH-PC\SQLEXPRESS"
            '    .DatabaseName = "MusicSchool"
            '    '.UserID = "YOUR DATABASE USERNAME"
            '    '.Password = "YOUR DATABASE PASSWORD"
            '    .IntegratedSecurity = True
            'End With
            rpt.Load(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6) & "\" & ReportName)
            With crConnectionInfo
                .ServerName = "RMG-PC\SQLEXPRESS"
                .DatabaseName = "MusicSchool"
                .UserID = "SA"
                .Password = "rabih_123123"

            End With
            
#Else
            'MsgBox(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6))
            'rpt.Load(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6) & "\" & ReportName)

            'MessageBox.Show((System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6) & ReportName)
            'MessageBox.Show(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6) & ReportName)

            rpt.Load(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6) & "\" & ReportName)
            
            With crConnectionInfo
                .ServerName = "RMG-PC\SQLEXPRESS"
                .DatabaseName = "MusicSchool"
                .UserID = "SA"
                .Password = "rabih_123123"

            End With
#End If

            CrTables = rpt.Database.Tables

            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next






            crParameterDiscreteValue.Value = strsql
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields()
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("@strsql")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)


            For i As Integer = 0 To FoFields.GetUpperBound(0)
                rpt.DataDefinition.FormulaFields(FoFields(i, 0)).Text = FoFields(i, 1)
            Next


            Me.WindowState = FormWindowState.Maximized
            Viewer.Width = Me.Width - 10
            Viewer.Height = Me.Height - 50

            Viewer.Top = 0
            Viewer.Left = 0


            Viewer.CreateControl()
            Viewer.Parent = Me
            Viewer.BringToFront()
            Viewer.Show()

            Viewer.Visible = True

            Viewer.Enabled = True

            Viewer.ShowPrintButton = True
            Viewer.DisplayGroupTree = False
            Viewer.ShowGroupTreeButton = False
            Viewer.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
            Viewer.ReportSource = rpt
            Viewer.Refresh()
            Viewer.ShowCloseButton = False
            Viewer.ShowRefreshButton = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
