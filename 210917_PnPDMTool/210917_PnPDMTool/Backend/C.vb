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

    Public WIDTH_CONTROL_EDIT As Integer = 1500
    Public HEIGHT_CONTROL_EDIT As Integer = 1200


#Region "Enum"

    Public Enum EBattleParticipentType
        Player
        NPC
        Monster
    End Enum

    Public Enum eAttributs
        Strength
        Dexterity
        Constitution
        Intelligence
        Wisdom
        Charisma
    End Enum

    Public Enum eSkills
        Acrobatic
        AnimalHandling
        Arcana
        Athletics
        Deception
        History
        Insight
        Intimidation
        Investigation
        Medicine
        Nature
        Perception
        Performance
        Persuation
        Religion
        SlightOfHand
        Stealth
        Survival
    End Enum

    Public Enum eCondidtion
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

    Public Enum eLanguages
        Abyssal
        Celestial
        Common
        Draconic
        Dwarfish
        Elvish
        Giant
        Infernal
        Primordial
        Sylvan
        Aarakocra
        All
        Aquan
        Blink_Dog
        Bothii
        Bullywug
        Citanes
        Dealkyr
        Deep_Speech
        Djaynaian
        Druidic
        Giant_Eagle
        Giant_Elk
        Giant_Owl
        Gith
        Gnoll
        Gnomish
        Goblin
        Godstongue
        Grell
        Grippli
        Grung
        Halfling
        Halri
        Hook_Horror
        Ice_Toad
        Ignan
        Ixtxachitl
        Kraul
        Leonin
        Loxodon 
        Marquesian
        Maynah
        Minotaur
        Modron
        Nwarian
        Naush
        Netherese
        Olman
        Orc
        Otyugh
        Quirapu
        Quori
        Riedran
        Sahuagin
        Sensan
        Shankhi
        Skitterwidget
        Slaad
        Sphinx
        Telepathy
        Terran
        Thayan
        Thieves_Cant
        Thri_kreen
        Tletahtolli
        Tlincalli
        Troglodyte
        Umber_Hulk
        Undercommon
        Vedalken
        Vegepygmy
        Winter_Wolf
        Worg
        Xingyu
        Yeti
        Yikaria
        Zabaani
        Zemnian
        Ziklight
    End Enum

    Public Enum eDmgType
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
        Magical
    End Enum


    Public Enum eImmunitiesModifier
        Normal
        Vulnerable
        Resistant
        Immune
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

    Public Enum eMonsterType
        Abberation
        Beast
        Celestial
        Construct
        Dragon
        Elemental
        Fey
        Fiend
        Giant
        Monstrosity
        Ooze
        Plant
        Undead
    End Enum

    Public Function CalcRelativeSize(parentSize As Size, facWidth As Double, facHeight As Double, min As Size) As Size
        ' Locals
        Dim s As Size = New Size(parentSize.Width * facWidth, parentSize.Height * facHeight)

        ' Check width 
        If (s.Width < min.Width) Then
            s.Width = min.Width
        End If

        ' Check Height 
        If (s.Height < min.Height) Then
            s.Height = min.Height
        End If

        Return s
    End Function

    Public Function CalcRelativeLocation(parentSize As Size, ownSize As Size, facWidth As Double, facHeight As Double) As Point
        Return New Point(parentSize.Width * facWidth - ownSize.Width / 2, parentSize.Height * facHeight - ownSize.Height / 2)
    End Function


#End Region
End Module
