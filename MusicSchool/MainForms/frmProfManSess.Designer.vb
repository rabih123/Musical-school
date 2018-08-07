<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfManSess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfManSess))
        Me.cbProff = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Mnthdate = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tdbSess = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnChk = New System.Windows.Forms.Button()
        Me.btnUnchk = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtReason = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.BtnPrvs = New System.Windows.Forms.Button()
        CType(Me.tdbSess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProff
        '
        Me.cbProff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbProff.FormattingEnabled = True
        Me.cbProff.Location = New System.Drawing.Point(22, 48)
        Me.cbProff.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.cbProff.Name = "cbProff"
        Me.cbProff.Size = New System.Drawing.Size(342, 28)
        Me.cbProff.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(22, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 38)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Professor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(-7, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(909, 4)
        Me.Label4.TabIndex = 34
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(126, 505)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(94, 55)
        Me.btnModify.TabIndex = 38
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
        Me.btnSave.Location = New System.Drawing.Point(458, 505)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 55)
        Me.btnSave.TabIndex = 36
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
        Me.btnClose.Location = New System.Drawing.Point(633, 505)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 55)
        Me.btnClose.TabIndex = 37
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
        Me.btnCancel.Location = New System.Drawing.Point(290, 505)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cbMonth
        '
        Me.cbMonth.BackColor = System.Drawing.Color.White
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonth.ForeColor = System.Drawing.Color.Black
        Me.cbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonth.Location = New System.Drawing.Point(22, 141)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(159, 24)
        Me.cbMonth.TabIndex = 51
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Wheat
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(22, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 38)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "Month"
        '
        'Mnthdate
        '
        Me.Mnthdate.BackColor = System.Drawing.Color.Red
        Me.Mnthdate.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.Mnthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mnthdate.Location = New System.Drawing.Point(499, 7)
        Me.Mnthdate.MaxSelectionCount = 6
        Me.Mnthdate.Name = "Mnthdate"
        Me.Mnthdate.ShowToday = False
        Me.Mnthdate.ShowTodayCircle = False
        Me.Mnthdate.TabIndex = 53
        Me.Mnthdate.TitleBackColor = System.Drawing.Color.Maroon
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(-4, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(885, 178)
        Me.Label1.TabIndex = 54
        '
        'tdbSess
        '
        Me.tdbSess.AllowColMove = False
        Me.tdbSess.AllowColSelect = False
        Me.tdbSess.AllowDelete = True
        Me.tdbSess.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbSess.AllowSort = False
        Me.tdbSess.Caption = " "
        Me.tdbSess.CaptionHeight = 25
        Me.tdbSess.FetchRowStyles = True
        Me.tdbSess.FilterBar = True
        Me.tdbSess.Images.Add(CType(resources.GetObject("tdbSess.Images"), System.Drawing.Image))
        Me.tdbSess.Location = New System.Drawing.Point(-1, 178)
        Me.tdbSess.Name = "tdbSess"
        Me.tdbSess.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbSess.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbSess.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbSess.PrintInfo.PageSettings = CType(resources.GetObject("tdbSess.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbSess.PropBag = resources.GetString("tdbSess.PropBag")
        Me.tdbSess.Size = New System.Drawing.Size(882, 250)
        Me.tdbSess.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-17, 495)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(909, 4)
        Me.Label3.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(-1, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(882, 72)
        Me.Label5.TabIndex = 57
        '
        'btnChk
        '
        Me.btnChk.BackColor = System.Drawing.Color.Wheat
        Me.btnChk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChk.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChk.ForeColor = System.Drawing.Color.Maroon
        Me.btnChk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChk.Location = New System.Drawing.Point(-1, 428)
        Me.btnChk.Name = "btnChk"
        Me.btnChk.Size = New System.Drawing.Size(113, 32)
        Me.btnChk.TabIndex = 58
        Me.btnChk.Tag = "button"
        Me.btnChk.Text = "Check All"
        Me.btnChk.UseVisualStyleBackColor = False
        '
        'btnUnchk
        '
        Me.btnUnchk.BackColor = System.Drawing.Color.Wheat
        Me.btnUnchk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnchk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnchk.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnchk.ForeColor = System.Drawing.Color.Maroon
        Me.btnUnchk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnchk.Location = New System.Drawing.Point(112, 428)
        Me.btnUnchk.Name = "btnUnchk"
        Me.btnUnchk.Size = New System.Drawing.Size(115, 32)
        Me.btnUnchk.TabIndex = 59
        Me.btnUnchk.Tag = "button"
        Me.btnUnchk.Text = "UnCheck All"
        Me.btnUnchk.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Wheat
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(322, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 38)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Reason"
        '
        'TxtReason
        '
        Me.TxtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReason.Location = New System.Drawing.Point(435, 442)
        Me.TxtReason.MaxLength = 100
        Me.TxtReason.Multiline = True
        Me.TxtReason.Name = "TxtReason"
        Me.TxtReason.Size = New System.Drawing.Size(432, 38)
        Me.TxtReason.TabIndex = 61
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Firebrick
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(738, 66)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(129, 41)
        Me.btnShow.TabIndex = 62
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'BtnPrvs
        '
        Me.BtnPrvs.BackColor = System.Drawing.Color.Wheat
        Me.BtnPrvs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrvs.Image = Global.MusicSchool.My.Resources.Resources.Iconshock_Real_Vista_Text_Search_b
        Me.BtnPrvs.Location = New System.Drawing.Point(445, 129)
        Me.BtnPrvs.Name = "BtnPrvs"
        Me.BtnPrvs.Size = New System.Drawing.Size(42, 40)
        Me.BtnPrvs.TabIndex = 63
        Me.BtnPrvs.UseVisualStyleBackColor = False
        '
        'frmProfManSess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(879, 565)
        Me.Controls.Add(Me.BtnPrvs)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.TxtReason)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnUnchk)
        Me.Controls.Add(Me.btnChk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tdbSess)
        Me.Controls.Add(Me.Mnthdate)
        Me.Controls.Add(Me.cbMonth)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbProff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfManSess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Managing Professors Sessions"
        CType(Me.tdbSess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbProff As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Mnthdate As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnChk As System.Windows.Forms.Button
    Friend WithEvents btnUnchk As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtReason As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents BtnPrvs As System.Windows.Forms.Button
    Private WithEvents tdbSess As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
