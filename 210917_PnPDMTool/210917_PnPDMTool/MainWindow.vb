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
    End Sub

    Private Sub changeSizeOfUcCharOverviewRight()
        ucCharOverviewRight1.Size = pnlCharOverviewRight.Size
    End Sub

    Private Sub changeSizeOfUcMapView()
        ucMapView1.Size = pnlMapView.Size
    End Sub
#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
#End Region

End Class
