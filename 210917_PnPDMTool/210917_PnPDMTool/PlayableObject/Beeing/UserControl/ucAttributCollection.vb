Public Class ucAttributCollection

#Region "Private Var"
    Private _attributeCOllection As AttributCollection
#End Region

#Region "Properties"

    Public Property AttributeCollectionToEdit As AttributCollection
        Get
            Return _attributeCOllection
        End Get
        Set(value As AttributCollection)
            _attributeCOllection = value
            UpdateDatabinding()
        End Set
    End Property

#End Region

#Region "Init"
    Public Sub New()

        AttributeCollectionToEdit = New AttributCollection

        ' Call common handle
        NewCommon()

    End Sub

    Public Sub New(attributeCollection As AttributCollection)

        AttributeCollectionToEdit = attributeCollection

        ' Call common handle
        NewCommon()

    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding()



        ' Check if UI Exist
        If (Not IsNothing(TextBox_Val_Cha)) Then
            ' Clear Values
            TextBox_Val_Cha.DataBindings.Clear()
            TextBox_Val_Con.DataBindings.Clear()
            TextBox_Val_Dex.DataBindings.Clear()
            TextBox_Val_Int.DataBindings.Clear()
            TextBox_Val_Str.DataBindings.Clear()
            TextBox_Val_Wis.DataBindings.Clear()
            ' Clear Modifier
            Label_Mod_Cha.DataBindings.Clear()
            Label_Mod_Con.DataBindings.Clear()
            Label_Mod_Dex.DataBindings.Clear()
            Label_Mod_Int.DataBindings.Clear()
            Label_Mod_Str.DataBindings.Clear()
            Label_Mod_Wis.DataBindings.Clear()

            ' Set Values
            TextBox_Val_Cha.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Charisma.Value"))
            TextBox_Val_Con.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Constitution.Value"))
            TextBox_Val_Dex.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Dexterity.Value"))
            TextBox_Val_Int.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Intelligence.Value"))
            TextBox_Val_Str.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Strength.Value"))
            TextBox_Val_Wis.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Wisdom.Value"))
            ' Set Modifiers
            Label_Mod_Cha.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Charisma.Modifier"))
            Label_Mod_Con.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Constitution.Modifier"))
            Label_Mod_Dex.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Dexterity.Modifier"))
            Label_Mod_Int.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Intelligence.Modifier"))
            Label_Mod_Str.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Strength.Modifier"))
            Label_Mod_Wis.DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, "Wisdom.Modifier"))
        End If

    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "Events Handle"
    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim ValLocFac As Integer = 1100
        Dim ModLocFac As Integer = 1600
        Dim FacInc As Integer = 1575

        ' Adjust positon 
        TextBox_Val_Str.Location = C.CalcLocation(Me.Size, TextBox_Val_Str.Size, 5000 / 10000, ValLocFac / 10000)
        Label_Mod_Str.Location = C.CalcLocation(Me.Size, Label_Mod_Str.Size, 5000 / 10000, ModLocFac / 10000)
        ValLocFac += FacInc
        ModLocFac += FacInc

        TextBox_Val_Dex.Location = C.CalcLocation(Me.Size, TextBox_Val_Dex.Size, 5000 / 10000, ValLocFac / 10000)
        Label_Mod_Dex.Location = C.CalcLocation(Me.Size, Label_Mod_Dex.Size, 5000 / 10000, ModLocFac / 10000)
        ValLocFac += FacInc
        ModLocFac += FacInc

        TextBox_Val_Con.Location = C.CalcLocation(Me.Size, TextBox_Val_Con.Size, 5000 / 10000, ValLocFac / 10000)
        Label_Mod_Con.Location = C.CalcLocation(Me.Size, Label_Mod_Con.Size, 5000 / 10000, ModLocFac / 10000)
        ValLocFac += FacInc
        ModLocFac += FacInc

        TextBox_Val_Int.Location = C.CalcLocation(Me.Size, TextBox_Val_Int.Size, 5000 / 10000, ValLocFac / 10000)
        Label_Mod_Int.Location = C.CalcLocation(Me.Size, Label_Mod_Int.Size, 5000 / 10000, ModLocFac / 10000)
        ValLocFac += FacInc
        ModLocFac += FacInc

        TextBox_Val_Wis.Location = C.CalcLocation(Me.Size, TextBox_Val_Wis.Size, 5000 / 10000, ValLocFac / 10000)
        Label_Mod_Wis.Location = C.CalcLocation(Me.Size, Label_Mod_Wis.Size, 5000 / 10000, ModLocFac / 10000)
        ValLocFac += FacInc
        ModLocFac += FacInc

        TextBox_Val_Cha.Location = C.CalcLocation(Me.Size, TextBox_Val_Cha.Size, 5000 / 10000, ValLocFac / 10000)
        Label_Mod_Cha.Location = C.CalcLocation(Me.Size, Label_Mod_Cha.Size, 5000 / 10000, ModLocFac / 10000)

    End Sub
#End Region






End Class
