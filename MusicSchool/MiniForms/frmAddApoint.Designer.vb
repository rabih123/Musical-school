<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddApoint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddApoint))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstartTime = New System.Windows.Forms.MaskedTextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtEndTime = New System.Windows.Forms.MaskedTextBox()
        Me.lblStd = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnRoom = New System.Windows.Forms.Button()
        Me.btnCLOSE = New System.Windows.Forms.Button()
        Me.LblCourse = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Name = "Label2"
        '
        'txtstartTime
        '
        Me.txtstartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtstartTime, "txtstartTime")
        Me.txtstartTime.Name = "txtstartTime"
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderSize = 2
        resources.ApplyResources(Me.BtnOk, "BtnOk")
        Me.BtnOk.ForeColor = System.Drawing.Color.Firebrick
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'TxtEndTime
        '
        Me.TxtEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TxtEndTime, "TxtEndTime")
        Me.TxtEndTime.Name = "TxtEndTime"
        '
        'lblStd
        '
        Me.lblStd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.lblStd, "lblStd")
        Me.lblStd.ForeColor = System.Drawing.Color.Firebrick
        Me.lblStd.Name = "lblStd"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Name = "Label3"
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.Color.White
        Me.btnCourse.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnCourse, "btnCourse")
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'btnRoom
        '
        Me.btnRoom.BackColor = System.Drawing.Color.White
        Me.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.btnRoom, "btnRoom")
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.UseVisualStyleBackColor = False
        '
        'btnCLOSE
        '
        Me.btnCLOSE.BackColor = System.Drawing.Color.Silver
        Me.btnCLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCLOSE.FlatAppearance.BorderSize = 2
        Me.btnCLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnCLOSE, "btnCLOSE")
        Me.btnCLOSE.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.UseVisualStyleBackColor = False
        '
        'LblCourse
        '
        Me.LblCourse.BackColor = System.Drawing.Color.White
        Me.LblCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblCourse, "LblCourse")
        Me.LblCourse.Name = "LblCourse"
        '
        'lblRoom
        '
        Me.lblRoom.BackColor = System.Drawing.Color.White
        Me.lblRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.lblRoom, "lblRoom")
        Me.lblRoom.Name = "lblRoom"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Name = "Label4"
        '
        'frmAddApoint
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCLOSE)
        Me.Controls.Add(Me.btnRoom)
        Me.Controls.Add(Me.btnCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStd)
        Me.Controls.Add(Me.TxtEndTime)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.txtstartTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblCourse)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmAddApoint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstartTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtEndTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblStd As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCourse As System.Windows.Forms.Button
    Friend WithEvents btnRoom As System.Windows.Forms.Button
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents LblCourse As System.Windows.Forms.Label
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
