Public Class ucTabDetailsControl
#Region "Enum"

#End Region

#Region "Private Var"
    Private _richTextBox As RichTextBox
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        _richTextBox = New RichTextBox()
        _richTextBox.Dock = DockStyle.Fill
        _richTextBox.ReadOnly = True

        TabControl1.Controls.Item(2).Controls.Add(_richTextBox)
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Sub Log(txt As String)
        _richTextBox.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + txt)
    End Sub
#End Region

#Region "Events"
    Public Event LoggingNotification(txt As String)
#End Region

#Region "GUI Handle"

#End Region
End Class
