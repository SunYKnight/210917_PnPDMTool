Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class DmgCollection(Of t)
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property Bludgeoning As t
    Public Property Piercing As t
    Public Property Slashing As t
    Public Property Acid As t
    Public Property Poison As t
    Public Property Fire As t
    Public Property Cold As t
    Public Property Force As t
    Public Property Lightning As t
    Public Property Thunder As t
    Public Property Necrotic As t
    Public Property Psychic As t
    Public Property Radiant As t
    Public Property Magical As t

#End Region
#Region "Init"
    Public Sub New(defaultValue As t)
        ' Set default value
        Bludgeoning = defaultValue
        Piercing = defaultValue
        Slashing = defaultValue
        Acid = defaultValue
        Poison = defaultValue
        Fire = defaultValue
        Cold = defaultValue
        Force = defaultValue
        Lightning = defaultValue
        Thunder = defaultValue
        Necrotic = defaultValue
        Psychic = defaultValue
        Radiant = defaultValue
        Magical = defaultValue
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
