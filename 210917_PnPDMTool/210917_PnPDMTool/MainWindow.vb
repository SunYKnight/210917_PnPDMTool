Public Class MainWindow
#Region "Private Var"

    'Panel and Window Size in the Beginning
    Dim pnlBattleViewMin As Rectangle = New Rectangle(12, 12, 308, 490)
    Dim pnlOpponentsViewMin As Rectangle = New Rectangle(326, 12, 308, 490)
    Dim pnlMapViewMin As Rectangle = New Rectangle(652, 12, 1230, 640)
    Dim pnlCharOverviewLeftMin As Rectangle = New Rectangle(12, 508, 621, 489)
    Dim pnlCharOverviewRightMin As Rectangle = New Rectangle(633, 671, 1249, 326)
    Dim windowSizeMin As Size = New Size(1920, 1080)

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
        If Me.Size.Width < 1920 Then
            Me.Size = New Size(1920 / 2, 1080 / 2)
        End If
    End Sub

    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'changeSizeAndPositionOfPanels()
    End Sub

    Private Sub changeSizeAndPositionOfPanels()
        If Me.Size.Width < 1920 Then
            Me.Size = New Size(1920, 1080)
            pnlBattleView.Size = pnlBattleViewMin.Size
            pnlBattleView.Location = pnlBattleViewMin.Location
            pnlOpponentsView.Size = pnlOpponentsViewMin.Size
            pnlOpponentsView.Location = pnlOpponentsViewMin.Location
            pnlMapView.Size = pnlMapViewMin.Size
            pnlMapView.Location = pnlMapViewMin.Location
            pnlCharOverviewLeft.Size = pnlCharOverviewLeftMin.Size
            pnlCharOverviewLeft.Location = pnlCharOverviewLeftMin.Location
            pnlCharOverviewRight.Size = pnlCharOverviewRightMin.Size
            pnlCharOverviewRight.Location = pnlCharOverviewRightMin.Location
        Else
            Dim newSize As Size = Me.Size
            Dim newInnerSize As Size = New Size(newSize.Width - 26, newSize.Height - 71)
            Dim widthRatio As Single = newSize.Width / 1920
            Dim heightRatio As Single = newSize.Height / 1080

            'pnlBattleView & pnlOpponentsView (same size)
            pnlBattleView.Size = New Size(CInt(pnlBattleViewMin.Width * widthRatio), CInt(pnlBattleViewMin.Height * heightRatio))
            pnlBattleView.Location = New Point(pnlBattleViewMin.X, pnlBattleViewMin.Y)
            pnlOpponentsView.Size = pnlBattleView.Size
            pnlOpponentsView.Location = New Point(12 + pnlBattleView.Width + 6, pnlOpponentsViewMin.Y)

            'pnlCharOverviewLeft & pnlCharOverviewRight
            pnlCharOverviewLeft.Size = New Size(2 * pnlBattleView.Width + 6, newInnerSize.Height - 12 - pnlBattleView.Height - 6 - 12)
            pnlCharOverviewLeft.Location = New Point(pnlCharOverviewLeftMin.X, 12 + pnlBattleView.Height + 6)
            pnlCharOverviewRight.Size = New Size(newInnerSize.Width - 12 - pnlCharOverviewLeft.Width - 12, CInt(pnlCharOverviewRightMin.Height * heightRatio))
            pnlCharOverviewRight.Location = New Point(12 + pnlCharOverviewLeft.Width, newInnerSize.Height - 12 - pnlCharOverviewRight.Height)

            'pnlMapView
            pnlMapView.Size = New Size(newInnerSize.Width - 12 - pnlCharOverviewLeft.Width - 19 - 12, newInnerSize.Height - 12 - 19 - pnlCharOverviewRight.Height - 12)
            pnlMapView.Location = New Point(12 + pnlCharOverviewLeft.Width + 19, pnlMapViewMin.Y)

            'userControls
            ucBattleView1.Size = pnlBattleView.Size
            ucOpponentsView1.Size = pnlOpponentsView.Size
            ucCharOverviewLeft1.Size = pnlCharOverviewLeft.Size
            ucCharOverviewRight1.Size = pnlCharOverviewRight.Size
            ucMapView1.Size = pnlMapView.Size
        End If
    End Sub
#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
#End Region

End Class
