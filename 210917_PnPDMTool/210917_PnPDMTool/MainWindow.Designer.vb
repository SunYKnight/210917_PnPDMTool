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
        Me.UcOpponentsView1 = New _210917_PnPDMTool.ucOpponentsView()
        Me.pnlMapView = New System.Windows.Forms.Panel()
        Me.pnlCharOverviewLeft = New System.Windows.Forms.Panel()
        Me.UcCharOverviewLeft1 = New _210917_PnPDMTool.ucCharOverviewLeft()
        Me.pnlCharOverviewRight = New System.Windows.Forms.Panel()
        Me.UcCharOverviewRight1 = New _210917_PnPDMTool.ucCharOverviewRight()
        Me.UcMapView1 = New _210917_PnPDMTool.ucMapView()
        Me.pnlBattleView.SuspendLayout()
        Me.pnlOpponentsView.SuspendLayout()
        Me.pnlMapView.SuspendLayout()
        Me.pnlCharOverviewLeft.SuspendLayout()
        Me.pnlCharOverviewRight.SuspendLayout()
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
        Me.UcBattleView1.Location = New System.Drawing.Point(0, 0)
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
        'UcOpponentsView1
        '
        Me.UcOpponentsView1.BackColor = System.Drawing.SystemColors.Control
        Me.UcOpponentsView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcOpponentsView1.Location = New System.Drawing.Point(0, 0)
        Me.UcOpponentsView1.Name = "UcOpponentsView1"
        Me.UcOpponentsView1.Size = New System.Drawing.Size(350, 500)
        Me.UcOpponentsView1.TabIndex = 0
        '
        'pnlMapView
        '
        Me.pnlMapView.Controls.Add(Me.UcMapView1)
        Me.pnlMapView.Location = New System.Drawing.Point(726, 13)
        Me.pnlMapView.Name = "pnlMapView"
        Me.pnlMapView.Size = New System.Drawing.Size(1156, 711)
        Me.pnlMapView.TabIndex = 2
        '
        'pnlCharOverviewLeft
        '
        Me.pnlCharOverviewLeft.Controls.Add(Me.UcCharOverviewLeft1)
        Me.pnlCharOverviewLeft.Location = New System.Drawing.Point(12, 519)
        Me.pnlCharOverviewLeft.Name = "pnlCharOverviewLeft"
        Me.pnlCharOverviewLeft.Size = New System.Drawing.Size(708, 478)
        Me.pnlCharOverviewLeft.TabIndex = 3
        '
        'UcCharOverviewLeft1
        '
        Me.UcCharOverviewLeft1.BackColor = System.Drawing.SystemColors.Control
        Me.UcCharOverviewLeft1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcCharOverviewLeft1.Location = New System.Drawing.Point(0, 0)
        Me.UcCharOverviewLeft1.Name = "UcCharOverviewLeft1"
        Me.UcCharOverviewLeft1.Size = New System.Drawing.Size(708, 478)
        Me.UcCharOverviewLeft1.TabIndex = 0
        '
        'pnlCharOverviewRight
        '
        Me.pnlCharOverviewRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlCharOverviewRight.Controls.Add(Me.UcCharOverviewRight1)
        Me.pnlCharOverviewRight.Location = New System.Drawing.Point(726, 730)
        Me.pnlCharOverviewRight.Name = "pnlCharOverviewRight"
        Me.pnlCharOverviewRight.Size = New System.Drawing.Size(1156, 267)
        Me.pnlCharOverviewRight.TabIndex = 4
        '
        'UcCharOverviewRight1
        '
        Me.UcCharOverviewRight1.BackColor = System.Drawing.SystemColors.Control
        Me.UcCharOverviewRight1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcCharOverviewRight1.Location = New System.Drawing.Point(0, 0)
        Me.UcCharOverviewRight1.Name = "UcCharOverviewRight1"
        Me.UcCharOverviewRight1.Size = New System.Drawing.Size(1156, 267)
        Me.UcCharOverviewRight1.TabIndex = 0
        '
        'UcMapView1
        '
        Me.UcMapView1.Location = New System.Drawing.Point(0, 0)
        Me.UcMapView1.Name = "UcMapView1"
        Me.UcMapView1.Size = New System.Drawing.Size(1156, 711)
        Me.UcMapView1.TabIndex = 0
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.Controls.Add(Me.pnlCharOverviewRight)
        Me.Controls.Add(Me.pnlCharOverviewLeft)
        Me.Controls.Add(Me.pnlMapView)
        Me.Controls.Add(Me.pnlOpponentsView)
        Me.Controls.Add(Me.pnlBattleView)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.Text = "windowMainWindow"
        Me.pnlBattleView.ResumeLayout(False)
        Me.pnlOpponentsView.ResumeLayout(False)
        Me.pnlMapView.ResumeLayout(False)
        Me.pnlCharOverviewLeft.ResumeLayout(False)
        Me.pnlCharOverviewRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBattleView As Panel
    Friend WithEvents pnlOpponentsView As Panel
    Friend WithEvents pnlMapView As Panel
    Friend WithEvents pnlCharOverviewLeft As Panel
    Friend WithEvents pnlCharOverviewRight As Panel
    Friend WithEvents UcBattleView1 As ucBattleView
    Friend WithEvents UcOpponentsView1 As ucOpponentsView
    Friend WithEvents UcCharOverviewLeft1 As ucCharOverviewLeft
    Friend WithEvents UcCharOverviewRight1 As ucCharOverviewRight
    Friend WithEvents UcMapView1 As ucMapView
End Class
