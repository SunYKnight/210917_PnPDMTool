Public Class ucTabEditBeeing
#Region "Enum"

#End Region

#Region "Private Var"
    Private _ucEditMonsterGeneral As ucEditMonsterGeneral
    Private _tabPageGeneral As TabPage
    Private _tapcEditMonster As TabControl
    Private _btnSave As Button
    Private _btnExit As Button
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
        _btnSave = New Button
        _btnSave.Text = "Save"

        ' Button Exit
        _btnExit = New Button
        _btnExit.Text = "Exit"

        ' Button layout
        _btnLayout = New FlowLayoutPanel
        _btnLayout.FlowDirection = FlowDirection.RightToLeft
        ' _btnLayout.Dock = DockStyle.Bottom
        _btnLayout.MinimumSize = New Size(200, 100)
        _btnLayout.Controls.Add(_btnSave)
        _btnLayout.Controls.Add(_btnExit)

        ' _ucEditMonsterGeneral
        _ucEditMonsterGeneral = New ucEditMonsterGeneral
        _ucEditMonsterGeneral.Dock = DockStyle.Fill

        ' _tabPageGeneral
        _tabPageGeneral = New TabPage
        _tabPageGeneral.Text = "General"
        _tabPageGeneral.Dock = DockStyle.Fill
        _tabPageGeneral.Controls.Add(_ucEditMonsterGeneral)

        ' _tapcEditMonster
        _tapcEditMonster = New TabControl
        _tapcEditMonster.MinimumSize = _ucEditMonsterGeneral.MinimumSize
        ' _tapcEditMonster.Dock = DockStyle.Fill
        _tapcEditMonster.Controls.Add(_tabPageGeneral)

        ' _mainLayout
        _mainLayout.Controls.Add(_tapcEditMonster)
        _mainLayout.Controls.Add(_btnLayout)

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "Event Handle"
#End Region
End Class
