<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPlayer
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
        Me.lbPlayer = New System.Windows.Forms.Label()
        Me.txtAc = New System.Windows.Forms.TextBox()
        Me.lbAc = New System.Windows.Forms.Label()
        Me.txtCha = New System.Windows.Forms.TextBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.txtWis = New System.Windows.Forms.TextBox()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.txtDex = New System.Windows.Forms.TextBox()
        Me.txtStr = New System.Windows.Forms.TextBox()
        Me.lbCha = New System.Windows.Forms.Label()
        Me.lbInt = New System.Windows.Forms.Label()
        Me.lbWis = New System.Windows.Forms.Label()
        Me.lbCon = New System.Windows.Forms.Label()
        Me.lbDex = New System.Windows.Forms.Label()
        Me.lbStr = New System.Windows.Forms.Label()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.lbImage = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbHP = New System.Windows.Forms.Label()
        Me.txtHp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbPlayer
        '
        Me.lbPlayer.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbPlayer.Location = New System.Drawing.Point(3, 0)
        Me.lbPlayer.Name = "lbPlayer"
        Me.lbPlayer.Size = New System.Drawing.Size(73, 40)
        Me.lbPlayer.TabIndex = 2
        Me.lbPlayer.Text = "Player"
        Me.lbPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAc
        '
        Me.txtAc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAc.Location = New System.Drawing.Point(79, 283)
        Me.txtAc.Name = "txtAc"
        Me.txtAc.Size = New System.Drawing.Size(50, 27)
        Me.txtAc.TabIndex = 29
        '
        'lbAc
        '
        Me.lbAc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbAc.Location = New System.Drawing.Point(3, 283)
        Me.lbAc.Name = "lbAc"
        Me.lbAc.Size = New System.Drawing.Size(50, 27)
        Me.lbAc.TabIndex = 28
        Me.lbAc.Text = "AC"
        Me.lbAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCha
        '
        Me.txtCha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCha.Location = New System.Drawing.Point(79, 217)
        Me.txtCha.Name = "txtCha"
        Me.txtCha.Size = New System.Drawing.Size(50, 27)
        Me.txtCha.TabIndex = 27
        '
        'txtInt
        '
        Me.txtInt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInt.Location = New System.Drawing.Point(79, 184)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(50, 27)
        Me.txtInt.TabIndex = 26
        '
        'txtWis
        '
        Me.txtWis.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWis.Location = New System.Drawing.Point(79, 151)
        Me.txtWis.Name = "txtWis"
        Me.txtWis.Size = New System.Drawing.Size(50, 27)
        Me.txtWis.TabIndex = 25
        '
        'txtCon
        '
        Me.txtCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCon.Location = New System.Drawing.Point(79, 118)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(50, 27)
        Me.txtCon.TabIndex = 24
        '
        'txtDex
        '
        Me.txtDex.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDex.Location = New System.Drawing.Point(79, 85)
        Me.txtDex.Name = "txtDex"
        Me.txtDex.Size = New System.Drawing.Size(50, 27)
        Me.txtDex.TabIndex = 23
        '
        'txtStr
        '
        Me.txtStr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStr.Location = New System.Drawing.Point(79, 52)
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(50, 27)
        Me.txtStr.TabIndex = 22
        '
        'lbCha
        '
        Me.lbCha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbCha.Location = New System.Drawing.Point(3, 217)
        Me.lbCha.Name = "lbCha"
        Me.lbCha.Size = New System.Drawing.Size(70, 27)
        Me.lbCha.TabIndex = 21
        Me.lbCha.Text = "CHA"
        Me.lbCha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbInt
        '
        Me.lbInt.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbInt.Location = New System.Drawing.Point(3, 184)
        Me.lbInt.Name = "lbInt"
        Me.lbInt.Size = New System.Drawing.Size(70, 27)
        Me.lbInt.TabIndex = 20
        Me.lbInt.Text = "INT"
        Me.lbInt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbWis
        '
        Me.lbWis.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbWis.Location = New System.Drawing.Point(3, 151)
        Me.lbWis.Name = "lbWis"
        Me.lbWis.Size = New System.Drawing.Size(70, 27)
        Me.lbWis.TabIndex = 19
        Me.lbWis.Text = "WIS"
        Me.lbWis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCon
        '
        Me.lbCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbCon.Location = New System.Drawing.Point(3, 118)
        Me.lbCon.Name = "lbCon"
        Me.lbCon.Size = New System.Drawing.Size(70, 27)
        Me.lbCon.TabIndex = 18
        Me.lbCon.Text = "CON"
        Me.lbCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDex
        '
        Me.lbDex.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbDex.Location = New System.Drawing.Point(3, 85)
        Me.lbDex.Name = "lbDex"
        Me.lbDex.Size = New System.Drawing.Size(70, 27)
        Me.lbDex.TabIndex = 17
        Me.lbDex.Text = "DEX"
        Me.lbDex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbStr
        '
        Me.lbStr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbStr.Location = New System.Drawing.Point(3, 52)
        Me.lbStr.Name = "lbStr"
        Me.lbStr.Size = New System.Drawing.Size(70, 27)
        Me.lbStr.TabIndex = 16
        Me.lbStr.Text = "STR"
        Me.lbStr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImage
        '
        Me.txtImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtImage.Location = New System.Drawing.Point(266, 89)
        Me.txtImage.Multiline = True
        Me.txtImage.Name = "txtImage"
        Me.txtImage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImage.Size = New System.Drawing.Size(963, 27)
        Me.txtImage.TabIndex = 90
        '
        'lbImage
        '
        Me.lbImage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbImage.Location = New System.Drawing.Point(190, 89)
        Me.lbImage.Name = "lbImage"
        Me.lbImage.Size = New System.Drawing.Size(70, 27)
        Me.lbImage.TabIndex = 89
        Me.lbImage.Text = "Image:"
        Me.lbImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(266, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(963, 27)
        Me.txtName.TabIndex = 88
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbName.Location = New System.Drawing.Point(190, 56)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(70, 27)
        Me.lbName.TabIndex = 87
        Me.lbName.Text = "Name:"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDiscard
        '
        Me.btnDiscard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDiscard.Location = New System.Drawing.Point(1064, 697)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(75, 30)
        Me.btnDiscard.TabIndex = 92
        Me.btnDiscard.Text = "discard"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(1154, 697)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 91
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbHP
        '
        Me.lbHP.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbHP.Location = New System.Drawing.Point(3, 316)
        Me.lbHP.Name = "lbHP"
        Me.lbHP.Size = New System.Drawing.Size(50, 27)
        Me.lbHP.TabIndex = 93
        Me.lbHP.Text = "HP"
        Me.lbHP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHp
        '
        Me.txtHp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtHp.Location = New System.Drawing.Point(79, 316)
        Me.txtHp.Name = "txtHp"
        Me.txtHp.Size = New System.Drawing.Size(50, 27)
        Me.txtHp.TabIndex = 94
        '
        'ucPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtHp)
        Me.Controls.Add(Me.lbHP)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtImage)
        Me.Controls.Add(Me.lbImage)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.txtAc)
        Me.Controls.Add(Me.lbAc)
        Me.Controls.Add(Me.txtCha)
        Me.Controls.Add(Me.txtInt)
        Me.Controls.Add(Me.txtWis)
        Me.Controls.Add(Me.txtCon)
        Me.Controls.Add(Me.txtDex)
        Me.Controls.Add(Me.txtStr)
        Me.Controls.Add(Me.lbCha)
        Me.Controls.Add(Me.lbInt)
        Me.Controls.Add(Me.lbWis)
        Me.Controls.Add(Me.lbCon)
        Me.Controls.Add(Me.lbDex)
        Me.Controls.Add(Me.lbStr)
        Me.Controls.Add(Me.lbPlayer)
        Me.Name = "ucPlayer"
        Me.Size = New System.Drawing.Size(1240, 741)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbPlayer As Label
    Friend WithEvents txtAc As TextBox
    Friend WithEvents lbAc As Label
    Friend WithEvents txtCha As TextBox
    Friend WithEvents txtInt As TextBox
    Friend WithEvents txtWis As TextBox
    Friend WithEvents txtCon As TextBox
    Friend WithEvents txtDex As TextBox
    Friend WithEvents txtStr As TextBox
    Friend WithEvents lbCha As Label
    Friend WithEvents lbInt As Label
    Friend WithEvents lbWis As Label
    Friend WithEvents lbCon As Label
    Friend WithEvents lbDex As Label
    Friend WithEvents lbStr As Label
    Friend WithEvents txtImage As TextBox
    Friend WithEvents lbImage As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbName As Label
    Friend WithEvents btnDiscard As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lbHP As Label
    Friend WithEvents txtHp As TextBox
End Class
