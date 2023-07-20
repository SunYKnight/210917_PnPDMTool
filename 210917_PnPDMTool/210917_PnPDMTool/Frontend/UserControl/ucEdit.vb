Public Class ucEdit(Of t As {UserControl})
#Region "Enum"

#End Region

#Region "Private Var"
    Private _uc As t
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New(uc As t)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Set autosize Properties
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        uc.AutoSize = True
        uc.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel_editUC.AutoSize = True
        FlowLayoutPanel_editUC.AutoSizeMode = AutoSizeMode.GrowAndShrink

        ' Add Usercontrol
        _uc = uc
        Me.FlowLayoutPanel_editUC.Controls.Add(uc)
    End Sub


#End Region

#Region "Private Sub"
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        RaiseEvent Save(CType(_uc, Object).Save(), CType(_uc, Object).GetOutputType())
    End Sub

    Private Sub Button_Disccard_Click(sender As Object, e As EventArgs) Handles Button_Disccard.Click
        RaiseEvent Discard(CType(_uc, Object).Discard())
    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"
    Public Event Save(obj As Object, type As Type)
    Public Event Discard(obj As Object)
#End Region

#Region "GUI Handle"

#End Region
End Class
