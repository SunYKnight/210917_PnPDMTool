Imports _210917_PnPDMTool.C

Public Class UcCharOverviewLeft
#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbName.Size = New Size(newSize.Width - GAP_SMALL, HEIGHT_TITLE)
        Me.btnActions.Size = New Size(CInt((newSize.Width - 3 * GAP_SMALL) * 3 / 10), HEIGHT_BUTTON)
        Me.btnLegendaryActions.Size = Me.btnActions.Size

        Me.txtAbilitiesTitle.Size = New Size(Me.btnActions.Width, HEIGHT_SUBTITLE)
        Me.txtAbilities.Size = New Size(CInt(Me.txtAbilitiesTitle.Width / 3), HEIGHT_TEXT_6)
        Me.txtAbilitiesModifier.Size = Me.txtAbilities.Size
        Me.txtAbilitiesScore.Size = New Size(Me.txtAbilitiesTitle.Width - 2 * Me.txtAbilities.Width, Me.txtAbilities.Height)

        Me.pictureBoxChar.Size = New Size(Me.btnActions.Width, newSize.Height - 4 * GAP_SMALL - 2 * HEIGHT_BUTTON - HEIGHT_TEXT_6 - HEIGHT_SUBTITLE - HEIGHT_TITLE)

        Me.txtMPLv1.Size = New Size(CInt((newSize.Width - 4 * GAP_SMALL) / 18), HEIGHT_TEXT_1)
        Me.txtMPLv2.Size = Me.txtMPLv1.Size
        Me.txtMPLv3.Size = Me.txtMPLv1.Size
        Me.txtMPLv4.Size = Me.txtMPLv1.Size
        Me.txtMPLv5.Size = Me.txtMPLv1.Size
        Me.txtMPLv6.Size = Me.txtMPLv1.Size
        Me.txtMPLv7.Size = Me.txtMPLv1.Size
        Me.txtMPLv8.Size = Me.txtMPLv1.Size
        Me.txtMPLv9.Size = Me.txtMPLv1.Size
        Me.txtMPLv1Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv2Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv3Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv4Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv5Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv6Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv7Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv8Title.Size = Me.txtMPLv1.Size
        Me.txtMPLv9Title.Size = Me.txtMPLv1.Size
        Me.txtMPTitle.Size = New Size(Me.txtMPLv1Title.Width * 9, HEIGHT_SUBTITLE)

        Me.txtInfo1.Size = New Size(newSize.Width - Me.btnActions.Width - 3 * GAP_SMALL, newSize.Height - HEIGHT_TITLE - 2 * GAP_SMALL - 2 * HEIGHT_TEXT_1 - HEIGHT_SUBTITLE)

        Me.txtHPTitle.Size = New Size(CInt((Me.txtInfo1.Width - Me.txtMPTitle.Width - 2 * GAP_SMALL) / 2), HEIGHT_SUBTITLE)
        Me.txtHP.Size = New Size(Me.txtHPTitle.Width, 2 * HEIGHT_TEXT_1)
        Me.TxtHPmax.Size = New Size(Me.txtHPTitle.Width, HEIGHT_TEXT_SMALL)
        Me.txtACTitle.Size = New Size(Me.txtInfo1.Width - Me.txtMPTitle.Width - Me.txtHPTitle.Width - 2 * GAP_SMALL, 2 * HEIGHT_TEXT_1)
        Me.txtAC.Size = New Size(Me.txtACTitle.Width, 2 * HEIGHT_TEXT_1)

        Me.lbName.Location = New Point(GAP_SMALL, 0)
        Me.pictureBoxChar.Location = New Point(GAP_SMALL, HEIGHT_TITLE)
        Me.txtAbilitiesTitle.Location = New Point(GAP_SMALL, HEIGHT_TITLE + Me.pictureBoxChar.Height + GAP_SMALL)
        Me.txtAbilities.Location = New Point(GAP_SMALL, Me.txtAbilitiesTitle.Location.Y + HEIGHT_SUBTITLE)
        Me.txtAbilitiesScore.Location = New Point(GAP_SMALL + Me.txtAbilities.Width, Me.txtAbilities.Location.Y)
        Me.txtAbilitiesModifier.Location = New Point(Me.txtAbilitiesScore.Location.X + Me.txtAbilitiesScore.Width, Me.txtAbilities.Location.Y)
        Me.btnActions.Location = New Point(GAP_SMALL, newSize.Height - 2 * GAP_SMALL - 2 * HEIGHT_BUTTON)
        Me.btnLegendaryActions.Location = New Point(GAP_SMALL, newSize.Height - GAP_SMALL - HEIGHT_BUTTON)
        Me.txtInfo1.Location = New Point(2 * GAP_SMALL + Me.pictureBoxChar.Width, newSize.Height - GAP_SMALL - Me.txtInfo1.Height)

        Me.txtMPTitle.Location = New Point(2 * GAP_SMALL + Me.pictureBoxChar.Width, HEIGHT_TITLE)
        Me.txtMPLv1Title.Location = New Point(Me.txtMPTitle.Location.X, Me.txtMPTitle.Location.Y + HEIGHT_SUBTITLE)
        Me.txtMPLv2Title.Location = New Point(Me.txtMPTitle.Location.X + Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv3Title.Location = New Point(Me.txtMPTitle.Location.X + 2 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv4Title.Location = New Point(Me.txtMPTitle.Location.X + 3 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv5Title.Location = New Point(Me.txtMPTitle.Location.X + 4 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv6Title.Location = New Point(Me.txtMPTitle.Location.X + 5 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv7Title.Location = New Point(Me.txtMPTitle.Location.X + 6 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv8Title.Location = New Point(Me.txtMPTitle.Location.X + 7 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv9Title.Location = New Point(Me.txtMPTitle.Location.X + 8 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv1.Location = New Point(Me.txtMPLv1Title.Location.X, Me.txtMPLv1Title.Location.Y + HEIGHT_TEXT_1)
        Me.txtMPLv2.Location = New Point(Me.txtMPLv2Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv3.Location = New Point(Me.txtMPLv3Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv4.Location = New Point(Me.txtMPLv4Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv5.Location = New Point(Me.txtMPLv5Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv6.Location = New Point(Me.txtMPLv6Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv7.Location = New Point(Me.txtMPLv7Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv8.Location = New Point(Me.txtMPLv8Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv9.Location = New Point(Me.txtMPLv9Title.Location.X, Me.txtMPLv1.Location.Y)

        Me.txtACTitle.Location = New Point(3 * GAP_SMALL + Me.pictureBoxChar.Width + Me.txtMPTitle.Width, HEIGHT_TITLE)
        Me.txtAC.Location = New Point(Me.txtACTitle.Location.X, Me.txtACTitle.Height + HEIGHT_SUBTITLE)

        Me.txtHPTitle.Location = New Point(Me.txtACTitle.Location.X + GAP_SMALL + Me.txtACTitle.Width, Me.txtACTitle.Location.Y)
        Me.txtHP.Location = New Point(Me.txtHPTitle.Location.X, Me.txtAC.Location.Y)
        Me.TxtHPmax.Location = New Point(Me.txtHPTitle.Location.X, Me.txtHP.Location.Y + 2 * HEIGHT_TEXT_1 - HEIGHT_TEXT_SMALL)
    End Sub

    Private Sub btnLegendaryActions_Click(sender As Object, e As EventArgs) Handles btnLegendaryActions.Click

    End Sub
#End Region

#Region "Events"

#End Region
End Class
