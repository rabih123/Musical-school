<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYearALert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYearALert))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pcb = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PbHelp = New System.Windows.Forms.PictureBox()
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PnlHelp = New System.Windows.Forms.Panel()
        Me.PnlStart = New System.Windows.Forms.Panel()
        Me.LblHelp = New System.Windows.Forms.Label()
        Me.Pg1 = New System.Windows.Forms.ProgressBar()
        Me.lblProgres = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pcb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlHelp.SuspendLayout()
        Me.PnlStart.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(90, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pay Attention Please"
        '
        'lbltext
        '
        Me.lbltext.AccessibleName = "t"
        Me.lbltext.Font = New System.Drawing.Font("High Tower Text", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltext.Location = New System.Drawing.Point(0, 124)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(470, 96)
        Me.lbltext.TabIndex = 1
        Me.lbltext.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(187, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-5, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(478, 3)
        Me.Label2.TabIndex = 3
        '
        'Pcb
        '
        Me.Pcb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pcb.Image = CType(resources.GetObject("Pcb.Image"), System.Drawing.Image)
        Me.Pcb.Location = New System.Drawing.Point(202, 193)
        Me.Pcb.Name = "Pcb"
        Me.Pcb.Size = New System.Drawing.Size(70, 70)
        Me.Pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pcb.TabIndex = 5
        Me.Pcb.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Press Button To Start Year"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(427, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 36)
        Me.Label3.TabIndex = 6
        '
        'PbHelp
        '
        Me.PbHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbHelp.Location = New System.Drawing.Point(5, 67)
        Me.PbHelp.Name = "PbHelp"
        Me.PbHelp.Size = New System.Drawing.Size(47, 46)
        Me.PbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbHelp.TabIndex = 7
        Me.PbHelp.TabStop = False
        Me.PbHelp.Tag = "New"
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "help_and_supportss.gif")
        Me.ImgList.Images.SetKeyName(1, "help_and_support.gif")
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PnlHelp
        '
        Me.PnlHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlHelp.Controls.Add(Me.LblHelp)
        Me.PnlHelp.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.PnlHelp.Location = New System.Drawing.Point(2, 117)
        Me.PnlHelp.Name = "PnlHelp"
        Me.PnlHelp.Size = New System.Drawing.Size(468, 120)
        Me.PnlHelp.TabIndex = 8
        Me.PnlHelp.Visible = False
        '
        'PnlStart
        '
        Me.PnlStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlStart.Controls.Add(Me.lblProgres)
        Me.PnlStart.Controls.Add(Me.Pg1)
        Me.PnlStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PnlStart.Location = New System.Drawing.Point(54, 119)
        Me.PnlStart.Name = "PnlStart"
        Me.PnlStart.Size = New System.Drawing.Size(365, 146)
        Me.PnlStart.TabIndex = 9
        Me.PnlStart.Visible = False
        '
        'LblHelp
        '
        Me.LblHelp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp.ForeColor = System.Drawing.Color.Firebrick
        Me.LblHelp.Location = New System.Drawing.Point(0, 0)
        Me.LblHelp.Name = "LblHelp"
        Me.LblHelp.Size = New System.Drawing.Size(468, 120)
        Me.LblHelp.TabIndex = 0
        '
        'Pg1
        '
        Me.Pg1.Location = New System.Drawing.Point(-1, 53)
        Me.Pg1.MarqueeAnimationSpeed = 10000000
        Me.Pg1.Name = "Pg1"
        Me.Pg1.Size = New System.Drawing.Size(365, 34)
        Me.Pg1.Step = 1
        Me.Pg1.TabIndex = 0
        '
        'lblProgres
        '
        Me.lblProgres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblProgres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgres.ForeColor = System.Drawing.Color.Firebrick
        Me.lblProgres.Location = New System.Drawing.Point(41, 16)
        Me.lblProgres.Name = "lblProgres"
        Me.lblProgres.Size = New System.Drawing.Size(278, 23)
        Me.lblProgres.TabIndex = 1
        Me.lblProgres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'frmYearALert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(472, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnlStart)
        Me.Controls.Add(Me.PnlHelp)
        Me.Controls.Add(Me.PbHelp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Pcb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmYearALert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pcb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlHelp.ResumeLayout(False)
        Me.PnlStart.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbltext As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pcb As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PbHelp As System.Windows.Forms.PictureBox
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PnlHelp As System.Windows.Forms.Panel
    Friend WithEvents LblHelp As System.Windows.Forms.Label
    Friend WithEvents PnlStart As System.Windows.Forms.Panel
    Friend WithEvents lblProgres As System.Windows.Forms.Label
    Friend WithEvents Pg1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
