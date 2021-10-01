<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCharOverviewLeft
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
        Me.lbName = New System.Windows.Forms.Label()
        Me.btnActions = New System.Windows.Forms.Button()
        Me.btnLegendaryActions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbName.Location = New System.Drawing.Point(0, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(354, 40)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Name"
        '
        'btnActions
        '
        Me.btnActions.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnActions.Location = New System.Drawing.Point(273, 3)
        Me.btnActions.Name = "btnActions"
        Me.btnActions.Size = New System.Drawing.Size(132, 46)
        Me.btnActions.TabIndex = 1
        Me.btnActions.Text = "actions"
        Me.btnActions.UseVisualStyleBackColor = True
        '
        'btnLegendaryActions
        '
        Me.btnLegendaryActions.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLegendaryActions.Location = New System.Drawing.Point(411, 3)
        Me.btnLegendaryActions.Name = "btnLegendaryActions"
        Me.btnLegendaryActions.Size = New System.Drawing.Size(207, 46)
        Me.btnLegendaryActions.TabIndex = 2
        Me.btnLegendaryActions.Text = "legendary actions"
        Me.btnLegendaryActions.UseVisualStyleBackColor = True
        '
        'ucCharOverviewLeft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.btnLegendaryActions)
        Me.Controls.Add(Me.btnActions)
        Me.Controls.Add(Me.lbName)
        Me.MinimumSize = New System.Drawing.Size(621, 489)
        Me.Name = "ucCharOverviewLeft"
        Me.Size = New System.Drawing.Size(623, 491)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbName As Label
    Friend WithEvents btnActions As Button
    Friend WithEvents btnLegendaryActions As Button
End Class
