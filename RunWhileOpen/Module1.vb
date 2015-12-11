' Author: Kalbintion
' Date: December 10 2015
' Desc: This application will stay running in the background until a program is no longer opened
'       which was to allow a "game" to be marked as being played in steam without having to worry
'       about the overlay potentially coming up due to some software not being intended to work
'       with steams overlays or other steam interactions
'
'       Particular use cases involve Minecraft's Map Editor MCEdit, where multiple versions use the
'       same executable name, but swapping between them would require each particular version to be
'       added to the Steam library list. Sony Vegas Pro 13.0 has crashed with Steam overlay attempting
'       to be added to the application.

Module Module1

    Sub Main()
        Dim running As Boolean = False
        Dim exe As String

        Dim runFile As Boolean = False

        If Environment.GetCommandLineArgs().Count > 1 Then
            exe = Environment.GetCommandLineArgs(1) ' Grab the first argument from the line
            If exe.ToLower = "-o" Or exe.ToLower = "-r" Then
                runFile = True
                exe = Environment.GetCommandLineArgs(2) ' Since this is the -o parameter, the second arg will be the file location
            End If
        Else
            End ' We don't have enough information
        End If

        If runFile Then
            Process.Start(exe)
            Dim file As System.IO.FileInfo = New System.IO.FileInfo(exe)
            exe = file.ToString
        End If

        Dim p() As Process
        Console.WriteLine("Looking for: " & exe)
        Do
            p = Process.GetProcessesByName(exe)
            If p.Count > 0 Then
                running = True
            Else
                running = False
            End If
            System.Threading.Thread.Sleep(5000) ' Prevent program from running non-stop. meant to cut down on CPU usage
        Loop Until running = False
    End Sub

End Module
