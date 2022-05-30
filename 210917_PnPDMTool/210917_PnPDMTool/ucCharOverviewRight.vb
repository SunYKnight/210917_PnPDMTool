Imports _210917_PnPDMTool.C

Public Class UcCharOverviewRight
#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.txtInfo2.Size = New Size(CInt((Me.Width - 2 * gapSmall) / 3), Me.Height - 2 * gapSmall)
        Me.txtInfo3.Size = New Size(Me.Width - Me.txtInfo2.Width - 2 * gapSmall, Me.txtInfo2.Height)

        Me.txtInfo2.Location = New Point(0, gapSmall)
        Me.txtInfo3.Location = New Point(Me.txtInfo2.Width + gapSmall, gapSmall)
    End Sub

#End Region

#Region "Events"

#End Region
End Class
