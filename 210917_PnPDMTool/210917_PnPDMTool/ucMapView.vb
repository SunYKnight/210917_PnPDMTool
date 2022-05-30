Imports _210917_PnPDMTool.C

Public Class UcMapView
#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"
    Private Sub btnNewMap_Click(sender As Object, e As EventArgs) Handles btnNewMap.Click
        RaiseEvent btnNewMapClicked()
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbMap.Size = New Size(Me.Width, heightTitle)
        Me.dropDownMap.Size = New Size(CInt(Me.Width / 6), heightButtons)
        Me.btnNewMap.Size = New Size(CInt(Me.dropDownMap.Width / 2), heightButtons)
        Me.pictureBoxMap.Size = New Size(Me.Width - 2 * gapSmall, Me.Height - gapSmall - heightTitle)

        Me.pictureBoxInitiative1.Size = New Size(CInt((Me.pictureBoxMap.Width - 19 * gapSmall) / 18), CInt((Me.pictureBoxMap.Width - 19 * gapSmall) / 18))
        Me.pictureBoxInitiative2.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative3.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative4.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative5.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative6.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative7.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative8.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative9.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative10.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative11.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative12.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative13.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative14.Size = Me.pictureBoxInitiative1.Size

        Me.lbMap.Location = New Point(0, 0)
        Me.dropDownMap.Location = New Point(Me.Width - gapSmall - Me.dropDownMap.Width, gapSmall)
        Me.btnNewMap.Location = New Point(Me.dropDownMap.Location.X - gapMedium - Me.btnNewMap.Width, gapSmall)
        Me.pictureBoxMap.Location = New Point(gapSmall, heightTitle)

        Me.pictureBoxInitiative1.Location = New Point(3 * gapSmall + 2 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative2.Location = New Point(4 * gapSmall + 3 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative3.Location = New Point(5 * gapSmall + 4 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative4.Location = New Point(6 * gapSmall + 5 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative5.Location = New Point(7 * gapSmall + 6 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative6.Location = New Point(8 * gapSmall + 7 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative7.Location = New Point(9 * gapSmall + 8 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative8.Location = New Point(10 * gapSmall + 9 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative9.Location = New Point(11 * gapSmall + 10 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative10.Location = New Point(12 * gapSmall + 11 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative11.Location = New Point(13 * gapSmall + 12 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative12.Location = New Point(14 * gapSmall + 13 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative13.Location = New Point(15 * gapSmall + 14 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        Me.pictureBoxInitiative14.Location = New Point(16 * gapSmall + 15 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
    End Sub
#End Region

#Region "Events"
    Public Event btnNewMapClicked()
#End Region
End Class
