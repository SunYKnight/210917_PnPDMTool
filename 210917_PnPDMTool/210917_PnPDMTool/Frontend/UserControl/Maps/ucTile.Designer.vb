<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTile
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
        TextBox_Name = New TextBox()
        FlowLayoutPanel_Effects = New FlowLayoutPanel()
        PictureBox_Image = New PictureBox()
        Panel1 = New Panel()
        CType(PictureBox_Image, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Dock = DockStyle.Bottom
        TextBox_Name.Enabled = False
        TextBox_Name.Location = New Point(0, 167)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(198, 31)
        TextBox_Name.TabIndex = 0
        TextBox_Name.Visible = False
        ' 
        ' FlowLayoutPanel_Effects
        ' 
        FlowLayoutPanel_Effects.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel_Effects.Dock = DockStyle.Right
        FlowLayoutPanel_Effects.Location = New Point(156, 0)
        FlowLayoutPanel_Effects.Name = "FlowLayoutPanel_Effects"
        FlowLayoutPanel_Effects.Size = New Size(42, 167)
        FlowLayoutPanel_Effects.TabIndex = 1
        FlowLayoutPanel_Effects.Visible = False
        ' 
        ' PictureBox_Image
        ' 
        PictureBox_Image.Dock = DockStyle.Fill
        PictureBox_Image.Location = New Point(0, 0)
        PictureBox_Image.Name = "PictureBox_Image"
        PictureBox_Image.Size = New Size(156, 167)
        PictureBox_Image.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox_Image.TabIndex = 3
        PictureBox_Image.TabStop = False
        PictureBox_Image.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(198, 198)
        Panel1.TabIndex = 4
        ' 
        ' ucTile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.Transparent
        Controls.Add(PictureBox_Image)
        Controls.Add(FlowLayoutPanel_Effects)
        Controls.Add(TextBox_Name)
        Controls.Add(Panel1)
        Margin = New Padding(0)
        Name = "ucTile"
        Size = New Size(198, 198)
        CType(PictureBox_Image, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents FlowLayoutPanel_Effects As FlowLayoutPanel
    Friend WithEvents PictureBox_Image As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
