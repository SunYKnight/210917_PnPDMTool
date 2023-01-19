Imports _210917_PnPDMTool.C

Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size

    Private WithEvents _ucTabBeeingDetails As ucTabDetailsControl = New ucTabDetailsControl
    Private WithEvents _ucTabBeeingLists As ucTabListsControl = New ucTabListsControl
    Private WithEvents _ucMapView As UcMapView = New UcMapView
    Private WithEvents _ucEditBeeing As ucEdit(Of ucBeeing)
#End Region

#Region "Properties"
    Public Property BeeingList As New List(Of BeeingType)
#End Region

#Region "Init"
    Public Sub New()
        InitializeComponent()


        ' Add to layout
        FlowLayoutPanel_Left.Controls.Add(_ucTabBeeingLists)
        FlowLayoutPanel_Left.Controls.Add(_ucTabBeeingDetails)
        FlowLayoutPanel_Center.Controls.Add(_ucMapView)

        ' Call resize handler
        Me.Size = Me.Size

        ' Notification
        LoggingNotificationHandle("MainWindow Load Complete!")

        ' Load Data 
        ' TODO

        ' Update Data
        _ucTabBeeingLists.UcMonsterView1.UpdateListView(BeeingList)

    End Sub
#End Region

#Region "Private Sub"

    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize


        ' Handle window size
        If Me.Size.Width < Me.MinimumSize.Width Then
            Me.Size = New Size(Me.MinimumSize.Width, Me.Size.Height)
        End If

        If Me.Size.Height < Me.MinimumSize.Height Then
            Me.Size = New Size(Me.Size.Width, Me.MinimumSize.Height)
        End If
        innerSize = New Size(Me.Size.Width - 15, Me.Size.Height - 39)

    End Sub

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "Event Handle"

    Private Sub TabListEventHandle(evt As ucTabListsControl.eGuiEvent, arg As Object) Handles _ucTabBeeingLists.guiEvent
        Select Case evt
            Case ucTabListsControl.eGuiEvent.nextTurn
            Case ucTabListsControl.eGuiEvent.removePlayableObject
            Case ucTabListsControl.eGuiEvent.newPlayableObject
            Case ucTabListsControl.eGuiEvent.newMonster
                _ucEditBeeing = New ucEdit(Of ucBeeing)(New ucBeeing(New BeeingType))
                FlowLayoutPanel_Center.Controls.Clear()
                FlowLayoutPanel_Center.Controls.Add(_ucEditBeeing)
                FlowLayoutPanel_Center.Update()
            Case ucTabListsControl.eGuiEvent.editMonster
                ' Check if any item is selected
                If (_ucTabBeeingLists.UcMonsterView1.listView_Opponents.SelectedItems.Count > 0) Then
                    Dim beeing = BeeingList.Find(Function(p) p.Name = _ucTabBeeingLists.UcMonsterView1.listView_Opponents.SelectedItems(0).SubItems(0).Text)
                    _ucEditBeeing = New ucEdit(Of ucBeeing)(New ucBeeing(beeing))
                    FlowLayoutPanel_Center.Controls.Clear()
                    FlowLayoutPanel_Center.Controls.Add(_ucEditBeeing)
                    FlowLayoutPanel_Center.Update()
                End If
                ' Todo change to selected Beeing

            Case ucTabListsControl.eGuiEvent.endBattle
            Case Else
        End Select
    End Sub

    Private Sub EditMonsterSaveEvent(obj As Object, type As Type) Handles _ucEditBeeing.Save
        ' Locals
        Dim beeing As BeeingType = CType(obj, BeeingType)

        ' Close Window
        _ucEditBeeing.Dispose()
        ' Macke sure name is unique
        If BeeingList.FindAll(Function(p) p.Name = beeing.Name).Count > 0 Then
            BeeingList.Remove(BeeingList.Find(Function(p) p.Name = beeing.Name))
        End If
        ' Add Element
        BeeingList.Add(beeing)
        ' Update list
        _ucTabBeeingLists.UcMonsterView1.UpdateListView(BeeingList)

        FlowLayoutPanel_Center.Controls.Clear()
        FlowLayoutPanel_Center.Controls.Add(_ucMapView)
        FlowLayoutPanel_Center.Update()
    End Sub

    Private Sub EditMonsterDiscardEvent(obj As Object) Handles _ucEditBeeing.Discard

        ' Find dublicated in Beeing list

        FlowLayoutPanel_Center.Controls.Clear()
        FlowLayoutPanel_Center.Controls.Add(_ucMapView)
        FlowLayoutPanel_Center.Update()
    End Sub

    Private Sub LoggingNotificationHandle(txt As String) Handles _ucTabBeeingLists.LoggingNotification, _ucTabBeeingDetails.LoggingNotification, _ucMapView.LoggingNotification
        _ucTabBeeingDetails.Log(txt)
    End Sub
#End Region

End Class
