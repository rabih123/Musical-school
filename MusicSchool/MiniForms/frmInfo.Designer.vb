<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.btnCLOSE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStd = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblStartTime = New System.Windows.Forms.Label()
        Me.LblEndTime = New System.Windows.Forms.Label()
        Me.LblCourse = New System.Windows.Forms.Label()
        Me.LblRoom = New System.Windows.Forms.Label()
        Me.LblStudent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCLOSE
        '
        Me.btnCLOSE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCLOSE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCLOSE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCLOSE.FlatAppearance.BorderSize = 2
        Me.btnCLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCLOSE.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCLOSE.Image = CType(resources.GetObject("btnCLOSE.Image"), System.Drawing.Image)
        Me.btnCLOSE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCLOSE.Location = New System.Drawing.Point(1, 3)
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.Size = New System.Drawing.Size(38, 41)
        Me.btnCLOSE.TabIndex = 48
        Me.btnCLOSE.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(30, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 27)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "End Time"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(30, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 27)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Start Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(30, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 27)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Course"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStd
        '
        Me.lblStd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblStd.ForeColor = System.Drawing.Color.Firebrick
        Me.lblStd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStd.Location = New System.Drawing.Point(30, 175)
        Me.lblStd.Name = "lblStd"
        Me.lblStd.Size = New System.Drawing.Size(118, 27)
        Me.lblStd.TabIndex = 51
        Me.lblStd.Text = "Room"
        Me.lblStd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(30, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 27)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Student"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStartTime
        '
        Me.LblStartTime.BackColor = System.Drawing.Color.White
        Me.LblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStartTime.ForeColor = System.Drawing.Color.Firebrick
        Me.LblStartTime.Location = New System.Drawing.Point(166, 52)
        Me.LblStartTime.Name = "LblStartTime"
        Me.LblStartTime.Size = New System.Drawing.Size(190, 27)
        Me.LblStartTime.TabIndex = 54
        Me.LblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEndTime
        '
        Me.LblEndTime.BackColor = System.Drawing.Color.White
        Me.LblEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndTime.ForeColor = System.Drawing.Color.Firebrick
        Me.LblEndTime.Location = New System.Drawing.Point(166, 93)
        Me.LblEndTime.Name = "LblEndTime"
        Me.LblEndTime.Size = New System.Drawing.Size(190, 27)
        Me.LblEndTime.TabIndex = 55
        Me.LblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCourse
        '
        Me.LblCourse.BackColor = System.Drawing.Color.White
        Me.LblCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCourse.ForeColor = System.Drawing.Color.Firebrick
        Me.LblCourse.Location = New System.Drawing.Point(166, 134)
        Me.LblCourse.Name = "LblCourse"
        Me.LblCourse.Size = New System.Drawing.Size(190, 27)
        Me.LblCourse.TabIndex = 56
        Me.LblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRoom
        '
        Me.LblRoom.BackColor = System.Drawing.Color.White
        Me.LblRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRoom.ForeColor = System.Drawing.Color.Firebrick
        Me.LblRoom.Location = New System.Drawing.Point(166, 175)
        Me.LblRoom.Name = "LblRoom"
        Me.LblRoom.Size = New System.Drawing.Size(190, 27)
        Me.LblRoom.TabIndex = 57
        Me.LblRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblStudent
        '
        Me.LblStudent.BackColor = System.Drawing.Color.White
        Me.LblStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStudent.ForeColor = System.Drawing.Color.Firebrick
        Me.LblStudent.Location = New System.Drawing.Point(166, 216)
        Me.LblStudent.Name = "LblStudent"
        Me.LblStudent.Size = New System.Drawing.Size(190, 27)
        Me.LblStudent.TabIndex = 58
        Me.LblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 266)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblStudent)
        Me.Controls.Add(Me.LblRoom)
        Me.Controls.Add(Me.LblCourse)
        Me.Controls.Add(Me.LblEndTime)
        Me.Controls.Add(Me.LblStartTime)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCLOSE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblStd As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblStartTime As System.Windows.Forms.Label
    Friend WithEvents LblEndTime As System.Windows.Forms.Label
    Friend WithEvents LblCourse As System.Windows.Forms.Label
    Friend WithEvents LblRoom As System.Windows.Forms.Label
    Friend WithEvents LblStudent As System.Windows.Forms.Label
End Class
