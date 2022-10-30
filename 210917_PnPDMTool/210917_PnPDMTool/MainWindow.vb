Imports _210917_PnPDMTool.C

Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size

    Private _ucTabDetails As ucTabDetailsControl
    Private _ucTabList As ucTabListsControl
    Private _ucMapView As UcMapView
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()
        InitializeComponent()

        _ucTabList = New ucTabListsControl()
        _ucTabDetails = New ucTabDetailsControl()
        _ucMapView = New UcMapView()

        FlowLayoutPanel_Left.Controls.Add(_ucTabList)
        FlowLayoutPanel_Left.Controls.Add(_ucTabDetails)
        FlowLayoutPanel_Center.Controls.Add(_ucMapView)

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

End Class
