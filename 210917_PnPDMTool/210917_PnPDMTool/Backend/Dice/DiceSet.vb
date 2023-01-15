Public Class DiceSet
    'Grundeinstellungen der Opponents

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property DiceCount As Integer = 0
#End Region

#Region "Init"
    Public Sub New()

    End Sub

    Public Sub New(count As Integer)
        ' Save class parameter
        Me.DiceCount = count
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Evaluate(dice As DiceType, type As DiceType.EThrowType) As Integer
        ' Locals
        Dim result As Integer = 0

        ' Evaluate Set
        For i = 0 To Me.DiceCount
            result += dice.Evaluate(type)
        Next

        Return result
    End Function


#End Region

#Region "Events"

#End Region
End Class
