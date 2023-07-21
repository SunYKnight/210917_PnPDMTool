Imports System.IO
Imports _210917_PnPDMTool.C
Imports _210917_PnPDMTool.TileType

Public Class ucEditMap
#Region "Private Var"
    Private DEF_WIDTH As Integer = 10
    Private DEF_HEIGHT As Integer = 10
    Private selcted_tiles As New List(Of TileType)
#End Region

#Region "Properties"
    Public Overrides Property MinimumSize As Size = New Size(C.WIDTH_CONTROL_EDIT, C.HEIGHT_CONTROL_EDIT)
    Public Property Map As New MapType
#End Region

#Region "Init"

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        NewCommon()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.Map = New MapType()

        Map.Width = DEF_WIDTH
        Map.Height = DEF_HEIGHT

        ' Check size
        If (Map.Width > 0 And Map.Height > 0) Then
            ' Update Tiles
            updateMapTiles(Map.Width, Map.Height)
        End If

    End Sub

    Public Sub New(m As MapType)

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        NewCommon()

        ' Save beeing
        Me.Map = m

        NumericUpDown_width.Value = Map.Width
        NumericUpDown_height.Value = Map.Height

        ' Check size
        If (Map.Width > 0 And Map.Height > 0) Then
            ' Update Tiles
            updateMapTiles(Map.Width, Map.Height)
        End If

        ' Update Map display
        updateMap()

    End Sub

    Private Sub NewCommon()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Reset selection
        resetSelectedTiles()

        ' Set combobox data
        ComboBox_wall_north.DataSource = System.Enum.GetValues(GetType(eWallType))
        ComboBox_wall_east.DataSource = System.Enum.GetValues(GetType(eWallType))
        ComboBox_wall_west.DataSource = System.Enum.GetValues(GetType(eWallType))
        ComboBox_wall_south.DataSource = System.Enum.GetValues(GetType(eWallType))
        ComboBox_light.DataSource = System.Enum.GetValues(GetType(eLightIntensity))
        ComboBox_gound.DataSource = System.Enum.GetValues(GetType(eGroundType))
    End Sub


#End Region

#Region "Private Sub"

    Private Sub updateMapTiles(cols As Integer, rows As Integer)
        Dim layout As FlowLayoutPanel

        ' Pause Control draw
        TableLayoutPanel_Map.SuspendLayout()

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
               .BackColor = Color.Transparent,
               .Name = c.ToString + "," + r.ToString}
                layout.Controls.Add(New ucTile())
                Me.TableLayoutPanel_Map.Controls.Add(layout, c, r)

                ' Fast forward mouse click
                AddHandler layout.MouseClick, AddressOf PanelClickHandle
            Next
        Next

        ' Continue Control draw
        TableLayoutPanel_Map.ResumeLayout(True)

        ' Set border stile
        Me.TableLayoutPanel_Map.BorderStyle = BorderStyle.FixedSingle
        Me.TableLayoutPanel_Map.Update()

    End Sub

    Private Sub updateMap()
        If (Map.Name <> "" And Map.Path <> "") Then
            ' Display Image
            setMapFromPath(Me.TableLayoutPanel_Map.BackgroundImage, Map.Path, Me.TableLayoutPanel_Map.Width, Me.TableLayoutPanel_Map.Height)
            ' Display Name
            TextBox_Name.Text = Map.Name
        End If
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
#End Region

#Region "GUI Handle"
    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Name.DoubleClick
        Dim fs As New FileSelector(MAP_FILES)

        ' CHeck success
        If fs.Path <> "" Then
            ' Save Path
            Map.Path = fs.Path
            ' Save Name
            Map.Name = Map.Path.Split("\").Last()
            ' Update Map display
            updateMap()
        End If

    End Sub

    Private Sub NumericUpDown_width_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_width.ValueChanged
        ' Save Value
        Map.Width = NumericUpDown_width.Value
    End Sub

    Private Sub NumericUpDown_height_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown_height.ValueChanged
        ' Save Value
        Map.Height = NumericUpDown_height.Value

    End Sub

    Private Sub Button_set_Click(sender As Object, e As EventArgs) Handles Button_set.Click
        ' Check size
        If (Map.Width > 0 And Map.Height > 0) Then
            ' Update Tiles
            updateMapTiles(Map.Width, Map.Height)

            ' Create Tiles
            Map.UpdateTiles(Map.Width, Map.Height)
        End If
    End Sub

    Private Sub PanelClickHandle(sender As Object, e As EventArgs) Handles TableLayoutPanel_Map.MouseClick
        Dim a As Integer = 0
        Dim row As Integer = -1
        Dim col As Integer = -1
        Dim raw_data As String()
        Dim layout As FlowLayoutPanel = CType(sender, FlowLayoutPanel)
        Dim selected_tile As TileType

        ' Split index data
        raw_data = Split(layout.Name, ",")

        ' Check success
        If raw_data.Length = 2 Then
            col = CType(raw_data(0), Integer?)
            row = CType(raw_data(1), Integer?)
            selected_tile = Map.getTile(col, row)
            getTileParameter(selected_tile)
            If CheckBox_set_start_tile.Checked Then
                NumericUpDown_start_height.Value = row
                NumericUpDown_start_width.Value = col
            Else
                NumericUpDown_stop_height.Value = row
                NumericUpDown_stop_width.Value = col
            End If

        End If

        ' Check success
        If (col >= 0 And row >= 0) Then
            If (Not CheckBox_multiselect.Checked) Then
                resetSelectedTiles()
            End If
            selcted_tiles.Add(selected_tile)
            layout.BorderStyle = BorderStyle.Fixed3D
        End If

    End Sub

    Private Sub getTileParameter(tile As TileType)
        ' Display parameter
        ComboBox_wall_east.SelectedIndex = tile.Base.WallEast
        ComboBox_wall_west.SelectedIndex = tile.Base.WallWest
        ComboBox_wall_north.SelectedIndex = tile.Base.WallNorth
        ComboBox_wall_south.SelectedIndex = tile.Base.WallSouth
        ComboBox_light.SelectedIndex = tile.Base.LightIntensity
        ComboBox_gound.SelectedIndex = tile.Base.GroundMaterial
        NumericUpDown_elevation.Value = tile.Base.Elevation
        NumericUpDown_free_sky.Value = tile.Base.FreeSky_ft
        CheckBox_is_difficult_terrain.Checked = tile.Base.IsDifficultTerrain
        CheckBox_is_trap.Checked = tile.Base.IsTrap

        ' Enable controls
        ComboBox_wall_east.Enabled = True
        ComboBox_wall_west.Enabled = True
        ComboBox_wall_north.Enabled = True
        ComboBox_wall_south.Enabled = True
        ComboBox_light.Enabled = True
        ComboBox_gound.Enabled = True
        NumericUpDown_elevation.Enabled = True
        NumericUpDown_free_sky.Enabled = True
        CheckBox_is_difficult_terrain.Enabled = True
        CheckBox_is_trap.Enabled = True
    End Sub

    Private Sub setTileParameter(tile As TileType)
        ' Save parameter to tile Base
        If (ComboBox_wall_east.Enabled) Then
            tile.Base.WallEast = ComboBox_wall_east.SelectedIndex
        End If
        If (ComboBox_wall_west.Enabled) Then
            tile.Base.WallWest = ComboBox_wall_west.SelectedIndex
        End If
        If (ComboBox_wall_north.Enabled) Then
            tile.Base.WallNorth = ComboBox_wall_north.SelectedIndex
        End If
        If (ComboBox_wall_south.Enabled) Then
            tile.Base.WallSouth = ComboBox_wall_south.SelectedIndex
        End If
        If (ComboBox_light.Enabled) Then
            tile.Base.LightIntensity = ComboBox_light.SelectedIndex
        End If
        If (ComboBox_gound.Enabled) Then
            tile.Base.GroundMaterial = ComboBox_gound.SelectedIndex
        End If
        If (NumericUpDown_elevation.Enabled) Then
            tile.Base.Elevation = NumericUpDown_elevation.Value
        End If
        If (NumericUpDown_free_sky.Enabled) Then
            tile.Base.FreeSky_ft = NumericUpDown_free_sky.Value
        End If
        If (CheckBox_is_difficult_terrain.Enabled) Then
            tile.Base.IsDifficultTerrain = CheckBox_is_difficult_terrain.Checked
        End If
        If (CheckBox_is_trap.Enabled) Then
            tile.Base.IsTrap = CheckBox_is_trap.Checked
        End If

        ' Save parameter to tile Temp
        tile.Temp.WallEast = tile.Base.WallEast
        tile.Temp.WallWest = tile.Base.WallWest
        tile.Temp.WallNorth = tile.Base.WallNorth
        tile.Temp.WallSouth = tile.Base.WallSouth
        tile.Temp.LightIntensity = tile.Base.LightIntensity
        tile.Temp.GroundMaterial = tile.Base.GroundMaterial
        tile.Temp.Elevation = tile.Base.Elevation
        tile.Temp.FreeSky_ft = tile.Base.FreeSky_ft
        tile.Temp.IsDifficultTerrain = tile.Base.IsDifficultTerrain
        tile.Temp.IsTrap = tile.Base.IsTrap
    End Sub

    Private Sub resetSelectedTiles()
        ' Clear list
        selcted_tiles.Clear()

        ' Pause Control draw
        TableLayoutPanel_Map.SuspendLayout()

        ' Reser View
        For Each c In TableLayoutPanel_Map.Controls
            c.BorderStyle = BorderStyle.FixedSingle
        Next

        ' Continue Control draw
        TableLayoutPanel_Map.ResumeLayout(True)

        ' Enable controls
        ComboBox_wall_east.Enabled = False
        ComboBox_wall_west.Enabled = False
        ComboBox_wall_north.Enabled = False
        ComboBox_wall_south.Enabled = False
        ComboBox_light.Enabled = False
        ComboBox_gound.Enabled = False
        NumericUpDown_elevation.Enabled = False
        NumericUpDown_free_sky.Enabled = False
        CheckBox_is_difficult_terrain.Enabled = False
        CheckBox_is_trap.Enabled = False

    End Sub


    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        resetSelectedTiles()
    End Sub

    Private Sub Button_apply_selection_Click(sender As Object, e As EventArgs) Handles Button_apply_to_area.Click
        ' Check values
        If (NumericUpDown_start_height.Value <= NumericUpDown_stop_height.Value) Then
            If (NumericUpDown_start_width.Value <= NumericUpDown_stop_width.Value) Then
                For c As Integer = NumericUpDown_start_width.Value To NumericUpDown_stop_width.Value
                    For r As Integer = NumericUpDown_start_height.Value To NumericUpDown_stop_height.Value
                        setTileParameter(Map.getTile(c, r))
                    Next
                Next
            End If
        End If
        ' Reset selection
        resetSelectedTiles()
    End Sub

    Private Sub Button_apply_to_selection_Click(sender As Object, e As EventArgs) Handles Button_apply_to_selection.Click
        For Each t In selcted_tiles
            setTileParameter(t)
        Next
    End Sub


#End Region

#Region "Events"
    Public Event btnMapDiscardClicked()
    Public Event btnMapSaveClicked()
#End Region
End Class
