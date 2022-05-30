<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcCharOverviewRight
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
        Me.txtInfo2 = New System.Windows.Forms.TextBox()
        Me.txtInfo3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtInfo2
        '
        Me.txtInfo2.BackColor = System.Drawing.Color.White
        Me.txtInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo2.Location = New System.Drawing.Point(20, 23)
        Me.txtInfo2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInfo2.Multiline = True
        Me.txtInfo2.Name = "txtInfo2"
        Me.txtInfo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo2.Size = New System.Drawing.Size(857, 378)
        Me.txtInfo2.TabIndex = 0
        '
        'txtInfo3
        '
        Me.txtInfo3.BackColor = System.Drawing.Color.White
        Me.txtInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo3.Location = New System.Drawing.Point(914, 23)
        Me.txtInfo3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInfo3.Multiline = True
        Me.txtInfo3.Name = "txtInfo3"
        Me.txtInfo3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo3.Size = New System.Drawing.Size(857, 378)
        Me.txtInfo3.TabIndex = 1
        '
        'ucCharOverviewRight
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.txtInfo3)
        Me.Controls.Add(Me.txtInfo2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucCharOverviewRight"
        Me.Size = New System.Drawing.Size(1799, 428)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInfo2 As TextBox
    Friend WithEvents txtInfo3 As TextBox
End Class
