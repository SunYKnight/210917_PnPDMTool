<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucAction
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RichTextBox_Description = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AttackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_Type = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RichTextBox_name = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView_attackList = New System.Windows.Forms.ListView()
        Me.Button_add = New System.Windows.Forms.Button()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.Button_remove = New System.Windows.Forms.Button()
        CType(Me.AttackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox_Description
        '
        Me.RichTextBox_Description.Location = New System.Drawing.Point(112, 39)
        Me.RichTextBox_Description.MaxLength = 1000
        Me.RichTextBox_Description.Name = "RichTextBox_Description"
        Me.RichTextBox_Description.Size = New System.Drawing.Size(732, 100)
        Me.RichTextBox_Description.TabIndex = 0
        Me.RichTextBox_Description.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description:"
        '
        'AttackBindingSource
        '
        Me.AttackBindingSource.DataSource = GetType(_210917_PnPDMTool.AttackType)
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type:"
        '
        'ComboBox_Type
        '
        Me.ComboBox_Type.FormattingEnabled = True
        Me.ComboBox_Type.Location = New System.Drawing.Point(112, 145)
        Me.ComboBox_Type.Name = "ComboBox_Type"
        Me.ComboBox_Type.Size = New System.Drawing.Size(207, 33)
        Me.ComboBox_Type.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 25)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Name:"
        '
        'RichTextBox_name
        '
        Me.RichTextBox_name.Location = New System.Drawing.Point(112, 0)
        Me.RichTextBox_name.MaxLength = 100
        Me.RichTextBox_name.Multiline = False
        Me.RichTextBox_name.Name = "RichTextBox_name"
        Me.RichTextBox_name.Size = New System.Drawing.Size(732, 33)
        Me.RichTextBox_name.TabIndex = 23
        Me.RichTextBox_name.Text = ""
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Attack List:"
        '
        'ListView_attackList
        '
        Me.ListView_attackList.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView_attackList.Location = New System.Drawing.Point(112, 184)
        Me.ListView_attackList.MultiSelect = False
        Me.ListView_attackList.Name = "ListView_attackList"
        Me.ListView_attackList.Size = New System.Drawing.Size(732, 250)
        Me.ListView_attackList.TabIndex = 26
        Me.ListView_attackList.UseCompatibleStateImageBehavior = False
        Me.ListView_attackList.View = System.Windows.Forms.View.Details
        '
        'Button_add
        '
        Me.Button_add.Location = New System.Drawing.Point(420, 440)
        Me.Button_add.Name = "Button_add"
        Me.Button_add.Size = New System.Drawing.Size(112, 34)
        Me.Button_add.TabIndex = 27
        Me.Button_add.Text = "Add"
        Me.Button_add.UseVisualStyleBackColor = True
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(302, 440)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(112, 34)
        Me.Button_edit.TabIndex = 28
        Me.Button_edit.Text = "Edit"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'Button_remove
        '
        Me.Button_remove.Location = New System.Drawing.Point(184, 440)
        Me.Button_remove.Name = "Button_remove"
        Me.Button_remove.Size = New System.Drawing.Size(112, 34)
        Me.Button_remove.TabIndex = 29
        Me.Button_remove.Text = "Remove"
        Me.Button_remove.UseVisualStyleBackColor = True
        '
        'ucAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_remove)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Button_add)
        Me.Controls.Add(Me.ListView_attackList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RichTextBox_name)
        Me.Controls.Add(Me.ComboBox_Type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox_Description)
        Me.Name = "ucAction"
        Me.Size = New System.Drawing.Size(861, 481)
        CType(Me.AttackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox_Description As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AttackBindingSource As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_Type As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents RichTextBox_name As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView_attackList As ListView
    Friend WithEvents Button_add As Button
    Friend WithEvents Button_edit As Button
    Friend WithEvents Button_remove As Button
End Class
