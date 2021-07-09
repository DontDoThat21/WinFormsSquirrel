<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SquirrelTestingGrounds
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
        Me.txtLatestVersion = New System.Windows.Forms.TextBox()
        Me.lblLatestVersion = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblExecLoc = New System.Windows.Forms.Label()
        Me.txtExecLoc = New System.Windows.Forms.TextBox()
        Me.txtCurrentVersion = New System.Windows.Forms.TextBox()
        Me.lblCurrentVersion = New System.Windows.Forms.Label()
        Me.timerCheckForUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLatestVersion
        '
        Me.txtLatestVersion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLatestVersion.Enabled = False
        Me.txtLatestVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtLatestVersion.Location = New System.Drawing.Point(169, 173)
        Me.txtLatestVersion.Name = "txtLatestVersion"
        Me.txtLatestVersion.ReadOnly = True
        Me.txtLatestVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLatestVersion.Size = New System.Drawing.Size(98, 24)
        Me.txtLatestVersion.TabIndex = 0
        Me.txtLatestVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLatestVersion
        '
        Me.lblLatestVersion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLatestVersion.AutoSize = True
        Me.lblLatestVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLatestVersion.Location = New System.Drawing.Point(167, 147)
        Me.lblLatestVersion.Name = "lblLatestVersion"
        Me.lblLatestVersion.Size = New System.Drawing.Size(103, 17)
        Me.lblLatestVersion.TabIndex = 1
        Me.lblLatestVersion.Text = "Latest Version:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.btnUpdate.Location = New System.Drawing.Point(170, 230)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(98, 78)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "CHECK FOR UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblExecLoc)
        Me.Panel1.Controls.Add(Me.txtExecLoc)
        Me.Panel1.Controls.Add(Me.txtCurrentVersion)
        Me.Panel1.Controls.Add(Me.lblCurrentVersion)
        Me.Panel1.Controls.Add(Me.lblLatestVersion)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.txtLatestVersion)
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 438)
        Me.Panel1.TabIndex = 3
        '
        'lblExecLoc
        '
        Me.lblExecLoc.AutoSize = True
        Me.lblExecLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblExecLoc.Location = New System.Drawing.Point(3, 368)
        Me.lblExecLoc.Name = "lblExecLoc"
        Me.lblExecLoc.Size = New System.Drawing.Size(195, 17)
        Me.lblExecLoc.TabIndex = 6
        Me.lblExecLoc.Text = "Executing Assembly Location:"
        '
        'txtExecLoc
        '
        Me.txtExecLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtExecLoc.Location = New System.Drawing.Point(3, 399)
        Me.txtExecLoc.Name = "txtExecLoc"
        Me.txtExecLoc.Size = New System.Drawing.Size(446, 26)
        Me.txtExecLoc.TabIndex = 5
        '
        'txtCurrentVersion
        '
        Me.txtCurrentVersion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCurrentVersion.Enabled = False
        Me.txtCurrentVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtCurrentVersion.Location = New System.Drawing.Point(170, 109)
        Me.txtCurrentVersion.Name = "txtCurrentVersion"
        Me.txtCurrentVersion.ReadOnly = True
        Me.txtCurrentVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCurrentVersion.Size = New System.Drawing.Size(98, 24)
        Me.txtCurrentVersion.TabIndex = 4
        Me.txtCurrentVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrentVersion
        '
        Me.lblCurrentVersion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentVersion.AutoSize = True
        Me.lblCurrentVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCurrentVersion.Location = New System.Drawing.Point(166, 83)
        Me.lblCurrentVersion.Name = "lblCurrentVersion"
        Me.lblCurrentVersion.Size = New System.Drawing.Size(91, 17)
        Me.lblCurrentVersion.TabIndex = 3
        Me.lblCurrentVersion.Text = "This Version:"
        '
        'timerCheckForUpdate
        '
        Me.timerCheckForUpdate.Interval = 60000
        '
        'SquirrelTestingGrounds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!)
        Me.MaximumSize = New System.Drawing.Size(506, 509)
        Me.MinimumSize = New System.Drawing.Size(506, 509)
        Me.Name = "SquirrelTestingGrounds"
        Me.Text = "Squirrel Testing Grounds"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtLatestVersion As TextBox
    Friend WithEvents lblLatestVersion As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCurrentVersion As Label
    Friend WithEvents txtCurrentVersion As TextBox
    Friend WithEvents lblExecLoc As Label
    Friend WithEvents txtExecLoc As TextBox
    Friend WithEvents timerCheckForUpdate As Timer
End Class
