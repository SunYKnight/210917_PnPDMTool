Public Module C
    Public GAP_SMALL As Int32 = 6
    Public GAP_MEDIUM As Int32 = 12
    Public GAP_BIG As Int32 = 18

    Public HEIGHT_BUTTON As Int32 = 30
    Public HEIGHT_TITLE As Int32 = 40
    Public HEIGHT_SUBTITLE As Int32 = 25
    Public HEIGHT_TEXT_SMALL As Int32 = 15
    Public HEIGHT_TEXT_1 As Int32 = 20
    Public HEIGHT_TEXT_BOX As Int32 = 27
    Public HEIGHT_TEXT_6 As Int32 = 120

    Public WIDTH_TEXT_SMALL As Int32 = 50
    Public WIDTH_TEXT_MEDIUM As Int32 = 70
    Public WIDTH_TEXT_BIG As Int32 = 170


#Region "Enum"

    Public Enum EBattleParticipentType
        Player
        NPC
        Monster
    End Enum

    Public Enum ECondidtion
        Blinded
        Charmed
        Deafened
        Exhaustion
        Fightended
        Grappeled
        Incapacitatated
        Invisible
        Paralyzed
        Poisoned
        Prone
        Restrained
        Stunned
        Unconscious
    End Enum

    <Flags()> Public Enum ELanguages
        Abyssal = 1 << 1
        Celestial = 1 << 2
        Common = 1 << 3
        Draconic = 1 << 4
        Dwarfish = 1 << 5
        Elvish = 1 << 6
        Giant = 1 << 7
        Infernal = 1 << 8
        Primordial = 1 << 9
        Sylvan = 1 << 10
        Aarakocra = 1 << 11
        All = 1 << 12
        Aquan = 1 << 13
        Blink_Dog = 1 << 14
        Bothii = 1 << 15
        Bullywug = 1 << 16
        Citanes = 1 << 17
        Dealkyr = 1 << 18
        Deep_Speech = 1 << 19
        Djaynaian = 1 << 20
        Druidic = 1 << 21
        Giant_Eagle = 1 << 22
        Giant_Elk = 1 << 23
        Giant_Owl = 1 << 24
        Gith = 1 << 25
        Gnoll = 1 << 26
        Gnomish = 1 << 27
        Goblin = 1 << 28
        Godstongue = 1 << 29
        Grell = 1 << 30
        Grippli = 1 << 31
        Grung = 1 << 32
        Halfling = 1 << 33
        Halri = 1 << 34
        Hook_Horror = 1 << 35
        Ice_Toad = 1 << 36
        Ignan = 1 << 37
        Ixtxachitl = 1 << 38
        Kraul = 1 << 39
        Leonin = 1 << 40
        Loxodon = 1 << 41
        Marquesian = 1 << 42
        Maynah = 1 << 43
        Minotaur = 1 << 44
        Modron = 1 << 45
        Nwarian = 1 << 46
        Naush = 1 << 47
        Netherese = 1 << 48
        Olman = 1 << 49
        Orc = 1 << 50
        Otyugh = 1 << 51
        Quirapu = 1 << 52
        Quori = 1 << 53
        Riedran = 1 << 54
        Sahuagin = 1 << 55
        Sensan = 1 << 56
        Shankhi = 1 << 57
        Skitterwidget = 1 << 58
        Slaad = 1 << 59
        Sphinx = 1 << 60
        Telepathy = 1 << 61
        Terran = 1 << 62
        Thayan = 1 << 63
        Thieves_Cant = 1 << 64
        Thri_kreen = 1 << 65
        Tletahtolli = 1 << 66
        Tlincalli = 1 << 67
        Troglodyte = 1 << 68
        Umber_Hulk = 1 << 69
        Undercommon = 1 << 70
        Vedalken = 1 << 71
        Vegepygmy = 1 << 72
        Winter_Wolf = 1 << 73
        Worg = 1 << 74
        Xingyu = 1 << 75
        Yeti = 1 << 76
        Yikaria = 1 << 77
        Zabaani = 1 << 78
        Zemnian = 1 << 79
        Ziklight = 1 << 80
    End Enum

    Public Enum EDmgType
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


    Public Enum EDmgTypeModifier
        Normal = 1
        Vulnerable = 2
        Resistant = 0.5
        Immune = 0
    End Enum

    Public Enum EEnvironment
        Arctic
        Coastal
        Desert
        Forest
        Grassland
        Hill
        Moontain
        Swamp
        Underdark
        Underwater
        Urban
    End Enum

    Public Enum ESize
        Tiny
        Small
        Medium
        Large
        Huge
        Gargantuan
    End Enum

    Public Enum ESenses
        Blindsight
        Darkvision
        Tremorsense
        Truesight
    End Enum

    Public Function CalcRelativeSize(parentSize As Size, facWidth As Double, facHeight As Double) As Size
        Return New Point(parentSize.Width * facWidth, parentSize.Height * facHeight)
    End Function

    Public Function CalcRelativeLocation(parentSize As Size, ownSize As Size, facWidth As Double, facHeight As Double) As Point
        Return New Point(parentSize.Width * facWidth - ownSize.Width / 2, parentSize.Height * facHeight - ownSize.Height / 2)
    End Function


#End Region
End Module
