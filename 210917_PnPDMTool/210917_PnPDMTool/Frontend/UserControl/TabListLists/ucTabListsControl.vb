Public Class ucTabListsControl
#Region "Enum"
    Public Enum eGuiEvent
        newPlayableObject
        editPlayableObject
        removePlayableObject
        nextTurn
        addToBattle
        endBattle
        newMonster
        editMonster
        newMap
        editMap
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
                RaiseEvent guiEvent(eGuiEvent.newMap, arg)
            Case ucMapList.eGuiEvent.newMap
                RaiseEvent guiEvent(eGuiEvent.editMap, arg)
            Case Else
        End Select
    End Sub

    Private Sub MonsterViewUiEventHandle(evt As ucOpponentList.eGuiEvent, arg As Object) Handles UcOpponentList1.guiEvent
        Select Case evt
            Case ucOpponentList.eGuiEvent.newMonster
                RaiseEvent guiEvent(eGuiEvent.newMonster, arg)
            Case ucOpponentList.eGuiEvent.editMonster
                RaiseEvent guiEvent(eGuiEvent.editMonster, arg)
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
                RaiseEvent guiEvent(eGuiEvent.newPlayableObject, arg)
            Case UcBattleView.eGuiEvent.editPlayableObject
                RaiseEvent guiEvent(eGuiEvent.editPlayableObject, arg)
            Case UcBattleView.eGuiEvent.endBattle
                RaiseEvent guiEvent(eGuiEvent.endBattle, arg)
            Case UcBattleView.eGuiEvent.removePlayableObject
                RaiseEvent guiEvent(eGuiEvent.removePlayableObject, arg)
            Case Else
        End Select
    End Sub
#End Region
End Class
