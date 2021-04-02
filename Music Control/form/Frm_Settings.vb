Public Class Frm_Settings

    Private Sub Settings_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        'enable always on top'frm_control
        FRM_Control.Timer1.Enabled = True
        'save settings
        My.Settings.Save()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'enable always on top'frm_control
        FRM_Control.Timer1.Enabled = False

        'set text for always on top setting
        Tbx_AlwaysOnTop.Text = My.Settings.Frm_Control_Time_AlwaysOnTop / 1000

        'set text for size setting
        Tbx_Btn_Size.Text = My.Settings.Frm_Control_Btn_Frm_Size

        'set text for position setting
        CB_Position.Text = My.Settings.Frm_Control_Position

        'set color for brackground selection
        Btn_BackgroundColor.BackColor = My.Settings.Frm_Backcolor

    End Sub

    Private Sub Button_ok_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
#Region "variables"
        'declare variables
        Dim tmp_string As String
        Dim tmp_integer As Integer
#End Region

#Region "settings"
        'set backgroundcolor in settings
        My.Settings.Frm_Backcolor = Btn_BackgroundColor.BackColor

#End Region

#Region "always on top"
        'convert always on top to int
        tmp_string = Tbx_AlwaysOnTop.Text
        tmp_integer = CInt(Int(tmp_string))
        My.Settings.Frm_Control_Time_AlwaysOnTop = tmp_integer * 1000
        FRM_Control.Timer1.Interval = My.Settings.Frm_Control_Time_AlwaysOnTop
#End Region

#Region "button size"
        tmp_string = Tbx_Btn_Size.Text
        tmp_integer = CInt(Int(tmp_string))
        My.Settings.Frm_Control_Btn_Frm_Size = tmp_integer
        Resize_form_buttons_Control()
#End Region

#Region "form control position"
        My.Settings.Frm_Control_Position = CB_Position.Text
        Select Case My.Settings.Frm_Control_Position
            Case "TopLeft"
                form_at_topleft(FRM_Control)
            Case "TopRight"
                form_at_topRight(FRM_Control)
            Case "BottomLeft"
                form_at_Bottomleft(FRM_Control)
            Case "BottomRight"
                form_at_BottomRight(FRM_Control)
            Case "Center"
                form_at_center(FRM_Control)
        End Select
#End Region

#Region "form controlbackcolor"
        FRM_Control.BackColor = My.Settings.Frm_Backcolor
#End Region

        Me.Close()

    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Btn_BackgroundColor_Click(sender As Object, e As EventArgs) Handles Btn_BackgroundColor.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = My.Settings.Frm_Backcolor

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Btn_BackgroundColor.BackColor = cDialog.Color ' update with user selected color.
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        'close form
        Me.Close()
    End Sub

    Private Sub Tbx_Btn_Size_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbx_Btn_Size.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Tbx_AlwaysOnTop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbx_AlwaysOnTop.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class