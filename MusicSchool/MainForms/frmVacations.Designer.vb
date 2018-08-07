<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVacations))
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnPrvs = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbHalfDay = New System.Windows.Forms.RadioButton()
        Me.rbFulday = New System.Windows.Forms.RadioButton()
        Me.MnthEndDate = New System.Windows.Forms.MonthCalendar()
        Me.MntStrdate = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Student = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tdbHolid = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.tdbHolid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(66, 512)
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
        Me.btnSave.Location = New System.Drawing.Point(398, 512)
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
        Me.btnClose.Location = New System.Drawing.Point(573, 512)
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
        Me.btnCancel.Location = New System.Drawing.Point(230, 512)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-1, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(766, 3)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.BtnPrvs)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtReason)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.rbHalfDay)
        Me.Panel1.Controls.Add(Me.rbFulday)
        Me.Panel1.Controls.Add(Me.MnthEndDate)
        Me.Panel1.Controls.Add(Me.MntStrdate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Student)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(-8, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 292)
        Me.Panel1.TabIndex = 21
        '
        'BtnPrvs
        '
        Me.BtnPrvs.BackColor = System.Drawing.Color.Wheat
        Me.BtnPrvs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrvs.Image = Global.MusicSchool.My.Resources.Resources.Iconshock_Real_Vista_Text_Search_b
        Me.BtnPrvs.Location = New System.Drawing.Point(350, 14)
        Me.BtnPrvs.Name = "BtnPrvs"
        Me.BtnPrvs.Size = New System.Drawing.Size(42, 40)
        Me.BtnPrvs.TabIndex = 61
        Me.BtnPrvs.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Firebrick
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(306, 248)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 41)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtReason
        '
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReason.Location = New System.Drawing.Point(187, 213)
        Me.txtReason.MaxLength = 100
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(491, 30)
        Me.txtReason.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Wheat
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(57, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 27)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Reason"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(57, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 30)
        Me.Label5.TabIndex = 58
        '
        'rbHalfDay
        '
        Me.rbHalfDay.BackColor = System.Drawing.Color.White
        Me.rbHalfDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalfDay.ForeColor = System.Drawing.Color.Red
        Me.rbHalfDay.Location = New System.Drawing.Point(316, 137)
        Me.rbHalfDay.Name = "rbHalfDay"
        Me.rbHalfDay.Size = New System.Drawing.Size(104, 24)
        Me.rbHalfDay.TabIndex = 55
        Me.rbHalfDay.Text = "Half Day"
        Me.rbHalfDay.UseVisualStyleBackColor = False
        '
        'rbFulday
        '
        Me.rbFulday.BackColor = System.Drawing.Color.White
        Me.rbFulday.Checked = True
        Me.rbFulday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFulday.ForeColor = System.Drawing.Color.Red
        Me.rbFulday.Location = New System.Drawing.Point(316, 85)
        Me.rbFulday.Name = "rbFulday"
        Me.rbFulday.Size = New System.Drawing.Size(104, 24)
        Me.rbFulday.TabIndex = 54
        Me.rbFulday.TabStop = True
        Me.rbFulday.Text = "Full Day"
        Me.rbFulday.UseVisualStyleBackColor = False
        '
        'MnthEndDate
        '
        Me.MnthEndDate.Location = New System.Drawing.Point(450, 41)
        Me.MnthEndDate.MaxSelectionCount = 1
        Me.MnthEndDate.Name = "MnthEndDate"
        Me.MnthEndDate.ShowToday = False
        Me.MnthEndDate.ShowTodayCircle = False
        Me.MnthEndDate.TabIndex = 53
        '
        'MntStrdate
        '
        Me.MntStrdate.BackColor = System.Drawing.Color.Red
        Me.MntStrdate.Location = New System.Drawing.Point(57, 40)
        Me.MntStrdate.MaxSelectionCount = 1
        Me.MntStrdate.Name = "MntStrdate"
        Me.MntStrdate.ShowToday = False
        Me.MntStrdate.ShowTodayCircle = False
        Me.MntStrdate.TabIndex = 52
        Me.MntStrdate.TitleBackColor = System.Drawing.Color.Maroon
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(450, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 27)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "End Holiday Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(450, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 30)
        Me.Label3.TabIndex = 51
        '
        'Student
        '
        Me.Student.BackColor = System.Drawing.Color.Wheat
        Me.Student.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Student.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student.ForeColor = System.Drawing.Color.Maroon
        Me.Student.Location = New System.Drawing.Point(57, 11)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(227, 27)
        Me.Student.TabIndex = 48
        Me.Student.Text = "Start Holiday Date"
        Me.Student.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(57, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(230, 30)
        Me.Label18.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(300, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 100)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        '
        'tdbHolid
        '
        Me.tdbHolid.AllowColMove = False
        Me.tdbHolid.AllowColSelect = False
        Me.tdbHolid.AllowDelete = True
        Me.tdbHolid.AllowFilter = False
        Me.tdbHolid.AllowUpdate = False
        Me.tdbHolid.Caption = "Holidays"
        Me.tdbHolid.CaptionHeight = 25
        Me.tdbHolid.Images.Add(CType(resources.GetObject("tdbHolid.Images"), System.Drawing.Image))
        Me.tdbHolid.Location = New System.Drawing.Point(2, 292)
        Me.tdbHolid.Name = "tdbHolid"
        Me.tdbHolid.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbHolid.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbHolid.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbHolid.PrintInfo.PageSettings = CType(resources.GetObject("tdbHolid.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbHolid.Size = New System.Drawing.Size(755, 181)
        Me.tdbHolid.TabIndex = 22
        Me.tdbHolid.Text = "C1TrueDBGrid1"
        Me.tdbHolid.PropBag = resources.GetString("tdbHolid.PropBag")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(-1, 479)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(456, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "P.S : Select A Row And Press Delete To Remove The Holiday"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(-75, 502)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(909, 4)
        Me.Label8.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(-64, 502)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(882, 72)
        Me.Label10.TabIndex = 61
        '
        'frmVacations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 570)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tdbHolid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVacations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holidays Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tdbHolid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Student As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbHalfDay As System.Windows.Forms.RadioButton
    Friend WithEvents rbFulday As System.Windows.Forms.RadioButton
    Friend WithEvents MnthEndDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents MntStrdate As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents tdbHolid As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnPrvs As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
