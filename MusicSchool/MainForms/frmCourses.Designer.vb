<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourses))
        Me.CbProff = New System.Windows.Forms.ComboBox()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tdbcourses = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbCourse = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblStudentNo = New System.Windows.Forms.Label()
        Me.LblProfNO = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblMode = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblsess = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnSchedule = New System.Windows.Forms.Button()
        Me.sestimer = New System.Windows.Forms.Timer(Me.components)
        Me.GrpMode = New System.Windows.Forms.GroupBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.RbDelete = New System.Windows.Forms.RadioButton()
        Me.RbAdd = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tdbcourses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GrpMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'CbProff
        '
        Me.CbProff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbProff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProff.ForeColor = System.Drawing.Color.Black
        Me.CbProff.FormattingEnabled = True
        Me.CbProff.Location = New System.Drawing.Point(17, 154)
        Me.CbProff.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.CbProff.Name = "CbProff"
        Me.CbProff.Size = New System.Drawing.Size(342, 28)
        Me.CbProff.TabIndex = 3
        '
        'LblCount
        '
        Me.LblCount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCount.Font = New System.Drawing.Font("Arial Narrow", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.ForeColor = System.Drawing.Color.Firebrick
        Me.LblCount.Location = New System.Drawing.Point(800, 467)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(86, 32)
        Me.LblCount.TabIndex = 6
        Me.LblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(88, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 23)
        Me.Label4.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Already registred students"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.MusicSchool.My.Resources.Resources.Save
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(498, 517)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 55)
        Me.btnSave.TabIndex = 13
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
        Me.btnClose.Location = New System.Drawing.Point(705, 517)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 55)
        Me.btnClose.TabIndex = 14
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
        Me.btnCancel.Location = New System.Drawing.Point(298, 517)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(102, 517)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(94, 55)
        Me.btnModify.TabIndex = 15
        Me.btnModify.Tag = "button"
        Me.btnModify.Text = "    Modify   - F4"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 307)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Firebrick
        Me.Label15.Location = New System.Drawing.Point(609, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(180, 15)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = " Attending Another Courses"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Honeydew
        Me.Button1.Location = New System.Drawing.Point(7, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 38)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Yellow
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(676, 265)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 23)
        Me.Label14.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightSalmon
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(511, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(443, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Registred With selected professor"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightGreen
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(283, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 23)
        Me.Label8.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(197, 291)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Registred with selected Prof And Another prof"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(357, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total Students"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(785, 253)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Total Students"
        '
        'tdbcourses
        '
        Me.tdbcourses.AllowColMove = False
        Me.tdbcourses.CaptionHeight = 17
        Me.tdbcourses.FetchRowStyles = True
        Me.tdbcourses.FilterBar = True
        Me.tdbcourses.Images.Add(CType(resources.GetObject("tdbcourses.Images"), System.Drawing.Image))
        Me.tdbcourses.Location = New System.Drawing.Point(12, 208)
        Me.tdbcourses.Name = "tdbcourses"
        Me.tdbcourses.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbcourses.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbcourses.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbcourses.PrintInfo.PageSettings = CType(resources.GetObject("tdbcourses.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbcourses.RowHeight = 17
        Me.tdbcourses.Size = New System.Drawing.Size(881, 241)
        Me.tdbcourses.TabIndex = 2
        Me.tdbcourses.PropBag = resources.GetString("tdbcourses.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Wheat
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(17, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 35)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Professors"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Crimson
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Wheat
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Calibri", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(17, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 38)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Courses"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbCourse
        '
        Me.CbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CbCourse.FormattingEnabled = True
        Me.CbCourse.Location = New System.Drawing.Point(17, 56)
        Me.CbCourse.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.CbCourse.Name = "CbCourse"
        Me.CbCourse.Size = New System.Drawing.Size(342, 28)
        Me.CbCourse.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.LblStudentNo)
        Me.GroupBox2.Controls.Add(Me.LblProfNO)
        Me.GroupBox2.Controls.Add(Me.LblPrice)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(891, 93)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'LblStudentNo
        '
        Me.LblStudentNo.BackColor = System.Drawing.Color.White
        Me.LblStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStudentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudentNo.ForeColor = System.Drawing.Color.Maroon
        Me.LblStudentNo.Location = New System.Drawing.Point(742, 41)
        Me.LblStudentNo.Name = "LblStudentNo"
        Me.LblStudentNo.Size = New System.Drawing.Size(115, 23)
        Me.LblStudentNo.TabIndex = 69
        Me.LblStudentNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblProfNO
        '
        Me.LblProfNO.BackColor = System.Drawing.Color.White
        Me.LblProfNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblProfNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProfNO.ForeColor = System.Drawing.Color.Maroon
        Me.LblProfNO.Location = New System.Drawing.Point(609, 41)
        Me.LblProfNO.Name = "LblProfNO"
        Me.LblProfNO.Size = New System.Drawing.Size(115, 23)
        Me.LblProfNO.TabIndex = 69
        Me.LblProfNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPrice
        '
        Me.LblPrice.BackColor = System.Drawing.Color.White
        Me.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.ForeColor = System.Drawing.Color.Maroon
        Me.LblPrice.Location = New System.Drawing.Point(474, 41)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(115, 23)
        Me.LblPrice.TabIndex = 68
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Wheat
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(474, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 25)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Course Price"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Wheat
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(742, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 25)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "# Students"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Wheat
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(609, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "# Of Professors Registred"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.LblMode)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.lblsess)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.BtnSchedule)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(891, 100)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'LblMode
        '
        Me.LblMode.BackColor = System.Drawing.Color.Beige
        Me.LblMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMode.ForeColor = System.Drawing.Color.Firebrick
        Me.LblMode.Location = New System.Drawing.Point(637, 48)
        Me.LblMode.Name = "LblMode"
        Me.LblMode.Size = New System.Drawing.Size(147, 30)
        Me.LblMode.TabIndex = 72
        Me.LblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Wheat
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Olive
        Me.Label17.Location = New System.Drawing.Point(637, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 29)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Mode"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsess
        '
        Me.lblsess.BackColor = System.Drawing.Color.White
        Me.lblsess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsess.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsess.ForeColor = System.Drawing.Color.Firebrick
        Me.lblsess.Location = New System.Drawing.Point(358, 44)
        Me.lblsess.Name = "lblsess"
        Me.lblsess.Size = New System.Drawing.Size(147, 41)
        Me.lblsess.TabIndex = 70
        Me.lblsess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Wheat
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Firebrick
        Me.Label16.Location = New System.Drawing.Point(358, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(147, 29)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Sessions"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSchedule
        '
        Me.BtnSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnSchedule.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSchedule.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSchedule.Location = New System.Drawing.Point(255, 15)
        Me.BtnSchedule.Name = "BtnSchedule"
        Me.BtnSchedule.Size = New System.Drawing.Size(96, 39)
        Me.BtnSchedule.TabIndex = 0
        Me.BtnSchedule.Text = "Schedule"
        Me.BtnSchedule.UseVisualStyleBackColor = False
        '
        'sestimer
        '
        Me.sestimer.Interval = 1500
        '
        'GrpMode
        '
        Me.GrpMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GrpMode.Controls.Add(Me.BtnOk)
        Me.GrpMode.Controls.Add(Me.RbDelete)
        Me.GrpMode.Controls.Add(Me.RbAdd)
        Me.GrpMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GrpMode.Location = New System.Drawing.Point(26, 395)
        Me.GrpMode.Name = "GrpMode"
        Me.GrpMode.Size = New System.Drawing.Size(273, 117)
        Me.GrpMode.TabIndex = 71
        Me.GrpMode.TabStop = False
        Me.GrpMode.Text = "Mode"
        Me.GrpMode.Visible = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderSize = 2
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.Firebrick
        Me.BtnOk.Image = CType(resources.GetObject("BtnOk.Image"), System.Drawing.Image)
        Me.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnOk.Location = New System.Drawing.Point(94, 73)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(68, 34)
        Me.BtnOk.TabIndex = 6
        Me.BtnOk.Text = "OK"
        Me.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'RbDelete
        '
        Me.RbDelete.AutoSize = True
        Me.RbDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDelete.ForeColor = System.Drawing.Color.Firebrick
        Me.RbDelete.Location = New System.Drawing.Point(121, 30)
        Me.RbDelete.Name = "RbDelete"
        Me.RbDelete.Size = New System.Drawing.Size(139, 35)
        Me.RbDelete.TabIndex = 1
        Me.RbDelete.Text = "Remove"
        Me.RbDelete.UseVisualStyleBackColor = True
        '
        'RbAdd
        '
        Me.RbAdd.AutoSize = True
        Me.RbAdd.Checked = True
        Me.RbAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAdd.ForeColor = System.Drawing.Color.Firebrick
        Me.RbAdd.Location = New System.Drawing.Point(17, 30)
        Me.RbAdd.Name = "RbAdd"
        Me.RbAdd.Size = New System.Drawing.Size(93, 35)
        Me.RbAdd.TabIndex = 0
        Me.RbAdd.TabStop = True
        Me.RbAdd.Text = "ADD"
        Me.RbAdd.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(9, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(890, 4)
        Me.Label18.TabIndex = 72
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(-30, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(981, 4)
        Me.Label19.TabIndex = 73
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Maroon
        Me.Label20.Location = New System.Drawing.Point(-3, 505)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(909, 4)
        Me.Label20.TabIndex = 74
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(0, 510)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(906, 63)
        Me.Label21.TabIndex = 75
        '
        'frmCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 575)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GrpMode)
        Me.Controls.Add(Me.CbCourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.CbProff)
        Me.Controls.Add(Me.tdbcourses)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCourses"
        Me.Text = "Courses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tdbcourses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpMode.ResumeLayout(False)
        Me.GrpMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbProff As System.Windows.Forms.ComboBox
    Friend WithEvents LblCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tdbcourses As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblStudentNo As System.Windows.Forms.Label
    Friend WithEvents LblProfNO As System.Windows.Forms.Label
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSchedule As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblsess As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents sestimer As System.Windows.Forms.Timer
    Friend WithEvents GrpMode As System.Windows.Forms.GroupBox
    Friend WithEvents RbDelete As System.Windows.Forms.RadioButton
    Friend WithEvents RbAdd As System.Windows.Forms.RadioButton
    Friend WithEvents LblMode As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
