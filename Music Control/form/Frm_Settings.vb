Public Class Frm_Settings

    Private Sub Settings_Closing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        FRM_Control.Timer1.Enabled = True
        My.Settings.Save()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FRM_Control.Timer1.Enabled = False
        Tbx_AlwaysOnTop.Text = My.Settings.Frm_Control_Time_AlwaysOnTop / 1000
        Tbx_Btn_Size.Text = My.Settings.Frm_Control_Btn_Frm_Size
        Cbx_StartWithWindows.Checked = My.Settings.app_Start_With_Windows
        Cbx_TransparentBackground.Checked = My.Settings.Frm_Control_Tranparent_Background
        Me.BackColor = My.Settings.Frm_All_Backcolor
        Btn_Ok.BackColor = My.Settings.Frm_All_Backcolor
        Btn_Cancel.BackColor = My.Settings.Frm_All_Backcolor
        Btn_BackgroundColor.BackColor = My.Settings.Frm_All_Backcolor
        CB_Position.Text = My.Settings.Frm_Control_Position
        Cbx_BackgroundSameAsWindosColor.Checked = My.Settings.Frm_Windows_As_Background

        Tbx_AlwaysOnTop.BackColor = Me.BackColor
        Tbx_Btn_Size.BackColor = Me.BackColor
        Cbx_StartWithWindows.BackColor = Me.BackColor
        Cbx_TransparentBackground.BackColor = Me.BackColor
        Cbx_BackgroundSameAsWindosColor.BackColor = Me.BackColor
        CB_Position.BackColor = Me.BackColor

        Btn_Ok.BackColor = Color_darker(Me.BackColor)
        Btn_Cancel.BackColor = Color_darker(Me.BackColor)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Ok.Click
        FRM_Control.Timer1.Enabled = True

        My.Settings.Frm_All_Backcolor = Btn_BackgroundColor.BackColor

        Dim temp_string As String
        Dim temp_integer As Integer

        temp_string = Tbx_AlwaysOnTop.Text
        temp_integer = CInt(Int(temp_string))

        My.Settings.Frm_Control_Time_AlwaysOnTop = temp_integer * 1000

        temp_string = Tbx_Btn_Size.Text
        temp_integer = CInt(Int(temp_string))

        My.Settings.Frm_Control_Btn_Frm_Size = temp_integer

        Resize_form_buttons_Control()

        FRM_Control.Timer1.Interval = My.Settings.Frm_Control_Time_AlwaysOnTop

        If Cbx_BackgroundSameAsWindosColor.Checked Then
            My.Settings.Frm_All_Backcolor = SystemColors.Window
        End If

        My.Settings.app_Start_With_Windows = Cbx_StartWithWindows.Checked
        My.Settings.Frm_Control_Tranparent_Background = Cbx_TransparentBackground.Checked

        ' The following code is a rendition of one provided by
        ' Firestarter_75, so he gets the credit here:

        Dim applicationName As String = Application.ProductName
        Dim applicationPath As String = Application.ExecutablePath

        If Cbx_StartWithWindows.Checked Then
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue(applicationName, """" & applicationPath & """")
            regKey.Close()
        Else
            Dim regKey As Microsoft.Win32.RegistryKey
            regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.DeleteValue(applicationName, False)
            regKey.Close()

        End If



        If Cbx_TransparentBackground.Checked Then
            FRM_Control.TransparencyKey = BackColor
            TransparencyKey = BackColor

            FRM_Control.btn_Play.FlatAppearance.BorderSize = 1
            FRM_Control.Btn_Mute.FlatAppearance.BorderSize = 1
            FRM_Control.Btn_Next.FlatAppearance.BorderSize = 1
            FRM_Control.Btn_Previous.FlatAppearance.BorderSize = 1
            FRM_Control.Btn_Volume_Higher.FlatAppearance.BorderSize = 1
            FRM_Control.Btn_Volume_Lower.FlatAppearance.BorderSize = 1
        Else
            FRM_Control.BackColor = My.Settings.Frm_All_Backcolor
            FRM_Control.btn_Play.FlatAppearance.BorderSize = 0
            FRM_Control.Btn_Mute.FlatAppearance.BorderSize = 0
            FRM_Control.Btn_Next.FlatAppearance.BorderSize = 0
            FRM_Control.Btn_Previous.FlatAppearance.BorderSize = 0
            FRM_Control.Btn_Volume_Higher.FlatAppearance.BorderSize = 0
            FRM_Control.Btn_Volume_Lower.FlatAppearance.BorderSize = 0

            Dim tmp_color
            tmp_color = Color_darker(My.Settings.Frm_All_Backcolor)
            FRM_Control.btn_Play.BackColor = tmp_color
            FRM_Control.Btn_Mute.BackColor = tmp_color
            FRM_Control.Btn_Next.BackColor = tmp_color
            FRM_Control.btn_Play.BackColor = tmp_color
            FRM_Control.Btn_Previous.BackColor = tmp_color
            FRM_Control.Btn_Volume_Higher.BackColor = tmp_color
            FRM_Control.Btn_Volume_Lower.BackColor = tmp_color

        End If

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



        My.Settings.Frm_Windows_As_Background = Cbx_BackgroundSameAsWindosColor.Checked

        Btn_Ok.BackColor = Color_darker(Me.BackColor)

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        FRM_Control.Timer1.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_BackgroundColor.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = My.Settings.Frm_All_Backcolor

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Btn_BackgroundColor.BackColor = cDialog.Color ' update with user selected color.
        End If
    End Sub
End Class