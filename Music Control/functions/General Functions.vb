Imports System.IO
Imports System.Net.NetworkInformation

Module General_Functions

    Dim Function_Version = "V.0.11"

    Public Sub File_Excists_CREATE(ByRef name, ByRef path)
        Dim csv
        Dim tmp
        csv = path & "\" & name

        tmp = File.Exists(csv)
        If (tmp = False) Then

            File.Create(csv).Dispose()

        End If

    End Sub

    Public Sub File_Delete(ByRef name, ByRef path)
        Dim csv
        Dim tmp
        csv = path & "\" & name

        tmp = File.Exists(csv)
        If (tmp = True) Then

            File.Delete(csv)

        End If

    End Sub

    Public Function Get_Projectpath()
        Dim path

        path = System.AppDomain.CurrentDomain.BaseDirectory
        Return path

    End Function

    Public Sub Fill_Combo_From_CSV(ByRef path, ByRef filename, ByRef combo)

        Dim line
        Dim csv

        csv = path & "\" & filename

        Dim cvsfile As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(csv)

        While Not cvsfile.EndOfStream

            line = cvsfile.ReadLine()
            combo.Items.Add(line)
        End While

        cvsfile.Close()
    End Sub

    Public Function Get_Day_Today()

        Select Case (Now).DayOfWeek
            Case "1"
                Return "Monday"
            Case "2"
                Return "Tuesday"
            Case "3"
                Return "Wednesday"
            Case "4"
                Return "Thursday"
            Case "5"
                Return "Fryday"
            Case "6"
                Return "Saterday"
            Case "7"
                Return "Sunday"

            Case Else
                Return ""

        End Select
    End Function

    Public Function Get_Day_From_Date(set_date)

        Select Case (set_date).DayOfWeek
            Case "1"
                Return "Monday"
            Case "2"
                Return "Tuesday"
            Case "3"
                Return "Wednesday"
            Case "4"
                Return "Thursday"
            Case "5"
                Return "Fryday"
            Case "6"
                Return "Saterday"
            Case "7"
                Return "Sunday"

            Case Else
                Return ""

        End Select
    End Function

    Public Function Value_in_Empty_String(ByRef variable, ByRef NewValue)

        If variable = "" Then
            variable = NewValue
        End If

        Return variable

    End Function

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
        Dim working_area As Rectangle = _
            SystemInformation.WorkingArea
        Dim x As Integer = _
            working_area.Left + _
            working_area.Width - _
           FormName.Width
        Dim y As Integer = _
            working_area.Top + _
            working_area.Height - _
            FormName.Height
        FormName.Location = New Point(x, y)
    End Sub

    Public Sub form_at_Bottomleft(ByRef FormName)
        Dim working_area As Rectangle = _
            SystemInformation.WorkingArea
        Dim x As Integer = _
            working_area.Left
        Dim y As Integer = _
            working_area.Top + _
            working_area.Height - _
            FormName.Height
        FormName.Location = New Point(x, y)
    End Sub

    Public Sub form_at_topRight(ByRef FormName)
        Dim working_area As Rectangle = _
            SystemInformation.WorkingArea
        Dim x As Integer = _
            working_area.Left + _
            working_area.Width - _
            FormName.Width
        Dim y As Integer = _
            working_area.Top
        FormName.Location = New Point(x, y)
    End Sub

    Public Sub form_at_topleft(ByRef FormName)
        Dim working_area As Rectangle = _
            SystemInformation.WorkingArea
        Dim x As Integer = _
            working_area.Left
        Dim y As Integer = _
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

    Public Sub Empty_Then_Invisible(ByRef Obj)
        If Obj.text = "" Then
            Obj.visible = False
        Else
            Obj.visible = True
        End If
    End Sub

    Public Sub Copy_combobox(ByRef Combobox_Copy, ByRef Combobox_paste)

        Dim Item As String

        For Each Item In Combobox_Copy.Items
            With Combobox_paste.Items
                .Add(Item)
            End With
        Next

    End Sub

    Public Sub Run_Synctoy(ByRef Host)

        If My.Computer.Network.IsAvailable Then

            If My.Computer.Network.Ping(Host) Then
                If My.Computer.FileSystem.FileExists("C:\Program Files\SyncToy 2.1\SyncToyCmd.exe") Then

                    Dim p As New ProcessStartInfo

                    p.FileName = "C:\Program Files\SyncToy 2.1\SyncToyCmd.exe"
                    p.Arguments = "-R"
                    p.WindowStyle = ProcessWindowStyle.Hidden

                    Process.Start(p)

                End If
            End If
        End If

    End Sub

    Public Function Ping(ByRef Host, ByRef Err, timeout)

        Dim pingreq As Ping = New Ping()

        Try
            If My.Computer.Network.IsAvailable Then


                If timeout = 0 Then
                    timeout = 1000
                End If

                Dim rep As PingReply = pingreq.Send(Host, 500)

                Err = True

                If rep.Status.ToString = "Success" Then

                    Err = False

                    If rep.RoundtripTime > 0 Then
                        Return "Reply from " & rep.Address.ToString & " : " & rep.RoundtripTime & "Ms"
                    Else
                        Return "Reply from " & rep.Address.ToString & " : " & "<1 Ms"
                    End If
                Else
                    Return rep.Status.ToString
                End If

            Else
                Return "Network dowm"
            End If

        Catch
            Return "Error: host not valid"

        End Try



    End Function

    Public Sub copy_file_overwrite(ByRef source, ByRef destination)
        Dim filename

        If (source <> "") And (destination <> "") Then

            If File.Exists(source) And Directory.Exists(destination) Then

                filename = Path.GetFileName(source)

                File.Copy(source, destination & "\" & filename, True)
            End If

        End If

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

    Public Function available_drive_letters()
        Dim availableDriveLetters As New List(Of String)
        For x As Integer = 65 To 90
            availableDriveLetters.Add(Chr(x))
        Next
        For Each d As String In System.IO.Directory.GetLogicalDrives()
            availableDriveLetters.Remove(d.Replace(":\", ""))
        Next

        Return availableDriveLetters

    End Function

    Public Sub Map_Drive(ByRef driveletter, ByRef url, ByRef persistent)

        Dim application As New ProcessStartInfo("cmd.exe") With
                     {.RedirectStandardInput = True, .UseShellExecute = False}

        Dim process As New Process
        Dim command

        process = process.Start(application)
        If persistent Then
            command = "net use " & driveletter & ": " & url & " /p:yes " & vbCrLf & "exit"
        Else
            command = "net use " & driveletter & ": " & url & vbCrLf & "exit"
        End If
        process.StandardInput.WriteLine(Command)
        process.WaitForExit()
        process.Close()


    End Sub

    Public Sub Unmap_Drive(ByRef driveletter)

        Dim application As New ProcessStartInfo("cmd.exe") With
             {.RedirectStandardInput = True, .UseShellExecute = False}
        Dim process As New Process

        process = process.Start(application)
        Dim command As String = "net use " & driveletter & ": /delete" & vbCrLf & "exit"
        process.StandardInput.WriteLine(command)
        process.WaitForExit()
        process.Close()

    End Sub

    Public Sub Open_Url(url)

        Dim p As New Process()


        p.StartInfo.FileName = "explorer.exe "
        p.StartInfo.Arguments = url
        p.Start()


    End Sub

End Module
