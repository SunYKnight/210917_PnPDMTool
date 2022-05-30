Module Programm
    Public Sub Main()
        Dim mainWindow As MainWindow

        ' Do compatibility stuff
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Create MainWindow element
        mainWindow = New MainWindow()

        ' Run MainWindow
        Application.Run(mainWindow)

    End Sub

End Module
