Public Class ucPOStats
#Region "Enum"

#End Region

#Region "Private Var"
    Private Property _po As PlayableObject

    Friend WithEvents _ucConditionImmunityList As ucItemList(Of eCondidtion)
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
    End Sub
#End Region

#Region "Private Sub"
    Public Sub updateUI()

        setMapFromPath(PictureBox_po.Image, _po.Beeing.Metadata.Image, PictureBox_po.Image.Width, PictureBox_po.Image.Height)

        NumericUpDown_hp_current.DataBindings.Clear()
        NumericUpDown_hp_current.DataBindings.Add(New Binding("Value", _po, "CurrentHp"))

        NumericUpDown_hp_max.DataBindings.Clear()
        NumericUpDown_hp_max.DataBindings.Add(New Binding("Value", _po, "MaxHp"))

        ' ConditionImmunity
        _ucConditionImmunityList = New ucItemList(Of eCondidtion)(_po.ActiveConditions, "Active Conditions", True)
        _ucConditionImmunityList.Location = New Point(300, 20)
        Me.Controls.Add(Me._ucConditionImmunityList)

    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub updatePo(po As PlayableObject)
        ' Save PO
        _po = po
        ' Update UI
        updateUI()
    End Sub
#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
