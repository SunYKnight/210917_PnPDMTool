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
        Me.SuspendLayout()
        '
        'pnlBattleView
        '
        Me.pnlBattleView.Location = New System.Drawing.Point(102, 90)
        Me.pnlBattleView.Name = "pnlBattleView"
        Me.pnlBattleView.Size = New System.Drawing.Size(454, 445)
        Me.pnlBattleView.TabIndex = 0
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 1014)
        Me.Controls.Add(Me.pnlBattleView)
        Me.Name = "MainWindow"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBattleView As Panel
End Class
