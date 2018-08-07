<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stslbl1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Stslbluser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsLbldate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Stslbltime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuInst = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuStudents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProff = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRooms = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProfSched = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCourses = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuChgStdSess = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMangProfSes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.PaymentsVouchersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProfPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProfStdMnthDisc = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRptStd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProfRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProfSchRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDaiSchoolSch = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLstAdmStd = New System.Windows.Forms.ToolStripMenuItem()
        Me.WsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuStrtClosYear = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSpecialMonth = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuHolidays = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMonthPaym = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.UsersPrivilegesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPrivUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlPass = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MnuScholPayInc = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.PnlPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stslbl1, Me.Stslbluser, Me.ToolStripStatusLabel1, Me.stsLbldate, Me.Stslbltime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stslbl1
        '
        Me.stslbl1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stslbl1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
        Me.stslbl1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stslbl1.Name = "stslbl1"
        Me.stslbl1.Size = New System.Drawing.Size(54, 21)
        Me.stslbl1.Text = "User  :"
        '
        'Stslbluser
        '
        Me.Stslbluser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.Stslbluser.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.Stslbluser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Stslbluser.ForeColor = System.Drawing.Color.Firebrick
        Me.Stslbluser.Name = "Stslbluser"
        Me.Stslbluser.Size = New System.Drawing.Size(4, 21)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(850, 21)
        '
        'stsLbldate
        '
        Me.stsLbldate.AutoSize = False
        Me.stsLbldate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.stsLbldate.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.stsLbldate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stsLbldate.Name = "stsLbldate"
        Me.stsLbldate.Size = New System.Drawing.Size(240, 21)
        Me.stsLbldate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Stslbltime
        '
        Me.Stslbltime.AutoSize = False
        Me.Stslbltime.BackColor = System.Drawing.SystemColors.Control
        Me.Stslbltime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Stslbltime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Stslbltime.Name = "Stslbltime"
        Me.Stslbltime.Size = New System.Drawing.Size(85, 21)
        Me.Stslbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Time
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdmissionToolStripMenuItem, Me.ToolStripTextBox1, Me.DToolStripMenuItem, Me.ToolStripTextBox4, Me.PaymentsVouchersToolStripMenuItem, Me.ToolStripTextBox2, Me.ReportsToolStripMenuItem, Me.WsToolStripMenuItem, Me.SystemToolStripMenuItem, Me.ToolStripTextBox3, Me.UsersPrivilegesToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 12, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 40)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdmissionToolStripMenuItem
        '
        Me.AdmissionToolStripMenuItem.AutoSize = False
        Me.AdmissionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AdmissionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuInst, Me.MnuStudents, Me.MnuProff, Me.MnuRooms})
        Me.AdmissionToolStripMenuItem.Image = Global.MusicSchool.My.Resources.Resources._11265_professor_teaching_on_a_blackboard_in_white_shapes_inside_a_black_rounded_square_vector
        Me.AdmissionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdmissionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AdmissionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.AdmissionToolStripMenuItem.Name = "AdmissionToolStripMenuItem"
        Me.AdmissionToolStripMenuItem.Size = New System.Drawing.Size(120, 19)
        Me.AdmissionToolStripMenuItem.Text = "&1-Admission/Add"
        Me.AdmissionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MnuInst
        '
        Me.MnuInst.BackColor = System.Drawing.SystemColors.Control
        Me.MnuInst.Image = Global.MusicSchool.My.Resources.Resources.musical_instrument_icons_background_33799749
        Me.MnuInst.Name = "MnuInst"
        Me.MnuInst.Size = New System.Drawing.Size(140, 22)
        Me.MnuInst.Tag = "Menu"
        Me.MnuInst.Text = "&A-Courses"
        '
        'MnuStudents
        '
        Me.MnuStudents.BackColor = System.Drawing.SystemColors.Control
        Me.MnuStudents.Image = Global.MusicSchool.My.Resources.Resources.elementary_school
        Me.MnuStudents.Name = "MnuStudents"
        Me.MnuStudents.Size = New System.Drawing.Size(140, 22)
        Me.MnuStudents.Tag = "Menu"
        Me.MnuStudents.Text = "&B-Students"
        '
        'MnuProff
        '
        Me.MnuProff.BackColor = System.Drawing.SystemColors.Control
        Me.MnuProff.Image = Global.MusicSchool.My.Resources.Resources._11265_professor_teaching_on_a_blackboard_in_white_shapes_inside_a_black_rounded_square_vector1
        Me.MnuProff.Name = "MnuProff"
        Me.MnuProff.Size = New System.Drawing.Size(140, 22)
        Me.MnuProff.Tag = "Menu"
        Me.MnuProff.Text = "&C-Professors"
        '
        'MnuRooms
        '
        Me.MnuRooms.BackColor = System.Drawing.SystemColors.Control
        Me.MnuRooms.Image = CType(resources.GetObject("MnuRooms.Image"), System.Drawing.Image)
        Me.MnuRooms.Name = "MnuRooms"
        Me.MnuRooms.Size = New System.Drawing.Size(140, 22)
        Me.MnuRooms.Tag = "Menu"
        Me.MnuRooms.Text = "&D-Rooms"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(1, 23)
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.AutoSize = False
        Me.DToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuProfSched, Me.MnuCourses, Me.MnuChgStdSess, Me.MnuMangProfSes})
        Me.DToolStripMenuItem.Image = Global.MusicSchool.My.Resources.Resources.schedule_clock_512
        Me.DToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(140, 19)
        Me.DToolStripMenuItem.Text = "&2-Classes / Schedule"
        '
        'MnuProfSched
        '
        Me.MnuProfSched.Image = Global.MusicSchool.My.Resources.Resources.schedule_clock_512
        Me.MnuProfSched.Name = "MnuProfSched"
        Me.MnuProfSched.Size = New System.Drawing.Size(247, 22)
        Me.MnuProfSched.Tag = "Menu"
        Me.MnuProfSched.Text = "&A-Professors Schedule"
        '
        'MnuCourses
        '
        Me.MnuCourses.Image = Global.MusicSchool.My.Resources.Resources._125920_matte_white_square_icon_sports_hobbies_people_guitar_man
        Me.MnuCourses.Name = "MnuCourses"
        Me.MnuCourses.Size = New System.Drawing.Size(247, 22)
        Me.MnuCourses.Tag = "Menu"
        Me.MnuCourses.Text = "&B-Students Courses"
        '
        'MnuChgStdSess
        '
        Me.MnuChgStdSess.Image = CType(resources.GetObject("MnuChgStdSess.Image"), System.Drawing.Image)
        Me.MnuChgStdSess.Name = "MnuChgStdSess"
        Me.MnuChgStdSess.Size = New System.Drawing.Size(247, 22)
        Me.MnuChgStdSess.Text = "&C-Changing Students  Sessions"
        '
        'MnuMangProfSes
        '
        Me.MnuMangProfSes.Image = CType(resources.GetObject("MnuMangProfSes.Image"), System.Drawing.Image)
        Me.MnuMangProfSes.Name = "MnuMangProfSes"
        Me.MnuMangProfSes.Size = New System.Drawing.Size(247, 22)
        Me.MnuMangProfSes.Text = "&D-Managing Professors Sessions"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.AutoSize = False
        Me.ToolStripTextBox4.BackColor = System.Drawing.SystemColors.MenuText
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(1, 23)
        '
        'PaymentsVouchersToolStripMenuItem
        '
        Me.PaymentsVouchersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PaymentsVouchersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuVoucher, Me.MnuProfPay, Me.MnuProfStdMnthDisc})
        Me.PaymentsVouchersToolStripMenuItem.Image = CType(resources.GetObject("PaymentsVouchersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PaymentsVouchersToolStripMenuItem.Name = "PaymentsVouchersToolStripMenuItem"
        Me.PaymentsVouchersToolStripMenuItem.Size = New System.Drawing.Size(163, 20)
        Me.PaymentsVouchersToolStripMenuItem.Text = "&3-Payments && Vouchers"
        '
        'MnuVoucher
        '
        Me.MnuVoucher.Image = Global.MusicSchool.My.Resources.Resources._14_512
        Me.MnuVoucher.Name = "MnuVoucher"
        Me.MnuVoucher.Size = New System.Drawing.Size(251, 22)
        Me.MnuVoucher.Tag = "Menu"
        Me.MnuVoucher.Text = "&A-Students Vouchers"
        '
        'MnuProfPay
        '
        Me.MnuProfPay.Image = Global.MusicSchool.My.Resources.Resources.Payment_Methods_Card_in_use_icon
        Me.MnuProfPay.Name = "MnuProfPay"
        Me.MnuProfPay.Size = New System.Drawing.Size(251, 22)
        Me.MnuProfPay.Tag = "Menu"
        Me.MnuProfPay.Text = "&B-Professors Payments"
        '
        'MnuProfStdMnthDisc
        '
        Me.MnuProfStdMnthDisc.Image = CType(resources.GetObject("MnuProfStdMnthDisc.Image"), System.Drawing.Image)
        Me.MnuProfStdMnthDisc.Name = "MnuProfStdMnthDisc"
        Me.MnuProfStdMnthDisc.Size = New System.Drawing.Size(251, 22)
        Me.MnuProfStdMnthDisc.Text = "&C-Prof\Stud Monthly Adjustment"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.BackColor = System.Drawing.SystemColors.MenuText
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(1, 23)
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.AutoSize = False
        Me.ReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuRptStd, Me.MnuProfRpt, Me.MnuProfSchRpt, Me.MnuDaiSchoolSch, Me.MnuLstAdmStd, Me.MnuScholPayInc})
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(94, 19)
        Me.ReportsToolStripMenuItem.Text = "&4-Reports"
        '
        'MnuRptStd
        '
        Me.MnuRptStd.Image = CType(resources.GetObject("MnuRptStd.Image"), System.Drawing.Image)
        Me.MnuRptStd.Name = "MnuRptStd"
        Me.MnuRptStd.Size = New System.Drawing.Size(234, 22)
        Me.MnuRptStd.Tag = "Menu"
        Me.MnuRptStd.Text = "&A-Students Voucher Reports"
        '
        'MnuProfRpt
        '
        Me.MnuProfRpt.Image = CType(resources.GetObject("MnuProfRpt.Image"), System.Drawing.Image)
        Me.MnuProfRpt.Name = "MnuProfRpt"
        Me.MnuProfRpt.Size = New System.Drawing.Size(234, 22)
        Me.MnuProfRpt.Tag = "Menu"
        Me.MnuProfRpt.Text = "&B-Professors Payment Reports"
        '
        'MnuProfSchRpt
        '
        Me.MnuProfSchRpt.Image = CType(resources.GetObject("MnuProfSchRpt.Image"), System.Drawing.Image)
        Me.MnuProfSchRpt.Name = "MnuProfSchRpt"
        Me.MnuProfSchRpt.Size = New System.Drawing.Size(234, 22)
        Me.MnuProfSchRpt.Text = "&C-Weekly Professors Schedule"
        '
        'MnuDaiSchoolSch
        '
        Me.MnuDaiSchoolSch.Image = CType(resources.GetObject("MnuDaiSchoolSch.Image"), System.Drawing.Image)
        Me.MnuDaiSchoolSch.Name = "MnuDaiSchoolSch"
        Me.MnuDaiSchoolSch.Size = New System.Drawing.Size(234, 22)
        Me.MnuDaiSchoolSch.Text = "&D-Daily School Schedule"
        '
        'MnuLstAdmStd
        '
        Me.MnuLstAdmStd.Image = CType(resources.GetObject("MnuLstAdmStd.Image"), System.Drawing.Image)
        Me.MnuLstAdmStd.Name = "MnuLstAdmStd"
        Me.MnuLstAdmStd.Size = New System.Drawing.Size(234, 22)
        Me.MnuLstAdmStd.Text = "&E-List Of Admitting Students"
        '
        'WsToolStripMenuItem
        '
        Me.WsToolStripMenuItem.AutoSize = False
        Me.WsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.WsToolStripMenuItem.Name = "WsToolStripMenuItem"
        Me.WsToolStripMenuItem.Size = New System.Drawing.Size(1, 23)
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.Checked = True
        Me.SystemToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuStrtClosYear, Me.MnuSpecialMonth, Me.MnuHolidays, Me.MnuMonthPaym})
        Me.SystemToolStripMenuItem.Image = CType(resources.GetObject("SystemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.SystemToolStripMenuItem.Text = "&5-System"
        '
        'MnuStrtClosYear
        '
        Me.MnuStrtClosYear.Image = CType(resources.GetObject("MnuStrtClosYear.Image"), System.Drawing.Image)
        Me.MnuStrtClosYear.Name = "MnuStrtClosYear"
        Me.MnuStrtClosYear.Size = New System.Drawing.Size(199, 22)
        Me.MnuStrtClosYear.Text = "&A- Close And Start  Year"
        '
        'MnuSpecialMonth
        '
        Me.MnuSpecialMonth.Image = CType(resources.GetObject("MnuSpecialMonth.Image"), System.Drawing.Image)
        Me.MnuSpecialMonth.Name = "MnuSpecialMonth"
        Me.MnuSpecialMonth.Size = New System.Drawing.Size(199, 22)
        Me.MnuSpecialMonth.Text = "&B- Special Months"
        '
        'MnuHolidays
        '
        Me.MnuHolidays.Image = CType(resources.GetObject("MnuHolidays.Image"), System.Drawing.Image)
        Me.MnuHolidays.Name = "MnuHolidays"
        Me.MnuHolidays.Size = New System.Drawing.Size(199, 22)
        Me.MnuHolidays.Text = "&C- School Holidays"
        '
        'MnuMonthPaym
        '
        Me.MnuMonthPaym.Image = CType(resources.GetObject("MnuMonthPaym.Image"), System.Drawing.Image)
        Me.MnuMonthPaym.Name = "MnuMonthPaym"
        Me.MnuMonthPaym.Size = New System.Drawing.Size(199, 22)
        Me.MnuMonthPaym.Text = "&D- Monthly Payments"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.BackColor = System.Drawing.SystemColors.MenuText
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(1, 23)
        '
        'UsersPrivilegesToolStripMenuItem
        '
        Me.UsersPrivilegesToolStripMenuItem.AutoSize = False
        Me.UsersPrivilegesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UsersPrivilegesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuUser, Me.MnuPrivUser})
        Me.UsersPrivilegesToolStripMenuItem.Image = CType(resources.GetObject("UsersPrivilegesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsersPrivilegesToolStripMenuItem.Name = "UsersPrivilegesToolStripMenuItem"
        Me.UsersPrivilegesToolStripMenuItem.Size = New System.Drawing.Size(140, 19)
        Me.UsersPrivilegesToolStripMenuItem.Text = "&6-Users && Privileges"
        '
        'MnuUser
        '
        Me.MnuUser.Image = Global.MusicSchool.My.Resources.Resources.users_icon
        Me.MnuUser.Name = "MnuUser"
        Me.MnuUser.Size = New System.Drawing.Size(167, 22)
        Me.MnuUser.Tag = "Menu"
        Me.MnuUser.Text = "&A-Users"
        '
        'MnuPrivUser
        '
        Me.MnuPrivUser.Image = Global.MusicSchool.My.Resources.Resources.cbef081d709fe61c46eb7a0831a1ac2a
        Me.MnuPrivUser.Name = "MnuPrivUser"
        Me.MnuPrivUser.Size = New System.Drawing.Size(167, 22)
        Me.MnuPrivUser.Tag = "Menu"
        Me.MnuPrivUser.Text = "&B-Users Privileges"
        '
        'PnlPass
        '
        Me.PnlPass.BackColor = System.Drawing.Color.LightCoral
        Me.PnlPass.Controls.Add(Me.Label2)
        Me.PnlPass.Controls.Add(Me.Label1)
        Me.PnlPass.Controls.Add(Me.TxtPass)
        Me.PnlPass.Location = New System.Drawing.Point(318, 40)
        Me.PnlPass.Name = "PnlPass"
        Me.PnlPass.Size = New System.Drawing.Size(271, 56)
        Me.PnlPass.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(192, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Press Enter"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Location = New System.Drawing.Point(0, 26)
        Me.TxtPass.Multiline = True
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(271, 27)
        Me.TxtPass.TabIndex = 0
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Double Click on A Session To register the Student"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'MnuScholPayInc
        '
        Me.MnuScholPayInc.Image = CType(resources.GetObject("MnuScholPayInc.Image"), System.Drawing.Image)
        Me.MnuScholPayInc.Name = "MnuScholPayInc"
        Me.MnuScholPayInc.Size = New System.Drawing.Size(234, 22)
        Me.MnuScholPayInc.Text = "&F- School Payment && Income"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1264, 750)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PnlPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PnlPass.ResumeLayout(False)
        Me.PnlPass.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stslbl1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Stslbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Stslbltime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents stsLbldate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuStudents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuInst As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCourses As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProfSched As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersPrivilegesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuPrivUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PnlPass As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents PaymentsVouchersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVoucher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProfPay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuRptStd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProfRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents MnuRooms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents WsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSpecialMonth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuStrtClosYear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuHolidays As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuChgStdSess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuMangProfSes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProfStdMnthDisc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProfSchRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuDaiSchoolSch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLstAdmStd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuMonthPaym As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuScholPayInc As System.Windows.Forms.ToolStripMenuItem

End Class
