Public Class MainWindow
#Region "Private Var"

    'Panel and Window Size in the Beginning
    Dim pnlBattleViewMin As Rectangle = New Rectangle(12, 12, 308, 490)
    Dim pnlOpponentsViewMin As Rectangle = New Rectangle(326, 12, 308, 490)
    Dim pnlMapViewMin As Rectangle = New Rectangle(653, 12, 1240, 741)
    Dim pnlCharOverviewLeftMin As Rectangle = New Rectangle(12, 514, 622, 515)
    Dim pnlCharOverviewRightMin As Rectangle = New Rectangle(634, 772, 1259, 257)
    Dim windowSizeMin As Size = New Size(1920, 1080)
    Dim gapSmall As Int32 = 6
    Dim gapMedium As Int32 = 12
    Dim gapBig As Int32 = 19

#End Region

#Region "Properties"
#End Region

#Region "Private Sub"
#End Region

#Region "Init"
    Public Sub Init()
        InitializeComponent()
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        changeSizeAndPositionOfPanels()
        changeSizeOfUserControls()
    End Sub

    Private Sub changeSizeAndPositionOfPanels()
        Dim newSize As Size = Me.Size

        If Me.Size.Width < 1920 Then
            Me.Size = New Size(1920, newSize.Height)
        End If

        newSize = Me.Size

        If Me.Size.Height < 1080 Then
            Me.Size = New Size(newSize.Width, 1080)
        End If

        newSize = Me.Size
        Dim newInnerSize As Size = New Size(newSize.Width - 15, newSize.Height - 39)
        Dim widthRatio As Single = newSize.Width / 1920
        Dim heightRatio As Single = newSize.Height / 1080

        'pnlBattleView & pnlOpponentsView (same size)
        pnlBattleView.Size = New Size(CInt(pnlBattleViewMin.Width * widthRatio), CInt(pnlBattleViewMin.Height * heightRatio))
        pnlBattleView.Location = New Point(pnlBattleViewMin.X, pnlBattleViewMin.Y)
        pnlOpponentsView.Size = pnlBattleView.Size
        pnlOpponentsView.Location = New Point(gapMedium + pnlBattleView.Width + gapSmall, pnlOpponentsViewMin.Y)

        'pnlCharOverviewLeft & pnlCharOverviewRight
        pnlCharOverviewLeft.Size = New Size(2 * pnlBattleView.Width + gapSmall, newInnerSize.Height - 3 * gapMedium - pnlBattleView.Height)
        pnlCharOverviewLeft.Location = New Point(pnlCharOverviewLeftMin.X, 2 * gapMedium + pnlBattleView.Height)
        pnlCharOverviewRight.Size = New Size(newInnerSize.Width - 2 * gapMedium - pnlCharOverviewLeft.Width, CInt(pnlCharOverviewRightMin.Height * heightRatio))
        pnlCharOverviewRight.Location = New Point(gapMedium + pnlCharOverviewLeft.Width, newInnerSize.Height - gapMedium - pnlCharOverviewRight.Height)

        'pnlMapView
        pnlMapView.Size = New Size(newInnerSize.Width - 2 * gapMedium - gapBig - pnlCharOverviewLeft.Width, newInnerSize.Height - pnlCharOverviewRight.Height - 2 * gapMedium - gapBig)
        pnlMapView.Location = New Point(gapMedium + gapBig + pnlCharOverviewLeft.Width, pnlMapViewMin.Y)
    End Sub
    Private Sub changeSizeOfUserControls()
        ucBattleView1.Size = pnlBattleView.Size
        ucOpponentsView1.Size = pnlOpponentsView.Size
        ucCharOverviewLeft1.Size = pnlCharOverviewLeft.Size
        ucCharOverviewRight1.Size = pnlCharOverviewRight.Size
        ucMapView1.Size = pnlMapView.Size
    End Sub
#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
#End Region

End Class
