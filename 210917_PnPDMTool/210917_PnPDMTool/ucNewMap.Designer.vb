<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNewMap
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
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.lbImage = New System.Windows.Forms.Label()
        Me.lbMap = New System.Windows.Forms.Label()
        Me.lbSizeOfTiles = New System.Windows.Forms.Label()
        Me.lbLocation = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.cbVeryLarge = New System.Windows.Forms.CheckBox()
        Me.cbLarge = New System.Windows.Forms.CheckBox()
        Me.cbMedium = New System.Windows.Forms.CheckBox()
        Me.cbSmall = New System.Windows.Forms.CheckBox()
        Me.cbVerySmall = New System.Windows.Forms.CheckBox()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtImage
        '
        Me.txtImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtImage.Location = New System.Drawing.Point(126, 101)
        Me.txtImage.Multiline = True
        Me.txtImage.Name = "txtImage"
        Me.txtImage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImage.Size = New System.Drawing.Size(1014, 27)
        Me.txtImage.TabIndex = 93
        '
        'lbImage
        '
        Me.lbImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbImage.Location = New System.Drawing.Point(5, 101)
        Me.lbImage.Name = "lbImage"
        Me.lbImage.Size = New System.Drawing.Size(70, 27)
        Me.lbImage.TabIndex = 92
        Me.lbImage.Text = "Image:"
        Me.lbImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbMap
        '
        Me.lbMap.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbMap.Location = New System.Drawing.Point(0, 2)
        Me.lbMap.Name = "lbMap"
        Me.lbMap.Size = New System.Drawing.Size(73, 40)
        Me.lbMap.TabIndex = 91
        Me.lbMap.Text = "Map"
        Me.lbMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbSizeOfTiles
        '
        Me.lbSizeOfTiles.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbSizeOfTiles.Location = New System.Drawing.Point(5, 146)
        Me.lbSizeOfTiles.Name = "lbSizeOfTiles"
        Me.lbSizeOfTiles.Size = New System.Drawing.Size(122, 27)
        Me.lbSizeOfTiles.TabIndex = 94
        Me.lbSizeOfTiles.Text = "Size of Tiles:"
        Me.lbSizeOfTiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLocation
        '
        Me.lbLocation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbLocation.Location = New System.Drawing.Point(5, 60)
        Me.lbLocation.Name = "lbLocation"
        Me.lbLocation.Size = New System.Drawing.Size(70, 27)
        Me.lbLocation.TabIndex = 95
        Me.lbLocation.Text = "Location:"
        Me.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLocation.Location = New System.Drawing.Point(126, 60)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(1014, 27)
        Me.txtLocation.TabIndex = 96
        '
        'cbVeryLarge
        '
        Me.cbVeryLarge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbVeryLarge.Location = New System.Drawing.Point(126, 146)
        Me.cbVeryLarge.Name = "cbVeryLarge"
        Me.cbVeryLarge.Size = New System.Drawing.Size(147, 27)
        Me.cbVeryLarge.TabIndex = 97
        Me.cbVeryLarge.Text = "very large"
        Me.cbVeryLarge.UseVisualStyleBackColor = True
        '
        'cbLarge
        '
        Me.cbLarge.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbLarge.Location = New System.Drawing.Point(279, 147)
        Me.cbLarge.Name = "cbLarge"
        Me.cbLarge.Size = New System.Drawing.Size(81, 27)
        Me.cbLarge.TabIndex = 98
        Me.cbLarge.Text = "large"
        Me.cbLarge.UseVisualStyleBackColor = True
        '
        'cbMedium
        '
        Me.cbMedium.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbMedium.Location = New System.Drawing.Point(400, 147)
        Me.cbMedium.Name = "cbMedium"
        Me.cbMedium.Size = New System.Drawing.Size(108, 27)
        Me.cbMedium.TabIndex = 99
        Me.cbMedium.Text = "medium"
        Me.cbMedium.UseVisualStyleBackColor = True
        '
        'cbSmall
        '
        Me.cbSmall.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbSmall.Location = New System.Drawing.Point(563, 147)
        Me.cbSmall.Name = "cbSmall"
        Me.cbSmall.Size = New System.Drawing.Size(81, 27)
        Me.cbSmall.TabIndex = 100
        Me.cbSmall.Text = "small"
        Me.cbSmall.UseVisualStyleBackColor = True
        '
        'cbVerySmall
        '
        Me.cbVerySmall.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbVerySmall.Location = New System.Drawing.Point(720, 147)
        Me.cbVerySmall.Name = "cbVerySmall"
        Me.cbVerySmall.Size = New System.Drawing.Size(107, 27)
        Me.cbVerySmall.TabIndex = 101
        Me.cbVerySmall.Text = "very small"
        Me.cbVerySmall.UseVisualStyleBackColor = True
        '
        'btnDiscard
        '
        Me.btnDiscard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDiscard.Location = New System.Drawing.Point(964, 645)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(75, 30)
        Me.btnDiscard.TabIndex = 103
        Me.btnDiscard.Text = "discard"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(1045, 645)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 102
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ucNewMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbVerySmall)
        Me.Controls.Add(Me.cbSmall)
        Me.Controls.Add(Me.cbMedium)
        Me.Controls.Add(Me.cbLarge)
        Me.Controls.Add(Me.cbVeryLarge)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lbLocation)
        Me.Controls.Add(Me.lbSizeOfTiles)
        Me.Controls.Add(Me.txtImage)
        Me.Controls.Add(Me.lbImage)
        Me.Controls.Add(Me.lbMap)
        Me.Name = "ucNewMap"
        Me.Size = New System.Drawing.Size(1143, 687)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtImage As TextBox
    Friend WithEvents lbImage As Label
    Friend WithEvents lbMap As Label
    Friend WithEvents lbSizeOfTiles As Label
    Friend WithEvents lbLocation As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents cbVeryLarge As CheckBox
    Friend WithEvents cbLarge As CheckBox
    Friend WithEvents cbMedium As CheckBox
    Friend WithEvents cbSmall As CheckBox
    Friend WithEvents cbVerySmall As CheckBox
    Friend WithEvents btnDiscard As Button
    Friend WithEvents btnSave As Button
End Class
