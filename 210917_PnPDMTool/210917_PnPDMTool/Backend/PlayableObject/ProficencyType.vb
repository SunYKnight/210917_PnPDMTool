Public Class ProficencyType

#Region "Enum"
    Public Enum ECopmetenceType
        None = 0
        Proficent = 1
        Expertise = 2
    End Enum
#End Region
#Region "Private Var"

#End Region


#Region "Properties"
    Public Property Competence As ECopmetenceType = ECopmetenceType.None
#End Region

#Region "Init"
    Public Sub Init()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Evaluate(dice As DiceType, throwType As DiceType.EThrowType, procficencyValue As Integer)
        Return dice.Evaluate(throwType) + procficencyValue * Competence
    End Function
#End Region

#Region "Events"

#End Region
End Class
