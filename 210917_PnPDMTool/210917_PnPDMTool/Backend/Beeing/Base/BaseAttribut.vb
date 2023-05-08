Public Class BaseAttribut

#Region "Enum"

#End Region

#Region "Private Var"
    Private _value As Integer
#End Region

#Region "Properties"

    Public ReadOnly Property Modifier As Integer
        Get
            Return (Value - 10) \ 2
        End Get
    End Property
    Public Property Value As Integer
        Get
            Return _value
        End Get
        Set(value As Integer)
            _value = value
        End Set
    End Property

#End Region

#Region "Init"
    Public Sub Init()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class
