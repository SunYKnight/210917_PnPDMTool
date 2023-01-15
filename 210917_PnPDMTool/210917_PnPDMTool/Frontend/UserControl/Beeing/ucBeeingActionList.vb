Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ucBeeingActionList
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property ActionList As New List(Of ActionType)
#End Region

#Region "Init"
    Public Sub New()
        InitializeComponent()

        Dim test_action As New ActionType(ActionType.eType.Attack) With {
            .Name = "Test",
            .Description = "Test Description"
        }

        ActionList.Add(test_action)

        UpdateListView()
    End Sub
#End Region

#Region "Private Sub"
    Private Sub UpdateListView()
        ' Handle Header
        ListView_Actions.Columns.Clear()
        ' Adding ListView Columns
        ListView_Actions.Columns.Add("Name", 100, HorizontalAlignment.Left)
        ListView_Actions.Columns.Add("Type", 100, HorizontalAlignment.Left)

        ' Handle Items
        ListView_Actions.Items.Clear()
        ' Create Items
        For Each action In ActionList
            ListView_Actions.Items.Add(New ListViewItem(action.ToListString))
        Next

        ListView_Actions.Update()
    End Sub

    Private Sub EditAction(action As ActionType)
        Dim editWindow = New Form()
        Dim ucAction As New ucAction
        Dim ucEditAction As New ucEdit(Of ucAction)(ucAction)
        editWindow.Controls.Add(ucEditAction)
        editWindow.MinimumSize = ucEditAction.MinimumSize
        editWindow.Show()

    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "GUI Handle"
    Private Sub Button_new_Click(sender As Object, e As EventArgs) Handles Button_new.Click
        EditAction(New ActionType(ActionType.eType.Attack))
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click

    End Sub
#End Region
End Class
