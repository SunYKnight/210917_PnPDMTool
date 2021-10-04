<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBattleView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBattleView))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnEndBattle = New System.Windows.Forms.Button()
        Me.lbBattle = New System.Windows.Forms.Label()
        Me.listViewBattle = New System.Windows.Forms.ListView()
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
        Me.listViewBattle.HideSelection = False
        resources.ApplyResources(Me.listViewBattle, "listViewBattle")
        Me.listViewBattle.Name = "listViewBattle"
        Me.listViewBattle.UseCompatibleStateImageBehavior = False
        '
        'ucBattleView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.listViewBattle)
        Me.Controls.Add(Me.lbBattle)
        Me.Controls.Add(Me.btnEndBattle)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnRemove)
        Me.Name = "ucBattleView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEndBattle As Button
    Friend WithEvents lbBattle As Label
    Friend WithEvents listViewBattle As ListView
End Class
