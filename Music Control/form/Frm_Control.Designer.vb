<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Control
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Control))
        Me.Tmr_on_Top = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_minimize = New System.Windows.Forms.Button()
        Me.lbl_Device = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.Panel()
        Me.btn_Play = New MaterialSkin.Controls.MaterialButton()
        Me.Btn_Previous = New MaterialSkin.Controls.MaterialButton()
        Me.Btn_Next = New MaterialSkin.Controls.MaterialButton()
        Me.Btn_Mute = New MaterialSkin.Controls.MaterialButton()
        Me.Volume_Slider = New MaterialSkin.Controls.MaterialSlider()
        Me.TmrSlider = New System.Windows.Forms.Timer(Me.components)
        Me.Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tmr_on_Top
        '
        Me.Tmr_on_Top.Enabled = True
        Me.Tmr_on_Top.Interval = 2000
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Btn_Close.ForeColor = System.Drawing.Color.Black
        Me.Btn_Close.Location = New System.Drawing.Point(271, 0)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Close.TabIndex = 29
        Me.Btn_Close.Text = "X"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Btn_minimize
        '
        Me.Btn_minimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Btn_minimize.FlatAppearance.BorderSize = 0
        Me.Btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_minimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Btn_minimize.ForeColor = System.Drawing.Color.Black
        Me.Btn_minimize.Location = New System.Drawing.Point(236, 0)
        Me.Btn_minimize.Name = "Btn_minimize"
        Me.Btn_minimize.Size = New System.Drawing.Size(25, 25)
        Me.Btn_minimize.TabIndex = 30
        Me.Btn_minimize.Text = "-"
        Me.Btn_minimize.UseVisualStyleBackColor = False
        '
        'lbl_Device
        '
        Me.lbl_Device.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.lbl_Device.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_Device.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Device.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Device.Location = New System.Drawing.Point(0, 25)
        Me.lbl_Device.Name = "lbl_Device"
        Me.lbl_Device.Size = New System.Drawing.Size(306, 25)
        Me.lbl_Device.TabIndex = 33
        Me.lbl_Device.Text = "............."
        Me.lbl_Device.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Header.Controls.Add(Me.Btn_Close)
        Me.Header.Controls.Add(Me.Btn_minimize)
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(306, 25)
        Me.Header.TabIndex = 34
        '
        'btn_Play
        '
        Me.btn_Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_Play.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_Play.Depth = 0
        Me.btn_Play.DrawShadows = False
        Me.btn_Play.HighEmphasis = True
        Me.btn_Play.Icon = CType(resources.GetObject("btn_Play.Icon"), System.Drawing.Image)
        Me.btn_Play.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_Play.Location = New System.Drawing.Point(10, 55)
        Me.btn_Play.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_Play.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_Play.Name = "btn_Play"
        Me.btn_Play.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_Play.Size = New System.Drawing.Size(64, 36)
        Me.btn_Play.TabIndex = 35
        Me.btn_Play.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Play.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_Play.UseAccentColor = False
        Me.btn_Play.UseVisualStyleBackColor = True
        '
        'Btn_Previous
        '
        Me.Btn_Previous.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Previous.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Btn_Previous.Depth = 0
        Me.Btn_Previous.HighEmphasis = True
        Me.Btn_Previous.Icon = CType(resources.GetObject("Btn_Previous.Icon"), System.Drawing.Image)
        Me.Btn_Previous.Location = New System.Drawing.Point(84, 55)
        Me.Btn_Previous.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Previous.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Previous.Name = "Btn_Previous"
        Me.Btn_Previous.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Btn_Previous.Size = New System.Drawing.Size(64, 36)
        Me.Btn_Previous.TabIndex = 36
        Me.Btn_Previous.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Previous.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Btn_Previous.UseAccentColor = False
        Me.Btn_Previous.UseVisualStyleBackColor = True
        '
        'Btn_Next
        '
        Me.Btn_Next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Next.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Btn_Next.Depth = 0
        Me.Btn_Next.HighEmphasis = True
        Me.Btn_Next.Icon = CType(resources.GetObject("Btn_Next.Icon"), System.Drawing.Image)
        Me.Btn_Next.Location = New System.Drawing.Point(158, 55)
        Me.Btn_Next.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Next.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Btn_Next.Size = New System.Drawing.Size(64, 36)
        Me.Btn_Next.TabIndex = 37
        Me.Btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Next.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Btn_Next.UseAccentColor = False
        Me.Btn_Next.UseVisualStyleBackColor = True
        '
        'Btn_Mute
        '
        Me.Btn_Mute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn_Mute.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Btn_Mute.Depth = 0
        Me.Btn_Mute.HighEmphasis = True
        Me.Btn_Mute.Icon = CType(resources.GetObject("Btn_Mute.Icon"), System.Drawing.Image)
        Me.Btn_Mute.Location = New System.Drawing.Point(232, 55)
        Me.Btn_Mute.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Mute.MouseState = MaterialSkin.MouseState.HOVER
        Me.Btn_Mute.Name = "Btn_Mute"
        Me.Btn_Mute.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Btn_Mute.Size = New System.Drawing.Size(64, 36)
        Me.Btn_Mute.TabIndex = 38
        Me.Btn_Mute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Mute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Btn_Mute.UseAccentColor = False
        Me.Btn_Mute.UseVisualStyleBackColor = True
        '
        'Volume_Slider
        '
        Me.Volume_Slider.Depth = 0
        Me.Volume_Slider.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Volume_Slider.Location = New System.Drawing.Point(12, 96)
        Me.Volume_Slider.MouseState = MaterialSkin.MouseState.HOVER
        Me.Volume_Slider.Name = "Volume_Slider"
        Me.Volume_Slider.Size = New System.Drawing.Size(280, 40)
        Me.Volume_Slider.TabIndex = 39
        Me.Volume_Slider.Text = "Volume"
        '
        'TmrSlider
        '
        Me.TmrSlider.Enabled = True
        Me.TmrSlider.Interval = 250
        '
        'FRM_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(306, 136)
        Me.Controls.Add(Me.Volume_Slider)
        Me.Controls.Add(Me.Btn_Mute)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.Btn_Previous)
        Me.Controls.Add(Me.btn_Play)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.lbl_Device)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRM_Control"
        Me.Text = "Music Control"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.Header.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tmr_on_Top As System.Windows.Forms.Timer
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_minimize As Button
    Friend WithEvents lbl_Device As Label
    Friend WithEvents Header As Panel
    Friend WithEvents btn_Play As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Btn_Previous As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Btn_Next As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Btn_Mute As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Volume_Slider As MaterialSkin.Controls.MaterialSlider
    Friend WithEvents TmrSlider As Timer
End Class
