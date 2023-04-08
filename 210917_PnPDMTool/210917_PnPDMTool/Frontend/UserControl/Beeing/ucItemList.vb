Public Class ucItemList(Of t)

    Private _list As List(Of t)

    Public Sub New(ByRef list As List(Of t), title As String, is_edit As Boolean)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        Label_title.Text = title
        ComboBox_source.DataSource = System.Enum.GetValues(GetType(t))
        _list = list

        ' Disable edit controls
        ComboBox_source.Visible = is_edit
        Button_add.Visible = is_edit
        Button_remove.Visible = is_edit
        If Not is_edit Then
            ListBox_items.Height += (Button_add.Height + ComboBox_source.Height - 10)
        End If

        UpdateListView()
    End Sub

    Private Sub UpdateListView()
        ListBox_items.Items.Clear()
        For Each itm In _list
            ListBox_items.Items.Add(itm)
        Next
    End Sub

    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        ' Check if langages not already exist
        If (_list.IndexOf(ComboBox_source.SelectedItem) = -1) Then
            _list.Add(ComboBox_source.SelectedItem)
            UpdateListView()
        End If
    End Sub

    Private Sub Button_remove_Click(sender As Object, e As EventArgs) Handles Button_remove.Click
        _list.Remove(ListBox_items.SelectedItem)
        UpdateListView()
    End Sub
End Class
