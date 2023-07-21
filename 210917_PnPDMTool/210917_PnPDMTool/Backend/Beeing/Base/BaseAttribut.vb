Public Class BaseAttribut

#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"

    Public ReadOnly Property Modifier As Integer
        Get
            Return (Value - 10) \ 2
        End Get
    End Property
    Public Property Value As Integer = 8

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
End Class
