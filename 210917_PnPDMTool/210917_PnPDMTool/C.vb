Module C
    Public gapSmall As Int32 = 6
    Public gapMedium As Int32 = 12
    Public gapBig As Int32 = 18

    Public heightButtons As Int32 = 30
    Public heightTitle As Int32 = 40
    Public heightSubTitle As Int32 = 25
    Public heightTxtSmall As Int32 = 15
    Public heightTxt1 As Int32 = 20
    Public heightTxtBox As Int32 = 27
    Public heightTxt6 As Int32 = 120

    Public widthTxtSmall As Int32 = 50
    Public widthTxtMedium As Int32 = 70
    Public widthTxtBig As Int32 = 170


#Region "Enum"

    Enum eDmgType
        Bludgeoning
        Piercing
        Slashing
        Acid
        Poison
        Fire
        Cold
        Force
        Lightning
        Thunder
        Necrotic
        Psychic
        Radiant
        Count
    End Enum

    Enum eDmgTypeModifier
        Normal = 1
        Vulnerable = 2
        Resistant = 0.5
        Immune = 0
    End Enum
#End Region
End Module
