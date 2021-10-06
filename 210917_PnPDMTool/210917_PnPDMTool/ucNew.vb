Public Class ucNew
#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"
    Private Sub btnPlayer_Click(sender As Object, e As EventArgs) Handles btnPlayer.Click
        RaiseEvent btnPlayerClicked()
    End Sub

    Private Sub btnOpponent_Click(sender As Object, e As EventArgs) Handles btnOpponent.Click
        RaiseEvent btnOpponentClicked()
    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    Public Event btnPlayerClicked()
    Public Event btnOpponentClicked()
#End Region
End Class
