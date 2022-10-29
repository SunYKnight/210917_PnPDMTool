Public Class ProficencyType
#Region "Private Var"

#End Region


#Region "Properties"
    Public Property ProficencyValue As Double = 0
#End Region

#Region "Init"
    Public Sub Init()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Evaluate(dice As DiceType, throwType As DiceType.EThrowType)
        Return dice.Evaluate(throwType) + Me.ProficencyValue
    End Function
#End Region

#Region "Events"

#End Region
End Class
