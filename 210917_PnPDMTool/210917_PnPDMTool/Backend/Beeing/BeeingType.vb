Public Class BeeingType
#Region "Private Var"

#End Region


#Region "Properties"
    Public Property Name As String = ""
    Public Property Image As String = ""
    Public Property Skills As SkillCollection = New SkillCollection
    Public Property SavingThrows As SavingThrowCollection = New SavingThrowCollection
    Public Property Attributs As AttributCollection = New AttributCollection
    Public Property Aligment As AligmentType = New AligmentType
    Public Property Size As ESize = ESize.Medium
    Public Property Speed As Integer
    Public Property AC As Integer
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
