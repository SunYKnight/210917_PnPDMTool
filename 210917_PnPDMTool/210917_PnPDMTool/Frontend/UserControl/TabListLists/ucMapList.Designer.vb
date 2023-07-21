<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMapList
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
        btnEdit = New Button()
        btnNew = New Button()
        lbOpponents = New Label()
        listView_Items = New ListView()
        Button_load = New Button()
        SuspendLayout()
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.Location = New Point(159, 738)
        btnEdit.Margin = New Padding(3, 2, 3, 2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(120, 55)
        btnEdit.TabIndex = 1
        btnEdit.Text = "edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnNew
        ' 
        btnNew.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnNew.Location = New Point(33, 738)
        btnNew.Margin = New Padding(3, 2, 3, 2)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(120, 55)
        btnNew.TabIndex = 2
        btnNew.Text = "new"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' lbOpponents
        ' 
        lbOpponents.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbOpponents.Location = New Point(3, 0)
        lbOpponents.Name = "lbOpponents"
        lbOpponents.Size = New Size(434, 70)
        lbOpponents.TabIndex = 3
        lbOpponents.Text = "Maps"
        lbOpponents.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' listView_Items
        ' 
        listView_Items.Activation = ItemActivation.OneClick
        listView_Items.BackColor = Color.White
        listView_Items.BorderStyle = BorderStyle.None
        listView_Items.Location = New Point(21, 92)
        listView_Items.Margin = New Padding(4, 5, 4, 5)
        listView_Items.Name = "listView_Items"
        listView_Items.Size = New Size(400, 627)
        listView_Items.TabIndex = 4
        listView_Items.UseCompatibleStateImageBehavior = False
        listView_Items.View = View.Details
        ' 
        ' Button_load
        ' 
        Button_load.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button_load.Location = New Point(285, 738)
        Button_load.Margin = New Padding(3, 2, 3, 2)
        Button_load.Name = "Button_load"
        Button_load.Size = New Size(120, 55)
        Button_load.TabIndex = 5
        Button_load.Text = "load"
        Button_load.UseVisualStyleBackColor = True
        ' 
        ' ucMapList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        Controls.Add(Button_load)
        Controls.Add(listView_Items)
        Controls.Add(lbOpponents)
        Controls.Add(btnNew)
        Controls.Add(btnEdit)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ucMapList"
        Size = New Size(440, 817)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents lbOpponents As Label
    Friend WithEvents listView_Items As ListView
    Friend WithEvents Button_load As Button
End Class
