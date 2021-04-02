<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Control))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_Volume_Higher = New System.Windows.Forms.Button()
        Me.Btn_Volume_Lower = New System.Windows.Forms.Button()
        Me.Btn_Mute = New System.Windows.Forms.Button()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.Btn_Previous = New System.Windows.Forms.Button()
        Me.btn_Play = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(128, 70)
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MinimizeToolStripMenuItem.Text = "minimize"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SettingsToolStripMenuItem.Text = "settings"
        '
        'Btn_Volume_Higher
        '
        Me.Btn_Volume_Higher.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Volume_Higher.BackgroundImage = Global.MusicControl.My.Resources.Resources.media_volume_3
        Me.Btn_Volume_Higher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Volume_Higher.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Btn_Volume_Higher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Volume_Higher.Location = New System.Drawing.Point(230, 5)
        Me.Btn_Volume_Higher.Name = "Btn_Volume_Higher"
        Me.Btn_Volume_Higher.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Volume_Higher.TabIndex = 5
        Me.Btn_Volume_Higher.UseVisualStyleBackColor = False
        '
        'Btn_Volume_Lower
        '
        Me.Btn_Volume_Lower.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Volume_Lower.BackgroundImage = Global.MusicControl.My.Resources.Resources.media_volume_1
        Me.Btn_Volume_Lower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Volume_Lower.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Btn_Volume_Lower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Volume_Lower.Location = New System.Drawing.Point(185, 5)
        Me.Btn_Volume_Lower.Name = "Btn_Volume_Lower"
        Me.Btn_Volume_Lower.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Volume_Lower.TabIndex = 4
        Me.Btn_Volume_Lower.UseVisualStyleBackColor = False
        '
        'Btn_Mute
        '
        Me.Btn_Mute.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Mute.BackgroundImage = Global.MusicControl.My.Resources.Resources.media_volume_0
        Me.Btn_Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Mute.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Btn_Mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Mute.Location = New System.Drawing.Point(140, 5)
        Me.Btn_Mute.Name = "Btn_Mute"
        Me.Btn_Mute.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Mute.TabIndex = 3
        Me.Btn_Mute.UseVisualStyleBackColor = False
        '
        'Btn_Next
        '
        Me.Btn_Next.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Next.BackgroundImage = Global.MusicControl.My.Resources.Resources.media_next
        Me.Btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Next.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Next.Location = New System.Drawing.Point(95, 5)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Next.TabIndex = 2
        Me.Btn_Next.UseVisualStyleBackColor = False
        '
        'Btn_Previous
        '
        Me.Btn_Previous.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Previous.BackgroundImage = Global.MusicControl.My.Resources.Resources.media_previous
        Me.Btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Previous.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Btn_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Previous.Location = New System.Drawing.Point(50, 5)
        Me.Btn_Previous.Name = "Btn_Previous"
        Me.Btn_Previous.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Previous.TabIndex = 1
        Me.Btn_Previous.UseVisualStyleBackColor = False
        '
        'btn_Play
        '
        Me.btn_Play.BackColor = System.Drawing.Color.Transparent
        Me.btn_Play.BackgroundImage = Global.MusicControl.My.Resources.Resources.media_play_pause_resume
        Me.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Play.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Play.Location = New System.Drawing.Point(5, 5)
        Me.btn_Play.Name = "btn_Play"
        Me.btn_Play.Size = New System.Drawing.Size(40, 40)
        Me.btn_Play.TabIndex = 0
        Me.btn_Play.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'FRM_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 53)
        Me.Controls.Add(Me.Btn_Volume_Higher)
        Me.Controls.Add(Me.Btn_Volume_Lower)
        Me.Controls.Add(Me.Btn_Mute)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Btn_Previous)
        Me.Controls.Add(Me.btn_Play)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRM_Control"
        Me.Text = "Music Control"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Play As System.Windows.Forms.Button
    Friend WithEvents Btn_Previous As System.Windows.Forms.Button
    Friend WithEvents Btn_Next As System.Windows.Forms.Button
    Friend WithEvents Btn_Mute As System.Windows.Forms.Button
    Friend WithEvents Btn_Volume_Lower As System.Windows.Forms.Button
    Friend WithEvents Btn_Volume_Higher As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
