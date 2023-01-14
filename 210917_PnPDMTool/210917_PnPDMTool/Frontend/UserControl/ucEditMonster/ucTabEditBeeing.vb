Public Class ucTabEditBeeing
#Region "Enum"

#End Region

#Region "Private Var"
    Private WithEvents _ucBeeing As ucBeeing
    Private WithEvents _btnSave As Button
    Private WithEvents _btnExit As Button
    Private _btnLayout As FlowLayoutPanel
#End Region

#Region "Properties"
#End Region

#Region "Init"
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Button Save
        _btnSave = New Button With {
            .Text = "Save"
        }

        ' Button Exit
        _btnExit = New Button With {
            .Text = "Exit"
        }

        ' Button layout
        _btnLayout = New FlowLayoutPanel With {
            .FlowDirection = FlowDirection.RightToLeft,
            .MinimumSize = New Size(200, 100),
            .AutoSize = True
        }
        _btnLayout.Controls.Add(_btnSave)
        _btnLayout.Controls.Add(_btnExit)

        ' UC Beeing
        _ucBeeing = New ucBeeing()

        ' _mainLayout
        _mainLayout.Controls.Add(_ucBeeing)
        _mainLayout.Controls.Add(_btnLayout)
        _mainLayout.AutoSize = True

        Me.MinimumSize = New Size(_ucBeeing.MinimumSize.Width, _ucBeeing.MinimumSize.Height + _btnLayout.Height)

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    Public Event ButtonSaveClicked()
    Public Event ButtonExitClicked()
#End Region

#Region "Event Handle"
    Private Sub ButtonExitClickedHandler() Handles _btnExit.Click
        RaiseEvent ButtonExitClicked()
    End Sub

    Private Sub ButtonSaveClickedHandler() Handles _btnSave.Click
        RaiseEvent ButtonSaveClicked()
    End Sub
#End Region
End Class
