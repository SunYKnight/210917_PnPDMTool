Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size
    Dim widthRatio As Single
    Dim heightRatio As Single

    Dim gapSmall As Int32 = 6
    Dim gapMedium As Int32 = 12
    Dim gapBig As Int32 = 18
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub Init()
        InitializeComponent()
    End Sub
#End Region

#Region "Private Sub"
    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.Size.Width < Me.MinimumSize.Width Then
            Me.Size = New Size(Me.MinimumSize.Width, Me.Size.Height)
        End If

        If Me.Size.Height < Me.MinimumSize.Height Then
            Me.Size = New Size(Me.Size.Width, Me.MinimumSize.Height)
        End If
        innerSize = New Size(Me.Size.Width - 15, Me.Size.Height - 39)

        changeSizeAndPositionOfPanels()
        changeSizeOfUserControls()
        changeSizeofUcBattleView()
    End Sub

    Private Sub changeSizeAndPositionOfPanels()
        pnlBattleView.Size = New Size(CInt((innerSize.Width - 3 * gapMedium - gapBig) / 6), CInt((innerSize.Height - 3 * gapMedium) / 2))
        pnlOpponentsView.Size = pnlBattleView.Size
        pnlCharOverviewLeft.Size = New Size(2 * pnlBattleView.Width + gapMedium, innerSize.Height - 3 * gapMedium - pnlBattleView.Height)
        pnlCharOverviewRight.Size = New Size(innerSize.Width - 2 * gapMedium - pnlCharOverviewLeft.Width, CInt((innerSize.Height - 2 * gapMedium - gapBig) / 6))
        pnlMapView.Size = New Size(pnlCharOverviewRight.Width - gapBig, innerSize.Height - 2 * gapMedium - gapBig - pnlCharOverviewRight.Height)

        pnlBattleView.Location = New Point(gapMedium, gapMedium)
        pnlOpponentsView.Location = New Point(2 * gapMedium + pnlBattleView.Width, gapMedium)
        pnlCharOverviewLeft.Location = New Point(gapMedium, 2 * gapMedium + pnlBattleView.Height)
        pnlCharOverviewRight.Location = New Point(gapMedium + pnlCharOverviewLeft.Width, gapMedium + gapBig + pnlMapView.Height)
        pnlMapView.Location = New Point(2 * gapMedium + gapBig + 2 * pnlBattleView.Width, gapMedium)
    End Sub

    Private Sub changeSizeOfUserControls()

        ucOpponentsView1.Size = pnlOpponentsView.Size
        ucCharOverviewLeft1.Size = pnlCharOverviewLeft.Size
        ucCharOverviewRight1.Size = pnlCharOverviewRight.Size
        ucMapView1.Size = pnlMapView.Size
    End Sub

    Private Sub changeSizeofUcBattleView()
        ucBattleView1.Size = pnlBattleView.Size
    End Sub
#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
#End Region

End Class
