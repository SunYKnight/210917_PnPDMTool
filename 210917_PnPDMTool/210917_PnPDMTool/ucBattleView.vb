Imports _210917_PnPDMTool.C

Public Class UcBattleView
#Region "Private Var"
#End Region

#Region "Properties"
#End Region

#Region "Init"
#End Region

#Region "Private Sub"
    Private Sub btnNewPlayer_Click(sender As Object, e As EventArgs) Handles btnNewPlayer.Click
        RaiseEvent btnNewPlayerClicked()
    End Sub

    Private Sub btnEditPlayer_Click(sender As Object, e As EventArgs) Handles btnEditPlayer.Click
        RaiseEvent btnEditPlayerClicked()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RaiseEvent btnRemoveClicked()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        RaiseEvent btnNextClicked()
    End Sub

    Private Sub btnEndBattle_Click(sender As Object, e As EventArgs) Handles btnEndBattle.Click
        RaiseEvent btnEndBattleClicked()
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbBattle.Size = New Size(Me.Width, heightTitle)
        Me.listViewBattle.Size = New Size(Me.Width - 2 * gapSmall, Me.Height - 3 * gapSmall - 2 * heightButtons - heightTitle)

        Me.btnNewPlayer.Size = New Size(CInt((Me.Width - 4 * gapSmall) / 3), heightButtons)
        Me.btnEditPlayer.Size = New Size(Me.Width - 4 * gapSmall - 2 * Me.btnNewPlayer.Width, heightButtons)
        Me.btnRemove.Size = Me.btnNewPlayer.Size

        Me.btnNext.Size = New Size(CInt((Me.Width - 3 * gapSmall) / 2), heightButtons)
        Me.btnEndBattle.Size = Me.btnNext.Size

        Me.lbBattle.Location = New Point(0, 0)
        Me.listViewBattle.Location = New Point(gapSmall, heightTitle)

        Me.btnNewPlayer.Location = New Point(gapSmall, Me.Height - 2 * gapSmall - 2 * heightButtons)
        Me.btnEditPlayer.Location = New Point(2 * gapSmall + Me.btnNewPlayer.Width, Me.btnNewPlayer.Location.Y)
        Me.btnRemove.Location = New Point(Me.Width - Me.btnRemove.Width - gapSmall, Me.btnNewPlayer.Location.Y)

        Me.btnNext.Location = New Point(gapSmall, Me.Height - gapSmall - heightButtons)
        Me.btnEndBattle.Location = New Point(2 * gapSmall + Me.btnNext.Width, Me.btnNext.Location.Y)
    End Sub
#End Region

#Region "Events"
    Public Event btnNewPlayerClicked()
    Public Event btnEditPlayerClicked()
    Public Event btnRemoveClicked()
    Public Event btnNextClicked()
    Public Event btnEndBattleClicked()
#End Region
End Class
