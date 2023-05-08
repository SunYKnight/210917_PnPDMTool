Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports _210917_PnPDMTool.C
Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucBMetadata

#Region "Private Var"
    Friend WithEvents _ucLanguageList As ucItemList(Of eLanguages)
    Friend WithEvents _ucDmgResistanceList As ucItemList(Of eDmgType)
    Friend WithEvents _ucDmgImmunityList As ucItemList(Of eDmgType)
    Friend WithEvents _ucDmgVunrabilityList As ucItemList(Of eDmgType)
    Friend WithEvents _ucConditionImmunityList As ucItemList(Of eCondidtion)
    Friend WithEvents _ucSavingThrowProfiecenies As ucItemList(Of eAttribut)
    Friend WithEvents _ucSkillProfiecencies As ucItemList(Of eSkills)
    Friend WithEvents _ucSkillExpertieses As ucItemList(Of eSkills)
#End Region

#Region "Properties"
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

        ' Load Image
        Try
            Using fs As New System.IO.FileStream(Beeing.Metadata.Image, IO.FileMode.Open)
                PictureBox_image.Image = New Bitmap(Image.FromStream(fs))
            End Using
        Catch ex As Exception
            If (Beeing.Metadata.Image <> "") Then
                MsgBox(String.Format("Path not found:\n{0}", Beeing.Metadata.Image))
            End If
            ' Reset Path
            Beeing.Metadata.Image = ""
        End Try

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Size
        ComboBox_Size.DataSource = System.Enum.GetValues(GetType(C.eSize))
        ' Monster Class
        ComboBox_monsterClass.DataSource = System.Enum.GetValues(GetType(C.eMonsterType))
        ' Aligment
        ComboBox_aligment_behaviour.DataSource = System.Enum.GetValues(GetType(BaseAligment.EBehaviour))
        ' Spellcast attribute
        ComboBox_spellcast_attribute.DataSource = System.Enum.GetValues(GetType(eAttribut))

        ' Update data
        UpdateDatabinding()

    End Sub

#End Region

#Region "Private Sub"

    Private Sub SetDatabinding(ByRef cbc As ControlBindingsCollection, dest As String, src As String)
        cbc.Clear()
        cbc.Add(New Binding(dest, Beeing, src))
    End Sub

    Private Sub UpdateDatabinding()
        ' Locals
        Dim prop_name As String

        ' Handle Stats
        prop_name = "Metadata."

        ' Name
        SetDatabinding(TextBox_name.DataBindings, "Text", prop_name + "Name")

        ' Monster Class
        Dim cBmt As New ComboboxBinder(Of eMonsterType)(ComboBox_monsterClass, Beeing, "MonsterType")

        ' Aligment
        Dim cBal As New ComboboxBinder(Of BaseAligment.EBehaviour)(ComboBox_aligment_behaviour, Beeing, prop_name + "Aligment.Behaviour")

        ' Size
        Dim cBsize As New ComboboxBinder(Of eSize)(ComboBox_Size, Beeing, prop_name + "Size")

        ' Spellcast Attribute
        Dim cBSpellcastAttribute As New ComboboxBinder(Of eAttribut)(ComboBox_spellcast_attribute, Beeing, prop_name + "SpellcastAttribute")


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
        dialog.InitialDirectory = "data/Images"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New System.IO.FileInfo(dialog.FileName)
            Try
                Using fs As New System.IO.FileStream(fi.FullName, IO.FileMode.Open)
                    PictureBox_image.Image = New Bitmap(Image.FromStream(fs))
                    Beeing.Metadata.Image = fi.FullName
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
