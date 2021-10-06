Imports _210917_PnPDMTool.C

Public Class ucPlayer

#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        RaiseEvent btnPlayerDiscardClicked()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaiseEvent btnPlayerSaveClicked()
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        'Title
        Me.lbPlayer.Size = New Size(Me.Width - gapSmall, heightTitle)
        Me.lbPlayer.Location = New Point(gapSmall, 0)

        'Abilities
        Me.lbStr.Size = New Size(widthTxtMedium, heightTxtBox)
        Me.lbDex.Size = Me.lbStr.Size
        Me.lbCon.Size = Me.lbStr.Size
        Me.lbWis.Size = Me.lbStr.Size
        Me.lbInt.Size = Me.lbStr.Size
        Me.lbCha.Size = Me.lbStr.Size
        Me.txtStr.Size = New Size(widthTxtSmall, heightTxtBox)
        Me.txtDex.Size = Me.txtStr.Size
        Me.txtCon.Size = Me.txtStr.Size
        Me.txtWis.Size = Me.txtStr.Size
        Me.txtInt.Size = Me.txtStr.Size
        Me.txtCha.Size = Me.txtStr.Size

        Me.lbStr.Location = New Point(gapSmall, heightTitle + gapMedium)
        Me.lbDex.Location = New Point(gapSmall, Me.lbStr.Location.Y + heightTxtBox + gapSmall)
        Me.lbCon.Location = New Point(gapSmall, Me.lbDex.Location.Y + heightTxtBox + gapSmall)
        Me.lbWis.Location = New Point(gapSmall, Me.lbCon.Location.Y + heightTxtBox + gapSmall)
        Me.lbInt.Location = New Point(gapSmall, Me.lbWis.Location.Y + heightTxtBox + gapSmall)
        Me.lbCha.Location = New Point(gapSmall, Me.lbInt.Location.Y + heightTxtBox + gapSmall)
        Me.txtStr.Location = New Point(gapSmall + widthTxtMedium, Me.lbStr.Location.Y)
        Me.txtDex.Location = New Point(gapSmall + widthTxtMedium, Me.lbDex.Location.Y)
        Me.txtCon.Location = New Point(gapSmall + widthTxtMedium, Me.lbCon.Location.Y)
        Me.txtWis.Location = New Point(gapSmall + widthTxtMedium, Me.lbWis.Location.Y)
        Me.txtInt.Location = New Point(gapSmall + widthTxtMedium, Me.lbInt.Location.Y)
        Me.txtCha.Location = New Point(gapSmall + widthTxtMedium, Me.lbCha.Location.Y)

        'AC & HP
        Me.lbAc.Size = Me.lbStr.Size
        Me.lbHP.Size = Me.lbStr.Size
        Me.txtAc.Size = Me.txtStr.Size
        Me.txtHp.Size = Me.txtStr.Size

        Me.lbAc.Location = New Point(gapSmall, Me.lbCha.Location.Y + 2 * heightTxtBox + 2 * gapSmall)
        Me.lbHP.Location = New Point(gapSmall, Me.lbAc.Location.Y + heightTxtBox + gapSmall)
        Me.txtAc.Location = New Point(gapSmall + widthTxtMedium, Me.lbAc.Location.Y)
        Me.txtHp.Location = New Point(gapSmall + widthTxtMedium, Me.lbHP.Location.Y)

        'Name and Image
        Me.lbName.Size = New Size(widthTxtMedium, heightTxtBox)
        Me.lbImage.Size = Me.lbName.Size
        Me.txtName.Size = New Size(Me.Width - gapSmall - widthTxtSmall - widthTxtMedium - 3 * gapBig - widthTxtMedium - gapSmall, heightTxtBox)
        Me.txtImage.Size = Me.txtName.Size

        Me.lbName.Location = New Point(gapSmall + widthTxtSmall + widthTxtMedium + 3 * gapBig, Me.lbStr.Location.Y)
        Me.lbImage.Location = New Point(Me.lbName.Location.X, Me.lbDex.Location.Y)
        Me.txtName.Location = New Size(Me.lbName.Location.X + widthTxtMedium, Me.lbName.Location.Y)
        Me.txtImage.Location = New Size(Me.txtName.Location.X, Me.lbImage.Location.Y)

        'Buttons
        Me.btnDiscard.Size = New Size(CInt((Me.Width / 2 - 3 * gapSmall - gapBig) / 6), heightButtons)
        Me.btnSave.Size = Me.btnDiscard.Size

        Me.btnSave.Location = New Point(Me.Width - gapSmall - Me.btnSave.Width, Me.Height - heightButtons - gapSmall)
        Me.btnDiscard.Location = New Point(Me.Width - 2 * gapSmall - 2 * Me.btnSave.Width, Me.btnSave.Location.Y)
    End Sub
#End Region

#Region "Events"
    Public Event btnPlayerDiscardClicked()
    Public Event btnPlayerSaveClicked()
#End Region
End Class
