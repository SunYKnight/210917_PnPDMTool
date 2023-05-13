<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcBattleView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcBattleView))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnEndBattle = New System.Windows.Forms.Button()
        Me.lbBattle = New System.Windows.Forms.Label()
        Me.listViewBattle = New System.Windows.Forms.ListView()
        Me.btnEditPlayer = New System.Windows.Forms.Button()
        Me.btnNewPlayer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        resources.ApplyResources(Me.btnRemove, "btnRemove")
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        resources.ApplyResources(Me.btnNext, "btnNext")
        Me.btnNext.Name = "btnNext"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnEndBattle
        '
        resources.ApplyResources(Me.btnEndBattle, "btnEndBattle")
        Me.btnEndBattle.Name = "btnEndBattle"
        Me.btnEndBattle.UseVisualStyleBackColor = True
        '
        'lbBattle
        '
        resources.ApplyResources(Me.lbBattle, "lbBattle")
        Me.lbBattle.Name = "lbBattle"
        '
        'listViewBattle
        '
        Me.listViewBattle.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listViewBattle.BackColor = System.Drawing.Color.White
        Me.listViewBattle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listViewBattle.Location = New System.Drawing.Point(21, 92)
        Me.listViewBattle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listViewBattle.Name = "listView_Opponents"
        Me.listViewBattle.Size = New System.Drawing.Size(400, 568)
        Me.listViewBattle.TabIndex = 4
        Me.listViewBattle.UseCompatibleStateImageBehavior = False
        Me.listViewBattle.View = System.Windows.Forms.View.Details
        '
        'btnEditPlayer
        '
        resources.ApplyResources(Me.btnEditPlayer, "btnEditPlayer")
        Me.btnEditPlayer.Name = "btnEditPlayer"
        Me.btnEditPlayer.UseVisualStyleBackColor = True
        '
        'btnNewPlayer
        '
        resources.ApplyResources(Me.btnNewPlayer, "btnNewPlayer")
        Me.btnNewPlayer.Name = "btnNewPlayer"
        Me.btnNewPlayer.UseVisualStyleBackColor = True
        '
        'UcBattleView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.btnNewPlayer)
        Me.Controls.Add(Me.btnEditPlayer)
        Me.Controls.Add(Me.listViewBattle)
        Me.Controls.Add(Me.lbBattle)
        Me.Controls.Add(Me.btnEndBattle)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnRemove)
        Me.Name = "UcBattleView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEndBattle As Button
    Friend WithEvents lbBattle As Label
    Friend WithEvents listViewBattle As ListView
    Friend WithEvents btnEditPlayer As Button
    Friend WithEvents btnNewPlayer As Button
End Class
