<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsrPriv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsrPriv))
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.CbUser = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblUsrName = New System.Windows.Forms.Label()
        Me.tdbPriv = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.tdbPriv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(50, 302)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(94, 55)
        Me.btnModify.TabIndex = 19
        Me.btnModify.Tag = "button"
        Me.btnModify.Text = "    Modify   - F4"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.MusicSchool.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(368, 302)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 55)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Tag = "button"
        Me.btnSave.Text = "       Save        -F10"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightGray
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Global.MusicSchool.My.Resources.Resources.Log_Out_icon
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(527, 302)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 55)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Tag = "button"
        Me.btnClose.Text = "  Close   -F12"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightGray
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.MusicSchool.My.Resources.Resources.Sign_Stop
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(209, 302)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'CbUser
        '
        Me.CbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbUser.ForeColor = System.Drawing.Color.Maroon
        Me.CbUser.FormattingEnabled = True
        Me.CbUser.Location = New System.Drawing.Point(23, 42)
        Me.CbUser.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.CbUser.Name = "CbUser"
        Me.CbUser.Size = New System.Drawing.Size(205, 24)
        Me.CbUser.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Wheat
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(24, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 31)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "User"
        '
        'LblUsrName
        '
        Me.LblUsrName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblUsrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUsrName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblUsrName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsrName.ForeColor = System.Drawing.Color.Firebrick
        Me.LblUsrName.Location = New System.Drawing.Point(244, 42)
        Me.LblUsrName.Name = "LblUsrName"
        Me.LblUsrName.Size = New System.Drawing.Size(409, 24)
        Me.LblUsrName.TabIndex = 23
        '
        'tdbPriv
        '
        Me.tdbPriv.AllowColMove = False
        Me.tdbPriv.CaptionHeight = 17
        Me.tdbPriv.FetchRowStyles = True
        Me.tdbPriv.FilterBar = True
        Me.tdbPriv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbPriv.Images.Add(CType(resources.GetObject("tdbPriv.Images"), System.Drawing.Image))
        Me.tdbPriv.Location = New System.Drawing.Point(24, 83)
        Me.tdbPriv.Name = "tdbPriv"
        Me.tdbPriv.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbPriv.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbPriv.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbPriv.PrintInfo.PageSettings = CType(resources.GetObject("tdbPriv.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbPriv.RowHeight = 17
        Me.tdbPriv.Size = New System.Drawing.Size(629, 203)
        Me.tdbPriv.TabIndex = 24
        Me.tdbPriv.Text = "fff"
        Me.tdbPriv.PropBag = resources.GetString("tdbPriv.PropBag")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-114, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(909, 4)
        Me.Label3.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(-98, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(882, 72)
        Me.Label5.TabIndex = 59
        '
        'frmUsrPriv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 365)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tdbPriv)
        Me.Controls.Add(Me.LblUsrName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbUser)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsrPriv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUsrPriv"
        CType(Me.tdbPriv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents CbUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblUsrName As System.Windows.Forms.Label
    Friend WithEvents tdbPriv As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
