Public Class ucOpponent
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
#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    Public Event btnOpponentDiscardClicked()
    Public Event btnOpponentSaveClicked()
    Public Event btnOpponentActionsClicked()
    Public Event btnOpponentLegendaryActionsClicked()
#End Region
End Class
