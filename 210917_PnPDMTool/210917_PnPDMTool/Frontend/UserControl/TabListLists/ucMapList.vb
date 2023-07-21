Imports _210917_PnPDMTool.C

Public Class ucMapList

#Region "Enum"
    Public Enum eGuiEvent
        newMap
        editMap
        loadMap
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
        RaiseEvent guiEvent(eGuiEvent.newMap, Nothing)
    End Sub

    Private Sub btnEditOpponent_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            RaiseEvent guiEvent(eGuiEvent.editMap, listView_Items.SelectedItems(0))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoadOpponent_Click(sender As Object, e As EventArgs) Handles Button_load.Click

        Try
            RaiseEvent guiEvent(eGuiEvent.loadMap, listView_Items.SelectedItems(0))
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Pubilc Sub"

    Public Sub UpdateListView(list As List(Of MapType))
        ' Handle Header
        listView_Items.Columns.Clear()
        ' Adding ListView Columns
        listView_Items.Columns.Add("Name", 200, HorizontalAlignment.Left)
        listView_Items.Columns.Add("WxH", 60, HorizontalAlignment.Left)

        ' Handle Items
        listView_Items.Items.Clear()

        ' Check for empty list 
        If (list.Count > 0) Then
            ' Create Items
            For Each l In list
                listView_Items.Items.Add(New ListViewItem(l.ToListString(listView_Items.Columns.Count)))
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

        Me.lbOpponents.Location = New Point(0, 0)
        Me.listView_Items.Location = New Point(GAP_SMALL, HEIGHT_TITLE)

        Me.btnNew.Location = New Point(GAP_SMALL, Me.Height - 2 * GAP_SMALL - 2 * HEIGHT_BUTTON)
        Me.btnEdit.Location = New Point(2 * GAP_SMALL + Me.btnNew.Width, Me.btnNew.Location.Y)
    End Sub
#End Region

#Region "Events"
    Public Event guiEvent(evt As eGuiEvent, arg As Object)
#End Region

End Class
