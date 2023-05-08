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
        TabControl_beeing = New TabControl()
        TabPage_Stats = New TabPage()
        TabPage_Actions = New TabPage()
        TabPage_Meta = New TabPage()
        TabControl_beeing.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl_beeing
        ' 
        TabControl_beeing.Controls.Add(TabPage_Meta)
        TabControl_beeing.Controls.Add(TabPage_Stats)
        TabControl_beeing.Controls.Add(TabPage_Actions)
        TabControl_beeing.Dock = DockStyle.Fill
        TabControl_beeing.Location = New Point(0, 0)
        TabControl_beeing.Name = "TabControl_beeing"
        TabControl_beeing.SelectedIndex = 0
        TabControl_beeing.Size = New Size(1500, 1200)
        TabControl_beeing.TabIndex = 0
        ' 
        ' TabPage_Stats
        ' 
        TabPage_Stats.Location = New Point(4, 34)
        TabPage_Stats.Name = "TabPage_Stats"
        TabPage_Stats.Padding = New Padding(3)
        TabPage_Stats.Size = New Size(1492, 1162)
        TabPage_Stats.TabIndex = 0
        TabPage_Stats.Text = "Stats"
        TabPage_Stats.UseVisualStyleBackColor = True
        ' 
        ' TabPage_Actions
        ' 
        TabPage_Actions.Location = New Point(4, 34)
        TabPage_Actions.Name = "TabPage_Actions"
        TabPage_Actions.Padding = New Padding(3)
        TabPage_Actions.Size = New Size(1492, 1162)
        TabPage_Actions.TabIndex = 1
        TabPage_Actions.Text = "Actions"
        TabPage_Actions.UseVisualStyleBackColor = True
        ' 
        ' TabPage_Meta
        ' 
        TabPage_Meta.Location = New Point(4, 34)
        TabPage_Meta.Name = "TabPage_Meta"
        TabPage_Meta.Padding = New Padding(3)
        TabPage_Meta.Size = New Size(1492, 1162)
        TabPage_Meta.TabIndex = 2
        TabPage_Meta.Text = "Meta"
        TabPage_Meta.UseVisualStyleBackColor = True
        ' 
        ' ucBeeing
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TabControl_beeing)
        Name = "ucBeeing"
        Size = New Size(1500, 1200)
        TabControl_beeing.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl_beeing As TabControl
    Friend WithEvents TabPage_Stats As TabPage
    Friend WithEvents TabPage_Actions As TabPage
    Friend WithEvents TabPage_Meta As TabPage
End Class
