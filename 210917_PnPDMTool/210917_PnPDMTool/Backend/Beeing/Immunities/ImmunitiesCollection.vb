Public Class ImmunitiesCollection
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    ' Damage Immunities
    Public Property Damage As New DmgCollection(Of eImmunitiesModifier)()

    ' Condition Immunities
    Public Property Conditions As New ConditionCollection(Of eImmunitiesModifier)()
#End Region

#Region "Init"
    Public Sub New()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
