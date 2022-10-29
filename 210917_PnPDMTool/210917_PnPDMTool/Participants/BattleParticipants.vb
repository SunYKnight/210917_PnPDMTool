Public Class BattleParticipants(Of t As {PlayableObject})
    'Characters die sich im Battle befinden

#Region "Private Var"

    Private _participent As t

#End Region

#Region "Properties"
    Public ReadOnly Property LiveStr As Int32
        Get
            Return _participent.Attributs.Strength.Value + _participent.GetStrBonus()
        End Get
    End Property
    Public ReadOnly Property LiveDex As Int32
        Get
            Return _participent.Attributs.Dexterity.Value + _participent.GetDexBonus()
        End Get
    End Property
    Public ReadOnly Property LiveCon As Int32
        Get
            Return _participent.Attributs.Constitution.Value + _participent.GetConBonus()
        End Get
    End Property

    Public ReadOnly Property LiveWis As Int32
        Get
            Return _participent.Attributs.Wisdom.Value + _participent.GetWisBonus()
        End Get
    End Property
    Public ReadOnly Property LiveInt As Int32
        Get
            Return _participent.Attributs.Intelligence.Value + _participent.GetIntBonus()
        End Get
    End Property
    Public ReadOnly Property LiveCha As Int32
        Get
            Return _participent.Attributs.Charisma.Value + _participent.GetChaBonus()
        End Get
    End Property
    Public ReadOnly Property LiveAC As Int32
        Get
            Return 0
        End Get
    End Property
#End Region

#Region "Init"
    Public Sub New(participent As t)
        ' Save data
        Me._participent = participent
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class
