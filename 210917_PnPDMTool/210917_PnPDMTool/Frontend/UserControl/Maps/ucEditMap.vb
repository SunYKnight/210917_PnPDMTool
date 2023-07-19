Imports System.IO
Imports _210917_PnPDMTool.C

Public Class ucEditMap
#Region "Private Var"

#End Region

#Region "Properties"
    Public Overrides Property MinimumSize As Size = New Size(C.WIDTH_CONTROL_EDIT, C.HEIGHT_CONTROL_EDIT)
    Public Property Map As New MapType
#End Region

#Region "Init"

    Public Sub New(m As MapType)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Save beeing
        Me.Map = m

    End Sub

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Save() As Object
        Return Map
    End Function

    Public Function GetOutputType() As Type
        Return GetType(MapType)
    End Function

    Public Function Discard() As Object
        Return Map
    End Function
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.DoubleClick
        Dim fs As New FileSelector(MAP_FILES)

        ' CHeck success
        If fs.Path <> "" Then
            Map.Path = fs.Path
            Me.PictureBox_Map.Image = ResizeImage(Image.FromFile(Map.Path), Me.PictureBox_Map.Width, Me.PictureBox_Map.Height)
        End If

    End Sub


#End Region

#Region "Events"
    Public Event btnMapDiscardClicked()
    Public Event btnMapSaveClicked()
#End Region
End Class
