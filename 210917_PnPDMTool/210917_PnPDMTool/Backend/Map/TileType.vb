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

#End Region

#Region "Private Var"
    Public Property Location_R As Integer
    Public Property Location_C As Integer
    Public Property groundMaterial As eGroundType = eGroundType.Soil
    Public Property freeSky_ft As Integer = 1000
    Public Property WallNorth As eWallType = eWallType.None
    Public Property WallEast As eWallType = eWallType.None
    Public Property WallSouth As eWallType = eWallType.None
    Public Property WallWest As eWallType = eWallType.None
    Public Property Elevation As Integer = 0
    Public Property IsDifficultTerrain As Boolean = False
    Public Property IsTrap As Boolean = False
    Public Property CausedCondition As New List(Of eCondidtion)
    Public Property LightIntensity As eLightIntensity = eLightIntensity.Bright
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
