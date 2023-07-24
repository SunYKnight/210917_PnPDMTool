Imports _210917_PnPDMTool.C

Public Class UcBattleView
#Region "Enum"
    Public Enum eGuiEvent
        newPlayableObject
        editPlayableObject
        removePlayableObject
        changeSelectedPo
        nextTurn
        endBattle
    End Enum
#End Region
#Region "Private Var"
#End Region

#Region "Properties"
#End Region

#Region "Init"
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub
#End Region

#Region "Private Sub"
    Private Sub btnNewPlayer_Click(sender As Object, e As EventArgs) Handles btnNewPlayer.Click
        RaiseEvent guiEvent(eGuiEvent.newPlayableObject, Nothing)
    End Sub

    Private Sub btnEditPlayer_Click(sender As Object, e As EventArgs) Handles btnEditPlayer.Click
        RaiseEvent guiEvent(eGuiEvent.editPlayableObject, Nothing)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RaiseEvent guiEvent(eGuiEvent.removePlayableObject, Nothing)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        RaiseEvent guiEvent(eGuiEvent.nextTurn, Nothing)
    End Sub

    Private Sub btnEndBattle_Click(sender As Object, e As EventArgs) Handles btnEndBattle.Click
        RaiseEvent guiEvent(eGuiEvent.endBattle, Nothing)
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub UpdateListView(poList As List(Of PlayableObject))
        ' Locals
        Dim idx As Integer = 0

        ' Handle Header
        listViewBattle.Columns.Clear()
        ' Adding ListView Columns
        listViewBattle.Columns.Add("Name", 60, HorizontalAlignment.Left)
        listViewBattle.Columns.Add("Initative", 60, HorizontalAlignment.Left)
        listViewBattle.Columns.Add("Hp", 60, HorizontalAlignment.Left)

        ' Handle Items
        listViewBattle.Items.Clear()

        ' Check for empty list 
        If (poList.Count > 0) Then
            ' Create Items
            For Each po In poList
                listViewBattle.Items.Add(New ListViewItem(po.ToListString(listViewBattle.Columns.Count, idx)))
                idx += 1
            Next
        End If

        listViewBattle.Update()
    End Sub

    Private Sub listViewBattle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewBattle.SelectedIndexChanged
        RaiseEvent guiEvent(eGuiEvent.changeSelectedPo, listViewBattle.SelectedItems.Item(0))
    End Sub
#End Region

#Region "Events"
    Public Event guiEvent(evt As eGuiEvent, arg As Object)
#End Region
End Class
