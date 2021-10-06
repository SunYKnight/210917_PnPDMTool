<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOpponent
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbOpponent = New System.Windows.Forms.Label()
        Me.lbStr = New System.Windows.Forms.Label()
        Me.lbDex = New System.Windows.Forms.Label()
        Me.lbCon = New System.Windows.Forms.Label()
        Me.lbWis = New System.Windows.Forms.Label()
        Me.lbInt = New System.Windows.Forms.Label()
        Me.lbCha = New System.Windows.Forms.Label()
        Me.txtStr = New System.Windows.Forms.TextBox()
        Me.txtDex = New System.Windows.Forms.TextBox()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.txtWis = New System.Windows.Forms.TextBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.txtCha = New System.Windows.Forms.TextBox()
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
        Me.lbOthers = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSavingThrows = New System.Windows.Forms.TextBox()
        Me.txtProficiency = New System.Windows.Forms.TextBox()
        Me.txtSkills = New System.Windows.Forms.TextBox()
        Me.txtSenses = New System.Windows.Forms.TextBox()
        Me.txtLanguages = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'lbOpponent
        '
        Me.lbOpponent.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbOpponent.Location = New System.Drawing.Point(3, 0)
        Me.lbOpponent.Name = "lbOpponent"
        Me.lbOpponent.Size = New System.Drawing.Size(634, 40)
        Me.lbOpponent.TabIndex = 1
        Me.lbOpponent.Text = "Opponent"
        Me.lbOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStr
        '
        Me.lbStr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbStr.Location = New System.Drawing.Point(10, 105)
        Me.lbStr.Name = "lbStr"
        Me.lbStr.Size = New System.Drawing.Size(50, 27)
        Me.lbStr.TabIndex = 2
        Me.lbStr.Text = "STR"
        Me.lbStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDex
        '
        Me.lbDex.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDex.Location = New System.Drawing.Point(10, 132)
        Me.lbDex.Name = "lbDex"
        Me.lbDex.Size = New System.Drawing.Size(50, 27)
        Me.lbDex.TabIndex = 3
        Me.lbDex.Text = "DEX"
        Me.lbDex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCon
        '
        Me.lbCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbCon.Location = New System.Drawing.Point(10, 159)
        Me.lbCon.Name = "lbCon"
        Me.lbCon.Size = New System.Drawing.Size(50, 27)
        Me.lbCon.TabIndex = 4
        Me.lbCon.Text = "CON"
        Me.lbCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbWis
        '
        Me.lbWis.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbWis.Location = New System.Drawing.Point(10, 186)
        Me.lbWis.Name = "lbWis"
        Me.lbWis.Size = New System.Drawing.Size(50, 27)
        Me.lbWis.TabIndex = 5
        Me.lbWis.Text = "WIS"
        Me.lbWis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbInt
        '
        Me.lbInt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbInt.Location = New System.Drawing.Point(10, 213)
        Me.lbInt.Name = "lbInt"
        Me.lbInt.Size = New System.Drawing.Size(50, 27)
        Me.lbInt.TabIndex = 6
        Me.lbInt.Text = "INT"
        Me.lbInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCha
        '
        Me.lbCha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbCha.Location = New System.Drawing.Point(10, 240)
        Me.lbCha.Name = "lbCha"
        Me.lbCha.Size = New System.Drawing.Size(50, 27)
        Me.lbCha.TabIndex = 7
        Me.lbCha.Text = "CHA"
        Me.lbCha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStr
        '
        Me.txtStr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStr.Location = New System.Drawing.Point(86, 105)
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(50, 27)
        Me.txtStr.TabIndex = 8
        '
        'txtDex
        '
        Me.txtDex.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDex.Location = New System.Drawing.Point(86, 132)
        Me.txtDex.Name = "txtDex"
        Me.txtDex.Size = New System.Drawing.Size(50, 27)
        Me.txtDex.TabIndex = 9
        '
        'txtCon
        '
        Me.txtCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCon.Location = New System.Drawing.Point(86, 159)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(50, 27)
        Me.txtCon.TabIndex = 10
        '
        'txtWis
        '
        Me.txtWis.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWis.Location = New System.Drawing.Point(86, 186)
        Me.txtWis.Name = "txtWis"
        Me.txtWis.Size = New System.Drawing.Size(50, 27)
        Me.txtWis.TabIndex = 11
        '
        'txtInt
        '
        Me.txtInt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInt.Location = New System.Drawing.Point(86, 213)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(50, 27)
        Me.txtInt.TabIndex = 12
        '
        'txtCha
        '
        Me.txtCha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCha.Location = New System.Drawing.Point(86, 240)
        Me.txtCha.Name = "txtCha"
        Me.txtCha.Size = New System.Drawing.Size(50, 27)
        Me.txtCha.TabIndex = 13
        '
        'lbAc
        '
        Me.lbAc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbAc.Location = New System.Drawing.Point(10, 273)
        Me.lbAc.Name = "lbAc"
        Me.lbAc.Size = New System.Drawing.Size(50, 27)
        Me.lbAc.TabIndex = 14
        Me.lbAc.Text = "AC"
        Me.lbAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAc
        '
        Me.txtAc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAc.Location = New System.Drawing.Point(86, 273)
        Me.txtAc.Name = "txtAc"
        Me.txtAc.Size = New System.Drawing.Size(50, 27)
        Me.txtAc.TabIndex = 15
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNumber.Location = New System.Drawing.Point(86, 641)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(50, 27)
        Me.txtNumber.TabIndex = 17
        '
        'txtDice
        '
        Me.txtDice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDice.Location = New System.Drawing.Point(86, 672)
        Me.txtDice.Name = "txtDice"
        Me.txtDice.Size = New System.Drawing.Size(50, 27)
        Me.txtDice.TabIndex = 18
        '
        'txtModifier
        '
        Me.txtModifier.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtModifier.Location = New System.Drawing.Point(86, 705)
        Me.txtModifier.Name = "txtModifier"
        Me.txtModifier.Size = New System.Drawing.Size(50, 27)
        Me.txtModifier.TabIndex = 19
        '
        'lbDice
        '
        Me.lbDice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDice.Location = New System.Drawing.Point(10, 675)
        Me.lbDice.Name = "lbDice"
        Me.lbDice.Size = New System.Drawing.Size(50, 27)
        Me.lbDice.TabIndex = 20
        Me.lbDice.Text = "Dice"
        Me.lbDice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbNumber
        '
        Me.lbNumber.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbNumber.Location = New System.Drawing.Point(10, 641)
        Me.lbNumber.Name = "lbNumber"
        Me.lbNumber.Size = New System.Drawing.Size(70, 27)
        Me.lbNumber.TabIndex = 21
        Me.lbNumber.Text = "Number"
        Me.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbModifier
        '
        Me.lbModifier.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbModifier.Location = New System.Drawing.Point(10, 706)
        Me.lbModifier.Name = "lbModifier"
        Me.lbModifier.Size = New System.Drawing.Size(70, 27)
        Me.lbModifier.TabIndex = 22
        Me.lbModifier.Text = "Modifier"
        Me.lbModifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMp
        '
        Me.lbMp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbMp.Location = New System.Drawing.Point(10, 323)
        Me.lbMp.Name = "lbMp"
        Me.lbMp.Size = New System.Drawing.Size(106, 27)
        Me.lbMp.TabIndex = 23
        Me.lbMp.Text = "MP"
        Me.lbMp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbLv1
        '
        Me.lbLv1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv1.Location = New System.Drawing.Point(10, 350)
        Me.lbLv1.Name = "lbLv1"
        Me.lbLv1.Size = New System.Drawing.Size(50, 27)
        Me.lbLv1.TabIndex = 24
        Me.lbLv1.Text = "LV1"
        Me.lbLv1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv2
        '
        Me.lbLv2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv2.Location = New System.Drawing.Point(10, 377)
        Me.lbLv2.Name = "lbLv2"
        Me.lbLv2.Size = New System.Drawing.Size(50, 27)
        Me.lbLv2.TabIndex = 25
        Me.lbLv2.Text = "LV2"
        Me.lbLv2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv3
        '
        Me.lbLv3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv3.Location = New System.Drawing.Point(10, 404)
        Me.lbLv3.Name = "lbLv3"
        Me.lbLv3.Size = New System.Drawing.Size(50, 27)
        Me.lbLv3.TabIndex = 26
        Me.lbLv3.Text = "LV3"
        Me.lbLv3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv4
        '
        Me.lbLv4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv4.Location = New System.Drawing.Point(10, 431)
        Me.lbLv4.Name = "lbLv4"
        Me.lbLv4.Size = New System.Drawing.Size(50, 27)
        Me.lbLv4.TabIndex = 27
        Me.lbLv4.Text = "LV4"
        Me.lbLv4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv5
        '
        Me.lbLv5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv5.Location = New System.Drawing.Point(10, 458)
        Me.lbLv5.Name = "lbLv5"
        Me.lbLv5.Size = New System.Drawing.Size(50, 27)
        Me.lbLv5.TabIndex = 28
        Me.lbLv5.Text = "LV5"
        Me.lbLv5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv6
        '
        Me.lbLv6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv6.Location = New System.Drawing.Point(10, 485)
        Me.lbLv6.Name = "lbLv6"
        Me.lbLv6.Size = New System.Drawing.Size(50, 27)
        Me.lbLv6.TabIndex = 29
        Me.lbLv6.Text = "LV6"
        Me.lbLv6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv7
        '
        Me.lbLv7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv7.Location = New System.Drawing.Point(10, 512)
        Me.lbLv7.Name = "lbLv7"
        Me.lbLv7.Size = New System.Drawing.Size(50, 27)
        Me.lbLv7.TabIndex = 30
        Me.lbLv7.Text = "LV7"
        Me.lbLv7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv8
        '
        Me.lbLv8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv8.Location = New System.Drawing.Point(10, 539)
        Me.lbLv8.Name = "lbLv8"
        Me.lbLv8.Size = New System.Drawing.Size(50, 27)
        Me.lbLv8.TabIndex = 31
        Me.lbLv8.Text = "LV8"
        Me.lbLv8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLv9
        '
        Me.lbLv9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLv9.Location = New System.Drawing.Point(10, 566)
        Me.lbLv9.Name = "lbLv9"
        Me.lbLv9.Size = New System.Drawing.Size(50, 27)
        Me.lbLv9.TabIndex = 32
        Me.lbLv9.Text = "LV9"
        Me.lbLv9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLv1
        '
        Me.txtLv1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv1.Location = New System.Drawing.Point(86, 353)
        Me.txtLv1.Name = "txtLv1"
        Me.txtLv1.Size = New System.Drawing.Size(50, 27)
        Me.txtLv1.TabIndex = 33
        '
        'txtLv2
        '
        Me.txtLv2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv2.Location = New System.Drawing.Point(86, 380)
        Me.txtLv2.Name = "txtLv2"
        Me.txtLv2.Size = New System.Drawing.Size(50, 27)
        Me.txtLv2.TabIndex = 34
        '
        'txtLv3
        '
        Me.txtLv3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv3.Location = New System.Drawing.Point(86, 407)
        Me.txtLv3.Name = "txtLv3"
        Me.txtLv3.Size = New System.Drawing.Size(50, 27)
        Me.txtLv3.TabIndex = 35
        '
        'txtLv4
        '
        Me.txtLv4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv4.Location = New System.Drawing.Point(86, 434)
        Me.txtLv4.Name = "txtLv4"
        Me.txtLv4.Size = New System.Drawing.Size(50, 27)
        Me.txtLv4.TabIndex = 36
        '
        'txtLv5
        '
        Me.txtLv5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv5.Location = New System.Drawing.Point(86, 461)
        Me.txtLv5.Name = "txtLv5"
        Me.txtLv5.Size = New System.Drawing.Size(50, 27)
        Me.txtLv5.TabIndex = 37
        '
        'txtLv6
        '
        Me.txtLv6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv6.Location = New System.Drawing.Point(86, 488)
        Me.txtLv6.Name = "txtLv6"
        Me.txtLv6.Size = New System.Drawing.Size(50, 27)
        Me.txtLv6.TabIndex = 38
        '
        'txtLv7
        '
        Me.txtLv7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv7.Location = New System.Drawing.Point(86, 515)
        Me.txtLv7.Name = "txtLv7"
        Me.txtLv7.Size = New System.Drawing.Size(50, 27)
        Me.txtLv7.TabIndex = 39
        '
        'txtLv8
        '
        Me.txtLv8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv8.Location = New System.Drawing.Point(86, 542)
        Me.txtLv8.Name = "txtLv8"
        Me.txtLv8.Size = New System.Drawing.Size(50, 27)
        Me.txtLv8.TabIndex = 40
        '
        'txtLv9
        '
        Me.txtLv9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLv9.Location = New System.Drawing.Point(86, 569)
        Me.txtLv9.Name = "txtLv9"
        Me.txtLv9.Size = New System.Drawing.Size(50, 27)
        Me.txtLv9.TabIndex = 41
        '
        'lbMaxHp
        '
        Me.lbMaxHp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbMaxHp.Location = New System.Drawing.Point(10, 611)
        Me.lbMaxHp.Name = "lbMaxHp"
        Me.lbMaxHp.Size = New System.Drawing.Size(106, 27)
        Me.lbMaxHp.TabIndex = 43
        Me.lbMaxHp.Text = "max. HP"
        Me.lbMaxHp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbName.Location = New System.Drawing.Point(190, 65)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(170, 27)
        Me.lbName.TabIndex = 44
        Me.lbName.Text = "Name:"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSavingThrows
        '
        Me.lbSavingThrows.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSavingThrows.Location = New System.Drawing.Point(190, 204)
        Me.lbSavingThrows.Name = "lbSavingThrows"
        Me.lbSavingThrows.Size = New System.Drawing.Size(170, 27)
        Me.lbSavingThrows.TabIndex = 45
        Me.lbSavingThrows.Text = "Saving Throws:"
        Me.lbSavingThrows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbProficiency
        '
        Me.lbProficiency.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbProficiency.Location = New System.Drawing.Point(190, 237)
        Me.lbProficiency.Name = "lbProficiency"
        Me.lbProficiency.Size = New System.Drawing.Size(170, 27)
        Me.lbProficiency.TabIndex = 46
        Me.lbProficiency.Text = "Proficiency:"
        Me.lbProficiency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSkills
        '
        Me.lbSkills.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSkills.Location = New System.Drawing.Point(190, 270)
        Me.lbSkills.Name = "lbSkills"
        Me.lbSkills.Size = New System.Drawing.Size(170, 27)
        Me.lbSkills.TabIndex = 47
        Me.lbSkills.Text = "Skills:"
        Me.lbSkills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSenses
        '
        Me.lbSenses.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSenses.Location = New System.Drawing.Point(190, 303)
        Me.lbSenses.Name = "lbSenses"
        Me.lbSenses.Size = New System.Drawing.Size(170, 27)
        Me.lbSenses.TabIndex = 48
        Me.lbSenses.Text = "Senses:"
        Me.lbSenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLanguages
        '
        Me.lbLanguages.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLanguages.Location = New System.Drawing.Point(190, 336)
        Me.lbLanguages.Name = "lbLanguages"
        Me.lbLanguages.Size = New System.Drawing.Size(170, 27)
        Me.lbLanguages.TabIndex = 49
        Me.lbLanguages.Text = "Languages:"
        Me.lbLanguages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbChallenge
        '
        Me.lbChallenge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbChallenge.Location = New System.Drawing.Point(190, 369)
        Me.lbChallenge.Name = "lbChallenge"
        Me.lbChallenge.Size = New System.Drawing.Size(170, 27)
        Me.lbChallenge.TabIndex = 50
        Me.lbChallenge.Text = "Challenge:"
        Me.lbChallenge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSpeed
        '
        Me.lbSpeed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSpeed.Location = New System.Drawing.Point(190, 402)
        Me.lbSpeed.Name = "lbSpeed"
        Me.lbSpeed.Size = New System.Drawing.Size(170, 27)
        Me.lbSpeed.TabIndex = 51
        Me.lbSpeed.Text = "Speed:"
        Me.lbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEffects
        '
        Me.lbEffects.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbEffects.Location = New System.Drawing.Point(190, 435)
        Me.lbEffects.Name = "lbEffects"
        Me.lbEffects.Size = New System.Drawing.Size(170, 27)
        Me.lbEffects.TabIndex = 52
        Me.lbEffects.Text = "Effects:"
        Me.lbEffects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDamageImmunities
        '
        Me.lbDamageImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDamageImmunities.Location = New System.Drawing.Point(190, 472)
        Me.lbDamageImmunities.Name = "lbDamageImmunities"
        Me.lbDamageImmunities.Size = New System.Drawing.Size(170, 27)
        Me.lbDamageImmunities.TabIndex = 53
        Me.lbDamageImmunities.Text = "Damage Immunities:"
        Me.lbDamageImmunities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDamageResistance
        '
        Me.lbDamageResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDamageResistance.Location = New System.Drawing.Point(190, 505)
        Me.lbDamageResistance.Name = "lbDamageResistance"
        Me.lbDamageResistance.Size = New System.Drawing.Size(170, 27)
        Me.lbDamageResistance.TabIndex = 54
        Me.lbDamageResistance.Text = "Damage Resistance:"
        Me.lbDamageResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDamageVulnerabilities
        '
        Me.lbDamageVulnerabilities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDamageVulnerabilities.Location = New System.Drawing.Point(190, 538)
        Me.lbDamageVulnerabilities.Name = "lbDamageVulnerabilities"
        Me.lbDamageVulnerabilities.Size = New System.Drawing.Size(170, 27)
        Me.lbDamageVulnerabilities.TabIndex = 55
        Me.lbDamageVulnerabilities.Text = "Damage Vulnerabilities:"
        Me.lbDamageVulnerabilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConditionImmunities
        '
        Me.lbConditionImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbConditionImmunities.Location = New System.Drawing.Point(190, 571)
        Me.lbConditionImmunities.Name = "lbConditionImmunities"
        Me.lbConditionImmunities.Size = New System.Drawing.Size(170, 27)
        Me.lbConditionImmunities.TabIndex = 56
        Me.lbConditionImmunities.Text = "Condition Immunities:"
        Me.lbConditionImmunities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbConditionResistance
        '
        Me.lbConditionResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbConditionResistance.Location = New System.Drawing.Point(190, 604)
        Me.lbConditionResistance.Name = "lbConditionResistance"
        Me.lbConditionResistance.Size = New System.Drawing.Size(170, 27)
        Me.lbConditionResistance.TabIndex = 57
        Me.lbConditionResistance.Text = "Condition Resistance:"
        Me.lbConditionResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLegendaryResistance
        '
        Me.lbLegendaryResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLegendaryResistance.Location = New System.Drawing.Point(190, 639)
        Me.lbLegendaryResistance.Name = "lbLegendaryResistance"
        Me.lbLegendaryResistance.Size = New System.Drawing.Size(170, 27)
        Me.lbLegendaryResistance.TabIndex = 58
        Me.lbLegendaryResistance.Text = "Legendary Resistance:"
        Me.lbLegendaryResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMagicResistance
        '
        Me.lbMagicResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbMagicResistance.Location = New System.Drawing.Point(190, 672)
        Me.lbMagicResistance.Name = "lbMagicResistance"
        Me.lbMagicResistance.Size = New System.Drawing.Size(170, 27)
        Me.lbMagicResistance.TabIndex = 59
        Me.lbMagicResistance.Text = "Magic Resistance:"
        Me.lbMagicResistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbOthers
        '
        Me.lbOthers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbOthers.Location = New System.Drawing.Point(190, 705)
        Me.lbOthers.Name = "lbOthers"
        Me.lbOthers.Size = New System.Drawing.Size(170, 27)
        Me.lbOthers.TabIndex = 60
        Me.lbOthers.Text = "others:"
        Me.lbOthers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(1162, 738)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDiscard
        '
        Me.btnDiscard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDiscard.Location = New System.Drawing.Point(1081, 738)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(75, 30)
        Me.btnDiscard.TabIndex = 62
        Me.btnDiscard.Text = "discard"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(366, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(871, 27)
        Me.txtName.TabIndex = 63
        '
        'txtSavingThrows
        '
        Me.txtSavingThrows.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSavingThrows.Location = New System.Drawing.Point(366, 204)
        Me.txtSavingThrows.Multiline = True
        Me.txtSavingThrows.Name = "txtSavingThrows"
        Me.txtSavingThrows.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSavingThrows.Size = New System.Drawing.Size(871, 27)
        Me.txtSavingThrows.TabIndex = 64
        '
        'txtProficiency
        '
        Me.txtProficiency.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtProficiency.Location = New System.Drawing.Point(366, 237)
        Me.txtProficiency.Multiline = True
        Me.txtProficiency.Name = "txtProficiency"
        Me.txtProficiency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProficiency.Size = New System.Drawing.Size(871, 27)
        Me.txtProficiency.TabIndex = 65
        '
        'txtSkills
        '
        Me.txtSkills.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSkills.Location = New System.Drawing.Point(366, 270)
        Me.txtSkills.Multiline = True
        Me.txtSkills.Name = "txtSkills"
        Me.txtSkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSkills.Size = New System.Drawing.Size(871, 27)
        Me.txtSkills.TabIndex = 66
        '
        'txtSenses
        '
        Me.txtSenses.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSenses.Location = New System.Drawing.Point(366, 303)
        Me.txtSenses.Multiline = True
        Me.txtSenses.Name = "txtSenses"
        Me.txtSenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSenses.Size = New System.Drawing.Size(871, 27)
        Me.txtSenses.TabIndex = 67
        '
        'txtLanguages
        '
        Me.txtLanguages.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLanguages.Location = New System.Drawing.Point(366, 336)
        Me.txtLanguages.Multiline = True
        Me.txtLanguages.Name = "txtLanguages"
        Me.txtLanguages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLanguages.Size = New System.Drawing.Size(871, 27)
        Me.txtLanguages.TabIndex = 68
        '
        'txtChallenge
        '
        Me.txtChallenge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtChallenge.Location = New System.Drawing.Point(366, 369)
        Me.txtChallenge.Multiline = True
        Me.txtChallenge.Name = "txtChallenge"
        Me.txtChallenge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChallenge.Size = New System.Drawing.Size(871, 27)
        Me.txtChallenge.TabIndex = 69
        '
        'txtSpeed
        '
        Me.txtSpeed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSpeed.Location = New System.Drawing.Point(366, 402)
        Me.txtSpeed.Multiline = True
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSpeed.Size = New System.Drawing.Size(871, 27)
        Me.txtSpeed.TabIndex = 70
        '
        'txtEffects
        '
        Me.txtEffects.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEffects.Location = New System.Drawing.Point(366, 435)
        Me.txtEffects.Multiline = True
        Me.txtEffects.Name = "txtEffects"
        Me.txtEffects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEffects.Size = New System.Drawing.Size(871, 27)
        Me.txtEffects.TabIndex = 71
        '
        'txtDamageImmunities
        '
        Me.txtDamageImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDamageImmunities.Location = New System.Drawing.Point(366, 472)
        Me.txtDamageImmunities.Multiline = True
        Me.txtDamageImmunities.Name = "txtDamageImmunities"
        Me.txtDamageImmunities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDamageImmunities.Size = New System.Drawing.Size(871, 27)
        Me.txtDamageImmunities.TabIndex = 72
        '
        'txtDamageResistance
        '
        Me.txtDamageResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDamageResistance.Location = New System.Drawing.Point(366, 505)
        Me.txtDamageResistance.Multiline = True
        Me.txtDamageResistance.Name = "txtDamageResistance"
        Me.txtDamageResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDamageResistance.Size = New System.Drawing.Size(871, 27)
        Me.txtDamageResistance.TabIndex = 73
        '
        'txtDamageVulnerabilities
        '
        Me.txtDamageVulnerabilities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDamageVulnerabilities.Location = New System.Drawing.Point(366, 538)
        Me.txtDamageVulnerabilities.Multiline = True
        Me.txtDamageVulnerabilities.Name = "txtDamageVulnerabilities"
        Me.txtDamageVulnerabilities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDamageVulnerabilities.Size = New System.Drawing.Size(871, 27)
        Me.txtDamageVulnerabilities.TabIndex = 74
        '
        'txtConditionImmunities
        '
        Me.txtConditionImmunities.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConditionImmunities.Location = New System.Drawing.Point(366, 571)
        Me.txtConditionImmunities.Multiline = True
        Me.txtConditionImmunities.Name = "txtConditionImmunities"
        Me.txtConditionImmunities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConditionImmunities.Size = New System.Drawing.Size(871, 27)
        Me.txtConditionImmunities.TabIndex = 75
        '
        'txtConditionResistance
        '
        Me.txtConditionResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtConditionResistance.Location = New System.Drawing.Point(366, 604)
        Me.txtConditionResistance.Multiline = True
        Me.txtConditionResistance.Name = "txtConditionResistance"
        Me.txtConditionResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConditionResistance.Size = New System.Drawing.Size(871, 27)
        Me.txtConditionResistance.TabIndex = 76
        '
        'txtLegendaryResistance
        '
        Me.txtLegendaryResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLegendaryResistance.Location = New System.Drawing.Point(366, 639)
        Me.txtLegendaryResistance.Multiline = True
        Me.txtLegendaryResistance.Name = "txtLegendaryResistance"
        Me.txtLegendaryResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLegendaryResistance.Size = New System.Drawing.Size(871, 27)
        Me.txtLegendaryResistance.TabIndex = 77
        '
        'txtMagicResistance
        '
        Me.txtMagicResistance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMagicResistance.Location = New System.Drawing.Point(366, 672)
        Me.txtMagicResistance.Multiline = True
        Me.txtMagicResistance.Name = "txtMagicResistance"
        Me.txtMagicResistance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMagicResistance.Size = New System.Drawing.Size(871, 27)
        Me.txtMagicResistance.TabIndex = 78
        '
        'txtOthers
        '
        Me.txtOthers.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOthers.Location = New System.Drawing.Point(366, 705)
        Me.txtOthers.Multiline = True
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOthers.Size = New System.Drawing.Size(871, 27)
        Me.txtOthers.TabIndex = 79
        '
        'btnActions
        '
        Me.btnActions.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnActions.Location = New System.Drawing.Point(366, 738)
        Me.btnActions.Name = "btnActions"
        Me.btnActions.Size = New System.Drawing.Size(157, 30)
        Me.btnActions.TabIndex = 80
        Me.btnActions.Text = "actions"
        Me.btnActions.UseVisualStyleBackColor = True
        '
        'btnLegendaryActions
        '
        Me.btnLegendaryActions.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLegendaryActions.Location = New System.Drawing.Point(529, 738)
        Me.btnLegendaryActions.Name = "btnLegendaryActions"
        Me.btnLegendaryActions.Size = New System.Drawing.Size(161, 30)
        Me.btnLegendaryActions.TabIndex = 81
        Me.btnLegendaryActions.Text = "legendary actions"
        Me.btnLegendaryActions.UseVisualStyleBackColor = True
        '
        'lbInformations
        '
        Me.lbInformations.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbInformations.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbInformations.Location = New System.Drawing.Point(190, 172)
        Me.lbInformations.Name = "lbInformations"
        Me.lbInformations.Size = New System.Drawing.Size(170, 27)
        Me.lbInformations.TabIndex = 82
        Me.lbInformations.Text = "Informations"
        Me.lbInformations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbEnvironment
        '
        Me.lbEnvironment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbEnvironment.Location = New System.Drawing.Point(190, 96)
        Me.lbEnvironment.Name = "lbEnvironment"
        Me.lbEnvironment.Size = New System.Drawing.Size(170, 27)
        Me.lbEnvironment.TabIndex = 83
        Me.lbEnvironment.Text = "Environment:"
        Me.lbEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEnvironment
        '
        Me.txtEnvironment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtEnvironment.Location = New System.Drawing.Point(366, 98)
        Me.txtEnvironment.Name = "txtEnvironment"
        Me.txtEnvironment.Size = New System.Drawing.Size(871, 27)
        Me.txtEnvironment.TabIndex = 84
        '
        'lbImage
        '
        Me.lbImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbImage.Location = New System.Drawing.Point(190, 132)
        Me.lbImage.Name = "lbImage"
        Me.lbImage.Size = New System.Drawing.Size(170, 27)
        Me.lbImage.TabIndex = 85
        Me.lbImage.Text = "Image:"
        Me.lbImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImage
        '
        Me.txtImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtImage.Location = New System.Drawing.Point(366, 132)
        Me.txtImage.Multiline = True
        Me.txtImage.Name = "txtImage"
        Me.txtImage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImage.Size = New System.Drawing.Size(871, 27)
        Me.txtImage.TabIndex = 86
        '
        'ucOpponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.txtLanguages)
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
        Me.Controls.Add(Me.txtCha)
        Me.Controls.Add(Me.txtInt)
        Me.Controls.Add(Me.txtWis)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.txtDex)
        Me.Controls.Add(Me.txtStr)
        Me.Controls.Add(Me.lbCha)
        Me.Controls.Add(Me.lbInt)
        Me.Controls.Add(Me.lbWis)
        Me.Controls.Add(Me.lbCon)
        Me.Controls.Add(Me.lbDex)
        Me.Controls.Add(Me.lbStr)
        Me.Controls.Add(Me.lbOpponent)
        Me.Name = "ucOpponent"
        Me.Size = New System.Drawing.Size(1240, 787)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbOpponent As Label
    Friend WithEvents lbStr As Label
    Friend WithEvents lbDex As Label
    Friend WithEvents lbCon As Label
    Friend WithEvents lbWis As Label
    Friend WithEvents lbInt As Label
    Friend WithEvents lbCha As Label
    Friend WithEvents txtStr As TextBox
    Friend WithEvents txtDex As TextBox
    Friend WithEvents txtCon As TextBox
    Friend WithEvents txtWis As TextBox
    Friend WithEvents txtInt As TextBox
    Friend WithEvents txtCha As TextBox
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
    Friend WithEvents lbOthers As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSavingThrows As TextBox
    Friend WithEvents txtProficiency As TextBox
    Friend WithEvents txtSkills As TextBox
    Friend WithEvents txtSenses As TextBox
    Friend WithEvents txtLanguages As TextBox
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
End Class
