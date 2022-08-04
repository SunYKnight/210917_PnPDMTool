Public Class Dice
    'Grundeinstellungen der Opponents

#Region "Private Var"
    Private _number As Integer
    Private _eyes As Integer
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New(number As Integer, eyes As Integer)
        ' Save class parameter
        Me._number = number
        Me._eyes = eyes
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Evaluate(count As Integer) As Integer
        ' Locals
        Dim diceSum As Integer = 0
        Dim Generator As System.Random = New System.Random()

        For i As Integer = 1 To count
            For j As Integer = 1 To _number
                diceSum += Generator.Next(1, _eyes + 1)
            Next
        Next

        Return diceSum

    End Function


#End Region

#Region "Events"

#End Region
End Class
