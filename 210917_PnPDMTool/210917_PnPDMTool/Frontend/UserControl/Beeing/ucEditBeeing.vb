Public Class ucEditBeeing
#Region "Enum"

#End Region

#Region "Private Var"
    Private _ucBMetadata As ucBMetadata
    Private _ucBStats As ucBStats
    Private _ucBActionList As ucBActionList
#End Region

#Region "Properties"
    Public Overrides Property MinimumSize As Size = New Size(C.WIDTH_CONTROL_EDIT, C.HEIGHT_CONTROL_EDIT)
    Public Property Beeing As BeeingType
#End Region

#Region "Init"
    Public Sub New(beeing As BeeingType)
        ' Required function call
        InitializeComponent()

        ' Save beeing
        Me.Beeing = beeing

        _ucBStats = New ucBStats(beeing)
        _ucBActionList = New ucBActionList(beeing.Stats.ActionList)
        _ucBMetadata = New ucBMetadata(beeing)

        ' Add Tab pages control
        TabControl_beeing.TabPages.Item(1).Controls.Add(_ucBStats)
        TabControl_beeing.TabPages.Item(2).Controls.Add(_ucBActionList)
        TabControl_beeing.TabPages.Item(0).Controls.Add(_ucBMetadata)
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Save() As Object
        Return Beeing
    End Function

    Public Function GetOutputType() As Type
        Return GetType(BeeingType)
    End Function

    Public Function Discard() As Object
        Return Beeing
    End Function
#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
