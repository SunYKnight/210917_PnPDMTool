Imports _210917_PnPDMTool.C

Public Class UcNewMap
#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        RaiseEvent btnMapDiscardClicked()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaiseEvent btnMapSaveClicked()
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbMap.Size = New Size(newSize.Width - gapSmall, heightTitle)
        Me.lbLocation.Size = New Size(widthTxtBig, heightTxtBox)
        Me.lbImage.Size = Me.lbLocation.Size
        Me.lbSizeOfTiles.Size = Me.lbLocation.Size

        Me.txtLocation.Size = New Size(newSize.Width - 2 * gapSmall - Me.lbLocation.Width, heightTxtBox)
        Me.txtImage.Size = Me.txtLocation.Size
        Me.cbVeryLarge.Size = New Size(CInt((Me.txtLocation.Width - 2 * widthTxtBig) / 5), heightTxtBox)
        Me.cbLarge.Size = Me.cbVeryLarge.Size
        Me.cbMedium.Size = Me.cbVeryLarge.Size
        Me.cbSmall.Size = Me.cbVeryLarge.Size
        Me.cbVerySmall.Size = Me.cbVeryLarge.Size

        Me.lbMap.Location = New Point(gapSmall, 0)
        Me.lbLocation.Location = New Point(gapSmall, heightTitle + gapMedium)
        Me.lbImage.Location = New Point(gapSmall, Me.lbLocation.Location.Y + gapSmall + heightTxtBox)
        Me.lbSizeOfTiles.Location = New Point(gapSmall, Me.lbImage.Location.Y + gapSmall + heightTxtBox)

        Me.txtLocation.Location = New Point(gapSmall + widthTxtBig, Me.lbLocation.Location.Y)
        Me.txtImage.Location = New Point(Me.txtLocation.Location.X, Me.lbImage.Location.Y)
        Me.cbVeryLarge.Location = New Point(Me.txtLocation.Location.X, Me.lbImage.Location.Y + gapSmall + heightTxtBox)
        Me.cbLarge.Location = New Point(Me.cbVeryLarge.Location.X + Me.cbVeryLarge.Width, Me.cbVeryLarge.Location.Y)
        Me.cbMedium.Location = New Point(Me.cbLarge.Location.X + Me.cbVeryLarge.Width, Me.cbVeryLarge.Location.Y)
        Me.cbSmall.Location = New Point(Me.cbMedium.Location.X + Me.cbVeryLarge.Width, Me.cbVeryLarge.Location.Y)
        Me.cbVerySmall.Location = New Point(Me.cbSmall.Location.X + Me.cbVeryLarge.Width, Me.cbVeryLarge.Location.Y)

        Me.btnDiscard.Size = New Size(CInt((Me.Width / 2 - 3 * gapSmall - gapBig) / 6), heightButtons)
        Me.btnSave.Size = Me.btnDiscard.Size

        Me.btnSave.Location = New Point(Me.Width - gapSmall - Me.btnSave.Width, Me.Height - heightButtons - gapSmall)
        Me.btnDiscard.Location = New Point(Me.Width - 2 * gapSmall - 2 * Me.btnSave.Width, Me.btnSave.Location.Y)
    End Sub


#End Region

#Region "Events"
    Public Event btnMapDiscardClicked()
    Public Event btnMapSaveClicked()
#End Region
End Class
