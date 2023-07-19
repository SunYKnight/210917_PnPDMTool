<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEditMap
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
        lbMap = New Label()
        lbLocation = New Label()
        txtLocation = New TextBox()
        PictureBox_Map = New PictureBox()
        CType(PictureBox_Map, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbMap
        ' 
        lbMap.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbMap.Location = New Point(0, 3)
        lbMap.Margin = New Padding(4, 0, 4, 0)
        lbMap.Name = "lbMap"
        lbMap.Size = New Size(104, 67)
        lbMap.TabIndex = 91
        lbMap.Text = "Map"
        lbMap.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbLocation
        ' 
        lbLocation.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbLocation.Location = New Point(1150, 73)
        lbLocation.Margin = New Padding(4, 0, 4, 0)
        lbLocation.Name = "lbLocation"
        lbLocation.Size = New Size(129, 45)
        lbLocation.TabIndex = 95
        lbLocation.Text = "Location:"
        lbLocation.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtLocation
        ' 
        txtLocation.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtLocation.Location = New Point(1150, 123)
        txtLocation.Margin = New Padding(4, 5, 4, 5)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(464, 37)
        txtLocation.TabIndex = 96
        ' 
        ' PictureBox_Map
        ' 
        PictureBox_Map.Location = New Point(3, 73)
        PictureBox_Map.Name = "PictureBox_Map"
        PictureBox_Map.Size = New Size(1120, 1069)
        PictureBox_Map.TabIndex = 102
        PictureBox_Map.TabStop = False
        ' 
        ' ucEditMap
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBox_Map)
        Controls.Add(txtLocation)
        Controls.Add(lbLocation)
        Controls.Add(lbMap)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ucEditMap"
        Size = New Size(1633, 1145)
        CType(PictureBox_Map, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbMap As Label
    Friend WithEvents lbLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents PictureBox_Map As PictureBox
End Class
