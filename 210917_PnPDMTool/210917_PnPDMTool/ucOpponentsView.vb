Public Class ucOpponentsView

#Region "Private Var"

#End Region

#Region "Properties"
#End Region

#Region "Init"
#End Region

#Region "Private Sub"
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        RaiseEvent btnNewClicked()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        RaiseEvent btnEditClicked()
    End Sub

    Private Sub btnAddToBattle_Click(sender As Object, e As EventArgs) Handles btnAddToBattle.Click
        RaiseEvent btnAddToBattleClicked()
    End Sub
#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
    Public Event btnNewClicked()
    Public Event btnEditClicked()
    Public Event btnAddToBattleClicked()
#End Region

End Class
