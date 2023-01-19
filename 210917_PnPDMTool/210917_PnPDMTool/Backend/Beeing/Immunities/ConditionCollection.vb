Public Class ConditionCollection(Of t)
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property Blinded As t
    Public Property Charmed As t
    Public Property Deafened As t
    Public Property Exhaustion As t
    Public Property Fightended As t
    Public Property Grappeled As t
    Public Property Incapacitatated As t
    Public Property Invisible As t
    Public Property Paralyzed As t
    Public Property Poisoned As t
    Public Property Prone As t
    Public Property Restrained As t
    Public Property Stunned As t
    Public Property Unconscious As t
#End Region

#Region "Init"
    Public Sub New(defaultValue As t)
        ' Set default value
        Blinded = defaultValue
        Charmed = defaultValue
        Deafened = defaultValue
        Exhaustion = defaultValue
        Fightended = defaultValue
        Grappeled = defaultValue
        Incapacitatated = defaultValue
        Invisible = defaultValue
        Paralyzed = defaultValue
        Poisoned = defaultValue
        Prone = defaultValue
        Restrained = defaultValue
        Stunned = defaultValue
        Unconscious = defaultValue
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
