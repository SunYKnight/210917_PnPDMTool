Imports _210917_PnPDMTool.C

Public Class UcOpponent

#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

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
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        'Title
        Me.lbOpponent.Size = New Size(Me.Width - gapSmall, heightTitle)
        Me.lbOpponent.Location = New Point(gapSmall, 0)

        'Abilities
        Me.lbStr.Size = New Size(widthTxtMedium, heightTxtBox)
        Me.lbDex.Size = Me.lbStr.Size
        Me.lbCon.Size = Me.lbStr.Size
        Me.lbWis.Size = Me.lbStr.Size
        Me.lbInt.Size = Me.lbStr.Size
        Me.lbCha.Size = Me.lbStr.Size
        Me.lbAc.Size = Me.lbStr.Size
        Me.txtStr.Size = New Size(widthTxtSmall, heightTxtBox)
        Me.txtDex.Size = Me.txtStr.Size
        Me.txtCon.Size = Me.txtStr.Size
        Me.txtWis.Size = Me.txtStr.Size
        Me.txtInt.Size = Me.txtStr.Size
        Me.txtCha.Size = Me.txtStr.Size
        Me.txtAc.Size = Me.txtStr.Size

        Me.lbStr.Location = New Point(gapSmall, heightTitle + gapMedium)
        Me.lbDex.Location = New Point(gapSmall, Me.lbStr.Location.Y + heightTxtBox + gapSmall)
        Me.lbCon.Location = New Point(gapSmall, Me.lbDex.Location.Y + heightTxtBox + gapSmall)
        Me.lbWis.Location = New Point(gapSmall, Me.lbCon.Location.Y + heightTxtBox + gapSmall)
        Me.lbInt.Location = New Point(gapSmall, Me.lbWis.Location.Y + heightTxtBox + gapSmall)
        Me.lbCha.Location = New Point(gapSmall, Me.lbInt.Location.Y + heightTxtBox + gapSmall)
        Me.lbAc.Location = New Point(gapSmall, Me.lbCha.Location.Y + heightTxtBox + gapSmall)
        Me.txtStr.Location = New Point(gapSmall + widthTxtMedium, Me.lbStr.Location.Y)
        Me.txtDex.Location = New Point(gapSmall + widthTxtMedium, Me.lbDex.Location.Y)
        Me.txtCon.Location = New Point(gapSmall + widthTxtMedium, Me.lbCon.Location.Y)
        Me.txtWis.Location = New Point(gapSmall + widthTxtMedium, Me.lbWis.Location.Y)
        Me.txtInt.Location = New Point(gapSmall + widthTxtMedium, Me.lbInt.Location.Y)
        Me.txtCha.Location = New Point(gapSmall + widthTxtMedium, Me.lbCha.Location.Y)
        Me.txtAc.Location = New Point(gapSmall + widthTxtMedium, Me.lbAc.Location.Y)

        'MP
        Me.lbMp.Size = New Size(widthTxtSmall + widthTxtMedium, heightTxtBox)
        Me.lbLv1.Size = Me.lbStr.Size
        Me.lbLv2.Size = Me.lbStr.Size
        Me.lbLv3.Size = Me.lbStr.Size
        Me.lbLv4.Size = Me.lbStr.Size
        Me.lbLv5.Size = Me.lbStr.Size
        Me.lbLv6.Size = Me.lbStr.Size
        Me.lbLv7.Size = Me.lbStr.Size
        Me.lbLv8.Size = Me.lbStr.Size
        Me.lbLv9.Size = Me.lbStr.Size
        Me.txtLv1.Size = Me.txtStr.Size
        Me.txtLv2.Size = Me.txtStr.Size
        Me.txtLv3.Size = Me.txtStr.Size
        Me.txtLv4.Size = Me.txtStr.Size
        Me.txtLv5.Size = Me.txtStr.Size
        Me.txtLv6.Size = Me.txtStr.Size
        Me.txtLv7.Size = Me.txtStr.Size
        Me.txtLv8.Size = Me.txtStr.Size
        Me.txtLv9.Size = Me.txtStr.Size

        Me.lbMp.Location = New Point(gapSmall, Me.lbAc.Location.Y + 2 * heightTxtBox + 2 * gapSmall)
        Me.lbLv1.Location = New Point(gapSmall, Me.lbMp.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv2.Location = New Point(gapSmall, Me.lbLv1.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv3.Location = New Point(gapSmall, Me.lbLv2.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv4.Location = New Point(gapSmall, Me.lbLv3.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv5.Location = New Point(gapSmall, Me.lbLv4.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv6.Location = New Point(gapSmall, Me.lbLv5.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv7.Location = New Point(gapSmall, Me.lbLv6.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv8.Location = New Point(gapSmall, Me.lbLv7.Location.Y + heightTxtBox + gapSmall)
        Me.lbLv9.Location = New Point(gapSmall, Me.lbLv8.Location.Y + heightTxtBox + gapSmall)
        Me.txtLv1.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv1.Location.Y)
        Me.txtLv2.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv2.Location.Y)
        Me.txtLv3.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv3.Location.Y)
        Me.txtLv4.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv4.Location.Y)
        Me.txtLv5.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv5.Location.Y)
        Me.txtLv6.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv6.Location.Y)
        Me.txtLv7.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv7.Location.Y)
        Me.txtLv8.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv8.Location.Y)
        Me.txtLv9.Location = New Point(gapSmall + widthTxtMedium, Me.lbLv9.Location.Y)

        'max. HP
        Me.lbMaxHp.Size = Me.lbMp.Size
        Me.lbNumber.Size = Me.lbStr.Size
        Me.lbDice.Size = Me.lbStr.Size
        Me.lbModifier.Size = Me.lbStr.Size
        Me.txtNumber.Size = Me.txtStr.Size
        Me.txtDice.Size = Me.txtStr.Size
        Me.txtModifier.Size = Me.txtStr.Size

        Me.lbMaxHp.Location = New Point(gapSmall, Me.lbLv9.Location.Y + 2 * heightTxtBox + 2 * gapSmall)
        Me.lbNumber.Location = New Point(gapSmall, Me.lbMaxHp.Location.Y + heightTxtBox + gapSmall)
        Me.lbDice.Location = New Point(gapSmall, Me.lbNumber.Location.Y + heightTxtBox + gapSmall)
        Me.lbModifier.Location = New Point(gapSmall, Me.lbDice.Location.Y + heightTxtBox + gapSmall)
        Me.txtNumber.Location = New Point(gapSmall + widthTxtMedium, Me.lbNumber.Location.Y)
        Me.txtDice.Location = New Point(gapSmall + widthTxtMedium, Me.lbDice.Location.Y)
        Me.txtModifier.Location = New Point(gapSmall + widthTxtMedium, Me.lbModifier.Location.Y)

        'Name, Image and Informations
        Me.lbName.Size = New Size(widthTxtBig, heightTxtBox)
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

        Me.lbName.Location = New Point(gapSmall + Me.lbMp.Width + 3 * gapBig, Me.lbStr.Location.Y)
        Me.lbEnvironment.Location = New Point(Me.lbName.Location.X, Me.lbDex.Location.Y)
        Me.lbImage.Location = New Point(Me.lbName.Location.X, Me.lbCon.Location.Y)

        Me.lbInformations.Location = New Point(Me.lbName.Location.X, Me.lbInt.Location.Y)
        Me.lbSavingThrows.Location = New Point(Me.lbName.Location.X, Me.lbCha.Location.Y)
        Me.lbProficiency.Location = New Point(Me.lbName.Location.X, Me.lbAc.Location.Y)
        Me.lbSkills.Location = New Point(Me.lbName.Location.X, Me.lbAc.Location.Y + heightTxtBox + gapSmall)
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
        Me.lbLegendaryResistance.Location = New Point(Me.lbName.Location.X, Me.lbLv9.Location.Y + heightTxtBox + gapSmall)
        Me.lbMagicResistance.Location = New Point(Me.lbName.Location.X, Me.lbMaxHp.Location.Y)
        Me.lbOthers.Location = New Point(Me.lbName.Location.X, Me.lbNumber.Location.Y)

        Me.txtName.Size = New Size(Me.Width - gapSmall - widthTxtSmall - widthTxtMedium - 3 * gapBig - widthTxtBig - gapSmall, heightTxtBox)
        Me.txtEnvironment.Size = Me.txtName.Size
        Me.txtImage.Size = Me.txtName.Size
        Me.txtSavingThrows.Size = Me.txtName.Size
        Me.txtProficiency.Size = Me.txtName.Size
        Me.txtSkills.Size = Me.txtName.Size
        Me.txtSenses.Size = Me.txtName.Size
        Me.txtLanguages.Size = Me.txtName.Size
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

        Me.txtName.Location = New Size(Me.lbName.Location.X + widthTxtBig, Me.lbName.Location.Y)
        Me.txtEnvironment.Location = New Size(Me.txtName.Location.X, Me.lbEnvironment.Location.Y)
        Me.txtImage.Location = New Size(Me.txtName.Location.X, Me.lbImage.Location.Y)
        Me.txtSavingThrows.Location = New Size(Me.txtName.Location.X, Me.lbSavingThrows.Location.Y)
        Me.txtProficiency.Location = New Size(Me.txtName.Location.X, Me.lbProficiency.Location.Y)
        Me.txtSkills.Location = New Size(Me.txtName.Location.X, Me.lbSkills.Location.Y)
        Me.txtSenses.Location = New Size(Me.txtName.Location.X, Me.lbSenses.Location.Y)
        Me.txtLanguages.Location = New Size(Me.txtName.Location.X, Me.lbLanguages.Location.Y)
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

        Me.txtOthers.Size = New Size(Me.txtName.Width, Me.Height - Me.lbOthers.Location.Y - 2 * gapSmall - heightButtons)
        Me.txtOthers.Location = New Point(Me.txtName.Location.X, Me.lbOthers.Location.Y)

        'Buttons
        Me.btnActions.Size = New Size(CInt((Me.Width / 2 - 3 * gapSmall - gapBig) / 4), heightButtons)
        Me.btnLegendaryActions.Size = Me.btnActions.Size
        Me.btnDiscard.Size = New Size(CInt(Me.btnActions.Width / 3 * 2), heightButtons)
        Me.btnSave.Size = Me.btnDiscard.Size

        Me.btnSave.Location = New Point(Me.Width - gapSmall - Me.btnSave.Width, Me.Height - heightButtons - gapSmall)
        Me.btnDiscard.Location = New Point(Me.Width - 2 * gapSmall - 2 * Me.btnSave.Width, Me.btnSave.Location.Y)
        Me.btnActions.Location = New Point(Me.txtOthers.Location.X, Me.btnSave.Location.Y)
        Me.btnLegendaryActions.Location = New Point(Me.txtOthers.Location.X + Me.btnActions.Width + gapSmall, Me.btnSave.Location.Y)
    End Sub
#End Region

#Region "Events"
    Public Event btnOpponentDiscardClicked()
    Public Event btnOpponentSaveClicked()
    Public Event btnOpponentActionsClicked()
    Public Event btnOpponentLegendaryActionsClicked()

#End Region
End Class
