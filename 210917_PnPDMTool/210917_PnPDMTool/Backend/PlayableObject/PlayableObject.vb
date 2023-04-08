Public Class PlayableObject
    'Grundeinstellungen der Opponents
    Inherits BeeingType

#Region "Private Var"
    Private _dmgRecvModifierType(System.Enum.GetValues(GetType(C.eDmgType)).Length) As C.eImmunitiesModifier


    Private _type As EBattleParticipentType

#End Region

#Region "Properties"
    Public Property Dices As New DiceCollection
    Public Property Proficencies As ProficencyCollection = New ProficencyCollection
    Public Property ID As Int64

#End Region

#Region "Init"
    Public Sub New(type As EBattleParticipentType)

        ' Call Parent
        MyBase.New()

        ' Generate ID
        ID = IdentificationNumber.GetNewID()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Overridable Function GetStrBonus() As Integer
        Return 0
    End Function
    Public Overridable Function GetDexBonus() As Integer
        Return 0
    End Function
    Public Overridable Function GetConBonus() As Integer
        Return 0
    End Function
    Public Overridable Function GetWisBonus() As Integer
        Return 0
    End Function
    Public Overridable Function GetIntBonus() As Integer
        Return 0
    End Function
    Public Overridable Function GetChaBonus() As Integer
        Return 0
    End Function
    Public Overridable Function GetACBonus() As Integer
        Return 0
    End Function
#End Region

#Region "Events"

#End Region
End Class
