<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBattleView
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnEndBattle = New System.Windows.Forms.Button()
        Me.lbBattle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRemove.Location = New System.Drawing.Point(3, 451)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(111, 46)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(120, 451)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(85, 46)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnEndBattle
        '
        Me.btnEndBattle.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEndBattle.Location = New System.Drawing.Point(211, 451)
        Me.btnEndBattle.Name = "btnEndBattle"
        Me.btnEndBattle.Size = New System.Drawing.Size(136, 46)
        Me.btnEndBattle.TabIndex = 2
        Me.btnEndBattle.Text = "end battle"
        Me.btnEndBattle.UseVisualStyleBackColor = True
        '
        'lbBattle
        '
        Me.lbBattle.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbBattle.Location = New System.Drawing.Point(3, 0)
        Me.lbBattle.Name = "lbBattle"
        Me.lbBattle.Size = New System.Drawing.Size(347, 40)
        Me.lbBattle.TabIndex = 3
        Me.lbBattle.Text = "Battle"
        Me.lbBattle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucBattleView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.lbBattle)
        Me.Controls.Add(Me.btnEndBattle)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnRemove)
        Me.Name = "ucBattleView"
        Me.Size = New System.Drawing.Size(350, 500)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnEndBattle As Button
    Friend WithEvents lbBattle As Label
End Class
