<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassRpt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassRpt))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TdbCourse = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.TdbCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(-241, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(909, 4)
        Me.Label8.TabIndex = 62
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.LightGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(72, 223)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(110, 55)
        Me.btnShow.TabIndex = 60
        Me.btnShow.Tag = "button"
        Me.btnShow.Text = "       Show       -F10"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightGray
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.MusicSchool.My.Resources.Resources.Log_Out_icon
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(254, 223)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 55)
        Me.btnClose.TabIndex = 61
        Me.btnClose.Tag = "button"
        Me.btnClose.Text = "  Close   -F12"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Location = New System.Drawing.Point(0, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(435, 72)
        Me.Label9.TabIndex = 63
        '
        'TdbCourse
        '
        Me.TdbCourse.AllowColMove = False
        Me.TdbCourse.AllowColSelect = False
        Me.TdbCourse.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.TdbCourse.Caption = " Courses"
        Me.TdbCourse.CaptionHeight = 25
        Me.TdbCourse.FetchRowStyles = True
        Me.TdbCourse.FilterBar = True
        Me.TdbCourse.Images.Add(CType(resources.GetObject("TdbCourse.Images"), System.Drawing.Image))
        Me.TdbCourse.Location = New System.Drawing.Point(333, 178)
        Me.TdbCourse.Name = "TdbCourse"
        Me.TdbCourse.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TdbCourse.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TdbCourse.PreviewInfo.ZoomFactor = 75.0R
        Me.TdbCourse.PrintInfo.PageSettings = CType(resources.GetObject("TdbCourse.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TdbCourse.PropBag = resources.GetString("TdbCourse.PropBag")
        Me.TdbCourse.RowHeight = 18
        Me.TdbCourse.Size = New System.Drawing.Size(264, 178)
        Me.TdbCourse.TabIndex = 69
        '
        'frmClassRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 281)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClassRpt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Courses Report"
        CType(Me.TdbCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents TdbCourse As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
