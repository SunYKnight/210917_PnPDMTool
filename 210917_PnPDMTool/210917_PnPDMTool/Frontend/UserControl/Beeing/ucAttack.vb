Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucAttack
#Region "Enum"

#End Region

#Region "Private Var"
    Private _uctriggeredConditionsList As ucItemList(Of eCondidtion)
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
        Dim dataSrc = System.Enum.GetNames(GetType(eAttribut))

        InitializeComponent()

        ' Get Combobox values
        ComboBox_DmgType.DataSource = System.Enum.GetValues(GetType(eDmgType))
        ComboBox_sec_dmgType.DataSource = System.Enum.GetValues(GetType(eDmgType))
        ComboBox_savingThrow.DataSource = System.Enum.GetValues(GetType(eAttribut))
        ComboBox_sec_savingThrow.DataSource = System.Enum.GetValues(GetType(eAttribut))
        ComboBox_condition_savingThrow.DataSource = System.Enum.GetValues(GetType(eAttribut))

        ' Description
        TextBox_name.DataBindings.Clear()
        TextBox_name.DataBindings.Add(New Binding("Text", Attack, "Name"))

        ' Description
        RichTextBox_Description.DataBindings.Clear()
        RichTextBox_Description.DataBindings.Add(New Binding("Text", Attack, "Description"))

        ' Pirimary Attack

        ' Damage Type
        Dim cBpdt As New ComboboxBinder(Of eDmgType)(ComboBox_DmgType, Attack.PrimaryAttack, "DmgType")
        ' Shape
        Dim cBpsh As New ComboboxBinder(Of eShape)(ComboBox_dmgShape, Attack.PrimaryAttack, "DmgShape")
        ' HitRange
        NumericUpDown_hitRange.DataBindings.Clear()
        NumericUpDown_hitRange.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack, "HitRange"))
        ' AoERange
        NumericUpDown_dmgAoE.DataBindings.Clear()
        NumericUpDown_dmgAoE.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack, "AoERange"))
        ' NumberOfTargets
        NumericUpDown_NumberOfTargets.DataBindings.Clear()
        NumericUpDown_NumberOfTargets.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack, "NumberOfTargets"))
        ' Dmg Bonus
        NumericUpDown_dmgBonus.DataBindings.Clear()
        NumericUpDown_dmgBonus.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack, "DmgBonus"))
        ' Dmg Dice D4
        NumericUpDown_dmgDiceD4.DataBindings.Clear()
        NumericUpDown_dmgDiceD4.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack.DmgDiceD4, "DiceCount"))
        ' Dmg Dice D6
        NumericUpDown_dmgDiceD6.DataBindings.Clear()
        NumericUpDown_dmgDiceD6.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack.DmgDiceD6, "DiceCount"))
        ' Dmg Dice D8
        NumericUpDown_dmgDiceD8.DataBindings.Clear()
        NumericUpDown_dmgDiceD8.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack.DmgDiceD8, "DiceCount"))
        ' Dmg Dice D12
        NumericUpDown_dmgDiceD12.DataBindings.Clear()
        NumericUpDown_dmgDiceD12.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack.DmgDiceD12, "DiceCount"))
        ' Dmg Dice D20
        NumericUpDown_dmgDiceD20.DataBindings.Clear()
        NumericUpDown_dmgDiceD20.DataBindings.Add(New Binding("Value", Attack.PrimaryAttack.DmgDiceD20, "DiceCount"))

        ' PrimaryAttackHitBonus
        NumericUpDown_hitBonus.DataBindings.Clear()
        NumericUpDown_hitBonus.DataBindings.Add(New Binding("Value", Attack, "PrimaryAttackHitBonus"))
        ' PrimaryAttackHitsAlways
        CheckBox_hitAlways.DataBindings.Clear()
        CheckBox_hitAlways.DataBindings.Add(New Binding("CheckedState", Attack, "PrimaryAttackHitsAlways"))
        ' PrimaryAttackUseSavingThrow
        CheckBox_isSavingThrow.DataBindings.Clear()
        CheckBox_isSavingThrow.DataBindings.Add(New Binding("CheckedState", Attack, "PrimaryAttackUseSavingThrow"))
        ' PrimaryAttackSavingThrow
        Dim cBpst As New ComboboxBinder(Of eAttribut)(ComboBox_savingThrow, Attack, "PrimaryAttackSavingThrow")


        ' Secondary Attack

        ' Damage Type
        Dim cBsdt As New ComboboxBinder(Of eDmgType)(ComboBox_DmgType, Attack.SecondaryAttack, "DmgType")
        ' Shape
        Dim cBssh As New ComboboxBinder(Of eShape)(ComboBox_dmgShape, Attack.SecondaryAttack, "DmgShape")
        ' HitRange
        NumericUpDown_sec_hitRange.DataBindings.Clear()
        NumericUpDown_sec_hitRange.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack, "HitRange"))
        ' AoERange
        NumericUpDown_sec_DmgAoE.DataBindings.Clear()
        NumericUpDown_sec_DmgAoE.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack, "AoERange"))
        ' NumberOfTargets
        NumericUpDown_sec_NumberOfTargets.DataBindings.Clear()
        NumericUpDown_sec_NumberOfTargets.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack, "NumberOfTargets"))
        ' Dmg Bonus
        NumericUpDown_sec_dmgBonus.DataBindings.Clear()
        NumericUpDown_sec_dmgBonus.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack, "DmgBonus"))
        ' Dmg Dice D4
        NumericUpDown_sec_dmgDiceD4.DataBindings.Clear()
        NumericUpDown_sec_dmgDiceD4.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack.DmgDiceD4, "DiceCount"))
        ' Dmg Dice D6
        NumericUpDown_sec_dmgDiceD6.DataBindings.Clear()
        NumericUpDown_sec_dmgDiceD6.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack.DmgDiceD6, "DiceCount"))
        ' Dmg Dice D8
        NumericUpDown_sec_dmgDiceD8.DataBindings.Clear()
        NumericUpDown_sec_dmgDiceD8.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack.DmgDiceD8, "DiceCount"))
        ' Dmg Dice D12
        NumericUpDown_sec_dmgDiceD12.DataBindings.Clear()
        NumericUpDown_sec_dmgDiceD12.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack.DmgDiceD12, "DiceCount"))
        ' Dmg Dice D20
        NumericUpDown_sec_dmgDiceD20.DataBindings.Clear()
        NumericUpDown_sec_dmgDiceD20.DataBindings.Add(New Binding("Value", Attack.SecondaryAttack.DmgDiceD20, "DiceCount"))


        ' Triggered Condition
        _uctriggeredConditionsList = New ucItemList(Of eCondidtion)(Attack.TriggeredCondition, "Triggered Conditions", True)
        _uctriggeredConditionsList.Location = New Point(3, 200)
        Me.Controls.Add(_uctriggeredConditionsList)
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
