﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOpponentsView
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
        Me.btnAddToBattle = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lbOpponents = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddToBattle
        '
        Me.btnAddToBattle.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToBattle.Location = New System.Drawing.Point(3, 451)
        Me.btnAddToBattle.Name = "btnAddToBattle"
        Me.btnAddToBattle.Size = New System.Drawing.Size(150, 46)
        Me.btnAddToBattle.TabIndex = 0
        Me.btnAddToBattle.Text = "add to battle"
        Me.btnAddToBattle.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.Location = New System.Drawing.Point(159, 451)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(88, 46)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNew.Location = New System.Drawing.Point(253, 451)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(94, 46)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "new"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lbOpponents
        '
        Me.lbOpponents.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbOpponents.Location = New System.Drawing.Point(0, 0)
        Me.lbOpponents.Name = "lbOpponents"
        Me.lbOpponents.Size = New System.Drawing.Size(350, 40)
        Me.lbOpponents.TabIndex = 3
        Me.lbOpponents.Text = "Opponents"
        Me.lbOpponents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucOpponentsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbOpponents)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddToBattle)
        Me.Name = "ucOpponentsView"
        Me.Size = New System.Drawing.Size(350, 500)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddToBattle As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents lbOpponents As Label
End Class
