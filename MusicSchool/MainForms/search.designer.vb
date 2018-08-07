<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tdbsearch = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(1, 1)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(559, 289)
        Me.dgv.TabIndex = 0
        '
        'tdbsearch
        '
        Me.tdbsearch.AllowColMove = False
        Me.tdbsearch.AllowUpdate = False
        Me.tdbsearch.CaptionHeight = 17
        Me.tdbsearch.FilterBar = True
        Me.tdbsearch.Images.Add(CType(resources.GetObject("tdbsearch.Images"), System.Drawing.Image))
        Me.tdbsearch.Location = New System.Drawing.Point(1, 1)
        Me.tdbsearch.Name = "tdbsearch"
        Me.tdbsearch.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbsearch.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbsearch.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbsearch.PrintInfo.PageSettings = CType(resources.GetObject("tdbsearch.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbsearch.RowHeight = 17
        Me.tdbsearch.Size = New System.Drawing.Size(863, 421)
        Me.tdbsearch.TabIndex = 1
        Me.tdbsearch.PropBag = resources.GetString("tdbsearch.PropBag")
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(868, 426)
        Me.Controls.Add(Me.tdbsearch)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "search"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents tdbsearch As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
