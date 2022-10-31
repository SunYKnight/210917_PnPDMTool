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
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbBattle.Size = New Size(Me.Width, HEIGHT_TITLE)
        Me.listViewBattle.Size = New Size(Me.Width - 2 * GAP_SMALL, Me.Height - 3 * GAP_SMALL - 2 * HEIGHT_BUTTON - HEIGHT_TITLE)

        Me.btnNewPlayer.Size = New Size(CInt((Me.Width - 4 * GAP_SMALL) / 3), HEIGHT_BUTTON)
        Me.btnEditPlayer.Size = New Size(Me.Width - 4 * GAP_SMALL - 2 * Me.btnNewPlayer.Width, HEIGHT_BUTTON)
        Me.btnRemove.Size = Me.btnNewPlayer.Size

        Me.btnNext.Size = New Size(CInt((Me.Width - 3 * GAP_SMALL) / 2), HEIGHT_BUTTON)
        Me.btnEndBattle.Size = Me.btnNext.Size

        Me.lbBattle.Location = New Point(0, 0)
        Me.listViewBattle.Location = New Point(GAP_SMALL, HEIGHT_TITLE)

        Me.btnNewPlayer.Location = New Point(GAP_SMALL, Me.Height - 2 * GAP_SMALL - 2 * HEIGHT_BUTTON)
        Me.btnEditPlayer.Location = New Point(2 * GAP_SMALL + Me.btnNewPlayer.Width, Me.btnNewPlayer.Location.Y)
        Me.btnRemove.Location = New Point(Me.Width - Me.btnRemove.Width - GAP_SMALL, Me.btnNewPlayer.Location.Y)

        Me.btnNext.Location = New Point(GAP_SMALL, Me.Height - GAP_SMALL - HEIGHT_BUTTON)
        Me.btnEndBattle.Location = New Point(2 * GAP_SMALL + Me.btnNext.Width, Me.btnNext.Location.Y)
    End Sub
#End Region

#Region "Events"
    Public Event guiEvent(evt As eGuiEvent, arg As Object)
#End Region
End Class
