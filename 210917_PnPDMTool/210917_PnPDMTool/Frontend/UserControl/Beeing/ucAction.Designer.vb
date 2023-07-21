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
        components = New ComponentModel.Container()
        RichTextBox_Description = New RichTextBox()
        Label1 = New Label()
        AttackBindingSource = New BindingSource(components)
        Label2 = New Label()
        ComboBox_Type = New ComboBox()
        Label13 = New Label()
        RichTextBox_name = New RichTextBox()
        Label3 = New Label()
        ListView_attackList = New ListView()
        Button_add = New Button()
        Button_edit = New Button()
        Button_remove = New Button()
        CType(AttackBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' RichTextBox_Description
        ' 
        RichTextBox_Description.Location = New Point(112, 39)
        RichTextBox_Description.MaxLength = 1000
        RichTextBox_Description.Name = "RichTextBox_Description"
        RichTextBox_Description.Size = New Size(951, 100)
        RichTextBox_Description.TabIndex = 0
        RichTextBox_Description.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 1
        Label1.Text = "Description:"
        ' 
        ' AttackBindingSource
        ' 
        AttackBindingSource.DataSource = GetType(BaseAttack)
        ' 
        ' Label2
        ' 
        Label2.AccessibleRole = AccessibleRole.IpAddress
        Label2.AutoSize = True
        Label2.Location = New Point(0, 148)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 25)
        Label2.TabIndex = 2
        Label2.Text = "Type:"
        ' 
        ' ComboBox_Type
        ' 
        ComboBox_Type.FormattingEnabled = True
        ComboBox_Type.Location = New Point(112, 145)
        ComboBox_Type.Name = "ComboBox_Type"
        ComboBox_Type.Size = New Size(207, 33)
        ComboBox_Type.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(63, 25)
        Label13.TabIndex = 24
        Label13.Text = "Name:"
        ' 
        ' RichTextBox_name
        ' 
        RichTextBox_name.Location = New Point(112, 0)
        RichTextBox_name.MaxLength = 100
        RichTextBox_name.Multiline = False
        RichTextBox_name.Name = "RichTextBox_name"
        RichTextBox_name.Size = New Size(951, 33)
        RichTextBox_name.TabIndex = 23
        RichTextBox_name.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AccessibleRole = AccessibleRole.IpAddress
        Label3.AutoSize = True
        Label3.Location = New Point(0, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 25
        Label3.Text = "Attack List:"
        ' 
        ' ListView_attackList
        ' 
        ListView_attackList.Activation = ItemActivation.OneClick
        ListView_attackList.Location = New Point(112, 184)
        ListView_attackList.MultiSelect = False
        ListView_attackList.Name = "ListView_attackList"
        ListView_attackList.Size = New Size(951, 250)
        ListView_attackList.TabIndex = 26
        ListView_attackList.UseCompatibleStateImageBehavior = False
        ListView_attackList.View = View.Details
        ' 
        ' Button_add
        ' 
        Button_add.Location = New Point(951, 444)
        Button_add.Name = "Button_add"
        Button_add.Size = New Size(112, 34)
        Button_add.TabIndex = 27
        Button_add.Text = "Add"
        Button_add.UseVisualStyleBackColor = True
        ' 
        ' Button_edit
        ' 
        Button_edit.Location = New Point(833, 444)
        Button_edit.Name = "Button_edit"
        Button_edit.Size = New Size(112, 34)
        Button_edit.TabIndex = 28
        Button_edit.Text = "Edit"
        Button_edit.UseVisualStyleBackColor = True
        ' 
        ' Button_remove
        ' 
        Button_remove.Location = New Point(715, 444)
        Button_remove.Name = "Button_remove"
        Button_remove.Size = New Size(112, 34)
        Button_remove.TabIndex = 29
        Button_remove.Text = "Remove"
        Button_remove.UseVisualStyleBackColor = True
        ' 
        ' ucAction
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(Button_remove)
        Controls.Add(Button_edit)
        Controls.Add(Button_add)
        Controls.Add(ListView_attackList)
        Controls.Add(Label3)
        Controls.Add(Label13)
        Controls.Add(RichTextBox_name)
        Controls.Add(ComboBox_Type)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RichTextBox_Description)
        MinimumSize = New Size(1066, 481)
        Name = "ucAction"
        Size = New Size(1066, 481)
        CType(AttackBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
