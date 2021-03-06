﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedules
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
        Dim PrintStyle1 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle2 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle3 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle4 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle5 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedules))
        Me.Schedule = New C1.Win.C1Schedule.C1Schedule()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CntMnuNewSess = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntViewInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnProf = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblStdName = New System.Windows.Forms.Label()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.labelss = New System.Windows.Forms.Label()
        CType(Me.Schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Schedule.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Schedule
        '
        '
        '
        '
        Me.Schedule.CalendarInfo.CultureInfo = New System.Globalization.CultureInfo("en-US")
        Me.Schedule.CalendarInfo.DateFormatString = "M/d/yyyy"
        Me.Schedule.CalendarInfo.EndDayTime = System.TimeSpan.Parse("21:00:00")
        Me.Schedule.CalendarInfo.FirstDate = New Date(2014, 12, 1, 0, 0, 0, 0)
        Me.Schedule.CalendarInfo.Holidays.Add(New Date(CType(0, Long)))
        Me.Schedule.CalendarInfo.Holidays.Add(New Date(2014, 12, 24, 0, 0, 0, 0))
        Me.Schedule.CalendarInfo.LastDate = New Date(2014, 12, 6, 0, 0, 0, 0)
        Me.Schedule.CalendarInfo.StartDayTime = System.TimeSpan.Parse("08:00:00")
        Me.Schedule.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00")
        Me.Schedule.CalendarInfo.WeekStart = System.DayOfWeek.Monday
        Me.Schedule.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday, System.DayOfWeek.Saturday})
        Me.Schedule.ContextMenuStrip = Me.ContextMenuStrip1
        '
        '
        '
        Me.Schedule.Dock = System.Windows.Forms.DockStyle.Top
        Me.Schedule.EditOptions = CType((((C1.Win.C1Schedule.EditOptions.AllowDrag Or C1.Win.C1Schedule.EditOptions.AllowAppointmentEdit) _
            Or C1.Win.C1Schedule.EditOptions.AllowAppointmentCreate) _
            Or C1.Win.C1Schedule.EditOptions.AllowAppointmentDelete), C1.Win.C1Schedule.EditOptions)
        Me.Schedule.GroupPageSize = 2
        Me.Schedule.LargeButtons = True
        Me.Schedule.Location = New System.Drawing.Point(0, 0)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.PrintInfo.IsPrintingEnabled = False
        PrintStyle1.Description = "Daily Style"
        PrintStyle1.PreviewImage = CType(resources.GetObject("PrintStyle1.PreviewImage"), System.Drawing.Image)
        PrintStyle1.StyleName = "Daily"
        PrintStyle1.StyleSource = "day.c1d"
        PrintStyle2.Description = "Weekly Style"
        PrintStyle2.PreviewImage = CType(resources.GetObject("PrintStyle2.PreviewImage"), System.Drawing.Image)
        PrintStyle2.StyleName = "Week"
        PrintStyle2.StyleSource = "week.c1d"
        PrintStyle3.Description = "Monthly Style"
        PrintStyle3.PreviewImage = CType(resources.GetObject("PrintStyle3.PreviewImage"), System.Drawing.Image)
        PrintStyle3.StyleName = "Month"
        PrintStyle3.StyleSource = "month.c1d"
        PrintStyle4.Description = "Details Style"
        PrintStyle4.PreviewImage = CType(resources.GetObject("PrintStyle4.PreviewImage"), System.Drawing.Image)
        PrintStyle4.StyleName = "Details"
        PrintStyle4.StyleSource = "details.c1d"
        PrintStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment
        PrintStyle5.Description = "Memo Style"
        PrintStyle5.PreviewImage = CType(resources.GetObject("PrintStyle5.PreviewImage"), System.Drawing.Image)
        PrintStyle5.StyleName = "Memo"
        PrintStyle5.StyleSource = "memo.c1d"
        Me.Schedule.PrintInfo.PrintStyles.AddRange(New C1.C1Schedule.Printing.PrintStyle() {PrintStyle1, PrintStyle2, PrintStyle3, PrintStyle4, PrintStyle5})
        '
        '
        '
        Me.Schedule.Settings.SetReminder = False
        Me.Schedule.ShowAllDayArea = False
        Me.Schedule.ShowAppointmentToolTip = False
        Me.Schedule.ShowReminderForm = False
        Me.Schedule.ShowTitle = False
        Me.Schedule.ShowWorkTimeOnly = True
        Me.Schedule.Size = New System.Drawing.Size(1282, 493)
        Me.Schedule.TabIndex = 5
        '
        '
        '
        Me.Schedule.Theme.XmlDefinition = resources.GetString("resource.XmlDefinition")
        Me.Schedule.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView
        Me.Schedule.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Custom
        Me.Schedule.WeekTabFormat = C1.Win.C1Schedule.WeekTabFormat.[Short]
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntMnuNewSess, Me.CntViewInfo})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(166, 48)
        '
        'CntMnuNewSess
        '
        Me.CntMnuNewSess.Image = CType(resources.GetObject("CntMnuNewSess.Image"), System.Drawing.Image)
        Me.CntMnuNewSess.Name = "CntMnuNewSess"
        Me.CntMnuNewSess.Size = New System.Drawing.Size(165, 22)
        Me.CntMnuNewSess.Text = "Add New Session"
        '
        'CntViewInfo
        '
        Me.CntViewInfo.Image = CType(resources.GetObject("CntViewInfo.Image"), System.Drawing.Image)
        Me.CntViewInfo.Name = "CntViewInfo"
        Me.CntViewInfo.Size = New System.Drawing.Size(165, 22)
        Me.CntViewInfo.Text = "Info"
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Btnsave.FlatAppearance.BorderSize = 2
        Me.Btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Maroon
        Me.Btnsave.Image = Global.MusicSchool.My.Resources.Resources.Save
        Me.Btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsave.Location = New System.Drawing.Point(594, 523)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(107, 50)
        Me.Btnsave.TabIndex = 6
        Me.Btnsave.Text = "    Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(126, 499)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(30, 23)
        Me.btnMax.TabIndex = 7
        Me.btnMax.Text = "+"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.Location = New System.Drawing.Point(90, 499)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(30, 23)
        Me.BtnMin.TabIndex = 8
        Me.BtnMin.Text = "-"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cornsilk
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 499)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Zoom"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnPrint.FlatAppearance.BorderSize = 2
        Me.BtnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(481, 523)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(107, 50)
        Me.BtnPrint.TabIndex = 10
        Me.BtnPrint.Text = "    Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.Firebrick
        Me.LblName.Location = New System.Drawing.Point(1000, 531)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(285, 48)
        Me.LblName.TabIndex = 12
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(992, 500)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 87)
        Me.Label2.TabIndex = 13
        '
        'BtnProf
        '
        Me.BtnProf.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnProf.Image = Global.MusicSchool.My.Resources.Resources.Button_Add2
        Me.BtnProf.Location = New System.Drawing.Point(953, 500)
        Me.BtnProf.Name = "BtnProf"
        Me.BtnProf.Size = New System.Drawing.Size(40, 35)
        Me.BtnProf.TabIndex = 14
        Me.BtnProf.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(859, 536)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Choose Another Professor"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Firebrick
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(6, 524)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 18)
        Me.Label4.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 525)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Reserved Session"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(6, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 18)
        Me.Label6.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 548)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Available Session"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Firebrick
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1070, 500)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 30)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Professor"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblStdName
        '
        Me.LblStdName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblStdName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblStdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStdName.ForeColor = System.Drawing.Color.Firebrick
        Me.LblStdName.Location = New System.Drawing.Point(416, 520)
        Me.LblStdName.Name = "LblStdName"
        Me.LblStdName.Size = New System.Drawing.Size(347, 53)
        Me.LblStdName.TabIndex = 23
        Me.LblStdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblStdName.Visible = False
        '
        'Btnclose
        '
        Me.Btnclose.Location = New System.Drawing.Point(832, 564)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(24, 23)
        Me.Btnclose.TabIndex = 24
        Me.Btnclose.Text = "Button1"
        Me.Btnclose.UseVisualStyleBackColor = True
        Me.Btnclose.Visible = False
        '
        'LblCount
        '
        Me.LblCount.BackColor = System.Drawing.Color.Cornsilk
        Me.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCount.ForeColor = System.Drawing.Color.Firebrick
        Me.LblCount.Location = New System.Drawing.Point(162, 546)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(120, 28)
        Me.LblCount.TabIndex = 26
        Me.LblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblCount.Visible = False
        '
        'labelss
        '
        Me.labelss.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.labelss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelss.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelss.ForeColor = System.Drawing.Color.Firebrick
        Me.labelss.Location = New System.Drawing.Point(162, 514)
        Me.labelss.Name = "labelss"
        Me.labelss.Size = New System.Drawing.Size(120, 32)
        Me.labelss.TabIndex = 27
        Me.labelss.Text = "Sessions Count"
        Me.labelss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.labelss.Visible = False
        '
        'frmSchedules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(1282, 593)
        Me.Controls.Add(Me.labelss)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.LblStdName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnProf)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Schedule)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSchedules"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Schedule.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Schedule As C1.Win.C1Schedule.C1Schedule
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents btnMax As System.Windows.Forms.Button
    Friend WithEvents BtnMin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CntMnuNewSess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnProf As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CntViewInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblStdName As System.Windows.Forms.Label
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents LblCount As System.Windows.Forms.Label
    Friend WithEvents labelss As System.Windows.Forms.Label
End Class
