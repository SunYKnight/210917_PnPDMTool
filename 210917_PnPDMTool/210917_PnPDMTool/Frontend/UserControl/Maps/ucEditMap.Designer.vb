<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEditMap
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
        lbMap = New Label()
        lbLocation = New Label()
        TextBox_Name = New TextBox()
        NumericUpDown_width = New NumericUpDown()
        NumericUpDown_height = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        TableLayoutPanel_Map = New TableLayoutPanel()
        Button1 = New Button()
        ComboBox_wall_north = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox_wall_east = New ComboBox()
        Label5 = New Label()
        ComboBox_wall_south = New ComboBox()
        Label6 = New Label()
        ComboBox_wall_west = New ComboBox()
        NumericUpDown_elevation = New NumericUpDown()
        Label7 = New Label()
        Label8 = New Label()
        ComboBox_gound = New ComboBox()
        Label9 = New Label()
        ComboBox_light = New ComboBox()
        Label10 = New Label()
        NumericUpDown_free_sky = New NumericUpDown()
        CheckBox_is_difficult_terrain = New CheckBox()
        CheckBox_is_trap = New CheckBox()
        Button_reset = New Button()
        CType(NumericUpDown_width, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_height, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_elevation, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_free_sky, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbMap
        ' 
        lbMap.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbMap.Location = New Point(0, 3)
        lbMap.Margin = New Padding(4, 0, 4, 0)
        lbMap.Name = "lbMap"
        lbMap.Size = New Size(104, 67)
        lbMap.TabIndex = 91
        lbMap.Text = "Map"
        lbMap.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbLocation
        ' 
        lbLocation.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbLocation.Location = New Point(1026, 72)
        lbLocation.Margin = New Padding(4, 0, 4, 0)
        lbLocation.Name = "lbLocation"
        lbLocation.Size = New Size(174, 45)
        lbLocation.TabIndex = 95
        lbLocation.Text = "Selected Map:"
        lbLocation.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox_Name.Location = New Point(1026, 122)
        TextBox_Name.Margin = New Padding(4, 5, 4, 5)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(464, 37)
        TextBox_Name.TabIndex = 96
        ' 
        ' NumericUpDown_width
        ' 
        NumericUpDown_width.Location = New Point(1202, 174)
        NumericUpDown_width.Minimum = New [Decimal](New Integer() {1, 0, 0, 0})
        NumericUpDown_width.Name = "NumericUpDown_width"
        NumericUpDown_width.Size = New Size(59, 31)
        NumericUpDown_width.TabIndex = 103
        NumericUpDown_width.Value = New [Decimal](New Integer() {10, 0, 0, 0})
        ' 
        ' NumericUpDown_height
        ' 
        NumericUpDown_height.Location = New Point(1291, 174)
        NumericUpDown_height.Minimum = New [Decimal](New Integer() {1, 0, 0, 0})
        NumericUpDown_height.Name = "NumericUpDown_height"
        NumericUpDown_height.Size = New Size(63, 31)
        NumericUpDown_height.TabIndex = 104
        NumericUpDown_height.Value = New [Decimal](New Integer() {10, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(1026, 164)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 45)
        Label1.TabIndex = 105
        Label1.Text = "Width x Height:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(1268, 164)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 45)
        Label2.TabIndex = 106
        Label2.Text = "x"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel_Map
        ' 
        TableLayoutPanel_Map.ColumnCount = 10
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TableLayoutPanel_Map.Location = New Point(19, 73)
        TableLayoutPanel_Map.Name = "TableLayoutPanel_Map"
        TableLayoutPanel_Map.RowCount = 10
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel_Map.Size = New Size(1000, 1000)
        TableLayoutPanel_Map.TabIndex = 107
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1360, 174)
        Button1.Name = "Button1"
        Button1.Size = New Size(66, 34)
        Button1.TabIndex = 108
        Button1.Text = "Set"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox_wall_north
        ' 
        ComboBox_wall_north.FormattingEnabled = True
        ComboBox_wall_north.Location = New Point(1026, 275)
        ComboBox_wall_north.Name = "ComboBox_wall_north"
        ComboBox_wall_north.Size = New Size(182, 33)
        ComboBox_wall_north.TabIndex = 109
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(1026, 227)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(174, 45)
        Label3.TabIndex = 110
        Label3.Text = "Wall North:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(1214, 227)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(174, 45)
        Label4.TabIndex = 112
        Label4.Text = "Wall East:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox_wall_east
        ' 
        ComboBox_wall_east.FormattingEnabled = True
        ComboBox_wall_east.Location = New Point(1214, 275)
        ComboBox_wall_east.Name = "ComboBox_wall_east"
        ComboBox_wall_east.Size = New Size(182, 33)
        ComboBox_wall_east.TabIndex = 111
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(1214, 311)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(174, 45)
        Label5.TabIndex = 116
        Label5.Text = "Wall South:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox_wall_south
        ' 
        ComboBox_wall_south.FormattingEnabled = True
        ComboBox_wall_south.Location = New Point(1214, 359)
        ComboBox_wall_south.Name = "ComboBox_wall_south"
        ComboBox_wall_south.Size = New Size(182, 33)
        ComboBox_wall_south.TabIndex = 115
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(1026, 311)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(174, 45)
        Label6.TabIndex = 114
        Label6.Text = "Wall West:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox_wall_west
        ' 
        ComboBox_wall_west.FormattingEnabled = True
        ComboBox_wall_west.Location = New Point(1026, 359)
        ComboBox_wall_west.Name = "ComboBox_wall_west"
        ComboBox_wall_west.Size = New Size(182, 33)
        ComboBox_wall_west.TabIndex = 113
        ' 
        ' NumericUpDown_elevation
        ' 
        NumericUpDown_elevation.Increment = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_elevation.Location = New Point(1186, 490)
        NumericUpDown_elevation.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_elevation.Name = "NumericUpDown_elevation"
        NumericUpDown_elevation.Size = New Size(75, 31)
        NumericUpDown_elevation.TabIndex = 117
        NumericUpDown_elevation.Value = New [Decimal](New Integer() {100, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(1026, 480)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 45)
        Label7.TabIndex = 118
        Label7.Text = "Elevation [ft]:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(1214, 395)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(174, 45)
        Label8.TabIndex = 122
        Label8.Text = "Ground Type:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox_gound
        ' 
        ComboBox_gound.FormattingEnabled = True
        ComboBox_gound.Location = New Point(1214, 443)
        ComboBox_gound.Name = "ComboBox_gound"
        ComboBox_gound.Size = New Size(182, 33)
        ComboBox_gound.TabIndex = 121
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(1026, 395)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(174, 45)
        Label9.TabIndex = 120
        Label9.Text = "Light Intensity:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ComboBox_light
        ' 
        ComboBox_light.FormattingEnabled = True
        ComboBox_light.Location = New Point(1026, 443)
        ComboBox_light.Name = "ComboBox_light"
        ComboBox_light.Size = New Size(182, 33)
        ComboBox_light.TabIndex = 119
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(1026, 525)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(153, 45)
        Label10.TabIndex = 124
        Label10.Text = "Free Sky [ft]:"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' NumericUpDown_free_sky
        ' 
        NumericUpDown_free_sky.Increment = New [Decimal](New Integer() {5, 0, 0, 0})
        NumericUpDown_free_sky.Location = New Point(1186, 535)
        NumericUpDown_free_sky.Maximum = New [Decimal](New Integer() {1000, 0, 0, 0})
        NumericUpDown_free_sky.Name = "NumericUpDown_free_sky"
        NumericUpDown_free_sky.Size = New Size(75, 31)
        NumericUpDown_free_sky.TabIndex = 123
        NumericUpDown_free_sky.Value = New [Decimal](New Integer() {1000, 0, 0, 0})
        ' 
        ' CheckBox_is_difficult_terrain
        ' 
        CheckBox_is_difficult_terrain.AutoSize = True
        CheckBox_is_difficult_terrain.Location = New Point(1035, 576)
        CheckBox_is_difficult_terrain.Name = "CheckBox_is_difficult_terrain"
        CheckBox_is_difficult_terrain.Size = New Size(155, 29)
        CheckBox_is_difficult_terrain.TabIndex = 125
        CheckBox_is_difficult_terrain.Text = "Difficult Terrain"
        CheckBox_is_difficult_terrain.UseVisualStyleBackColor = True
        ' 
        ' CheckBox_is_trap
        ' 
        CheckBox_is_trap.AutoSize = True
        CheckBox_is_trap.Location = New Point(1186, 576)
        CheckBox_is_trap.Name = "CheckBox_is_trap"
        CheckBox_is_trap.Size = New Size(71, 29)
        CheckBox_is_trap.TabIndex = 126
        CheckBox_is_trap.Text = "Trap"
        CheckBox_is_trap.UseVisualStyleBackColor = True
        ' 
        ' Button_reset
        ' 
        Button_reset.Location = New Point(1035, 1028)
        Button_reset.Name = "Button_reset"
        Button_reset.Size = New Size(391, 34)
        Button_reset.TabIndex = 127
        Button_reset.Text = "Reset Tile Selection"
        Button_reset.UseVisualStyleBackColor = True
        ' 
        ' ucEditMap
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(Button_reset)
        Controls.Add(CheckBox_is_trap)
        Controls.Add(CheckBox_is_difficult_terrain)
        Controls.Add(Label10)
        Controls.Add(NumericUpDown_free_sky)
        Controls.Add(Label8)
        Controls.Add(ComboBox_gound)
        Controls.Add(Label9)
        Controls.Add(ComboBox_light)
        Controls.Add(Label7)
        Controls.Add(NumericUpDown_elevation)
        Controls.Add(Label5)
        Controls.Add(ComboBox_wall_south)
        Controls.Add(Label6)
        Controls.Add(ComboBox_wall_west)
        Controls.Add(Label4)
        Controls.Add(ComboBox_wall_east)
        Controls.Add(Label3)
        Controls.Add(ComboBox_wall_north)
        Controls.Add(Button1)
        Controls.Add(TableLayoutPanel_Map)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(NumericUpDown_height)
        Controls.Add(NumericUpDown_width)
        Controls.Add(TextBox_Name)
        Controls.Add(lbLocation)
        Controls.Add(lbMap)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ucEditMap"
        Size = New Size(1494, 1076)
        CType(NumericUpDown_width, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_height, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_elevation, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_free_sky, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbMap As Label
    Friend WithEvents lbLocation As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents NumericUpDown_width As NumericUpDown
    Friend WithEvents NumericUpDown_height As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel_Map As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox_wall_north As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_wall_east As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_wall_south As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_wall_west As ComboBox
    Friend WithEvents NumericUpDown_elevation As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox_gound As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_light As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown_free_sky As NumericUpDown
    Friend WithEvents CheckBox_is_difficult_terrain As CheckBox
    Friend WithEvents CheckBox_is_trap As CheckBox
    Friend WithEvents Button_reset As Button
End Class
