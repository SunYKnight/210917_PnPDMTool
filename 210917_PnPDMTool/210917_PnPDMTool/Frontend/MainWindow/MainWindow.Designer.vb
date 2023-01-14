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
        Me.FlowLayoutPanel_Left = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel_Center = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel_Left
        '
        resources.ApplyResources(Me.FlowLayoutPanel_Left, "FlowLayoutPanel_Left")
        Me.FlowLayoutPanel_Left.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel_Left.Name = "FlowLayoutPanel_Left"
        '
        'FlowLayoutPanel_Center
        '
        resources.ApplyResources(Me.FlowLayoutPanel_Center, "FlowLayoutPanel_Center")
        Me.FlowLayoutPanel_Center.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel_Center.Name = "FlowLayoutPanel_Center"
        '
        'MainWindow
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.FlowLayoutPanel_Center)
        Me.Controls.Add(Me.FlowLayoutPanel_Left)
        Me.Name = "MainWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucOpponent1 As ucEditMonsterOld
    Friend WithEvents FlowLayoutPanel_Left As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel_Center As FlowLayoutPanel
End Class
