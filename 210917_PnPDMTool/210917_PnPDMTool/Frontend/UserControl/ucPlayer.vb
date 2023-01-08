Imports _210917_PnPDMTool.C

Public Class UcPlayer

#Region "Private Var"
    Private _playerToEdit As PlayerType
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()
        ' Create new instance
        _playerToEdit = New PlayerType()

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub New(player As PlayerType)
        ' Copy instance
        _playerToEdit = player

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        'txtStr.DataBindings.Add(New Binding("Text", _playerToEdit, "Attributs.Strength.Value"))
        'txtDex.DataBindings.Add(New Binding("Text", _playerToEdit, "Attributs.Dexterity.Value"))
        'txtCha.DataBindings.Add(New Binding("Text", _playerToEdit, "Attributs.Charisma.Value"))
        'txtCon.DataBindings.Add(New Binding("Text", _playerToEdit, "Attributs.Constitution.Value"))
        'txtWis.DataBindings.Add(New Binding("Text", _playerToEdit, "Attributs.Wisdom.Value"))
        'txtInt.DataBindings.Add(New Binding("Text", _playerToEdit, "Attributs.Intelligence.Value"))
        ' comboBoxItem = New ComboBoxItemCheck()
        ' ComboBox_languages.Items.Add(comboBoxItem)
        'CheckedListBox_languages.DataSource = [Enum].GetNames(GetType(ELanguages))
    End Sub
#End Region

#Region "Private Sub"
    Private Sub btnDiscard_Click(sender As Object, e As EventArgs) Handles btnDiscard.Click
        RaiseEvent btnPlayerDiscardClicked()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim newPlayer As New PlayerType With {
            .Name = txtName.Text,
            .Image = txtImage.Text
        }

        newPlayer.Attributs.Strength.Value = CInt(txtStr.Text)
        newPlayer.Attributs.Dexterity.Value = CInt(txtDex.Text)
        newPlayer.Attributs.Intelligence.Value = CInt(txtInt.Text)
        newPlayer.Attributs.Wisdom.Value = CInt(txtWis.Text)
        newPlayer.Attributs.Constitution.Value = CInt(txtCon.Text)
        newPlayer.Attributs.Charisma.Value = CInt(txtCha.Text)


        '.BaseAC = CInt(txtAc.Text),
        '.BaseMaxHP = CInt(txtHp.Text)


        'write to xml file
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(PlayerType))
        Dim file As New System.IO.StreamWriter("C:\Projekte\Player" + newPlayer.Name + ".xml")
        writer.Serialize(file, newPlayer)
        file.Close()

        RaiseEvent btnPlayerSaveClicked()
    End Sub
#End Region

#Region "Pubilc Sub"
    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        'Title
        Me.lbPlayer.Size = New Size(Me.Width - GAP_SMALL, HEIGHT_TITLE)
        Me.lbPlayer.Location = New Point(GAP_SMALL, 0)

        'Abilities
        Me.lbStr.Size = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Me.lbDex.Size = Me.lbStr.Size
        Me.lbCon.Size = Me.lbStr.Size
        Me.lbWis.Size = Me.lbStr.Size
        Me.lbInt.Size = Me.lbStr.Size
        Me.lbCha.Size = Me.lbStr.Size
        Me.txtStr.Size = New Size(WIDTH_TEXT_SMALL, HEIGHT_TEXT_BOX)
        Me.txtDex.Size = Me.txtStr.Size
        Me.txtCon.Size = Me.txtStr.Size
        Me.txtWis.Size = Me.txtStr.Size
        Me.txtInt.Size = Me.txtStr.Size
        Me.txtCha.Size = Me.txtStr.Size

        Me.lbStr.Location = New Point(GAP_SMALL, HEIGHT_TITLE + GAP_MEDIUM)
        Me.lbDex.Location = New Point(GAP_SMALL, Me.lbStr.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbCon.Location = New Point(GAP_SMALL, Me.lbDex.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbWis.Location = New Point(GAP_SMALL, Me.lbCon.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbInt.Location = New Point(GAP_SMALL, Me.lbWis.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.lbCha.Location = New Point(GAP_SMALL, Me.lbInt.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.txtStr.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbStr.Location.Y)
        Me.txtDex.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbDex.Location.Y)
        Me.txtCon.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbCon.Location.Y)
        Me.txtWis.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbWis.Location.Y)
        Me.txtInt.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbInt.Location.Y)
        Me.txtCha.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbCha.Location.Y)

        'AC & HP
        Me.lbAc.Size = Me.lbStr.Size
        Me.lbHP.Size = Me.lbStr.Size
        Me.txtAc.Size = Me.txtStr.Size
        Me.txtHp.Size = Me.txtStr.Size

        Me.lbAc.Location = New Point(GAP_SMALL, Me.lbCha.Location.Y + 2 * HEIGHT_TEXT_BOX + 2 * GAP_SMALL)
        Me.lbHP.Location = New Point(GAP_SMALL, Me.lbAc.Location.Y + HEIGHT_TEXT_BOX + GAP_SMALL)
        Me.txtAc.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbAc.Location.Y)
        Me.txtHp.Location = New Point(GAP_SMALL + WIDTH_TEXT_MEDIUM, Me.lbHP.Location.Y)

        'Name and Image
        Me.lbName.Size = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Me.lbImage.Size = Me.lbName.Size
        Me.txtName.Size = New Size(Me.Width - GAP_SMALL - WIDTH_TEXT_SMALL - WIDTH_TEXT_MEDIUM - 3 * GAP_BIG - WIDTH_TEXT_MEDIUM - GAP_SMALL, HEIGHT_TEXT_BOX)
        Me.txtImage.Size = Me.txtName.Size

        Me.lbName.Location = New Point(GAP_SMALL + WIDTH_TEXT_SMALL + WIDTH_TEXT_MEDIUM + 3 * GAP_BIG, Me.lbStr.Location.Y)
        Me.lbImage.Location = New Point(Me.lbName.Location.X, Me.lbDex.Location.Y)
        Me.txtName.Location = New Size(Me.lbName.Location.X + WIDTH_TEXT_MEDIUM, Me.lbName.Location.Y)
        Me.txtImage.Location = New Size(Me.txtName.Location.X, Me.lbImage.Location.Y)

        'Buttons
        Me.btnDiscard.Size = New Size(CInt((Me.Width / 2 - 3 * GAP_SMALL - GAP_BIG) / 6), HEIGHT_BUTTON)
        Me.btnSave.Size = Me.btnDiscard.Size

        Me.btnSave.Location = New Point(Me.Width - GAP_SMALL - Me.btnSave.Width, Me.Height - HEIGHT_BUTTON - GAP_SMALL)
        Me.btnDiscard.Location = New Point(Me.Width - 2 * GAP_SMALL - 2 * Me.btnSave.Width, Me.btnSave.Location.Y)
    End Sub
#End Region

#Region "Events"
    Public Event btnPlayerDiscardClicked()
    Public Event btnPlayerSaveClicked()

#End Region
End Class
