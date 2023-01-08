Public Class DiceCollection

#Region "Private Var"
    Private WithEvents _d4 As DiceType
    Private WithEvents _d8 As DiceType
    Private WithEvents _d10 As DiceType
    Private WithEvents _d12 As DiceType
    Private WithEvents _d20 As DiceType
    Private WithEvents _d100 As DiceType

#End Region

#Region "Properties"

    Public ReadOnly D4 As DiceType = d4
    Public ReadOnly D8 As DiceType = _d8
    Public ReadOnly D10 As DiceType = _d10
    Public ReadOnly D12 As DiceType = _d12
    Public ReadOnly D20 As DiceType = _d20
    Public ReadOnly D100 As DiceType = _d100

#End Region

#Region "Init"
    Public Sub Init()
        ' Create dices
        _d4 = New DiceType(4)
        _d8 = New DiceType(8)
        _d10 = New DiceType(10)
        _d12 = New DiceType(12)
        _d20 = New DiceType(20)
        _d100 = New DiceType(100)
    End Sub
#End Region

#Region "Private Sub"
    Private Sub DiceRolledHandle(dice As DiceType, result As Integer) Handles _d4.DiceRolled, _d8.DiceRolled, _d12.DiceRolled, _d10.DiceRolled, _d20.DiceRolled, _d100.DiceRolled


    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class
