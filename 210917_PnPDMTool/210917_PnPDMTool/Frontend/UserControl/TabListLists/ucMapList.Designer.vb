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
        SuspendLayout()
        ' 
        ' btnEditOpponent
        ' 
        btnEdit.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.Location = New Point(218, 740)
        btnEdit.Margin = New Padding(3, 2, 3, 2)
        btnEdit.Name = "btnEditOpponent"
        btnEdit.Size = New Size(203, 55)
        btnEdit.TabIndex = 1
        btnEdit.Text = "edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnNewOpponent
        ' 
        btnNew.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnNew.Location = New Point(20, 740)
        btnNew.Margin = New Padding(3, 2, 3, 2)
        btnNew.Name = "btnNewOpponent"
        btnNew.Size = New Size(191, 55)
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
        ' listView_Opponents
        ' 
        listView_Items.Activation = ItemActivation.OneClick
        listView_Items.BackColor = Color.White
        listView_Items.BorderStyle = BorderStyle.None
        listView_Items.Location = New Point(21, 92)
        listView_Items.Margin = New Padding(4, 5, 4, 5)
        listView_Items.Name = "listView_Opponents"
        listView_Items.Size = New Size(400, 627)
        listView_Items.TabIndex = 4
        listView_Items.UseCompatibleStateImageBehavior = False
        listView_Items.View = View.Details
        ' 
        ' ucMapList
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
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
End Class
