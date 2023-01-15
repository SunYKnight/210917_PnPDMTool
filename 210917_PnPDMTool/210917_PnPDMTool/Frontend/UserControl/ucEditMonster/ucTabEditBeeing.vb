Public Class ucTabEditBeeing
#Region "Enum"

#End Region

#Region "Private Var"
    Private WithEvents _ucEdit As ucEdit(Of ucBeeing)
    Private WithEvents _ucBeeing As New ucBeeing()
#End Region

#Region "Properties"
#End Region

#Region "Init"
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        _ucEdit = New ucEdit(Of ucBeeing)(_ucBeeing)
        _mainLayout.Controls.Add(_ucEdit)

        Me.MinimumSize = _ucBeeing.MinimumSize

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
    Private Sub ButtonExitClickedHandler() Handles _ucEdit.Discard
        RaiseEvent ButtonExitClicked()
    End Sub

    Private Sub ButtonSaveClickedHandler() Handles _ucEdit.Discard
        RaiseEvent ButtonSaveClicked()
    End Sub
#End Region
End Class
