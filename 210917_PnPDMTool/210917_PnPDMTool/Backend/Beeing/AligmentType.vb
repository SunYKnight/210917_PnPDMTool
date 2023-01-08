Public Class AligmentType

#Region "Enum"
    Enum EPersonality
        Lawful = 1
        Neutral = 0
        Chaotic = -1
    End Enum

    Enum EBehaviour
        Good = 1
        Neutral = 0
        Evil = -1
    End Enum
#End Region
#Region "Private Var"

#End Region

#Region "Properties"
    Public Property Personality As EPersonality = EPersonality.Neutral
    Public Property Behaviour As EBehaviour = EBehaviour.Neutral
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
