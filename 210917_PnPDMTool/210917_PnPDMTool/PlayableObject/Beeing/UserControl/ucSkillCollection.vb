Public Class ucSkillCollection

#Region "Private Var"
    Private _skillCollection As SkillCollection
#End Region

#Region "Properties"

    Public Property SkillCollectionToEdit As SkillCollection
        Get
            Return _skillCollection
        End Get
        Set(value As SkillCollection)
            _skillCollection = value
            UpdateDatabinding()
        End Set
    End Property

#End Region

#Region "Init"
    Public Sub New()

        SkillCollectionToEdit = New SkillCollection

        ' Call common handle
        NewCommon()

    End Sub

    Public Sub New(skillCollection As SkillCollection)

        SkillCollectionToEdit = skillCollection

        ' Call common handle
        NewCommon()

    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.MinimumSize = New Size(230, 250)

        ' Get all armours
        ComboBox_Competence_Acrobatic.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))

    End Sub

#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding() ' Brocken

        ' Check if UI Exist
        If (Not IsNothing(ComboBox_Competence_Acrobatic)) Then
            ' Clear Values
            ComboBox_Competence_Acrobatic.DataBindings.Clear()


            ' Set Values
            SetupBinding(ComboBox_Competence_Acrobatic, "Acrobatic")

        End If

    End Sub

    Private Sub SetupBinding(cb As ComboBox, attribute As String)
        Dim binding = New Binding("SelectedIndex", _skillCollection, attribute & ".Competence", True, DataSourceUpdateMode.OnPropertyChanged)
        AddHandler binding.Format, AddressOf binding_Format
        AddHandler binding.Parse, AddressOf binding_Parse
        cb.DataBindings.Add(binding)
    End Sub

    Private Sub binding_Parse(sender As Object, e As ConvertEventArgs)
        If e.DesiredType = GetType(ProficencyType.ECopmetenceType) Then
            e.Value = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType)).GetValue(CInt(e.Value))
        End If
    End Sub

    Private Sub binding_Format(sender As Object, e As ConvertEventArgs)
        If e.DesiredType = GetType(Integer) Then
            e.Value = Array.IndexOf(System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType)), e.Value)
        End If
    End Sub


#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "Events Handle"
    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim CbLocFacHeight As Double = 900 / 10000
        Dim LbLocFacHeight As Double = 900 / 10000
        Dim CbLocFacWidth As Double = 3000 / 10000
        Dim LbLocFacWidth As Double = 8000 / 10000
        Dim FacInc As Double = 1570 / 10000

        ' Adjust positon 
        ComboBox_Competence_Acrobatic.Location = C.CalcRelativeLocation(Me.Size, ComboBox_Competence_Acrobatic.Size, CbLocFacWidth, CbLocFacHeight)
        Label_Competence_Acrobatic.Location = C.CalcRelativeLocation(Me.Size, Label_Competence_Acrobatic.Size, LbLocFacWidth, LbLocFacHeight)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc



    End Sub


#End Region
End Class
