Public Class ucTile
#Region "Enum"

#End Region

#Region "Private Var"
    Private ProgressBar_Hp As New VerticalProgressBar
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ProgressBar_Hp.Dock = DockStyle.Left
        ProgressBar_Hp.Visible = False
        Me.Controls.Add(ProgressBar_Hp)

        ProgressBar_Hp.Minimum = 0
        ProgressBar_Hp.Maximum = 1
        ProgressBar_Hp.Value = 0.5

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
