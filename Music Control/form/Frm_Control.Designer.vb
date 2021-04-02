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
        Me.Tmr_on_Top = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_minimize = New System.Windows.Forms.Button()
        Me.lbl_Header = New System.Windows.Forms.Label()
        Me.Btn_Volume_Higher = New System.Windows.Forms.Button()
        Me.Btn_Volume_Lower = New System.Windows.Forms.Button()
        Me.Btn_Mute = New System.Windows.Forms.Button()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.Btn_Previous = New System.Windows.Forms.Button()
        Me.btn_Play = New System.Windows.Forms.Button()
        Me.Btn_settings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tmr_on_Top
        '
        Me.Tmr_on_Top.Enabled = True
        Me.Tmr_on_Top.Interval = 5000
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Btn_Close.ForeColor = System.Drawing.Color.White
        Me.Btn_Close.Location = New System.Drawing.Point(307, 5)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Close.TabIndex = 29
        Me.Btn_Close.Text = "X"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Btn_minimize
        '
        Me.Btn_minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Btn_minimize.FlatAppearance.BorderSize = 0
        Me.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Btn_minimize.ForeColor = System.Drawing.Color.White
        Me.Btn_minimize.Location = New System.Drawing.Point(276, 5)
        Me.Btn_minimize.Name = "Btn_minimize"
        Me.Btn_minimize.Size = New System.Drawing.Size(25, 25)
        Me.Btn_minimize.TabIndex = 30
        Me.Btn_minimize.Text = "-"
        Me.Btn_minimize.UseVisualStyleBackColor = False
        '
        'lbl_Header
        '
        Me.lbl_Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.lbl_Header.ForeColor = System.Drawing.Color.White
        Me.lbl_Header.Location = New System.Drawing.Point(115, 97)
        Me.lbl_Header.Name = "lbl_Header"
        Me.lbl_Header.Size = New System.Drawing.Size(95, 25)
        Me.lbl_Header.TabIndex = 31
        Me.lbl_Header.Text = "Settings"
        '
        'Btn_Volume_Higher
        '
        Me.Btn_Volume_Higher.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Volume_Higher.BackgroundImage = CType(resources.GetObject("Btn_Volume_Higher.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Volume_Higher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Volume_Higher.FlatAppearance.BorderSize = 0
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
        Me.Btn_Volume_Lower.BackgroundImage = CType(resources.GetObject("Btn_Volume_Lower.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Volume_Lower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Volume_Lower.FlatAppearance.BorderSize = 0
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
        Me.Btn_Mute.BackgroundImage = CType(resources.GetObject("Btn_Mute.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Mute.FlatAppearance.BorderSize = 0
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
        Me.Btn_Next.BackgroundImage = CType(resources.GetObject("Btn_Next.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Next.FlatAppearance.BorderSize = 0
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
        Me.Btn_Previous.BackgroundImage = CType(resources.GetObject("Btn_Previous.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Previous.FlatAppearance.BorderSize = 0
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
        Me.btn_Play.BackgroundImage = CType(resources.GetObject("btn_Play.BackgroundImage"), System.Drawing.Image)
        Me.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Play.FlatAppearance.BorderSize = 0
        Me.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Play.Location = New System.Drawing.Point(5, 5)
        Me.btn_Play.Name = "btn_Play"
        Me.btn_Play.Size = New System.Drawing.Size(40, 40)
        Me.btn_Play.TabIndex = 0
        Me.btn_Play.UseVisualStyleBackColor = False
        '
        'Btn_settings
        '
        Me.Btn_settings.BackColor = System.Drawing.Color.Transparent
        Me.Btn_settings.BackgroundImage = CType(resources.GetObject("Btn_settings.BackgroundImage"), System.Drawing.Image)
        Me.Btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn_settings.FlatAppearance.BorderSize = 0
        Me.Btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_settings.Location = New System.Drawing.Point(296, 144)
        Me.Btn_settings.Name = "Btn_settings"
        Me.Btn_settings.Size = New System.Drawing.Size(20, 20)
        Me.Btn_settings.TabIndex = 32
        Me.Btn_settings.UseVisualStyleBackColor = False
        '
        'FRM_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(633, 329)
        Me.Controls.Add(Me.Btn_settings)
        Me.Controls.Add(Me.lbl_Header)
        Me.Controls.Add(Me.Btn_minimize)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Volume_Higher)
        Me.Controls.Add(Me.Btn_Volume_Lower)
        Me.Controls.Add(Me.Btn_Mute)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Btn_Previous)
        Me.Controls.Add(Me.btn_Play)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRM_Control"
        Me.Text = "Music Control"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Play As System.Windows.Forms.Button
    Friend WithEvents Btn_Previous As System.Windows.Forms.Button
    Friend WithEvents Btn_Next As System.Windows.Forms.Button
    Friend WithEvents Btn_Mute As System.Windows.Forms.Button
    Friend WithEvents Btn_Volume_Lower As System.Windows.Forms.Button
    Friend WithEvents Btn_Volume_Higher As System.Windows.Forms.Button
    Friend WithEvents Tmr_on_Top As System.Windows.Forms.Timer
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_minimize As Button
    Friend WithEvents lbl_Header As Label
    Friend WithEvents Btn_settings As Button
End Class
