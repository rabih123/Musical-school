<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChngSess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChngSess))
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbStudent = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbCourse = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblProf = New System.Windows.Forms.Label()
        Me.cbProff = New System.Windows.Forms.ComboBox()
        Me.rbOtherProf = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbSameProf = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tdbSess = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlSess = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TdbAvSess = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.lblSelecProf = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tdbSess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSess.SuspendLayout()
        CType(Me.TdbAvSess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(102, 475)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(94, 55)
        Me.btnModify.TabIndex = 23
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
        Me.btnSave.Location = New System.Drawing.Point(434, 475)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 55)
        Me.btnSave.TabIndex = 21
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
        Me.btnClose.Location = New System.Drawing.Point(609, 475)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 55)
        Me.btnClose.TabIndex = 22
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
        Me.btnCancel.Location = New System.Drawing.Point(266, 475)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cbStudent)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbCourse)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 182)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'cbStudent
        '
        Me.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbStudent.FormattingEnabled = True
        Me.cbStudent.Location = New System.Drawing.Point(9, 143)
        Me.cbStudent.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.cbStudent.Name = "cbStudent"
        Me.cbStudent.Size = New System.Drawing.Size(342, 28)
        Me.cbStudent.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(9, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 38)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Student"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbCourse
        '
        Me.CbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbCourse.FormattingEnabled = True
        Me.CbCourse.Location = New System.Drawing.Point(9, 56)
        Me.CbCourse.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.CbCourse.Name = "CbCourse"
        Me.CbCourse.Size = New System.Drawing.Size(342, 28)
        Me.CbCourse.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Wheat
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Calibri", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(9, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 38)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Course"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LblProf)
        Me.GroupBox2.Controls.Add(Me.cbProff)
        Me.GroupBox2.Controls.Add(Me.rbOtherProf)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.rbSameProf)
        Me.GroupBox2.Location = New System.Drawing.Point(-3, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(833, 139)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Wheat
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Calibri", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(39, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 38)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Professor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(410, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(4, 134)
        Me.Label7.TabIndex = 29
        '
        'LblProf
        '
        Me.LblProf.BackColor = System.Drawing.Color.White
        Me.LblProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProf.Location = New System.Drawing.Point(39, 99)
        Me.LblProf.Name = "LblProf"
        Me.LblProf.Size = New System.Drawing.Size(297, 23)
        Me.LblProf.TabIndex = 31
        '
        'cbProff
        '
        Me.cbProff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbProff.FormattingEnabled = True
        Me.cbProff.Location = New System.Drawing.Point(436, 99)
        Me.cbProff.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.cbProff.Name = "cbProff"
        Me.cbProff.Size = New System.Drawing.Size(342, 28)
        Me.cbProff.TabIndex = 30
        '
        'rbOtherProf
        '
        Me.rbOtherProf.AutoSize = True
        Me.rbOtherProf.BackColor = System.Drawing.Color.White
        Me.rbOtherProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOtherProf.ForeColor = System.Drawing.Color.Maroon
        Me.rbOtherProf.Location = New System.Drawing.Point(436, 16)
        Me.rbOtherProf.Name = "rbOtherProf"
        Me.rbOtherProf.Size = New System.Drawing.Size(174, 28)
        Me.rbOtherProf.TabIndex = 1
        Me.rbOtherProf.Text = "Other Professor"
        Me.rbOtherProf.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(435, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 38)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Professor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbSameProf
        '
        Me.rbSameProf.AutoSize = True
        Me.rbSameProf.BackColor = System.Drawing.Color.White
        Me.rbSameProf.Checked = True
        Me.rbSameProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSameProf.ForeColor = System.Drawing.Color.Maroon
        Me.rbSameProf.Location = New System.Drawing.Point(39, 16)
        Me.rbSameProf.Name = "rbSameProf"
        Me.rbSameProf.Size = New System.Drawing.Size(175, 28)
        Me.rbSameProf.TabIndex = 0
        Me.rbSameProf.TabStop = True
        Me.rbSameProf.Text = "Same Professor"
        Me.rbSameProf.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(-22, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(850, 4)
        Me.Label3.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(-2, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(840, 4)
        Me.Label4.TabIndex = 27
        '
        'tdbSess
        '
        Me.tdbSess.AllowColMove = False
        Me.tdbSess.AllowColSelect = False
        Me.tdbSess.AllowDelete = True
        Me.tdbSess.AllowFilter = False
        Me.tdbSess.AllowSort = False
        Me.tdbSess.AllowUpdate = False
        Me.tdbSess.Caption = " "
        Me.tdbSess.CaptionHeight = 25
        Me.tdbSess.Images.Add(CType(resources.GetObject("tdbSess.Images"), System.Drawing.Image))
        Me.tdbSess.Location = New System.Drawing.Point(-3, 320)
        Me.tdbSess.Name = "tdbSess"
        Me.tdbSess.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbSess.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbSess.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbSess.PrintInfo.PageSettings = CType(resources.GetObject("tdbSess.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbSess.Size = New System.Drawing.Size(831, 117)
        Me.tdbSess.TabIndex = 28
        Me.tdbSess.PropBag = resources.GetString("tdbSess.PropBag")
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(0, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(456, 18)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "P.S : Double Click on The Row To Change"
        '
        'pnlSess
        '
        Me.pnlSess.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlSess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSess.Controls.Add(Me.Button1)
        Me.pnlSess.Controls.Add(Me.TdbAvSess)
        Me.pnlSess.Controls.Add(Me.lblSelecProf)
        Me.pnlSess.Controls.Add(Me.Label9)
        Me.pnlSess.Location = New System.Drawing.Point(98, 36)
        Me.pnlSess.Name = "pnlSess"
        Me.pnlSess.Size = New System.Drawing.Size(673, 342)
        Me.pnlSess.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Firebrick
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(628, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 41)
        Me.Button1.TabIndex = 49
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TdbAvSess
        '
        Me.TdbAvSess.AllowColMove = False
        Me.TdbAvSess.AllowColSelect = False
        Me.TdbAvSess.AllowDelete = True
        Me.TdbAvSess.AllowFilter = False
        Me.TdbAvSess.AllowUpdate = False
        Me.TdbAvSess.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TdbAvSess.Caption = "Available Sessions"
        Me.TdbAvSess.CaptionHeight = 25
        Me.TdbAvSess.ForeColor = System.Drawing.Color.Black
        Me.TdbAvSess.Images.Add(CType(resources.GetObject("TdbAvSess.Images"), System.Drawing.Image))
        Me.TdbAvSess.Location = New System.Drawing.Point(0, 89)
        Me.TdbAvSess.Name = "TdbAvSess"
        Me.TdbAvSess.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TdbAvSess.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TdbAvSess.PreviewInfo.ZoomFactor = 75.0R
        Me.TdbAvSess.PrintInfo.PageSettings = CType(resources.GetObject("TdbAvSess.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TdbAvSess.Size = New System.Drawing.Size(673, 252)
        Me.TdbAvSess.TabIndex = 29
        Me.TdbAvSess.PropBag = resources.GetString("TdbAvSess.PropBag")
        '
        'lblSelecProf
        '
        Me.lblSelecProf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSelecProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelecProf.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelecProf.ForeColor = System.Drawing.Color.Maroon
        Me.lblSelecProf.Location = New System.Drawing.Point(108, 38)
        Me.lblSelecProf.Name = "lblSelecProf"
        Me.lblSelecProf.Size = New System.Drawing.Size(474, 36)
        Me.lblSelecProf.TabIndex = 1
        Me.lblSelecProf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(276, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 36)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Professor"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Wheat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(157, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 19)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Current Sessions"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Wheat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(535, 323)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 19)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "New Sessions"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(408, 344)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(3, 92)
        Me.Label12.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(-52, 466)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(909, 4)
        Me.Label13.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(-22, 471)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(882, 63)
        Me.Label14.TabIndex = 58
        '
        'frmChngSess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 533)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.pnlSess)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tdbSess)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChngSess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changing Student  Sessions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tdbSess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSess.ResumeLayout(False)
        CType(Me.TdbAvSess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbStudent As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbOtherProf As System.Windows.Forms.RadioButton
    Friend WithEvents rbSameProf As System.Windows.Forms.RadioButton
    Friend WithEvents cbProff As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tdbSess As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblProf As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlSess As System.Windows.Forms.Panel
    Friend WithEvents TdbAvSess As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents lblSelecProf As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
