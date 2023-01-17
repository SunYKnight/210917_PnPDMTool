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

        UcAttributCollection1.AttributeCollectionToEdit = Beeing.Attributs
        UcSavingThrowCollection1.SavingThrowCollectionToEdit = Beeing.SavingThrows
        UcSkillCollection1.SkillCollectionToEdit = Beeing.Skills

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        ComboBox_Size.DataSource = System.Enum.GetValues(GetType(C.ESize))
        ComboBox_monsterClass.DataSource = System.Enum.GetValues(GetType(C.eMonsterType))
        ' Condition
        ComboBox_condBlinded.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condCharmed.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condDeafened.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condExhaustion.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condFightended.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condGrappeled.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condIncapacitatated.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condInvisible.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condParalyzed.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condPoisoned.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condProne.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condRestrained.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condStunned.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_condUnconscious.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ' Dmg Type
        ComboBox_dmgAcid.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgBludgeoning.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgCold.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgFire.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgForce.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgLightning.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgMagical.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgNecrotic.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgPiercing.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgPoison.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgPsychic.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgRadiant.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgSlashing.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ComboBox_dmgThunder.DataSource = System.Enum.GetValues(GetType(C.eDmgTypeModifier))
        ' Monster Class
        ComboBox_monsterClass.DataSource = System.Enum.GetValues(GetType(C.eMonsterType))


        ' Update data
        UpdateDatabinding()

        ' comboBoxItem = New ComboBoxItemCheck()
        ' ComboBox_languages.Items.Add(comboBoxItem)
        'CheckedListBox_languages.DataSource = [Enum].GetNames(GetType(ELanguages))
    End Sub

#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding()
        ' Locals
        Dim dataSrc = System.Enum.GetNames(GetType(eAttributes))

        ' Name
        TextBox_name.DataBindings.Clear()
        TextBox_name.DataBindings.Add(New Binding("Text", Beeing, "Name"))

        ' Image
        PictureBox_image.DataBindings.Clear()
        PictureBox_image.DataBindings.Add("ImageLocation", Beeing, "Image", True)

        ' Monster Class
        ComboBox_monsterClass.DataBindings.Clear()
        ComboBox_monsterClass.DataBindings.Add(New Binding("SelectedIndex", Beeing, "MonsterClass"))

        ' Aligment
        ComboBox_aligment_behaviour.DataBindings.Clear()
        ComboBox_aligment_behaviour.DataBindings.Add(New Binding("Text", Beeing.Aligment, "Behaviour"))

        ' Size
        ComboBox_Size.DataBindings.Clear()
        ComboBox_Size.DataBindings.Add(New Binding("SelectedIndex", Beeing, "Size"))

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
        ComboBox_dmgAcid.DataBindings.Clear()
        ComboBox_dmgAcid.DataBindings.Add(New Binding("Value", Beeing, "DmgImmunities(0)", True))


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
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New System.IO.FileInfo(dialog.FileName)
            Try
                Using fs As New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
                    PictureBox_image.Image = New Bitmap(Image.FromStream(fs))
                End Using
            Catch ex As Exception
                Dim msg As String = "Filename: " & fi.FullName &
                    Environment.NewLine & Environment.NewLine &
                    "Exception: " & ex.ToString
                MessageBox.Show(msg, "Error Opening Image File")
            End Try
        End If

    End Sub


#End Region

#Region "Events"

#End Region

End Class
