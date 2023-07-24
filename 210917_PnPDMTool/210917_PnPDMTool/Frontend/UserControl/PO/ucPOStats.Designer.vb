<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPOStats
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
        NumericUpDown_hp_current = New NumericUpDown()
        Label1 = New Label()
        NumericUpDown_hp_max = New NumericUpDown()
        Label2 = New Label()
        PictureBox_po = New PictureBox()
        Label3 = New Label()
        Button_use_action = New Button()
        CType(NumericUpDown_hp_current, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown_hp_max, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox_po, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NumericUpDown_hp_current
        ' 
        NumericUpDown_hp_current.Location = New Point(73, 253)
        NumericUpDown_hp_current.Maximum = New [Decimal](New Integer() {9999, 0, 0, 0})
        NumericUpDown_hp_current.Name = "NumericUpDown_hp_current"
        NumericUpDown_hp_current.Size = New Size(74, 31)
        NumericUpDown_hp_current.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 255)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 25)
        Label1.TabIndex = 1
        Label1.Text = "HP:"
        ' 
        ' NumericUpDown_hp_max
        ' 
        NumericUpDown_hp_max.Location = New Point(188, 253)
        NumericUpDown_hp_max.Maximum = New [Decimal](New Integer() {9999, 0, 0, 0})
        NumericUpDown_hp_max.Minimum = New [Decimal](New Integer() {1, 0, 0, 0})
        NumericUpDown_hp_max.Name = "NumericUpDown_hp_max"
        NumericUpDown_hp_max.Size = New Size(74, 31)
        NumericUpDown_hp_max.TabIndex = 2
        NumericUpDown_hp_max.Value = New [Decimal](New Integer() {1, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(153, 255)
        Label2.Name = "Label2"
        Label2.Size = New Size(29, 25)
        Label2.TabIndex = 3
        Label2.Text = "of"
        ' 
        ' PictureBox1
        ' 
        PictureBox_po.Location = New Point(30, 27)
        PictureBox_po.Name = "PictureBox1"
        PictureBox_po.Size = New Size(164, 182)
        PictureBox_po.TabIndex = 4
        PictureBox_po.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 25)
        Label3.TabIndex = 5
        Label3.Text = "<Name>"
        ' 
        ' Button_use_action
        ' 
        Button_use_action.Location = New Point(28, 539)
        Button_use_action.Name = "Button_use_action"
        Button_use_action.Size = New Size(112, 34)
        Button_use_action.TabIndex = 6
        Button_use_action.Text = "Use"
        Button_use_action.UseVisualStyleBackColor = True
        ' 
        ' ucPOStats
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button_use_action)
        Controls.Add(Label3)
        Controls.Add(PictureBox_po)
        Controls.Add(Label2)
        Controls.Add(NumericUpDown_hp_max)
        Controls.Add(Label1)
        Controls.Add(NumericUpDown_hp_current)
        Name = "ucPOStats"
        Size = New Size(483, 598)
        CType(NumericUpDown_hp_current, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown_hp_max, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox_po, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NumericUpDown_hp_current As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown_hp_max As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox_po As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_use_action As Button
End Class
