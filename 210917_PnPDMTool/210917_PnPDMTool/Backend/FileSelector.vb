Public Class FileSelector

    Public Property Path As String

    Public Sub New(filter As String)
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Select Map"
        fd.InitialDirectory = "C:\"
        fd.Filter = filter
        fd.FilterIndex = 2
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            Path = fd.FileName
        End If

    End Sub



End Class
