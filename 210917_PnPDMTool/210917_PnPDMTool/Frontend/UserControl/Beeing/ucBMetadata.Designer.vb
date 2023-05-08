<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBMetadata
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
        Label1 = New Label()
        TextBox_name = New TextBox()
        Label2 = New Label()
        ComboBox_Size = New ComboBox()
        ComboBox_aligment_behaviour = New ComboBox()
        Label3 = New Label()
        PictureBox_image = New PictureBox()
        ComboBox_monsterClass = New ComboBox()
        Label19 = New Label()
        NumericUpDown_Proficency = New NumericUpDown()
        Label50 = New Label()
        NumericUpDown_challenge = New NumericUpDown()
        Label51 = New Label()
        ComboBox_spellcast_attribute = New ComboBox()
        Label4 = New Label()
        CType(PictureBox_image, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_Proficency, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_challenge, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 3
        Label1.Text = "Name:"
        ' 
        ' TextBox_name
        ' 
        TextBox_name.Location = New Point(99, 37)
        TextBox_name.Name = "TextBox_name"
        TextBox_name.Size = New Size(513, 31)
        TextBox_name.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(415, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 25)
        Label2.TabIndex = 5
        Label2.Text = "Size:"
        ' 
        ' ComboBox_Size
        ' 
        ComboBox_Size.FormattingEnabled = True
        ComboBox_Size.Location = New Point(415, 251)
        ComboBox_Size.Name = "ComboBox_Size"
        ComboBox_Size.Size = New Size(175, 33)
        ComboBox_Size.TabIndex = 6
        ' 
        ' ComboBox_aligment_behaviour
        ' 
        ComboBox_aligment_behaviour.FormattingEnabled = True
        ComboBox_aligment_behaviour.Location = New Point(414, 187)
        ComboBox_aligment_behaviour.Name = "ComboBox_aligment_behaviour"
        ComboBox_aligment_behaviour.Size = New Size(176, 33)
        ComboBox_aligment_behaviour.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(410, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 25)
        Label3.TabIndex = 7
        Label3.Text = "Aligment:"
        ' 
        ' PictureBox_image
        ' 
        PictureBox_image.BackgroundImageLayout = ImageLayout.None
        PictureBox_image.BorderStyle = BorderStyle.Fixed3D
        PictureBox_image.Location = New Point(99, 92)
        PictureBox_image.Name = "PictureBox_image"
        PictureBox_image.Size = New Size(277, 339)
        PictureBox_image.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox_image.TabIndex = 11
        PictureBox_image.TabStop = False
        ' 
        ' ComboBox_monsterClass
        ' 
        ComboBox_monsterClass.FormattingEnabled = True
        ComboBox_monsterClass.Location = New Point(414, 123)
        ComboBox_monsterClass.Name = "ComboBox_monsterClass"
        ComboBox_monsterClass.Size = New Size(175, 33)
        ComboBox_monsterClass.TabIndex = 50
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(414, 95)
        Label19.Name = "Label19"
        Label19.Size = New Size(127, 25)
        Label19.TabIndex = 49
        Label19.Text = "Monster Class:"
        ' 
        ' NumericUpDown_Proficency
        ' 
        NumericUpDown_Proficency.Location = New Point(415, 328)
        NumericUpDown_Proficency.Maximum = New [Decimal](New Integer() {20, 0, 0, 0})
        NumericUpDown_Proficency.Minimum = New [Decimal](New Integer() {10, 0, 0, Integer.MinValue})
        NumericUpDown_Proficency.Name = "NumericUpDown_Proficency"
        NumericUpDown_Proficency.Size = New Size(65, 31)
        NumericUpDown_Proficency.TabIndex = 112
        ' 
        ' Label50
        ' 
        Label50.AccessibleRole = AccessibleRole.IpAddress
        Label50.AutoSize = True
        Label50.Location = New Point(411, 300)
        Label50.Name = "Label50"
        Label50.Size = New Size(97, 25)
        Label50.TabIndex = 111
        Label50.Text = "Proficency:"
        ' 
        ' NumericUpDown_challenge
        ' 
        NumericUpDown_challenge.DecimalPlaces = 2
        NumericUpDown_challenge.Location = New Point(503, 328)
        NumericUpDown_challenge.Maximum = New [Decimal](New Integer() {30, 0, 0, 0})
        NumericUpDown_challenge.Name = "NumericUpDown_challenge"
        NumericUpDown_challenge.Size = New Size(83, 31)
        NumericUpDown_challenge.TabIndex = 114
        ' 
        ' Label51
        ' 
        Label51.AccessibleRole = AccessibleRole.IpAddress
        Label51.AutoSize = True
        Label51.Location = New Point(497, 300)
        Label51.Name = "Label51"
        Label51.Size = New Size(93, 25)
        Label51.TabIndex = 113
        Label51.Text = "Challange:"
        ' 
        ' ComboBox_spellcast_attribute
        ' 
        ComboBox_spellcast_attribute.FormattingEnabled = True
        ComboBox_spellcast_attribute.Location = New Point(411, 390)
        ComboBox_spellcast_attribute.Name = "ComboBox_spellcast_attribute"
        ComboBox_spellcast_attribute.Size = New Size(175, 33)
        ComboBox_spellcast_attribute.TabIndex = 115
        ' 
        ' Label4
        ' 
        Label4.AccessibleRole = AccessibleRole.IpAddress
        Label4.AutoSize = True
        Label4.Location = New Point(415, 362)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 25)
        Label4.TabIndex = 116
        Label4.Text = "Spellcast Attribute:"
        ' 
        ' ucBMetadata
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(Label4)
        Controls.Add(ComboBox_spellcast_attribute)
        Controls.Add(NumericUpDown_challenge)
        Controls.Add(Label51)
        Controls.Add(NumericUpDown_Proficency)
        Controls.Add(Label50)
        Controls.Add(ComboBox_monsterClass)
        Controls.Add(Label19)
        Controls.Add(PictureBox_image)
        Controls.Add(ComboBox_aligment_behaviour)
        Controls.Add(Label3)
        Controls.Add(ComboBox_Size)
        Controls.Add(Label2)
        Controls.Add(TextBox_name)
        Controls.Add(Label1)
        Name = "ucBMetadata"
        Size = New Size(1420, 876)
        CType(PictureBox_image, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_Proficency, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_challenge, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_Size As ComboBox
    Friend WithEvents ComboBox_aligment_behaviour As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox_image As PictureBox
    Friend WithEvents ComboBox_monsterClass As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents NumericUpDown_Proficency As NumericUpDown
    Friend WithEvents Label50 As Label
    Friend WithEvents NumericUpDown_challenge As NumericUpDown
    Friend WithEvents Label51 As Label
    Friend WithEvents ComboBox_spellcast_attribute As ComboBox
    Friend WithEvents Label4 As Label
End Class
