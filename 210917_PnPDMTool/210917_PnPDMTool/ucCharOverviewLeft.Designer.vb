<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucCharOverviewLeft
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
        Me.lbName = New System.Windows.Forms.Label()
        Me.btnActions = New System.Windows.Forms.Button()
        Me.btnLegendaryActions = New System.Windows.Forms.Button()
        Me.txtAbilities = New System.Windows.Forms.TextBox()
        Me.txtAbilitiesScore = New System.Windows.Forms.TextBox()
        Me.txtAbilitiesModifier = New System.Windows.Forms.TextBox()
        Me.pictureBoxChar = New System.Windows.Forms.PictureBox()
        Me.txtInfo1 = New System.Windows.Forms.TextBox()
        Me.txtMPTitle = New System.Windows.Forms.TextBox()
        Me.txtMPLv1Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv2Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv4Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv3Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv6Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv5Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv8Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv7Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv9Title = New System.Windows.Forms.TextBox()
        Me.txtMPLv9 = New System.Windows.Forms.TextBox()
        Me.txtMPLv8 = New System.Windows.Forms.TextBox()
        Me.txtMPLv7 = New System.Windows.Forms.TextBox()
        Me.txtMPLv6 = New System.Windows.Forms.TextBox()
        Me.txtMPLv5 = New System.Windows.Forms.TextBox()
        Me.txtMPLv4 = New System.Windows.Forms.TextBox()
        Me.txtMPLv3 = New System.Windows.Forms.TextBox()
        Me.txtMPLv2 = New System.Windows.Forms.TextBox()
        Me.txtMPLv1 = New System.Windows.Forms.TextBox()
        Me.txtAbilitiesTitle = New System.Windows.Forms.TextBox()
        Me.txtACTitle = New System.Windows.Forms.TextBox()
        Me.txtHPTitle = New System.Windows.Forms.TextBox()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.TxtHPmax = New System.Windows.Forms.TextBox()
        CType(Me.pictureBoxChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbName.Location = New System.Drawing.Point(2, 0)
        Me.lbName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(191, 40)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Name"
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnActions
        '
        Me.btnActions.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnActions.Location = New System.Drawing.Point(4, 473)
        Me.btnActions.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnActions.Name = "btnActions"
        Me.btnActions.Size = New System.Drawing.Size(179, 30)
        Me.btnActions.TabIndex = 1
        Me.btnActions.Text = "actions"
        Me.btnActions.UseVisualStyleBackColor = True
        '
        'btnLegendaryActions
        '
        Me.btnLegendaryActions.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLegendaryActions.Location = New System.Drawing.Point(4, 427)
        Me.btnLegendaryActions.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnLegendaryActions.Name = "btnLegendaryActions"
        Me.btnLegendaryActions.Size = New System.Drawing.Size(179, 30)
        Me.btnLegendaryActions.TabIndex = 2
        Me.btnLegendaryActions.Text = "legendary actions"
        Me.btnLegendaryActions.UseVisualStyleBackColor = True
        '
        'txtAbilities
        '
        Me.txtAbilities.BackColor = System.Drawing.Color.White
        Me.txtAbilities.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbilities.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAbilities.Location = New System.Drawing.Point(4, 302)
        Me.txtAbilities.Multiline = True
        Me.txtAbilities.Name = "txtAbilities"
        Me.txtAbilities.ReadOnly = True
        Me.txtAbilities.Size = New System.Drawing.Size(50, 120)
        Me.txtAbilities.TabIndex = 3
        Me.txtAbilities.Text = "STR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DEX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CON" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WIS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CHA"
        '
        'txtAbilitiesScore
        '
        Me.txtAbilitiesScore.BackColor = System.Drawing.Color.White
        Me.txtAbilitiesScore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbilitiesScore.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAbilitiesScore.Location = New System.Drawing.Point(51, 302)
        Me.txtAbilitiesScore.Multiline = True
        Me.txtAbilitiesScore.Name = "txtAbilitiesScore"
        Me.txtAbilitiesScore.ReadOnly = True
        Me.txtAbilitiesScore.Size = New System.Drawing.Size(50, 120)
        Me.txtAbilitiesScore.TabIndex = 4
        '
        'txtAbilitiesModifier
        '
        Me.txtAbilitiesModifier.BackColor = System.Drawing.Color.White
        Me.txtAbilitiesModifier.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbilitiesModifier.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtAbilitiesModifier.Location = New System.Drawing.Point(98, 302)
        Me.txtAbilitiesModifier.Multiline = True
        Me.txtAbilitiesModifier.Name = "txtAbilitiesModifier"
        Me.txtAbilitiesModifier.ReadOnly = True
        Me.txtAbilitiesModifier.Size = New System.Drawing.Size(50, 120)
        Me.txtAbilitiesModifier.TabIndex = 5
        '
        'pictureBoxChar
        '
        Me.pictureBoxChar.BackColor = System.Drawing.Color.White
        Me.pictureBoxChar.Location = New System.Drawing.Point(2, 43)
        Me.pictureBoxChar.Name = "pictureBoxChar"
        Me.pictureBoxChar.Size = New System.Drawing.Size(179, 233)
        Me.pictureBoxChar.TabIndex = 6
        Me.pictureBoxChar.TabStop = False
        '
        'txtInfo1
        '
        Me.txtInfo1.BackColor = System.Drawing.Color.White
        Me.txtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtInfo1.Location = New System.Drawing.Point(187, 114)
        Me.txtInfo1.Multiline = True
        Me.txtInfo1.Name = "txtInfo1"
        Me.txtInfo1.ReadOnly = True
        Me.txtInfo1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo1.Size = New System.Drawing.Size(418, 389)
        Me.txtInfo1.TabIndex = 7
        '
        'txtMPTitle
        '
        Me.txtMPTitle.BackColor = System.Drawing.Color.White
        Me.txtMPTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPTitle.Location = New System.Drawing.Point(187, 38)
        Me.txtMPTitle.Multiline = True
        Me.txtMPTitle.Name = "txtMPTitle"
        Me.txtMPTitle.ReadOnly = True
        Me.txtMPTitle.Size = New System.Drawing.Size(270, 25)
        Me.txtMPTitle.TabIndex = 8
        Me.txtMPTitle.Text = "MP"
        Me.txtMPTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv1Title
        '
        Me.txtMPLv1Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv1Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv1Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv1Title.Location = New System.Drawing.Point(187, 63)
        Me.txtMPLv1Title.Multiline = True
        Me.txtMPLv1Title.Name = "txtMPLv1Title"
        Me.txtMPLv1Title.ReadOnly = True
        Me.txtMPLv1Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv1Title.TabIndex = 9
        Me.txtMPLv1Title.Text = "1"
        Me.txtMPLv1Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv2Title
        '
        Me.txtMPLv2Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv2Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv2Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv2Title.Location = New System.Drawing.Point(217, 63)
        Me.txtMPLv2Title.Multiline = True
        Me.txtMPLv2Title.Name = "txtMPLv2Title"
        Me.txtMPLv2Title.ReadOnly = True
        Me.txtMPLv2Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv2Title.TabIndex = 10
        Me.txtMPLv2Title.Text = "2"
        Me.txtMPLv2Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv4Title
        '
        Me.txtMPLv4Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv4Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv4Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv4Title.Location = New System.Drawing.Point(277, 63)
        Me.txtMPLv4Title.Multiline = True
        Me.txtMPLv4Title.Name = "txtMPLv4Title"
        Me.txtMPLv4Title.ReadOnly = True
        Me.txtMPLv4Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv4Title.TabIndex = 12
        Me.txtMPLv4Title.Text = "4"
        Me.txtMPLv4Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv3Title
        '
        Me.txtMPLv3Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv3Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv3Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv3Title.Location = New System.Drawing.Point(247, 63)
        Me.txtMPLv3Title.Multiline = True
        Me.txtMPLv3Title.Name = "txtMPLv3Title"
        Me.txtMPLv3Title.ReadOnly = True
        Me.txtMPLv3Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv3Title.TabIndex = 11
        Me.txtMPLv3Title.Text = "3"
        Me.txtMPLv3Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv6Title
        '
        Me.txtMPLv6Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv6Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv6Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv6Title.Location = New System.Drawing.Point(337, 63)
        Me.txtMPLv6Title.Multiline = True
        Me.txtMPLv6Title.Name = "txtMPLv6Title"
        Me.txtMPLv6Title.ReadOnly = True
        Me.txtMPLv6Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv6Title.TabIndex = 14
        Me.txtMPLv6Title.Text = "6"
        Me.txtMPLv6Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv5Title
        '
        Me.txtMPLv5Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv5Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv5Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv5Title.Location = New System.Drawing.Point(307, 63)
        Me.txtMPLv5Title.Multiline = True
        Me.txtMPLv5Title.Name = "txtMPLv5Title"
        Me.txtMPLv5Title.ReadOnly = True
        Me.txtMPLv5Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv5Title.TabIndex = 13
        Me.txtMPLv5Title.Text = "5"
        Me.txtMPLv5Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv8Title
        '
        Me.txtMPLv8Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv8Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv8Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv8Title.Location = New System.Drawing.Point(397, 63)
        Me.txtMPLv8Title.Multiline = True
        Me.txtMPLv8Title.Name = "txtMPLv8Title"
        Me.txtMPLv8Title.ReadOnly = True
        Me.txtMPLv8Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv8Title.TabIndex = 16
        Me.txtMPLv8Title.Text = "8"
        Me.txtMPLv8Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv7Title
        '
        Me.txtMPLv7Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv7Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv7Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv7Title.Location = New System.Drawing.Point(367, 63)
        Me.txtMPLv7Title.Multiline = True
        Me.txtMPLv7Title.Name = "txtMPLv7Title"
        Me.txtMPLv7Title.ReadOnly = True
        Me.txtMPLv7Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv7Title.TabIndex = 15
        Me.txtMPLv7Title.Text = "7"
        Me.txtMPLv7Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv9Title
        '
        Me.txtMPLv9Title.BackColor = System.Drawing.Color.White
        Me.txtMPLv9Title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv9Title.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv9Title.Location = New System.Drawing.Point(427, 63)
        Me.txtMPLv9Title.Multiline = True
        Me.txtMPLv9Title.Name = "txtMPLv9Title"
        Me.txtMPLv9Title.ReadOnly = True
        Me.txtMPLv9Title.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv9Title.TabIndex = 17
        Me.txtMPLv9Title.Text = "9"
        Me.txtMPLv9Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv9
        '
        Me.txtMPLv9.BackColor = System.Drawing.Color.White
        Me.txtMPLv9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv9.Location = New System.Drawing.Point(427, 83)
        Me.txtMPLv9.Multiline = True
        Me.txtMPLv9.Name = "txtMPLv9"
        Me.txtMPLv9.ReadOnly = True
        Me.txtMPLv9.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv9.TabIndex = 26
        Me.txtMPLv9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv8
        '
        Me.txtMPLv8.BackColor = System.Drawing.Color.White
        Me.txtMPLv8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv8.Location = New System.Drawing.Point(397, 83)
        Me.txtMPLv8.Multiline = True
        Me.txtMPLv8.Name = "txtMPLv8"
        Me.txtMPLv8.ReadOnly = True
        Me.txtMPLv8.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv8.TabIndex = 25
        Me.txtMPLv8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv7
        '
        Me.txtMPLv7.BackColor = System.Drawing.Color.White
        Me.txtMPLv7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv7.Location = New System.Drawing.Point(367, 83)
        Me.txtMPLv7.Multiline = True
        Me.txtMPLv7.Name = "txtMPLv7"
        Me.txtMPLv7.ReadOnly = True
        Me.txtMPLv7.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv7.TabIndex = 24
        Me.txtMPLv7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv6
        '
        Me.txtMPLv6.BackColor = System.Drawing.Color.White
        Me.txtMPLv6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv6.Location = New System.Drawing.Point(337, 83)
        Me.txtMPLv6.Multiline = True
        Me.txtMPLv6.Name = "txtMPLv6"
        Me.txtMPLv6.ReadOnly = True
        Me.txtMPLv6.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv6.TabIndex = 23
        Me.txtMPLv6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv5
        '
        Me.txtMPLv5.BackColor = System.Drawing.Color.White
        Me.txtMPLv5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv5.Location = New System.Drawing.Point(307, 83)
        Me.txtMPLv5.Multiline = True
        Me.txtMPLv5.Name = "txtMPLv5"
        Me.txtMPLv5.ReadOnly = True
        Me.txtMPLv5.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv5.TabIndex = 22
        Me.txtMPLv5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv4
        '
        Me.txtMPLv4.BackColor = System.Drawing.Color.White
        Me.txtMPLv4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv4.Location = New System.Drawing.Point(277, 83)
        Me.txtMPLv4.Multiline = True
        Me.txtMPLv4.Name = "txtMPLv4"
        Me.txtMPLv4.ReadOnly = True
        Me.txtMPLv4.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv4.TabIndex = 21
        Me.txtMPLv4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv3
        '
        Me.txtMPLv3.BackColor = System.Drawing.Color.White
        Me.txtMPLv3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv3.Location = New System.Drawing.Point(247, 83)
        Me.txtMPLv3.Multiline = True
        Me.txtMPLv3.Name = "txtMPLv3"
        Me.txtMPLv3.ReadOnly = True
        Me.txtMPLv3.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv3.TabIndex = 20
        Me.txtMPLv3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv2
        '
        Me.txtMPLv2.BackColor = System.Drawing.Color.White
        Me.txtMPLv2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv2.Location = New System.Drawing.Point(217, 83)
        Me.txtMPLv2.Multiline = True
        Me.txtMPLv2.Name = "txtMPLv2"
        Me.txtMPLv2.ReadOnly = True
        Me.txtMPLv2.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv2.TabIndex = 19
        Me.txtMPLv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMPLv1
        '
        Me.txtMPLv1.BackColor = System.Drawing.Color.White
        Me.txtMPLv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMPLv1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMPLv1.Location = New System.Drawing.Point(187, 83)
        Me.txtMPLv1.Multiline = True
        Me.txtMPLv1.Name = "txtMPLv1"
        Me.txtMPLv1.ReadOnly = True
        Me.txtMPLv1.Size = New System.Drawing.Size(30, 20)
        Me.txtMPLv1.TabIndex = 18
        Me.txtMPLv1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAbilitiesTitle
        '
        Me.txtAbilitiesTitle.BackColor = System.Drawing.Color.White
        Me.txtAbilitiesTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbilitiesTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAbilitiesTitle.Location = New System.Drawing.Point(4, 277)
        Me.txtAbilitiesTitle.Multiline = True
        Me.txtAbilitiesTitle.Name = "txtAbilitiesTitle"
        Me.txtAbilitiesTitle.ReadOnly = True
        Me.txtAbilitiesTitle.Size = New System.Drawing.Size(144, 25)
        Me.txtAbilitiesTitle.TabIndex = 27
        Me.txtAbilitiesTitle.Text = "Abilities"
        Me.txtAbilitiesTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtACTitle
        '
        Me.txtACTitle.BackColor = System.Drawing.Color.White
        Me.txtACTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtACTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtACTitle.Location = New System.Drawing.Point(463, 38)
        Me.txtACTitle.Multiline = True
        Me.txtACTitle.Name = "txtACTitle"
        Me.txtACTitle.ReadOnly = True
        Me.txtACTitle.Size = New System.Drawing.Size(69, 25)
        Me.txtACTitle.TabIndex = 28
        Me.txtACTitle.Text = "AC"
        Me.txtACTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHPTitle
        '
        Me.txtHPTitle.BackColor = System.Drawing.Color.White
        Me.txtHPTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHPTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtHPTitle.Location = New System.Drawing.Point(538, 38)
        Me.txtHPTitle.Multiline = True
        Me.txtHPTitle.Name = "txtHPTitle"
        Me.txtHPTitle.ReadOnly = True
        Me.txtHPTitle.Size = New System.Drawing.Size(69, 25)
        Me.txtHPTitle.TabIndex = 29
        Me.txtHPTitle.Text = "HP"
        Me.txtHPTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAC
        '
        Me.txtAC.BackColor = System.Drawing.Color.White
        Me.txtAC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAC.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtAC.Location = New System.Drawing.Point(463, 63)
        Me.txtAC.Multiline = True
        Me.txtAC.Name = "txtAC"
        Me.txtAC.ReadOnly = True
        Me.txtAC.Size = New System.Drawing.Size(69, 40)
        Me.txtAC.TabIndex = 30
        Me.txtAC.Text = "1"
        Me.txtAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHP
        '
        Me.txtHP.BackColor = System.Drawing.Color.White
        Me.txtHP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHP.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtHP.Location = New System.Drawing.Point(538, 63)
        Me.txtHP.Multiline = True
        Me.txtHP.Name = "txtHP"
        Me.txtHP.ReadOnly = True
        Me.txtHP.Size = New System.Drawing.Size(69, 40)
        Me.txtHP.TabIndex = 31
        Me.txtHP.Text = "1"
        Me.txtHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtHPmax
        '
        Me.TxtHPmax.BackColor = System.Drawing.Color.White
        Me.TxtHPmax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtHPmax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtHPmax.Location = New System.Drawing.Point(538, 88)
        Me.TxtHPmax.Multiline = True
        Me.TxtHPmax.Name = "TxtHPmax"
        Me.TxtHPmax.ReadOnly = True
        Me.TxtHPmax.Size = New System.Drawing.Size(69, 15)
        Me.TxtHPmax.TabIndex = 32
        Me.TxtHPmax.Text = "20"
        Me.TxtHPmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ucCharOverviewLeft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.TxtHPmax)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.txtAC)
        Me.Controls.Add(Me.txtHPTitle)
        Me.Controls.Add(Me.txtACTitle)
        Me.Controls.Add(Me.txtAbilitiesTitle)
        Me.Controls.Add(Me.txtMPLv9)
        Me.Controls.Add(Me.txtMPLv8)
        Me.Controls.Add(Me.txtMPLv7)
        Me.Controls.Add(Me.txtMPLv6)
        Me.Controls.Add(Me.txtMPLv5)
        Me.Controls.Add(Me.txtMPLv4)
        Me.Controls.Add(Me.txtMPLv3)
        Me.Controls.Add(Me.txtMPLv2)
        Me.Controls.Add(Me.txtMPLv1)
        Me.Controls.Add(Me.txtMPLv9Title)
        Me.Controls.Add(Me.txtMPLv8Title)
        Me.Controls.Add(Me.txtMPLv7Title)
        Me.Controls.Add(Me.txtMPLv6Title)
        Me.Controls.Add(Me.txtMPLv5Title)
        Me.Controls.Add(Me.txtMPLv4Title)
        Me.Controls.Add(Me.txtMPLv3Title)
        Me.Controls.Add(Me.txtMPLv2Title)
        Me.Controls.Add(Me.txtMPLv1Title)
        Me.Controls.Add(Me.txtMPTitle)
        Me.Controls.Add(Me.txtInfo1)
        Me.Controls.Add(Me.pictureBoxChar)
        Me.Controls.Add(Me.txtAbilitiesModifier)
        Me.Controls.Add(Me.txtAbilitiesScore)
        Me.Controls.Add(Me.txtAbilities)
        Me.Controls.Add(Me.btnLegendaryActions)
        Me.Controls.Add(Me.btnActions)
        Me.Controls.Add(Me.lbName)
        Me.Name = "ucCharOverviewLeft"
        Me.Size = New System.Drawing.Size(622, 515)
        CType(Me.pictureBoxChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbName As Label
    Friend WithEvents btnActions As Button
    Friend WithEvents btnLegendaryActions As Button
    Friend WithEvents txtAbilities As TextBox
    Friend WithEvents txtAbilitiesScore As TextBox
    Friend WithEvents txtAbilitiesModifier As TextBox
    Friend WithEvents pictureBoxChar As PictureBox
    Friend WithEvents txtInfo1 As TextBox
    Friend WithEvents txtMPTitle As TextBox
    Friend WithEvents txtMPLv1Title As TextBox
    Friend WithEvents txtMPLv2Title As TextBox
    Friend WithEvents txtMPLv4Title As TextBox
    Friend WithEvents txtMPLv3Title As TextBox
    Friend WithEvents txtMPLv6Title As TextBox
    Friend WithEvents txtMPLv5Title As TextBox
    Friend WithEvents txtMPLv8Title As TextBox
    Friend WithEvents txtMPLv7Title As TextBox
    Friend WithEvents txtMPLv9Title As TextBox
    Friend WithEvents txtMPLv9 As TextBox
    Friend WithEvents txtMPLv8 As TextBox
    Friend WithEvents txtMPLv7 As TextBox
    Friend WithEvents txtMPLv6 As TextBox
    Friend WithEvents txtMPLv5 As TextBox
    Friend WithEvents txtMPLv4 As TextBox
    Friend WithEvents txtMPLv3 As TextBox
    Friend WithEvents txtMPLv2 As TextBox
    Friend WithEvents txtMPLv1 As TextBox
    Friend WithEvents txtAbilitiesTitle As TextBox
    Friend WithEvents txtACTitle As TextBox
    Friend WithEvents txtHPTitle As TextBox
    Friend WithEvents txtAC As TextBox
    Friend WithEvents txtHP As TextBox
    Friend WithEvents TxtHPmax As TextBox
End Class
