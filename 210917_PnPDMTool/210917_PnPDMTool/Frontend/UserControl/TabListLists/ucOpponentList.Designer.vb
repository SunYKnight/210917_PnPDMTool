<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucOpponentList
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
        Me.listView_Items = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnAddToBattle
        '
        Me.btnAddToBattle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddToBattle.Location = New System.Drawing.Point(21, 742)
        Me.btnAddToBattle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddToBattle.Name = "btnAddToBattle"
        Me.btnAddToBattle.Size = New System.Drawing.Size(400, 57)
        Me.btnAddToBattle.TabIndex = 0
        Me.btnAddToBattle.Text = "add to battle"
        Me.btnAddToBattle.UseVisualStyleBackColor = True
        '
        'btnEditOpponent
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.Location = New System.Drawing.Point(219, 683)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEditOpponent"
        Me.btnEdit.Size = New System.Drawing.Size(203, 55)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "edit Opponent"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNewOpponent
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNew.Location = New System.Drawing.Point(21, 683)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNew.Name = "btnNewOpponent"
        Me.btnNew.Size = New System.Drawing.Size(191, 55)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "new Opponent"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lbOpponents
        '
        Me.lbOpponents.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbOpponents.Location = New System.Drawing.Point(3, 0)
        Me.lbOpponents.Name = "lbOpponents"
        Me.lbOpponents.Size = New System.Drawing.Size(434, 70)
        Me.lbOpponents.TabIndex = 3
        Me.lbOpponents.Text = "Opponents"
        Me.lbOpponents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listView_Opponents
        '
        Me.listView_Items.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listView_Items.BackColor = System.Drawing.Color.White
        Me.listView_Items.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listView_Items.Location = New System.Drawing.Point(21, 92)
        Me.listView_Items.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listView_Items.Name = "listView_Opponents"
        Me.listView_Items.Size = New System.Drawing.Size(400, 568)
        Me.listView_Items.TabIndex = 4
        Me.listView_Items.UseCompatibleStateImageBehavior = False
        Me.listView_Items.View = System.Windows.Forms.View.Details
        '
        'ucMonsterView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.listView_Items)
        Me.Controls.Add(Me.lbOpponents)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddToBattle)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucMonsterView"
        Me.Size = New System.Drawing.Size(440, 817)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddToBattle As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents lbOpponents As Label
    Friend WithEvents listView_Items As ListView
End Class
