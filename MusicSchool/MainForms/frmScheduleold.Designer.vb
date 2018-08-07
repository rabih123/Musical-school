<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleold
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleold))
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbProff = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkMonday = New System.Windows.Forms.CheckBox()
        Me.Chktue = New System.Windows.Forms.CheckBox()
        Me.Chkwed = New System.Windows.Forms.CheckBox()
        Me.chkThur = New System.Windows.Forms.CheckBox()
        Me.chkFrid = New System.Windows.Forms.CheckBox()
        Me.chkSat = New System.Windows.Forms.CheckBox()
        Me.txtMond1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtMond2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTue1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtwed1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtthur1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtFrid1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtSat1 = New System.Windows.Forms.MaskedTextBox()
        Me.Txttue2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtwed2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtThur2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtFrid2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtSat2 = New System.Windows.Forms.MaskedTextBox()
        Me.pnlMond = New System.Windows.Forms.Panel()
        Me.pnlTue = New System.Windows.Forms.Panel()
        Me.pnlWed = New System.Windows.Forms.Panel()
        Me.pnlThur = New System.Windows.Forms.Panel()
        Me.pnlFrid = New System.Windows.Forms.Panel()
        Me.pnlSat = New System.Windows.Forms.Panel()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        '' Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        ' Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(161, 304)
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
        Me.btnSave.Location = New System.Drawing.Point(414, 304)
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
        Me.btnClose.Location = New System.Drawing.Point(541, 304)
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
        Me.btnCancel.Location = New System.Drawing.Point(297, 304)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 55)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(346, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 26)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Professors"
        '
        'CbProff
        '
        Me.CbProff.BackColor = System.Drawing.Color.White
        Me.CbProff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProff.ForeColor = System.Drawing.Color.Maroon
        Me.CbProff.FormattingEnabled = True
        Me.CbProff.Location = New System.Drawing.Point(254, 36)
        Me.CbProff.Margin = New System.Windows.Forms.Padding(15, 3, 3, 3)
        Me.CbProff.Name = "CbProff"
        Me.CbProff.Size = New System.Drawing.Size(304, 24)
        Me.CbProff.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label1.Location = New System.Drawing.Point(62, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Monday"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(183, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Tuesday"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(306, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Wednesday"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(433, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Thursday"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(559, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Friday"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label6.Location = New System.Drawing.Point(685, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Saturday"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkMonday
        '
        Me.ChkMonday.AutoSize = True
        Me.ChkMonday.Location = New System.Drawing.Point(105, 123)
        Me.ChkMonday.Name = "ChkMonday"
        Me.ChkMonday.Size = New System.Drawing.Size(15, 14)
        Me.ChkMonday.TabIndex = 30
        Me.ChkMonday.UseVisualStyleBackColor = True
        '
        'Chktue
        '
        Me.Chktue.AutoSize = True
        Me.Chktue.Location = New System.Drawing.Point(227, 123)
        Me.Chktue.Name = "Chktue"
        Me.Chktue.Size = New System.Drawing.Size(15, 14)
        Me.Chktue.TabIndex = 31
        Me.Chktue.UseVisualStyleBackColor = True
        '
        'Chkwed
        '
        Me.Chkwed.AutoSize = True
        Me.Chkwed.Location = New System.Drawing.Point(347, 123)
        Me.Chkwed.Name = "Chkwed"
        Me.Chkwed.Size = New System.Drawing.Size(15, 14)
        Me.Chkwed.TabIndex = 32
        Me.Chkwed.UseVisualStyleBackColor = True
        '
        'chkThur
        '
        Me.chkThur.AutoSize = True
        Me.chkThur.Location = New System.Drawing.Point(476, 123)
        Me.chkThur.Name = "chkThur"
        Me.chkThur.Size = New System.Drawing.Size(15, 14)
        Me.chkThur.TabIndex = 33
        Me.chkThur.UseVisualStyleBackColor = True
        '
        'chkFrid
        '
        Me.chkFrid.AutoSize = True
        Me.chkFrid.Location = New System.Drawing.Point(604, 123)
        Me.chkFrid.Name = "chkFrid"
        Me.chkFrid.Size = New System.Drawing.Size(15, 14)
        Me.chkFrid.TabIndex = 34
        Me.chkFrid.UseVisualStyleBackColor = True
        '
        'chkSat
        '
        Me.chkSat.AutoSize = True
        Me.chkSat.Location = New System.Drawing.Point(727, 123)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(15, 14)
        Me.chkSat.TabIndex = 35
        Me.chkSat.UseVisualStyleBackColor = True
        '
        'txtMond1
        '
        Me.txtMond1.Location = New System.Drawing.Point(62, 143)
        Me.txtMond1.Mask = "90:00 aa"
        Me.txtMond1.Name = "txtMond1"
        Me.txtMond1.Size = New System.Drawing.Size(100, 20)
        Me.txtMond1.TabIndex = 36
        Me.txtMond1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMond2
        '
        Me.txtMond2.Location = New System.Drawing.Point(62, 185)
        Me.txtMond2.Mask = "90:00 aa"
        Me.txtMond2.Name = "txtMond2"
        Me.txtMond2.Size = New System.Drawing.Size(100, 20)
        Me.txtMond2.TabIndex = 37
        Me.txtMond2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(6, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "From"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(6, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "To"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTue1
        '
        Me.TxtTue1.Location = New System.Drawing.Point(183, 143)
        Me.TxtTue1.Mask = "90:00 aa"
        Me.TxtTue1.Name = "TxtTue1"
        Me.TxtTue1.Size = New System.Drawing.Size(100, 20)
        Me.TxtTue1.TabIndex = 40
        Me.TxtTue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtwed1
        '
        Me.txtwed1.Location = New System.Drawing.Point(306, 143)
        Me.txtwed1.Mask = "90:00 aa"
        Me.txtwed1.Name = "txtwed1"
        Me.txtwed1.Size = New System.Drawing.Size(100, 20)
        Me.txtwed1.TabIndex = 41
        Me.txtwed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtthur1
        '
        Me.txtthur1.Location = New System.Drawing.Point(433, 143)
        Me.txtthur1.Mask = "90:00 aa"
        Me.txtthur1.Name = "txtthur1"
        Me.txtthur1.Size = New System.Drawing.Size(100, 20)
        Me.txtthur1.TabIndex = 42
        Me.txtthur1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFrid1
        '
        Me.txtFrid1.Location = New System.Drawing.Point(559, 143)
        Me.txtFrid1.Mask = "90:00 aa"
        Me.txtFrid1.Name = "txtFrid1"
        Me.txtFrid1.Size = New System.Drawing.Size(100, 20)
        Me.txtFrid1.TabIndex = 43
        Me.txtFrid1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSat1
        '
        Me.txtSat1.Location = New System.Drawing.Point(685, 143)
        Me.txtSat1.Mask = "90:00 aa"
        Me.txtSat1.Name = "txtSat1"
        Me.txtSat1.Size = New System.Drawing.Size(100, 20)
        Me.txtSat1.TabIndex = 44
        Me.txtSat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txttue2
        '
        Me.Txttue2.Location = New System.Drawing.Point(183, 185)
        Me.Txttue2.Mask = "90:00 aa"
        Me.Txttue2.Name = "Txttue2"
        Me.Txttue2.Size = New System.Drawing.Size(100, 20)
        Me.Txttue2.TabIndex = 45
        Me.Txttue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtwed2
        '
        Me.txtwed2.Location = New System.Drawing.Point(306, 185)
        Me.txtwed2.Mask = "90:00 aa"
        Me.txtwed2.Name = "txtwed2"
        Me.txtwed2.Size = New System.Drawing.Size(100, 20)
        Me.txtwed2.TabIndex = 46
        Me.txtwed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtThur2
        '
        Me.txtThur2.Location = New System.Drawing.Point(433, 185)
        Me.txtThur2.Mask = "90:00 aa"
        Me.txtThur2.Name = "txtThur2"
        Me.txtThur2.Size = New System.Drawing.Size(100, 20)
        Me.txtThur2.TabIndex = 47
        Me.txtThur2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFrid2
        '
        Me.txtFrid2.Location = New System.Drawing.Point(559, 185)
        Me.txtFrid2.Mask = "90:00 aa"
        Me.txtFrid2.Name = "txtFrid2"
        Me.txtFrid2.Size = New System.Drawing.Size(100, 20)
        Me.txtFrid2.TabIndex = 48
        Me.txtFrid2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSat2
        '
        Me.txtSat2.Location = New System.Drawing.Point(685, 185)
        Me.txtSat2.Mask = "90:00 aa"
        Me.txtSat2.Name = "txtSat2"
        Me.txtSat2.Size = New System.Drawing.Size(100, 20)
        Me.txtSat2.TabIndex = 49
        Me.txtSat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlMond
        '
        Me.pnlMond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMond.Location = New System.Drawing.Point(57, 93)
        Me.pnlMond.Name = "pnlMond"
        Me.pnlMond.Size = New System.Drawing.Size(110, 121)
        Me.pnlMond.TabIndex = 50
        '
        'pnlTue
        '
        Me.pnlTue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTue.Location = New System.Drawing.Point(178, 93)
        Me.pnlTue.Name = "pnlTue"
        Me.pnlTue.Size = New System.Drawing.Size(110, 121)
        Me.pnlTue.TabIndex = 51
        '
        'pnlWed
        '
        Me.pnlWed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlWed.Location = New System.Drawing.Point(299, 93)
        Me.pnlWed.Name = "pnlWed"
        Me.pnlWed.Size = New System.Drawing.Size(110, 121)
        Me.pnlWed.TabIndex = 51
        '
        'pnlThur
        '
        Me.pnlThur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlThur.Location = New System.Drawing.Point(426, 93)
        Me.pnlThur.Name = "pnlThur"
        Me.pnlThur.Size = New System.Drawing.Size(110, 121)
        Me.pnlThur.TabIndex = 51
        '
        'pnlFrid
        '
        Me.pnlFrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFrid.Location = New System.Drawing.Point(552, 93)
        Me.pnlFrid.Name = "pnlFrid"
        Me.pnlFrid.Size = New System.Drawing.Size(110, 121)
        Me.pnlFrid.TabIndex = 51
        '
        'pnlSat
        '
        Me.pnlSat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSat.Location = New System.Drawing.Point(680, 93)
        Me.pnlSat.Name = "pnlSat"
        Me.pnlSat.Size = New System.Drawing.Size(110, 121)
        Me.pnlSat.TabIndex = 51
        '
        'TxtNotes
        '
        Me.TxtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNotes.Location = New System.Drawing.Point(192, 236)
        Me.TxtNotes.MaxLength = 500
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(420, 53)
        Me.TxtNotes.TabIndex = 52
        '
        'ShapeContainer1
        '
        'Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        'Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer1.Name = "ShapeContainer1"
        'Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        'Me.ShapeContainer1.Size = New System.Drawing.Size(813, 370)
        'Me.ShapeContainer1.TabIndex = 53
        'Me.ShapeContainer1.TabStop = False
        ''
        ''LineShape1
        ''
        'Me.LineShape1.Name = "LineShape1"
        'Me.LineShape1.X1 = 96
        'Me.LineShape1.X2 = 744
        'Me.LineShape1.Y1 = 227
        'Me.LineShape1.Y2 = 227
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(136, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 26)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Notes"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 370)
        Me.Controls.Add(Me.TxtNotes)
        Me.Controls.Add(Me.txtSat2)
        Me.Controls.Add(Me.txtFrid2)
        Me.Controls.Add(Me.txtThur2)
        Me.Controls.Add(Me.txtwed2)
        Me.Controls.Add(Me.Txttue2)
        Me.Controls.Add(Me.txtSat1)
        Me.Controls.Add(Me.txtFrid1)
        Me.Controls.Add(Me.txtthur1)
        Me.Controls.Add(Me.txtwed1)
        Me.Controls.Add(Me.TxtTue1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMond2)
        Me.Controls.Add(Me.txtMond1)
        Me.Controls.Add(Me.chkSat)
        Me.Controls.Add(Me.chkFrid)
        Me.Controls.Add(Me.chkThur)
        Me.Controls.Add(Me.Chkwed)
        Me.Controls.Add(Me.Chktue)
        Me.Controls.Add(Me.ChkMonday)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbProff)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlMond)
        Me.Controls.Add(Me.pnlSat)
        Me.Controls.Add(Me.pnlFrid)
        Me.Controls.Add(Me.pnlThur)
        Me.Controls.Add(Me.pnlWed)
        Me.Controls.Add(Me.pnlTue)
        Me.Controls.Add(Me.Label10)
        '   Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSchedule"
        Me.Text = "Schedule"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbProff As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChkMonday As System.Windows.Forms.CheckBox
    Friend WithEvents Chktue As System.Windows.Forms.CheckBox
    Friend WithEvents Chkwed As System.Windows.Forms.CheckBox
    Friend WithEvents chkThur As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrid As System.Windows.Forms.CheckBox
    Friend WithEvents chkSat As System.Windows.Forms.CheckBox
    Friend WithEvents txtMond1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtMond2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTue1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtwed1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtthur1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFrid1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSat1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Txttue2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtwed2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtThur2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFrid2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSat2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pnlMond As System.Windows.Forms.Panel
    Friend WithEvents pnlTue As System.Windows.Forms.Panel
    Friend WithEvents pnlWed As System.Windows.Forms.Panel
    Friend WithEvents pnlThur As System.Windows.Forms.Panel
    Friend WithEvents pnlFrid As System.Windows.Forms.Panel
    Friend WithEvents pnlSat As System.Windows.Forms.Panel
    Friend WithEvents TxtNotes As System.Windows.Forms.TextBox
    '' Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    ' Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
