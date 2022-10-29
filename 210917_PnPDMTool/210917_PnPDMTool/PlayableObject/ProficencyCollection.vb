Public Class ProficencyCollection
#Region "Enum"
    Public Enum eArmor
        Light
        Medium
        Heavy
        Shild
    End Enum

    Public Enum eWeapon
        SimpleMeele
        SimpleRanged
        MartialMeele
        MartialRanged
    End Enum

    Public Enum eTool
        ' Artisan's tools
        AlchemistSupplies
        BrewerSublies
        CalligrapherSupplies
        CarpenterTools
        CartographerTools
        CobblerTools
        CookUtensil
        GlassblowerTools
        JewelerTools
        LeatherworkerTools
        MasonTools
        PainterSupplies
        PotterTools
        SmithTools
        TinkerTools
        WeaverTools
        WoodcarverTools
        DisguiseKit
        ForgeryKit
        ' Gaming Set
        DiceSet
        DragonchessSet
        PlayingCardSet
        ThreeDragonAnteSet
        HerbalismKit
        ' MusicalInstrument
        Bagpipes
        Drum
        Dulcimer
        Flute
        Lute
        Lyre
        Horn
        PanFlute
        Shawm
        Viol
        NavigatorTools
        PoisonerTools
        ThievesTools
        ' TODO Vehicles
    End Enum
#End Region
#Region "Private Var"
    Private _armors As List(Of ProficencyType)
    Private _weapons As List(Of ProficencyType)
    Private _tools As List(Of ProficencyType)
    Private _languages As C.ELanguages = 0


#End Region


#Region "Properties"

#End Region

#Region "Init"
    Public Sub Init()

        ' Get all armours
        For Each i In System.Enum.GetValues(GetType(eArmor))
            _armors.Append(New ProficencyType)
        Next

        ' Get all armours
        For Each i In System.Enum.GetValues(GetType(eWeapon))
            _weapons.Append(New ProficencyType)
        Next

        ' Get all armours
        For Each i In System.Enum.GetValues(GetType(eTool))
            _tools.Append(New ProficencyType)
        Next

    End Sub

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class
