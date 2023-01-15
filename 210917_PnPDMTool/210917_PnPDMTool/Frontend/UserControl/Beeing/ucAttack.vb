Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucAttack
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property VM As New AttackType()
#End Region

#Region "Init"
    Public Sub New()
        InitializeComponent()

        ' Get Combobox values
        ComboBox_DmgType.DataSource = System.Enum.GetValues(GetType(EDmgType))

        ' Update databinding
        UpdateDatabinding()
    End Sub
#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding()
        ' Locals
        Dim dataSrc = System.Enum.GetNames(GetType(eAttributes))

        ' Description
        RichTextBox_Description.DataBindings.Clear()
        RichTextBox_Description.DataBindings.Add(New Binding("Text", VM, "Description"))

        ' Damage Type
        ComboBox_DmgType.DataBindings.Clear()
        ComboBox_DmgType.DataBindings.Add(New Binding("SelectedIndex", VM, "DmgType"))

        ' Range
        NumericUpDown_range.DataBindings.Clear()
        NumericUpDown_range.DataBindings.Add(New Binding("Value", VM, "Range"))

        ' Hit Bonus
        NumericUpDown_hitBonus.DataBindings.Clear()
        NumericUpDown_hitBonus.DataBindings.Add(New Binding("Value", VM, "HitBonus"))

        ' Dmg Bonus
        NumericUpDown_dmgBonus.DataBindings.Clear()
        NumericUpDown_dmgBonus.DataBindings.Add(New Binding("Value", VM, "DmgBonus"))

        ' Dmg Dice D4
        NumericUpDown_dmgDiceD4.DataBindings.Clear()
        NumericUpDown_dmgDiceD4.DataBindings.Add(New Binding("Value", VM.DmgDiceD4, "DiceCount"))
        ' Dmg Dice D6
        NumericUpDown_dmgDiceD6.DataBindings.Clear()
        NumericUpDown_dmgDiceD6.DataBindings.Add(New Binding("Value", VM.DmgDiceD6, "DiceCount"))
        ' Dmg Dice D8
        NumericUpDown_dmgDiceD8.DataBindings.Clear()
        NumericUpDown_dmgDiceD8.DataBindings.Add(New Binding("Value", VM.DmgDiceD8, "DiceCount"))
        ' Dmg Dice D12
        NumericUpDown_dmgDiceD12.DataBindings.Clear()
        NumericUpDown_dmgDiceD12.DataBindings.Add(New Binding("Value", VM.DmgDiceD12, "DiceCount"))
        ' Dmg Dice D20
        NumericUpDown_dmgDiceD20.DataBindings.Clear()
        NumericUpDown_dmgDiceD20.DataBindings.Add(New Binding("Value", VM.DmgDiceD20, "DiceCount"))
        ' Dmg Dice D100
        NumericUpDown_dmgDiceD100.DataBindings.Clear()
        NumericUpDown_dmgDiceD100.DataBindings.Add(New Binding("Value", VM.DmgDiceD100, "DiceCount"))
    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
