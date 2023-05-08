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
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox_Description = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AttackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_DmgType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown_hitRange = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_hitBonus = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown_dmgBonus = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown_dmgDiceD4 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_dmgDiceD6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_dmgDiceD8 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_dmgDiceD12 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_dmgDiceD20 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_name = New System.Windows.Forms.TextBox()
        Me.CheckBox_trigger_condition = New System.Windows.Forms.CheckBox()
        Me.CheckBox_trigger_secondary_attack = New System.Windows.Forms.CheckBox()
        Me.ComboBox_sec_dmgType = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox_sec_savingThrow = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBox_condition_savingThrow = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_dmgAoE = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NumericUpDown_NumberOfTargets = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CheckBox_isSavingThrow = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown_sec_NumberOfTargets = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.NumericUpDown_sec_DmgAoE = New System.Windows.Forms.NumericUpDown()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.NumericUpDown_sec_hitRange = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ComboBox_sec_dmg_shape = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_hitAlways = New System.Windows.Forms.CheckBox()
        Me.ComboBox_savingThrow = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ComboBox_dmgShape = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NumericUpDown_sec_dmgDiceD20 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_sec_dmgDiceD12 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_sec_dmgDiceD8 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_sec_dmgDiceD6 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_sec_dmgDiceD4 = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NumericUpDown_sec_dmgBonus = New System.Windows.Forms.NumericUpDown()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.AttackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_hitRange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_hitBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgAoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_NumberOfTargets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown_sec_NumberOfTargets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_sec_DmgAoE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_sec_hitRange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown_sec_dmgDiceD20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_sec_dmgDiceD12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_sec_dmgDiceD8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_sec_dmgDiceD6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_sec_dmgDiceD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_sec_dmgBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox_Description
        '
        Me.RichTextBox_Description.Location = New System.Drawing.Point(8, 95)
        Me.RichTextBox_Description.Name = "RichTextBox_Description"
        Me.RichTextBox_Description.Size = New System.Drawing.Size(420, 100)
        Me.RichTextBox_Description.TabIndex = 0
        Me.RichTextBox_Description.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description:"
        '
        'AttackBindingSource
        '
        Me.AttackBindingSource.DataSource = GetType(_210917_PnPDMTool.BaseAttack)
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dmg Type:"
        '
        'ComboBox_DmgType
        '
        Me.ComboBox_DmgType.FormattingEnabled = True
        Me.ComboBox_DmgType.Location = New System.Drawing.Point(8, 226)
        Me.ComboBox_DmgType.Name = "ComboBox_DmgType"
        Me.ComboBox_DmgType.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_DmgType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Range:"
        '
        'NumericUpDown_hitRange
        '
        Me.NumericUpDown_hitRange.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_hitRange.Location = New System.Drawing.Point(8, 294)
        Me.NumericUpDown_hitRange.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_hitRange.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_hitRange.Name = "NumericUpDown_hitRange"
        Me.NumericUpDown_hitRange.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_hitRange.TabIndex = 5
        Me.NumericUpDown_hitRange.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumericUpDown_hitBonus
        '
        Me.NumericUpDown_hitBonus.Location = New System.Drawing.Point(238, 104)
        Me.NumericUpDown_hitBonus.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_hitBonus.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_hitBonus.Name = "NumericUpDown_hitBonus"
        Me.NumericUpDown_hitBonus.Size = New System.Drawing.Size(74, 31)
        Me.NumericUpDown_hitBonus.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hit Bonus:"
        '
        'NumericUpDown_dmgBonus
        '
        Me.NumericUpDown_dmgBonus.Location = New System.Drawing.Point(363, 384)
        Me.NumericUpDown_dmgBonus.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown_dmgBonus.Name = "NumericUpDown_dmgBonus"
        Me.NumericUpDown_dmgBonus.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_dmgBonus.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Bonus:"
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dmg Dice:"
        '
        'NumericUpDown_dmgDiceD4
        '
        Me.NumericUpDown_dmgDiceD4.Location = New System.Drawing.Point(221, 323)
        Me.NumericUpDown_dmgDiceD4.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD4.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD4.Name = "NumericUpDown_dmgDiceD4"
        Me.NumericUpDown_dmgDiceD4.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_dmgDiceD4.TabIndex = 11
        '
        'NumericUpDown_dmgDiceD6
        '
        Me.NumericUpDown_dmgDiceD6.Location = New System.Drawing.Point(292, 323)
        Me.NumericUpDown_dmgDiceD6.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD6.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD6.Name = "NumericUpDown_dmgDiceD6"
        Me.NumericUpDown_dmgDiceD6.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_dmgDiceD6.TabIndex = 12
        '
        'NumericUpDown_dmgDiceD8
        '
        Me.NumericUpDown_dmgDiceD8.Location = New System.Drawing.Point(363, 323)
        Me.NumericUpDown_dmgDiceD8.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD8.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD8.Name = "NumericUpDown_dmgDiceD8"
        Me.NumericUpDown_dmgDiceD8.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_dmgDiceD8.TabIndex = 13
        '
        'NumericUpDown_dmgDiceD12
        '
        Me.NumericUpDown_dmgDiceD12.Location = New System.Drawing.Point(221, 384)
        Me.NumericUpDown_dmgDiceD12.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD12.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD12.Name = "NumericUpDown_dmgDiceD12"
        Me.NumericUpDown_dmgDiceD12.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_dmgDiceD12.TabIndex = 14
        '
        'NumericUpDown_dmgDiceD20
        '
        Me.NumericUpDown_dmgDiceD20.Location = New System.Drawing.Point(292, 384)
        Me.NumericUpDown_dmgDiceD20.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD20.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD20.Name = "NumericUpDown_dmgDiceD20"
        Me.NumericUpDown_dmgDiceD20.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_dmgDiceD20.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "D4"
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(292, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "D6"
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "D8"
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(221, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "D12"
        '
        'Label11
        '
        Me.Label11.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(292, 357)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "D20"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 25)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Name:"
        '
        'TextBox_name
        '
        Me.TextBox_name.Location = New System.Drawing.Point(8, 37)
        Me.TextBox_name.Name = "TextBox_name"
        Me.TextBox_name.Size = New System.Drawing.Size(420, 31)
        Me.TextBox_name.TabIndex = 24
        '
        'CheckBox_trigger_condition
        '
        Me.CheckBox_trigger_condition.AutoSize = True
        Me.CheckBox_trigger_condition.Location = New System.Drawing.Point(739, 22)
        Me.CheckBox_trigger_condition.Name = "CheckBox_trigger_condition"
        Me.CheckBox_trigger_condition.Size = New System.Drawing.Size(232, 29)
        Me.CheckBox_trigger_condition.TabIndex = 25
        Me.CheckBox_trigger_condition.Text = "Trigger Condition On Hit"
        Me.CheckBox_trigger_condition.UseVisualStyleBackColor = True
        '
        'CheckBox_trigger_secondary_attack
        '
        Me.CheckBox_trigger_secondary_attack.AutoSize = True
        Me.CheckBox_trigger_secondary_attack.Location = New System.Drawing.Point(458, 22)
        Me.CheckBox_trigger_secondary_attack.Name = "CheckBox_trigger_secondary_attack"
        Me.CheckBox_trigger_secondary_attack.Size = New System.Drawing.Size(225, 29)
        Me.CheckBox_trigger_secondary_attack.TabIndex = 26
        Me.CheckBox_trigger_secondary_attack.Text = "Trigger Additional DMG"
        Me.CheckBox_trigger_secondary_attack.UseVisualStyleBackColor = True
        '
        'ComboBox_sec_dmgType
        '
        Me.ComboBox_sec_dmgType.FormattingEnabled = True
        Me.ComboBox_sec_dmgType.Location = New System.Drawing.Point(32, 163)
        Me.ComboBox_sec_dmgType.Name = "ComboBox_sec_dmgType"
        Me.ComboBox_sec_dmgType.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_sec_dmgType.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 135)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 25)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Dmg Type:"
        '
        'Label21
        '
        Me.Label21.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 25)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Saving Throw:"
        '
        'ComboBox_sec_savingThrow
        '
        Me.ComboBox_sec_savingThrow.FormattingEnabled = True
        Me.ComboBox_sec_savingThrow.Location = New System.Drawing.Point(32, 99)
        Me.ComboBox_sec_savingThrow.Name = "ComboBox_sec_savingThrow"
        Me.ComboBox_sec_savingThrow.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_sec_savingThrow.TabIndex = 47
        '
        'Label22
        '
        Me.Label22.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(22, 73)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(123, 25)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Saving Throw:"
        '
        'ComboBox_condition_savingThrow
        '
        Me.ComboBox_condition_savingThrow.FormattingEnabled = True
        Me.ComboBox_condition_savingThrow.Location = New System.Drawing.Point(24, 101)
        Me.ComboBox_condition_savingThrow.Name = "ComboBox_condition_savingThrow"
        Me.ComboBox_condition_savingThrow.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_condition_savingThrow.TabIndex = 49
        '
        'NumericUpDown_dmgAoE
        '
        Me.NumericUpDown_dmgAoE.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_dmgAoE.Location = New System.Drawing.Point(74, 294)
        Me.NumericUpDown_dmgAoE.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_dmgAoE.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_dmgAoE.Name = "NumericUpDown_dmgAoE"
        Me.NumericUpDown_dmgAoE.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_dmgAoE.TabIndex = 52
        Me.NumericUpDown_dmgAoE.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label23
        '
        Me.Label23.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(74, 268)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 25)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "AoE:"
        '
        'NumericUpDown_NumberOfTargets
        '
        Me.NumericUpDown_NumberOfTargets.Location = New System.Drawing.Point(140, 294)
        Me.NumericUpDown_NumberOfTargets.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_NumberOfTargets.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_NumberOfTargets.Name = "NumericUpDown_NumberOfTargets"
        Me.NumericUpDown_NumberOfTargets.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_NumberOfTargets.TabIndex = 54
        Me.NumericUpDown_NumberOfTargets.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label24
        '
        Me.Label24.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(140, 268)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 25)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "Targets:"
        '
        'CheckBox_isSavingThrow
        '
        Me.CheckBox_isSavingThrow.AutoSize = True
        Me.CheckBox_isSavingThrow.Location = New System.Drawing.Point(14, 44)
        Me.CheckBox_isSavingThrow.Name = "CheckBox_isSavingThrow"
        Me.CheckBox_isSavingThrow.Size = New System.Drawing.Size(163, 29)
        Me.CheckBox_isSavingThrow.TabIndex = 55
        Me.CheckBox_isSavingThrow.Text = "Is Saving Throw"
        Me.CheckBox_isSavingThrow.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_dmgDiceD20)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_dmgDiceD12)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_dmgDiceD8)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_dmgDiceD6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_dmgDiceD4)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_dmgBonus)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_NumberOfTargets)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_DmgAoE)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown_sec_hitRange)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.ComboBox_sec_dmg_shape)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.ComboBox_sec_savingThrow)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.ComboBox_sec_dmgType)
        Me.GroupBox1.Location = New System.Drawing.Point(444, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 511)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional DMG on Hit"
        '
        'NumericUpDown_sec_NumberOfTargets
        '
        Me.NumericUpDown_sec_NumberOfTargets.Location = New System.Drawing.Point(179, 291)
        Me.NumericUpDown_sec_NumberOfTargets.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_sec_NumberOfTargets.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_sec_NumberOfTargets.Name = "NumericUpDown_sec_NumberOfTargets"
        Me.NumericUpDown_sec_NumberOfTargets.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_NumberOfTargets.TabIndex = 68
        Me.NumericUpDown_sec_NumberOfTargets.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label28
        '
        Me.Label28.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(175, 264)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 25)
        Me.Label28.TabIndex = 67
        Me.Label28.Text = "Targets:"
        '
        'NumericUpDown_sec_DmgAoE
        '
        Me.NumericUpDown_sec_DmgAoE.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_sec_DmgAoE.Location = New System.Drawing.Point(108, 291)
        Me.NumericUpDown_sec_DmgAoE.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_sec_DmgAoE.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_sec_DmgAoE.Name = "NumericUpDown_sec_DmgAoE"
        Me.NumericUpDown_sec_DmgAoE.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_DmgAoE.TabIndex = 66
        Me.NumericUpDown_sec_DmgAoE.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(104, 264)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 25)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "AoE:"
        '
        'NumericUpDown_sec_hitRange
        '
        Me.NumericUpDown_sec_hitRange.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_sec_hitRange.Location = New System.Drawing.Point(32, 291)
        Me.NumericUpDown_sec_hitRange.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_sec_hitRange.Name = "NumericUpDown_sec_hitRange"
        Me.NumericUpDown_sec_hitRange.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_hitRange.TabIndex = 64
        '
        'Label30
        '
        Me.Label30.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(28, 263)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 25)
        Me.Label30.TabIndex = 63
        Me.Label30.Text = "Range:"
        '
        'ComboBox_sec_dmg_shape
        '
        Me.ComboBox_sec_dmg_shape.FormattingEnabled = True
        Me.ComboBox_sec_dmg_shape.Location = New System.Drawing.Point(32, 227)
        Me.ComboBox_sec_dmg_shape.Name = "ComboBox_sec_dmg_shape"
        Me.ComboBox_sec_dmg_shape.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_sec_dmg_shape.TabIndex = 62
        '
        'Label27
        '
        Me.Label27.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(32, 199)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(65, 25)
        Me.Label27.TabIndex = 61
        Me.Label27.Text = "Shape:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox_condition_savingThrow)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Location = New System.Drawing.Point(717, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 511)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Triggered Condition on Hit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox_savingThrow)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown_hitBonus)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CheckBox_isSavingThrow)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 417)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(424, 151)
        Me.GroupBox3.TabIndex = 58
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hit Mechanic"
        '
        'CheckBox_hitAlways
        '
        Me.CheckBox_hitAlways.AutoSize = True
        Me.CheckBox_hitAlways.Location = New System.Drawing.Point(15, 382)
        Me.CheckBox_hitAlways.Name = "CheckBox_hitAlways"
        Me.CheckBox_hitAlways.Size = New System.Drawing.Size(129, 29)
        Me.CheckBox_hitAlways.TabIndex = 58
        Me.CheckBox_hitAlways.Text = "Always Hits"
        Me.CheckBox_hitAlways.UseVisualStyleBackColor = True
        '
        'ComboBox_savingThrow
        '
        Me.ComboBox_savingThrow.FormattingEnabled = True
        Me.ComboBox_savingThrow.Location = New System.Drawing.Point(15, 104)
        Me.ComboBox_savingThrow.Name = "ComboBox_savingThrow"
        Me.ComboBox_savingThrow.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_savingThrow.TabIndex = 56
        '
        'Label25
        '
        Me.Label25.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(13, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(123, 25)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "Saving Throw:"
        '
        'ComboBox_dmgShape
        '
        Me.ComboBox_dmgShape.FormattingEnabled = True
        Me.ComboBox_dmgShape.Location = New System.Drawing.Point(221, 227)
        Me.ComboBox_dmgShape.Name = "ComboBox_dmgShape"
        Me.ComboBox_dmgShape.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_dmgShape.TabIndex = 60
        '
        'Label26
        '
        Me.Label26.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(221, 199)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 25)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "Shape:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(28, 38)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(196, 29)
        Me.CheckBox1.TabIndex = 61
        Me.CheckBox1.Text = "Always apply on Hit"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(22, 40)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(206, 29)
        Me.CheckBox2.TabIndex = 69
        Me.CheckBox2.Text = "Always Trigger on Hit"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(102, 422)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 25)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "D20"
        '
        'Label14
        '
        Me.Label14.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 422)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 25)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "D12"
        '
        'Label15
        '
        Me.Label15.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(173, 361)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 25)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "D8"
        '
        'Label16
        '
        Me.Label16.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(102, 361)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 25)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "D6"
        '
        'Label17
        '
        Me.Label17.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(31, 361)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 25)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "D4"
        '
        'NumericUpDown_sec_dmgDiceD20
        '
        Me.NumericUpDown_sec_dmgDiceD20.Location = New System.Drawing.Point(102, 449)
        Me.NumericUpDown_sec_dmgDiceD20.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_sec_dmgDiceD20.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_sec_dmgDiceD20.Name = "NumericUpDown_sec_dmgDiceD20"
        Me.NumericUpDown_sec_dmgDiceD20.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_dmgDiceD20.TabIndex = 76
        '
        'NumericUpDown_sec_dmgDiceD12
        '
        Me.NumericUpDown_sec_dmgDiceD12.Location = New System.Drawing.Point(31, 449)
        Me.NumericUpDown_sec_dmgDiceD12.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_sec_dmgDiceD12.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_sec_dmgDiceD12.Name = "NumericUpDown_sec_dmgDiceD12"
        Me.NumericUpDown_sec_dmgDiceD12.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_dmgDiceD12.TabIndex = 75
        '
        'NumericUpDown_sec_dmgDiceD8
        '
        Me.NumericUpDown_sec_dmgDiceD8.Location = New System.Drawing.Point(173, 388)
        Me.NumericUpDown_sec_dmgDiceD8.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_sec_dmgDiceD8.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_sec_dmgDiceD8.Name = "NumericUpDown_sec_dmgDiceD8"
        Me.NumericUpDown_sec_dmgDiceD8.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_dmgDiceD8.TabIndex = 74
        '
        'NumericUpDown_sec_dmgDiceD6
        '
        Me.NumericUpDown_sec_dmgDiceD6.Location = New System.Drawing.Point(102, 388)
        Me.NumericUpDown_sec_dmgDiceD6.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_sec_dmgDiceD6.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_sec_dmgDiceD6.Name = "NumericUpDown_sec_dmgDiceD6"
        Me.NumericUpDown_sec_dmgDiceD6.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_dmgDiceD6.TabIndex = 73
        '
        'NumericUpDown_sec_dmgDiceD4
        '
        Me.NumericUpDown_sec_dmgDiceD4.Location = New System.Drawing.Point(31, 388)
        Me.NumericUpDown_sec_dmgDiceD4.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_sec_dmgDiceD4.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_sec_dmgDiceD4.Name = "NumericUpDown_sec_dmgDiceD4"
        Me.NumericUpDown_sec_dmgDiceD4.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_dmgDiceD4.TabIndex = 72
        '
        'Label19
        '
        Me.Label19.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 333)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 25)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "Dmg Dice:"
        '
        'NumericUpDown_sec_dmgBonus
        '
        Me.NumericUpDown_sec_dmgBonus.Location = New System.Drawing.Point(173, 449)
        Me.NumericUpDown_sec_dmgBonus.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown_sec_dmgBonus.Name = "NumericUpDown_sec_dmgBonus"
        Me.NumericUpDown_sec_dmgBonus.Size = New System.Drawing.Size(60, 31)
        Me.NumericUpDown_sec_dmgBonus.TabIndex = 70
        '
        'Label20
        '
        Me.Label20.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(173, 422)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 25)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Bonus:"
        '
        'ucAttack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckBox_hitAlways)
        Me.Controls.Add(Me.CheckBox_trigger_condition)
        Me.Controls.Add(Me.ComboBox_dmgShape)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NumericUpDown_NumberOfTargets)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.NumericUpDown_dmgAoE)
        Me.Controls.Add(Me.CheckBox_trigger_secondary_attack)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox_name)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD20)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD12)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD8)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD6)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown_dmgBonus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown_hitRange)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox_DmgType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox_Description)
        Me.Name = "ucAttack"
        Me.Size = New System.Drawing.Size(980, 733)
        CType(Me.AttackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_hitRange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_hitBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgAoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_NumberOfTargets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown_sec_NumberOfTargets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_sec_DmgAoE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_sec_hitRange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDown_sec_dmgDiceD20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_sec_dmgDiceD12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_sec_dmgDiceD8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_sec_dmgDiceD6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_sec_dmgDiceD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_sec_dmgBonus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
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
