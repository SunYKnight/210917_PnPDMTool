Public Class Action
#Region "Enum"
    Enum eType
        Attack
        Dash
        Doge
        Hold
    End Enum
#End Region

#Region "Private Var"
    Private _type As eType

#End Region

#Region "Properties"
    Public Property Description As String = ""
    Public Property Range As Single = 0

    Public Property AttackList As List(Of Attack)

#End Region

#Region "Init"
    Public Sub New(t As eType)

        _type = t

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Sub Use(self As BattleParticipants, target As BattleParticipants)
        Dim attackRollValue As Integer
        Dim dmgRollValue As Integer
        Select Case _type

            Case eType.Attack
                For Each attack In AttackList
                    ' Get Attack roll value
                    attackRollValue = attack.Use(self.Dices, DiceType.EThrowType.Normal)
                    ' Raise Event
                    RaiseEvent AttackRollThrow(attackRollValue)
                    ' Check AC value
                    If (target.LiveAC < attackRollValue) Then
                        ' Get Attack damage
                        dmgRollValue = attack.GetDmg(self.Dices, DiceType.EThrowType.Normal)
                        ' Raise Event
                        RaiseEvent AttackRollThrow(dmgRollValue)
                        ' Adjust target HP
                        target.LiveHP -= dmgRollValue
                    End If
                Next
            Case eType.Hold
            Case eType.Dash
            Case eType.Doge

        End Select
    End Sub
#End Region

#Region "Events"
    Public Event AttackRollThrow(attackRollValue As Integer)
    Public Event DmgRollThrow(dmgRollValue As Integer)
#End Region

#Region "GUI Handle"

#End Region
End Class
