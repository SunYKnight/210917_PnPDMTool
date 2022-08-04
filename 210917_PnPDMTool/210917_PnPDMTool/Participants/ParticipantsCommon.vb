Public Class ParticipantsCommon
    'Grundeinstellungen der Opponents

#Region "Private Var"
    Private _dmgRecvModifierType(C.EDmgType.Count) As C.EDmgTypeModifier

#End Region

#Region "Properties"

    Public Property Name As String
    Public Property Image As String
    Public Property BaseStr As Int32 = 5
    Public Property BaseDex As Int32 = 5
    Public Property BaseCon As Int32 = 5
    Public Property BaseWis As Int32 = 5
    Public Property BaseInt As Int32 = 5
    Public Property BaseCha As Int32 = 5
    Public Property BaseAC As Int32 = 8

    Public Property Languages As C.ELanguages

    Public Property ID As Int64

#End Region

#Region "Init"
    Public Sub New()
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
