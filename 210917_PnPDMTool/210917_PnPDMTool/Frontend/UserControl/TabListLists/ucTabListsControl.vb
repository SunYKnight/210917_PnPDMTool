Public Class ucTabListsControl
#Region "Enum"
    Public Enum eGuiEvent
        MonsterNew
        MonsterEdit
        MapNew
        MapEdit
        MapLoad
        PONew
        POEdit
        PORemove
        nextTurn
        addToBattle
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

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

    Public Event LoggingNotification(txt As String)

    Public Event guiEvent(evt As eGuiEvent, arg As Object)

#End Region

#Region "Event Handle"
    Private Sub MapListiEventHandle(evt As ucOpponentList.eGuiEvent, arg As Object) Handles UcMapList1.guiEvent
        Select Case evt
            Case ucMapList.eGuiEvent.newMap
                RaiseEvent guiEvent(eGuiEvent.MapNew, arg)
            Case ucMapList.eGuiEvent.editMap
                RaiseEvent guiEvent(eGuiEvent.MapEdit, arg)
            Case ucMapList.eGuiEvent.loadMap
                RaiseEvent guiEvent(eGuiEvent.MapLoad, arg)
            Case Else
        End Select
    End Sub

    Private Sub MonsterViewUiEventHandle(evt As ucOpponentList.eGuiEvent, arg As Object) Handles UcOpponentList1.guiEvent
        Select Case evt
            Case ucOpponentList.eGuiEvent.newMonster
                RaiseEvent guiEvent(eGuiEvent.MonsterNew, arg)
            Case ucOpponentList.eGuiEvent.editMonster
                RaiseEvent guiEvent(eGuiEvent.MonsterEdit, arg)
            Case ucOpponentList.eGuiEvent.addToBattle
                RaiseEvent guiEvent(eGuiEvent.addToBattle, arg)
            Case Else
        End Select
    End Sub

    Private Sub BattleViewUiEventHandle(evt As UcBattleView.eGuiEvent, arg As Object) Handles UcBattleView1.guiEvent
        Select Case evt
            Case UcBattleView.eGuiEvent.nextTurn
                RaiseEvent guiEvent(eGuiEvent.nextTurn, arg)
            Case UcBattleView.eGuiEvent.newPlayableObject
                RaiseEvent guiEvent(eGuiEvent.PONew, arg)
            Case UcBattleView.eGuiEvent.editPlayableObject
                RaiseEvent guiEvent(eGuiEvent.POEdit, arg)
            Case UcBattleView.eGuiEvent.endBattle
                RaiseEvent guiEvent(eGuiEvent.endBattle, arg)
            Case UcBattleView.eGuiEvent.removePlayableObject
                RaiseEvent guiEvent(eGuiEvent.PORemove, arg)
            Case Else
        End Select
    End Sub
#End Region
End Class
