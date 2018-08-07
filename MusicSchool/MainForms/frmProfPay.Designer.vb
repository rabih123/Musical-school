<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfPay))
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Student = New System.Windows.Forms.Label()
        Me.cbProff = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanlHide = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblPayd = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tdbSess = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbSess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(174, 430)
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
        Me.btnSave.Location = New System.Drawing.Point(462, 430)
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
        Me.btnClose.Location = New System.Drawing.Point(614, 430)
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
        Me.btnCancel.Location = New System.Drawing.Point(314, 430)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.cbMonth)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnshow)
        Me.GroupBox2.Controls.Add(Me.cbYear)
        Me.GroupBox2.Controls.Add(Me.Student)
        Me.GroupBox2.Controls.Add(Me.cbProff)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(903, 115)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtration "
        '
        'cbMonth
        '
        Me.cbMonth.BackColor = System.Drawing.Color.White
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonth.ForeColor = System.Drawing.Color.Firebrick
        Me.cbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonth.Location = New System.Drawing.Point(414, 72)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(132, 24)
        Me.cbMonth.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(291, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 27)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Month"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(291, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 30)
        Me.Label2.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Wheat
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(8, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 27)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Year"
        '
        'btnshow
        '
        Me.btnshow.BackColor = System.Drawing.Color.Firebrick
        Me.btnshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.ForeColor = System.Drawing.Color.White
        Me.btnshow.Location = New System.Drawing.Point(651, 64)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(129, 41)
        Me.btnshow.TabIndex = 44
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = False
        '
        'cbYear
        '
        Me.cbYear.BackColor = System.Drawing.Color.White
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbYear.ForeColor = System.Drawing.Color.Firebrick
        Me.cbYear.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cbYear.Location = New System.Drawing.Point(131, 76)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(132, 23)
        Me.cbYear.TabIndex = 40
        '
        'Student
        '
        Me.Student.BackColor = System.Drawing.Color.Wheat
        Me.Student.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Student.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student.ForeColor = System.Drawing.Color.Maroon
        Me.Student.Location = New System.Drawing.Point(8, 17)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(117, 27)
        Me.Student.TabIndex = 39
        Me.Student.Text = "Professor"
        '
        'cbProff
        '
        Me.cbProff.BackColor = System.Drawing.Color.White
        Me.cbProff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProff.ForeColor = System.Drawing.Color.Maroon
        Me.cbProff.FormattingEnabled = True
        Me.cbProff.Location = New System.Drawing.Point(131, 20)
        Me.cbProff.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.cbProff.Name = "cbProff"
        Me.cbProff.Size = New System.Drawing.Size(282, 24)
        Me.cbProff.TabIndex = 38
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(131, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 23)
        Me.Label16.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DimGray
        Me.Label18.Location = New System.Drawing.Point(8, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 30)
        Me.Label18.TabIndex = 47
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(8, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 30)
        Me.Label19.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(414, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 52
        '
        'PanlHide
        '
        Me.PanlHide.Location = New System.Drawing.Point(1, 147)
        Me.PanlHide.Name = "PanlHide"
        Me.PanlHide.Size = New System.Drawing.Size(905, 271)
        Me.PanlHide.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Firebrick
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label5.Location = New System.Drawing.Point(483, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 31)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Amount To Paid"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Snow
        Me.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAmount.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Firebrick
        Me.lblAmount.Location = New System.Drawing.Point(483, 374)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(188, 31)
        Me.lblAmount.TabIndex = 44
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayd
        '
        Me.lblPayd.BackColor = System.Drawing.Color.Firebrick
        Me.lblPayd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPayd.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayd.ForeColor = System.Drawing.Color.LemonChiffon
        Me.lblPayd.Location = New System.Drawing.Point(328, 343)
        Me.lblPayd.Name = "lblPayd"
        Me.lblPayd.Size = New System.Drawing.Size(93, 46)
        Me.lblPayd.TabIndex = 45
        Me.lblPayd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Location = New System.Drawing.Point(477, 330)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Snow
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Firebrick
        Me.Label8.Location = New System.Drawing.Point(251, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 31)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Paid"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(-2, 419)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(909, 4)
        Me.Label9.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(-3, 424)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(915, 76)
        Me.Label11.TabIndex = 74
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(-3, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(909, 4)
        Me.Label12.TabIndex = 75
        '
        'tdbSess
        '
        Me.tdbSess.AllowColMove = False
        Me.tdbSess.AllowColSelect = False
        Me.tdbSess.AllowFilter = False
        Me.tdbSess.AllowRowSelect = False
        Me.tdbSess.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbSess.AllowSort = False
        Me.tdbSess.AllowUpdate = False
        Me.tdbSess.Caption = " Actual Info"
        Me.tdbSess.CaptionHeight = 32
        Me.tdbSess.ColumnFooters = True
        Me.tdbSess.Images.Add(CType(resources.GetObject("tdbSess.Images"), System.Drawing.Image))
        Me.tdbSess.Location = New System.Drawing.Point(0, 116)
        Me.tdbSess.Name = "tdbSess"
        Me.tdbSess.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbSess.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbSess.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbSess.PrintInfo.PageSettings = CType(resources.GetObject("tdbSess.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbSess.RecordSelectors = False
        Me.tdbSess.RowHeight = 30
        Me.tdbSess.Size = New System.Drawing.Size(907, 208)
        Me.tdbSess.TabIndex = 76
        Me.tdbSess.PropBag = resources.GetString("tdbSess.PropBag")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(244, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(448, 95)
        Me.Label4.TabIndex = 77
        '
        'frmProfPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 491)
        Me.Controls.Add(Me.tdbSess)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPayd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PanlHide)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Professors Payment"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbSess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Student As System.Windows.Forms.Label
    Friend WithEvents cbProff As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblPayd As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanlHide As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tdbSess As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
