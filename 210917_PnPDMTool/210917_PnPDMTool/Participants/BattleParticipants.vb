Public Class BattleParticipants(Of Participant As {ParticipantsCommon})
    'Characters die sich im Battle befinden

#Region "Private Var"
    Private _type As EBPType = EBPType.None
    Private _particitpant As Participant
#End Region

#Region "Properties"
    Public ReadOnly Property LiveStr As Int32
        Get
            Return _particitpant.BaseStr + _particitpant.GetStrBonus()
        End Get
    End Property
    Public ReadOnly Property LiveDex As Int32
        Get
            Return _particitpant.BaseDex + _particitpant.GetDexBonus()
        End Get
    End Property
    Public ReadOnly Property LiveCon As Int32
        Get
            Return _particitpant.BaseCon + _particitpant.GetConBonus()
        End Get
    End Property

    Public ReadOnly Property LiveWis As Int32
        Get
            Return _particitpant.BaseWis + _particitpant.GetWisBonus()
        End Get
    End Property
    Public ReadOnly Property LiveInt As Int32
        Get
            Return _particitpant.BaseInt + _particitpant.GetIntBonus()
        End Get
    End Property
    Public ReadOnly Property LiveCha As Int32
        Get
            Return _particitpant.BaseCha + _particitpant.GetChaBonus()
        End Get
    End Property
    Public ReadOnly Property LiveAC As Int32
        Get
            Return _particitpant.BaseAC + _particitpant.GetACBonus()
        End Get
    End Property
#End Region

#Region "Init"
    Public Sub New(type As EBPType, participant As Participant)

        ' Save Parameter
        Me._type = type
        Me._particitpant = participant

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class
