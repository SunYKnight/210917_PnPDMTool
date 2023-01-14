<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucTabEditBeeing
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
        Me._mainLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        '_mainLayout
        '
        Me._mainLayout.AutoSize = True
        Me._mainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me._mainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me._mainLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me._mainLayout.Location = New System.Drawing.Point(0, 0)
        Me._mainLayout.Name = "_mainLayout"
        Me._mainLayout.Size = New System.Drawing.Size(750, 1000)
        Me._mainLayout.TabIndex = 0
        '
        'ucTabEditBeeing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me._mainLayout)
        Me.MinimumSize = New System.Drawing.Size(750, 1000)
        Me.Name = "ucTabEditBeeing"
        Me.Size = New System.Drawing.Size(750, 1000)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _mainLayout As FlowLayoutPanel
End Class
