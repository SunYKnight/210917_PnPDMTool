Imports _210917_PnPDMTool.BaseAction
Imports _210917_PnPDMTool.C

Public Class MainWindow
#Region "Private Var"
    Dim innerSize As Size

    Private WithEvents _ucTabBeeingDetails As ucTabDetailsControl = New ucTabDetailsControl
    Private WithEvents _ucTabBeeingLists As ucTabListsControl = New ucTabListsControl
    Private WithEvents _ucBattleMapView As UcBattleMapView = New UcBattleMapView
    Private WithEvents _ucEditBeeing As ucEdit(Of ucEditBeeing)
    Private WithEvents _ucEditMap As ucEdit(Of ucEditMap)
    Private WithEvents _ucPOStats As New ucPOStats
#End Region

#Region "Properties"
    Public Property BeeingList As New List(Of BeeingType)
    Public Property MapList As New List(Of MapType)
    Public Property POList As New List(Of PlayableObject)
#End Region

#Region "Init"
    Public Sub New(loadedBeeings As List(Of BeeingType), loadedMaps As List(Of MapType))
        ' Load designer
        InitializeComponent()

        ' Set Layout Dock
        FlowLayoutPanel_Left.Dock = DockStyle.Left
        FlowLayoutPanel_Center.Dock = DockStyle.Fill
        FlowLayoutPanel_Center.AutoSize = True
        FlowLayoutPanel_Center.AutoSizeMode = AutoSizeMode.GrowAndShrink

        ' Copy loaded Beeings to Propery
        BeeingList.AddRange(loadedBeeings)

        ' Copy loaded Beeings to Propery
        MapList.AddRange(loadedMaps)

        ' Add to layout
        FlowLayoutPanel_Left.Controls.Add(_ucTabBeeingLists)
        FlowLayoutPanel_Left.Controls.Add(_ucPOStats)
        FlowLayoutPanel_Center.Controls.Add(_ucBattleMapView)

        ' Call resize handler
        Me.Size = Me.Size

        ' Load Data 
        ' TODO

        ' Update Data
        _ucTabBeeingLists.UcOpponentList1.UpdateListView(BeeingList)
        ' Update Data
        _ucTabBeeingLists.UcMapList1.UpdateListView(MapList)

        ' Notification
        LoggingNotificationHandle("MainWindow Load Complete!")

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


            Case ucTabListsControl.eGuiEvent.PORemove
                Dim po = POList.Find(Function(p) p.Beeing.Metadata.Name = _ucTabBeeingLists.UcBattleView1.listViewBattle.SelectedItems(0).SubItems(0).Text)
                POList.Remove(po)
                _ucTabBeeingLists.UcBattleView1.UpdateListView(POList)


            Case ucTabListsControl.eGuiEvent.PONew


            Case ucTabListsControl.eGuiEvent.MonsterNew
                _ucEditBeeing = New ucEdit(Of ucEditBeeing)(New ucEditBeeing(CType(arg, BeeingType)))
                FlowLayoutPanel_Center.Controls.Clear()
                FlowLayoutPanel_Center.Controls.Add(_ucEditBeeing)
                FlowLayoutPanel_Center.Update()


            Case ucTabListsControl.eGuiEvent.MonsterEdit
                ' Get object from list
                Dim beeing = BeeingList.Find(Function(p) p.Metadata.Name = arg.Text)
                ' Check if any item is selected
                If Not IsNothing(beeing) Then
                    ' Create edit user control
                    _ucEditBeeing = New ucEdit(Of ucEditBeeing)(New ucEditBeeing(beeing))
                    ' Show edit control
                    FlowLayoutPanel_Center.Controls.Clear()
                    FlowLayoutPanel_Center.Controls.Add(_ucEditBeeing)
                    FlowLayoutPanel_Center.Update()
                End If


            Case ucTabListsControl.eGuiEvent.MapNew
                _ucEditMap = New ucEdit(Of ucEditMap)(New ucEditMap())
                FlowLayoutPanel_Center.Controls.Clear()
                FlowLayoutPanel_Center.Controls.Add(_ucEditMap)
                FlowLayoutPanel_Center.Update()


            Case ucTabListsControl.eGuiEvent.MapEdit
                ' Get object from list
                Dim map = MapList.Find(Function(p) p.Name = arg.Text)
                ' Check if any item is selected
                If Not IsNothing(map) Then
                    ' Create edit user control
                    _ucEditMap = New ucEdit(Of ucEditMap)(New ucEditMap(map))
                    ' Show edit control
                    FlowLayoutPanel_Center.Controls.Clear()
                    FlowLayoutPanel_Center.Controls.Add(_ucEditMap)
                    FlowLayoutPanel_Center.Update()
                End If

            Case ucTabListsControl.eGuiEvent.MapLoad
                ' Get object from list
                Dim map = MapList.Find(Function(p) p.Name = arg.Text)
                ' Load Battlemap
                _ucBattleMapView.setMap(map)


            Case ucTabListsControl.eGuiEvent.POSelectionChanged
                ' Get object from list
                Dim po = POList.Find(Function(p) p.GetUniqueName() = arg.Text)
                ' Show details
                _ucPOStats.updatePo(po)


            Case ucTabListsControl.eGuiEvent.addToBattle
                ' Get object from list
                Dim beeing = BeeingList.Find(Function(p) p.Metadata.Name = arg.Text)
                ' Add to list
                POList.Add(New PlayableObject(beeing))
                ' Update list
                _ucTabBeeingLists.UcBattleView1.UpdateListView(POList)


            Case ucTabListsControl.eGuiEvent.endBattle

                Dim po As PlayableObject
                po = POList.Find(Function(p) p.Beeing.BType <> BeeingType.eBType.Player)

                While (Not IsNothing(po))
                    POList.Remove(po)
                    po = POList.Find(Function(p) p.Beeing.BType <> BeeingType.eBType.Player)
                End While

                ' Update list
                _ucTabBeeingLists.UcBattleView1.UpdateListView(POList)


            Case Else


        End Select
    End Sub

    Private Sub EditMapSaveEvent(obj As Object, type As Type) Handles _ucEditMap.Save
        ' Locals
        Dim m As MapType = CType(obj, MapType)
        Dim x As New xml(Of MapType)

        ' Close Window
        _ucEditMap.Dispose()
        ' Macke sure name is unique
        If MapList.FindAll(Function(p) p.Name = m.Name).Count > 0 Then
            MapList.Remove(MapList.Find(Function(p) p.Name = m.Name))
        End If
        ' Add Element
        MapList.Add(m)
        x.Serialize(m, "MapType", "data/Maps/" + m.Name + ".xml")

        ' Update list
        _ucTabBeeingLists.UcMapList1.UpdateListView(MapList)

        FlowLayoutPanel_Center.Controls.Clear()
        FlowLayoutPanel_Center.Controls.Add(_ucBattleMapView)
        FlowLayoutPanel_Center.Update()
    End Sub

    Private Sub EditMapDiscardEvent(obj As Object) Handles _ucEditMap.Discard

        ' Find dublicated in Beeing list

        FlowLayoutPanel_Center.Controls.Clear()
        FlowLayoutPanel_Center.Controls.Add(_ucBattleMapView)
        FlowLayoutPanel_Center.Update()
    End Sub

    Private Sub EditMonsterSaveEvent(obj As Object, type As Type) Handles _ucEditBeeing.Save
        ' Locals
        Dim beeing As BeeingType = CType(obj, BeeingType)
        Dim x As New xml(Of BeeingType)

        ' Close Window
        _ucEditBeeing.Dispose()
        ' Macke sure name is unique
        If BeeingList.FindAll(Function(p) p.Metadata.Name = beeing.Metadata.Name).Count > 0 Then
            BeeingList.Remove(BeeingList.Find(Function(p) p.Metadata.Name = beeing.Metadata.Name))
        End If
        ' Add Element
        BeeingList.Add(beeing)
        x.Serialize(beeing, "BeeingType", "data/Beeings/" + beeing.Metadata.Name + ".xml")

        ' Update list
        _ucTabBeeingLists.UcOpponentList1.UpdateListView(BeeingList)

        FlowLayoutPanel_Center.Controls.Clear()
        FlowLayoutPanel_Center.Controls.Add(_ucBattleMapView)
        FlowLayoutPanel_Center.Update()
    End Sub

    Private Sub EditMonsterDiscardEvent(obj As Object) Handles _ucEditBeeing.Discard

        ' Find dublicated in Beeing list

        FlowLayoutPanel_Center.Controls.Clear()
        FlowLayoutPanel_Center.Controls.Add(_ucBattleMapView)
        FlowLayoutPanel_Center.Update()
    End Sub

    Private Sub LoggingNotificationHandle(txt As String) Handles _ucTabBeeingLists.LoggingNotification, _ucTabBeeingDetails.LoggingNotification, _ucBattleMapView.LoggingNotification
        _ucTabBeeingDetails.Log(txt)
    End Sub
#End Region

End Class
