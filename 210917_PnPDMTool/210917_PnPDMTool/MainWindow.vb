Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size
    Dim widthRatio As Single
    Dim heightRatio As Single

    Dim gapSmall As Int32 = 6
    Dim gapMedium As Int32 = 12
    Dim gapBig As Int32 = 18

    Dim heightButtons As Int32 = 30
    Dim heightTitle As Int32 = 40
    Dim heightSubTitle As Int32 = 25
    Dim heightTxtSmall As Int32 = 15
    Dim heightTxt1 As Int32 = 20
    Dim heightTxtBox As Int32 = 27
    Dim heightTxt6 As Int32 = 120

    Dim widthTxtSmall As Int32 = 50
    Dim widthTxtMedium As Int32 = 70
    Dim widthTxtBig As Int32 = 170
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
        changeSizeOfUcNew()
        changeSizeOfUcOpponent()
        changeSizeOfUcPlayer()
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

        ucBattleView1.lbBattle.Size = New Size(pnlBattleView.Width, heightTitle)
        ucBattleView1.btnRemove.Size = New Size(CInt((pnlBattleView.Width - 4 * gapSmall) / 3), heightButtons)
        ucBattleView1.btnEndBattle.Size = ucBattleView1.btnRemove.Size
        ucBattleView1.btnNext.Size = New Size(pnlBattleView.Width - 4 * gapSmall - 2 * ucBattleView1.btnRemove.Width, heightButtons)
        ucBattleView1.listViewBattle.Size = New Size(pnlBattleView.Width - 2 * gapSmall, pnlBattleView.Height - 2 * gapSmall - heightButtons - heightTitle)

        ucBattleView1.lbBattle.Location = New Point(0, 0)
        ucBattleView1.btnRemove.Location = New Point(gapSmall, pnlBattleView.Height - gapSmall - heightButtons)
        ucBattleView1.btnNext.Location = New Point(2 * gapSmall + ucBattleView1.btnRemove.Width, pnlBattleView.Height - gapSmall - heightButtons)
        ucBattleView1.btnEndBattle.Location = New Point(3 * gapSmall + ucBattleView1.btnEndBattle.Width + ucBattleView1.btnRemove.Width, pnlBattleView.Height - gapSmall - heightButtons)
        ucBattleView1.listViewBattle.Location = New Point(gapSmall, heightTitle)
    End Sub

    Private Sub changeSizeOfUcOpponentsView()
        ucOpponentsView1.Size = pnlOpponentsView.Size

        ucOpponentsView1.lbOpponents.Size = New Size(pnlOpponentsView.Width, heightTitle)
        ucOpponentsView1.btnAddToBattle.Size = New Size(CInt((pnlOpponentsView.Width - 4 * gapSmall) / 3), heightButtons)
        ucOpponentsView1.btnEdit.Size = ucOpponentsView1.btnAddToBattle.Size
        ucOpponentsView1.btnNew.Size = New Size(pnlOpponentsView.Width - 4 * gapSmall - 2 * ucOpponentsView1.btnAddToBattle.Width, heightButtons)
        ucOpponentsView1.listViewOpponents.Size = New Size(pnlOpponentsView.Width - 2 * gapSmall, pnlOpponentsView.Height - 2 * gapSmall - heightButtons - heightTitle)

        ucOpponentsView1.lbOpponents.Location = New Point(0, 0)
        ucOpponentsView1.btnAddToBattle.Location = New Point(gapSmall, pnlOpponentsView.Height - gapSmall - heightButtons)
        ucOpponentsView1.btnNew.Location = New Point(2 * gapSmall + ucOpponentsView1.btnAddToBattle.Width, pnlBattleView.Height - gapSmall - heightButtons)
        ucOpponentsView1.btnEdit.Location = New Point(3 * gapSmall + ucOpponentsView1.btnNew.Width + ucOpponentsView1.btnAddToBattle.Width, pnlOpponentsView.Height - gapSmall - heightButtons)
        ucOpponentsView1.listViewOpponents.Location = New Point(gapSmall, heightTitle)
    End Sub

    Private Sub changeSizeOfUcCharOverviewLeft()
        ucCharOverviewLeft1.Size = pnlCharOverviewLeft.Size

        ucCharOverviewLeft1.lbName.Size = New Size(pnlCharOverviewLeft.Width, heightTitle)
        ucCharOverviewLeft1.btnActions.Size = New Size(CInt((pnlCharOverviewLeft.Width - 3 * gapSmall) * 3 / 10), heightButtons)
        ucCharOverviewLeft1.btnLegendaryActions.Size = ucCharOverviewLeft1.btnActions.Size

        ucCharOverviewLeft1.txtAbilitiesTitle.Size = New Size(ucCharOverviewLeft1.btnActions.Width, heightSubTitle)
        ucCharOverviewLeft1.txtAbilities.Size = New Size(CInt(ucCharOverviewLeft1.txtAbilitiesTitle.Width / 3), heightTxt6)
        ucCharOverviewLeft1.txtAbilitiesModifier.Size = ucCharOverviewLeft1.txtAbilities.Size
        ucCharOverviewLeft1.txtAbilitiesScore.Size = New Size(ucCharOverviewLeft1.txtAbilitiesTitle.Width - 2 * ucCharOverviewLeft1.txtAbilities.Width, ucCharOverviewLeft1.txtAbilities.Height)

        ucCharOverviewLeft1.pictureBoxChar.Size = New Size(ucCharOverviewLeft1.btnActions.Width, pnlCharOverviewLeft.Height - 4 * gapSmall - 2 * heightButtons - heightTxt6 - heightSubTitle - heightTitle)

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
        ucCharOverviewLeft1.txtMPTitle.Size = New Size(ucCharOverviewLeft1.txtMPLv1Title.Width * 9, heightSubTitle)

        ucCharOverviewLeft1.txtInfo1.Size = New Size(pnlCharOverviewLeft.Width - ucCharOverviewLeft1.btnActions.Width - 3 * gapSmall, pnlCharOverviewLeft.Height - heightTitle - 2 * gapSmall - 2 * heightTxt1 - heightSubTitle)

        ucCharOverviewLeft1.txtHPTitle.Size = New Size(CInt((ucCharOverviewLeft1.txtInfo1.Width - ucCharOverviewLeft1.txtMPTitle.Width - 2 * gapSmall) / 2), heightSubTitle)
        ucCharOverviewLeft1.txtHP.Size = New Size(ucCharOverviewLeft1.txtHPTitle.Width, 2 * heightTxt1)
        ucCharOverviewLeft1.TxtHPmax.Size = New Size(ucCharOverviewLeft1.txtHPTitle.Width, heightTxtSmall)
        ucCharOverviewLeft1.txtACTitle.Size = New Size(ucCharOverviewLeft1.txtInfo1.Width - ucCharOverviewLeft1.txtMPTitle.Width - ucCharOverviewLeft1.txtHPTitle.Width - 2 * gapSmall, 2 * heightTxt1)
        ucCharOverviewLeft1.txtAC.Size = New Size(ucCharOverviewLeft1.txtACTitle.Width, 2 * heightTxt1)

        ucCharOverviewLeft1.lbName.Location = New Point(gapSmall, 0)
        ucCharOverviewLeft1.pictureBoxChar.Location = New Point(gapSmall, heightTitle)
        ucCharOverviewLeft1.txtAbilitiesTitle.Location = New Point(gapSmall, heightTitle + ucCharOverviewLeft1.pictureBoxChar.Height + gapSmall)
        ucCharOverviewLeft1.txtAbilities.Location = New Point(gapSmall, ucCharOverviewLeft1.txtAbilitiesTitle.Location.Y + heightSubTitle)
        ucCharOverviewLeft1.txtAbilitiesScore.Location = New Point(gapSmall + ucCharOverviewLeft1.txtAbilities.Width, ucCharOverviewLeft1.txtAbilities.Location.Y)
        ucCharOverviewLeft1.txtAbilitiesModifier.Location = New Point(ucCharOverviewLeft1.txtAbilitiesScore.Location.X + ucCharOverviewLeft1.txtAbilitiesScore.Width, ucCharOverviewLeft1.txtAbilities.Location.Y)
        ucCharOverviewLeft1.btnActions.Location = New Point(gapSmall, pnlCharOverviewLeft.Height - 2 * gapSmall - 2 * heightButtons)
        ucCharOverviewLeft1.btnLegendaryActions.Location = New Point(gapSmall, pnlCharOverviewLeft.Height - gapSmall - heightButtons)
        ucCharOverviewLeft1.txtInfo1.Location = New Point(2 * gapSmall + ucCharOverviewLeft1.pictureBoxChar.Width, pnlCharOverviewLeft.Height - gapSmall - ucCharOverviewLeft1.txtInfo1.Height)

        ucCharOverviewLeft1.txtMPTitle.Location = New Point(2 * gapSmall + ucCharOverviewLeft1.pictureBoxChar.Width, heightTitle)
        ucCharOverviewLeft1.txtMPLv1Title.Location = New Point(ucCharOverviewLeft1.txtMPTitle.Location.X, ucCharOverviewLeft1.txtMPTitle.Location.Y + heightSubTitle)
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

        ucCharOverviewLeft1.txtACTitle.Location = New Point(3 * gapSmall + ucCharOverviewLeft1.pictureBoxChar.Width + ucCharOverviewLeft1.txtMPTitle.Width, heightTitle)
        ucCharOverviewLeft1.txtAC.Location = New Point(ucCharOverviewLeft1.txtACTitle.Location.X, ucCharOverviewLeft1.txtACTitle.Height + heightSubTitle)

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

        ucMapView1.lbMap.Size = New Size(pnlMapView.Width, heightTitle)
        ucMapView1.dropDownMap.Size = New Size(CInt(pnlMapView.Width / 6), heightButtons)
        ucMapView1.pictureBoxMap.Size = New Size(pnlMapView.Width - 2 * gapSmall, pnlMapView.Height - gapSmall - heightTitle)

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
        ucMapView1.pictureBoxMap.Location = New Point(gapSmall, heightTitle)

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

    Private Sub changeSizeOfUcNew()
        ucNew1.Size = pnlMapView.Size

        ucNew1.lbNewCharacter.Size = New Size(pnlMapView.Width - gapSmall, heightTitle)
        ucNew1.lbCreateANew.Size = New Size(CInt(pnlMapView.Width / 12), heightButtons)
        ucNew1.btnPlayer.Size = ucNew1.lbCreateANew.Size
        ucNew1.btnOpponent.Size = ucNew1.lbCreateANew.Size

        ucNew1.lbNewCharacter.Location = New Point(gapSmall, 0)
        ucNew1.lbCreateANew.Location = New Point(gapSmall, heightTitle + gapSmall)
        ucNew1.btnPlayer.Location = New Point(2 * gapSmall + ucNew1.lbCreateANew.Width, ucNew1.lbCreateANew.Location.Y)
        ucNew1.btnOpponent.Location = New Point(3 * gapSmall + 2 * ucNew1.lbCreateANew.Width, ucNew1.lbCreateANew.Location.Y)
    End Sub

    Private Sub changeSizeOfUcPlayer()
        ucPlayer1.Size = pnlMapView.Size

        'Title
        ucPlayer1.lbPlayer.Size = New Size(pnlMapView.Width - gapSmall, heightTitle)
        ucPlayer1.lbPlayer.Location = New Point(gapSmall, 0)

        'Abilities
        ucPlayer1.lbStr.Size = New Size(widthTxtMedium, heightTxtBox)
        ucPlayer1.lbDex.Size = ucPlayer1.lbStr.Size
        ucPlayer1.lbCon.Size = ucPlayer1.lbStr.Size
        ucPlayer1.lbWis.Size = ucPlayer1.lbStr.Size
        ucPlayer1.lbInt.Size = ucPlayer1.lbStr.Size
        ucPlayer1.lbCha.Size = ucPlayer1.lbStr.Size
        ucPlayer1.txtStr.Size = New Size(widthTxtSmall, heightTxtBox)
        ucPlayer1.txtDex.Size = ucPlayer1.txtStr.Size
        ucPlayer1.txtCon.Size = ucPlayer1.txtStr.Size
        ucPlayer1.txtWis.Size = ucPlayer1.txtStr.Size
        ucPlayer1.txtInt.Size = ucPlayer1.txtStr.Size
        ucPlayer1.txtCha.Size = ucPlayer1.txtStr.Size

        ucPlayer1.lbStr.Location = New Point(gapSmall, heightTitle + gapMedium)
        ucPlayer1.lbDex.Location = New Point(gapSmall, ucPlayer1.lbStr.Location.Y + heightTxtBox + gapSmall)
        ucPlayer1.lbCon.Location = New Point(gapSmall, ucPlayer1.lbDex.Location.Y + heightTxtBox + gapSmall)
        ucPlayer1.lbWis.Location = New Point(gapSmall, ucPlayer1.lbCon.Location.Y + heightTxtBox + gapSmall)
        ucPlayer1.lbInt.Location = New Point(gapSmall, ucPlayer1.lbWis.Location.Y + heightTxtBox + gapSmall)
        ucPlayer1.lbCha.Location = New Point(gapSmall, ucPlayer1.lbInt.Location.Y + heightTxtBox + gapSmall)
        ucPlayer1.txtStr.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbStr.Location.Y)
        ucPlayer1.txtDex.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbDex.Location.Y)
        ucPlayer1.txtCon.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbCon.Location.Y)
        ucPlayer1.txtWis.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbWis.Location.Y)
        ucPlayer1.txtInt.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbInt.Location.Y)
        ucPlayer1.txtCha.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbCha.Location.Y)

        'AC & HP
        ucPlayer1.lbAc.Size = ucPlayer1.lbStr.Size
        ucPlayer1.lbHP.Size = ucPlayer1.lbStr.Size
        ucPlayer1.txtAc.Size = ucPlayer1.txtStr.Size
        ucPlayer1.txtHp.Size = ucPlayer1.txtStr.Size

        ucPlayer1.lbAc.Location = New Point(gapSmall, ucPlayer1.lbCha.Location.Y + 2 * heightTxtBox + 2 * gapSmall)
        ucPlayer1.lbHP.Location = New Point(gapSmall, ucPlayer1.lbAc.Location.Y + heightTxtBox + gapSmall)
        ucPlayer1.txtAc.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbAc.Location.Y)
        ucPlayer1.txtHp.Location = New Point(gapSmall + widthTxtMedium, ucPlayer1.lbHP.Location.Y)

        'Name and Image
        ucPlayer1.lbName.Size = New Size(widthTxtMedium, heightTxtBox)
        ucPlayer1.lbImage.Size = ucPlayer1.lbName.Size
        ucPlayer1.txtName.Size = New Size(pnlMapView.Width - gapSmall - widthTxtSmall - widthTxtMedium - 3 * gapBig - widthTxtMedium - gapSmall, heightTxtBox)
        ucPlayer1.txtImage.Size = ucPlayer1.txtName.Size

        ucPlayer1.lbName.Location = New Point(gapSmall + widthTxtSmall + widthTxtMedium + 3 * gapBig, ucPlayer1.lbStr.Location.Y)
        ucPlayer1.lbImage.Location = New Point(ucPlayer1.lbName.Location.X, ucPlayer1.lbDex.Location.Y)
        ucPlayer1.txtName.Location = New Size(ucPlayer1.lbName.Location.X + widthTxtMedium, ucPlayer1.lbName.Location.Y)
        ucPlayer1.txtImage.Location = New Size(ucPlayer1.txtName.Location.X, ucPlayer1.lbImage.Location.Y)

        'Buttons
        ucPlayer1.btnDiscard.Size = New Size(CInt((pnlMapView.Width / 2 - 3 * gapSmall - gapBig) / 6), heightButtons)
        ucPlayer1.btnSave.Size = ucPlayer1.btnDiscard.Size

        ucPlayer1.btnSave.Location = New Point(pnlMapView.Width - gapSmall - ucPlayer1.btnSave.Width, pnlMapView.Height - heightButtons - gapSmall)
        ucPlayer1.btnDiscard.Location = New Point(pnlMapView.Width - 2 * gapSmall - 2 * ucPlayer1.btnSave.Width, ucPlayer1.btnSave.Location.Y)
    End Sub

    Private Sub changeSizeOfUcOpponent()
        ucOpponent1.Size = pnlMapView.Size

        'Title
        ucOpponent1.lbOpponent.Size = New Size(pnlMapView.Width - gapSmall, heightTitle)
        ucOpponent1.lbOpponent.Location = New Point(gapSmall, 0)

        'Abilities
        ucOpponent1.lbStr.Size = New Size(widthTxtMedium, heightTxtBox)
        ucOpponent1.lbDex.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbCon.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbWis.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbInt.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbCha.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbAc.Size = ucOpponent1.lbStr.Size
        ucOpponent1.txtStr.Size = New Size(widthTxtSmall, heightTxtBox)
        ucOpponent1.txtDex.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtCon.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtWis.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtInt.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtCha.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtAc.Size = ucOpponent1.txtStr.Size

        ucOpponent1.lbStr.Location = New Point(gapSmall, heightTitle + gapMedium)
        ucOpponent1.lbDex.Location = New Point(gapSmall, ucOpponent1.lbStr.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbCon.Location = New Point(gapSmall, ucOpponent1.lbDex.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbWis.Location = New Point(gapSmall, ucOpponent1.lbCon.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbInt.Location = New Point(gapSmall, ucOpponent1.lbWis.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbCha.Location = New Point(gapSmall, ucOpponent1.lbInt.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbAc.Location = New Point(gapSmall, ucOpponent1.lbCha.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.txtStr.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbStr.Location.Y)
        ucOpponent1.txtDex.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbDex.Location.Y)
        ucOpponent1.txtCon.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbCon.Location.Y)
        ucOpponent1.txtWis.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbWis.Location.Y)
        ucOpponent1.txtInt.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbInt.Location.Y)
        ucOpponent1.txtCha.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbCha.Location.Y)
        ucOpponent1.txtAc.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbAc.Location.Y)

        'MP
        ucOpponent1.lbMp.Size = New Size(widthTxtSmall + widthTxtMedium, heightTxtBox)
        ucOpponent1.lbLv1.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv2.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv3.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv4.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv5.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv6.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv7.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv8.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbLv9.Size = ucOpponent1.lbStr.Size
        ucOpponent1.txtLv1.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv2.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv3.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv4.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv5.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv6.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv7.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv8.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtLv9.Size = ucOpponent1.txtStr.Size

        ucOpponent1.lbMp.Location = New Point(gapSmall, ucOpponent1.lbAc.Location.Y + 2 * heightTxtBox + 2 * gapSmall)
        ucOpponent1.lbLv1.Location = New Point(gapSmall, ucOpponent1.lbMp.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv2.Location = New Point(gapSmall, ucOpponent1.lbLv1.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv3.Location = New Point(gapSmall, ucOpponent1.lbLv2.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv4.Location = New Point(gapSmall, ucOpponent1.lbLv3.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv5.Location = New Point(gapSmall, ucOpponent1.lbLv4.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv6.Location = New Point(gapSmall, ucOpponent1.lbLv5.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv7.Location = New Point(gapSmall, ucOpponent1.lbLv6.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv8.Location = New Point(gapSmall, ucOpponent1.lbLv7.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbLv9.Location = New Point(gapSmall, ucOpponent1.lbLv8.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.txtLv1.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv1.Location.Y)
        ucOpponent1.txtLv2.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv2.Location.Y)
        ucOpponent1.txtLv3.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv3.Location.Y)
        ucOpponent1.txtLv4.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv4.Location.Y)
        ucOpponent1.txtLv5.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv5.Location.Y)
        ucOpponent1.txtLv6.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv6.Location.Y)
        ucOpponent1.txtLv7.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv7.Location.Y)
        ucOpponent1.txtLv8.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv8.Location.Y)
        ucOpponent1.txtLv9.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbLv9.Location.Y)

        'max. HP
        ucOpponent1.lbMaxHp.Size = ucOpponent1.lbMp.Size
        ucOpponent1.lbNumber.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbDice.Size = ucOpponent1.lbStr.Size
        ucOpponent1.lbModifier.Size = ucOpponent1.lbStr.Size
        ucOpponent1.txtNumber.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtDice.Size = ucOpponent1.txtStr.Size
        ucOpponent1.txtModifier.Size = ucOpponent1.txtStr.Size

        ucOpponent1.lbMaxHp.Location = New Point(gapSmall, ucOpponent1.lbLv9.Location.Y + 2 * heightTxtBox + 2 * gapSmall)
        ucOpponent1.lbNumber.Location = New Point(gapSmall, ucOpponent1.lbMaxHp.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbDice.Location = New Point(gapSmall, ucOpponent1.lbNumber.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbModifier.Location = New Point(gapSmall, ucOpponent1.lbDice.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.txtNumber.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbNumber.Location.Y)
        ucOpponent1.txtDice.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbDice.Location.Y)
        ucOpponent1.txtModifier.Location = New Point(gapSmall + widthTxtMedium, ucOpponent1.lbModifier.Location.Y)

        'Name, Image and Informations
        ucOpponent1.lbName.Size = New Size(widthTxtBig, heightTxtBox)
        ucOpponent1.lbEnvironment.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbInformations.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbSavingThrows.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbProficiency.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbSkills.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbSenses.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbLanguages.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbChallenge.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbSpeed.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbEffects.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbDamageImmunities.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbDamageResistance.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbDamageVulnerabilities.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbConditionImmunities.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbConditionResistance.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbLegendaryResistance.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbMagicResistance.Size = ucOpponent1.lbName.Size
        ucOpponent1.lbOthers.Size = ucOpponent1.lbName.Size

        ucOpponent1.lbName.Location = New Point(gapSmall + ucOpponent1.lbMp.Width + 3 * gapBig, ucOpponent1.lbStr.Location.Y)
        ucOpponent1.lbEnvironment.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbDex.Location.Y)
        ucOpponent1.lbImage.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbCon.Location.Y)

        ucOpponent1.lbInformations.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbInt.Location.Y)
        ucOpponent1.lbSavingThrows.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbCha.Location.Y)
        ucOpponent1.lbProficiency.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbAc.Location.Y)
        ucOpponent1.lbSkills.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbAc.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbSenses.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbMp.Location.Y)
        ucOpponent1.lbLanguages.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv1.Location.Y)
        ucOpponent1.lbChallenge.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv2.Location.Y)
        ucOpponent1.lbSpeed.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv3.Location.Y)
        ucOpponent1.lbEffects.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv4.Location.Y)
        ucOpponent1.lbDamageImmunities.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv5.Location.Y)
        ucOpponent1.lbDamageResistance.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv6.Location.Y)
        ucOpponent1.lbDamageVulnerabilities.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv7.Location.Y)
        ucOpponent1.lbConditionImmunities.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv8.Location.Y)
        ucOpponent1.lbConditionResistance.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv9.Location.Y)
        ucOpponent1.lbLegendaryResistance.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbLv9.Location.Y + heightTxtBox + gapSmall)
        ucOpponent1.lbMagicResistance.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbMaxHp.Location.Y)
        ucOpponent1.lbOthers.Location = New Point(ucOpponent1.lbName.Location.X, ucOpponent1.lbNumber.Location.Y)

        ucOpponent1.txtName.Size = New Size(pnlMapView.Width - gapSmall - widthTxtSmall - widthTxtMedium - 3 * gapBig - widthTxtBig - gapSmall, heightTxtBox)
        ucOpponent1.txtEnvironment.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtImage.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtSavingThrows.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtProficiency.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtSkills.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtSenses.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtLanguages.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtChallenge.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtSpeed.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtEffects.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtDamageImmunities.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtDamageResistance.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtDamageVulnerabilities.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtConditionImmunities.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtConditionResistance.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtLegendaryResistance.Size = ucOpponent1.txtName.Size
        ucOpponent1.txtMagicResistance.Size = ucOpponent1.txtName.Size

        ucOpponent1.txtName.Location = New Size(ucOpponent1.lbName.Location.X + widthTxtBig, ucOpponent1.lbName.Location.Y)
        ucOpponent1.txtEnvironment.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbEnvironment.Location.Y)
        ucOpponent1.txtImage.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbImage.Location.Y)
        ucOpponent1.txtSavingThrows.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbSavingThrows.Location.Y)
        ucOpponent1.txtProficiency.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbProficiency.Location.Y)
        ucOpponent1.txtSkills.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbSkills.Location.Y)
        ucOpponent1.txtSenses.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbSenses.Location.Y)
        ucOpponent1.txtLanguages.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbLanguages.Location.Y)
        ucOpponent1.txtChallenge.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbChallenge.Location.Y)
        ucOpponent1.txtSpeed.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbSpeed.Location.Y)
        ucOpponent1.txtEffects.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbEffects.Location.Y)
        ucOpponent1.txtDamageImmunities.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbDamageImmunities.Location.Y)
        ucOpponent1.txtDamageResistance.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbDamageResistance.Location.Y)
        ucOpponent1.txtDamageVulnerabilities.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbDamageVulnerabilities.Location.Y)
        ucOpponent1.txtConditionImmunities.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbConditionImmunities.Location.Y)
        ucOpponent1.txtConditionResistance.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbConditionResistance.Location.Y)
        ucOpponent1.txtLegendaryResistance.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbLegendaryResistance.Location.Y)
        ucOpponent1.txtMagicResistance.Location = New Size(ucOpponent1.txtName.Location.X, ucOpponent1.lbMagicResistance.Location.Y)

        ucOpponent1.txtOthers.Size = New Size(ucOpponent1.txtName.Width, pnlMapView.Height - ucOpponent1.lbOthers.Location.Y - 2 * gapSmall - heightButtons)
        ucOpponent1.txtOthers.Location = New Point(ucOpponent1.txtName.Location.X, ucOpponent1.lbOthers.Location.Y)

        'Buttons
        ucOpponent1.btnActions.Size = New Size(CInt((pnlMapView.Width / 2 - 3 * gapSmall - gapBig) / 4), heightButtons)
        ucOpponent1.btnLegendaryActions.Size = ucOpponent1.btnActions.Size
        ucOpponent1.btnDiscard.Size = New Size(CInt(ucOpponent1.btnActions.Width / 3 * 2), heightButtons)
        ucOpponent1.btnSave.Size = ucOpponent1.btnDiscard.Size

        ucOpponent1.btnSave.Location = New Point(pnlMapView.Width - gapSmall - ucOpponent1.btnSave.Width, pnlMapView.Height - heightButtons - gapSmall)
        ucOpponent1.btnDiscard.Location = New Point(pnlMapView.Width - 2 * gapSmall - 2 * ucOpponent1.btnSave.Width, ucOpponent1.btnSave.Location.Y)
        ucOpponent1.btnActions.Location = New Point(ucOpponent1.txtOthers.Location.X, ucOpponent1.btnSave.Location.Y)
        ucOpponent1.btnLegendaryActions.Location = New Point(ucOpponent1.txtOthers.Location.X + ucOpponent1.btnActions.Width + gapSmall, ucOpponent1.btnSave.Location.Y)
    End Sub

    Private Sub showUcNew()
        pnlMapView.Controls.Clear()
        pnlMapView.Controls.Add(ucNew1)
    End Sub

    Private Sub showUcMapView()
        pnlMapView.Controls.Clear()
        pnlMapView.Controls.Add(ucMapView1)
    End Sub

    Private Sub showUcOpponent()
        pnlMapView.Controls.Clear()
        pnlMapView.Controls.Add(ucOpponent1)
    End Sub

    Private Sub showUcPlayer()
        pnlMapView.Controls.Clear()
        pnlMapView.Controls.Add(ucPlayer1)
    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    Private Sub btnNewClickedHandler() Handles ucOpponentsView1.btnNewClicked
        showUcNew()
    End Sub

    Private Sub btnPlayerClickedHandler() Handles ucNew1.btnPlayerClicked
        showUcPlayer()
    End Sub

    Private Sub btnOpponentClickedHandler() Handles ucNew1.btnOpponentClicked
        showUcOpponent()
    End Sub

    Private Sub btnOpponentDiscardClickedHandler() Handles ucOpponent1.btnOpponentDiscardClicked
        showUcMapView()
    End Sub

    Private Sub btnOpponentSaveClickedHandler() Handles ucOpponent1.btnOpponentSaveClicked
        showUcMapView()
    End Sub

    Private Sub btnOpponentActionsClickedHandler() Handles ucOpponent1.btnOpponentActionsClicked

    End Sub

    Private Sub btnOpponentLegendaryActionsClickedHandler() Handles ucOpponent1.btnOpponentLegendaryActionsClicked

    End Sub

    Private Sub btnPlayerDiscardClickedHandler() Handles ucPlayer1.btnPlayerDiscardClicked
        showUcMapView()
    End Sub

    Private Sub btnPlayerSaveClickedHandler() Handles ucPlayer1.btnPlayerSaveDiscardClicked
        showUcMapView()
    End Sub
#End Region

End Class
