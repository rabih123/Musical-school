<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchIncProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchIncProf))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkStdPay = New System.Windows.Forms.CheckBox()
        Me.ChkPay = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CbMonthTo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMonthFrom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.LightGray
        Me.btnModify.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnModify, "btnModify")
        Me.btnModify.Image = Global.MusicSchool.My.Resources.Resources.edit_notes
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Tag = "button"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.LightGray
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnShow, "btnShow")
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Tag = "button"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightGray
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnClose, "btnClose")
        Me.btnClose.Image = Global.MusicSchool.My.Resources.Resources.Log_Out_icon
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Tag = "button"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightGray
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Image = Global.MusicSchool.My.Resources.Resources.Sign_Stop
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Tag = "button"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.ChkStdPay)
        Me.GroupBox1.Controls.Add(Me.ChkPay)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbYear)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.CbMonthTo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbMonthFrom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ChkStdPay
        '
        resources.ApplyResources(Me.ChkStdPay, "ChkStdPay")
        Me.ChkStdPay.Checked = True
        Me.ChkStdPay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkStdPay.Name = "ChkStdPay"
        Me.ChkStdPay.UseVisualStyleBackColor = True
        '
        'ChkPay
        '
        resources.ApplyResources(Me.ChkPay, "ChkPay")
        Me.ChkPay.Checked = True
        Me.ChkPay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPay.Name = "ChkPay"
        Me.ChkPay.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Wheat
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Name = "Label7"
        '
        'cbYear
        '
        Me.cbYear.BackColor = System.Drawing.Color.White
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbYear, "cbYear")
        Me.cbYear.ForeColor = System.Drawing.Color.Firebrick
        Me.cbYear.Items.AddRange(New Object() {resources.GetString("cbYear.Items"), resources.GetString("cbYear.Items1"), resources.GetString("cbYear.Items2"), resources.GetString("cbYear.Items3"), resources.GetString("cbYear.Items4"), resources.GetString("cbYear.Items5"), resources.GetString("cbYear.Items6"), resources.GetString("cbYear.Items7"), resources.GetString("cbYear.Items8"), resources.GetString("cbYear.Items9"), resources.GetString("cbYear.Items10"), resources.GetString("cbYear.Items11"), resources.GetString("cbYear.Items12"), resources.GetString("cbYear.Items13"), resources.GetString("cbYear.Items14"), resources.GetString("cbYear.Items15"), resources.GetString("cbYear.Items16")})
        Me.cbYear.Name = "cbYear"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'CbMonthTo
        '
        Me.CbMonthTo.BackColor = System.Drawing.Color.White
        Me.CbMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CbMonthTo, "CbMonthTo")
        Me.CbMonthTo.ForeColor = System.Drawing.Color.Firebrick
        Me.CbMonthTo.Items.AddRange(New Object() {resources.GetString("CbMonthTo.Items"), resources.GetString("CbMonthTo.Items1"), resources.GetString("CbMonthTo.Items2"), resources.GetString("CbMonthTo.Items3"), resources.GetString("CbMonthTo.Items4"), resources.GetString("CbMonthTo.Items5"), resources.GetString("CbMonthTo.Items6"), resources.GetString("CbMonthTo.Items7"), resources.GetString("CbMonthTo.Items8"), resources.GetString("CbMonthTo.Items9"), resources.GetString("CbMonthTo.Items10"), resources.GetString("CbMonthTo.Items11")})
        Me.CbMonthTo.Name = "CbMonthTo"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Wheat
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'cbMonthFrom
        '
        Me.cbMonthFrom.BackColor = System.Drawing.Color.White
        Me.cbMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbMonthFrom, "cbMonthFrom")
        Me.cbMonthFrom.ForeColor = System.Drawing.Color.Firebrick
        Me.cbMonthFrom.Items.AddRange(New Object() {resources.GetString("cbMonthFrom.Items"), resources.GetString("cbMonthFrom.Items1"), resources.GetString("cbMonthFrom.Items2"), resources.GetString("cbMonthFrom.Items3"), resources.GetString("cbMonthFrom.Items4"), resources.GetString("cbMonthFrom.Items5"), resources.GetString("cbMonthFrom.Items6"), resources.GetString("cbMonthFrom.Items7"), resources.GetString("cbMonthFrom.Items8"), resources.GetString("cbMonthFrom.Items9"), resources.GetString("cbMonthFrom.Items10"), resources.GetString("cbMonthFrom.Items11")})
        Me.cbMonthFrom.Name = "cbMonthFrom"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmSchIncProf
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSchIncProf"
        Me.ShowInTaskbar = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CbMonthTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbMonthFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChkStdPay As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPay As System.Windows.Forms.CheckBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
