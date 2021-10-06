Imports _210917_PnPDMTool.C

Public Class ucCharOverviewLeft
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

        Me.lbName.Size = New Size(newSize.Width - gapSmall, heightTitle)
        Me.btnActions.Size = New Size(CInt((newSize.Width - 3 * gapSmall) * 3 / 10), heightButtons)
        Me.btnLegendaryActions.Size = Me.btnActions.Size

        Me.txtAbilitiesTitle.Size = New Size(Me.btnActions.Width, heightSubTitle)
        Me.txtAbilities.Size = New Size(CInt(Me.txtAbilitiesTitle.Width / 3), heightTxt6)
        Me.txtAbilitiesModifier.Size = Me.txtAbilities.Size
        Me.txtAbilitiesScore.Size = New Size(Me.txtAbilitiesTitle.Width - 2 * Me.txtAbilities.Width, Me.txtAbilities.Height)

        Me.pictureBoxChar.Size = New Size(Me.btnActions.Width, newSize.Height - 4 * gapSmall - 2 * heightButtons - heightTxt6 - heightSubTitle - heightTitle)

        Me.txtMPLv1.Size = New Size(CInt((newSize.Width - 4 * gapSmall) / 18), heightTxt1)
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
        Me.txtMPTitle.Size = New Size(Me.txtMPLv1Title.Width * 9, heightSubTitle)

        Me.txtInfo1.Size = New Size(newSize.Width - Me.btnActions.Width - 3 * gapSmall, newSize.Height - heightTitle - 2 * gapSmall - 2 * heightTxt1 - heightSubTitle)

        Me.txtHPTitle.Size = New Size(CInt((Me.txtInfo1.Width - Me.txtMPTitle.Width - 2 * gapSmall) / 2), heightSubTitle)
        Me.txtHP.Size = New Size(Me.txtHPTitle.Width, 2 * heightTxt1)
        Me.TxtHPmax.Size = New Size(Me.txtHPTitle.Width, heightTxtSmall)
        Me.txtACTitle.Size = New Size(Me.txtInfo1.Width - Me.txtMPTitle.Width - Me.txtHPTitle.Width - 2 * gapSmall, 2 * heightTxt1)
        Me.txtAC.Size = New Size(Me.txtACTitle.Width, 2 * heightTxt1)

        Me.lbName.Location = New Point(gapSmall, 0)
        Me.pictureBoxChar.Location = New Point(gapSmall, heightTitle)
        Me.txtAbilitiesTitle.Location = New Point(gapSmall, heightTitle + Me.pictureBoxChar.Height + gapSmall)
        Me.txtAbilities.Location = New Point(gapSmall, Me.txtAbilitiesTitle.Location.Y + heightSubTitle)
        Me.txtAbilitiesScore.Location = New Point(gapSmall + Me.txtAbilities.Width, Me.txtAbilities.Location.Y)
        Me.txtAbilitiesModifier.Location = New Point(Me.txtAbilitiesScore.Location.X + Me.txtAbilitiesScore.Width, Me.txtAbilities.Location.Y)
        Me.btnActions.Location = New Point(gapSmall, newSize.Height - 2 * gapSmall - 2 * heightButtons)
        Me.btnLegendaryActions.Location = New Point(gapSmall, newSize.Height - gapSmall - heightButtons)
        Me.txtInfo1.Location = New Point(2 * gapSmall + Me.pictureBoxChar.Width, newSize.Height - gapSmall - Me.txtInfo1.Height)

        Me.txtMPTitle.Location = New Point(2 * gapSmall + Me.pictureBoxChar.Width, heightTitle)
        Me.txtMPLv1Title.Location = New Point(Me.txtMPTitle.Location.X, Me.txtMPTitle.Location.Y + heightSubTitle)
        Me.txtMPLv2Title.Location = New Point(Me.txtMPTitle.Location.X + Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv3Title.Location = New Point(Me.txtMPTitle.Location.X + 2 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv4Title.Location = New Point(Me.txtMPTitle.Location.X + 3 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv5Title.Location = New Point(Me.txtMPTitle.Location.X + 4 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv6Title.Location = New Point(Me.txtMPTitle.Location.X + 5 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv7Title.Location = New Point(Me.txtMPTitle.Location.X + 6 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv8Title.Location = New Point(Me.txtMPTitle.Location.X + 7 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv9Title.Location = New Point(Me.txtMPTitle.Location.X + 8 * Me.txtMPLv1.Width, Me.txtMPLv1Title.Location.Y)
        Me.txtMPLv1.Location = New Point(Me.txtMPLv1Title.Location.X, Me.txtMPLv1Title.Location.Y + heightTxt1)
        Me.txtMPLv2.Location = New Point(Me.txtMPLv2Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv3.Location = New Point(Me.txtMPLv3Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv4.Location = New Point(Me.txtMPLv4Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv5.Location = New Point(Me.txtMPLv5Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv6.Location = New Point(Me.txtMPLv6Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv7.Location = New Point(Me.txtMPLv7Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv8.Location = New Point(Me.txtMPLv8Title.Location.X, Me.txtMPLv1.Location.Y)
        Me.txtMPLv9.Location = New Point(Me.txtMPLv9Title.Location.X, Me.txtMPLv1.Location.Y)

        Me.txtACTitle.Location = New Point(3 * gapSmall + Me.pictureBoxChar.Width + Me.txtMPTitle.Width, heightTitle)
        Me.txtAC.Location = New Point(Me.txtACTitle.Location.X, Me.txtACTitle.Height + heightSubTitle)

        Me.txtHPTitle.Location = New Point(Me.txtACTitle.Location.X + gapSmall + Me.txtACTitle.Width, Me.txtACTitle.Location.Y)
        Me.txtHP.Location = New Point(Me.txtHPTitle.Location.X, Me.txtAC.Location.Y)
        Me.TxtHPmax.Location = New Point(Me.txtHPTitle.Location.X, Me.txtHP.Location.Y + 2 * heightTxt1 - heightTxtSmall)
    End Sub
#End Region

#Region "Events"

#End Region
End Class
