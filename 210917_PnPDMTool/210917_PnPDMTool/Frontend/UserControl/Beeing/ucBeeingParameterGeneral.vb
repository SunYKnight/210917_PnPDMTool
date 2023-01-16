Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports _210917_PnPDMTool.C
Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucBeeingParameterGeneral

#Region "Private Var"
#End Region

#Region "Properties"
    Public Overridable Property MinimumSize As Size = New Size(1200, 900)
    Public Property Beeing As BeeingType
#End Region

#Region "Init"

    Public Sub New(monster As BeeingType)

        Me.Beeing = monster

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        UcAttributCollection1.AttributeCollectionToEdit = Beeing.Attributs
        UcSavingThrowCollection1.SavingThrowCollectionToEdit = Beeing.SavingThrows
        UcSkillCollection1.SkillCollectionToEdit = Beeing.Skills

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        ComboBox_Size.DataSource = System.Enum.GetValues(GetType(C.ESize))

        ' Update data
        UpdateDatabinding()

        ' comboBoxItem = New ComboBoxItemCheck()
        ' ComboBox_languages.Items.Add(comboBoxItem)
        'CheckedListBox_languages.DataSource = [Enum].GetNames(GetType(ELanguages))
    End Sub

#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding()
        ' Locals
        Dim dataSrc = System.Enum.GetNames(GetType(eAttributes))

        TextBox_name.DataBindings.Clear()
        TextBox_name.DataBindings.Add(New Binding("Text", Beeing, "Name"))

        ComboBox_Size.DataBindings.Clear()
        ComboBox_Size.DataBindings.Add(New Binding("Text", Beeing, "Size"))

        ComboBox_aligment_personality.DataBindings.Clear()
        ComboBox_aligment_personality.DataBindings.Add(New Binding("Text", Beeing.Aligment, "Personality"))

        ComboBox_aligment_behaviour.DataBindings.Clear()
        ComboBox_aligment_behaviour.DataBindings.Add(New Binding("Text", Beeing.Aligment, "Behaviour"))

        PictureBox_image.DataBindings.Clear()
        PictureBox_image.DataBindings.Add(New Binding("Image", Beeing.Aligment, "Behaviour", True))

    End Sub
#End Region

#Region "Pubilc Sub"

    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim labelSize = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Dim textBoxSize = New Size(WIDTH_TEXT_SMALL, HEIGHT_TEXT_BOX)


        '' Attributs
        'Me.UcAttributCollection1.Size = C.CalcRelativeSize(Me.Size, 0.25, 0.8, Me.UcAttributCollection1.MinimumSize)
        'Me.UcAttributCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcAttributCollection1.Size, 0.6, 0.85)

        'Me.UcSavingThrowCollection1.Size = C.CalcRelativeSize(Me.Size, 0.175, 0.2, Me.UcSavingThrowCollection1.MinimumSize)
        'Me.UcSavingThrowCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSavingThrowCollection1.Size, 0.6, 0.2)

        'Me.UcSkillCollection1.Size = C.CalcRelativeSize(Me.Size, 0.1, 0.7, Me.UcSkillCollection1.MinimumSize)
        'Me.UcSkillCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSkillCollection1.Size, 0.85, 0.5)

        'Me.TextBox_name.Location = C.CalcRelativeLocation(Me.Size, Me.TextBox_name.Size, 0.15, 0.1)
        'Me.ComboBox_Size.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_Size.Size, 0.15, 0.15)
        'Me.ComboBox_aligment_personality.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_aligment_personality.Size, 0.2, 0.15)
        'Me.ComboBox_aligment_behaviour.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_aligment_behaviour.Size, 0.2, 0.2)
        'Me.PictureBox_image.Location = C.CalcRelativeLocation(Me.Size, Me.PictureBox_image.Size, 0.15, 0.5)

    End Sub

    Private Sub PictureBox_image_Click(sender As Object, e As EventArgs) Handles PictureBox_image.DoubleClick
        Dim dialog As New OpenFileDialog()
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New System.IO.FileInfo(dialog.FileName)
            Try
                Using fs As New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
                    PictureBox_image.Image = New Bitmap(Image.FromStream(fs))
                End Using
            Catch ex As Exception
                Dim msg As String = "Filename: " & fi.FullName &
                    Environment.NewLine & Environment.NewLine &
                    "Exception: " & ex.ToString
                MessageBox.Show(msg, "Error Opening Image File")
            End Try
        End If

    End Sub


#End Region

#Region "Events"

#End Region

End Class
