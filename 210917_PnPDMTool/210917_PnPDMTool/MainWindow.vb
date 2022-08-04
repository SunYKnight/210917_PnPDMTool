Imports _210917_PnPDMTool.C

Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub Init()
        InitializeComponent()

        ' Create User Control elements
        ucBattleView1 = New UcBattleView()
        ucOpponentsView1 = New UcOpponentsView()
        ucCharOverviewLeft1.changeSize(pnlCharOverviewLeft.Size)
        ucCharOverviewRight1.changeSize(pnlCharOverviewRight.Size)
        ucMapView1.changeSize(pnlMapView.Size)
        ucOpponent1.changeSize(pnlMapView.Size)
        ucPlayer1.changeSize(pnlMapView.Size)
        ucNewMap1.changeSize(pnlMapView.Size)
    End Sub
#End Region

#Region "Private Sub"
    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize


        ' Handle window size
        If Me.Size.Width < Me.MinimumSize.Width Then
            Me.Size = New Size(Me.MinimumSize.Width, Me.Size.Height)
        End If

        If Me.Size.Height < Me.MinimumSize.Height Then
            Me.Size = New Size(Me.Size.Width, Me.MinimumSize.Height)
        End If
        innerSize = New Size(Me.Size.Width - 15, Me.Size.Height - 39)

        ' Update panel size
        changeSizeOfPanels()

    End Sub

    Private Sub changeSizeOfPanels()
        pnlBattleView.Size = New Size(CInt((innerSize.Width - 3 * GAP_MEDIUM - GAP_BIG) / 6), CInt((innerSize.Height - 3 * GAP_MEDIUM) / 2))
        pnlOpponentsView.Size = pnlBattleView.Size
        pnlCharOverviewLeft.Size = New Size(2 * pnlBattleView.Width + GAP_MEDIUM, innerSize.Height - 3 * GAP_MEDIUM - pnlBattleView.Height)
        pnlCharOverviewRight.Size = New Size(innerSize.Width - 2 * GAP_MEDIUM - pnlCharOverviewLeft.Width, CInt((innerSize.Height - 2 * GAP_MEDIUM - GAP_BIG) / 6))
        pnlMapView.Size = New Size(pnlCharOverviewRight.Width - GAP_BIG, innerSize.Height - 2 * GAP_MEDIUM - GAP_BIG - pnlCharOverviewRight.Height)

        pnlBattleView.Location = New Point(GAP_MEDIUM, GAP_MEDIUM)
        pnlOpponentsView.Location = New Point(2 * GAP_MEDIUM + pnlBattleView.Width, GAP_MEDIUM)
        pnlCharOverviewLeft.Location = New Point(GAP_MEDIUM, 2 * GAP_MEDIUM + pnlBattleView.Height)
        pnlCharOverviewRight.Location = New Point(GAP_MEDIUM + pnlCharOverviewLeft.Width, GAP_MEDIUM + GAP_BIG + pnlMapView.Height)
        pnlMapView.Location = New Point(2 * GAP_MEDIUM + GAP_BIG + 2 * pnlBattleView.Width, GAP_MEDIUM)

        ' Update panels
        ucBattleView1.changeSize(pnlBattleView.Size)
        ucOpponentsView1.changeSize(pnlOpponentsView.Size)
        ucCharOverviewLeft1.changeSize(pnlCharOverviewLeft.Size)
        ucCharOverviewRight1.changeSize(pnlCharOverviewRight.Size)
        ucMapView1.changeSize(pnlMapView.Size)
        ucOpponent1.changeSize(pnlMapView.Size)
        ucPlayer1.changeSize(pnlMapView.Size)
        ucNewMap1.changeSize(pnlMapView.Size)

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

    Private Sub showUcNewMap()
        pnlMapView.Controls.Clear()
        pnlMapView.Controls.Add(ucNewMap1)
    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    'Buttons Battleview
    Private Sub btnNewPlayerClickedHandler() Handles ucBattleView1.btnNewPlayerClicked
        showUcPlayer()
    End Sub

    Private Sub btnEditPlayerClickedHandler() Handles ucBattleView1.btnEditPlayerClicked
        showUcPlayer()
    End Sub

    Private Sub btnRemoveClickedHandler() Handles ucBattleView1.btnRemoveClicked

    End Sub

    Private Sub btnNextClickedHandler() Handles ucBattleView1.btnNextClicked

    End Sub

    Private Sub btnEndBattleClickedHandler() Handles ucBattleView1.btnEndBattleClicked

    End Sub

    'Buttons Opponentsview
    Private Sub btnNewOpponentClickedHandler() Handles ucOpponentsView1.btnNewOpponentClicked

        showUcOpponent()
    End Sub

    Private Sub btnEditOpponentClickedHandler() Handles ucOpponentsView1.btnEditOpponentClicked
        showUcOpponent()
    End Sub

    Private Sub btnAddToBattleClickedHandler() Handles ucOpponentsView1.btnAddToBattleClicked

    End Sub

    'Buttons Edit/New Opponent
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

    'Buttons Edit/New Player
    Private Sub btnPlayerDiscardClickedHandler() Handles ucPlayer1.btnPlayerDiscardClicked
        showUcMapView()
    End Sub

    Private Sub btnPlayerSaveClickedHandler() Handles ucPlayer1.btnPlayerSaveClicked
        showUcMapView()
    End Sub

    'Buttons MapView
    Private Sub btnNewMapClickedHandler() Handles ucMapView1.btnNewMapClicked
        showUcNewMap()
    End Sub

    'Buttons NewMap
    Private Sub btnMapDiscardClickedHandler() Handles ucNewMap1.btnMapDiscardClicked
        showUcMapView()
    End Sub

    Private Sub btnMapSaveClickedHandler() Handles ucNewMap1.btnMapSaveClicked
        showUcMapView()
    End Sub


#End Region

End Class
