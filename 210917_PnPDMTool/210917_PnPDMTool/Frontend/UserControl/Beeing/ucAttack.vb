Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucAttack
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property Attack As AttackType
#End Region

#Region "Init"
    Public Sub New(attack As AttackType)

        ' Save value
        Me.Attack = attack

        ' Update databinding
        NewCommon()
    End Sub
#End Region

#Region "Private Sub"
    Private Sub NewCommon()
        ' Locals
        Dim dataSrc = System.Enum.GetNames(GetType(eAttributes))

        InitializeComponent()

        ' Get Combobox values
        ComboBox_DmgType.DataSource = System.Enum.GetValues(GetType(EDmgType))

        ' Description
        TextBox_name.DataBindings.Clear()
        TextBox_name.DataBindings.Add(New Binding("Text", Attack, "Name"))

        ' Description
        RichTextBox_Description.DataBindings.Clear()
        RichTextBox_Description.DataBindings.Add(New Binding("Text", Attack, "Description"))

        ' Damage Type
        ComboBox_DmgType.DataBindings.Clear()
        ComboBox_DmgType.DataBindings.Add(New Binding("SelectedIndex", Attack, "DmgType"))

        ' Range
        NumericUpDown_range.DataBindings.Clear()
        NumericUpDown_range.DataBindings.Add(New Binding("Value", Attack, "Range"))

        ' Hit Bonus
        NumericUpDown_hitBonus.DataBindings.Clear()
        NumericUpDown_hitBonus.DataBindings.Add(New Binding("Value", Attack, "HitBonus"))

        ' Dmg Bonus
        NumericUpDown_dmgBonus.DataBindings.Clear()
        NumericUpDown_dmgBonus.DataBindings.Add(New Binding("Value", Attack, "DmgBonus"))

        ' Dmg Dice D4
        NumericUpDown_dmgDiceD4.DataBindings.Clear()
        NumericUpDown_dmgDiceD4.DataBindings.Add(New Binding("Value", Attack.DmgDiceD4, "DiceCount"))
        ' Dmg Dice D6
        NumericUpDown_dmgDiceD6.DataBindings.Clear()
        NumericUpDown_dmgDiceD6.DataBindings.Add(New Binding("Value", Attack.DmgDiceD6, "DiceCount"))
        ' Dmg Dice D8
        NumericUpDown_dmgDiceD8.DataBindings.Clear()
        NumericUpDown_dmgDiceD8.DataBindings.Add(New Binding("Value", Attack.DmgDiceD8, "DiceCount"))
        ' Dmg Dice D12
        NumericUpDown_dmgDiceD12.DataBindings.Clear()
        NumericUpDown_dmgDiceD12.DataBindings.Add(New Binding("Value", Attack.DmgDiceD12, "DiceCount"))
        ' Dmg Dice D20
        NumericUpDown_dmgDiceD20.DataBindings.Clear()
        NumericUpDown_dmgDiceD20.DataBindings.Add(New Binding("Value", Attack.DmgDiceD20, "DiceCount"))
        ' Dmg Dice D100
        NumericUpDown_dmgDiceD100.DataBindings.Clear()
        NumericUpDown_dmgDiceD100.DataBindings.Add(New Binding("Value", Attack.DmgDiceD100, "DiceCount"))
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Function Save() As Object
        Return Attack
    End Function

    Public Function GetOutputType() As Type
        Return GetType(AttackType)
    End Function
#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
