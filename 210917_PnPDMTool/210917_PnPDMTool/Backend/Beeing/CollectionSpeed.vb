Imports _210917_PnPDMTool.C

Public Class SpeedCollection
#Region "Private Var"

#End Region


#Region "Properties"

    Public Property Walk As Integer = 0
    Public Property Fly As Integer = 0
    Public Property Burrow As Integer = 0
    Public Property Swim As Integer = 0
    Public Property Climb As Integer = 0
#End Region

#Region "Init"
    Public Sub Init()

    End Sub

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Shared Operator +(ByVal sc1 As SpeedCollection,
                             ByVal sc2 As SpeedCollection) As SpeedCollection
        ' Locals
        Dim sc As New SpeedCollection
        sc.Walk = sc1.Walk + sc2.Walk
        sc.Fly = sc1.Fly + sc2.Fly
        sc.Burrow = sc1.Burrow + sc2.Burrow
        sc.Swim = sc1.Swim + sc2.Swim
        sc.Climb = sc1.Climb + sc2.Climb
        Return sc
    End Operator

    Public Shared Operator -(ByVal sc1 As SpeedCollection,
                         ByVal sc2 As SpeedCollection) As SpeedCollection
        ' Locals
        Dim sc As New SpeedCollection
        sc.Walk = sc1.Walk - sc2.Walk
        sc.Fly = sc1.Fly - sc2.Fly
        sc.Burrow = sc1.Burrow - sc2.Burrow
        sc.Swim = sc1.Swim - sc2.Swim
        sc.Climb = sc1.Climb - sc2.Climb
        Return sc
    End Operator
#End Region

#Region "Events"

#End Region
End Class
