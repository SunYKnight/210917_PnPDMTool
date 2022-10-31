<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTabEditBeeing
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_general = New System.Windows.Forms.TabPage()
        Me.TabPage_details = New System.Windows.Forms.TabPage()
        Me.UcEditMonsterGeneral1 = New _210917_PnPDMTool.ucEditMonsterGeneral()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_general.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_general)
        Me.TabControl1.Controls.Add(Me.TabPage_details)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(751, 682)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_general
        '
        Me.TabPage_general.Controls.Add(Me.UcEditMonsterGeneral1)
        Me.TabPage_general.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_general.Name = "TabPage_general"
        Me.TabPage_general.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_general.Size = New System.Drawing.Size(743, 644)
        Me.TabPage_general.TabIndex = 0
        Me.TabPage_general.Text = "General"
        Me.TabPage_general.UseVisualStyleBackColor = True
        '
        'TabPage_details
        '
        Me.TabPage_details.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_details.Name = "TabPage_details"
        Me.TabPage_details.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_details.Size = New System.Drawing.Size(743, 644)
        Me.TabPage_details.TabIndex = 1
        Me.TabPage_details.Text = "Details"
        Me.TabPage_details.UseVisualStyleBackColor = True
        '
        'UcEditMonsterGeneral1
        '
        Me.UcEditMonsterGeneral1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcEditMonsterGeneral1.Location = New System.Drawing.Point(3, 3)
        Me.UcEditMonsterGeneral1.Name = "UcEditMonsterGeneral1"
        Me.UcEditMonsterGeneral1.Size = New System.Drawing.Size(737, 638)
        Me.UcEditMonsterGeneral1.TabIndex = 0
        '
        'ucTabEditBeeing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ucTabEditBeeing"
        Me.Size = New System.Drawing.Size(751, 682)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_general.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_general As TabPage
    Friend WithEvents TabPage_details As TabPage
    Friend WithEvents UcEditMonsterGeneral1 As ucEditMonsterGeneral
End Class
