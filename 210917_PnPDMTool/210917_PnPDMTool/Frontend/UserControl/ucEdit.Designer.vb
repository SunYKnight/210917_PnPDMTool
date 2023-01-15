<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucEdit(Of t As {UserControl})
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button_Disccard = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel_editUC = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_Disccard)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button_Save)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 654)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(995, 40)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Button_Disccard
        '
        Me.Button_Disccard.Location = New System.Drawing.Point(880, 3)
        Me.Button_Disccard.Name = "Button_Disccard"
        Me.Button_Disccard.Size = New System.Drawing.Size(112, 34)
        Me.Button_Disccard.TabIndex = 1
        Me.Button_Disccard.Text = "Discard"
        Me.Button_Disccard.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(762, 3)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(112, 34)
        Me.Button_Save.TabIndex = 2
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel_editUC
        '
        Me.FlowLayoutPanel_editUC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel_editUC.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel_editUC.Name = "FlowLayoutPanel_editUC"
        Me.FlowLayoutPanel_editUC.Size = New System.Drawing.Size(995, 654)
        Me.FlowLayoutPanel_editUC.TabIndex = 2
        '
        'ucEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel_editUC)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "ucEdit"
        Me.Size = New System.Drawing.Size(995, 694)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button_Disccard As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents FlowLayoutPanel_editUC As FlowLayoutPanel
End Class
