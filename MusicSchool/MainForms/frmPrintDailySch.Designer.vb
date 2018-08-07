<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintDailySch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintDailySch))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblEndDate = New System.Windows.Forms.Label()
        Me.LblStrDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblMonth = New System.Windows.Forms.Label()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbTime = New System.Windows.Forms.RadioButton()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkStd = New System.Windows.Forms.CheckBox()
        Me.ChkMond = New System.Windows.Forms.CheckBox()
        Me.Pnldate = New System.Windows.Forms.Panel()
        Me.chkSat = New System.Windows.Forms.CheckBox()
        Me.chkFrid = New System.Windows.Forms.CheckBox()
        Me.ChkThur = New System.Windows.Forms.CheckBox()
        Me.chkWed = New System.Windows.Forms.CheckBox()
        Me.chkTue = New System.Windows.Forms.CheckBox()
        Me.tdbProf = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCourse = New System.Windows.Forms.RadioButton()
        Me.rbStud = New System.Windows.Forms.RadioButton()
        Me.RbProff = New System.Windows.Forms.RadioButton()
        Me.TdbCourse = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnUnchkProf = New System.Windows.Forms.Button()
        Me.btnChkProf = New System.Windows.Forms.Button()
        Me.btnUnchStd = New System.Windows.Forms.Button()
        Me.BtnChkStd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnldate.SuspendLayout()
        CType(Me.tdbProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TdbCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.LblEndDate)
        Me.GroupBox1.Controls.Add(Me.LblStrDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblMonth)
        Me.GroupBox1.Controls.Add(Me.LblYear)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(6, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(749, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LblEndDate
        '
        Me.LblEndDate.BackColor = System.Drawing.Color.White
        Me.LblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndDate.Location = New System.Drawing.Point(358, 93)
        Me.LblEndDate.Name = "LblEndDate"
        Me.LblEndDate.Size = New System.Drawing.Size(141, 27)
        Me.LblEndDate.TabIndex = 71
        Me.LblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStrDate
        '
        Me.LblStrDate.BackColor = System.Drawing.Color.White
        Me.LblStrDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStrDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStrDate.Location = New System.Drawing.Point(217, 93)
        Me.LblStrDate.Name = "LblStrDate"
        Me.LblStrDate.Size = New System.Drawing.Size(141, 27)
        Me.LblStrDate.TabIndex = 70
        Me.LblStrDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Wheat
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(358, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 27)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "End Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(217, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 27)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Start Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMonth
        '
        Me.LblMonth.BackColor = System.Drawing.Color.White
        Me.LblMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonth.Location = New System.Drawing.Point(528, 22)
        Me.LblMonth.Name = "LblMonth"
        Me.LblMonth.Size = New System.Drawing.Size(107, 27)
        Me.LblMonth.TabIndex = 67
        Me.LblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblYear
        '
        Me.LblYear.BackColor = System.Drawing.Color.White
        Me.LblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYear.Location = New System.Drawing.Point(185, 22)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(107, 27)
        Me.LblYear.TabIndex = 66
        Me.LblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Wheat
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(421, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 27)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Month"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(79, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 27)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Year"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbTime
        '
        Me.rbTime.BackColor = System.Drawing.Color.Gray
        Me.rbTime.Checked = True
        Me.rbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTime.ForeColor = System.Drawing.Color.White
        Me.rbTime.Location = New System.Drawing.Point(8, 23)
        Me.rbTime.Name = "rbTime"
        Me.rbTime.Size = New System.Drawing.Size(123, 20)
        Me.rbTime.TabIndex = 63
        Me.rbTime.TabStop = True
        Me.rbTime.Text = "Time"
        Me.rbTime.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.LightGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(217, 429)
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
        Me.btnClose.Location = New System.Drawing.Point(425, 429)
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
        Me.Label8.Location = New System.Drawing.Point(-135, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(909, 4)
        Me.Label8.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-143, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(906, 72)
        Me.Label9.TabIndex = 59
        '
        'ChkStd
        '
        Me.ChkStd.AutoSize = True
        Me.ChkStd.BackColor = System.Drawing.Color.White
        Me.ChkStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkStd.ForeColor = System.Drawing.Color.Maroon
        Me.ChkStd.Location = New System.Drawing.Point(7, 394)
        Me.ChkStd.Name = "ChkStd"
        Me.ChkStd.Size = New System.Drawing.Size(215, 20)
        Me.ChkStd.TabIndex = 64
        Me.ChkStd.Text = "Include Available Sessions"
        Me.ChkStd.UseVisualStyleBackColor = False
        '
        'ChkMond
        '
        Me.ChkMond.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkMond.Checked = True
        Me.ChkMond.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMond.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ChkMond.FlatAppearance.BorderSize = 2
        Me.ChkMond.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.ChkMond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMond.ForeColor = System.Drawing.Color.Maroon
        Me.ChkMond.Location = New System.Drawing.Point(15, 10)
        Me.ChkMond.Name = "ChkMond"
        Me.ChkMond.Size = New System.Drawing.Size(85, 20)
        Me.ChkMond.TabIndex = 65
        Me.ChkMond.Tag = "1"
        Me.ChkMond.Text = "Monday"
        Me.ChkMond.UseVisualStyleBackColor = False
        '
        'Pnldate
        '
        Me.Pnldate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pnldate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnldate.Controls.Add(Me.chkSat)
        Me.Pnldate.Controls.Add(Me.chkFrid)
        Me.Pnldate.Controls.Add(Me.ChkThur)
        Me.Pnldate.Controls.Add(Me.chkWed)
        Me.Pnldate.Controls.Add(Me.chkTue)
        Me.Pnldate.Controls.Add(Me.ChkMond)
        Me.Pnldate.Location = New System.Drawing.Point(7, 138)
        Me.Pnldate.Name = "Pnldate"
        Me.Pnldate.Size = New System.Drawing.Size(748, 40)
        Me.Pnldate.TabIndex = 66
        '
        'chkSat
        '
        Me.chkSat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkSat.Checked = True
        Me.chkSat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSat.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkSat.FlatAppearance.BorderSize = 2
        Me.chkSat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkSat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSat.ForeColor = System.Drawing.Color.Maroon
        Me.chkSat.Location = New System.Drawing.Point(633, 10)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(92, 20)
        Me.chkSat.TabIndex = 70
        Me.chkSat.Tag = "6"
        Me.chkSat.Text = "Saturday"
        Me.chkSat.UseVisualStyleBackColor = False
        '
        'chkFrid
        '
        Me.chkFrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkFrid.Checked = True
        Me.chkFrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFrid.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkFrid.FlatAppearance.BorderSize = 2
        Me.chkFrid.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkFrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFrid.ForeColor = System.Drawing.Color.Maroon
        Me.chkFrid.Location = New System.Drawing.Point(528, 10)
        Me.chkFrid.Name = "chkFrid"
        Me.chkFrid.Size = New System.Drawing.Size(74, 20)
        Me.chkFrid.TabIndex = 69
        Me.chkFrid.Tag = "5"
        Me.chkFrid.Text = "Friday"
        Me.chkFrid.UseVisualStyleBackColor = False
        '
        'ChkThur
        '
        Me.ChkThur.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkThur.Checked = True
        Me.ChkThur.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkThur.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ChkThur.FlatAppearance.BorderSize = 2
        Me.ChkThur.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.ChkThur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkThur.ForeColor = System.Drawing.Color.Maroon
        Me.ChkThur.Location = New System.Drawing.Point(402, 10)
        Me.ChkThur.Name = "ChkThur"
        Me.ChkThur.Size = New System.Drawing.Size(95, 20)
        Me.ChkThur.TabIndex = 68
        Me.ChkThur.Tag = "4"
        Me.ChkThur.Text = "Thursday"
        Me.ChkThur.UseVisualStyleBackColor = False
        '
        'chkWed
        '
        Me.chkWed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkWed.Checked = True
        Me.chkWed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWed.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkWed.FlatAppearance.BorderSize = 2
        Me.chkWed.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkWed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWed.ForeColor = System.Drawing.Color.Maroon
        Me.chkWed.Location = New System.Drawing.Point(257, 10)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(114, 20)
        Me.chkWed.TabIndex = 67
        Me.chkWed.Tag = "3"
        Me.chkWed.Text = "Wednesday"
        Me.chkWed.UseVisualStyleBackColor = False
        '
        'chkTue
        '
        Me.chkTue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkTue.Checked = True
        Me.chkTue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTue.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.chkTue.FlatAppearance.BorderSize = 2
        Me.chkTue.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.chkTue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTue.ForeColor = System.Drawing.Color.Maroon
        Me.chkTue.Location = New System.Drawing.Point(131, 10)
        Me.chkTue.Name = "chkTue"
        Me.chkTue.Size = New System.Drawing.Size(95, 20)
        Me.chkTue.TabIndex = 66
        Me.chkTue.Tag = "2"
        Me.chkTue.Text = "Tuesday"
        Me.chkTue.UseVisualStyleBackColor = False
        '
        'tdbProf
        '
        Me.tdbProf.AllowColMove = False
        Me.tdbProf.AllowColSelect = False
        Me.tdbProf.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbProf.Caption = " Professors"
        Me.tdbProf.CaptionHeight = 25
        Me.tdbProf.FilterBar = True
        Me.tdbProf.Images.Add(CType(resources.GetObject("tdbProf.Images"), System.Drawing.Image))
        Me.tdbProf.Location = New System.Drawing.Point(7, 178)
        Me.tdbProf.Name = "tdbProf"
        Me.tdbProf.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbProf.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbProf.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbProf.PrintInfo.PageSettings = CType(resources.GetObject("tdbProf.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbProf.RowHeight = 18
        Me.tdbProf.Size = New System.Drawing.Size(320, 178)
        Me.tdbProf.TabIndex = 67
        Me.tdbProf.PropBag = resources.GetString("tdbProf.PropBag")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.rbCourse)
        Me.GroupBox2.Controls.Add(Me.rbStud)
        Me.GroupBox2.Controls.Add(Me.RbProff)
        Me.GroupBox2.Controls.Add(Me.rbTime)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(603, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 173)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order by"
        '
        'rbCourse
        '
        Me.rbCourse.BackColor = System.Drawing.Color.Gray
        Me.rbCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCourse.ForeColor = System.Drawing.Color.White
        Me.rbCourse.Location = New System.Drawing.Point(8, 92)
        Me.rbCourse.Name = "rbCourse"
        Me.rbCourse.Size = New System.Drawing.Size(123, 20)
        Me.rbCourse.TabIndex = 66
        Me.rbCourse.Text = "Courses"
        Me.rbCourse.UseVisualStyleBackColor = False
        '
        'rbStud
        '
        Me.rbStud.BackColor = System.Drawing.Color.Gray
        Me.rbStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStud.ForeColor = System.Drawing.Color.White
        Me.rbStud.Location = New System.Drawing.Point(8, 126)
        Me.rbStud.Name = "rbStud"
        Me.rbStud.Size = New System.Drawing.Size(123, 20)
        Me.rbStud.TabIndex = 65
        Me.rbStud.Text = "Students"
        Me.rbStud.UseVisualStyleBackColor = False
        '
        'RbProff
        '
        Me.RbProff.BackColor = System.Drawing.Color.Gray
        Me.RbProff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbProff.ForeColor = System.Drawing.Color.White
        Me.RbProff.Location = New System.Drawing.Point(8, 57)
        Me.RbProff.Name = "RbProff"
        Me.RbProff.Size = New System.Drawing.Size(123, 20)
        Me.RbProff.TabIndex = 64
        Me.RbProff.Text = "Professors"
        Me.RbProff.UseVisualStyleBackColor = False
        '
        'TdbCourse
        '
        Me.TdbCourse.AllowColMove = False
        Me.TdbCourse.AllowColSelect = False
        Me.TdbCourse.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.TdbCourse.Caption = " Courses"
        Me.TdbCourse.CaptionHeight = 25
        Me.TdbCourse.FetchRowStyles = True
        Me.TdbCourse.FilterBar = True
        Me.TdbCourse.Images.Add(CType(resources.GetObject("TdbCourse.Images"), System.Drawing.Image))
        Me.TdbCourse.Location = New System.Drawing.Point(333, 178)
        Me.TdbCourse.Name = "TdbCourse"
        Me.TdbCourse.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TdbCourse.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TdbCourse.PreviewInfo.ZoomFactor = 75.0R
        Me.TdbCourse.PrintInfo.PageSettings = CType(resources.GetObject("TdbCourse.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TdbCourse.RowHeight = 18
        Me.TdbCourse.Size = New System.Drawing.Size(264, 178)
        Me.TdbCourse.TabIndex = 69
        Me.TdbCourse.PropBag = resources.GetString("TdbCourse.PropBag")
        '
        'btnUnchkProf
        '
        Me.btnUnchkProf.BackColor = System.Drawing.Color.Wheat
        Me.btnUnchkProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnchkProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnchkProf.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnchkProf.ForeColor = System.Drawing.Color.Maroon
        Me.btnUnchkProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnchkProf.Location = New System.Drawing.Point(120, 356)
        Me.btnUnchkProf.Name = "btnUnchkProf"
        Me.btnUnchkProf.Size = New System.Drawing.Size(115, 32)
        Me.btnUnchkProf.TabIndex = 71
        Me.btnUnchkProf.Tag = "button"
        Me.btnUnchkProf.Text = "UnCheck All"
        Me.btnUnchkProf.UseVisualStyleBackColor = False
        '
        'btnChkProf
        '
        Me.btnChkProf.BackColor = System.Drawing.Color.Wheat
        Me.btnChkProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChkProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChkProf.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChkProf.ForeColor = System.Drawing.Color.Maroon
        Me.btnChkProf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChkProf.Location = New System.Drawing.Point(7, 356)
        Me.btnChkProf.Name = "btnChkProf"
        Me.btnChkProf.Size = New System.Drawing.Size(113, 32)
        Me.btnChkProf.TabIndex = 70
        Me.btnChkProf.Tag = "button"
        Me.btnChkProf.Text = "Check All"
        Me.btnChkProf.UseVisualStyleBackColor = False
        '
        'btnUnchStd
        '
        Me.btnUnchStd.BackColor = System.Drawing.Color.Wheat
        Me.btnUnchStd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnchStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnchStd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnchStd.ForeColor = System.Drawing.Color.Maroon
        Me.btnUnchStd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnchStd.Location = New System.Drawing.Point(446, 356)
        Me.btnUnchStd.Name = "btnUnchStd"
        Me.btnUnchStd.Size = New System.Drawing.Size(115, 32)
        Me.btnUnchStd.TabIndex = 73
        Me.btnUnchStd.Tag = "button"
        Me.btnUnchStd.Text = "UnCheck All"
        Me.btnUnchStd.UseVisualStyleBackColor = False
        '
        'BtnChkStd
        '
        Me.BtnChkStd.BackColor = System.Drawing.Color.Wheat
        Me.BtnChkStd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChkStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChkStd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChkStd.ForeColor = System.Drawing.Color.Maroon
        Me.BtnChkStd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChkStd.Location = New System.Drawing.Point(333, 356)
        Me.BtnChkStd.Name = "BtnChkStd"
        Me.BtnChkStd.Size = New System.Drawing.Size(113, 32)
        Me.BtnChkStd.TabIndex = 72
        Me.BtnChkStd.Tag = "button"
        Me.BtnChkStd.Text = "Check All"
        Me.BtnChkStd.UseVisualStyleBackColor = False
        '
        'frmPrintDailySch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 491)
        Me.Controls.Add(Me.btnUnchStd)
        Me.Controls.Add(Me.BtnChkStd)
        Me.Controls.Add(Me.btnUnchkProf)
        Me.Controls.Add(Me.btnChkProf)
        Me.Controls.Add(Me.TdbCourse)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tdbProf)
        Me.Controls.Add(Me.Pnldate)
        Me.Controls.Add(Me.ChkStd)
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
        Me.Name = "frmPrintDailySch"
        Me.Text = "Daily School Schedule"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnldate.ResumeLayout(False)
        CType(Me.tdbProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TdbCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTime As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblMonth As System.Windows.Forms.Label
    Friend WithEvents LblYear As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblEndDate As System.Windows.Forms.Label
    Friend WithEvents LblStrDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkMond As System.Windows.Forms.CheckBox
    Friend WithEvents ChkStd As System.Windows.Forms.CheckBox
    Friend WithEvents Pnldate As System.Windows.Forms.Panel
    Friend WithEvents chkSat As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrid As System.Windows.Forms.CheckBox
    Friend WithEvents ChkThur As System.Windows.Forms.CheckBox
    Friend WithEvents chkWed As System.Windows.Forms.CheckBox
    Friend WithEvents chkTue As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tdbProf As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents rbStud As System.Windows.Forms.RadioButton
    Friend WithEvents RbProff As System.Windows.Forms.RadioButton
    Friend WithEvents rbCourse As System.Windows.Forms.RadioButton
    Friend WithEvents TdbCourse As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnUnchStd As System.Windows.Forms.Button
    Friend WithEvents BtnChkStd As System.Windows.Forms.Button
    Friend WithEvents btnUnchkProf As System.Windows.Forms.Button
    Friend WithEvents btnChkProf As System.Windows.Forms.Button
End Class
