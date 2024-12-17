Imports System.Runtime.InteropServices
Imports CoreAudio

Public Class FRM_Control

#Region "public variables"
    ' declare varieble for keyboard media keys
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Dim DevEnum As New MMDeviceEnumerator(Guid.NewGuid())
    Dim AudioDevice As MMDevice

#End Region

#Region "Load"
    Private Sub Frm_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetActiveAudioDevice()
        MutedAudioDevice()
        GetVolumeAudioDevice()
    End Sub
#End Region

#Region "buttons media"
    Private Sub Btn_Play_Click(sender As Object, e As EventArgs) Handles btn_Play.Click
        keybd_event(Keys.MediaPlayPause, 0, 1, 0)
    End Sub

    Private Sub Btn_Previous_Click(sender As Object, e As EventArgs) Handles Btn_Previous.Click
        keybd_event(Keys.MediaPreviousTrack, 0, 1, 0)
    End Sub

    Private Sub Btn_Next_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click
        keybd_event(Keys.MediaNextTrack, 0, 1, 0)
    End Sub

    Private Sub Btn_Mute_Click(sender As Object, e As EventArgs) Handles Btn_Mute.Click
        keybd_event(Keys.VolumeMute, 0, 1, 0)
    End Sub
#End Region

#Region "button top"
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_minimize_Click(sender As Object, e As EventArgs) Handles Btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Timers"
    Private Sub Tmr_on_Top_Tick(sender As Object, e As EventArgs) Handles Tmr_on_Top.Tick
        Me.TopMost = True
        GetActiveAudioDevice()
        GetVolumeAudioDevice()
    End Sub

    Private Sub TmrSlider_Tick(sender As Object, e As EventArgs) Handles TmrSlider.Tick
        MutedAudioDevice()
        SetVolumeAudioDevice()
    End Sub
#End Region

#Region " audio device Functions"
    Public Sub GetActiveAudioDevice()
        ''declare variable for audio device

        AudioDevice = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        lbl_Device.Text = AudioDevice.DeviceFriendlyName

    End Sub
    Public Sub MutedAudioDevice()

        Btn_Mute.UseAccentColor = AudioDevice.AudioEndpointVolume.Mute

    End Sub

    Public Sub GetVolumeAudioDevice()

        Volume_Slider.Value = AudioDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100

    End Sub

    Public Sub SetVolumeAudioDevice()

        If Volume_Slider.Value <> AudioDevice.AudioEndpointVolume.MasterVolumeLevelScalar * 100 Then
            AudioDevice.AudioEndpointVolume.MasterVolumeLevelScalar = Volume_Slider.Value / 100
        End If

    End Sub

#End Region

#Region "move form from header"
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, Header.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
#End Region

End Class
