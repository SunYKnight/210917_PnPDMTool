<Serializable()>
Public Class TileType
#Region "Enum"
    Public Enum eGroundType
        Soil
        Water
        Stone
        Void
    End Enum

    Public Enum eWallType
        None
        Weak
        Stable
        Climable
    End Enum

    Public Class Metadata
        Public Location_R As Integer
        Public Location_C As Integer
    End Class

    Public Class TileData
        Public GroundMaterial As eGroundType
        Public FreeSky_ft As Integer
        Public WallNorth As eWallType
        Public WallEast As eWallType
        Public WallSouth As eWallType
        Public WallWest As eWallType
        Public Elevation As Integer
        Public IsDifficultTerrain As Boolean
        Public IsTrap As Boolean
        Public CauseCondition As List(Of eCondidtion)
        Public LightIntensity As eLightIntensity
    End Class

#End Region

#Region "Private Var"
    Public Property Meta As Metadata = New Metadata With {
        .Location_C = -1,
        .Location_R = -1}

    Public Property Base As TileData = New TileData With {
        .GroundMaterial = eGroundType.Soil,
        .FreeSky_ft = 1000,
        .WallEast = eWallType.None,
        .WallNorth = eWallType.None,
        .WallSouth = eWallType.None,
        .WallWest = eWallType.None,
        .CauseCondition = New List(Of eCondidtion),
        .Elevation = 100,
        .IsDifficultTerrain = False,
        .IsTrap = False,
        .LightIntensity = eLightIntensity.Bright}

    Public Property Temp As TileData = New TileData With {
        .GroundMaterial = eGroundType.Soil,
        .FreeSky_ft = 1000,
        .WallEast = eWallType.None,
        .WallNorth = eWallType.None,
        .WallSouth = eWallType.None,
        .WallWest = eWallType.None,
        .CauseCondition = New List(Of eCondidtion),
        .Elevation = 100,
        .IsDifficultTerrain = False,
        .IsTrap = False,
        .LightIntensity = eLightIntensity.Bright}

#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
