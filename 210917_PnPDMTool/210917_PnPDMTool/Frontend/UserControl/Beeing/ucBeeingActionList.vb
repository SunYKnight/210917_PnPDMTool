Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ucBeeingActionList
#Region "Enum"

#End Region

#Region "Private Var"
    Private _editWindow As New Form()
    Private WithEvents _editUc As ucEdit(Of ucAction)
#End Region

#Region "Properties"
    Public Property ActionList As List(Of ActionType)
#End Region

#Region "Init"
    Public Sub New(actionList As List(Of ActionType))
        InitializeComponent()

        Me.ActionList = actionList

        ' Set edit window Size
        _editWindow.MinimumSize = New Size(WIDTH_CONTROL_EDIT, HEIGHT_CONTROL_EDIT)

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
        ListView_Actions.Columns.Add("Desc", 100, HorizontalAlignment.Left)

        ' Handle Items
        ListView_Actions.Items.Clear()

        ' Check for empty list 
        If (ActionList.Count > 0) Then
            ' Create Items
            For Each action In ActionList
                ListView_Actions.Items.Add(New ListViewItem(action.ToListString))
            Next
        End If


        ListView_Actions.Update()
    End Sub

    Private Sub EditAction(action As ActionType)
        ' Update uc Edit 
        _editUc = New ucEdit(Of ucAction)(New ucAction(action))

        _editWindow.Controls.Clear()
        _editWindow.Controls.Add(_editUc)
        _editWindow.Show()

    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    Private Sub editWindowSaveHandle(obj As Object, type As Type) Handles _editUc.Save
        Dim action As ActionType = CType(obj, ActionType)

        ' Close Window
        _editWindow.Hide()
        _editUc.Dispose()
        ' Macke sure name is unique
        If ActionList.FindAll(Function(p) p.Name = action.Name).Count > 0 Then
            ActionList.Remove(ActionList.Find(Function(p) p.Name = action.Name))
        End If
        ' Add Element
        ActionList.Add(action)
        ' Update list
        UpdateListView()
    End Sub

    Private Sub editWindowDiscardHandle(obj As Object) Handles _editUc.Discard
        ' Close Window
        _editWindow.Hide()
        _editUc.Dispose()
    End Sub
#End Region

#Region "GUI Handle"
    Private Sub Button_new_Click(sender As Object, e As EventArgs) Handles Button_new.Click
        EditAction(New ActionType(ActionType.eType.Attack))
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        ' Check if any item is selected
        If (ListView_Actions.SelectedItems.Count > 0) Then
            EditAction(ActionList.Find(Function(p) p.Name = ListView_Actions.SelectedItems(0).SubItems(0).Text))
        End If
    End Sub
#End Region
End Class
