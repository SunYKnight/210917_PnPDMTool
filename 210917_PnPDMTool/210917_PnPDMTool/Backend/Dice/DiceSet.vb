Public Class DiceSet
    'Grundeinstellungen der Opponents

#Region "Private Var"

#End Region

#Region "Properties"
    Private Property DiceCount As Integer
#End Region

#Region "Init"
    Public Sub New(count As Integer)
        ' Save class parameter
        Me.DiceCount = count
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Evaluate(count As Integer, dice As DiceType) As Integer
        ' Locals
        Dim result As Integer = 0

        ' Evaluate Set
        For i = 0 To count
            result += dice.Evaluate(DiceType.EThrowType.Normal)
        Next

        Return result
    End Function


#End Region

#Region "Events"

#End Region
End Class
