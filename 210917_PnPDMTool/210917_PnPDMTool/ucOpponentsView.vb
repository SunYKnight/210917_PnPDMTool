Imports _210917_PnPDMTool.C

Public Class ucOpponentsView

#Region "Private Var"
#End Region

#Region "Properties"
#End Region

#Region "Init"
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

        Me.lbOpponents.Size = New Size(Me.Width, heightTitle)
        Me.listViewOpponents.Size = New Size(Me.Width - 2 * gapSmall, Me.Height - 3 * gapSmall - 2 * heightButtons - heightTitle)

        Me.btnNewOpponent.Size = New Size(CInt((Me.Width - 3 * gapSmall) / 2), heightButtons)
        Me.btnEditOpponent.Size = New Size(Me.Width - 3 * gapSmall - Me.btnNewOpponent.Width, heightButtons)
        Me.btnAddToBattle.Size = New Size(Me.Width - 2 * gapSmall, heightButtons)

        Me.lbOpponents.Location = New Point(0, 0)
        Me.listViewOpponents.Location = New Point(gapSmall, heightTitle)

        Me.btnNewOpponent.Location = New Point(gapSmall, Me.Height - 2 * gapSmall - 2 * heightButtons)
        Me.btnEditOpponent.Location = New Point(2 * gapSmall + Me.btnNewOpponent.Width, Me.btnNewOpponent.Location.Y)
        Me.btnAddToBattle.Location = New Point(gapSmall, Me.Height - gapSmall - heightButtons)
    End Sub
#End Region

#Region "Events"
    Public Event btnNewOpponentClicked()
    Public Event btnEditOpponentClicked()
    Public Event btnAddToBattleClicked()
#End Region

End Class
