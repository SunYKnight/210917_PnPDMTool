Module Programm
    Public Sub Main()
        Dim mainWindow As MainWindow
        Dim loadedBeeings As New List(Of BeeingType)
        Dim beeingLoader As New xml(Of BeeingType)

        ' Do compatibility stuff
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Create Folders
        If Not IO.Directory.Exists("Data") Then
            IO.Directory.CreateDirectory("Data")
        End If
        If Not IO.Directory.Exists("Data/Beeings") Then
            IO.Directory.CreateDirectory("Data/Beeings")
        End If
        If Not IO.Directory.Exists("Data/Images") Then
            IO.Directory.CreateDirectory("Data/Images")
        End If
        If Not IO.Directory.Exists("Data/Maps") Then
            IO.Directory.CreateDirectory("Data/Maps")
        End If
        If Not IO.Directory.Exists("Data/CurrentSesssion") Then
            IO.Directory.CreateDirectory("Data/CurrentSesssion")
        End If

        ' Load all saved beeings
        For Each file In IO.Directory.GetFiles("Data/Beeings")
            loadedBeeings.Add(beeingLoader.Deserialize(file, "BeeingType"))
        Next

        ' Create MainWindow element
        mainWindow = New MainWindow(loadedBeeings)

        ' Run MainWindow
        Application.Run(mainWindow)

    End Sub

End Module
