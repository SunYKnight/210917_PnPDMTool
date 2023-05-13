
<Serializable()>
Public Class CollectonMetadata
    ' Metadata
    Public Property Name As String = ""
    Public Property Image As String = ""
    Public Property Aligment As New BaseAligment()
    Public Property Size As eSize = eSize.Medium
    Public Property SpellcastAttribute As eAttribut = eAttribut.Wisdom
    Public Property Proficency As Integer = 2

End Class

<Serializable()>
Public Class CollectonStat
    ' Bonus
    Public Property BonusHP As Integer = 0
    Public Property BonusSpeed As New SpeedCollection
    Public Property BonusAC As Integer = 0
    Public Property BonusStrength As New Integer
    Public Property BonusDexterity As New Integer
    Public Property BonusConstitution As New Integer
    Public Property BonusIntelligence As New Integer
    Public Property BonusWisdom As New Integer
    Public Property BonusCharisma As New Integer

    ' Base Stats
    Public Property AC As New BaseAC
    Public Property Strength As New BaseAttribut
    Public Property Dexterity As New BaseAttribut
    Public Property Constitution As New BaseAttribut
    Public Property Wisdom As New BaseAttribut
    Public Property Intelligence As New BaseAttribut
    Public Property Charisma As New BaseAttribut
    Public Property BaseSpeed As New SpeedCollection

    ' Lists
    Public Property ActionList As New List(Of BaseAction)
    Public Property KnownLanguages As New List(Of C.eLanguages)
    Public Property SavingThrowProficencies As New List(Of C.eAttribut)
    Public Property DmgImmunities As New List(Of C.eDmgType)
    Public Property DmgResistances As New List(Of C.eDmgType)
    Public Property DmgVulnerabilites As New List(Of C.eDmgType)
    Public Property ConditionImmunities As New List(Of C.eCondidtion)
    Public Property SkillProficencies As New List(Of C.eSkills)
    Public Property SkillExpertieses As New List(Of C.eSkills)
    Public Property ArmourProficencies As New List(Of C.eArmours)
    Public Property WeaponProficencies As New List(Of C.eWeapons)
    Public Property ToolsProficencies As New List(Of C.eTools)

End Class


<Serializable()>
Public Class BeeingType

#Region "Enum"
    Public Enum eBType
        Player
        Monster
        NPC
    End Enum

#End Region

#Region "Private Var"

#End Region


#Region "Properties"

    ' Type
    Public Property BType As eBType


    ' Monster Parameter
    Public Property MonsterType As eMonsterType = eMonsterType.None
    Public Property Challenge As Single = 0
    Public Property HpDice As New DiceCollection

    ' Player / NPC
    Public Property RaceType As eRaceType = eRaceType.None
    Public Property ClassType As eClassType = eClassType.None
    Public Property Level As Integer = 0
    Public Property BaseHP As Integer = 0


    ' Type Specific
    Public Property Metadata As New CollectonMetadata
    Public Property Stats As New CollectonStat


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
        str(0) = Metadata.Name
        str(1) = Challenge.ToString("F2")
        Return str
    End Function
#End Region

#Region "Events"

#End Region
End Class
