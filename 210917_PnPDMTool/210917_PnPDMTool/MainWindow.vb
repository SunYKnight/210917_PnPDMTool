Public Class MainWindow
#Region "Private Var"
    Dim ucBattleView As New UserControl
    Dim ucOppenentsView As New UserControl

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
        pnlBattleView.Controls.Add(ucBattleView)
        pnlOpponentsView.Controls.Add(ucOppenentsView)
    End Sub

    Private Sub pnlBattleView_Paint(sender As Object, e As PaintEventArgs) Handles pnlBattleView.Paint

    End Sub

    Private Sub pnlOpponentsView_Paint(sender As Object, e As PaintEventArgs) Handles pnlOpponentsView.Paint

    End Sub

#End Region

#Region "Pubilc Sub"


#End Region

#Region "Events"

#End Region


End Class
