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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Battle = New System.Windows.Forms.TabPage()
        Me.TabPage_Monster = New System.Windows.Forms.TabPage()
        Me.TabPage_NPC = New System.Windows.Forms.TabPage()
        Me.TabPage_Player = New System.Windows.Forms.TabPage()
        Me.UcBattleView1 = New _210917_PnPDMTool.UcBattleView()
        Me.UcMonsterView1 = New _210917_PnPDMTool.ucMonsterView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Battle.SuspendLayout()
        Me.TabPage_Monster.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Battle)
        Me.TabControl1.Controls.Add(Me.TabPage_Monster)
        Me.TabControl1.Controls.Add(Me.TabPage_NPC)
        Me.TabControl1.Controls.Add(Me.TabPage_Player)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(453, 857)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_Battle
        '
        Me.TabPage_Battle.Controls.Add(Me.UcBattleView1)
        Me.TabPage_Battle.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_Battle.Name = "TabPage_Battle"
        Me.TabPage_Battle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Battle.Size = New System.Drawing.Size(445, 819)
        Me.TabPage_Battle.TabIndex = 0
        Me.TabPage_Battle.Text = "Battle"
        Me.TabPage_Battle.UseVisualStyleBackColor = True
        '
        'TabPage_Monster
        '
        Me.TabPage_Monster.Controls.Add(Me.UcMonsterView1)
        Me.TabPage_Monster.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_Monster.Name = "TabPage_Monster"
        Me.TabPage_Monster.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Monster.Size = New System.Drawing.Size(445, 819)
        Me.TabPage_Monster.TabIndex = 1
        Me.TabPage_Monster.Text = "Monster"
        Me.TabPage_Monster.UseVisualStyleBackColor = True
        '
        'TabPage_NPC
        '
        Me.TabPage_NPC.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_NPC.Name = "TabPage_NPC"
        Me.TabPage_NPC.Size = New System.Drawing.Size(772, 662)
        Me.TabPage_NPC.TabIndex = 2
        Me.TabPage_NPC.Text = "NPC"
        Me.TabPage_NPC.UseVisualStyleBackColor = True
        '
        'TabPage_Player
        '
        Me.TabPage_Player.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_Player.Name = "TabPage_Player"
        Me.TabPage_Player.Size = New System.Drawing.Size(772, 662)
        Me.TabPage_Player.TabIndex = 3
        Me.TabPage_Player.Text = "Player"
        Me.TabPage_Player.UseVisualStyleBackColor = True
        '
        'UcBattleView1
        '
        Me.UcBattleView1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UcBattleView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcBattleView1.Location = New System.Drawing.Point(3, 3)
        Me.UcBattleView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcBattleView1.Name = "UcBattleView1"
        Me.UcBattleView1.Size = New System.Drawing.Size(439, 813)
        Me.UcBattleView1.TabIndex = 0
        '
        'UcMonsterView1
        '
        Me.UcMonsterView1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UcMonsterView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcMonsterView1.Location = New System.Drawing.Point(3, 3)
        Me.UcMonsterView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcMonsterView1.Name = "UcMonsterView1"
        Me.UcMonsterView1.Size = New System.Drawing.Size(439, 813)
        Me.UcMonsterView1.TabIndex = 0
        '
        'ucTabListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.TabControl1)
        Me.MinimumSize = New System.Drawing.Size(100, 100)
        Me.Name = "ucTabListControl"
        Me.Size = New System.Drawing.Size(453, 857)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Battle.ResumeLayout(False)
        Me.TabPage_Monster.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_Battle As TabPage
    Friend WithEvents TabPage_Monster As TabPage
    Friend WithEvents TabPage_NPC As TabPage
    Friend WithEvents TabPage_Player As TabPage
    Friend WithEvents UcBattleView1 As UcBattleView
    Friend WithEvents UcMonsterView1 As ucMonsterView
End Class
