<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTabDetailsControl
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
        Me.TabPage_General = New System.Windows.Forms.TabPage()
        Me.UcCharDetailsGeneral1 = New _210917_PnPDMTool.ucCharDetailsGeneral()
        Me.TabPage_Actions = New System.Windows.Forms.TabPage()
        Me.UcCharDetailsActions1 = New _210917_PnPDMTool.ucCharDetailsActions()
        Me.TabPage_Log = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_General.SuspendLayout()
        Me.TabPage_Actions.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_General)
        Me.TabControl1.Controls.Add(Me.TabPage_Actions)
        Me.TabControl1.Controls.Add(Me.TabPage_Log)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(884, 888)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage_General
        '
        Me.TabPage_General.Controls.Add(Me.UcCharDetailsGeneral1)
        Me.TabPage_General.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_General.Name = "TabPage_General"
        Me.TabPage_General.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_General.Size = New System.Drawing.Size(876, 850)
        Me.TabPage_General.TabIndex = 0
        Me.TabPage_General.Text = "General"
        Me.TabPage_General.UseVisualStyleBackColor = True
        '
        'UcCharDetailsGeneral1
        '
        Me.UcCharDetailsGeneral1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCharDetailsGeneral1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UcCharDetailsGeneral1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcCharDetailsGeneral1.Location = New System.Drawing.Point(3, 3)
        Me.UcCharDetailsGeneral1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcCharDetailsGeneral1.Name = "UcCharDetailsGeneral1"
        Me.UcCharDetailsGeneral1.Size = New System.Drawing.Size(870, 844)
        Me.UcCharDetailsGeneral1.TabIndex = 0
        '
        'TabPage_Actions
        '
        Me.TabPage_Actions.Controls.Add(Me.UcCharDetailsActions1)
        Me.TabPage_Actions.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_Actions.Name = "TabPage_Actions"
        Me.TabPage_Actions.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Actions.Size = New System.Drawing.Size(876, 850)
        Me.TabPage_Actions.TabIndex = 1
        Me.TabPage_Actions.Text = "Actions"
        Me.TabPage_Actions.UseVisualStyleBackColor = True
        '
        'UcCharDetailsActions1
        '
        Me.UcCharDetailsActions1.AllowDrop = True
        Me.UcCharDetailsActions1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcCharDetailsActions1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UcCharDetailsActions1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcCharDetailsActions1.Location = New System.Drawing.Point(3, 3)
        Me.UcCharDetailsActions1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcCharDetailsActions1.Name = "UcCharDetailsActions1"
        Me.UcCharDetailsActions1.Size = New System.Drawing.Size(870, 844)
        Me.UcCharDetailsActions1.TabIndex = 0
        '
        'TabPage_Log
        '
        Me.TabPage_Log.Location = New System.Drawing.Point(4, 34)
        Me.TabPage_Log.Name = "TabPage_Log"
        Me.TabPage_Log.Size = New System.Drawing.Size(876, 850)
        Me.TabPage_Log.TabIndex = 2
        Me.TabPage_Log.Text = "Log"
        Me.TabPage_Log.UseVisualStyleBackColor = True
        '
        'ucTabDetailsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ucTabDetailsControl"
        Me.Size = New System.Drawing.Size(884, 888)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_General.ResumeLayout(False)
        Me.TabPage_Actions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_General As TabPage
    Friend WithEvents TabPage_Actions As TabPage
    Friend WithEvents TabPage_Log As TabPage
    Friend WithEvents UcCharDetailsGeneral1 As ucCharDetailsGeneral
    Friend WithEvents UcCharDetailsActions1 As ucCharDetailsActions
    Friend WithEvents RichTextBox_Log As RichTextBox
End Class
