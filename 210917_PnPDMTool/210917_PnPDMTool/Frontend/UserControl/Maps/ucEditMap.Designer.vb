﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(NumericUpDown_width, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_height, ComponentModel.ISupportInitialize).BeginInit()
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
        lbLocation.Location = New Point(1150, 73)
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
        TextBox_Name.Location = New Point(1150, 123)
        TextBox_Name.Margin = New Padding(4, 5, 4, 5)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(464, 37)
        TextBox_Name.TabIndex = 96
        ' 
        ' NumericUpDown_width
        ' 
        NumericUpDown_width.Location = New Point(1323, 175)
        NumericUpDown_width.Minimum = New [Decimal](New Integer() {1, 0, 0, 0})
        NumericUpDown_width.Name = "NumericUpDown_width"
        NumericUpDown_width.Size = New Size(75, 31)
        NumericUpDown_width.TabIndex = 103
        NumericUpDown_width.Value = New [Decimal](New Integer() {10, 0, 0, 0})
        ' 
        ' NumericUpDown_height
        ' 
        NumericUpDown_height.Location = New Point(1441, 175)
        NumericUpDown_height.Minimum = New [Decimal](New Integer() {1, 0, 0, 0})
        NumericUpDown_height.Name = "NumericUpDown_height"
        NumericUpDown_height.Size = New Size(75, 31)
        NumericUpDown_height.TabIndex = 104
        NumericUpDown_height.Value = New [Decimal](New Integer() {10, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(1150, 165)
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
        Label2.Location = New Point(1408, 165)
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
        TableLayoutPanel_Map.Size = New Size(1124, 1057)
        TableLayoutPanel_Map.TabIndex = 107
        ' 
        ' ucEditMap
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
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
        Size = New Size(1633, 1145)
        CType(NumericUpDown_width, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_height, ComponentModel.ISupportInitialize).EndInit()
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
End Class
