Public Class ActionType
#Region "Enum"
    Enum eType
        Attack
        Dash
        Doge
        Hold
    End Enum
#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property Name As String = ""
    Public Property Description As String = ""
    Public Property Type As eType
    Public Property AttackList As List(Of AttackType)

#End Region

#Region "Init"
    Public Sub New(t As eType)

        Type = t

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function ToListString() As String()
        Dim str(2) As String
        str(0) = Name
        str(1) = Type.ToString
        Return str
    End Function

    Public Sub Use(self As BattleParticipants, target As BattleParticipants)
        Dim attackRollValue As Integer
        Dim dmgRollValue As Integer
        Select Case Type

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
