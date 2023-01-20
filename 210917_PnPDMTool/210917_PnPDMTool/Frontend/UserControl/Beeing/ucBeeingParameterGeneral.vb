Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports _210917_PnPDMTool.C
Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucBeeingParameterGeneral

#Region "Private Var"
#End Region

#Region "Properties"
    Public Property Beeing As BeeingType
#End Region

#Region "Init"

    Public Sub New(monster As BeeingType)

        Me.Beeing = monster

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Load Image
        Try
            Using fs As New System.IO.FileStream(Beeing.Image, IO.FileMode.Open)
                PictureBox_image.Image = New Bitmap(Image.FromStream(fs))
            End Using
        Catch ex As Exception
            If (Beeing.Image <> "") Then
                MsgBox(String.Format("Path not found:\n{0}", Beeing.Image))
            End If
            ' Reset Path
            Beeing.Image = ""
        End Try

        UcAttributCollection1.AttributeCollectionToEdit = Beeing.Attributs
        UcSavingThrowCollection1.SavingThrowCollectionToEdit = Beeing.SavingThrows
        UcSkillCollection1.SkillCollectionToEdit = Beeing.Skills

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Size
        ComboBox_Size.DataSource = System.Enum.GetValues(GetType(C.ESize))
        ' Monster Class
        ComboBox_monsterClass.DataSource = System.Enum.GetValues(GetType(C.eMonsterType))
        ' Aligment
        ComboBox_aligment_behaviour.DataSource = System.Enum.GetValues(GetType(AligmentType.EBehaviour))
        ' Condition
        ComboBox_condBlinded.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condCharmed.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condDeafened.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condExhaustion.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condFightended.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condGrappeled.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condIncapacitatated.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condInvisible.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condParalyzed.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condPoisoned.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condProne.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condRestrained.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condStunned.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_condUnconscious.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ' Dmg Type
        ComboBox_dmgAcid.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgBludgeoning.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgCold.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgFire.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgForce.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgLightning.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgMagical.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgNecrotic.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgPiercing.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgPoison.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgPsychic.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgRadiant.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgSlashing.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))
        ComboBox_dmgThunder.DataSource = System.Enum.GetValues(GetType(C.eImmunitiesModifier))

        ' Languages
        CheckedListBox_languages.CheckOnClick = True
        CheckedListBox_languages.Items.Clear()
        For Each language In System.Enum.GetValues(GetType(eLanguages))
            CheckedListBox_languages.Items.Add(language.ToString)
        Next
        For Each language In Beeing.Languages
            CheckedListBox_languages.SetItemChecked(language, True)
        Next

        ' Add datahandler
        AddHandler CheckedListBox_languages.ItemCheck, AddressOf CheckedListBox_languages_SelectedIndexChanged


        ' Update data
        UpdateDatabinding()

    End Sub

#End Region

#Region "Private Sub"


    Private Sub UpdateDatabinding()


        ' Name
        TextBox_name.DataBindings.Clear()
        TextBox_name.DataBindings.Add(New Binding("Text", Beeing, "Name"))

        ' Monster Class
        Dim cBmt As New ComboboxBinder(Of eMonsterType)(ComboBox_monsterClass, Beeing, "MonsterClass")

        ' Aligment
        Dim cBal As New ComboboxBinder(Of AligmentType.EBehaviour)(ComboBox_aligment_behaviour, Beeing.Aligment, "Behaviour")

        ' Size
        Dim cBsize As New ComboboxBinder(Of ESize)(ComboBox_Size, Beeing, "Size")

        ' AC
        NumericUpDown_AC.DataBindings.Clear()
        NumericUpDown_AC.DataBindings.Add(New Binding("Value", Beeing, "AC"))

        ' Proficency
        NumericUpDown_Proficency.DataBindings.Clear()
        NumericUpDown_Proficency.DataBindings.Add(New Binding("Value", Beeing, "Proficency"))

        ' Challenge
        NumericUpDown_challenge.DataBindings.Clear()
        NumericUpDown_challenge.DataBindings.Add(New Binding("Value", Beeing, "Challenge"))

        ' HP
        NumericUpDown_HpBonus.DataBindings.Clear()
        NumericUpDown_HpBonus.DataBindings.Add(New Binding("Value", Beeing, "HPBonus"))
        NumericUpDown_HpDiceD100.DataBindings.Clear()
        NumericUpDown_HpDiceD100.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD100.DiceCount"))
        NumericUpDown_HpDiceD20.DataBindings.Clear()
        NumericUpDown_HpDiceD20.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD20.DiceCount"))
        NumericUpDown_HpDiceD12.DataBindings.Clear()
        NumericUpDown_HpDiceD12.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD12.DiceCount"))
        NumericUpDown_HpDiceD8.DataBindings.Clear()
        NumericUpDown_HpDiceD8.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD8.DiceCount"))
        NumericUpDown_HpDiceD6.DataBindings.Clear()
        NumericUpDown_HpDiceD6.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD6.DiceCount"))
        NumericUpDown_HpDiceD4.DataBindings.Clear()
        NumericUpDown_HpDiceD4.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD4.DiceCount"))

        ' Speed
        NumericUpDown_speedBorrow.DataBindings.Clear()
        NumericUpDown_speedBorrow.DataBindings.Add(New Binding("Value", Beeing, "SpeedBurrowing"))
        NumericUpDown_speedClimb.DataBindings.Clear()
        NumericUpDown_speedClimb.DataBindings.Add(New Binding("Value", Beeing, "SpeedClimb"))
        NumericUpDown_speedFly.DataBindings.Clear()
        NumericUpDown_speedFly.DataBindings.Add(New Binding("Value", Beeing, "SpeedFlying"))
        NumericUpDown_speedSwim.DataBindings.Clear()
        NumericUpDown_speedSwim.DataBindings.Add(New Binding("Value", Beeing, "SpeedSwimming"))
        NumericUpDown_speedWalk.DataBindings.Clear()
        NumericUpDown_speedWalk.DataBindings.Add(New Binding("Value", Beeing, "SpeedWalk"))

        ' Dmg Effects
        Dim cBi1 As New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgAcid, Beeing.Immunities, "Damage.Acid")
        Dim cBi2 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgBludgeoning, Beeing.Immunities, "Damage.Bludgeoning")
        Dim cBi3 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgCold, Beeing.Immunities, "Damage.Cold")
        Dim cBi4 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgFire, Beeing.Immunities, "Damage.Fire")
        Dim cBi5 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgForce, Beeing.Immunities, "Damage.Force")
        Dim cBi6 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgLightning, Beeing.Immunities, "Damage.Lightning")
        Dim cBi7 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgMagical, Beeing.Immunities, "Damage.Magical")
        Dim cBi8 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgNecrotic, Beeing.Immunities, "Damage.Necrotic")
        Dim cBi9 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgPiercing, Beeing.Immunities, "Damage.Piercing")
        Dim cBi10 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgPoison, Beeing.Immunities, "Damage.Poison")
        Dim cBi11 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgPsychic, Beeing.Immunities, "Damage.Psychic")
        Dim cBi12 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgRadiant, Beeing.Immunities, "Damage.Radiant")
        Dim cBi13 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgSlashing, Beeing.Immunities, "Damage.Slashing")
        Dim cBi14 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_dmgThunder, Beeing.Immunities, "Damage.Thunder")

        ' Condition Effects
        Dim cBc1 As New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condBlinded, Beeing.Immunities, "Conditions.Blinded")
        Dim cBc2 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condCharmed, Beeing.Immunities, "Conditions.Charmed")
        Dim cBc3 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condDeafened, Beeing.Immunities, "Conditions.Deafened")
        Dim cBc4 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condExhaustion, Beeing.Immunities, "Conditions.Exhaustion")
        Dim cBc5 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condFightended, Beeing.Immunities, "Conditions.Fightended")
        Dim cBc6 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condGrappeled, Beeing.Immunities, "Conditions.Grappeled")
        Dim cBc7 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condIncapacitatated, Beeing.Immunities, "Conditions.Incapacitatated")
        Dim cBc8 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condInvisible, Beeing.Immunities, "Conditions.Invisible")
        Dim cBc9 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condParalyzed, Beeing.Immunities, "Conditions.Paralyzed")
        Dim cBc10 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condPoisoned, Beeing.Immunities, "Conditions.Poisoned")
        Dim cBc11 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condProne, Beeing.Immunities, "Conditions.Prone")
        Dim cBc12 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condRestrained, Beeing.Immunities, "Conditions.Restrained")
        Dim cBc13 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condStunned, Beeing.Immunities, "Conditions.Stunned")
        Dim cBc14 = New ComboboxBinder(Of eImmunitiesModifier)(ComboBox_condUnconscious, Beeing.Immunities, "Conditions.Unconscious")


    End Sub
#End Region

#Region "Pubilc Sub"

    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim labelSize = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Dim textBoxSize = New Size(WIDTH_TEXT_SMALL, HEIGHT_TEXT_BOX)


        '' Attributs
        'Me.UcAttributCollection1.Size = C.CalcRelativeSize(Me.Size, 0.25, 0.8, Me.UcAttributCollection1.MinimumSize)
        'Me.UcAttributCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcAttributCollection1.Size, 0.6, 0.85)

        'Me.UcSavingThrowCollection1.Size = C.CalcRelativeSize(Me.Size, 0.175, 0.2, Me.UcSavingThrowCollection1.MinimumSize)
        'Me.UcSavingThrowCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSavingThrowCollection1.Size, 0.6, 0.2)

        'Me.UcSkillCollection1.Size = C.CalcRelativeSize(Me.Size, 0.1, 0.7, Me.UcSkillCollection1.MinimumSize)
        'Me.UcSkillCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSkillCollection1.Size, 0.85, 0.5)

        'Me.TextBox_name.Location = C.CalcRelativeLocation(Me.Size, Me.TextBox_name.Size, 0.15, 0.1)
        'Me.ComboBox_Size.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_Size.Size, 0.15, 0.15)
        'Me.ComboBox_aligment_personality.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_aligment_personality.Size, 0.2, 0.15)
        'Me.ComboBox_aligment_behaviour.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_aligment_behaviour.Size, 0.2, 0.2)
        'Me.PictureBox_image.Location = C.CalcRelativeLocation(Me.Size, Me.PictureBox_image.Size, 0.15, 0.5)

    End Sub

    Private Sub PictureBox_image_Click(sender As Object, e As EventArgs) Handles PictureBox_image.DoubleClick
        Dim dialog As New OpenFileDialog()
        dialog.InitialDirectory = "data/Images"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New System.IO.FileInfo(dialog.FileName)
            Try
                Using fs As New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
                    PictureBox_image.Image = New Bitmap(Image.FromStream(fs))
                    Beeing.Image = fi.FullName
                End Using
            Catch ex As Exception
                Dim msg As String = "Filename: " & fi.FullName &
                    Environment.NewLine & Environment.NewLine &
                    "Exception: " & ex.ToString
                MessageBox.Show(msg, "Error Opening Image File")
            End Try
        End If

    End Sub

    Private Sub CheckedListBox_languages_SelectedIndexChanged(sender As Object, e As EventArgs)
        Beeing.Languages.Clear()
        For Each language In CheckedListBox_languages.CheckedIndices
            Beeing.Languages.Add(language)
        Next
    End Sub

#End Region

#Region "Events"

#End Region

End Class
