Public Class FRM_Control

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)

    Dim Version = "V 2.0"

    Dim VLC_Running

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Music Control " & Version

        If My.Settings.Frm_Control_Btn_Frm_Size = 0 Then
            My.Settings.Frm_Control_Btn_Frm_Size = 40
        End If

        Resize_form_buttons_Control()

        If My.Settings.Frm_Control_Time_AlwaysOnTop = 0 Then
            My.Settings.Frm_Control_Time_AlwaysOnTop = 5000
        End If

        Timer1.Interval = My.Settings.Frm_Control_Time_AlwaysOnTop

        'get username
        Dim user As String
        user = Get_UserName()

        'controleer of spotify geinstaleerd is.

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

    End Sub

    Private Sub Form1_close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Play.Click

        VLC_Running = Check_If_Running("vlc")

        If VLC_Running Then
            activate_Program("vlc", "{BACKSPACE}")
        End If

        keybd_event(System.Windows.Forms.Keys.MediaPlayPause, 0, 1, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Previous.Click

        VLC_Running = Check_If_Running("vlc")

        If VLC_Running Then
            activate_Program("vlc", "P")
        End If

        keybd_event(System.Windows.Forms.Keys.MediaPreviousTrack, 0, 1, 0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click

        VLC_Running = Check_If_Running("vlc")

        If VLC_Running Then
            activate_Program("vlc", "n")
        End If

        keybd_event(System.Windows.Forms.Keys.MediaNextTrack, 0, 1, 0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Mute.Click
        keybd_event(System.Windows.Forms.Keys.VolumeMute, 0, 1, 0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Volume_Lower.Click
        keybd_event(System.Windows.Forms.Keys.VolumeDown, 0, 1, 0)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn_Volume_Higher.Click
        keybd_event(System.Windows.Forms.Keys.VolumeUp, 0, 1, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Frm_Settings.Show()
    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim MyProcess() As Process = System.Diagnostics.Process.GetProcessesByName("spotify")

        For Each mykill As Process In MyProcess
            mykill.Kill()
        Next
    End Sub



    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'get username
        Dim user As String
        user = Get_UserName()

        'start program
        Call Shell("C:\Users\" & user & "\AppData\Roaming\Spotify\spotify.exe", vbNormalFocus)
    End Sub
End Class
