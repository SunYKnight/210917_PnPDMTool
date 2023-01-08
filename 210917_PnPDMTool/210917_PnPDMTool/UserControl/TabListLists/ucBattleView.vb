Imports _210917_PnPDMTool.C

Public Class UcBattleView
#Region "Enum"
    Public Enum eGuiEvent
        newPlayableObject
        editPlayableObject
        removePlayableObject
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

#End Region

#Region "Events"
    Public Event guiEvent(evt As eGuiEvent, arg As Object)
#End Region
End Class
