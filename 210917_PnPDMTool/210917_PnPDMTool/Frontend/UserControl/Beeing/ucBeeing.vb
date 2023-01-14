Public Class ucBeeing
#Region "Enum"

#End Region

#Region "Private Var"
    Private _ucBeeingsParamterGeneral As New ucBeeingsParameterGeneral
#End Region

#Region "Properties"
    Public Overrides Property MinimumSize As Size = _ucBeeingsParamterGeneral.MinimumSize
#End Region

#Region "Init"
    Public Sub New()
        InitializeComponent()

        ' Add Tab pages control
        TabControl_beeing.TabPages.Item(0).Controls.Add(_ucBeeingsParamterGeneral)
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
