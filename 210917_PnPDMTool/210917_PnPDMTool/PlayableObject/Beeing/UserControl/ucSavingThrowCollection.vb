Public Class ucSavingThrowCollection
#Region "Private Var"
    Private _savingThrowCollection As SavingThrowCollection
#End Region

#Region "Properties"

    Public Property SavingThrowCollectionToEdit As SavingThrowCollection
        Get
            Return _savingThrowCollection
        End Get
        Set(value As SavingThrowCollection)
            _savingThrowCollection = value
            UpdateDatabinding()
        End Set
    End Property

#End Region

#Region "Init"
    Public Sub New()

        SavingThrowCollectionToEdit = New SavingThrowCollection

        ' Call common handle
        NewCommon()

    End Sub

    Public Sub New(attributeCollection As SavingThrowCollection)

        SavingThrowCollectionToEdit = attributeCollection

        ' Call common handle
        NewCommon()

    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.MinimumSize = New Size(230, 250)

        ' Get all armours
        ComboBox_Competence_Str.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Dex.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Con.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Int.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Wis.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Cha.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))

    End Sub

#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding() ' Brocken

        ' Check if UI Exist
        If (Not IsNothing(ComboBox_Competence_Str)) Then
            ' Clear Values
            ComboBox_Competence_Str.DataBindings.Clear()
            ComboBox_Competence_Dex.DataBindings.Clear()
            ComboBox_Competence_Con.DataBindings.Clear()
            ComboBox_Competence_Int.DataBindings.Clear()
            ComboBox_Competence_Wis.DataBindings.Clear()
            ComboBox_Competence_Cha.DataBindings.Clear()

            ' Set Values
            SetupBinding(ComboBox_Competence_Str, "Strength")
            SetupBinding(ComboBox_Competence_Dex, "Dexterity")
            SetupBinding(ComboBox_Competence_Con, "Constitution")
            SetupBinding(ComboBox_Competence_Int, "Intelligence")
            SetupBinding(ComboBox_Competence_Wis, "Wisdom")
            SetupBinding(ComboBox_Competence_Cha, "Charisma")

        End If

    End Sub

    Private Sub SetupBinding(cb As ComboBox, attribute As String)
        Dim binding = New Binding("SelectedIndex", _savingThrowCollection, attribute & ".Competence", True, DataSourceUpdateMode.OnPropertyChanged)
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
        ComboBox_Competence_Str.Location = C.CalcRelativeLocation(Me.Size, ComboBox_Competence_Str.Size, CbLocFacWidth, CbLocFacHeight)
        Label_Competence_Str.Location = C.CalcRelativeLocation(Me.Size, Label_Competence_Str.Size, LbLocFacWidth, LbLocFacHeight)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        ComboBox_Competence_Dex.Location = C.CalcRelativeLocation(Me.Size, ComboBox_Competence_Dex.Size, CbLocFacWidth, CbLocFacHeight)
        Label_Competence_Dex.Location = C.CalcRelativeLocation(Me.Size, Label_Competence_Dex.Size, LbLocFacWidth, LbLocFacHeight)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        ComboBox_Competence_Con.Location = C.CalcRelativeLocation(Me.Size, ComboBox_Competence_Con.Size, CbLocFacWidth, CbLocFacHeight)
        Label_Competence_Con.Location = C.CalcRelativeLocation(Me.Size, Label_Competence_Con.Size, LbLocFacWidth, LbLocFacHeight)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        ComboBox_Competence_Int.Location = C.CalcRelativeLocation(Me.Size, ComboBox_Competence_Int.Size, CbLocFacWidth, CbLocFacHeight)
        Label_Competence_Int.Location = C.CalcRelativeLocation(Me.Size, Label_Competence_Int.Size, LbLocFacWidth, LbLocFacHeight)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        ComboBox_Competence_Wis.Location = C.CalcRelativeLocation(Me.Size, ComboBox_Competence_Wis.Size, CbLocFacWidth, CbLocFacHeight)
        Label_Competence_Wis.Location = C.CalcRelativeLocation(Me.Size, Label_Competence_Wis.Size, LbLocFacWidth, LbLocFacHeight)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        ComboBox_Competence_Cha.Location = C.CalcRelativeLocation(Me.Size, ComboBox_Competence_Cha.Size, CbLocFacWidth, CbLocFacHeight)
        Label_Competence_Cha.Location = C.CalcRelativeLocation(Me.Size, Label_Competence_Cha.Size, LbLocFacWidth, LbLocFacHeight)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc


    End Sub


#End Region





End Class
