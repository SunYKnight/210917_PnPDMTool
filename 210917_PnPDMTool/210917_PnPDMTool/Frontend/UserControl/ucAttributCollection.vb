Public Class ucAttributCollection

#Region "Enum"


#End Region

#Region "Private Var"
    Private _attributeCOllection As AttributCollection
    Private main_layout As FlowLayoutPanel
    Private lbAttr As Label()
    Private tbAttrVal As TextBox()

#End Region

#Region "Properties"

    Public Overrides Property MinimumSize As Size = New Size(170, 265)

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

        ' Set Paramter
        main_layout = New FlowLayoutPanel()
        main_layout.AutoSize = True
        main_layout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        main_layout.MinimumSize = New Size(500, 100)
        main_layout.FlowDirection = FlowDirection.TopDown

        ' Add Layout
        Me.Controls.Add(main_layout)

        ' Create empty controlls
        lbAttr = New Label(System.Enum.GetNames(GetType(eAttribut)).Length) {}
        tbAttrVal = New TextBox(System.Enum.GetNames(GetType(eAttribut)).Length) {}

        ' Load all Arrtibutes
        For Each attr In System.Enum.GetValues(GetType(eAttribut))
            Dim layout As FlowLayoutPanel = New FlowLayoutPanel

            ' Set attribute text
            lbAttr(attr) = New Label()
            lbAttr(attr).Text = CType(attr, eAttribut).ToString()
            lbAttr(attr).Size = New Size(110, 30)

            ' Set attribute value
            tbAttrVal(attr) = New TextBox()
            tbAttrVal(attr).Size = New Size(30, 30)

            ' Set Parameter
            layout.AutoSize = True
            layout.AutoSizeMode = AutoSizeMode.GrowAndShrink
            layout.MinimumSize = New Size(500, 1)
            layout.FlowDirection = FlowDirection.LeftToRight

            ' Add items
            layout.Controls.Add(lbAttr(attr))
            layout.Controls.Add(tbAttrVal(attr))

            ' Add to main layout
            main_layout.Controls.Add(layout)

        Next

        ' Update data
        UpdateDatabinding()

    End Sub

#End Region

#Region "Private Sub"
    Private Sub UpdateDatabinding()
        ' Locals
        Dim dataSrc = System.Enum.GetNames(GetType(eAttribut))

        ' Check if UI Exist
        If (Not IsNothing(tbAttrVal)) Then

            For Each attr In System.Enum.GetValues(GetType(eAttribut))
                ' Clear Values
                tbAttrVal(attr).DataBindings.Clear()
                ' Set Databinding
                tbAttrVal(attr).DataBindings.Add(New Binding("Text", AttributeCollectionToEdit, dataSrc(attr) + ".Value"))
            Next

        End If

    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "Events Handle"

#End Region






End Class
