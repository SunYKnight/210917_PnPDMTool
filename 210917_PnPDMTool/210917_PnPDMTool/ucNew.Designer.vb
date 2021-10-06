<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNew
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
        Me.lbNewCharacter = New System.Windows.Forms.Label()
        Me.lbCreateANew = New System.Windows.Forms.Label()
        Me.btnPlayer = New System.Windows.Forms.Button()
        Me.btnOpponent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNewCharacter
        '
        Me.lbNewCharacter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbNewCharacter.Location = New System.Drawing.Point(3, 0)
        Me.lbNewCharacter.Name = "lbNewCharacter"
        Me.lbNewCharacter.Size = New System.Drawing.Size(157, 40)
        Me.lbNewCharacter.TabIndex = 0
        Me.lbNewCharacter.Text = "New Character"
        Me.lbNewCharacter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCreateANew
        '
        Me.lbCreateANew.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbCreateANew.Location = New System.Drawing.Point(3, 63)
        Me.lbCreateANew.Name = "lbCreateANew"
        Me.lbCreateANew.Size = New System.Drawing.Size(98, 30)
        Me.lbCreateANew.TabIndex = 1
        Me.lbCreateANew.Text = "Create a new:"
        Me.lbCreateANew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPlayer
        '
        Me.btnPlayer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlayer.Location = New System.Drawing.Point(129, 63)
        Me.btnPlayer.Name = "btnPlayer"
        Me.btnPlayer.Size = New System.Drawing.Size(115, 30)
        Me.btnPlayer.TabIndex = 2
        Me.btnPlayer.Text = "Player"
        Me.btnPlayer.UseVisualStyleBackColor = True
        '
        'btnOpponent
        '
        Me.btnOpponent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOpponent.Location = New System.Drawing.Point(268, 63)
        Me.btnOpponent.Name = "btnOpponent"
        Me.btnOpponent.Size = New System.Drawing.Size(125, 30)
        Me.btnOpponent.TabIndex = 3
        Me.btnOpponent.Text = "Opponent"
        Me.btnOpponent.UseVisualStyleBackColor = True
        '
        'ucNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnOpponent)
        Me.Controls.Add(Me.btnPlayer)
        Me.Controls.Add(Me.lbCreateANew)
        Me.Controls.Add(Me.lbNewCharacter)
        Me.Name = "ucNew"
        Me.Size = New System.Drawing.Size(1535, 1082)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbNewCharacter As Label
    Friend WithEvents lbCreateANew As Label
    Friend WithEvents btnPlayer As Button
    Friend WithEvents btnOpponent As Button
End Class
