Public Class AttributCollection
#Region "Private Var"

#End Region


#Region "Properties"

    Public Property Strength As Attribut = New Attribut
    Public Property Dexterity As Attribut = New Attribut
    Public Property Constitution As Attribut = New Attribut
    Public Property Intelligence As Attribut = New Attribut
    Public Property Wisdom As Attribut = New Attribut
    Public Property Charisma As Attribut = New Attribut
#End Region

#Region "Init"
    Public Sub Init()

    End Sub

    Public Shared Widening Operator CType(v As Boolean) As AttributCollection
        Throw New NotImplementedException()
    End Operator
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class
