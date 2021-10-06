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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.pnlBattleView = New System.Windows.Forms.Panel()
        Me.ucBattleView1 = New _210917_PnPDMTool.ucBattleView()
        Me.pnlOpponentsView = New System.Windows.Forms.Panel()
        Me.ucOpponentsView1 = New _210917_PnPDMTool.ucOpponentsView()
        Me.pnlMapView = New System.Windows.Forms.Panel()
        Me.ucMapView1 = New _210917_PnPDMTool.ucMapView()
        Me.ucNew1 = New _210917_PnPDMTool.ucNew()
        Me.pnlCharOverviewLeft = New System.Windows.Forms.Panel()
        Me.ucCharOverviewLeft1 = New _210917_PnPDMTool.ucCharOverviewLeft()
        Me.pnlCharOverviewRight = New System.Windows.Forms.Panel()
        Me.ucCharOverviewRight1 = New _210917_PnPDMTool.ucCharOverviewRight()
        Me.ucPlayer1 = New _210917_PnPDMTool.ucPlayer()
        Me.ucOpponent1 = New _210917_PnPDMTool.ucOpponent()
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
        Me.pnlBattleView.Controls.Add(Me.ucBattleView1)
        resources.ApplyResources(Me.pnlBattleView, "pnlBattleView")
        Me.pnlBattleView.Name = "pnlBattleView"
        '
        'ucBattleView1
        '
        Me.ucBattleView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.ucBattleView1, "ucBattleView1")
        Me.ucBattleView1.Name = "ucBattleView1"
        '
        'pnlOpponentsView
        '
        Me.pnlOpponentsView.BackColor = System.Drawing.SystemColors.Control
        Me.pnlOpponentsView.Controls.Add(Me.ucOpponentsView1)
        resources.ApplyResources(Me.pnlOpponentsView, "pnlOpponentsView")
        Me.pnlOpponentsView.Name = "pnlOpponentsView"
        '
        'ucOpponentsView1
        '
        Me.ucOpponentsView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.ucOpponentsView1, "ucOpponentsView1")
        Me.ucOpponentsView1.Name = "ucOpponentsView1"
        '
        'pnlMapView
        '
        Me.pnlMapView.BackColor = System.Drawing.SystemColors.Control
        Me.pnlMapView.Controls.Add(Me.ucMapView1)
        Me.pnlMapView.Controls.Add(Me.ucNew1)
        Me.pnlMapView.Controls.Add(Me.ucOpponent1)
        Me.pnlMapView.Controls.Add(Me.ucPlayer1)
        resources.ApplyResources(Me.pnlMapView, "pnlMapView")
        Me.pnlMapView.Name = "pnlMapView"
        '
        'ucMapView1
        '
        Me.ucMapView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.ucMapView1, "ucMapView1")
        Me.ucMapView1.Name = "ucMapView1"
        '
        'ucNew1
        '
        resources.ApplyResources(Me.ucNew1, "ucNew1")
        Me.ucNew1.Name = "ucNew1"
        '
        'pnlCharOverviewLeft
        '
        Me.pnlCharOverviewLeft.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCharOverviewLeft.Controls.Add(Me.ucCharOverviewLeft1)
        resources.ApplyResources(Me.pnlCharOverviewLeft, "pnlCharOverviewLeft")
        Me.pnlCharOverviewLeft.Name = "pnlCharOverviewLeft"
        '
        'ucCharOverviewLeft1
        '
        resources.ApplyResources(Me.ucCharOverviewLeft1, "ucCharOverviewLeft1")
        Me.ucCharOverviewLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ucCharOverviewLeft1.Name = "ucCharOverviewLeft1"
        '
        'pnlCharOverviewRight
        '
        Me.pnlCharOverviewRight.BackColor = System.Drawing.SystemColors.Control
        Me.pnlCharOverviewRight.Controls.Add(Me.ucCharOverviewRight1)
        resources.ApplyResources(Me.pnlCharOverviewRight, "pnlCharOverviewRight")
        Me.pnlCharOverviewRight.Name = "pnlCharOverviewRight"
        '
        'ucCharOverviewRight1
        '
        Me.ucCharOverviewRight1.AllowDrop = True
        Me.ucCharOverviewRight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.ucCharOverviewRight1, "ucCharOverviewRight1")
        Me.ucCharOverviewRight1.Name = "ucCharOverviewRight1"
        '
        'ucPlayer1
        '
        resources.ApplyResources(Me.ucPlayer1, "ucPlayer1")
        Me.ucPlayer1.Name = "ucPlayer1"
        '
        'ucOpponent1
        '
        resources.ApplyResources(Me.ucOpponent1, "ucOpponent1")
        Me.ucOpponent1.Name = "ucOpponent1"
        '
        'MainWindow
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.pnlBattleView)
        Me.Controls.Add(Me.pnlOpponentsView)
        Me.Controls.Add(Me.pnlMapView)
        Me.Controls.Add(Me.pnlCharOverviewLeft)
        Me.Controls.Add(Me.pnlCharOverviewRight)
        Me.Name = "MainWindow"
        Me.pnlBattleView.ResumeLayout(False)
        Me.pnlOpponentsView.ResumeLayout(False)
        Me.pnlMapView.ResumeLayout(False)
        Me.pnlCharOverviewLeft.ResumeLayout(False)
        Me.pnlCharOverviewLeft.PerformLayout()
        Me.pnlCharOverviewRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBattleView As Panel
    Friend WithEvents pnlOpponentsView As Panel
    Friend WithEvents pnlMapView As Panel
    Friend WithEvents pnlCharOverviewLeft As Panel
    Friend WithEvents pnlCharOverviewRight As Panel
    Friend WithEvents ucBattleView1 As ucBattleView
    Friend WithEvents ucOpponentsView1 As ucOpponentsView
    Friend WithEvents ucCharOverviewLeft1 As ucCharOverviewLeft
    Friend WithEvents ucMapView1 As ucMapView
    Friend WithEvents ucCharOverviewRight1 As ucCharOverviewRight
    Friend WithEvents ucNew1 As ucNew
    Friend WithEvents ucPlayer1 As ucPlayer
    Friend WithEvents ucOpponent1 As ucOpponent
End Class
