<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintListStd
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintListStd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkallStd = New System.Windows.Forms.CheckBox()
        Me.TxtStartdate = New System.Windows.Forms.DateTimePicker()
        Me.TxtEnddate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.TxtEnddate)
        Me.GroupBox1.Controls.Add(Me.TxtStartdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(10, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtration"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Wheat
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(291, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 27)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "To Date"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(291, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 30)
        Me.Label5.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(414, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 23)
        Me.Label6.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 27)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "From Date"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 30)
        Me.Label2.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(143, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 56
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.LightGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(137, 163)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(110, 55)
        Me.btnShow.TabIndex = 25
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
        Me.btnClose.Location = New System.Drawing.Point(351, 163)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 55)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Tag = "button"
        Me.btnClose.Text = "  Close   -F12"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(-159, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(909, 4)
        Me.Label8.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-143, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(882, 72)
        Me.Label9.TabIndex = 59
        '
        'chkallStd
        '
        Me.chkallStd.AutoSize = True
        Me.chkallStd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkallStd.Checked = True
        Me.chkallStd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkallStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkallStd.ForeColor = System.Drawing.Color.Maroon
        Me.chkallStd.Location = New System.Drawing.Point(207, 12)
        Me.chkallStd.Name = "chkallStd"
        Me.chkallStd.Size = New System.Drawing.Size(158, 29)
        Me.chkallStd.TabIndex = 60
        Me.chkallStd.Text = "All Students"
        Me.chkallStd.UseVisualStyleBackColor = False
        '
        'TxtStartdate
        '
        Me.TxtStartdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStartdate.CalendarForeColor = System.Drawing.Color.Maroon
        Me.TxtStartdate.CalendarTitleForeColor = System.Drawing.Color.Maroon
        Me.TxtStartdate.CustomFormat = "dd/MM/yyyy"
        Me.TxtStartdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.TxtStartdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtStartdate.Location = New System.Drawing.Point(144, 30)
        Me.TxtStartdate.Name = "TxtStartdate"
        Me.TxtStartdate.Size = New System.Drawing.Size(131, 22)
        Me.TxtStartdate.TabIndex = 61
        Me.TxtStartdate.Value = New Date(2015, 6, 17, 0, 0, 0, 0)
        '
        'TxtEnddate
        '
        Me.TxtEnddate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnddate.CalendarForeColor = System.Drawing.Color.Maroon
        Me.TxtEnddate.CalendarTitleForeColor = System.Drawing.Color.Maroon
        Me.TxtEnddate.CustomFormat = "dd/MM/yyyy"
        Me.TxtEnddate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.TxtEnddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtEnddate.Location = New System.Drawing.Point(415, 30)
        Me.TxtEnddate.Name = "TxtEnddate"
        Me.TxtEnddate.Size = New System.Drawing.Size(131, 22)
        Me.TxtEnddate.TabIndex = 62
        Me.TxtEnddate.Value = New Date(2015, 6, 17, 0, 0, 0, 0)
        '
        'frmPrintListStd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 227)
        Me.Controls.Add(Me.chkallStd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintListStd"
        Me.Text = "List Of Admitting Students"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkallStd As System.Windows.Forms.CheckBox
    Friend WithEvents TxtStartdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtEnddate As System.Windows.Forms.DateTimePicker
End Class
