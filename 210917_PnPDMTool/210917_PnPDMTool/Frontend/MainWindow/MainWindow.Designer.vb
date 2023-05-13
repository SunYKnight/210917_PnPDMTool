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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainWindow))
        FlowLayoutPanel_Left = New FlowLayoutPanel()
        FlowLayoutPanel_Center = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel_Left
        ' 
        resources.ApplyResources(FlowLayoutPanel_Left, "FlowLayoutPanel_Left")
        FlowLayoutPanel_Left.BackColor = SystemColors.ControlDark
        FlowLayoutPanel_Left.Name = "FlowLayoutPanel_Left"
        ' 
        ' FlowLayoutPanel_Center
        ' 
        resources.ApplyResources(FlowLayoutPanel_Center, "FlowLayoutPanel_Center")
        FlowLayoutPanel_Center.BackColor = SystemColors.ControlDark
        FlowLayoutPanel_Center.Name = "FlowLayoutPanel_Center"
        ' 
        ' MainWindow
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        Controls.Add(FlowLayoutPanel_Center)
        Controls.Add(FlowLayoutPanel_Left)
        Name = "MainWindow"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FlowLayoutPanel_Left As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel_Center As FlowLayoutPanel
End Class
