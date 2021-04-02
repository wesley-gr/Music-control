Module General_Functions
    Public Function Get_UserName() As String
        If TypeOf My.User.CurrentPrincipal Is
          Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function

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

    Public Function Check_If_Running(ByRef Program)

        Dim tmp

        tmp = False

        For Each clsProcess As Process In Process.GetProcesses()

            If clsProcess.ProcessName.StartsWith(Program) Then
                tmp = True
            End If
        Next

        Return tmp

    End Function

    Public Sub activate_Program(ByRef Program, ByRef key)

        Dim tmp

        tmp = False

        For Each clsProcess As Process In Process.GetProcesses()

            If clsProcess.ProcessName.StartsWith(Program) Then
                AppActivate(clsProcess.Id)

                SendKeys.SendWait(key)
            End If
        Next

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

End Module
