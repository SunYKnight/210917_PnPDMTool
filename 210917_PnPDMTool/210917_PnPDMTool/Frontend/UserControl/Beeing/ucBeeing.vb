Public Class ucBeeing
#Region "Enum"

#End Region

#Region "Private Var"
    Private _ucBeeingParamterGeneral As New ucBeeingParameterGeneral
    Private _ucBeeingActionList As New ucBeeingActionList
#End Region

#Region "Properties"
    Public Overrides Property MinimumSize As Size = _ucBeeingParamterGeneral.MinimumSize
#End Region

#Region "Init"
    Public Sub New()
        InitializeComponent()

        ' Add Tab pages control
        TabControl_beeing.TabPages.Item(0).Controls.Add(_ucBeeingParamterGeneral)
        TabControl_beeing.TabPages.Item(1).Controls.Add(_ucBeeingActionList)
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Save() As Object
        Return New Object
    End Function

    Public Function GetOutputType() As Type
        Return GetType(BeeingType)
    End Function

    Public Function Discard() As Object
        Return New Object
    End Function
#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
