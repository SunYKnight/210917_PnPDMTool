Imports _210917_PnPDMTool.C
Public Class ucEditMonsterGeneral

#Region "Private Var"
    Private _monsterToEdit As MonsterType
#End Region

#Region "Properties"
    Public Overrides Property MinimumSize As Size = New Size(750, 800)
#End Region

#Region "Init"
    Public Sub New()
        ' Create new instance
        _monsterToEdit = New MonsterType()

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub New(monster As MonsterType)
        ' Copy instance
        _monsterToEdit = monster

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        UcAttributCollection1.AttributeCollectionToEdit = _monsterToEdit.Attributs
        UcSavingThrowCollection1.SavingThrowCollectionToEdit = _monsterToEdit.SavingThrows
        UcSkillCollection1.SkillCollectionToEdit = _monsterToEdit.Skills

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' comboBoxItem = New ComboBoxItemCheck()
        ' ComboBox_languages.Items.Add(comboBoxItem)
        'CheckedListBox_languages.DataSource = [Enum].GetNames(GetType(ELanguages))
    End Sub

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"

    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim labelSize = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Dim textBoxSize = New Size(WIDTH_TEXT_SMALL, HEIGHT_TEXT_BOX)


        ' Attributs
        Me.UcAttributCollection1.Size = C.CalcRelativeSize(Me.Size, 0.25, 0.8, Me.UcAttributCollection1.MinimumSize)
        Me.UcAttributCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcAttributCollection1.Size, 0.5, 0.85)

        Me.UcSavingThrowCollection1.Size = C.CalcRelativeSize(Me.Size, 0.175, 0.2, Me.UcSavingThrowCollection1.MinimumSize)
        Me.UcSavingThrowCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSavingThrowCollection1.Size, 0.5, 0.2)

        Me.UcSkillCollection1.Size = C.CalcRelativeSize(Me.Size, 0.1, 0.7, Me.UcSkillCollection1.MinimumSize)
        Me.UcSkillCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSkillCollection1.Size, 0.15, 0.5)



    End Sub

#End Region

#Region "Events"

#End Region

End Class
