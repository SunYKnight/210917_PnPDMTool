<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucAttack
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        RichTextBox_Description = New RichTextBox()
        Label1 = New Label()
        AttackBindingSource = New BindingSource(components)
        Label2 = New Label()
        ComboBox_DmgType = New ComboBox()
        Label3 = New Label()
        NumericUpDown_hitRange = New NumericUpDown()
        NumericUpDown_hitBonus = New NumericUpDown()
        Label4 = New Label()
        NumericUpDown_dmgBonus = New NumericUpDown()
        Label5 = New Label()
        Label6 = New Label()
        NumericUpDown_dmgDiceD4 = New NumericUpDown()
        NumericUpDown_dmgDiceD6 = New NumericUpDown()
        NumericUpDown_dmgDiceD8 = New NumericUpDown()
        NumericUpDown_dmgDiceD12 = New NumericUpDown()
        NumericUpDown_dmgDiceD20 = New NumericUpDown()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label13 = New Label()
        TextBox_name = New TextBox()
        CheckBox_trigger_condition = New CheckBox()
        CheckBox_trigger_secondary_attack = New CheckBox()
        ComboBox_sec_dmgType = New ComboBox()
        Label18 = New Label()
        Label21 = New Label()
        ComboBox_sec_savingThrow = New ComboBox()
        Label22 = New Label()
        ComboBox_condition_savingThrow = New ComboBox()
        NumericUpDown_dmgAoE = New NumericUpDown()
        Label23 = New Label()
        NumericUpDown_NumberOfTargets = New NumericUpDown()
        Label24 = New Label()
        CheckBox_isSavingThrow = New CheckBox()
        GroupBox1 = New GroupBox()
        Label12 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        NumericUpDown_sec_dmgDiceD20 = New NumericUpDown()
        NumericUpDown_sec_dmgDiceD12 = New NumericUpDown()
        NumericUpDown_sec_dmgDiceD8 = New NumericUpDown()
        NumericUpDown_sec_dmgDiceD6 = New NumericUpDown()
        NumericUpDown_sec_dmgDiceD4 = New NumericUpDown()
        Label19 = New Label()
        NumericUpDown_sec_dmgBonus = New NumericUpDown()
        Label20 = New Label()
        CheckBox_sec_dmg_always = New CheckBox()
        NumericUpDown_sec_NumberOfTargets = New NumericUpDown()
        Label28 = New Label()
        NumericUpDown_sec_DmgAoE = New NumericUpDown()
        Label29 = New Label()
        NumericUpDown_sec_hitRange = New NumericUpDown()
        Label30 = New Label()
        ComboBox_sec_dmg_shape = New ComboBox()
        Label27 = New Label()
        GroupBox_cond = New GroupBox()
        CheckBox_cond_trigger_always = New CheckBox()
        GroupBox3 = New GroupBox()
        ComboBox_savingThrow = New ComboBox()
        Label25 = New Label()
        CheckBox_hitAlways = New CheckBox()
        ComboBox_dmgShape = New ComboBox()
        Label26 = New Label()
        CType(AttackBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_hitRange, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_hitBonus, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_dmgBonus, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_dmgDiceD4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_dmgDiceD6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_dmgDiceD8, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_dmgDiceD12, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_dmgDiceD20, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_dmgAoE, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_NumberOfTargets, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown_sec_dmgDiceD20, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_dmgDiceD12, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_dmgDiceD8, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_dmgDiceD6, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_dmgDiceD4, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_dmgBonus, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_NumberOfTargets, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_DmgAoE, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_sec_hitRange, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox_cond.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' RichTextBox_Description
        ' 
        RichTextBox_Description.Location = New Point(8, 95)
        RichTextBox_Description.Name = "RichTextBox_Description"
        RichTextBox_Description.Size = New Size(420, 100)
        RichTextBox_Description.TabIndex = 0
        RichTextBox_Description.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 1
        Label1.Text = "Description:"
        ' 
        ' AttackBindingSource
        ' 
        AttackBindingSource.DataSource = GetType(BaseAttack)
        ' 
        ' Label2
        ' 
        Label2.AccessibleRole = AccessibleRole.IpAddress
        Label2.AutoSize = True
        Label2.Location = New Point(8, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 25)
        Label2.TabIndex = 2
        Label2.Text = "Dmg Type:"
        ' 
        ' ComboBox_DmgType
        ' 
        ComboBox_DmgType.FormattingEnabled = True
        ComboBox_DmgType.Location = New Point(8, 226)
        ComboBox_DmgType.Name = "ComboBox_DmgType"
        ComboBox_DmgType.Size = New Size(207, 33)
        ComboBox_DmgType.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AccessibleRole = AccessibleRole.IpAddress
        Label3.AutoSize = True
        Label3.Location = New Point(8, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 25)
        Label3.TabIndex = 4
        Label3.Text = "Range:"
        ' 
        ' NumericUpDown_hitRange
        ' 
        NumericUpDown_hitRange.Increment = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_hitRange.Location = New Point(8, 294)
        NumericUpDown_hitRange.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_hitRange.Minimum = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_hitRange.Name = "NumericUpDown_hitRange"
        NumericUpDown_hitRange.Size = New Size(60, 31)
        NumericUpDown_hitRange.TabIndex = 5
        NumericUpDown_hitRange.Value = New [Decimal](New Integer() {5, 0, 0, 0})
        ' 
        ' NumericUpDown_hitBonus
        ' 
        NumericUpDown_hitBonus.Location = New Point(238, 104)
        NumericUpDown_hitBonus.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_hitBonus.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_hitBonus.Name = "NumericUpDown_hitBonus"
        NumericUpDown_hitBonus.Size = New Size(74, 31)
        NumericUpDown_hitBonus.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AccessibleRole = AccessibleRole.IpAddress
        Label4.AutoSize = True
        Label4.Location = New Point(238, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 25)
        Label4.TabIndex = 6
        Label4.Text = "Hit Bonus:"
        ' 
        ' NumericUpDown_dmgBonus
        ' 
        NumericUpDown_dmgBonus.Location = New Point(363, 384)
        NumericUpDown_dmgBonus.Minimum = New [Decimal](New Integer() {100, 0, 0, Integer.MinValue})
        NumericUpDown_dmgBonus.Name = "NumericUpDown_dmgBonus"
        NumericUpDown_dmgBonus.Size = New Size(60, 31)
        NumericUpDown_dmgBonus.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AccessibleRole = AccessibleRole.IpAddress
        Label5.AutoSize = True
        Label5.Location = New Point(363, 357)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 25)
        Label5.TabIndex = 8
        Label5.Text = "Bonus:"
        ' 
        ' Label6
        ' 
        Label6.AccessibleRole = AccessibleRole.IpAddress
        Label6.AutoSize = True
        Label6.Location = New Point(221, 268)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 25)
        Label6.TabIndex = 10
        Label6.Text = "Dmg Dice:"
        ' 
        ' NumericUpDown_dmgDiceD4
        ' 
        NumericUpDown_dmgDiceD4.Location = New Point(221, 323)
        NumericUpDown_dmgDiceD4.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_dmgDiceD4.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_dmgDiceD4.Name = "NumericUpDown_dmgDiceD4"
        NumericUpDown_dmgDiceD4.Size = New Size(60, 31)
        NumericUpDown_dmgDiceD4.TabIndex = 11
        ' 
        ' NumericUpDown_dmgDiceD6
        ' 
        NumericUpDown_dmgDiceD6.Location = New Point(292, 323)
        NumericUpDown_dmgDiceD6.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_dmgDiceD6.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_dmgDiceD6.Name = "NumericUpDown_dmgDiceD6"
        NumericUpDown_dmgDiceD6.Size = New Size(60, 31)
        NumericUpDown_dmgDiceD6.TabIndex = 12
        ' 
        ' NumericUpDown_dmgDiceD8
        ' 
        NumericUpDown_dmgDiceD8.Location = New Point(363, 323)
        NumericUpDown_dmgDiceD8.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_dmgDiceD8.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_dmgDiceD8.Name = "NumericUpDown_dmgDiceD8"
        NumericUpDown_dmgDiceD8.Size = New Size(60, 31)
        NumericUpDown_dmgDiceD8.TabIndex = 13
        ' 
        ' NumericUpDown_dmgDiceD12
        ' 
        NumericUpDown_dmgDiceD12.Location = New Point(221, 384)
        NumericUpDown_dmgDiceD12.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_dmgDiceD12.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_dmgDiceD12.Name = "NumericUpDown_dmgDiceD12"
        NumericUpDown_dmgDiceD12.Size = New Size(60, 31)
        NumericUpDown_dmgDiceD12.TabIndex = 14
        ' 
        ' NumericUpDown_dmgDiceD20
        ' 
        NumericUpDown_dmgDiceD20.Location = New Point(292, 384)
        NumericUpDown_dmgDiceD20.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_dmgDiceD20.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_dmgDiceD20.Name = "NumericUpDown_dmgDiceD20"
        NumericUpDown_dmgDiceD20.Size = New Size(60, 31)
        NumericUpDown_dmgDiceD20.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AccessibleRole = AccessibleRole.IpAddress
        Label7.AutoSize = True
        Label7.Location = New Point(221, 296)
        Label7.Name = "Label7"
        Label7.Size = New Size(35, 25)
        Label7.TabIndex = 17
        Label7.Text = "D4"
        ' 
        ' Label8
        ' 
        Label8.AccessibleRole = AccessibleRole.IpAddress
        Label8.AutoSize = True
        Label8.Location = New Point(292, 296)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 25)
        Label8.TabIndex = 18
        Label8.Text = "D6"
        ' 
        ' Label9
        ' 
        Label9.AccessibleRole = AccessibleRole.IpAddress
        Label9.AutoSize = True
        Label9.Location = New Point(363, 296)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 25)
        Label9.TabIndex = 19
        Label9.Text = "D8"
        ' 
        ' Label10
        ' 
        Label10.AccessibleRole = AccessibleRole.IpAddress
        Label10.AutoSize = True
        Label10.Location = New Point(221, 357)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 25)
        Label10.TabIndex = 20
        Label10.Text = "D12"
        ' 
        ' Label11
        ' 
        Label11.AccessibleRole = AccessibleRole.IpAddress
        Label11.AutoSize = True
        Label11.Location = New Point(292, 357)
        Label11.Name = "Label11"
        Label11.Size = New Size(45, 25)
        Label11.TabIndex = 21
        Label11.Text = "D20"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(8, 9)
        Label13.Name = "Label13"
        Label13.Size = New Size(63, 25)
        Label13.TabIndex = 23
        Label13.Text = "Name:"
        ' 
        ' TextBox_name
        ' 
        TextBox_name.Location = New Point(8, 37)
        TextBox_name.Name = "TextBox_name"
        TextBox_name.Size = New Size(420, 31)
        TextBox_name.TabIndex = 24
        ' 
        ' CheckBox_trigger_condition
        ' 
        CheckBox_trigger_condition.AutoSize = True
        CheckBox_trigger_condition.Location = New Point(739, 22)
        CheckBox_trigger_condition.Name = "CheckBox_trigger_condition"
        CheckBox_trigger_condition.Size = New Size(232, 29)
        CheckBox_trigger_condition.TabIndex = 25
        CheckBox_trigger_condition.Text = "Trigger Condition On Hit"
        CheckBox_trigger_condition.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_trigger_secondary_attack
        ' 
        CheckBox_trigger_secondary_attack.AutoSize = True
        CheckBox_trigger_secondary_attack.Location = New Point(458, 22)
        CheckBox_trigger_secondary_attack.Name = "CheckBox_trigger_secondary_attack"
        CheckBox_trigger_secondary_attack.Size = New Size(225, 29)
        CheckBox_trigger_secondary_attack.TabIndex = 26
        CheckBox_trigger_secondary_attack.Text = "Trigger Additional DMG"
        CheckBox_trigger_secondary_attack.UseVisualStyleBackColor = True
        ' 
        ' ComboBox_sec_dmgType
        ' 
        ComboBox_sec_dmgType.FormattingEnabled = True
        ComboBox_sec_dmgType.Location = New Point(32, 163)
        ComboBox_sec_dmgType.Name = "ComboBox_sec_dmgType"
        ComboBox_sec_dmgType.Size = New Size(207, 33)
        ComboBox_sec_dmgType.TabIndex = 45
        ' 
        ' Label18
        ' 
        Label18.AccessibleRole = AccessibleRole.IpAddress
        Label18.AutoSize = True
        Label18.Location = New Point(28, 135)
        Label18.Name = "Label18"
        Label18.Size = New Size(98, 25)
        Label18.TabIndex = 46
        Label18.Text = "Dmg Type:"
        ' 
        ' Label21
        ' 
        Label21.AccessibleRole = AccessibleRole.IpAddress
        Label21.AutoSize = True
        Label21.Location = New Point(28, 71)
        Label21.Name = "Label21"
        Label21.Size = New Size(123, 25)
        Label21.TabIndex = 48
        Label21.Text = "Saving Throw:"
        ' 
        ' ComboBox_sec_savingThrow
        ' 
        ComboBox_sec_savingThrow.FormattingEnabled = True
        ComboBox_sec_savingThrow.Location = New Point(32, 99)
        ComboBox_sec_savingThrow.Name = "ComboBox_sec_savingThrow"
        ComboBox_sec_savingThrow.Size = New Size(207, 33)
        ComboBox_sec_savingThrow.TabIndex = 47
        ' 
        ' Label22
        ' 
        Label22.AccessibleRole = AccessibleRole.IpAddress
        Label22.AutoSize = True
        Label22.Location = New Point(22, 73)
        Label22.Name = "Label22"
        Label22.Size = New Size(123, 25)
        Label22.TabIndex = 50
        Label22.Text = "Saving Throw:"
        ' 
        ' ComboBox_condition_savingThrow
        ' 
        ComboBox_condition_savingThrow.FormattingEnabled = True
        ComboBox_condition_savingThrow.Location = New Point(24, 101)
        ComboBox_condition_savingThrow.Name = "ComboBox_condition_savingThrow"
        ComboBox_condition_savingThrow.Size = New Size(207, 33)
        ComboBox_condition_savingThrow.TabIndex = 49
        ' 
        ' NumericUpDown_dmgAoE
        ' 
        NumericUpDown_dmgAoE.Increment = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_dmgAoE.Location = New Point(74, 294)
        NumericUpDown_dmgAoE.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_dmgAoE.Minimum = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_dmgAoE.Name = "NumericUpDown_dmgAoE"
        NumericUpDown_dmgAoE.Size = New Size(60, 31)
        NumericUpDown_dmgAoE.TabIndex = 52
        NumericUpDown_dmgAoE.Value = New [Decimal](New Integer() {5, 0, 0, 0})
        ' 
        ' Label23
        ' 
        Label23.AccessibleRole = AccessibleRole.IpAddress
        Label23.AutoSize = True
        Label23.Location = New Point(74, 268)
        Label23.Name = "Label23"
        Label23.Size = New Size(48, 25)
        Label23.TabIndex = 51
        Label23.Text = "AoE:"
        ' 
        ' NumericUpDown_NumberOfTargets
        ' 
        NumericUpDown_NumberOfTargets.Location = New Point(140, 294)
        NumericUpDown_NumberOfTargets.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_NumberOfTargets.Minimum = New [Decimal](New Integer() {1, 0, 0, 0})
        NumericUpDown_NumberOfTargets.Name = "NumericUpDown_NumberOfTargets"
        NumericUpDown_NumberOfTargets.Size = New Size(60, 31)
        NumericUpDown_NumberOfTargets.TabIndex = 54
        NumericUpDown_NumberOfTargets.Value = New [Decimal](New Integer() {1, 0, 0, 0})
        ' 
        ' Label24
        ' 
        Label24.AccessibleRole = AccessibleRole.IpAddress
        Label24.AutoSize = True
        Label24.Location = New Point(140, 268)
        Label24.Name = "Label24"
        Label24.Size = New Size(72, 25)
        Label24.TabIndex = 53
        Label24.Text = "Targets:"
        ' 
        ' CheckBox_isSavingThrow
        ' 
        CheckBox_isSavingThrow.AutoSize = True
        CheckBox_isSavingThrow.Location = New Point(14, 44)
        CheckBox_isSavingThrow.Name = "CheckBox_isSavingThrow"
        CheckBox_isSavingThrow.Size = New Size(163, 29)
        CheckBox_isSavingThrow.TabIndex = 55
        CheckBox_isSavingThrow.Text = "Is Saving Throw"
        CheckBox_isSavingThrow.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(NumericUpDown_sec_dmgDiceD20)
        GroupBox1.Controls.Add(NumericUpDown_sec_dmgDiceD12)
        GroupBox1.Controls.Add(NumericUpDown_sec_dmgDiceD8)
        GroupBox1.Controls.Add(NumericUpDown_sec_dmgDiceD6)
        GroupBox1.Controls.Add(NumericUpDown_sec_dmgDiceD4)
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(NumericUpDown_sec_dmgBonus)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Controls.Add(CheckBox_sec_dmg_always)
        GroupBox1.Controls.Add(NumericUpDown_sec_NumberOfTargets)
        GroupBox1.Controls.Add(Label28)
        GroupBox1.Controls.Add(NumericUpDown_sec_DmgAoE)
        GroupBox1.Controls.Add(Label29)
        GroupBox1.Controls.Add(NumericUpDown_sec_hitRange)
        GroupBox1.Controls.Add(Label30)
        GroupBox1.Controls.Add(ComboBox_sec_dmg_shape)
        GroupBox1.Controls.Add(Label27)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Controls.Add(ComboBox_sec_savingThrow)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(ComboBox_sec_dmgType)
        GroupBox1.Location = New Point(444, 57)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(267, 511)
        GroupBox1.TabIndex = 56
        GroupBox1.TabStop = False
        GroupBox1.Text = "Additional DMG on Hit"
        ' 
        ' Label12
        ' 
        Label12.AccessibleRole = AccessibleRole.IpAddress
        Label12.AutoSize = True
        Label12.Location = New Point(102, 422)
        Label12.Name = "Label12"
        Label12.Size = New Size(45, 25)
        Label12.TabIndex = 81
        Label12.Text = "D20"
        ' 
        ' Label14
        ' 
        Label14.AccessibleRole = AccessibleRole.IpAddress
        Label14.AutoSize = True
        Label14.Location = New Point(31, 422)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 25)
        Label14.TabIndex = 80
        Label14.Text = "D12"
        ' 
        ' Label15
        ' 
        Label15.AccessibleRole = AccessibleRole.IpAddress
        Label15.AutoSize = True
        Label15.Location = New Point(173, 361)
        Label15.Name = "Label15"
        Label15.Size = New Size(35, 25)
        Label15.TabIndex = 79
        Label15.Text = "D8"
        ' 
        ' Label16
        ' 
        Label16.AccessibleRole = AccessibleRole.IpAddress
        Label16.AutoSize = True
        Label16.Location = New Point(102, 361)
        Label16.Name = "Label16"
        Label16.Size = New Size(35, 25)
        Label16.TabIndex = 78
        Label16.Text = "D6"
        ' 
        ' Label17
        ' 
        Label17.AccessibleRole = AccessibleRole.IpAddress
        Label17.AutoSize = True
        Label17.Location = New Point(31, 361)
        Label17.Name = "Label17"
        Label17.Size = New Size(35, 25)
        Label17.TabIndex = 77
        Label17.Text = "D4"
        ' 
        ' NumericUpDown_sec_dmgDiceD20
        ' 
        NumericUpDown_sec_dmgDiceD20.Location = New Point(102, 449)
        NumericUpDown_sec_dmgDiceD20.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_sec_dmgDiceD20.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_sec_dmgDiceD20.Name = "NumericUpDown_sec_dmgDiceD20"
        NumericUpDown_sec_dmgDiceD20.Size = New Size(60, 31)
        NumericUpDown_sec_dmgDiceD20.TabIndex = 76
        ' 
        ' NumericUpDown_sec_dmgDiceD12
        ' 
        NumericUpDown_sec_dmgDiceD12.Location = New Point(31, 449)
        NumericUpDown_sec_dmgDiceD12.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_sec_dmgDiceD12.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_sec_dmgDiceD12.Name = "NumericUpDown_sec_dmgDiceD12"
        NumericUpDown_sec_dmgDiceD12.Size = New Size(60, 31)
        NumericUpDown_sec_dmgDiceD12.TabIndex = 75
        ' 
        ' NumericUpDown_sec_dmgDiceD8
        ' 
        NumericUpDown_sec_dmgDiceD8.Location = New Point(173, 388)
        NumericUpDown_sec_dmgDiceD8.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_sec_dmgDiceD8.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_sec_dmgDiceD8.Name = "NumericUpDown_sec_dmgDiceD8"
        NumericUpDown_sec_dmgDiceD8.Size = New Size(60, 31)
        NumericUpDown_sec_dmgDiceD8.TabIndex = 74
        ' 
        ' NumericUpDown_sec_dmgDiceD6
        ' 
        NumericUpDown_sec_dmgDiceD6.Location = New Point(102, 388)
        NumericUpDown_sec_dmgDiceD6.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_sec_dmgDiceD6.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_sec_dmgDiceD6.Name = "NumericUpDown_sec_dmgDiceD6"
        NumericUpDown_sec_dmgDiceD6.Size = New Size(60, 31)
        NumericUpDown_sec_dmgDiceD6.TabIndex = 73
        ' 
        ' NumericUpDown_sec_dmgDiceD4
        ' 
        NumericUpDown_sec_dmgDiceD4.Location = New Point(31, 388)
        NumericUpDown_sec_dmgDiceD4.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_sec_dmgDiceD4.Minimum = New [Decimal](New Integer() {30, 0, 0, Integer.MinValue})
        NumericUpDown_sec_dmgDiceD4.Name = "NumericUpDown_sec_dmgDiceD4"
        NumericUpDown_sec_dmgDiceD4.Size = New Size(60, 31)
        NumericUpDown_sec_dmgDiceD4.TabIndex = 72
        ' 
        ' Label19
        ' 
        Label19.AccessibleRole = AccessibleRole.IpAddress
        Label19.AutoSize = True
        Label19.Location = New Point(31, 333)
        Label19.Name = "Label19"
        Label19.Size = New Size(95, 25)
        Label19.TabIndex = 71
        Label19.Text = "Dmg Dice:"
        ' 
        ' NumericUpDown_sec_dmgBonus
        ' 
        NumericUpDown_sec_dmgBonus.Location = New Point(173, 449)
        NumericUpDown_sec_dmgBonus.Minimum = New [Decimal](New Integer() {100, 0, 0, Integer.MinValue})
        NumericUpDown_sec_dmgBonus.Name = "NumericUpDown_sec_dmgBonus"
        NumericUpDown_sec_dmgBonus.Size = New Size(60, 31)
        NumericUpDown_sec_dmgBonus.TabIndex = 70
        ' 
        ' Label20
        ' 
        Label20.AccessibleRole = AccessibleRole.IpAddress
        Label20.AutoSize = True
        Label20.Location = New Point(173, 422)
        Label20.Name = "Label20"
        Label20.Size = New Size(65, 25)
        Label20.TabIndex = 69
        Label20.Text = "Bonus:"
        ' 
        ' CheckBox_sec_dmg_always
        ' 
        CheckBox_sec_dmg_always.AutoSize = True
        CheckBox_sec_dmg_always.Location = New Point(28, 38)
        CheckBox_sec_dmg_always.Name = "CheckBox_sec_dmg_always"
        CheckBox_sec_dmg_always.Size = New Size(196, 29)
        CheckBox_sec_dmg_always.TabIndex = 61
        CheckBox_sec_dmg_always.Text = "Always apply on Hit"
        CheckBox_sec_dmg_always.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown_sec_NumberOfTargets
        ' 
        NumericUpDown_sec_NumberOfTargets.Location = New Point(179, 291)
        NumericUpDown_sec_NumberOfTargets.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_sec_NumberOfTargets.Minimum = New [Decimal](New Integer() {1, 0, 0, 0})
        NumericUpDown_sec_NumberOfTargets.Name = "NumericUpDown_sec_NumberOfTargets"
        NumericUpDown_sec_NumberOfTargets.Size = New Size(60, 31)
        NumericUpDown_sec_NumberOfTargets.TabIndex = 68
        NumericUpDown_sec_NumberOfTargets.Value = New [Decimal](New Integer() {1, 0, 0, 0})
        ' 
        ' Label28
        ' 
        Label28.AccessibleRole = AccessibleRole.IpAddress
        Label28.AutoSize = True
        Label28.Location = New Point(175, 264)
        Label28.Name = "Label28"
        Label28.Size = New Size(72, 25)
        Label28.TabIndex = 67
        Label28.Text = "Targets:"
        ' 
        ' NumericUpDown_sec_DmgAoE
        ' 
        NumericUpDown_sec_DmgAoE.Increment = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_sec_DmgAoE.Location = New Point(108, 291)
        NumericUpDown_sec_DmgAoE.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_sec_DmgAoE.Minimum = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_sec_DmgAoE.Name = "NumericUpDown_sec_DmgAoE"
        NumericUpDown_sec_DmgAoE.Size = New Size(60, 31)
        NumericUpDown_sec_DmgAoE.TabIndex = 66
        NumericUpDown_sec_DmgAoE.Value = New [Decimal](New Integer() {5, 0, 0, 0})
        ' 
        ' Label29
        ' 
        Label29.AccessibleRole = AccessibleRole.IpAddress
        Label29.AutoSize = True
        Label29.Location = New Point(104, 264)
        Label29.Name = "Label29"
        Label29.Size = New Size(48, 25)
        Label29.TabIndex = 65
        Label29.Text = "AoE:"
        ' 
        ' NumericUpDown_sec_hitRange
        ' 
        NumericUpDown_sec_hitRange.Increment = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_sec_hitRange.Location = New Point(32, 291)
        NumericUpDown_sec_hitRange.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_sec_hitRange.Name = "NumericUpDown_sec_hitRange"
        NumericUpDown_sec_hitRange.Size = New Size(60, 31)
        NumericUpDown_sec_hitRange.TabIndex = 64
        ' 
        ' Label30
        ' 
        Label30.AccessibleRole = AccessibleRole.IpAddress
        Label30.AutoSize = True
        Label30.Location = New Point(28, 263)
        Label30.Name = "Label30"
        Label30.Size = New Size(66, 25)
        Label30.TabIndex = 63
        Label30.Text = "Range:"
        ' 
        ' ComboBox_sec_dmg_shape
        ' 
        ComboBox_sec_dmg_shape.FormattingEnabled = True
        ComboBox_sec_dmg_shape.Location = New Point(32, 227)
        ComboBox_sec_dmg_shape.Name = "ComboBox_sec_dmg_shape"
        ComboBox_sec_dmg_shape.Size = New Size(207, 33)
        ComboBox_sec_dmg_shape.TabIndex = 62
        ' 
        ' Label27
        ' 
        Label27.AccessibleRole = AccessibleRole.IpAddress
        Label27.AutoSize = True
        Label27.Location = New Point(32, 199)
        Label27.Name = "Label27"
        Label27.Size = New Size(65, 25)
        Label27.TabIndex = 61
        Label27.Text = "Shape:"
        ' 
        ' GroupBox_cond
        ' 
        GroupBox_cond.Controls.Add(CheckBox_cond_trigger_always)
        GroupBox_cond.Controls.Add(ComboBox_condition_savingThrow)
        GroupBox_cond.Controls.Add(Label22)
        GroupBox_cond.Location = New Point(717, 57)
        GroupBox_cond.Name = "GroupBox_cond"
        GroupBox_cond.Size = New Size(267, 511)
        GroupBox_cond.TabIndex = 57
        GroupBox_cond.TabStop = False
        GroupBox_cond.Text = "Triggered Condition on Hit"
        ' 
        ' CheckBox_cond_trigger_always
        ' 
        CheckBox_cond_trigger_always.AutoSize = True
        CheckBox_cond_trigger_always.Location = New Point(22, 40)
        CheckBox_cond_trigger_always.Name = "CheckBox_cond_trigger_always"
        CheckBox_cond_trigger_always.Size = New Size(206, 29)
        CheckBox_cond_trigger_always.TabIndex = 69
        CheckBox_cond_trigger_always.Text = "Always Trigger on Hit"
        CheckBox_cond_trigger_always.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ComboBox_savingThrow)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Controls.Add(NumericUpDown_hitBonus)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(CheckBox_isSavingThrow)
        GroupBox3.Location = New Point(8, 417)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(424, 151)
        GroupBox3.TabIndex = 58
        GroupBox3.TabStop = False
        GroupBox3.Text = "Hit Mechanic"
        ' 
        ' ComboBox_savingThrow
        ' 
        ComboBox_savingThrow.FormattingEnabled = True
        ComboBox_savingThrow.Location = New Point(15, 104)
        ComboBox_savingThrow.Name = "ComboBox_savingThrow"
        ComboBox_savingThrow.Size = New Size(207, 33)
        ComboBox_savingThrow.TabIndex = 56
        ' 
        ' Label25
        ' 
        Label25.AccessibleRole = AccessibleRole.IpAddress
        Label25.AutoSize = True
        Label25.Location = New Point(13, 76)
        Label25.Name = "Label25"
        Label25.Size = New Size(123, 25)
        Label25.TabIndex = 57
        Label25.Text = "Saving Throw:"
        ' 
        ' CheckBox_hitAlways
        ' 
        CheckBox_hitAlways.AutoSize = True
        CheckBox_hitAlways.Location = New Point(15, 382)
        CheckBox_hitAlways.Name = "CheckBox_hitAlways"
        CheckBox_hitAlways.Size = New Size(129, 29)
        CheckBox_hitAlways.TabIndex = 58
        CheckBox_hitAlways.Text = "Always Hits"
        CheckBox_hitAlways.UseVisualStyleBackColor = True
        ' 
        ' ComboBox_dmgShape
        ' 
        ComboBox_dmgShape.FormattingEnabled = True
        ComboBox_dmgShape.Location = New Point(221, 227)
        ComboBox_dmgShape.Name = "ComboBox_dmgShape"
        ComboBox_dmgShape.Size = New Size(207, 33)
        ComboBox_dmgShape.TabIndex = 60
        ' 
        ' Label26
        ' 
        Label26.AccessibleRole = AccessibleRole.IpAddress
        Label26.AutoSize = True
        Label26.Location = New Point(221, 199)
        Label26.Name = "Label26"
        Label26.Size = New Size(65, 25)
        Label26.TabIndex = 59
        Label26.Text = "Shape:"
        ' 
        ' ucAttack
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(CheckBox_hitAlways)
        Controls.Add(CheckBox_trigger_condition)
        Controls.Add(ComboBox_dmgShape)
        Controls.Add(Label26)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox_cond)
        Controls.Add(GroupBox1)
        Controls.Add(NumericUpDown_NumberOfTargets)
        Controls.Add(Label24)
        Controls.Add(NumericUpDown_dmgAoE)
        Controls.Add(CheckBox_trigger_secondary_attack)
        Controls.Add(Label23)
        Controls.Add(TextBox_name)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(NumericUpDown_dmgDiceD20)
        Controls.Add(NumericUpDown_dmgDiceD12)
        Controls.Add(NumericUpDown_dmgDiceD8)
        Controls.Add(NumericUpDown_dmgDiceD6)
        Controls.Add(NumericUpDown_dmgDiceD4)
        Controls.Add(Label6)
        Controls.Add(NumericUpDown_dmgBonus)
        Controls.Add(Label5)
        Controls.Add(NumericUpDown_hitRange)
        Controls.Add(Label3)
        Controls.Add(ComboBox_DmgType)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RichTextBox_Description)
        MinimumSize = New Size(1000, 580)
        Name = "ucAttack"
        Size = New Size(1000, 580)
        CType(AttackBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_hitRange, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_hitBonus, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_dmgBonus, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_dmgDiceD4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_dmgDiceD6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_dmgDiceD8, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_dmgDiceD12, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_dmgDiceD20, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_dmgAoE, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_NumberOfTargets, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown_sec_dmgDiceD20, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_dmgDiceD12, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_dmgDiceD8, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_dmgDiceD6, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_dmgDiceD4, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_dmgBonus, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_NumberOfTargets, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_DmgAoE, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_sec_hitRange, ComponentModel.ISupportInitialize).EndInit()
        GroupBox_cond.ResumeLayout(False)
        GroupBox_cond.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RichTextBox_Description As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AttackBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_DmgType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown_hitRange As NumericUpDown
    Friend WithEvents NumericUpDown_hitBonus As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown_dmgBonus As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown_dmgDiceD4 As NumericUpDown
    Friend WithEvents NumericUpDown_dmgDiceD6 As NumericUpDown
    Friend WithEvents NumericUpDown_dmgDiceD8 As NumericUpDown
    Friend WithEvents NumericUpDown_dmgDiceD12 As NumericUpDown
    Friend WithEvents NumericUpDown_dmgDiceD20 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_name As TextBox
    Friend WithEvents CheckBox_trigger_condition As CheckBox
    Friend WithEvents CheckBox_trigger_secondary_attack As CheckBox
    Friend WithEvents ComboBox_sec_dmgType As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox_sec_savingThrow As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboBox_condition_savingThrow As ComboBox
    Friend WithEvents NumericUpDown_dmgAoE As NumericUpDown
    Friend WithEvents Label23 As Label
    Friend WithEvents NumericUpDown_NumberOfTargets As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents CheckBox_isSavingThrow As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox_cond As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox_savingThrow As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents CheckBox_hitAlways As CheckBox
    Friend WithEvents ComboBox_dmgShape As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents ComboBox_sec_dmg_shape As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents NumericUpDown_sec_NumberOfTargets As NumericUpDown
    Friend WithEvents Label28 As Label
    Friend WithEvents NumericUpDown_sec_DmgAoE As NumericUpDown
    Friend WithEvents Label29 As Label
    Friend WithEvents NumericUpDown_sec_hitRange As NumericUpDown
    Friend WithEvents Label30 As Label
    Friend WithEvents CheckBox_sec_dmg_always As CheckBox
    Friend WithEvents CheckBox_cond_trigger_always As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NumericUpDown_sec_dmgDiceD20 As NumericUpDown
    Friend WithEvents NumericUpDown_sec_dmgDiceD12 As NumericUpDown
    Friend WithEvents NumericUpDown_sec_dmgDiceD8 As NumericUpDown
    Friend WithEvents NumericUpDown_sec_dmgDiceD6 As NumericUpDown
    Friend WithEvents NumericUpDown_sec_dmgDiceD4 As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents NumericUpDown_sec_dmgBonus As NumericUpDown
    Friend WithEvents Label20 As Label
End Class
