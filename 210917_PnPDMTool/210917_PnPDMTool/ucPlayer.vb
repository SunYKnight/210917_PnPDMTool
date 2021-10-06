Public Class ucPlayer
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        RaiseEvent btnPlayerDiscardClicked()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaiseEvent btnPlayerSaveDiscardClicked()
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
    Public Event btnPlayerDiscardClicked()
    Public Event btnPlayerSaveDiscardClicked()
#End Region
End Class
