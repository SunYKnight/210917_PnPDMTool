Public Class ucEdit
#Region "Enum"

#End Region

#Region "Private Var"
    Private _uc As BaseEditUC
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New(uc As Object)
        _uc = uc
        FlowLayoutPanel_editUC.Controls.Add(uc)
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        RaiseEvent Save(_uc.Save())
    End Sub

    Private Sub Button_Disccard_Click(sender As Object, e As EventArgs) Handles Button_Disccard.Click
        RaiseEvent Discard(_uc.Discard())
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    Public Event Save(obj As Object)
    Public Event Discard(obj As Object)
#End Region

#Region "GUI Handle"

#End Region
End Class
