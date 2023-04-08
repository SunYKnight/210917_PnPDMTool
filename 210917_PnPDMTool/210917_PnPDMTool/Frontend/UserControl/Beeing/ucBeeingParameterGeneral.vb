Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports _210917_PnPDMTool.C
Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucBeeingParameterGeneral

#Region "Private Var"
    Friend WithEvents _ucLanguageList As ucItemList(Of eLanguages)
    Friend WithEvents _ucDmgResistanceList As ucItemList(Of eDmgType)
    Friend WithEvents _ucDmgImmunityList As ucItemList(Of eDmgType)
    Friend WithEvents _ucDmgVunrabilityList As ucItemList(Of eDmgType)
    Friend WithEvents _ucConditionImmunityList As ucItemList(Of eCondidtion)
    Friend WithEvents _ucSavingThrowProfiecenies As ucItemList(Of eAttributs)
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
            Using fs As New System.IO.FileStream(Beeing.Image, IO.FileMode.Open)
                PictureBox_image.Image = New Bitmap(Image.FromStream(fs))
            End Using
        Catch ex As Exception
            If (Beeing.Image <> "") Then
                MsgBox(String.Format("Path not found:\n{0}", Beeing.Image))
            End If
            ' Reset Path
            Beeing.Image = ""
        End Try

        UcAttributCollection1.AttributeCollectionToEdit = Beeing.Attributs

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Size
        ComboBox_Size.DataSource = System.Enum.GetValues(GetType(C.ESize))
        ' Monster Class
        ComboBox_monsterClass.DataSource = System.Enum.GetValues(GetType(C.eMonsterType))
        ' Aligment
        ComboBox_aligment_behaviour.DataSource = System.Enum.GetValues(GetType(AligmentType.EBehaviour))


        ' SavingThrowProficencies
        _ucSavingThrowProfiecenies = New ucItemList(Of eAttributs)(Beeing.SavingThrowProficencies, "Saving Throws", True)
        _ucSavingThrowProfiecenies.Location = New Point(150, 260)
        Me.Controls.Add(Me._ucSavingThrowProfiecenies)

        ' Languages
        _ucLanguageList = New ucItemList(Of eLanguages)(Beeing.KnownLanguages, "Languages", True)
        _ucLanguageList.Location = New Point(300, 260)
        Me.Controls.Add(Me._ucLanguageList)


        ' DmgImmunity
        _ucDmgImmunityList = New ucItemList(Of eDmgType)(Beeing.DmgImmunities, "DMG Immunities", True)
        _ucDmgImmunityList.Location = New Point(650, 20)
        Me.Controls.Add(Me._ucDmgImmunityList)

        ' DmgResistance
        _ucDmgResistanceList = New ucItemList(Of eDmgType)(Beeing.DmgResistances, "DMG Resistance", True)
        _ucDmgResistanceList.Location = New Point(650, 190)
        Me.Controls.Add(Me._ucDmgResistanceList)

        ' DmgVulnerability
        _ucDmgVunrabilityList = New ucItemList(Of eDmgType)(Beeing.DmgVulnerabilites, "DMG Vulnerability", True)
        _ucDmgVunrabilityList.Location = New Point(650, 360)
        Me.Controls.Add(Me._ucDmgVunrabilityList)



        ' ConditionImmunity
        _ucConditionImmunityList = New ucItemList(Of eCondidtion)(Beeing.ConditionImmunities, "Condition Immunity", True)
        _ucConditionImmunityList.Location = New Point(500, 20)
        Me.Controls.Add(Me._ucConditionImmunityList)

        ' SkillProficencies
        _ucSkillProfiecencies = New ucItemList(Of eSkills)(Beeing.SkillProficencies, "Skill Proficencies", True)
        _ucSkillProfiecencies.Location = New Point(500, 190)
        Me.Controls.Add(Me._ucSkillProfiecencies)

        ' SkillProficencies
        _ucSkillExpertieses = New ucItemList(Of eSkills)(Beeing.SkillExpertieses, "Skill Expertieses", True)
        _ucSkillExpertieses.Location = New Point(500, 360)
        Me.Controls.Add(Me._ucSkillExpertieses)

        ' Update data
        UpdateDatabinding()

    End Sub

#End Region

#Region "Private Sub"


    Private Sub UpdateDatabinding()


        ' Name
        TextBox_name.DataBindings.Clear()
        TextBox_name.DataBindings.Add(New Binding("Text", Beeing, "Name"))

        ' Monster Class
        Dim cBmt As New ComboboxBinder(Of eMonsterType)(ComboBox_monsterClass, Beeing, "MonsterClass")

        ' Aligment
        Dim cBal As New ComboboxBinder(Of AligmentType.EBehaviour)(ComboBox_aligment_behaviour, Beeing.Aligment, "Behaviour")

        ' Size
        Dim cBsize As New ComboboxBinder(Of ESize)(ComboBox_Size, Beeing, "Size")

        ' AC
        NumericUpDown_AC.DataBindings.Clear()
        NumericUpDown_AC.DataBindings.Add(New Binding("Value", Beeing, "AC"))

        ' Proficency
        NumericUpDown_Proficency.DataBindings.Clear()
        NumericUpDown_Proficency.DataBindings.Add(New Binding("Value", Beeing, "Proficency"))

        ' Challenge
        NumericUpDown_challenge.DataBindings.Clear()
        NumericUpDown_challenge.DataBindings.Add(New Binding("Value", Beeing, "Challenge"))

        ' HP
        NumericUpDown_HpBonus.DataBindings.Clear()
        NumericUpDown_HpBonus.DataBindings.Add(New Binding("Value", Beeing, "HPBonus"))
        NumericUpDown_HpDiceD100.DataBindings.Clear()
        NumericUpDown_HpDiceD100.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD100.DiceCount"))
        NumericUpDown_HpDiceD20.DataBindings.Clear()
        NumericUpDown_HpDiceD20.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD20.DiceCount"))
        NumericUpDown_HpDiceD12.DataBindings.Clear()
        NumericUpDown_HpDiceD12.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD12.DiceCount"))
        NumericUpDown_HpDiceD8.DataBindings.Clear()
        NumericUpDown_HpDiceD8.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD8.DiceCount"))
        NumericUpDown_HpDiceD6.DataBindings.Clear()
        NumericUpDown_HpDiceD6.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD6.DiceCount"))
        NumericUpDown_HpDiceD4.DataBindings.Clear()
        NumericUpDown_HpDiceD4.DataBindings.Add(New Binding("Value", Beeing, "HpDiceD4.DiceCount"))

        ' Speed
        NumericUpDown_speedBorrow.DataBindings.Clear()
        NumericUpDown_speedBorrow.DataBindings.Add(New Binding("Value", Beeing, "SpeedBurrowing"))
        NumericUpDown_speedClimb.DataBindings.Clear()
        NumericUpDown_speedClimb.DataBindings.Add(New Binding("Value", Beeing, "SpeedClimb"))
        NumericUpDown_speedFly.DataBindings.Clear()
        NumericUpDown_speedFly.DataBindings.Add(New Binding("Value", Beeing, "SpeedFlying"))
        NumericUpDown_speedSwim.DataBindings.Clear()
        NumericUpDown_speedSwim.DataBindings.Add(New Binding("Value", Beeing, "SpeedSwimming"))
        NumericUpDown_speedWalk.DataBindings.Clear()
        NumericUpDown_speedWalk.DataBindings.Add(New Binding("Value", Beeing, "SpeedWalk"))


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
                    Beeing.Image = fi.FullName
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
