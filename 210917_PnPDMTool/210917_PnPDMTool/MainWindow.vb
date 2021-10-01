Public Class MainWindow
#Region "Private Var"
    'vars to resize panels and usercontrols
    Dim pnlBattleViewMin As Rectangle = New Rectangle(12, 13, 308, 489)
    Dim pnlOpponentsViewMin As Rectangle = New Rectangle(326, 13, 307, 489)
    Dim pnlMapViewMin As Rectangle = New Rectangle(639, 13, 1243, 652)
    Dim pnlCharOverviewLeftMin As Rectangle = New Rectangle(12, 508, 621, 489)
    Dim pnlCharOverviewRightMin As Rectangle = New Rectangle(639, 671, 1243, 326)
    Dim windowInnerSize As Size = New Size(1894, 1010)
#End Region

#Region "Properties"
    Public Property PanelBattleView As Panel
        Get
            Return pnlBattleView
        End Get
        Set(value As Panel)
            pnlBattleView = value
        End Set
    End Property

    Public Property PanelOpponentsView As Panel
        Get
            Return pnlOpponentsView
        End Get
        Set(value As Panel)
            pnlOpponentsView = value
        End Set
    End Property

#End Region

#Region "Private Sub"
#End Region

#Region "Init"
    Public Sub Init()
        InitializeComponent()

    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mainWindowSize = Me.Size

        'pnlBattleViewRec = New Rectangle(pnlBattleView.Location.X, pnlBattleView.Location.Y, pnlBattleView.Width, pnlBattleView.Height)
        'pnlOpponentsViewRec = New Rectangle(pnlOpponentsView.Location.X, pnlOpponentsView.Location.Y, pnlOpponentsView.Width, pnlOpponentsView.Height)
        'pnlMapViewRec = New Rectangle(pnlMapView.Location.X, pnlMapView.Location.Y, pnlMapView.Width, pnlMapView.Height)
        'pnlCharOverviewLeftRec = New Rectangle(pnlCharOverviewLeft.Location.X, pnlCharOverviewLeft.Location.Y, pnlCharOverviewLeft.Width, pnlCharOverviewLeft.Height)
        'pnlCharOverviewRightRec = New Rectangle(pnlCharOverviewRight.Location.X, pnlCharOverviewRight.Location.Y, pnlCharOverviewRight.Width, pnlCharOverviewRight.Height)

    End Sub

    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'If mainWindowSize.Width > 0 Then
        'changeSizeAndPosition()
        'End If
    End Sub

    'Private Sub changeSizeAndPosition()
    'change panel size and position
    ' changeSizeAndPositionMath(pnlBattleViewRec, pnlBattleView)
    'changeSizeAndPositionMath(pnlOpponentsViewRec, pnlOpponentsView)
    'changeSizeAndPositionMath(pnlMapViewRec, pnlMapView)
    'changeSizeAndPositionMath(pnlCharOverviewLeftRec, pnlCharOverviewLeft)
    'changeSizeAndPositionMath(pnlCharOverviewRightRec, pnlCharOverviewRight)

    'change usercontrol size
    'ucBattleView1.Size = New Size(pnlBattleView.Width, pnlBattleView.Height)
    'ucOpponentsView1.Size = New Size(pnlOpponentsView.Width, pnlOpponentsView.Height)
    'ucMapView1.Size = New Size(pnlMapView.Width, pnlMapView.Height)
    'ucCharOverviewLeft1.Size = New Size(pnlCharOverviewLeft.Width, pnlOpponentsView.Height)
    'ucCharOverviewRight1.Size = New Size(pnlCharOverviewRight.Width, pnlCharOverviewRight.Height)

    'End Sub

    Private Sub changeSizeAndPosition()
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
            Dim widthRatio As Single = newSize.Width / 1920
            Dim heightRatio As Single = newSize.Height / 1080

            Dim pnlBattleView_Width As Int32 = CInt(pnlBattleViewMin.Width * widthRatio)
            Dim pnlBattleView_Height As Int32 = CInt(pnlBattleViewMin.Height * heightRatio)
            Dim pnlBattleView_X As Int32 = pnlBattleViewMin.Location.X
            Dim pnlBattleView_Y As Int32 = pnlBattleViewMin.Location.Y

            Dim pnlCharOverviewLeft_Width As Int32 = CInt(pnlCharOverviewLeftMin.Width * widthRatio)
            Dim pnlCharOverviewLeft_Height As Int32 = windowInnerSize.Height - 26 - 6 - pnlBattleView_Height
            Dim pnlCharOverviewLeft_X As Int32 = pnlBattleViewMin.Location.X
            Dim pnlCharOverviewLeft_Y As Int32 = 13 + pnlBattleView_Height + 6

            Dim pnlOpponentsView_Width As Int32 = pnlCharOverviewLeft_Width - pnlBattleView_Width - 6
            Dim pnlOpponentsView_Height As Int32 = pnlBattleView_Height
            Dim pnlOpponentsView_X As Int32 = 12 + pnlBattleView_Width + 6
            Dim pnlOpponentsView_Y As Int32 = pnlOpponentsViewMin.Y






        End If



    End Sub


    'Private Sub changeSizeAndPositionMath2(originalControlRec As Rectangle, control As Control)

    'Dim xRatio As Single = Me.Width / mainWindowSize.Width
    'Dim yRatio As Single = Me.Height / mainWindowSize.Height

    'Dim newX As Single = originalControlRec.X * xRatio
    'Dim newY As Single = originalControlRec.Y * yRatio
    'Dim newWidth As Single = originalControlRec.Width * xRatio
    'Dim newHeight As Single = originalControlRec.Height * yRatio

    'control.Location = New Point(CInt(newX), CInt(newY))
    'control.Size = New Size(CInt(newWidth), CInt(newHeight))

    'End Sub


#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
#End Region

End Class
