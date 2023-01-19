<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBeeing
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
        Me.TabControl_beeing = New System.Windows.Forms.TabControl()
        Me.TabPage_General = New System.Windows.Forms.TabPage()
        Me.TabPage_Actions = New System.Windows.Forms.TabPage()
        Me.TabControl_beeing.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_beeing
        '
        Me.TabControl_beeing.Controls.Add(Me.TabPage_General)
        Me.TabControl_beeing.Controls.Add(Me.TabPage_Actions)
        Me.TabControl_beeing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl_beeing.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_beeing.Name = "TabControl_beeing"
        Me.TabControl_beeing.SelectedIndex = 0
        Me.TabControl_beeing.Size = New System.Drawing.Size(1500, 1200)
        Me.TabControl_beeing.TabIndex = 0
        '
        'TabPage_General
        '
        Me.TabPage_General.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_General.Name = "TabPage_General"
        Me.TabPage_General.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_General.Size = New System.Drawing.Size(1492, 1162)
        Me.TabPage_General.TabIndex = 0
        Me.TabPage_General.Text = "General"
        Me.TabPage_General.UseVisualStyleBackColor = True
        '
        'TabPage_Actions
        '
        Me.TabPage_Actions.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_Actions.Name = "TabPage_Actions"
        Me.TabPage_Actions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Actions.Size = New System.Drawing.Size(873, 570)
        Me.TabPage_Actions.TabIndex = 1
        Me.TabPage_Actions.Text = "Actions"
        Me.TabPage_Actions.UseVisualStyleBackColor = True
        '
        'ucBeeing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl_beeing)
        Me.Name = "ucBeeing"
        Me.Size = New System.Drawing.Size(1500, 1200)
        Me.TabControl_beeing.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl_beeing As TabControl
    Friend WithEvents TabPage_General As TabPage
    Friend WithEvents TabPage_Actions As TabPage
End Class
