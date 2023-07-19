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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(UcBattleView))
        btnRemove = New Button()
        btnNext = New Button()
        btnEndBattle = New Button()
        lbBattle = New Label()
        listViewBattle = New ListView()
        btnEditPlayer = New Button()
        btnNewPlayer = New Button()
        SuspendLayout()
        ' 
        ' btnRemove
        ' 
        resources.ApplyResources(btnRemove, "btnRemove")
        btnRemove.Name = "btnRemove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        resources.ApplyResources(btnNext, "btnNext")
        btnNext.Name = "btnNext"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnEndBattle
        ' 
        resources.ApplyResources(btnEndBattle, "btnEndBattle")
        btnEndBattle.Name = "btnEndBattle"
        btnEndBattle.UseVisualStyleBackColor = True
        ' 
        ' lbBattle
        ' 
        resources.ApplyResources(lbBattle, "lbBattle")
        lbBattle.Name = "lbBattle"
        ' 
        ' listViewBattle
        ' 
        listViewBattle.Activation = ItemActivation.OneClick
        listViewBattle.BackColor = Color.White
        listViewBattle.BorderStyle = BorderStyle.None
        resources.ApplyResources(listViewBattle, "listViewBattle")
        listViewBattle.Name = "listViewBattle"
        listViewBattle.UseCompatibleStateImageBehavior = False
        listViewBattle.View = View.Details
        ' 
        ' btnEditPlayer
        ' 
        resources.ApplyResources(btnEditPlayer, "btnEditPlayer")
        btnEditPlayer.Name = "btnEditPlayer"
        btnEditPlayer.UseVisualStyleBackColor = True
        ' 
        ' btnNewPlayer
        ' 
        resources.ApplyResources(btnNewPlayer, "btnNewPlayer")
        btnNewPlayer.Name = "btnNewPlayer"
        btnNewPlayer.UseVisualStyleBackColor = True
        ' 
        ' UcBattleView
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        Controls.Add(btnNewPlayer)
        Controls.Add(btnEditPlayer)
        Controls.Add(listViewBattle)
        Controls.Add(lbBattle)
        Controls.Add(btnEndBattle)
        Controls.Add(btnNext)
        Controls.Add(btnRemove)
        Name = "UcBattleView"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEndBattle As Button
    Friend WithEvents lbBattle As Label
    Friend WithEvents listViewBattle As ListView
    Friend WithEvents btnEditPlayer As Button
    Friend WithEvents btnNewPlayer As Button
End Class
