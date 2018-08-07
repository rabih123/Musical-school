<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmschLoad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmschLoad))
        Me.CbProff = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbProff
        '
        Me.CbProff.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CbProff.DropDownHeight = 120
        Me.CbProff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbProff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProff.ForeColor = System.Drawing.Color.Firebrick
        Me.CbProff.FormattingEnabled = True
        Me.CbProff.IntegralHeight = False
        Me.CbProff.Location = New System.Drawing.Point(109, 80)
        Me.CbProff.Name = "CbProff"
        Me.CbProff.Size = New System.Drawing.Size(313, 24)
        Me.CbProff.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(109, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 68)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Professors"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCnt
        '
        Me.BtnCnt.BackColor = System.Drawing.Color.Lavender
        Me.BtnCnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCnt.ForeColor = System.Drawing.Color.Firebrick
        Me.BtnCnt.Location = New System.Drawing.Point(203, 176)
        Me.BtnCnt.Name = "BtnCnt"
        Me.BtnCnt.Size = New System.Drawing.Size(127, 40)
        Me.BtnCnt.TabIndex = 2
        Me.BtnCnt.Text = "Continue"
        Me.BtnCnt.UseVisualStyleBackColor = False
        '
        'frmschLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 262)
        Me.Controls.Add(Me.BtnCnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbProff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmschLoad"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CbProff As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCnt As System.Windows.Forms.Button
End Class
