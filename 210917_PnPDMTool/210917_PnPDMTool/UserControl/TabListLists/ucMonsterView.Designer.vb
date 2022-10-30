<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMonsterView
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
        Me.btnEditOpponent = New System.Windows.Forms.Button()
        Me.btnNewOpponent = New System.Windows.Forms.Button()
        Me.lbOpponents = New System.Windows.Forms.Label()
        Me.listViewOpponents = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnAddToBattle
        '
        Me.btnAddToBattle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToBattle.Location = New System.Drawing.Point(15, 445)
        Me.btnAddToBattle.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAddToBattle.Name = "btnAddToBattle"
        Me.btnAddToBattle.Size = New System.Drawing.Size(280, 34)
        Me.btnAddToBattle.TabIndex = 0
        Me.btnAddToBattle.Text = "add to battle"
        Me.btnAddToBattle.UseVisualStyleBackColor = True
        '
        'btnEditOpponent
        '
        Me.btnEditOpponent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditOpponent.Location = New System.Drawing.Point(153, 410)
        Me.btnEditOpponent.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnEditOpponent.Name = "btnEditOpponent"
        Me.btnEditOpponent.Size = New System.Drawing.Size(142, 33)
        Me.btnEditOpponent.TabIndex = 1
        Me.btnEditOpponent.Text = "edit Opponent"
        Me.btnEditOpponent.UseVisualStyleBackColor = True
        '
        'btnNewOpponent
        '
        Me.btnNewOpponent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNewOpponent.Location = New System.Drawing.Point(15, 410)
        Me.btnNewOpponent.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnNewOpponent.Name = "btnNewOpponent"
        Me.btnNewOpponent.Size = New System.Drawing.Size(134, 33)
        Me.btnNewOpponent.TabIndex = 2
        Me.btnNewOpponent.Text = "new Opponent"
        Me.btnNewOpponent.UseVisualStyleBackColor = True
        '
        'lbOpponents
        '
        Me.lbOpponents.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbOpponents.Location = New System.Drawing.Point(2, 0)
        Me.lbOpponents.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbOpponents.Name = "lbOpponents"
        Me.lbOpponents.Size = New System.Drawing.Size(304, 42)
        Me.lbOpponents.TabIndex = 3
        Me.lbOpponents.Text = "Opponents"
        Me.lbOpponents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listViewOpponents
        '
        Me.listViewOpponents.BackColor = System.Drawing.Color.White
        Me.listViewOpponents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listViewOpponents.HideSelection = False
        Me.listViewOpponents.Location = New System.Drawing.Point(15, 55)
        Me.listViewOpponents.Name = "listViewOpponents"
        Me.listViewOpponents.Size = New System.Drawing.Size(280, 341)
        Me.listViewOpponents.TabIndex = 4
        Me.listViewOpponents.UseCompatibleStateImageBehavior = False
        '
        'ucOpponentsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.listViewOpponents)
        Me.Controls.Add(Me.lbOpponents)
        Me.Controls.Add(Me.btnNewOpponent)
        Me.Controls.Add(Me.btnEditOpponent)
        Me.Controls.Add(Me.btnAddToBattle)
        Me.Name = "ucOpponentsView"
        Me.Size = New System.Drawing.Size(308, 490)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddToBattle As Button
    Friend WithEvents btnEditOpponent As Button
    Friend WithEvents btnNewOpponent As Button
    Friend WithEvents lbOpponents As Label
    Friend WithEvents listViewOpponents As ListView
End Class
