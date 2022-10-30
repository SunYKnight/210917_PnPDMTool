<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSkillCollection
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
        Me.Label_Competence_Acrobatic = New System.Windows.Forms.Label()
        Me.ComboBox_Competence_Acrobatic = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label_Competence_Acrobatic
        '
        Me.Label_Competence_Acrobatic.Location = New System.Drawing.Point(119, 17)
        Me.Label_Competence_Acrobatic.Name = "Label_Competence_Acrobatic"
        Me.Label_Competence_Acrobatic.Size = New System.Drawing.Size(120, 25)
        Me.Label_Competence_Acrobatic.TabIndex = 1
        Me.Label_Competence_Acrobatic.Text = "Acrobatic"
        '
        'ComboBox_Competence_Acrobatic
        '
        Me.ComboBox_Competence_Acrobatic.FormattingEnabled = True
        Me.ComboBox_Competence_Acrobatic.Location = New System.Drawing.Point(13, 14)
        Me.ComboBox_Competence_Acrobatic.Name = "ComboBox_Competence_Acrobatic"
        Me.ComboBox_Competence_Acrobatic.Size = New System.Drawing.Size(100, 33)
        Me.ComboBox_Competence_Acrobatic.TabIndex = 0
        '
        'ucSkillCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.ComboBox_Competence_Acrobatic)
        Me.Controls.Add(Me.Label_Competence_Acrobatic)
        Me.Name = "ucSkillCollection"
        Me.Size = New System.Drawing.Size(231, 501)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Competence_Acrobatic As Label
    Friend WithEvents ComboBox_Competence_Acrobatic As ComboBox
End Class
