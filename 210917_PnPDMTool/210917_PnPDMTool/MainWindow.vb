Imports _210917_PnPDMTool.C

Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size

    Private WithEvents _ucTabBeeingDetails As ucTabDetailsControl = New ucTabDetailsControl()
    Private WithEvents _ucTabBeeingLists As ucTabListsControl = New ucTabListsControl()
    Private WithEvents _ucMapView As UcMapView = New UcMapView()
    Private WithEvents _ucTabBeeingEdit As ucTabEditBeeing = New ucTabEditBeeing
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()
        InitializeComponent()


        ' Add to layout
        FlowLayoutPanel_Left.Controls.Add(_ucTabBeeingLists)
        FlowLayoutPanel_Left.Controls.Add(_ucTabBeeingDetails)
        FlowLayoutPanel_Center.Controls.Add(_ucMapView)

        ' Notification
        LoggingNotificationHandle("MainWindow Load Complete!")

    End Sub
#End Region

#Region "Private Sub"

    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize


        ' Handle window size
        If Me.Size.Width < Me.MinimumSize.Width Then
            Me.Size = New Size(Me.MinimumSize.Width, Me.Size.Height)
        End If

        If Me.Size.Height < Me.MinimumSize.Height Then
            Me.Size = New Size(Me.Size.Width, Me.MinimumSize.Height)
        End If
        innerSize = New Size(Me.Size.Width - 15, Me.Size.Height - 39)

    End Sub

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "Event Handle"

    Private Sub EditMonsterHandle(avt As ucTabListsControl.eGuiEvent, arg As Object) Handles _ucTabBeeingLists.guiEvent

    End Sub

    Private Sub LoggingNotificationHandle(txt As String) Handles _ucTabBeeingLists.LoggingNotification, _ucTabBeeingDetails.LoggingNotification, _ucMapView.LoggingNotification
        _ucTabBeeingDetails.Log(txt)
    End Sub
#End Region

End Class
