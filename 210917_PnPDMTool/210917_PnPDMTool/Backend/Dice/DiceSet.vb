Imports _210917_PnPDMTool.C

Public Class DiceSet

#Region "Private Var"
    Private WithEvents _d4 As DiceType
    Private WithEvents _d6 As DiceType
    Private WithEvents _d8 As DiceType
    Private WithEvents _d10 As DiceType
    Private WithEvents _d12 As DiceType
    Private WithEvents _d20 As DiceType
    Private WithEvents _d100 As DiceType

#End Region

#Region "Properties"

    Public ReadOnly Property D4 As DiceType
        Get
            Return _d4
        End Get
    End Property
    Public ReadOnly Property D6 As DiceType
        Get
            Return _d6
        End Get
    End Property
    Public ReadOnly Property D8 As DiceType
        Get
            Return _d8
        End Get
    End Property
    Public ReadOnly Property D10 As DiceType
        Get
            Return _d10
        End Get
    End Property
    Public ReadOnly Property D12 As DiceType
        Get
            Return _d12
        End Get
    End Property
    Public ReadOnly Property D20 As DiceType
        Get
            Return _d20
        End Get
    End Property
    Public ReadOnly Property D100 As DiceType
        Get
            Return _d100
        End Get
    End Property

#End Region

#Region "Init"
    Public Sub New()
        ' Create dices
        _d4 = New DiceType(4)
        _d6 = New DiceType(6)
        _d8 = New DiceType(8)
        _d10 = New DiceType(10)
        _d12 = New DiceType(12)
        _d20 = New DiceType(20)
        _d100 = New DiceType(100)
    End Sub
#End Region

#Region "Private Sub"
    Private Sub DiceRolledHandle(dice As DiceType, result As Integer) Handles _d4.DiceRolled, _d6.DiceRolled, _d8.DiceRolled, _d12.DiceRolled, _d10.DiceRolled, _d20.DiceRolled, _d100.DiceRolled

    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class

