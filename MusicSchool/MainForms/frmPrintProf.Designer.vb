<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintProf))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbSum = New System.Windows.Forms.RadioButton()
        Me.rbDet = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.rbNotPaid = New System.Windows.Forms.RadioButton()
        Me.RbPaid = New System.Windows.Forms.RadioButton()
        Me.RbAll = New System.Windows.Forms.RadioButton()
        Me.CbMonthTo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMonthFrom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbYear)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.rbNotPaid)
        Me.GroupBox1.Controls.Add(Me.RbPaid)
        Me.GroupBox1.Controls.Add(Me.RbAll)
        Me.GroupBox1.Controls.Add(Me.CbMonthTo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbMonthFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtration"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox2.Controls.Add(Me.rbSum)
        Me.GroupBox2.Controls.Add(Me.rbDet)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(72, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(420, 19)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Type"
        Me.GroupBox2.UseCompatibleTextRendering = True
        Me.GroupBox2.Visible = False
        '
        'rbSum
        '
        Me.rbSum.AutoSize = True
        Me.rbSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSum.ForeColor = System.Drawing.Color.DarkRed
        Me.rbSum.Location = New System.Drawing.Point(229, 20)
        Me.rbSum.Name = "rbSum"
        Me.rbSum.Size = New System.Drawing.Size(90, 20)
        Me.rbSum.TabIndex = 69
        Me.rbSum.Text = "Summary"
        Me.rbSum.UseVisualStyleBackColor = True
        '
        'rbDet
        '
        Me.rbDet.AutoSize = True
        Me.rbDet.Checked = True
        Me.rbDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDet.ForeColor = System.Drawing.Color.DarkRed
        Me.rbDet.Location = New System.Drawing.Point(69, 20)
        Me.rbDet.Name = "rbDet"
        Me.rbDet.Size = New System.Drawing.Size(85, 20)
        Me.rbDet.TabIndex = 69
        Me.rbDet.TabStop = True
        Me.rbDet.Text = "Detailed"
        Me.rbDet.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Wheat
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(144, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 27)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Year"
        '
        'cbYear
        '
        Me.cbYear.BackColor = System.Drawing.Color.White
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbYear.ForeColor = System.Drawing.Color.Firebrick
        Me.cbYear.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cbYear.Location = New System.Drawing.Point(267, 62)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(132, 24)
        Me.cbYear.TabIndex = 64
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(267, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 23)
        Me.Label16.TabIndex = 66
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(144, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 30)
        Me.Label19.TabIndex = 67
        '
        'rbNotPaid
        '
        Me.rbNotPaid.AutoSize = True
        Me.rbNotPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotPaid.ForeColor = System.Drawing.Color.DarkRed
        Me.rbNotPaid.Location = New System.Drawing.Point(342, 120)
        Me.rbNotPaid.Name = "rbNotPaid"
        Me.rbNotPaid.Size = New System.Drawing.Size(200, 20)
        Me.rbNotPaid.TabIndex = 63
        Me.rbNotPaid.Text = "Only Not Paid Professors"
        Me.rbNotPaid.UseVisualStyleBackColor = True
        '
        'RbPaid
        '
        Me.RbPaid.AutoSize = True
        Me.RbPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPaid.ForeColor = System.Drawing.Color.DarkRed
        Me.RbPaid.Location = New System.Drawing.Point(167, 120)
        Me.RbPaid.Name = "RbPaid"
        Me.RbPaid.Size = New System.Drawing.Size(172, 20)
        Me.RbPaid.TabIndex = 62
        Me.RbPaid.Text = "Only Paid Professors"
        Me.RbPaid.UseVisualStyleBackColor = True
        '
        'RbAll
        '
        Me.RbAll.AutoSize = True
        Me.RbAll.Checked = True
        Me.RbAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAll.ForeColor = System.Drawing.Color.DarkRed
        Me.RbAll.Location = New System.Drawing.Point(43, 120)
        Me.RbAll.Name = "RbAll"
        Me.RbAll.Size = New System.Drawing.Size(123, 20)
        Me.RbAll.TabIndex = 61
        Me.RbAll.TabStop = True
        Me.RbAll.Text = "All Professors"
        Me.RbAll.UseVisualStyleBackColor = True
        '
        'CbMonthTo
        '
        Me.CbMonthTo.BackColor = System.Drawing.Color.White
        Me.CbMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMonthTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbMonthTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMonthTo.ForeColor = System.Drawing.Color.Firebrick
        Me.CbMonthTo.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.CbMonthTo.Location = New System.Drawing.Point(414, 20)
        Me.CbMonthTo.Name = "CbMonthTo"
        Me.CbMonthTo.Size = New System.Drawing.Size(132, 24)
        Me.CbMonthTo.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Wheat
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(291, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 27)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "To Month"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(291, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 30)
        Me.Label5.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(414, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 23)
        Me.Label6.TabIndex = 60
        '
        'cbMonthFrom
        '
        Me.cbMonthFrom.BackColor = System.Drawing.Color.White
        Me.cbMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonthFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbMonthFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMonthFrom.ForeColor = System.Drawing.Color.Firebrick
        Me.cbMonthFrom.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbMonthFrom.Location = New System.Drawing.Point(144, 20)
        Me.cbMonthFrom.Name = "cbMonthFrom"
        Me.cbMonthFrom.Size = New System.Drawing.Size(132, 24)
        Me.cbMonthFrom.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 27)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "From Month"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 30)
        Me.Label2.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(143, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 23)
        Me.Label3.TabIndex = 56
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.Location = New System.Drawing.Point(12, 211)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(110, 55)
        Me.btnModify.TabIndex = 27
        Me.btnModify.Tag = "button"
        Me.btnModify.Text = "    Proceed   - F4"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.LightGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Image = CType(resources.GetObject("btnShow.Image"), System.Drawing.Image)
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(300, 211)
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
        Me.btnClose.Location = New System.Drawing.Point(452, 211)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 55)
        Me.btnClose.TabIndex = 26
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
        Me.btnCancel.Location = New System.Drawing.Point(152, 211)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 55)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Tag = "button"
        Me.btnCancel.Text = "      Cancel    -F8"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(-159, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(909, 4)
        Me.Label8.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(-143, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(724, 72)
        Me.Label9.TabIndex = 59
        '
        'frmPrintProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 274)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintProf"
        Me.Text = "Professors report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNotPaid As System.Windows.Forms.RadioButton
    Friend WithEvents RbPaid As System.Windows.Forms.RadioButton
    Friend WithEvents RbAll As System.Windows.Forms.RadioButton
    Friend WithEvents CbMonthTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMonthFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSum As System.Windows.Forms.RadioButton
    Friend WithEvents rbDet As System.Windows.Forms.RadioButton
End Class
