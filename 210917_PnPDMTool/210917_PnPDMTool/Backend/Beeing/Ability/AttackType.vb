Public Class AttackType
#Region "Private Var"

#End Region


#Region "Properties"
    Public Property Name As String = ""
    Public Property Description As String = ""
    Public Property DmgType As EDmgType = EDmgType.Bludgeoning
    Public Property Range As Double = 0
    Public Property HitBonus As Integer = 0
    Public Property DmgBonus As Integer = 0

    Public Property DmgDiceD4 As DiceSet = New DiceSet()
    Public Property DmgDiceD6 As DiceSet = New DiceSet()
    Public Property DmgDiceD8 As DiceSet = New DiceSet()
    Public Property DmgDiceD12 As DiceSet = New DiceSet()
    Public Property DmgDiceD20 As DiceSet = New DiceSet()
    Public Property DmgDiceD100 As DiceSet = New DiceSet()

#End Region

#Region "Init"
    Public Sub Init()

    End Sub

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Use(dices As DiceCollection, type As DiceType.EThrowType) As Integer
        ' Make attack throw
        Return dices.D20.Evaluate(type) + HitBonus
    End Function

    Public Function GetDmg(dices As DiceCollection, type As DiceType.EThrowType) As Integer
        ' Locals
        Dim dmg As Integer = 0
        ' Evaluate all damage dices
        dmg += DmgDiceD4.Evaluate(dices.D4, type)
        dmg += DmgDiceD6.Evaluate(dices.D6, type)
        dmg += DmgDiceD8.Evaluate(dices.D8, type)
        dmg += DmgDiceD12.Evaluate(dices.D12, type)
        dmg += DmgDiceD20.Evaluate(dices.D20, type)
        dmg += DmgDiceD100.Evaluate(dices.D100, type)

        Return dmg
    End Function

    Public Function ToListString() As String()
        Dim str(11) As String
        Dim idx As Integer = 0
        str(idx) = Name
        idx += 1
        str(idx) = HitBonus.ToString
        idx += 1
        str(idx) = DmgType.ToString
        idx += 1
        str(idx) = Range.ToString
        idx += 1
        str(idx) = DmgDiceD4.DiceCount.ToString
        idx += 1
        str(idx) = DmgDiceD6.DiceCount.ToString
        idx += 1
        str(idx) = DmgDiceD8.DiceCount.ToString
        idx += 1
        str(idx) = DmgDiceD12.DiceCount.ToString
        idx += 1
        str(idx) = DmgDiceD20.DiceCount.ToString
        idx += 1
        str(idx) = DmgDiceD100.DiceCount.ToString
        idx += 1
        str(idx) = DmgBonus.ToString
        idx += 1
        str(idx) = Description
        idx += 1
        Return str
    End Function

#End Region

#Region "Events"

#End Region

End Class
