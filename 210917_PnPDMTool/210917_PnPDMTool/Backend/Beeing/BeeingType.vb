
<Serializable()>
Public Class CollectonMetadata
    ' Metadata
    Public Property Name As String = ""
    Public Property Image As String = ""
    Public Property Aligment As New BaseAligment()
    Public Property Size As eSize = eSize.Medium
    Public Property Proficency As Integer = 2
    Public Property SpellcastAttribute As eAttribut = eAttribut.Wisdom

End Class

<Serializable()>
Public Class CollectonStat
    ' Bonus
    Public Property BonusHP As Integer = 0
    Public Property BonusSpeed As New SpeedCollection
    Public Property BonusAC As Integer = 0

    ' Base Stats
    Public Property AC As New BaseAC
    Public Property Strength As New BaseAttribut
    Public Property Dexterity As New BaseAttribut
    Public Property Constitution As New BaseAttribut
    Public Property Intelligence As New BaseAttribut
    Public Property Wisdom As New BaseAttribut
    Public Property Charisma As New BaseAttribut
    Public Property SpeedBase As New SpeedCollection

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
    Public Property ArmourProficencies As New List(Of C.eArmour)
    Public Property WeaponProficencies As New List(Of C.eWeapon)
    Public Property ToolsProficencies As New List(Of C.eTool)

End Class


<Serializable()>
Public Class BeeingType

#Region "Private Var"

#End Region


#Region "Properties"

    Public Property MonsterType As eMonsterType = eMonsterType.None
    Public Property RaceType As eRaceType = eRaceType.None
    Public Property ClassType As eClassType = eClassType.None
    Public Property Challenge As Single = 0
    Public Property Level As Integer = 0
    Public Property HpDice As New DiceCollection

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
    Public Function ToListString() As String()
        Dim str(1) As String
        str(0) = Metadata.Name
        Return str
    End Function
#End Region

#Region "Events"

#End Region
End Class
