Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size
    Dim widthRatio As Single
    Dim heightRatio As Single

    Dim gapSmall As Int32 = 6
    Dim gapMedium As Int32 = 12
    Dim gapBig As Int32 = 18

    Dim heightButtons As Int32 = 30
    Dim heightLables As Int32 = 40
    Dim heightTitles As Int32 = 25
    Dim heightTxt1 As Int32 = 20
    Dim heightTxt6 As Int32 = 120
    Dim heightTxtSmall As Int32 = 15
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub Init()
        InitializeComponent()
    End Sub
#End Region

#Region "Private Sub"
    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.Size.Width < Me.MinimumSize.Width Then
            Me.Size = New Size(Me.MinimumSize.Width, Me.Size.Height)
        End If

        If Me.Size.Height < Me.MinimumSize.Height Then
            Me.Size = New Size(Me.Size.Width, Me.MinimumSize.Height)
        End If
        innerSize = New Size(Me.Size.Width - 15, Me.Size.Height - 39)

        changeSizeAndPositionOfPanels()
        changeSizeofUcBattleView()
        changeSizeOfUcOpponentsView()
        changeSizeOfUcCharOverviewLeft()
        changeSizeOfUcCharOverviewRight()
        changeSizeOfUcMapView()
    End Sub

    Private Sub changeSizeAndPositionOfPanels()
        pnlBattleView.Size = New Size(CInt((innerSize.Width - 3 * gapMedium - gapBig) / 6), CInt((innerSize.Height - 3 * gapMedium) / 2))
        pnlOpponentsView.Size = pnlBattleView.Size
        pnlCharOverviewLeft.Size = New Size(2 * pnlBattleView.Width + gapMedium, innerSize.Height - 3 * gapMedium - pnlBattleView.Height)
        pnlCharOverviewRight.Size = New Size(innerSize.Width - 2 * gapMedium - pnlCharOverviewLeft.Width, CInt((innerSize.Height - 2 * gapMedium - gapBig) / 6))
        pnlMapView.Size = New Size(pnlCharOverviewRight.Width - gapBig, innerSize.Height - 2 * gapMedium - gapBig - pnlCharOverviewRight.Height)

        pnlBattleView.Location = New Point(gapMedium, gapMedium)
        pnlOpponentsView.Location = New Point(2 * gapMedium + pnlBattleView.Width, gapMedium)
        pnlCharOverviewLeft.Location = New Point(gapMedium, 2 * gapMedium + pnlBattleView.Height)
        pnlCharOverviewRight.Location = New Point(gapMedium + pnlCharOverviewLeft.Width, gapMedium + gapBig + pnlMapView.Height)
        pnlMapView.Location = New Point(2 * gapMedium + gapBig + 2 * pnlBattleView.Width, gapMedium)
    End Sub

    Private Sub changeSizeofUcBattleView()
        ucBattleView1.Size = pnlBattleView.Size

        ucBattleView1.lbBattle.Size = New Size(pnlBattleView.Width, heightLables)
        ucBattleView1.btnRemove.Size = New Size(CInt((pnlBattleView.Width - 4 * gapSmall) / 3), heightButtons)
        ucBattleView1.btnEndBattle.Size = ucBattleView1.btnRemove.Size
        ucBattleView1.btnNext.Size = New Size(pnlBattleView.Width - 4 * gapSmall - 2 * ucBattleView1.btnRemove.Width, heightButtons)
        ucBattleView1.listViewBattle.Size = New Size(pnlBattleView.Width - 2 * gapSmall, pnlBattleView.Height - 2 * gapSmall - heightButtons - heightLables)

        ucBattleView1.lbBattle.Location = New Point(0, 0)
        ucBattleView1.btnRemove.Location = New Point(gapSmall, pnlBattleView.Height - gapSmall - heightButtons)
        ucBattleView1.btnNext.Location = New Point(2 * gapSmall + ucBattleView1.btnRemove.Width, pnlBattleView.Height - gapSmall - heightButtons)
        ucBattleView1.btnEndBattle.Location = New Point(3 * gapSmall + ucBattleView1.btnEndBattle.Width + ucBattleView1.btnRemove.Width, pnlBattleView.Height - gapSmall - heightButtons)
        ucBattleView1.listViewBattle.Location = New Point(gapSmall, heightLables)
    End Sub

    Private Sub changeSizeOfUcOpponentsView()
        ucOpponentsView1.Size = pnlOpponentsView.Size

        ucOpponentsView1.lbOpponents.Size = New Size(pnlOpponentsView.Width, heightLables)
        ucOpponentsView1.btnAddToBattle.Size = New Size(CInt((pnlOpponentsView.Width - 4 * gapSmall) / 3), heightButtons)
        ucOpponentsView1.btnEdit.Size = ucOpponentsView1.btnAddToBattle.Size
        ucOpponentsView1.btnNew.Size = New Size(pnlOpponentsView.Width - 4 * gapSmall - 2 * ucOpponentsView1.btnAddToBattle.Width, heightButtons)
        ucOpponentsView1.listViewOpponents.Size = New Size(pnlOpponentsView.Width - 2 * gapSmall, pnlOpponentsView.Height - 2 * gapSmall - heightButtons - heightLables)

        ucOpponentsView1.lbOpponents.Location = New Point(0, 0)
        ucOpponentsView1.btnAddToBattle.Location = New Point(gapSmall, pnlOpponentsView.Height - gapSmall - heightButtons)
        ucOpponentsView1.btnNew.Location = New Point(2 * gapSmall + ucOpponentsView1.btnAddToBattle.Width, pnlBattleView.Height - gapSmall - heightButtons)
        ucOpponentsView1.btnEdit.Location = New Point(3 * gapSmall + ucOpponentsView1.btnNew.Width + ucOpponentsView1.btnAddToBattle.Width, pnlOpponentsView.Height - gapSmall - heightButtons)
        ucOpponentsView1.listViewOpponents.Location = New Point(gapSmall, heightLables)
    End Sub

    Private Sub changeSizeOfUcCharOverviewLeft()
        ucCharOverviewLeft1.Size = pnlCharOverviewLeft.Size

        ucCharOverviewLeft1.lbName.Size = New Size(pnlCharOverviewLeft.Width, heightLables)
        ucCharOverviewLeft1.btnActions.Size = New Size(CInt((pnlCharOverviewLeft.Width - 3 * gapSmall) * 3 / 10), heightButtons)
        ucCharOverviewLeft1.btnLegendaryActions.Size = ucCharOverviewLeft1.btnActions.Size

        ucCharOverviewLeft1.txtAbilitiesTitle.Size = New Size(ucCharOverviewLeft1.btnActions.Width, heightTitles)
        ucCharOverviewLeft1.txtAbilities.Size = New Size(CInt(ucCharOverviewLeft1.txtAbilitiesTitle.Width / 3), heightTxt6)
        ucCharOverviewLeft1.txtAbilitiesModifier.Size = ucCharOverviewLeft1.txtAbilities.Size
        ucCharOverviewLeft1.txtAbilitiesScore.Size = New Size(ucCharOverviewLeft1.txtAbilitiesTitle.Width - 2 * ucCharOverviewLeft1.txtAbilities.Width, ucCharOverviewLeft1.txtAbilities.Height)

        ucCharOverviewLeft1.pictureBoxChar.Size = New Size(ucCharOverviewLeft1.btnActions.Width, pnlCharOverviewLeft.Height - 4 * gapSmall - 2 * heightButtons - heightTxt6 - heightTitles - heightLables)

        ucCharOverviewLeft1.txtMPLv1.Size = New Size(CInt((pnlCharOverviewLeft.Width - 4 * gapSmall) / 18), heightTxt1)
        ucCharOverviewLeft1.txtMPLv2.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv3.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv4.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv5.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv6.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv7.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv8.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv9.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv1Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv2Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv3Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv4Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv5Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv6Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv7Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv8Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPLv9Title.Size = ucCharOverviewLeft1.txtMPLv1.Size
        ucCharOverviewLeft1.txtMPTitle.Size = New Size(ucCharOverviewLeft1.txtMPLv1Title.Width * 9, heightTitles)

        ucCharOverviewLeft1.txtInfo1.Size = New Size(pnlCharOverviewLeft.Width - ucCharOverviewLeft1.btnActions.Width - 3 * gapSmall, pnlCharOverviewLeft.Height - heightLables - 2 * gapSmall - 2 * heightTxt1 - heightTitles)

        ucCharOverviewLeft1.txtHPTitle.Size = New Size(CInt((ucCharOverviewLeft1.txtInfo1.Width - ucCharOverviewLeft1.txtMPTitle.Width - 2 * gapSmall) / 2), heightTitles)
        ucCharOverviewLeft1.txtHP.Size = New Size(ucCharOverviewLeft1.txtHPTitle.Width, 2 * heightTxt1)
        ucCharOverviewLeft1.TxtHPmax.Size = New Size(ucCharOverviewLeft1.txtHPTitle.Width, heightTxtSmall)
        ucCharOverviewLeft1.txtACTitle.Size = New Size(ucCharOverviewLeft1.txtInfo1.Width - ucCharOverviewLeft1.txtMPTitle.Width - ucCharOverviewLeft1.txtHPTitle.Width - 2 * gapSmall, 2 * heightTxt1)
        ucCharOverviewLeft1.txtAC.Size = New Size(ucCharOverviewLeft1.txtACTitle.Width, 2 * heightTxt1)

        ucCharOverviewLeft1.lbName.Location = New Point(gapSmall, 0)
        ucCharOverviewLeft1.pictureBoxChar.Location = New Point(gapSmall, heightLables)
        ucCharOverviewLeft1.txtAbilitiesTitle.Location = New Point(gapSmall, heightLables + ucCharOverviewLeft1.pictureBoxChar.Height + gapSmall)
        ucCharOverviewLeft1.txtAbilities.Location = New Point(gapSmall, ucCharOverviewLeft1.txtAbilitiesTitle.Location.Y + heightTitles)
        ucCharOverviewLeft1.txtAbilitiesScore.Location = New Point(gapSmall + ucCharOverviewLeft1.txtAbilities.Width, ucCharOverviewLeft1.txtAbilities.Location.Y)
        ucCharOverviewLeft1.txtAbilitiesModifier.Location = New Point(ucCharOverviewLeft1.txtAbilitiesScore.Location.X + ucCharOverviewLeft1.txtAbilitiesScore.Width, ucCharOverviewLeft1.txtAbilities.Location.Y)
        ucCharOverviewLeft1.btnActions.Location = New Point(gapSmall, pnlCharOverviewLeft.Height - 2 * gapSmall - 2 * heightButtons)
        ucCharOverviewLeft1.btnLegendaryActions.Location = New Point(gapSmall, pnlCharOverviewLeft.Height - gapSmall - heightButtons)
        ucCharOverviewLeft1.txtInfo1.Location = New Point(2 * gapSmall + ucCharOverviewLeft1.pictureBoxChar.Width, pnlCharOverviewLeft.Height - gapSmall - ucCharOverviewLeft1.txtInfo1.Height)

        ucCharOverviewLeft1.txtMPTitle.Location = New Point(2 * gapSmall + ucCharOverviewLeft1.pictureBoxChar.Width, heightLables)
        ucCharOverviewLeft1.txtMPLv1Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X, ucCharOverviewLeft1.txtMPTitle.Location.Y + heightTitles)
        ucCharOverviewLeft1.txtMPLv2Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv3Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + 2 * ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv4Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + 3 * ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv5Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + 4 * ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv6Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + 5 * ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv7Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + 6 * ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv8Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + 7 * ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv9Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X + 8 * ucCharOverviewLeft1.txtMPLv1.Width, ucCharOverviewLeft1.txtMPLv1Title.Location.Y)
        ucCharOverviewLeft1.txtMPLv1.Location = New Point(ucCharOverviewLeft1.txtMPLv1Title.Location.X, ucCharOverviewLeft1.txtMPLv1Title.Location.Y + heightTxt1)
        ucCharOverviewLeft1.txtMPLv2.Location = New Point(ucCharOverviewLeft1.txtMPLv2Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)
        ucCharOverviewLeft1.txtMPLv3.Location = New Point(ucCharOverviewLeft1.txtMPLv3Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)
        ucCharOverviewLeft1.txtMPLv4.Location = New Point(ucCharOverviewLeft1.txtMPLv4Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)
        ucCharOverviewLeft1.txtMPLv5.Location = New Point(ucCharOverviewLeft1.txtMPLv5Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)
        ucCharOverviewLeft1.txtMPLv6.Location = New Point(ucCharOverviewLeft1.txtMPLv6Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)
        ucCharOverviewLeft1.txtMPLv7.Location = New Point(ucCharOverviewLeft1.txtMPLv7Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)
        ucCharOverviewLeft1.txtMPLv8.Location = New Point(ucCharOverviewLeft1.txtMPLv8Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)
        ucCharOverviewLeft1.txtMPLv9.Location = New Point(ucCharOverviewLeft1.txtMPLv9Title.Location.X, ucCharOverviewLeft1.txtMPLv1.Location.Y)

        ucCharOverviewLeft1.txtACTitle.Location = New Point(3 * gapSmall + ucCharOverviewLeft1.pictureBoxChar.Width + ucCharOverviewLeft1.txtMPTitle.Width, heightLables)
        ucCharOverviewLeft1.txtAC.Location = New Point(ucCharOverviewLeft1.txtACTitle.Location.X, ucCharOverviewLeft1.txtACTitle.Height + heightTitles)

        ucCharOverviewLeft1.txtHPTitle.Location = New Point(ucCharOverviewLeft1.txtACTitle.Location.X + gapSmall + ucCharOverviewLeft1.txtACTitle.Width, ucCharOverviewLeft1.txtACTitle.Location.Y)
        ucCharOverviewLeft1.txtHP.Location = New Point(ucCharOverviewLeft1.txtHPTitle.Location.X, ucCharOverviewLeft1.txtAC.Location.Y)
        ucCharOverviewLeft1.TxtHPmax.Location = New Point(ucCharOverviewLeft1.txtHPTitle.Location.X, ucCharOverviewLeft1.txtHP.Location.Y + 2 * heightTxt1 - heightTxtSmall)
    End Sub

    Private Sub changeSizeOfUcCharOverviewRight()
        ucCharOverviewRight1.Size = pnlCharOverviewRight.Size

        ucCharOverviewRight1.txtInfo2.Size = New Size(CInt((pnlCharOverviewRight.Width - 2 * gapSmall) / 3), pnlCharOverviewRight.Height - 2 * gapSmall)
        ucCharOverviewRight1.txtInfo3.Size = New Size(pnlCharOverviewRight.Width - ucCharOverviewRight1.txtInfo2.Width - 2 * gapSmall, ucCharOverviewRight1.txtInfo2.Height)

        ucCharOverviewRight1.txtInfo2.Location = New Point(0, gapSmall)
        ucCharOverviewRight1.txtInfo3.Location = New Point(ucCharOverviewRight1.txtInfo2.Width + gapSmall, gapSmall)
    End Sub

    Private Sub changeSizeOfUcMapView()
        ucMapView1.Size = pnlMapView.Size

        ucMapView1.lbMap.Size = New Size(pnlMapView.Width, heightLables)
        ucMapView1.dropDownMap.Size = New Size(CInt(pnlMapView.Width / 6), heightButtons)
        ucMapView1.pictureBoxMap.Size = New Size(pnlMapView.Width - 2 * gapSmall, pnlMapView.Height - gapSmall - heightLables)

        ucMapView1.pictureBoxInitiative1.Size = New Size(CInt((ucMapView1.pictureBoxMap.Width - 19 * gapSmall) / 18), CInt((ucMapView1.pictureBoxMap.Width - 19 * gapSmall) / 18))
        ucMapView1.pictureBoxInitiative2.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative3.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative4.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative5.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative6.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative7.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative8.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative9.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative10.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative11.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative12.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative13.Size = ucMapView1.pictureBoxInitiative1.Size
        ucMapView1.pictureBoxInitiative14.Size = ucMapView1.pictureBoxInitiative1.Size

        ucMapView1.lbMap.Location = New Point(0, 0)
        ucMapView1.dropDownMap.Location = New Point(pnlMapView.Width - gapSmall - ucMapView1.dropDownMap.Width, gapSmall)
        ucMapView1.pictureBoxMap.Location = New Point(gapSmall, heightLables)

        ucMapView1.pictureBoxInitiative1.Location = New Point(3 * gapSmall + 2 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative2.Location = New Point(4 * gapSmall + 3 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative3.Location = New Point(5 * gapSmall + 4 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative4.Location = New Point(6 * gapSmall + 5 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative5.Location = New Point(7 * gapSmall + 6 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative6.Location = New Point(8 * gapSmall + 7 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative7.Location = New Point(9 * gapSmall + 8 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative8.Location = New Point(10 * gapSmall + 9 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative9.Location = New Point(11 * gapSmall + 10 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative10.Location = New Point(12 * gapSmall + 11 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative11.Location = New Point(13 * gapSmall + 12 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative12.Location = New Point(14 * gapSmall + 13 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative13.Location = New Point(15 * gapSmall + 14 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
        ucMapView1.pictureBoxInitiative14.Location = New Point(16 * gapSmall + 15 * ucMapView1.pictureBoxInitiative1.Width, ucMapView1.pictureBoxMap.Location.Y)
    End Sub
#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
#End Region

End Class
