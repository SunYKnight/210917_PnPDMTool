Imports _210917_PnPDMTool.TileType

<Serializable()>
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
    Public Property Tiles As TileType()
#End Region

#Region "Init"
    Public Sub New()

    End Sub
#End Region

#Region "Private Sub"

    Private Function getTileIdx(col As Integer, row As Integer)
        Return row + col * Height
    End Function

#End Region

#Region "Pubilc Sub"

    Public Function getTile(col As Integer, row As Integer)
        Return Tiles(getTileIdx(col, row))
    End Function

    Public Sub UpdateTiles(cols As Integer, rows As Integer)
        ' Resize Array
        ReDim Tiles(cols * rows)
        ' Create default Tiles
        For c As Integer = 0 To cols - 1
            For r As Integer = 0 To rows - 1
                Tiles(getTileIdx(c, r)) = New TileType()
                Tiles(getTileIdx(c, r)).Location_C = c
                Tiles(getTileIdx(c, r)).Location_R = r
            Next
        Next
    End Sub

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
