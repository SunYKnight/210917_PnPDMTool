<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlBattleView = New System.Windows.Forms.Panel()
        Me.UcBattleView1 = New _210917_PnPDMTool.ucBattleView()
        Me.pnlOpponentsView = New System.Windows.Forms.Panel()
        Me.pnlMapView = New System.Windows.Forms.Panel()
        Me.pnlCharacterOverviewLeft = New System.Windows.Forms.Panel()
        Me.pnlCharacterOverviewRight = New System.Windows.Forms.Panel()
        Me.UcOpponentsView1 = New _210917_PnPDMTool.ucOpponentsView()
        Me.pnlBattleView.SuspendLayout()
        Me.pnlOpponentsView.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBattleView
        '
        Me.pnlBattleView.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBattleView.Controls.Add(Me.UcBattleView1)
        Me.pnlBattleView.Location = New System.Drawing.Point(13, 13)
        Me.pnlBattleView.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBattleView.Name = "pnlBattleView"
        Me.pnlBattleView.Size = New System.Drawing.Size(350, 500)
        Me.pnlBattleView.TabIndex = 0
        '
        'UcBattleView1
        '
        Me.UcBattleView1.BackColor = System.Drawing.SystemColors.Control
        Me.UcBattleView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcBattleView1.Location = New System.Drawing.Point(-1, -1)
        Me.UcBattleView1.Name = "UcBattleView1"
        Me.UcBattleView1.Size = New System.Drawing.Size(350, 500)
        Me.UcBattleView1.TabIndex = 0
        '
        'pnlOpponentsView
        '
        Me.pnlOpponentsView.Controls.Add(Me.UcOpponentsView1)
        Me.pnlOpponentsView.Location = New System.Drawing.Point(370, 13)
        Me.pnlOpponentsView.Name = "pnlOpponentsView"
        Me.pnlOpponentsView.Size = New System.Drawing.Size(350, 500)
        Me.pnlOpponentsView.TabIndex = 1
        '
        'pnlMapView
        '
        Me.pnlMapView.Location = New System.Drawing.Point(734, 12)
        Me.pnlMapView.Name = "pnlMapView"
        Me.pnlMapView.Size = New System.Drawing.Size(1148, 700)
        Me.pnlMapView.TabIndex = 2
        '
        'pnlCharacterOverviewLeft
        '
        Me.pnlCharacterOverviewLeft.Location = New System.Drawing.Point(12, 527)
        Me.pnlCharacterOverviewLeft.Name = "pnlCharacterOverviewLeft"
        Me.pnlCharacterOverviewLeft.Size = New System.Drawing.Size(708, 470)
        Me.pnlCharacterOverviewLeft.TabIndex = 3
        '
        'pnlCharacterOverviewRight
        '
        Me.pnlCharacterOverviewRight.Location = New System.Drawing.Point(726, 730)
        Me.pnlCharacterOverviewRight.Name = "pnlCharacterOverviewRight"
        Me.pnlCharacterOverviewRight.Size = New System.Drawing.Size(1156, 267)
        Me.pnlCharacterOverviewRight.TabIndex = 4
        '
        'UcOpponentsView1
        '
        Me.UcOpponentsView1.BackColor = System.Drawing.SystemColors.Control
        Me.UcOpponentsView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcOpponentsView1.Location = New System.Drawing.Point(0, 0)
        Me.UcOpponentsView1.Name = "UcOpponentsView1"
        Me.UcOpponentsView1.Size = New System.Drawing.Size(350, 500)
        Me.UcOpponentsView1.TabIndex = 0
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.pnlCharacterOverviewRight)
        Me.Controls.Add(Me.pnlCharacterOverviewLeft)
        Me.Controls.Add(Me.pnlMapView)
        Me.Controls.Add(Me.pnlOpponentsView)
        Me.Controls.Add(Me.pnlBattleView)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "windowMainWindow"
        Me.pnlBattleView.ResumeLayout(False)
        Me.pnlOpponentsView.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBattleView As Panel
    Friend WithEvents pnlOpponentsView As Panel
    Friend WithEvents pnlMapView As Panel
    Friend WithEvents pnlCharacterOverviewLeft As Panel
    Friend WithEvents pnlCharacterOverviewRight As Panel
    Friend WithEvents UcBattleView1 As ucBattleView
    Friend WithEvents UcOpponentsView1 As ucOpponentsView
End Class
