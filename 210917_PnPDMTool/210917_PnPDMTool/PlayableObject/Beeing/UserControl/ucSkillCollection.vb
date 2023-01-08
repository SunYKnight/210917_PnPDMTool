Public Class ucSkillCollection

#Region "Private Var"
    Private _skillCollection As SkillCollection
#End Region

#Region "Properties"

    Public Overrides Property MinimumSize As Size = New Size(500, 500)

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
        Me.MinimumSize = New Size(285, 720)

        ' Get all armours
        ComboBox_Competence_Acrobatic.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_AnimalHandling.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Arcana.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Athletics.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Deception.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_History.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Insight.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Intimidation.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Investigation.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Medicine.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Nature.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Perception.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Performance.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Persuation.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Religion.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_SlightOfHand.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Stealth.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))
        ComboBox_Competence_Survival.DataSource = System.Enum.GetValues(GetType(ProficencyType.ECopmetenceType))

    End Sub

#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding() ' Brocken

        ' Check if UI Exist
        If (Not IsNothing(ComboBox_Competence_Acrobatic)) Then
            ' Clear Values
            ComboBox_Competence_Acrobatic.DataBindings.Clear()
            ComboBox_Competence_AnimalHandling.DataBindings.Clear()
            ComboBox_Competence_Arcana.DataBindings.Clear()
            ComboBox_Competence_Athletics.DataBindings.Clear()
            ComboBox_Competence_Deception.DataBindings.Clear()
            ComboBox_Competence_History.DataBindings.Clear()
            ComboBox_Competence_Insight.DataBindings.Clear()
            ComboBox_Competence_Intimidation.DataBindings.Clear()
            ComboBox_Competence_Investigation.DataBindings.Clear()
            ComboBox_Competence_Medicine.DataBindings.Clear()
            ComboBox_Competence_Nature.DataBindings.Clear()
            ComboBox_Competence_Perception.DataBindings.Clear()
            ComboBox_Competence_Performance.DataBindings.Clear()
            ComboBox_Competence_Persuation.DataBindings.Clear()
            ComboBox_Competence_Religion.DataBindings.Clear()
            ComboBox_Competence_SlightOfHand.DataBindings.Clear()
            ComboBox_Competence_Stealth.DataBindings.Clear()
            ComboBox_Competence_Survival.DataBindings.Clear()

            ' Set Values
            SetupBinding(ComboBox_Competence_Acrobatic, "Acrobatic")
            SetupBinding(ComboBox_Competence_AnimalHandling, "AnimalHandling")
            SetupBinding(ComboBox_Competence_Arcana, "Arcana")
            SetupBinding(ComboBox_Competence_Athletics, "Athletics")
            SetupBinding(ComboBox_Competence_Deception, "Deception")
            SetupBinding(ComboBox_Competence_History, "History")
            SetupBinding(ComboBox_Competence_Insight, "Insight")
            SetupBinding(ComboBox_Competence_Intimidation, "Intimidation")
            SetupBinding(ComboBox_Competence_Investigation, "Investigation")
            SetupBinding(ComboBox_Competence_Medicine, "Medicine")
            SetupBinding(ComboBox_Competence_Nature, "Nature")
            SetupBinding(ComboBox_Competence_Perception, "Perception")
            SetupBinding(ComboBox_Competence_Performance, "Performance")
            SetupBinding(ComboBox_Competence_Persuation, "Persuation")
            SetupBinding(ComboBox_Competence_Religion, "Religion")
            SetupBinding(ComboBox_Competence_SlightOfHand, "SlightOfHand")
            SetupBinding(ComboBox_Competence_Stealth, "Stealth")
            SetupBinding(ComboBox_Competence_Survival, "Survival")

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

    Private Sub SetLocCbLb(cb As ComboBox, lb As Label, cbLocFacWidth As Double, cbLocFacHeight As Double,
                           lbLocFacWidth As Double, lbLocFacHeight As Double, lbWidthOff As Integer)
        ' Get location
        cb.Location = C.CalcRelativeLocation(Me.Size, cb.Size, cbLocFacWidth, cbLocFacHeight)
        lb.Location = C.CalcRelativeLocation(Me.Size, lb.Size, lbLocFacWidth, lbLocFacHeight)

        ' Check offset
        If (lbWidthOff > 0) Then
            lb.Location = New Point(cb.Location.X + lbWidthOff, lb.Location.Y)
        End If

    End Sub


#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "Events Handle"

    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim CbLocFacHeight As Double = 300 / 10000
        Dim LbLocFacHeight As Double = 300 / 10000
        Dim CbLocFacWidth As Double = 3000 / 10000
        Dim LbLocFacWidth As Double = 8000 / 10000
        Dim LbLocOff As Integer = 80
        Dim FacInc As Double = 550 / 10000

        ' Adjust positon 
        SetLocCbLb(ComboBox_Competence_Acrobatic, Label_Competence_Acrobatic, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_AnimalHandling, Label_Competence_AnimalHandling, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Arcana, Label_Competence_Arcana, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Athletics, Label_Competence_Athletics, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Deception, Label_Competence_Deception, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_History, Label_Competence_History, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Insight, Label_Competence_Insight, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Intimidation, Label_Competence_Intimidation, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Investigation, Label_Competence_Investigation, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Medicine, Label_Competence_Medicine, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Nature, Label_Competence_Nature, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Perception, Label_Competence_Perception, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Performance, Label_Competence_Performance, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Persuation, Label_Competence_Persuation, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Religion, Label_Competence_Religion, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_SlightOfHand, Label_Competence_SlightOfHand, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Stealth, Label_Competence_Stealth, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

        SetLocCbLb(ComboBox_Competence_Survival, Label_Competence_Survival, CbLocFacWidth, CbLocFacHeight, LbLocFacWidth, LbLocFacHeight, LbLocOff)
        CbLocFacHeight += FacInc
        LbLocFacHeight += FacInc

    End Sub


#End Region
End Class
