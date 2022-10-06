Imports CoreAudioApi
Imports Microsoft.Win32

Public Class FRM_Control

    ' declare varieble for keyboard media keys
    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    'declare version
    Dim Version = "V2.0"

    Private Sub frm_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "default settings"
        'default settings volume
        If My.Settings.Frm_Control_Btn_Frm_Size = 0 Then
            My.Settings.Frm_Control_Btn_Frm_Size = 40
        End If
        'default settings always on top time
        If My.Settings.Frm_Control_Time_AlwaysOnTop = 0 Then
            My.Settings.Frm_Control_Time_AlwaysOnTop = 5000
        End If
#End Region

#Region "timer value set"
        Tmr_on_Top.Interval = My.Settings.Frm_Control_Time_AlwaysOnTop
#End Region

        Resize_form_buttons_Control()

#Region "form position"
        Select Case My.Settings.Frm_Control_Position
            Case "TopLeft"
                form_at_topleft(Me)
            Case "TopRight"
                form_at_topRight(Me)
            Case "BottomLeft"
                form_at_Bottomleft(Me)
            Case "BottomRight"
                form_at_BottomRight(Me)
            Case "Center"
                form_at_center(Me)
        End Select
#End Region

        lbl_Header.Text = "Music"

    End Sub

    Private Sub Frm_control_close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub btn_Play_Click(sender As Object, e As EventArgs) Handles btn_Play.Click
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

    Private Sub Btn_Volume_Lower_Click(sender As Object, e As EventArgs) Handles Btn_Volume_Lower.Click
        keybd_event(Keys.VolumeDown, 0, 1, 0)
    End Sub

    Private Sub Btn_Volume_Higher_Click(sender As Object, e As EventArgs) Handles Btn_Volume_Higher.Click
        keybd_event(Keys.VolumeUp, 0, 1, 0)
    End Sub

    Private Sub Tmr_on_Top_Tick(sender As Object, e As EventArgs) Handles Tmr_on_Top.Tick
        Me.TopMost = True
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Settings.Show()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_minimize_Click(sender As Object, e As EventArgs) Handles Btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_settings_Click(sender As Object, e As EventArgs) Handles Btn_settings.Click
        Frm_Settings.Show()
    End Sub

#Region "move form"
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = IntPtr.op_Explicit(HTCLIENT) Then m.Result = IntPtr.op_Explicit(HTCAPTION)
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub TimerDevice_Tick(sender As Object, e As EventArgs) Handles TimerDevice.Tick


        Dim DevEnum As New MMDeviceEnumerator()
        Dim AudioDevice As MMDevice

        Dim rk1 As RegistryKey
        Dim rk2 As RegistryKey
        Dim Friendlyname
        Dim Desc

        Dim ID
        Dim RegKeyLoc

        AudioDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)

        ID = AudioDevice.ID
        ID = ID.remove(0, 17)

        RegKeyLoc = "SOFTWARE\Microsoft\Windows\CurrentVersion\MMDevices\Audio\Render\" & ID & "\Properties"

        rk1 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
        rk2 = rk1.OpenSubKey(RegKeyLoc)
        Desc = rk2.GetValue("{b3f8fa53-0004-438e-9003-51a46e139bfc},6").ToString
        Friendlyname = rk2.GetValue("{a45c254e-df1c-4efd-8020-67d146a850e0},2").ToString



        lbl_Device.Text = Friendlyname & " (" & Desc & ")"

    End Sub




#End Region
End Class
