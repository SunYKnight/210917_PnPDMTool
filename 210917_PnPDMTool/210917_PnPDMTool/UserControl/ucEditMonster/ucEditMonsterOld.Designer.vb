<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMonster
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbOpponent = New System.Windows.Forms.Label()
        Me.lbAc = New System.Windows.Forms.Label()
        Me.txtAc = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtDice = New System.Windows.Forms.TextBox()
        Me.txtModifier = New System.Windows.Forms.TextBox()
        Me.lbDice = New System.Windows.Forms.Label()
        Me.lbNumber = New System.Windows.Forms.Label()
        Me.lbModifier = New System.Windows.Forms.Label()
        Me.lbMp = New System.Windows.Forms.Label()
        Me.lbLv1 = New System.Windows.Forms.Label()
        Me.lbLv2 = New System.Windows.Forms.Label()
        Me.lbLv3 = New System.Windows.Forms.Label()
        Me.lbLv4 = New System.Windows.Forms.Label()
        Me.lbLv5 = New System.Windows.Forms.Label()
        Me.lbLv6 = New System.Windows.Forms.Label()
        Me.lbLv7 = New System.Windows.Forms.Label()
        Me.lbLv8 = New System.Windows.Forms.Label()
        Me.lbLv9 = New System.Windows.Forms.Label()
        Me.txtLv1 = New System.Windows.Forms.TextBox()
        Me.txtLv2 = New System.Windows.Forms.TextBox()
        Me.txtLv3 = New System.Windows.Forms.TextBox()
        Me.txtLv4 = New System.Windows.Forms.TextBox()
        Me.txtLv5 = New System.Windows.Forms.TextBox()
        Me.txtLv6 = New System.Windows.Forms.TextBox()
        Me.txtLv7 = New System.Windows.Forms.TextBox()
        Me.txtLv8 = New System.Windows.Forms.TextBox()
        Me.txtLv9 = New System.Windows.Forms.TextBox()
        Me.lbMaxHp = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbSavingThrows = New System.Windows.Forms.Label()
        Me.lbProficiency = New System.Windows.Forms.Label()
        Me.lbSkills = New System.Windows.Forms.Label()
        Me.lbSenses = New System.Windows.Forms.Label()
        Me.lbLanguages = New System.Windows.Forms.Label()
        Me.lbChallenge = New System.Windows.Forms.Label()
        Me.lbSpeed = New System.Windows.Forms.Label()
        Me.lbEffects = New System.Windows.Forms.Label()
        Me.lbDamageImmunities = New System.Windows.Forms.Label()
        Me.lbDamageResistance = New System.Windows.Forms.Label()
        Me.lbDamageVulnerabilities = New System.Windows.Forms.Label()
        Me.lbConditionImmunities = New System.Windows.Forms.Label()
        Me.lbConditionResistance = New System.Windows.Forms.Label()
        Me.lbLegendaryResistance = New System.Windows.Forms.Label()
        Me.lbMagicResistance = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSavingThrows = New System.Windows.Forms.TextBox()
        Me.txtProficiency = New System.Windows.Forms.TextBox()
        Me.txtSkills = New System.Windows.Forms.TextBox()
        Me.txtSenses = New System.Windows.Forms.TextBox()
        Me.txtChallenge = New System.Windows.Forms.TextBox()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.txtEffects = New System.Windows.Forms.TextBox()
        Me.txtDamageImmunities = New System.Windows.Forms.TextBox()
        Me.txtDamageResistance = New System.Windows.Forms.TextBox()
        Me.txtDamageVulnerabilities = New System.Windows.Forms.TextBox()
        Me.txtConditionImmunities = New System.Windows.Forms.TextBox()
        Me.txtConditionResistance = New System.Windows.Forms.TextBox()
        Me.txtLegendaryResistance = New System.Windows.Forms.TextBox()
        Me.txtMagicResistance = New System.Windows.Forms.TextBox()
        Me.txtOthers = New System.Windows.Forms.TextBox()
        Me.btnActions = New System.Windows.Forms.Button()
        Me.btnLegendaryActions = New System.Windows.Forms.Button()
        Me.lbInformations = New System.Windows.Forms.Label()
        Me.lbEnvironment = New System.Windows.Forms.Label()
        Me.txtEnvironment = New System.Windows.Forms.TextBox()
        Me.lbImage = New System.Windows.Forms.Label()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.lbOthers = New System.Windows.Forms.Label()
        Me.ComboBox_languages = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbOpponent
        '
        Me.lbOpponent.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbOpponent.Location = New System.Drawing.Point(4, 0)
        Me.lbOpponent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOpponent.Name = "lbOpponent"
        Me.lbOpponent.Size = New System.Drawing.Size(906, 67)
        Me.lbOpponent.TabIndex = 1
        Me.lbOpponent.Text = "Opponent"
        Me.lbOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbAc
        '
        Me.lbAc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbAc.Location = New System.Drawing.Point(263, 455)
        Me.lbAc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbAc.Name = "lbAc"
        Me.lbAc.Size = New System.Drawing.Size(72, 45)
        Me.lbAc.TabIndex = 14
        Me.lbAc.Text = "AC"
        Me.lbAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAc
        '
        Me.txtAc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAc.Location = New System.Drawing.Point(372, 455)
        Me.txtAc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAc.Name = "txtAc"
        Me.txtAc.Size = New System.Drawing.Size(71, 37)
        Me.txtAc.TabIndex = 15
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumber.Location = New System.Drawing.Point(372, 1068)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(71, 37)
        Me.txtNumber.TabIndex = 17
        '
        'txtDice
        '
        Me.txtDice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDice.Location = New System.Drawing.Point(372, 1120)
        Me.txtDice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDice.Name = "txtDice"
        Me.txtDice.Size = New System.Drawing.Size(71, 37)
        Me.txtDice.TabIndex = 18
        '
        'txtModifier
        '
        Me.txtModifier.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtModifier.Location = New System.Drawing.Point(372, 1175)
        Me.txtModifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtModifier.Name = "txtModifier"
        Me.txtModifier.Size = New System.Drawing.Size(71, 37)
        Me.txtModifier.TabIndex = 19
        '
        'lbDice
        '
        Me.lbDice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDice.Location = New System.Drawing.Point(263, 1125)
        Me.lbDice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDice.Name = "lbDice"
        Me.lbDice.Size = New System.Drawing.Size(72, 45)
        Me.lbDice.TabIndex = 20
        Me.lbDice.Text = "Dice"
        Me.lbDice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbNumber
        '
        Me.lbNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbNumber.Location = New System.Drawing.Point(263, 1068)
        Me.lbNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNumber.Name = "lbNumber"
        Me.lbNumber.Size = New System.Drawing.Size(101, 45)
        Me.lbNumber.TabIndex = 21
        Me.lbNumber.Text = "Number"
        Me.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbModifier
        '
        Me.lbModifier.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbModifier.Location = New System.Drawing.Point(263, 1177)
        Me.lbModifier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbModifier.Name = "lbModifier"
        Me.lbModifier.Size = New System.Drawing.Size(101, 45)
        Me.lbModifier.TabIndex = 22
        Me.lbModifier.Text = "Modifier"
        Me.lbModifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMp
        '
        Me.lbMp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbMp.Location = New System.Drawing.Point(263, 538)
        Me.lbMp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMp.Name = "lbMp"
        Me.lbMp.Size = New System.Drawing.Size(152, 45)
        Me.lbMp.TabIndex = 23
        Me.lbMp.Text = "MP"
        Me.lbMp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbLv1
        '
        Me.lbLv1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv1.Location = New System.Drawing.Point(263, 583)
        Me.lbLv1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv1.Name = "lbLv1"
        Me.lbLv1.Size = New System.Drawing.Size(72, 45)
        Me.lbLv1.TabIndex = 24
        Me.lbLv1.Text = "LV1"
        Me.lbLv1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv2
        '
        Me.lbLv2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv2.Location = New System.Drawing.Point(263, 628)
        Me.lbLv2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv2.Name = "lbLv2"
        Me.lbLv2.Size = New System.Drawing.Size(72, 45)
        Me.lbLv2.TabIndex = 25
        Me.lbLv2.Text = "LV2"
        Me.lbLv2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv3
        '
        Me.lbLv3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv3.Location = New System.Drawing.Point(263, 673)
        Me.lbLv3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv3.Name = "lbLv3"
        Me.lbLv3.Size = New System.Drawing.Size(72, 45)
        Me.lbLv3.TabIndex = 26
        Me.lbLv3.Text = "LV3"
        Me.lbLv3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv4
        '
        Me.lbLv4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv4.Location = New System.Drawing.Point(263, 718)
        Me.lbLv4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv4.Name = "lbLv4"
        Me.lbLv4.Size = New System.Drawing.Size(72, 45)
        Me.lbLv4.TabIndex = 27
        Me.lbLv4.Text = "LV4"
        Me.lbLv4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv5
        '
        Me.lbLv5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv5.Location = New System.Drawing.Point(263, 763)
        Me.lbLv5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv5.Name = "lbLv5"
        Me.lbLv5.Size = New System.Drawing.Size(72, 45)
        Me.lbLv5.TabIndex = 28
        Me.lbLv5.Text = "LV5"
        Me.lbLv5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv6
        '
        Me.lbLv6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv6.Location = New System.Drawing.Point(263, 808)
        Me.lbLv6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv6.Name = "lbLv6"
        Me.lbLv6.Size = New System.Drawing.Size(72, 45)
        Me.lbLv6.TabIndex = 29
        Me.lbLv6.Text = "LV6"
        Me.lbLv6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv7
        '
        Me.lbLv7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv7.Location = New System.Drawing.Point(263, 853)
        Me.lbLv7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv7.Name = "lbLv7"
        Me.lbLv7.Size = New System.Drawing.Size(72, 45)
        Me.lbLv7.TabIndex = 30
        Me.lbLv7.Text = "LV7"
        Me.lbLv7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv8
        '
        Me.lbLv8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv8.Location = New System.Drawing.Point(263, 898)
        Me.lbLv8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv8.Name = "lbLv8"
        Me.lbLv8.Size = New System.Drawing.Size(72, 45)
        Me.lbLv8.TabIndex = 31
        Me.lbLv8.Text = "LV8"
        Me.lbLv8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv9
        '
        Me.lbLv9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv9.Location = New System.Drawing.Point(263, 943)
        Me.lbLv9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLv9.Name = "lbLv9"
        Me.lbLv9.Size = New System.Drawing.Size(72, 45)
        Me.lbLv9.TabIndex = 32
        Me.lbLv9.Text = "LV9"
        Me.lbLv9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLv1
        '
        Me.txtLv1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv1.Location = New System.Drawing.Point(372, 588)
        Me.txtLv1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv1.Name = "txtLv1"
        Me.txtLv1.Size = New System.Drawing.Size(71, 37)
        Me.txtLv1.TabIndex = 33
        '
        'txtLv2
        '
        Me.txtLv2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv2.Location = New System.Drawing.Point(372, 633)
        Me.txtLv2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv2.Name = "txtLv2"
        Me.txtLv2.Size = New System.Drawing.Size(71, 37)
        Me.txtLv2.TabIndex = 34
        '
        'txtLv3
        '
        Me.txtLv3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv3.Location = New System.Drawing.Point(372, 678)
        Me.txtLv3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv3.Name = "txtLv3"
        Me.txtLv3.Size = New System.Drawing.Size(71, 37)
        Me.txtLv3.TabIndex = 35
        '
        'txtLv4
        '
        Me.txtLv4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv4.Location = New System.Drawing.Point(372, 723)
        Me.txtLv4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv4.Name = "txtLv4"
        Me.txtLv4.Size = New System.Drawing.Size(71, 37)
        Me.txtLv4.TabIndex = 36
        '
        'txtLv5
        '
        Me.txtLv5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv5.Location = New System.Drawing.Point(372, 768)
        Me.txtLv5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv5.Name = "txtLv5"
        Me.txtLv5.Size = New System.Drawing.Size(71, 37)
        Me.txtLv5.TabIndex = 37
        '
        'txtLv6
        '
        Me.txtLv6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv6.Location = New System.Drawing.Point(372, 813)
        Me.txtLv6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv6.Name = "txtLv6"
        Me.txtLv6.Size = New System.Drawing.Size(71, 37)
        Me.txtLv6.TabIndex = 38
        '
        'txtLv7
        '
        Me.txtLv7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv7.Location = New System.Drawing.Point(372, 858)
        Me.txtLv7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv7.Name = "txtLv7"
        Me.txtLv7.Size = New System.Drawing.Size(71, 37)
        Me.txtLv7.TabIndex = 39
        '
        'txtLv8
        '
        Me.txtLv8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv8.Location = New System.Drawing.Point(372, 903)
        Me.txtLv8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv8.Name = "txtLv8"
        Me.txtLv8.Size = New System.Drawing.Size(71, 37)
        Me.txtLv8.TabIndex = 40
        '
        'txtLv9
        '
        Me.txtLv9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv9.Location = New System.Drawing.Point(372, 948)
        Me.txtLv9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLv9.Name = "txtLv9"
        Me.txtLv9.Size = New System.Drawing.Size(71, 37)
        Me.txtLv9.TabIndex = 41
        '
        'lbMaxHp
        '
        Me.lbMaxHp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbMaxHp.Location = New System.Drawing.Point(263, 1018)
        Me.lbMaxHp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMaxHp.Name = "lbMaxHp"
        Me.lbMaxHp.Size = New System.Drawing.Size(152, 45)
        Me.lbMaxHp.TabIndex = 43
        Me.lbMaxHp.Text = "max. HP"
        Me.lbMaxHp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbName.Location = New System.Drawing.Point(271, 108)
        Me.lbName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(243, 45)
        Me.lbName.TabIndex = 44
        Me.lbName.Text = "Name:"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSavingThrows
        '
        Me.lbSavingThrows.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSavingThrows.Location = New System.Drawing.Point(529, 340)
        Me.lbSavingThrows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSavingThrows.Name = "lbSavingThrows"
        Me.lbSavingThrows.Size = New System.Drawing.Size(243, 45)
        Me.lbSavingThrows.TabIndex = 45
        Me.lbSavingThrows.Text = "Saving Throws:"
        Me.lbSavingThrows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbProficiency
        '
        Me.lbProficiency.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbProficiency.Location = New System.Drawing.Point(529, 395)
        Me.lbProficiency.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbProficiency.Name = "lbProficiency"
        Me.lbProficiency.Size = New System.Drawing.Size(243, 45)
        Me.lbProficiency.TabIndex = 46
        Me.lbProficiency.Text = "Proficiency:"
        Me.lbProficiency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSkills
        '
        Me.lbSkills.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSkills.Location = New System.Drawing.Point(529, 450)
        Me.lbSkills.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSkills.Name = "lbSkills"
        Me.lbSkills.Size = New System.Drawing.Size(243, 45)
        Me.lbSkills.TabIndex = 47
        Me.lbSkills.Text = "Skills:"
        Me.lbSkills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSenses
        '
        Me.lbSenses.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSenses.Location = New System.Drawing.Point(529, 505)
        Me.lbSenses.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSenses.Name = "lbSenses"
        Me.lbSenses.Size = New System.Drawing.Size(243, 45)
        Me.lbSenses.TabIndex = 48
        Me.lbSenses.Text = "Senses:"
        Me.lbSenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLanguages
        '
        Me.lbLanguages.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLanguages.Location = New System.Drawing.Point(529, 557)
        Me.lbLanguages.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLanguages.Name = "lbLanguages"
        Me.lbLanguages.Size = New System.Drawing.Size(190, 45)
        Me.lbLanguages.TabIndex = 49
        Me.lbLanguages.Text = "Languages:"
        Me.lbLanguages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbChallenge
        '
        Me.lbChallenge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbChallenge.Location = New System.Drawing.Point(529, 615)
        Me.lbChallenge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbChallenge.Name = "lbChallenge"
        Me.lbChallenge.Size = New System.Drawing.Size(243, 45)
        Me.lbChallenge.TabIndex = 50
        Me.lbChallenge.Text = "Challenge:"
        Me.lbChallenge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSpeed
        '
        Me.lbSpeed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSpeed.Location = New System.Drawing.Point(529, 670)
        Me.lbSpeed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSpeed.Name = "lbSpeed"
        Me.lbSpeed.Size = New System.Drawing.Size(243, 45)
        Me.lbSpeed.TabIndex = 51
        Me.lbSpeed.Text = "Speed:"
        Me.lbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEffects
        '
        Me.lbEffects.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbEffects.Location = New System.Drawing.Point(529, 725)
        Me.lbEffects.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEffects.Name = "lbEffects"
        Me.lbEffects.Size = New System.Drawing.Size(243, 45)
        Me.lbEffects.TabIndex = 52
        Me.lbEffects.Text = "Effects:"
        Me.lbEffects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDamageImmunities
        '
        Me.lbDamageImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDamageImmunities.Location = New System.Drawing.Point(529, 787)
        Me.lbDamageImmunities.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDamageImmunities.Name = "lbDamageImmunities"
        Me.lbDamageImmunities.Size = New System.Drawing.Size(243, 45)
        Me.lbDamageImmunities.TabIndex = 53
        Me.lbDamageImmunities.Text = "Damage Immunities:"
        Me.lbDamageImmunities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDamageResistance
        '
        Me.lbDamageResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDamageResistance.Location = New System.Drawing.Point(529, 842)
        Me.lbDamageResistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDamageResistance.Name = "lbDamageResistance"
        Me.lbDamageResistance.Size = New System.Drawing.Size(243, 45)
        Me.lbDamageResistance.TabIndex = 54
        Me.lbDamageResistance.Text = "Damage Resistance:"
        Me.lbDamageResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDamageVulnerabilities
        '
        Me.lbDamageVulnerabilities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDamageVulnerabilities.Location = New System.Drawing.Point(529, 897)
        Me.lbDamageVulnerabilities.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDamageVulnerabilities.Name = "lbDamageVulnerabilities"
        Me.lbDamageVulnerabilities.Size = New System.Drawing.Size(243, 45)
        Me.lbDamageVulnerabilities.TabIndex = 55
        Me.lbDamageVulnerabilities.Text = "Damage Vulnerabilities:"
        Me.lbDamageVulnerabilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConditionImmunities
        '
        Me.lbConditionImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbConditionImmunities.Location = New System.Drawing.Point(529, 952)
        Me.lbConditionImmunities.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbConditionImmunities.Name = "lbConditionImmunities"
        Me.lbConditionImmunities.Size = New System.Drawing.Size(243, 45)
        Me.lbConditionImmunities.TabIndex = 56
        Me.lbConditionImmunities.Text = "Condition Immunities:"
        Me.lbConditionImmunities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConditionResistance
        '
        Me.lbConditionResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbConditionResistance.Location = New System.Drawing.Point(529, 1007)
        Me.lbConditionResistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbConditionResistance.Name = "lbConditionResistance"
        Me.lbConditionResistance.Size = New System.Drawing.Size(243, 45)
        Me.lbConditionResistance.TabIndex = 57
        Me.lbConditionResistance.Text = "Condition Resistance:"
        Me.lbConditionResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLegendaryResistance
        '
        Me.lbLegendaryResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLegendaryResistance.Location = New System.Drawing.Point(529, 1065)
        Me.lbLegendaryResistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLegendaryResistance.Name = "lbLegendaryResistance"
        Me.lbLegendaryResistance.Size = New System.Drawing.Size(243, 45)
        Me.lbLegendaryResistance.TabIndex = 58
        Me.lbLegendaryResistance.Text = "Legendary Resistance:"
        Me.lbLegendaryResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMagicResistance
        '
        Me.lbMagicResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbMagicResistance.Location = New System.Drawing.Point(529, 1120)
        Me.lbMagicResistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMagicResistance.Name = "lbMagicResistance"
        Me.lbMagicResistance.Size = New System.Drawing.Size(243, 45)
        Me.lbMagicResistance.TabIndex = 59
        Me.lbMagicResistance.Text = "Magic Resistance:"
        Me.lbMagicResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(1660, 1230)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 50)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDiscard
        '
        Me.btnDiscard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDiscard.Location = New System.Drawing.Point(1544, 1230)
        Me.btnDiscard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(107, 50)
        Me.btnDiscard.TabIndex = 62
        Me.btnDiscard.Text = "discard"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(523, 108)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(1243, 37)
        Me.txtName.TabIndex = 63
        '
        'txtSavingThrows
        '
        Me.txtSavingThrows.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSavingThrows.Location = New System.Drawing.Point(780, 340)
        Me.txtSavingThrows.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSavingThrows.Multiline = True
        Me.txtSavingThrows.Name = "txtSavingThrows"
        Me.txtSavingThrows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSavingThrows.Size = New System.Drawing.Size(986, 42)
        Me.txtSavingThrows.TabIndex = 64
        '
        'txtProficiency
        '
        Me.txtProficiency.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtProficiency.Location = New System.Drawing.Point(780, 395)
        Me.txtProficiency.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProficiency.Multiline = True
        Me.txtProficiency.Name = "txtProficiency"
        Me.txtProficiency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProficiency.Size = New System.Drawing.Size(986, 42)
        Me.txtProficiency.TabIndex = 65
        '
        'txtSkills
        '
        Me.txtSkills.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSkills.Location = New System.Drawing.Point(780, 450)
        Me.txtSkills.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSkills.Multiline = True
        Me.txtSkills.Name = "txtSkills"
        Me.txtSkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSkills.Size = New System.Drawing.Size(986, 42)
        Me.txtSkills.TabIndex = 66
        '
        'txtSenses
        '
        Me.txtSenses.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSenses.Location = New System.Drawing.Point(780, 505)
        Me.txtSenses.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSenses.Multiline = True
        Me.txtSenses.Name = "txtSenses"
        Me.txtSenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSenses.Size = New System.Drawing.Size(986, 42)
        Me.txtSenses.TabIndex = 67
        '
        'txtChallenge
        '
        Me.txtChallenge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtChallenge.Location = New System.Drawing.Point(780, 615)
        Me.txtChallenge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChallenge.Multiline = True
        Me.txtChallenge.Name = "txtChallenge"
        Me.txtChallenge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChallenge.Size = New System.Drawing.Size(986, 42)
        Me.txtChallenge.TabIndex = 69
        '
        'txtSpeed
        '
        Me.txtSpeed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSpeed.Location = New System.Drawing.Point(780, 670)
        Me.txtSpeed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSpeed.Multiline = True
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSpeed.Size = New System.Drawing.Size(986, 42)
        Me.txtSpeed.TabIndex = 70
        '
        'txtEffects
        '
        Me.txtEffects.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEffects.Location = New System.Drawing.Point(780, 725)
        Me.txtEffects.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEffects.Multiline = True
        Me.txtEffects.Name = "txtEffects"
        Me.txtEffects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEffects.Size = New System.Drawing.Size(986, 42)
        Me.txtEffects.TabIndex = 71
        '
        'txtDamageImmunities
        '
        Me.txtDamageImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDamageImmunities.Location = New System.Drawing.Point(780, 787)
        Me.txtDamageImmunities.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDamageImmunities.Multiline = True
        Me.txtDamageImmunities.Name = "txtDamageImmunities"
        Me.txtDamageImmunities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDamageImmunities.Size = New System.Drawing.Size(986, 42)
        Me.txtDamageImmunities.TabIndex = 72
        '
        'txtDamageResistance
        '
        Me.txtDamageResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDamageResistance.Location = New System.Drawing.Point(780, 842)
        Me.txtDamageResistance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDamageResistance.Multiline = True
        Me.txtDamageResistance.Name = "txtDamageResistance"
        Me.txtDamageResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDamageResistance.Size = New System.Drawing.Size(986, 42)
        Me.txtDamageResistance.TabIndex = 73
        '
        'txtDamageVulnerabilities
        '
        Me.txtDamageVulnerabilities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDamageVulnerabilities.Location = New System.Drawing.Point(780, 897)
        Me.txtDamageVulnerabilities.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDamageVulnerabilities.Multiline = True
        Me.txtDamageVulnerabilities.Name = "txtDamageVulnerabilities"
        Me.txtDamageVulnerabilities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDamageVulnerabilities.Size = New System.Drawing.Size(986, 42)
        Me.txtDamageVulnerabilities.TabIndex = 74
        '
        'txtConditionImmunities
        '
        Me.txtConditionImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConditionImmunities.Location = New System.Drawing.Point(780, 952)
        Me.txtConditionImmunities.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConditionImmunities.Multiline = True
        Me.txtConditionImmunities.Name = "txtConditionImmunities"
        Me.txtConditionImmunities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConditionImmunities.Size = New System.Drawing.Size(986, 42)
        Me.txtConditionImmunities.TabIndex = 75
        '
        'txtConditionResistance
        '
        Me.txtConditionResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConditionResistance.Location = New System.Drawing.Point(780, 1007)
        Me.txtConditionResistance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConditionResistance.Multiline = True
        Me.txtConditionResistance.Name = "txtConditionResistance"
        Me.txtConditionResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConditionResistance.Size = New System.Drawing.Size(986, 42)
        Me.txtConditionResistance.TabIndex = 76
        '
        'txtLegendaryResistance
        '
        Me.txtLegendaryResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLegendaryResistance.Location = New System.Drawing.Point(780, 1065)
        Me.txtLegendaryResistance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLegendaryResistance.Multiline = True
        Me.txtLegendaryResistance.Name = "txtLegendaryResistance"
        Me.txtLegendaryResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLegendaryResistance.Size = New System.Drawing.Size(986, 42)
        Me.txtLegendaryResistance.TabIndex = 77
        '
        'txtMagicResistance
        '
        Me.txtMagicResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMagicResistance.Location = New System.Drawing.Point(780, 1120)
        Me.txtMagicResistance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMagicResistance.Multiline = True
        Me.txtMagicResistance.Name = "txtMagicResistance"
        Me.txtMagicResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMagicResistance.Size = New System.Drawing.Size(986, 42)
        Me.txtMagicResistance.TabIndex = 78
        '
        'txtOthers
        '
        Me.txtOthers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOthers.Location = New System.Drawing.Point(780, 1175)
        Me.txtOthers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOthers.Multiline = True
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOthers.Size = New System.Drawing.Size(986, 42)
        Me.txtOthers.TabIndex = 79
        '
        'btnActions
        '
        Me.btnActions.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnActions.Location = New System.Drawing.Point(523, 1230)
        Me.btnActions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActions.Name = "btnActions"
        Me.btnActions.Size = New System.Drawing.Size(224, 50)
        Me.btnActions.TabIndex = 80
        Me.btnActions.Text = "actions"
        Me.btnActions.UseVisualStyleBackColor = True
        '
        'btnLegendaryActions
        '
        Me.btnLegendaryActions.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLegendaryActions.Location = New System.Drawing.Point(756, 1230)
        Me.btnLegendaryActions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLegendaryActions.Name = "btnLegendaryActions"
        Me.btnLegendaryActions.Size = New System.Drawing.Size(230, 50)
        Me.btnLegendaryActions.TabIndex = 81
        Me.btnLegendaryActions.Text = "legendary actions"
        Me.btnLegendaryActions.UseVisualStyleBackColor = True
        '
        'lbInformations
        '
        Me.lbInformations.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbInformations.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbInformations.Location = New System.Drawing.Point(271, 287)
        Me.lbInformations.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbInformations.Name = "lbInformations"
        Me.lbInformations.Size = New System.Drawing.Size(243, 45)
        Me.lbInformations.TabIndex = 82
        Me.lbInformations.Text = "Informations"
        Me.lbInformations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEnvironment
        '
        Me.lbEnvironment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbEnvironment.Location = New System.Drawing.Point(271, 160)
        Me.lbEnvironment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEnvironment.Name = "lbEnvironment"
        Me.lbEnvironment.Size = New System.Drawing.Size(243, 45)
        Me.lbEnvironment.TabIndex = 83
        Me.lbEnvironment.Text = "Environment:"
        Me.lbEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEnvironment
        '
        Me.txtEnvironment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEnvironment.Location = New System.Drawing.Point(523, 163)
        Me.txtEnvironment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEnvironment.Name = "txtEnvironment"
        Me.txtEnvironment.Size = New System.Drawing.Size(1243, 37)
        Me.txtEnvironment.TabIndex = 84
        '
        'lbImage
        '
        Me.lbImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbImage.Location = New System.Drawing.Point(271, 220)
        Me.lbImage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbImage.Name = "lbImage"
        Me.lbImage.Size = New System.Drawing.Size(243, 45)
        Me.lbImage.TabIndex = 85
        Me.lbImage.Text = "Image:"
        Me.lbImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImage
        '
        Me.txtImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtImage.Location = New System.Drawing.Point(523, 220)
        Me.txtImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImage.Multiline = True
        Me.txtImage.Name = "txtImage"
        Me.txtImage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImage.Size = New System.Drawing.Size(1243, 42)
        Me.txtImage.TabIndex = 86
        '
        'lbOthers
        '
        Me.lbOthers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbOthers.Location = New System.Drawing.Point(529, 1175)
        Me.lbOthers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbOthers.Name = "lbOthers"
        Me.lbOthers.Size = New System.Drawing.Size(243, 45)
        Me.lbOthers.TabIndex = 60
        Me.lbOthers.Text = "others:"
        Me.lbOthers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox_languages
        '
        Me.ComboBox_languages.FormattingEnabled = True
        Me.ComboBox_languages.Location = New System.Drawing.Point(780, 566)
        Me.ComboBox_languages.Name = "ComboBox_languages"
        Me.ComboBox_languages.Size = New System.Drawing.Size(182, 33)
        Me.ComboBox_languages.TabIndex = 87
        '
        'ucMonster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBox_languages)
        Me.Controls.Add(Me.txtImage)
        Me.Controls.Add(Me.lbImage)
        Me.Controls.Add(Me.txtEnvironment)
        Me.Controls.Add(Me.lbEnvironment)
        Me.Controls.Add(Me.lbInformations)
        Me.Controls.Add(Me.btnLegendaryActions)
        Me.Controls.Add(Me.btnActions)
        Me.Controls.Add(Me.txtOthers)
        Me.Controls.Add(Me.txtMagicResistance)
        Me.Controls.Add(Me.txtLegendaryResistance)
        Me.Controls.Add(Me.txtConditionResistance)
        Me.Controls.Add(Me.txtConditionImmunities)
        Me.Controls.Add(Me.txtDamageVulnerabilities)
        Me.Controls.Add(Me.txtDamageResistance)
        Me.Controls.Add(Me.txtDamageImmunities)
        Me.Controls.Add(Me.txtEffects)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.txtChallenge)
        Me.Controls.Add(Me.txtSenses)
        Me.Controls.Add(Me.txtSkills)
        Me.Controls.Add(Me.txtProficiency)
        Me.Controls.Add(Me.txtSavingThrows)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbOthers)
        Me.Controls.Add(Me.lbMagicResistance)
        Me.Controls.Add(Me.lbLegendaryResistance)
        Me.Controls.Add(Me.lbConditionResistance)
        Me.Controls.Add(Me.lbConditionImmunities)
        Me.Controls.Add(Me.lbDamageVulnerabilities)
        Me.Controls.Add(Me.lbDamageResistance)
        Me.Controls.Add(Me.lbDamageImmunities)
        Me.Controls.Add(Me.lbEffects)
        Me.Controls.Add(Me.lbSpeed)
        Me.Controls.Add(Me.lbChallenge)
        Me.Controls.Add(Me.lbLanguages)
        Me.Controls.Add(Me.lbSenses)
        Me.Controls.Add(Me.lbSkills)
        Me.Controls.Add(Me.lbProficiency)
        Me.Controls.Add(Me.lbSavingThrows)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.lbMaxHp)
        Me.Controls.Add(Me.txtLv9)
        Me.Controls.Add(Me.txtLv8)
        Me.Controls.Add(Me.txtLv7)
        Me.Controls.Add(Me.txtLv6)
        Me.Controls.Add(Me.txtLv5)
        Me.Controls.Add(Me.txtLv4)
        Me.Controls.Add(Me.txtLv3)
        Me.Controls.Add(Me.txtLv2)
        Me.Controls.Add(Me.txtLv1)
        Me.Controls.Add(Me.lbLv9)
        Me.Controls.Add(Me.lbLv8)
        Me.Controls.Add(Me.lbLv7)
        Me.Controls.Add(Me.lbLv6)
        Me.Controls.Add(Me.lbLv5)
        Me.Controls.Add(Me.lbLv4)
        Me.Controls.Add(Me.lbLv3)
        Me.Controls.Add(Me.lbLv2)
        Me.Controls.Add(Me.lbLv1)
        Me.Controls.Add(Me.lbMp)
        Me.Controls.Add(Me.lbModifier)
        Me.Controls.Add(Me.lbNumber)
        Me.Controls.Add(Me.lbDice)
        Me.Controls.Add(Me.txtModifier)
        Me.Controls.Add(Me.txtDice)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtAc)
        Me.Controls.Add(Me.lbAc)
        Me.Controls.Add(Me.lbOpponent)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucMonster"
        Me.Size = New System.Drawing.Size(1771, 1286)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbOpponent As Label
    Friend WithEvents lbAc As Label
    Friend WithEvents txtAc As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtDice As TextBox
    Friend WithEvents txtModifier As TextBox
    Friend WithEvents lbDice As Label
    Friend WithEvents lbNumber As Label
    Friend WithEvents lbModifier As Label
    Friend WithEvents lbMp As Label
    Friend WithEvents lbLv1 As Label
    Friend WithEvents lbLv2 As Label
    Friend WithEvents lbLv3 As Label
    Friend WithEvents lbLv4 As Label
    Friend WithEvents lbLv5 As Label
    Friend WithEvents lbLv6 As Label
    Friend WithEvents lbLv7 As Label
    Friend WithEvents lbLv8 As Label
    Friend WithEvents lbLv9 As Label
    Friend WithEvents txtLv1 As TextBox
    Friend WithEvents txtLv2 As TextBox
    Friend WithEvents txtLv3 As TextBox
    Friend WithEvents txtLv4 As TextBox
    Friend WithEvents txtLv5 As TextBox
    Friend WithEvents txtLv6 As TextBox
    Friend WithEvents txtLv7 As TextBox
    Friend WithEvents txtLv8 As TextBox
    Friend WithEvents txtLv9 As TextBox
    Friend WithEvents lbMaxHp As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbSavingThrows As Label
    Friend WithEvents lbProficiency As Label
    Friend WithEvents lbSkills As Label
    Friend WithEvents lbSenses As Label
    Friend WithEvents lbLanguages As Label
    Friend WithEvents lbChallenge As Label
    Friend WithEvents lbSpeed As Label
    Friend WithEvents lbEffects As Label
    Friend WithEvents lbDamageImmunities As Label
    Friend WithEvents lbDamageResistance As Label
    Friend WithEvents lbDamageVulnerabilities As Label
    Friend WithEvents lbConditionImmunities As Label
    Friend WithEvents lbConditionResistance As Label
    Friend WithEvents lbLegendaryResistance As Label
    Friend WithEvents lbMagicResistance As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSavingThrows As TextBox
    Friend WithEvents txtProficiency As TextBox
    Friend WithEvents txtSkills As TextBox
    Friend WithEvents txtSenses As TextBox
    Friend WithEvents txtChallenge As TextBox
    Friend WithEvents txtSpeed As TextBox
    Friend WithEvents txtEffects As TextBox
    Friend WithEvents txtDamageImmunities As TextBox
    Friend WithEvents txtDamageResistance As TextBox
    Friend WithEvents txtDamageVulnerabilities As TextBox
    Friend WithEvents txtConditionImmunities As TextBox
    Friend WithEvents txtConditionResistance As TextBox
    Friend WithEvents txtLegendaryResistance As TextBox
    Friend WithEvents txtMagicResistance As TextBox
    Friend WithEvents txtOthers As TextBox
    Friend WithEvents btnActions As Button
    Friend WithEvents btnLegendaryActions As Button
    Friend WithEvents lbInformations As Label
    Friend WithEvents lbEnvironment As Label
    Friend WithEvents txtEnvironment As TextBox
    Friend WithEvents lbImage As Label
    Friend WithEvents txtImage As TextBox
    Friend WithEvents lbOthers As Label
    Friend WithEvents ComboBox_languages As ComboBox
End Class
