Public Class MainWindow
#Region "Private Var"
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
#End Region

#Region "Pubilc Sub"
#End Region

#Region "Events"
#End Region

End Class
