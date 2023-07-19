Imports System.IO
Imports _210917_PnPDMTool.C

Public Class ucEditMap
#Region "Private Var"
    Private DEF_WIDTH As Integer = 10
    Private DEF_HEIGHT As Integer = 10
#End Region

#Region "Properties"
    Public Overrides Property MinimumSize As Size = New Size(C.WIDTH_CONTROL_EDIT, C.HEIGHT_CONTROL_EDIT)
    Public Property Map As New MapType
#End Region

#Region "Init"

    Public Sub New(m As MapType)

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Save beeing
        Me.Map = m

        ' Set border stile
        Me.TableLayoutPanel_Map.BorderStyle = BorderStyle.FixedSingle


    End Sub

#End Region

#Region "Private Sub"
    Private Sub updateMapTiles(width As Integer, heigth As Integer)

        ' Clear current Layout
        Me.TableLayoutPanel_Map.RowStyles().Clear()
        Me.TableLayoutPanel_Map.ColumnStyles().Clear()

        ' Build columns
        For i As Integer = 0 To width - 1
            Me.TableLayoutPanel_Map.ColumnStyles().Add(New ColumnStyle(SizeType.Percent, 100.0F / width))
        Next
        ' Build rows
        For i As Integer = 0 To heigth - 1
            Me.TableLayoutPanel_Map.RowStyles().Add(New RowStyle(SizeType.Percent, 100.0F / heigth))
        Next

        ' Set border stile
        Me.TableLayoutPanel_Map.BorderStyle = BorderStyle.FixedSingle
        Me.TableLayoutPanel_Map.Update()

    End Sub


#End Region

#Region "Pubilc Sub"



    Public Function Save() As Object
        Return Map
    End Function

    Public Function GetOutputType() As Type
        Return GetType(MapType)
    End Function

    Public Function Discard() As Object
        Return Map
    End Function

    Public Sub changeSize(newSize As Size)
        Me.Size = newSize
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Name.DoubleClick
        Dim fs As New FileSelector(MAP_FILES)

        ' CHeck success
        If fs.Path <> "" Then
            ' Save Path
            Map.Path = fs.Path
            ' Save Name
            Map.Name = Map.Path.Split("\").Last()
            ' Display Image
            setMapFromPath(Me.TableLayoutPanel_Map.BackgroundImage, Map.Path, Me.TableLayoutPanel_Map.Width, Me.TableLayoutPanel_Map.Height)
            ' Display Name
            TextBox_Name.Text = Map.Name
        End If

    End Sub

    Private Sub NumericUpDown_width_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_width.ValueChanged
        ' Save Value
        Map.Width = NumericUpDown_width.Value
        ' Update Tiles
        updateMapTiles(Map.Width, Map.Height)

    End Sub

    Private Sub NumericUpDown_height_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_height.ValueChanged
        ' Save Value
        Map.Height = NumericUpDown_height.Value
        ' Update Tiles
        updateMapTiles(Map.Width, Map.Height)
    End Sub


#End Region

#Region "Events"
    Public Event btnMapDiscardClicked()
    Public Event btnMapSaveClicked()
#End Region
End Class
