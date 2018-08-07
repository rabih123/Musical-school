<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alerts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alerts))
        Me.LblText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblColr = New System.Windows.Forms.Label()
        Me.LblPhoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LblPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblText
        '
        Me.LblText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblText.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblText.ForeColor = System.Drawing.Color.White
        Me.LblText.Location = New System.Drawing.Point(79, 33)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(206, 54)
        Me.LblText.TabIndex = 1
        Me.LblText.Text = "Show  Pending Students Payments"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LblColr
        '
        Me.LblColr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblColr.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblColr.Location = New System.Drawing.Point(0, 0)
        Me.LblColr.Name = "LblColr"
        Me.LblColr.Size = New System.Drawing.Size(287, 14)
        Me.LblColr.TabIndex = 2
        '
        'LblPhoto
        '
        Me.LblPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblPhoto.Image = CType(resources.GetObject("LblPhoto.Image"), System.Drawing.Image)
        Me.LblPhoto.Location = New System.Drawing.Point(3, 17)
        Me.LblPhoto.Name = "LblPhoto"
        Me.LblPhoto.Size = New System.Drawing.Size(70, 50)
        Me.LblPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LblPhoto.TabIndex = 3
        Me.LblPhoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(241, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 36)
        Me.Label1.TabIndex = 4
        '
        'Alerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(287, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblPhoto)
        Me.Controls.Add(Me.LblColr)
        Me.Controls.Add(Me.LblText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Alerts"
        CType(Me.LblPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblText As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblColr As System.Windows.Forms.Label
    Friend WithEvents LblPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
