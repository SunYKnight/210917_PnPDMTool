Public Class PlayableObject
    'Grundeinstellungen der Opponents

#Region "Private Var"

    Private _beeing As BeeingType
    Private _diceSet As New DiceSet
    Private _id As Long

    ' Initial rolls
    Private _rollInitative As Integer
    Private _rollHP As Integer

#End Region

#Region "Properties"

    Public Property BaseHP As Integer
        Get
            Return _rollHP + BonusHP
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property Initiative As Integer
        Get
            Return _rollInitative + ListDexterity.Last.Modifier
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property AC As Integer
        Get
            Return ListAC.Last.GetValue(ListStrength.Last.Modifier,
                                        ListDexterity.Last.Modifier,
                                        ListConstitution.Last.Modifier,
                                        ListIntelligence.Last.Modifier,
                                        ListWisdom.Last.Modifier,
                                        ListCharisma.Last.Modifier) + BonusAC
        End Get
        Set(value As Integer)

        End Set
    End Property

    ' Bonus
    Public Property BonusHP As Integer = 0
    Public Property BonusAC As Integer = 0
    Public Property BonusSpeed As SpeedCollection
    ' Lists
    Public Property ListAC As New List(Of BaseAC)
    Public Property ListStrength As New List(Of BaseAttribut)
    Public Property ListDexterity As New List(Of BaseAttribut)
    Public Property ListConstitution As New List(Of BaseAttribut)
    Public Property ListIntelligence As New List(Of BaseAttribut)
    Public Property ListWisdom As New List(Of BaseAttribut)
    Public Property ListCharisma As New List(Of BaseAttribut)
    Public Property ListSpeedBase As New List(Of SpeedCollection)

    ' Conditions
    Public Property ActiveConditions As New List(Of C.eCondidtion)


#End Region

#Region "Init"
    Public Sub New(beeing As BeeingType)

        ' Save parameter
        _beeing = beeing

        NewStatsAdd(_beeing.Stats)

        ' Generate Battle Paramter
        _rollHP = _beeing.HpDice.Evaluate(_diceSet, DiceType.EThrowType.Normal)
        _rollInitative = _diceSet.D20.Evaluate(1, DiceType.EThrowType.Normal)

        ' Generate ID
        _id = BaseIdentificationNumber.GetNewID()

    End Sub

#End Region

#Region "Private Sub"

    Private Sub GeneratePlayer()

    End Sub

    Private Sub GenerateNPC()

    End Sub

    Private Sub GenerateMonster()

    End Sub
    Private Sub NewStatsAdd(stats As CollectonStat)

        ' Check for nothing
        If (Not IsNothing(stats.AC)) Then
            ListAC.Add(stats.AC)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Strength)) Then
            ListStrength.Add(stats.Strength)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Dexterity)) Then
            ListDexterity.Add(stats.Dexterity)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Constitution)) Then
            ListConstitution.Add(stats.Constitution)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Intelligence)) Then
            ListIntelligence.Add(stats.Intelligence)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Wisdom)) Then
            ListWisdom.Add(stats.Wisdom)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Charisma)) Then
            ListCharisma.Add(stats.Charisma)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.SpeedBase)) Then
            ListSpeedBase.Add(stats.SpeedBase)
        End If

        ' Set base boni
        BonusHP += stats.BonusHP
        BonusAC += stats.BonusHP
        BonusSpeed += stats.BonusSpeed
    End Sub

    Private Sub NewStatsRemove(stats As CollectonStat)

        ' Check for nothing
        If (Not IsNothing(stats.AC)) Then
            ListAC.Remove(stats.AC)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Strength)) Then
            ListStrength.Remove(stats.Strength)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Dexterity)) Then
            ListDexterity.Remove(stats.Dexterity)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Constitution)) Then
            ListConstitution.Remove(stats.Constitution)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Intelligence)) Then
            ListIntelligence.Remove(stats.Intelligence)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Wisdom)) Then
            ListWisdom.Remove(stats.Wisdom)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.Charisma)) Then
            ListCharisma.Remove(stats.Charisma)
        End If

        ' Check for nothing
        If (Not IsNothing(stats.SpeedBase)) Then
            ListSpeedBase.Remove(stats.SpeedBase)
        End If

        ' Set base boni
        BonusHP -= stats.BonusHP
        BonusAC -= stats.BonusHP
        BonusSpeed -= stats.BonusSpeed
    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region
End Class
