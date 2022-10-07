

Imports CoreAudio

Module General_Functions

    Public Sub form_at_BottomRight(ByRef FormName)
        Dim working_area As Rectangle =
            SystemInformation.WorkingArea
        Dim x As Integer =
            working_area.Left +
            working_area.Width -
           FormName.Width
        Dim y As Integer =
            working_area.Top +
            working_area.Height -
            FormName.Height
        FormName.Location = New Point(x, y)
    End Sub

    Public Sub form_at_Bottomleft(ByRef FormName)
        Dim working_area As Rectangle =
            SystemInformation.WorkingArea
        Dim x As Integer =
            working_area.Left
        Dim y As Integer =
            working_area.Top +
            working_area.Height -
            FormName.Height
        FormName.Location = New Point(x, y)
    End Sub

    Public Sub form_at_topRight(ByRef FormName)
        Dim working_area As Rectangle =
            SystemInformation.WorkingArea
        Dim x As Integer =
            working_area.Left +
            working_area.Width -
            FormName.Width
        Dim y As Integer =
            working_area.Top
        FormName.Location = New Point(x, y)
    End Sub

    Public Sub form_at_topleft(ByRef FormName)
        Dim working_area As Rectangle =
            SystemInformation.WorkingArea
        Dim x As Integer =
            working_area.Left
        Dim y As Integer =
            working_area.Top
        FormName.Location = New Point(x, y)
    End Sub

    Public Sub form_at_center(ByRef FormName)
        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        r = Screen.PrimaryScreen.WorkingArea
        x = r.Width - FormName.Width
        y = r.Height - FormName.Height

        x = CInt(x / 2)
        y = CInt(y / 2)

        FormName.StartPosition = FormStartPosition.Manual
        FormName.Location = New Point(x, y)
    End Sub

    Public Function Color_darker(ByRef color_input As Color)
        Dim tmp_red
        Dim tmp_green
        Dim tmp_blue
        Dim tmp_color

        tmp_red = color_input.R
        tmp_green = color_input.G
        tmp_blue = color_input.B

        If tmp_red > 20 Then
            tmp_red = tmp_red - 20
        End If

        If tmp_green > 20 Then
            tmp_green = tmp_green - 20
        End If

        If tmp_blue > 20 Then
            tmp_blue = tmp_blue - 20
        End If

        tmp_color = Color.FromArgb(color_input.A, tmp_red, tmp_green, tmp_blue)

        Return tmp_color

    End Function

    Public Sub Resize_form_buttons_Control()
        Dim space_x = 5
        Dim space_y = 5
        Dim button_small = 25

        ''form
        FRM_Control.Height = My.Settings.Frm_Control_Btn_Frm_Size + (2 * button_small) + (4 * space_y)
        FRM_Control.Width = (My.Settings.Frm_Control_Btn_Frm_Size * 6) + space_x + (6 * space_x)

        ''close
        FRM_Control.Btn_Close.Location = New Point((FRM_Control.Width - 30), space_y)

        'minimize
        FRM_Control.Btn_minimize.Location = New Point((FRM_Control.Width - 30 - 30), space_y)

        'header
        FRM_Control.lbl_Header.Location = New Point(space_x, (2 * space_y))

        'settings
        FRM_Control.Btn_settings.Location = New Point((FRM_Control.Width - 30 - 30 - 30), 10)

        'device
        FRM_Control.lbl_Device.Location = New Point(5, (button_small + (2 * space_y)))
        FRM_Control.lbl_Device.Width = FRM_Control.Width - 5

        'play
        FRM_Control.btn_Play.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.btn_Play.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.btn_Play.Location = New Point(space_x, ((2 * button_small) + (2 * space_y)))

        'previous
        FRM_Control.Btn_Previous.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Previous.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Previous.Location = New Point(((2 * space_x) + (1 * My.Settings.Frm_Control_Btn_Frm_Size)), ((2 * button_small) + (2 * space_y)))

        'next
        FRM_Control.Btn_Next.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Next.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Next.Location = New Point(((3 * space_x) + (2 * My.Settings.Frm_Control_Btn_Frm_Size)), ((2 * button_small) + (2 * space_y)))

        'mute
        FRM_Control.Btn_Mute.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Mute.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Mute.Location = New Point(((4 * space_x) + (3 * My.Settings.Frm_Control_Btn_Frm_Size)), ((2 * button_small) + (2 * space_y)))

        'volume lower
        FRM_Control.Btn_Volume_Lower.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Lower.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Lower.Location = New Point(((5 * space_x) + (4 * My.Settings.Frm_Control_Btn_Frm_Size)), ((2 * button_small) + (2 * space_y)))

        'volume higher
        FRM_Control.Btn_Volume_Higher.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Higher.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Higher.Location = New Point(((6 * space_x) + (5 * My.Settings.Frm_Control_Btn_Frm_Size)), ((2 * button_small) + (2 * space_y)))


    End Sub

    Public Function GetActiveAudioDevice() As String
        ''declare variable for audio device
        Dim DevEnum As New MMDeviceEnumerator()
        Dim AudioDevice As MMDevice

        AudioDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)

        Return AudioDevice.DeviceFriendlyName

    End Function


End Module
