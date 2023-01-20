Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucAction
#Region "Enum"

#End Region

#Region "Private Var"
    Private _editWindow As New Form()
    Private WithEvents _editUc As ucEdit(Of ucAttack)
#End Region

#Region "Properties"
    Public Property Action As ActionType
#End Region

#Region "Init"
    Public Sub New(action As ActionType)
        ' Save action
        Me.Action = action

        ' Call common New
        NewCommon()
    End Sub

#End Region

#Region "Private Sub"
    Private Sub NewCommon()
        ' Locals
        Dim dataSrc = System.Enum.GetNames(GetType(eAttributes))

        ' Initilaize components
        InitializeComponent()

        ' Set edit window Size
        _editWindow.MinimumSize = New Size(WIDTH_CONTROL_EDIT, HEIGHT_CONTROL_EDIT)

        ' Get Combobox values
        ComboBox_Type.DataSource = System.Enum.GetValues(GetType(ActionType.eType))

        ' Set minimum size
        Me.MinimumSize = New Size(WIDTH_CONTROL_EDIT, HEIGHT_CONTROL_EDIT)

        ' Name
        RichTextBox_name.DataBindings.Clear()
        RichTextBox_name.DataBindings.Add(New Binding("Text", Action, "Name"))

        ' Description
        RichTextBox_Description.DataBindings.Clear()
        RichTextBox_Description.DataBindings.Add(New Binding("Text", Action, "Description"))

        ' Type
        ' Damage Type
        Dim cBat As New ComboboxBinder(Of ActionType.eType)(ComboBox_Type, Action, "Type")

        UpdateListView()
    End Sub

    Private Sub UpdateListView()
        ' Handle Header
        ListView_attackList.Columns.Clear()
        ' Adding ListView Columns
        ListView_attackList.Columns.Add("Name", 40, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("Hit", 35, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("Type", 100, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("Range", 50, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("D4", 30, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("D6", 30, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("D8", 30, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("D12", 35, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("D20", 35, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("D100", 40, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("Dmg", 40, HorizontalAlignment.Left)
        ListView_attackList.Columns.Add("Description", 200, HorizontalAlignment.Left)

        ' Handle Items
        ListView_attackList.Items.Clear()

        ' Check for empty list 
        If (Action.AttackList.Count > 0) Then
            ' Create Items
            For Each atk In Action.AttackList
                ListView_attackList.Items.Add(New ListViewItem(atk.ToListString))
            Next
        End If

        ListView_attackList.Update()
    End Sub

    Private Sub EditAttack(attack As AttackType)
        ' Update uc Edit 
        _editUc = New ucEdit(Of ucAttack)(New ucAttack(attack))

        ' Update edit Window
        _editWindow.Controls.Clear()
        _editWindow.Controls.Add(_editUc)
        _editWindow.Show()
    End Sub

#End Region

#Region "Pubilc Sub"
    Public Function Save() As Object
        Return Action
    End Function

    Public Function GetOutputType() As Type
        Return GetType(ActionType)
    End Function
#End Region

#Region "Events"
    Private Sub editWindowSaveHandle(obj As Object, type As Type) Handles _editUc.Save
        ' Locals
        Dim attack As AttackType = CType(obj, AttackType)

        ' Close Window
        _editWindow.Hide()
        _editUc.Dispose()
        ' Macke sure name is unique
        If Action.AttackList.FindAll(Function(p) p.Name = attack.Name).Count > 0 Then
            Action.AttackList.Remove(Action.AttackList.Find(Function(p) p.Name = attack.Name))
        End If
        ' Add Element
        Action.AttackList.Add(attack)
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
    Private Sub Button_new_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        EditAttack(New AttackType())
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        ' Check if any item is selected
        If (ListView_attackList.SelectedItems.Count > 0) Then
            EditAttack(Action.AttackList.Find(Function(p) p.Name = ListView_attackList.SelectedItems(0).SubItems(0).Text))
        End If
    End Sub
#End Region
End Class
