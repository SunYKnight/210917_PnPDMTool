Public Class MapType
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property Path As String = ""
    Public Property Name As String = ""
    Public Property Width As Integer = 0
    Public Property Height As Integer = 0
    Public Property Tiles As TileType()()
#End Region

#Region "Init"
    Public Sub New()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function ToListString(cnt As Integer) As String()
        Dim str(cnt) As String
        str(0) = Name
        str(1) = Width.ToString() + "x" + Height.ToString()
        Return str
    End Function
#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
