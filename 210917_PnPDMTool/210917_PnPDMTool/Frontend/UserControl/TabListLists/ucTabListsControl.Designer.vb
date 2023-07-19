<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTabListsControl
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
        TabControl1 = New TabControl()
        TabPage_Battle = New TabPage()
        UcBattleView1 = New UcBattleView()
        TabPage_Monster = New TabPage()
        TabPage_NPC = New TabPage()
        TabPage_Player = New TabPage()
        TabPage_Map = New TabPage()
        UcMapList1 = New ucMapList()
        UcOpponentList1 = New ucOpponentList()
        TabControl1.SuspendLayout()
        TabPage_Battle.SuspendLayout()
        TabPage_Monster.SuspendLayout()
        TabPage_Map.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage_Battle)
        TabControl1.Controls.Add(TabPage_Monster)
        TabControl1.Controls.Add(TabPage_NPC)
        TabControl1.Controls.Add(TabPage_Player)
        TabControl1.Controls.Add(TabPage_Map)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(453, 857)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage_Battle
        ' 
        TabPage_Battle.Controls.Add(UcBattleView1)
        TabPage_Battle.Location = New Point(4, 34)
        TabPage_Battle.Name = "TabPage_Battle"
        TabPage_Battle.Padding = New Padding(3)
        TabPage_Battle.Size = New Size(445, 819)
        TabPage_Battle.TabIndex = 0
        TabPage_Battle.Text = "Battle"
        TabPage_Battle.UseVisualStyleBackColor = True
        ' 
        ' UcBattleView1
        ' 
        UcBattleView1.AutoSize = True
        UcBattleView1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        UcBattleView1.BackColor = SystemColors.ActiveCaption
        UcBattleView1.Dock = DockStyle.Fill
        UcBattleView1.Location = New Point(3, 3)
        UcBattleView1.Margin = New Padding(4, 5, 4, 5)
        UcBattleView1.MinimumSize = New Size(300, 500)
        UcBattleView1.Name = "UcBattleView1"
        UcBattleView1.Size = New Size(439, 813)
        UcBattleView1.TabIndex = 0
        ' 
        ' TabPage_Monster
        ' 
        TabPage_Monster.Controls.Add(UcOpponentList1)
        TabPage_Monster.Location = New Point(4, 34)
        TabPage_Monster.Name = "TabPage_Monster"
        TabPage_Monster.Padding = New Padding(3)
        TabPage_Monster.Size = New Size(445, 819)
        TabPage_Monster.TabIndex = 1
        TabPage_Monster.Text = "Monster"
        TabPage_Monster.UseVisualStyleBackColor = True
        ' 
        ' TabPage_NPC
        ' 
        TabPage_NPC.Location = New Point(4, 34)
        TabPage_NPC.Name = "TabPage_NPC"
        TabPage_NPC.Size = New Size(445, 819)
        TabPage_NPC.TabIndex = 2
        TabPage_NPC.Text = "NPC"
        TabPage_NPC.UseVisualStyleBackColor = True
        ' 
        ' TabPage_Player
        ' 
        TabPage_Player.Location = New Point(4, 34)
        TabPage_Player.Name = "TabPage_Player"
        TabPage_Player.Size = New Size(445, 819)
        TabPage_Player.TabIndex = 3
        TabPage_Player.Text = "Player"
        TabPage_Player.UseVisualStyleBackColor = True
        ' 
        ' TabPage_Map
        ' 
        TabPage_Map.Controls.Add(UcMapList1)
        TabPage_Map.Location = New Point(4, 34)
        TabPage_Map.Name = "TabPage_Map"
        TabPage_Map.Size = New Size(445, 819)
        TabPage_Map.TabIndex = 4
        TabPage_Map.Text = "Map"
        TabPage_Map.UseVisualStyleBackColor = True
        ' 
        ' UcMapList1
        ' 
        UcMapList1.BackColor = SystemColors.ActiveCaption
        UcMapList1.Dock = DockStyle.Fill
        UcMapList1.Location = New Point(0, 0)
        UcMapList1.Margin = New Padding(4, 5, 4, 5)
        UcMapList1.Name = "UcMapList1"
        UcMapList1.Size = New Size(445, 819)
        UcMapList1.TabIndex = 0
        ' 
        ' UcOpponentList1
        ' 
        UcOpponentList1.BackColor = SystemColors.ActiveCaption
        UcOpponentList1.Dock = DockStyle.Fill
        UcOpponentList1.Location = New Point(3, 3)
        UcOpponentList1.Margin = New Padding(4, 5, 4, 5)
        UcOpponentList1.Name = "UcOpponentList1"
        UcOpponentList1.Size = New Size(439, 813)
        UcOpponentList1.TabIndex = 0
        ' 
        ' ucTabListsControl
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ControlDark
        Controls.Add(TabControl1)
        MinimumSize = New Size(100, 100)
        Name = "ucTabListsControl"
        Size = New Size(453, 857)
        TabControl1.ResumeLayout(False)
        TabPage_Battle.ResumeLayout(False)
        TabPage_Battle.PerformLayout()
        TabPage_Monster.ResumeLayout(False)
        TabPage_Map.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_Battle As TabPage
    Friend WithEvents TabPage_Monster As TabPage
    Friend WithEvents TabPage_NPC As TabPage
    Friend WithEvents TabPage_Player As TabPage
    Friend WithEvents UcBattleView1 As UcBattleView
    Friend WithEvents TabPage_Map As TabPage
    Friend WithEvents UcMapList1 As ucMapList
    Friend WithEvents UcOpponentList1 As ucOpponentList
End Class
