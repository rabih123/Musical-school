<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTypeRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTypeRpt))
        Me.rbDay = New System.Windows.Forms.RadioButton()
        Me.rbWeek = New System.Windows.Forms.RadioButton()
        Me.RbScreen = New System.Windows.Forms.RadioButton()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbDay
        '
        Me.rbDay.AutoSize = True
        Me.rbDay.Checked = True
        Me.rbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDay.ForeColor = System.Drawing.Color.Firebrick
        Me.rbDay.Location = New System.Drawing.Point(12, 23)
        Me.rbDay.Name = "rbDay"
        Me.rbDay.Size = New System.Drawing.Size(106, 20)
        Me.rbDay.TabIndex = 0
        Me.rbDay.TabStop = True
        Me.rbDay.Text = "Day Format"
        Me.rbDay.UseVisualStyleBackColor = True
        '
        'rbWeek
        '
        Me.rbWeek.AutoSize = True
        Me.rbWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWeek.ForeColor = System.Drawing.Color.Firebrick
        Me.rbWeek.Location = New System.Drawing.Point(131, 23)
        Me.rbWeek.Name = "rbWeek"
        Me.rbWeek.Size = New System.Drawing.Size(118, 20)
        Me.rbWeek.TabIndex = 1
        Me.rbWeek.Text = "Week Format"
        Me.rbWeek.UseVisualStyleBackColor = True
        '
        'RbScreen
        '
        Me.RbScreen.AutoSize = True
        Me.RbScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbScreen.ForeColor = System.Drawing.Color.Firebrick
        Me.RbScreen.Location = New System.Drawing.Point(266, 23)
        Me.RbScreen.Name = "RbScreen"
        Me.RbScreen.Size = New System.Drawing.Size(127, 20)
        Me.RbScreen.TabIndex = 2
        Me.RbScreen.Text = "Screen Format"
        Me.RbScreen.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderSize = 2
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.Firebrick
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnOk.Location = New System.Drawing.Point(154, 58)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(72, 32)
        Me.BtnOk.TabIndex = 6
        Me.BtnOk.Text = "OK"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'FrmTypeRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(397, 99)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.RbScreen)
        Me.Controls.Add(Me.rbWeek)
        Me.Controls.Add(Me.rbDay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTypeRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbDay As System.Windows.Forms.RadioButton
    Friend WithEvents rbWeek As System.Windows.Forms.RadioButton
    Friend WithEvents RbScreen As System.Windows.Forms.RadioButton
    Friend WithEvents BtnOk As System.Windows.Forms.Button
End Class
