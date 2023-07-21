Imports System.Runtime.Intrinsics
Imports _210917_PnPDMTool.C

Public Class ucOpponentList

#Region "Enum"
    Public Enum eGuiEvent
        newMonster
        editMonster
        addToBattle
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
    Private Sub btnNewOpponent_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        RaiseEvent guiEvent(eGuiEvent.newMonster, New BeeingType() With {.BType = BeeingType.eBType.Monster})
    End Sub

    Private Sub btnEditOpponent_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        RaiseEvent guiEvent(eGuiEvent.editMonster, listView_Items.SelectedItems(0))
    End Sub

    Private Sub btnAddToBattle_Click(sender As Object, e As EventArgs) Handles btnAddToBattle.Click
        RaiseEvent guiEvent(eGuiEvent.addToBattle, listView_Items.SelectedItems(0))
    End Sub
#End Region

#Region "Pubilc Sub"

    Public Sub UpdateListView(monsterList As List(Of BeeingType))
        ' Handle Header
        listView_Items.Columns.Clear()
        ' Adding ListView Columns
        listView_Items.Columns.Add("Name", 200, HorizontalAlignment.Left)
        listView_Items.Columns.Add("CR", 60, HorizontalAlignment.Left)

        ' Handle Items
        listView_Items.Items.Clear()

        ' Check for empty list 
        If (monsterList.Count > 0) Then
            ' Create Items
            For Each monster In monsterList
                listView_Items.Items.Add(New ListViewItem(monster.ToListString(listView_Items.Columns.Count)))
            Next
        End If

        listView_Items.Update()
    End Sub

    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbOpponents.Size = New Size(Me.Width, HEIGHT_TITLE)
        Me.listView_Items.Size = New Size(Me.Width - 2 * GAP_SMALL, Me.Height - 3 * GAP_SMALL - 2 * HEIGHT_BUTTON - HEIGHT_TITLE)

        Me.btnNew.Size = New Size(CInt((Me.Width - 3 * GAP_SMALL) / 2), HEIGHT_BUTTON)
        Me.btnEdit.Size = New Size(Me.Width - 3 * GAP_SMALL - Me.btnNew.Width, HEIGHT_BUTTON)
        Me.btnAddToBattle.Size = New Size(Me.Width - 2 * GAP_SMALL, HEIGHT_BUTTON)

        Me.lbOpponents.Location = New Point(0, 0)
        Me.listView_Items.Location = New Point(GAP_SMALL, HEIGHT_TITLE)

        Me.btnNew.Location = New Point(GAP_SMALL, Me.Height - 2 * GAP_SMALL - 2 * HEIGHT_BUTTON)
        Me.btnEdit.Location = New Point(2 * GAP_SMALL + Me.btnNew.Width, Me.btnNew.Location.Y)
        Me.btnAddToBattle.Location = New Point(GAP_SMALL, Me.Height - GAP_SMALL - HEIGHT_BUTTON)
    End Sub
#End Region

#Region "Events"
    Public Event guiEvent(evt As eGuiEvent, arg As Object)
#End Region

End Class
