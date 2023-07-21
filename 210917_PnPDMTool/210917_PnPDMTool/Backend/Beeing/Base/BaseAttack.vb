Public Class BaseAttack

#Region "Defines"
    Public Structure AttackBase

        Public Property DmgType As eDmgType
        Public Property DmgShape As eShape
        Public Property HitRange As Integer
        Public Property AoERange As Integer
        Public Property NumberOfTargets As Integer

        ' Damage
        Public Property DmgBonus As Integer
        Public Property DmgDice As DiceCollection

    End Structure
#End Region

#Region "Private Var"

#End Region


#Region "Properties"
    Public Property Name As String = "Default Name"
    Public Property Description As String = "Default Description"

    Public Property PrimaryAttack As AttackBase = New AttackBase With {
        .DmgType = eDmgType.Bludgeoning,
        .DmgShape = eShape.None,
        .HitRange = 5,
        .AoERange = 5,
        .NumberOfTargets = 1,
        .DmgDice = New DiceCollection,
        .DmgBonus = 0
        }
    Public Property PrimaryAttackHitBonus As Integer = 0
    Public Property PrimaryAttackHitsAlways As Boolean = False
    Public Property PrimaryAttackSavingThrow As eAttribut = eAttribut.Charisma
    Public Property PrimaryAttackUseSavingThrow As Boolean = False


    Public Property HasSecondaryAttack As Boolean = False
    Public Property SecondaryAttack As AttackBase = New AttackBase With {
        .DmgType = eDmgType.Bludgeoning,
        .DmgShape = eShape.None,
        .HitRange = 5,
        .AoERange = 5,
        .NumberOfTargets = 1,
        .DmgDice = New DiceCollection,
        .DmgBonus = 0
        }

    Public Property TriggerConditionOnHit As Boolean = False
    Public Property ConditionTriggersAlways As Boolean = False
    Public Property SecondaryAttackHitsAlways As Boolean = False
    Public Property TriggeredConditionSavingThrow As eAttribut = eAttribut.Charisma
    Public Property TriggeredCondition As New List(Of eCondidtion)

#End Region

#Region "Init"
    Public Sub New()

    End Sub

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Use(dices As DiceSet, type As DiceType.EThrowType) As Integer
        ' Make attack throw
        Return dices.D20.Evaluate(1, type) + PrimaryAttackHitBonus
    End Function

    Public Function GetDmg(dices As DiceSet, type As DiceType.EThrowType) As Integer
        ' Locals
        Dim dmg As Integer = 0

        ' TODO

        Return dmg
    End Function

    Public Function ToListString() As String()
        Dim str(11) As String
        Dim idx As Integer = 0
        str(idx) = Name
        idx += 1

        ' TODO add other parameter

        str(str.Length - 1) = Description
        Return str
    End Function

#End Region

#Region "Events"

#End Region

End Class
