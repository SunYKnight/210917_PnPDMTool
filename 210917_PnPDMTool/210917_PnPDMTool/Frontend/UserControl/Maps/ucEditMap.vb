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
    Private Sub updateMapTiles(cols As Integer, rows As Integer)
        Dim layout As FlowLayoutPanel

        SuspendLayout()

        ' Clear current Layout
        Me.TableLayoutPanel_Map.Controls.Clear()
        Me.TableLayoutPanel_Map.RowStyles().Clear()
        Me.TableLayoutPanel_Map.ColumnStyles().Clear()

        Me.TableLayoutPanel_Map.ColumnCount = cols
        Me.TableLayoutPanel_Map.RowCount = rows

        ' Build columns
        For i As Integer = 0 To cols - 1
            Me.TableLayoutPanel_Map.ColumnStyles().Add(New ColumnStyle(SizeType.Percent, 100.0F / cols))
        Next
        ' Build rows
        For i As Integer = 0 To rows - 1
            Me.TableLayoutPanel_Map.RowStyles().Add(New RowStyle(SizeType.Percent, 100.0F / rows))
        Next
        For r As Integer = 0 To rows - 1
            For c As Integer = 0 To cols - 1
                layout = New FlowLayoutPanel With {
               .Dock = DockStyle.Fill,
               .BorderStyle = BorderStyle.FixedSingle,
               .Margin = New Padding(0),
               .BackColor = Color.Transparent}
                layout.Controls.Add(New ucTile())
                Me.TableLayoutPanel_Map.Controls.Add(layout, c, r)
            Next
        Next

        ResumeLayout(False)
        PerformLayout()

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

        ' Check size
        If (Map.Width > 0 And Map.Height > 0) Then
            ' Update Tiles
            updateMapTiles(Map.Width, Map.Height)
        End If


    End Sub

    Private Sub NumericUpDown_height_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_height.ValueChanged
        ' Save Value
        Map.Height = NumericUpDown_height.Value
        ' Check size
        If (Map.Width > 0 And Map.Height > 0) Then
            ' Update Tiles
            updateMapTiles(Map.Width, Map.Height)
        End If
    End Sub


#End Region

#Region "Events"
    Public Event btnMapDiscardClicked()
    Public Event btnMapSaveClicked()
#End Region
End Class
