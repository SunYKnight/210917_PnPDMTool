﻿Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucAction
#Region "Enum"

#End Region

#Region "Private Var"
    Private WithEvents _editWindow As Form
    Private WithEvents _editUc As ucEdit(Of ucAttack)
#End Region

#Region "Properties"
    Public Property Action As BaseAction
#End Region

#Region "Init"
    Public Sub New(action As BaseAction)
        ' Save action
        Me.Action = action

        ' Call common New
        NewCommon()
    End Sub

#End Region

#Region "Private Sub"
    Private Sub NewCommon()
        ' Locals
        Dim dataSrc = System.Enum.GetNames(GetType(eAttribut))

        ' Initilaize components
        InitializeComponent()

        ' Get Combobox values
        ComboBox_Type.DataSource = System.Enum.GetValues(GetType(BaseAction.eType))

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
        Dim cBat As New ComboboxBinder(Of BaseAction.eType)(ComboBox_Type, Action, "Type")

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

    Private Sub EditAttack(attack As BaseAttack)
        ' Update uc Edit 
        _editUc = New ucEdit(Of ucAttack)(New ucAttack(attack))

        ' Update edit Window
        _editWindow = New Form() With {
        .MinimumSize = New Size(WIDTH_CONTROL_EDIT, HEIGHT_CONTROL_EDIT)}
        _editWindow.Controls.Add(_editUc)
        _editWindow.Show()
    End Sub

#End Region

#Region "Pubilc Sub"
    Public Function Save() As Object
        Return Action
    End Function

    Public Function GetOutputType() As Type
        Return GetType(BaseAction)
    End Function
#End Region

#Region "Events"
    Private Sub WindowCLoseHandle(sender As Object, e As EventArgs) Handles _editWindow.Closed
        _editWindow.Dispose()
    End Sub

    Private Sub editWindowSaveHandle(obj As Object, type As Type) Handles _editUc.Save
        ' Locals
        Dim attack As BaseAttack = CType(obj, BaseAttack)

        ' Close Window
        _editWindow.Hide()
        ' _editUc.Dispose()
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
        ' _editUc.Dispose()
    End Sub
#End Region

#Region "GUI Handle"
    Private Sub Button_new_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        EditAttack(New BaseAttack())
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        ' Check if any item is selected
        If (ListView_attackList.SelectedItems.Count > 0) Then
            EditAttack(Action.AttackList.Find(Function(p) p.Name = ListView_attackList.SelectedItems(0).SubItems(0).Text))
        End If
    End Sub
#End Region
End Class
