Imports _210917_PnPDMTool.C

Public Class ucMonsterView

#Region "Private Var"
#End Region

#Region "Properties"
#End Region

#Region "Init"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

#End Region

#Region "Private Sub"
    Private Sub btnNewOpponent_Click(sender As Object, e As EventArgs) Handles btnNewOpponent.Click
        RaiseEvent btnNewOpponentClicked()
    End Sub

    Private Sub btnEditOpponent_Click(sender As Object, e As EventArgs) Handles btnEditOpponent.Click
        RaiseEvent btnEditOpponentClicked()
    End Sub

    Private Sub btnAddToBattle_Click(sender As Object, e As EventArgs) Handles btnAddToBattle.Click
        RaiseEvent btnAddToBattleClicked()
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbOpponents.Size = New Size(Me.Width, HEIGHT_TITLE)
        Me.listViewOpponents.Size = New Size(Me.Width - 2 * GAP_SMALL, Me.Height - 3 * GAP_SMALL - 2 * HEIGHT_BUTTON - HEIGHT_TITLE)

        Me.btnNewOpponent.Size = New Size(CInt((Me.Width - 3 * GAP_SMALL) / 2), HEIGHT_BUTTON)
        Me.btnEditOpponent.Size = New Size(Me.Width - 3 * GAP_SMALL - Me.btnNewOpponent.Width, HEIGHT_BUTTON)
        Me.btnAddToBattle.Size = New Size(Me.Width - 2 * GAP_SMALL, HEIGHT_BUTTON)

        Me.lbOpponents.Location = New Point(0, 0)
        Me.listViewOpponents.Location = New Point(GAP_SMALL, HEIGHT_TITLE)

        Me.btnNewOpponent.Location = New Point(GAP_SMALL, Me.Height - 2 * GAP_SMALL - 2 * HEIGHT_BUTTON)
        Me.btnEditOpponent.Location = New Point(2 * GAP_SMALL + Me.btnNewOpponent.Width, Me.btnNewOpponent.Location.Y)
        Me.btnAddToBattle.Location = New Point(GAP_SMALL, Me.Height - GAP_SMALL - HEIGHT_BUTTON)
    End Sub
#End Region

#Region "Events"
    Public Event btnNewOpponentClicked()
    Public Event btnEditOpponentClicked()
    Public Event btnAddToBattleClicked()
#End Region

End Class
