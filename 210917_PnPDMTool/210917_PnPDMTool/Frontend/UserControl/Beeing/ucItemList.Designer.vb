<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucItemList(Of t)
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
        Me.ListBox_items = New System.Windows.Forms.ListBox()
        Me.Label_title = New System.Windows.Forms.Label()
        Me.ComboBox_source = New System.Windows.Forms.ComboBox()
        Me.Button_add = New System.Windows.Forms.Button()
        Me.Button_remove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox_items
        '
        Me.ListBox_items.FormattingEnabled = True
        Me.ListBox_items.ItemHeight = 25
        Me.ListBox_items.Location = New System.Drawing.Point(3, 25)
        Me.ListBox_items.Name = "ListBox_items"
        Me.ListBox_items.Size = New System.Drawing.Size(184, 154)
        Me.ListBox_items.TabIndex = 0
        '
        'Label_title
        '
        Me.Label_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_title.Location = New System.Drawing.Point(0, 0)
        Me.Label_title.Name = "Label_title"
        Me.Label_title.Size = New System.Drawing.Size(190, 25)
        Me.Label_title.TabIndex = 6
        Me.Label_title.Text = "Titel"
        '
        'ComboBox_source
        '
        Me.ComboBox_source.FormattingEnabled = True
        Me.ComboBox_source.Location = New System.Drawing.Point(3, 180)
        Me.ComboBox_source.Name = "ComboBox_source"
        Me.ComboBox_source.Size = New System.Drawing.Size(184, 33)
        Me.ComboBox_source.TabIndex = 7
        '
        'Button_add
        '
        Me.Button_add.Location = New System.Drawing.Point(3, 214)
        Me.Button_add.Name = "Button_add"
        Me.Button_add.Size = New System.Drawing.Size(90, 35)
        Me.Button_add.TabIndex = 8
        Me.Button_add.Text = "Add"
        Me.Button_add.UseVisualStyleBackColor = True
        '
        'Button_remove
        '
        Me.Button_remove.Location = New System.Drawing.Point(97, 214)
        Me.Button_remove.Name = "Button_remove"
        Me.Button_remove.Size = New System.Drawing.Size(90, 35)
        Me.Button_remove.TabIndex = 9
        Me.Button_remove.Text = "Remove"
        Me.Button_remove.UseVisualStyleBackColor = True
        '
        'ucItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button_remove)
        Me.Controls.Add(Me.Button_add)
        Me.Controls.Add(Me.ComboBox_source)
        Me.Controls.Add(Me.Label_title)
        Me.Controls.Add(Me.ListBox_items)
        Me.Name = "ucItemList"
        Me.Size = New System.Drawing.Size(190, 250)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox_items As ListBox
    Friend WithEvents Label_title As Label
    Friend WithEvents ComboBox_source As ComboBox
    Friend WithEvents Button_add As Button
    Friend WithEvents Button_remove As Button
End Class
