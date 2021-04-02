<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Ok = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Tbx_Btn_Size = New System.Windows.Forms.TextBox()
        Me.CB_Position = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Tbx_AlwaysOnTop = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Always on top time"
        '
        'Btn_Ok
        '
        Me.Btn_Ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Btn_Ok.FlatAppearance.BorderSize = 0
        Me.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Btn_Ok.ForeColor = System.Drawing.Color.White
        Me.Btn_Ok.Location = New System.Drawing.Point(15, 190)
        Me.Btn_Ok.Name = "Btn_Ok"
        Me.Btn_Ok.Size = New System.Drawing.Size(265, 25)
        Me.Btn_Ok.TabIndex = 2
        Me.Btn_Ok.Text = "OK"
        Me.Btn_Ok.UseVisualStyleBackColor = False
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.BackColor = System.Drawing.Color.Maroon
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Btn_Cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_Cancel.Location = New System.Drawing.Point(15, 225)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(265, 25)
        Me.Btn_Cancel.TabIndex = 3
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = False
        '
        'Tbx_Btn_Size
        '
        Me.Tbx_Btn_Size.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Tbx_Btn_Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tbx_Btn_Size.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Tbx_Btn_Size.ForeColor = System.Drawing.Color.White
        Me.Tbx_Btn_Size.Location = New System.Drawing.Point(180, 80)
        Me.Tbx_Btn_Size.Name = "Tbx_Btn_Size"
        Me.Tbx_Btn_Size.Size = New System.Drawing.Size(100, 25)
        Me.Tbx_Btn_Size.TabIndex = 5
        Me.Tbx_Btn_Size.Text = "0"
        Me.Tbx_Btn_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CB_Position
        '
        Me.CB_Position.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CB_Position.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CB_Position.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.CB_Position.ForeColor = System.Drawing.Color.White
        Me.CB_Position.FormattingEnabled = True
        Me.CB_Position.Items.AddRange(New Object() {"TopLeft", "TopRight", "BottomLeft", "BottomRight", "Center"})
        Me.CB_Position.Location = New System.Drawing.Point(15, 145)
        Me.CB_Position.Name = "CB_Position"
        Me.CB_Position.Size = New System.Drawing.Size(100, 26)
        Me.CB_Position.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(180, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(136, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Button Size"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(15, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 18)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Position"
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Maroon
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Btn_Close.ForeColor = System.Drawing.Color.White
        Me.Btn_Close.Location = New System.Drawing.Point(255, 15)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Close.TabIndex = 28
        Me.Btn_Close.Text = "X"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Tbx_AlwaysOnTop
        '
        Me.Tbx_AlwaysOnTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Tbx_AlwaysOnTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tbx_AlwaysOnTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!)
        Me.Tbx_AlwaysOnTop.ForeColor = System.Drawing.Color.White
        Me.Tbx_AlwaysOnTop.Location = New System.Drawing.Point(15, 80)
        Me.Tbx_AlwaysOnTop.Name = "Tbx_AlwaysOnTop"
        Me.Tbx_AlwaysOnTop.Size = New System.Drawing.Size(100, 25)
        Me.Tbx_AlwaysOnTop.TabIndex = 29
        Me.Tbx_AlwaysOnTop.Text = "0"
        Me.Tbx_AlwaysOnTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Settings"
        '
        'Frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 265)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Tbx_AlwaysOnTop)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CB_Position)
        Me.Controls.Add(Me.Tbx_Btn_Size)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Ok)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Ok As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Tbx_Btn_Size As System.Windows.Forms.TextBox
    Friend WithEvents CB_Position As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Tbx_AlwaysOnTop As TextBox
    Friend WithEvents Label2 As Label
End Class
