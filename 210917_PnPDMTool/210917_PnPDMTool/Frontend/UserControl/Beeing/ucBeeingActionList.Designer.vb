﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucBeeingActionList
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
        Me.ListView_Actions = New System.Windows.Forms.ListView()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_new = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView_Actions
        '
        Me.ListView_Actions.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_Actions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView_Actions.Location = New System.Drawing.Point(0, 0)
        Me.ListView_Actions.MultiSelect = False
        Me.ListView_Actions.Name = "ListView_Actions"
        Me.ListView_Actions.Size = New System.Drawing.Size(827, 460)
        Me.ListView_Actions.TabIndex = 0
        Me.ListView_Actions.UseCompatibleStateImageBehavior = False
        Me.ListView_Actions.View = System.Windows.Forms.View.Details
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(594, 3)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(112, 34)
        Me.Button_edit.TabIndex = 1
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'Button_new
        '
        Me.Button_new.Location = New System.Drawing.Point(712, 3)
        Me.Button_new.Name = "Button_new"
        Me.Button_new.Size = New System.Drawing.Size(112, 34)
        Me.Button_new.TabIndex = 2
        Me.Button_new.Text = "New"
        Me.Button_new.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_new)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_edit)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 419)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(827, 41)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'ucBeeingActionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.ListView_Actions)
        Me.Name = "ucBeeingActionList"
        Me.Size = New System.Drawing.Size(827, 460)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView_Actions As ListView
    Friend WithEvents Button_edit As Button
    Friend WithEvents Button_new As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
