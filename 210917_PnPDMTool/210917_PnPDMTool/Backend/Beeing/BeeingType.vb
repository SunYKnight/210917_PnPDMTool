Public Class BeeingType
#Region "Private Var"
#End Region


#Region "Properties"
    Public Property Name As String = ""
    Public Property Image As String = ""
    Public Property Skills As SkillCollection = New SkillCollection
    Public Property SavingThrows As SavingThrowCollection = New SavingThrowCollection
    Public Property Attributs As AttributCollection = New AttributCollection
    Public Property Aligment As AligmentType = New AligmentType
    Public Property Size As ESize = ESize.Medium
    Public Property SpeedWalk As Integer = 0
    Public Property SpeedBurrowing As Integer = 0
    Public Property SpeedSwimming As Integer = 0
    Public Property SpeedFlying As Integer = 0
    Public Property SpeedClimb As Integer = 0
    Public Property AC As Integer = 8
    Public Property Proficency As Integer = 2
    Public Property Challenge As Single = 1


    Public Property MonsterClass As eMonsterType = eMonsterType.Abberation

    Public Property HpDiceD4 As DiceSet = New DiceSet()
    Public Property HpDiceD6 As DiceSet = New DiceSet()
    Public Property HpDiceD8 As DiceSet = New DiceSet()
    Public Property HpDiceD12 As DiceSet = New DiceSet()
    Public Property HpDiceD20 As DiceSet = New DiceSet()
    Public Property HpDiceD100 As DiceSet = New DiceSet()
    Public Property HPBonus As Integer = 0

    ' Lists
    Public Property ActionList As New List(Of ActionType)
    Public Property DmgImmunities As C.eDmgTypeModifier() = New eDmgTypeModifier() {0}
    Public Property ConditionImmunities As C.eDmgTypeModifier() = New eDmgTypeModifier() {0}
    Public Property Languages As New List(Of C.eLanguages)
#End Region

#Region "Init"
    Public Sub New()
        Dim idx = 0

        ' Create Damage Immunities
        ReDim DmgImmunities(System.Enum.GetValues(GetType(C.EDmgType)).Length)
        For Each dmgType In System.Enum.GetValues(GetType(C.EDmgType))
            DmgImmunities(idx) = eDmgTypeModifier.Normal
            idx += 1
        Next

        ' Create Condition Immunities
        idx = 0
        ReDim ConditionImmunities(System.Enum.GetValues(GetType(C.ECondidtion)).Length)
        For Each dmgType In System.Enum.GetValues(GetType(C.ECondidtion))
            ConditionImmunities(idx) = eDmgTypeModifier.Normal
            idx += 1
        Next

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function ToListString() As String()
        Dim str(1) As String
        str(0) = Name
        Return str
    End Function
#End Region

#Region "Events"

#End Region
End Class
