<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfStdMnthDisc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfStdMnthDisc))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tdbdet = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.rbProf = New System.Windows.Forms.RadioButton()
        Me.rbStd = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAppply = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdisc = New System.Windows.Forms.TextBox()
        Me.btnUnchk = New System.Windows.Forms.Button()
        Me.btnChk = New System.Windows.Forms.Button()
        CType(Me.tdbdet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-32, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(909, 4)
        Me.Label3.TabIndex = 62
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(111, 413)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(94, 55)
        Me.btnModify.TabIndex = 61
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
        Me.btnSave.Location = New System.Drawing.Point(443, 413)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 55)
        Me.btnSave.TabIndex = 59
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
        Me.btnClose.Location = New System.Drawing.Point(618, 413)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 55)
        Me.btnClose.TabIndex = 60
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
        Me.btnCancel.Location = New System.Drawing.Point(275, 413)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(-16, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(882, 72)
        Me.Label5.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(-8, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 95)
        Me.Label1.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(-37, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(909, 4)
        Me.Label2.TabIndex = 65
        '
        'tdbdet
        '
        Me.tdbdet.AllowColMove = False
        Me.tdbdet.AllowColSelect = False
        Me.tdbdet.AllowDelete = True
        Me.tdbdet.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbdet.AllowSort = False
        Me.tdbdet.Caption = " "
        Me.tdbdet.CaptionHeight = 25
        Me.tdbdet.FetchRowStyles = True
        Me.tdbdet.FilterBar = True
        Me.tdbdet.Images.Add(CType(resources.GetObject("tdbdet.Images"), System.Drawing.Image))
        Me.tdbdet.Location = New System.Drawing.Point(-5, 93)
        Me.tdbdet.Name = "tdbdet"
        Me.tdbdet.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbdet.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbdet.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbdet.PrintInfo.PageSettings = CType(resources.GetObject("tdbdet.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbdet.RowHeight = 18
        Me.tdbdet.Size = New System.Drawing.Size(843, 257)
        Me.tdbdet.TabIndex = 66
        Me.tdbdet.PropBag = resources.GetString("tdbdet.PropBag")
        '
        'cbMonth
        '
        Me.cbMonth.BackColor = System.Drawing.Color.White
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonth.ForeColor = System.Drawing.Color.Black
        Me.cbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonth.Location = New System.Drawing.Point(429, 53)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(159, 24)
        Me.cbMonth.TabIndex = 67
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Wheat
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(429, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 38)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "Month"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Firebrick
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(653, 22)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(129, 41)
        Me.btnShow.TabIndex = 69
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'rbProf
        '
        Me.rbProf.BackColor = System.Drawing.Color.White
        Me.rbProf.Checked = True
        Me.rbProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbProf.ForeColor = System.Drawing.Color.Maroon
        Me.rbProf.Location = New System.Drawing.Point(12, 9)
        Me.rbProf.Name = "rbProf"
        Me.rbProf.Size = New System.Drawing.Size(167, 29)
        Me.rbProf.TabIndex = 70
        Me.rbProf.TabStop = True
        Me.rbProf.Text = "Professors"
        Me.rbProf.UseVisualStyleBackColor = False
        '
        'rbStd
        '
        Me.rbStd.BackColor = System.Drawing.Color.White
        Me.rbStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStd.ForeColor = System.Drawing.Color.Maroon
        Me.rbStd.Location = New System.Drawing.Point(217, 9)
        Me.rbStd.Name = "rbStd"
        Me.rbStd.Size = New System.Drawing.Size(167, 29)
        Me.rbStd.TabIndex = 71
        Me.rbStd.Text = "Students"
        Me.rbStd.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnAppply
        '
        Me.btnAppply.BackColor = System.Drawing.Color.Maroon
        Me.btnAppply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppply.ForeColor = System.Drawing.Color.White
        Me.btnAppply.Location = New System.Drawing.Point(148, 7)
        Me.btnAppply.Name = "btnAppply"
        Me.btnAppply.Size = New System.Drawing.Size(29, 31)
        Me.btnAppply.TabIndex = 77
        Me.btnAppply.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btnAppply, "Apply Amounts On All Checked Records")
        Me.btnAppply.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnAppply)
        Me.Panel1.Controls.Add(Me.txtdisc)
        Me.Panel1.Location = New System.Drawing.Point(637, 354)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 44)
        Me.Panel1.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 28)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Amount"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtdisc
        '
        Me.txtdisc.BackColor = System.Drawing.Color.White
        Me.txtdisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisc.Location = New System.Drawing.Point(77, 8)
        Me.txtdisc.MaxLength = 6
        Me.txtdisc.Multiline = True
        Me.txtdisc.Name = "txtdisc"
        Me.txtdisc.Size = New System.Drawing.Size(71, 28)
        Me.txtdisc.TabIndex = 76
        Me.txtdisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUnchk
        '
        Me.btnUnchk.BackColor = System.Drawing.Color.Wheat
        Me.btnUnchk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnchk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnchk.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnchk.ForeColor = System.Drawing.Color.Maroon
        Me.btnUnchk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnchk.Location = New System.Drawing.Point(112, 350)
        Me.btnUnchk.Name = "btnUnchk"
        Me.btnUnchk.Size = New System.Drawing.Size(115, 32)
        Me.btnUnchk.TabIndex = 77
        Me.btnUnchk.Tag = "button"
        Me.btnUnchk.Text = "UnCheck All"
        Me.btnUnchk.UseVisualStyleBackColor = False
        '
        'btnChk
        '
        Me.btnChk.BackColor = System.Drawing.Color.Wheat
        Me.btnChk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChk.ForeColor = System.Drawing.Color.Maroon
        Me.btnChk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChk.Location = New System.Drawing.Point(-1, 350)
        Me.btnChk.Name = "btnChk"
        Me.btnChk.Size = New System.Drawing.Size(113, 32)
        Me.btnChk.TabIndex = 76
        Me.btnChk.Tag = "button"
        Me.btnChk.Text = "Check All"
        Me.btnChk.UseVisualStyleBackColor = False
        '
        'frmProfStdMnthDisc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 477)
        Me.Controls.Add(Me.btnUnchk)
        Me.Controls.Add(Me.btnChk)
        Me.Controls.Add(Me.rbStd)
        Me.Controls.Add(Me.rbProf)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.cbMonth)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tdbdet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfStdMnthDisc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Professors \ Students Monthly Discounts"
        CType(Me.tdbdet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tdbdet As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents rbProf As System.Windows.Forms.RadioButton
    Friend WithEvents rbStd As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAppply As System.Windows.Forms.Button
    Friend WithEvents txtdisc As System.Windows.Forms.TextBox
    Friend WithEvents btnUnchk As System.Windows.Forms.Button
    Friend WithEvents btnChk As System.Windows.Forms.Button
End Class
