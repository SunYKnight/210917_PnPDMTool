Imports _210917_PnPDMTool.C

Public Class ucMonster

#Region "Private Var"
    Private _monsterToEdit As MonsterType
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()
        ' Create new instance
        _monsterToEdit = New MonsterType()

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub New(monster As MonsterType)
        ' Copy instance
        _monsterToEdit = monster

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        UcAttributCollection_opponent_edit.AttributeCollectionToEdit = _monsterToEdit.Attributs

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' comboBoxItem = New ComboBoxItemCheck()
        ' ComboBox_languages.Items.Add(comboBoxItem)
        'CheckedListBox_languages.DataSource = [Enum].GetNames(GetType(ELanguages))
    End Sub

#End Region

#Region "Private Sub"
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        RaiseEvent btnOpponentDiscardClicked()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaiseEvent btnOpponentSaveClicked()
    End Sub

    Private Sub btnActions_Click(sender As Object, e As EventArgs) Handles btnActions.Click
        RaiseEvent btnOpponentActionsClicked()
    End Sub

    Private Sub btnLegendaryActions_Click(sender As Object, e As EventArgs) Handles btnLegendaryActions.Click
        RaiseEvent btnOpponentLegendaryActionsClicked()
    End Sub
#End Region

#Region "Pubilc Sub"

    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim labelSize = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Dim textBoxSize = New Size(WIDTH_TEXT_SMALL, HEIGHT_TEXT_BOX)

        'Title
        Me.lbOpponent.Size = New Size(Me.Width - GAP_SMALL, HEIGHT_TITLE)
        Me.lbOpponent.Location = New Point(GAP_SMALL, 0)

        ' Attributs
        Me.UcAttributCollection_opponent_edit.Size = C.CalcRelativeSize(Me.Size, 0.1, 0.7)
        Me.UcAttributCollection_opponent_edit.Location = C.CalcRelativeLocation(Me.Size, Me.UcAttributCollection_opponent_edit.Size, 0.075, 0.45)



    End Sub

    Public Sub changeSize(newSize As Size)
        Me.Size = newSize
        Dim labelSize = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Dim textBoxSize = New Size(WIDTH_TEXT_SMALL, HEIGHT_TEXT_BOX)

        'MP
        Me.lbMp.Size = New Size(WIDTH_TEXT_SMALL + WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Me.lbLv1.Size = labelSize
        Me.lbLv2.Size = labelSize
        Me.lbLv3.Size = labelSize
        Me.lbLv4.Size = labelSize
        Me.lbLv5.Size = labelSize
        Me.lbLv6.Size = labelSize
        Me.lbLv7.Size = labelSize
        Me.lbLv8.Size = labelSize
        Me.lbLv9.Size = labelSize
        Me.txtLv1.Size = textBoxSize
        Me.txtLv2.Size = textBoxSize
        Me.txtLv3.Size = textBoxSize
        Me.txtLv4.Size = textBoxSize
        Me.txtLv5.Size = textBoxSize
        Me.txtLv6.Size = textBoxSize
        Me.txtLv7.Size = textBoxSize
        Me.txtLv8.Size = textBoxSize
        Me.txtLv9.Size = textBoxSize

        Me.lbMp.Location = New Point(GAP_SMALL, Me.lbAc.Location.Y + 2 * HEIGHT_TEXT_BOX + 2 * GAP_SMALL)
        Me.lbLv1.Location = New Point(GAP_SMALL, Me.lbMp.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv2.Location = New Point(GAP_SMALL, Me.lbLv1.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv3.Location = New Point(GAP_SMALL, Me.lbLv2.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv4.Location = New Point(GAP_SMALL, Me.lbLv3.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv5.Location = New Point(GAP_SMALL, Me.lbLv4.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv6.Location = New Point(GAP_SMALL, Me.lbLv5.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv7.Location = New Point(GAP_SMALL, Me.lbLv6.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv8.Location = New Point(GAP_SMALL, Me.lbLv7.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbLv9.Location = New Point(GAP_SMALL, Me.lbLv8.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.txtLv1.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv1.Location.Y)
        Me.txtLv2.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv2.Location.Y)
        Me.txtLv3.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv3.Location.Y)
        Me.txtLv4.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv4.Location.Y)
        Me.txtLv5.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv5.Location.Y)
        Me.txtLv6.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv6.Location.Y)
        Me.txtLv7.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv7.Location.Y)
        Me.txtLv8.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv8.Location.Y)
        Me.txtLv9.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbLv9.Location.Y)

        'max. HP
        Me.lbMaxHp.Size = labelSize
        Me.lbNumber.Size = labelSize
        Me.lbDice.Size = labelSize
        Me.lbModifier.Size = labelSize
        Me.txtNumber.Size = labelSize
        Me.txtDice.Size = labelSize
        Me.txtModifier.Size = labelSize

        Me.lbMaxHp.Location = New Point(GAP_SMALL, Me.lbLv9.Location.Y + 2 * HEIGHT_TEXT_BOX + 2 * GAP_SMALL)
        Me.lbNumber.Location = New Point(GAP_SMALL, Me.lbMaxHp.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbDice.Location = New Point(GAP_SMALL, Me.lbNumber.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbModifier.Location = New Point(GAP_SMALL, Me.lbDice.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.txtNumber.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbNumber.Location.Y)
        Me.txtDice.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbDice.Location.Y)
        Me.txtModifier.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbModifier.Location.Y)

        'Name, Image and Informations
        Me.lbName.Size = New Size(WIDTH_TEXT_BIG, HEIGHT_TEXT_BOX)
        Me.lbEnvironment.Size = Me.lbName.Size
        Me.lbInformations.Size = Me.lbName.Size
        Me.lbSavingThrows.Size = Me.lbName.Size
        Me.lbProficiency.Size = Me.lbName.Size
        Me.lbSkills.Size = Me.lbName.Size
        Me.lbSenses.Size = Me.lbName.Size
        Me.lbLanguages.Size = Me.lbName.Size
        Me.lbChallenge.Size = Me.lbName.Size
        Me.lbSpeed.Size = Me.lbName.Size
        Me.lbEffects.Size = Me.lbName.Size
        Me.lbDamageImmunities.Size = Me.lbName.Size
        Me.lbDamageResistance.Size = Me.lbName.Size
        Me.lbDamageVulnerabilities.Size = Me.lbName.Size
        Me.lbConditionImmunities.Size = Me.lbName.Size
        Me.lbConditionResistance.Size = Me.lbName.Size
        Me.lbLegendaryResistance.Size = Me.lbName.Size
        Me.lbMagicResistance.Size = Me.lbName.Size
        Me.lbOthers.Size = Me.lbName.Size

        'Me.lbName.Location = New Point(GAP_SMALL + Me.lbMp.Width + 3 * GAP_BIG, Me.lbStr.Location.Y)
        'Me.lbEnvironment.Location = New Point(Me.lbName.Location.X, Me.lbDex.Location.Y)
        'Me.lbImage.Location = New Point(Me.lbName.Location.X, Me.lbCon.Location.Y)

        'Me.lbInformations.Location = New Point(Me.lbName.Location.X, Me.lbInt.Location.Y)
        'Me.lbSavingThrows.Location = New Point(Me.lbName.Location.X, Me.lbCha.Location.Y)
        Me.lbProficiency.Location = New Point(Me.lbName.Location.X, Me.lbAc.Location.Y)
        Me.lbSkills.Location = New Point(Me.lbName.Location.X, Me.lbAc.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbSenses.Location = New Point(Me.lbName.Location.X, Me.lbMp.Location.Y)
        Me.lbLanguages.Location = New Point(Me.lbName.Location.X, Me.lbLv1.Location.Y)
        Me.lbChallenge.Location = New Point(Me.lbName.Location.X, Me.lbLv2.Location.Y)
        Me.lbSpeed.Location = New Point(Me.lbName.Location.X, Me.lbLv3.Location.Y)
        Me.lbEffects.Location = New Point(Me.lbName.Location.X, Me.lbLv4.Location.Y)
        Me.lbDamageImmunities.Location = New Point(Me.lbName.Location.X, Me.lbLv5.Location.Y)
        Me.lbDamageResistance.Location = New Point(Me.lbName.Location.X, Me.lbLv6.Location.Y)
        Me.lbDamageVulnerabilities.Location = New Point(Me.lbName.Location.X, Me.lbLv7.Location.Y)
        Me.lbConditionImmunities.Location = New Point(Me.lbName.Location.X, Me.lbLv8.Location.Y)
        Me.lbConditionResistance.Location = New Point(Me.lbName.Location.X, Me.lbLv9.Location.Y)
        Me.lbLegendaryResistance.Location = New Point(Me.lbName.Location.X, Me.lbLv9.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbMagicResistance.Location = New Point(Me.lbName.Location.X, Me.lbMaxHp.Location.Y)
        Me.lbOthers.Location = New Point(Me.lbName.Location.X, Me.lbNumber.Location.Y)

        Me.txtName.Size = New Size(Me.Width - GAP_SMALL - WIDTH_TEXT_SMALL - WIDTH_TEXT_MEDIUM - 3 * GAP_BIG - WIDTH_TEXT_BIG - GAP_SMALL, HEIGHT_TEXT_BOX)
        Me.txtEnvironment.Size = Me.txtName.Size
        Me.txtImage.Size = Me.txtName.Size
        Me.txtSavingThrows.Size = Me.txtName.Size
        Me.txtProficiency.Size = Me.txtName.Size
        Me.txtSkills.Size = Me.txtName.Size
        Me.txtSenses.Size = Me.txtName.Size
        ' Me.txtLanguages.Size = Me.txtName.Size
        Me.txtChallenge.Size = Me.txtName.Size
        Me.txtSpeed.Size = Me.txtName.Size
        Me.txtEffects.Size = Me.txtName.Size
        Me.txtDamageImmunities.Size = Me.txtName.Size
        Me.txtDamageResistance.Size = Me.txtName.Size
        Me.txtDamageVulnerabilities.Size = Me.txtName.Size
        Me.txtConditionImmunities.Size = Me.txtName.Size
        Me.txtConditionResistance.Size = Me.txtName.Size
        Me.txtLegendaryResistance.Size = Me.txtName.Size
        Me.txtMagicResistance.Size = Me.txtName.Size

        Me.txtName.Location = New Size(Me.lbName.Location.X + WIDTH_TEXT_BIG, Me.lbName.Location.Y)
        Me.txtEnvironment.Location = New Size(Me.txtName.Location.X, Me.lbEnvironment.Location.Y)
        Me.txtImage.Location = New Size(Me.txtName.Location.X, Me.lbImage.Location.Y)
        Me.txtSavingThrows.Location = New Size(Me.txtName.Location.X, Me.lbSavingThrows.Location.Y)
        Me.txtProficiency.Location = New Size(Me.txtName.Location.X, Me.lbProficiency.Location.Y)
        Me.txtSkills.Location = New Size(Me.txtName.Location.X, Me.lbSkills.Location.Y)
        Me.txtSenses.Location = New Size(Me.txtName.Location.X, Me.lbSenses.Location.Y)
        ' Me.txtLanguages.Location = New Size(Me.txtName.Location.X, Me.lbLanguages.Location.Y)
        Me.txtChallenge.Location = New Size(Me.txtName.Location.X, Me.lbChallenge.Location.Y)
        Me.txtSpeed.Location = New Size(Me.txtName.Location.X, Me.lbSpeed.Location.Y)
        Me.txtEffects.Location = New Size(Me.txtName.Location.X, Me.lbEffects.Location.Y)
        Me.txtDamageImmunities.Location = New Size(Me.txtName.Location.X, Me.lbDamageImmunities.Location.Y)
        Me.txtDamageResistance.Location = New Size(Me.txtName.Location.X, Me.lbDamageResistance.Location.Y)
        Me.txtDamageVulnerabilities.Location = New Size(Me.txtName.Location.X, Me.lbDamageVulnerabilities.Location.Y)
        Me.txtConditionImmunities.Location = New Size(Me.txtName.Location.X, Me.lbConditionImmunities.Location.Y)
        Me.txtConditionResistance.Location = New Size(Me.txtName.Location.X, Me.lbConditionResistance.Location.Y)
        Me.txtLegendaryResistance.Location = New Size(Me.txtName.Location.X, Me.lbLegendaryResistance.Location.Y)
        Me.txtMagicResistance.Location = New Size(Me.txtName.Location.X, Me.lbMagicResistance.Location.Y)

        Me.txtOthers.Size = New Size(Me.txtName.Width, Me.Height - Me.lbOthers.Location.Y - 2 * GAP_SMALL - HEIGHT_BUTTON)
        Me.txtOthers.Location = New Point(Me.txtName.Location.X, Me.lbOthers.Location.Y)

        'Buttons
        Me.btnActions.Size = New Size(CInt((Me.Width / 2 - 3 * GAP_SMALL - GAP_BIG) / 4), HEIGHT_BUTTON)
        Me.btnLegendaryActions.Size = Me.btnActions.Size
        Me.btnDiscard.Size = New Size(CInt(Me.btnActions.Width / 3 * 2), HEIGHT_BUTTON)
        Me.btnSave.Size = Me.btnDiscard.Size

        Me.btnSave.Location = New Point(Me.Width - GAP_SMALL - Me.btnSave.Width, Me.Height - HEIGHT_BUTTON - GAP_SMALL)
        Me.btnDiscard.Location = New Point(Me.Width - 2 * GAP_SMALL - 2 * Me.btnSave.Width, Me.btnSave.Location.Y)
        Me.btnActions.Location = New Point(Me.txtOthers.Location.X, Me.btnSave.Location.Y)
        Me.btnLegendaryActions.Location = New Point(Me.txtOthers.Location.X + Me.btnActions.Width + GAP_SMALL, Me.btnSave.Location.Y)
    End Sub

    Public Sub CreateNewOppenent()

    End Sub
#End Region

#Region "Events"
    Public Event btnOpponentDiscardClicked()
    Public Event btnOpponentSaveClicked()
    Public Event btnOpponentActionsClicked()
    Public Event btnOpponentLegendaryActionsClicked()



#End Region
End Class
