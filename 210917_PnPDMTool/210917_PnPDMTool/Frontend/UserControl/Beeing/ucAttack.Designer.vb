<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucAttack
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox_Description = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AttackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_DmgType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown_range = New System.Windows.Forms.NumericUpDown()
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
        Me.NumericUpDown_dmgDiceD100 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.AttackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_range, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_hitBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_dmgDiceD100, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox_Description
        '
        Me.RichTextBox_Description.Location = New System.Drawing.Point(112, 0)
        Me.RichTextBox_Description.Name = "RichTextBox_Description"
        Me.RichTextBox_Description.Size = New System.Drawing.Size(420, 100)
        Me.RichTextBox_Description.TabIndex = 0
        Me.RichTextBox_Description.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description:"
        '
        'AttackBindingSource
        '
        Me.AttackBindingSource.DataSource = GetType(_210917_PnPDMTool.Attack)
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dmg Type:"
        '
        'ComboBox_DmgType
        '
        Me.ComboBox_DmgType.FormattingEnabled = True
        Me.ComboBox_DmgType.Location = New System.Drawing.Point(112, 115)
        Me.ComboBox_DmgType.Name = "ComboBox_DmgType"
        Me.ComboBox_DmgType.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_DmgType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Range [ft]:"
        '
        'NumericUpDown_range
        '
        Me.NumericUpDown_range.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown_range.Location = New System.Drawing.Point(424, 115)
        Me.NumericUpDown_range.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown_range.Name = "NumericUpDown_range"
        Me.NumericUpDown_range.Size = New System.Drawing.Size(108, 31)
        Me.NumericUpDown_range.TabIndex = 5
        '
        'NumericUpDown_hitBonus
        '
        Me.NumericUpDown_hitBonus.Location = New System.Drawing.Point(112, 154)
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
        Me.Label4.Location = New System.Drawing.Point(3, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hit Bonus:"
        '
        'NumericUpDown_dmgBonus
        '
        Me.NumericUpDown_dmgBonus.Location = New System.Drawing.Point(308, 154)
        Me.NumericUpDown_dmgBonus.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown_dmgBonus.Name = "NumericUpDown_dmgBonus"
        Me.NumericUpDown_dmgBonus.Size = New System.Drawing.Size(62, 31)
        Me.NumericUpDown_dmgBonus.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dmg Bonus:"
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-3, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dmg Dice:"
        '
        'NumericUpDown_dmgDiceD4
        '
        Me.NumericUpDown_dmgDiceD4.Location = New System.Drawing.Point(112, 219)
        Me.NumericUpDown_dmgDiceD4.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD4.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD4.Name = "NumericUpDown_dmgDiceD4"
        Me.NumericUpDown_dmgDiceD4.Size = New System.Drawing.Size(65, 31)
        Me.NumericUpDown_dmgDiceD4.TabIndex = 11
        '
        'NumericUpDown_dmgDiceD6
        '
        Me.NumericUpDown_dmgDiceD6.Location = New System.Drawing.Point(183, 219)
        Me.NumericUpDown_dmgDiceD6.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD6.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD6.Name = "NumericUpDown_dmgDiceD6"
        Me.NumericUpDown_dmgDiceD6.Size = New System.Drawing.Size(65, 31)
        Me.NumericUpDown_dmgDiceD6.TabIndex = 12
        '
        'NumericUpDown_dmgDiceD8
        '
        Me.NumericUpDown_dmgDiceD8.Location = New System.Drawing.Point(254, 219)
        Me.NumericUpDown_dmgDiceD8.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD8.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD8.Name = "NumericUpDown_dmgDiceD8"
        Me.NumericUpDown_dmgDiceD8.Size = New System.Drawing.Size(65, 31)
        Me.NumericUpDown_dmgDiceD8.TabIndex = 13
        '
        'NumericUpDown_dmgDiceD12
        '
        Me.NumericUpDown_dmgDiceD12.Location = New System.Drawing.Point(325, 219)
        Me.NumericUpDown_dmgDiceD12.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD12.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD12.Name = "NumericUpDown_dmgDiceD12"
        Me.NumericUpDown_dmgDiceD12.Size = New System.Drawing.Size(65, 31)
        Me.NumericUpDown_dmgDiceD12.TabIndex = 14
        '
        'NumericUpDown_dmgDiceD20
        '
        Me.NumericUpDown_dmgDiceD20.Location = New System.Drawing.Point(396, 219)
        Me.NumericUpDown_dmgDiceD20.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD20.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD20.Name = "NumericUpDown_dmgDiceD20"
        Me.NumericUpDown_dmgDiceD20.Size = New System.Drawing.Size(65, 31)
        Me.NumericUpDown_dmgDiceD20.TabIndex = 15
        '
        'NumericUpDown_dmgDiceD100
        '
        Me.NumericUpDown_dmgDiceD100.Location = New System.Drawing.Point(467, 219)
        Me.NumericUpDown_dmgDiceD100.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown_dmgDiceD100.Minimum = New Decimal(New Integer() {30, 0, 0, -2147483648})
        Me.NumericUpDown_dmgDiceD100.Name = "NumericUpDown_dmgDiceD100"
        Me.NumericUpDown_dmgDiceD100.Size = New System.Drawing.Size(65, 31)
        Me.NumericUpDown_dmgDiceD100.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "D4"
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(183, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "D6"
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(254, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 25)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "D8"
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(325, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 25)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "D12"
        '
        'Label11
        '
        Me.Label11.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(396, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "D20"
        '
        'Label12
        '
        Me.Label12.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(467, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 25)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "D100"
        '
        'ucAttack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD100)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD20)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD12)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD8)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD6)
        Me.Controls.Add(Me.NumericUpDown_dmgDiceD4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown_dmgBonus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown_hitBonus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown_range)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox_DmgType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox_Description)
        Me.Name = "ucAttack"
        Me.Size = New System.Drawing.Size(538, 257)
        CType(Me.AttackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_range, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_hitBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_dmgDiceD100, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox_Description As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AttackBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_DmgType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown_range As NumericUpDown
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
    Friend WithEvents NumericUpDown_dmgDiceD100 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
