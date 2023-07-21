Imports _210917_PnPDMTool.C

Public Class UcBattleMapView
#Region "Private Var"
    Private _map As MapType
#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

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
            selected_tile = _map.getTile(col, row)
        End If

        ' Check success
        If (col >= 0 And row >= 0) Then

        End If

    End Sub
#End Region

#Region "Pubilc Sub"

    Public Sub setMap(m As MapType)
        _map = m
        ' Display Image
        setMapFromPath(TableLayoutPanel_Map.BackgroundImage, _map.Path, TableLayoutPanel_Map.Width, TableLayoutPanel_Map.Height)
        ' Draw tiles
        updateMapTiles(_map.Width, _map.Height)
    End Sub

    Public Sub changeSize(newSize As Size)
        Me.Size = newSize

        Me.lbMap.Size = New Size(Me.Width, HEIGHT_TITLE)

        'Me.pictureboxmap.size = New Size(Me.Width - 2 * GAP_SMALL, Me.Height - GAP_SMALL - HEIGHT_TITLE)

        'Me.pictureBoxInitiative1.Size = New Size(CInt((Me.pictureboxmap.width - 19 * GAP_SMALL) / 18), CInt((Me.pictureboxmap.width - 19 * GAP_SMALL) / 18))
        Me.pictureBoxInitiative2.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative3.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative4.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative5.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative6.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative7.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative8.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative9.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative10.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative11.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative12.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative13.Size = Me.pictureBoxInitiative1.Size
        Me.pictureBoxInitiative14.Size = Me.pictureBoxInitiative1.Size

        Me.lbMap.Location = New Point(0, 0)
        'Me.pictureBoxMap.Location = New Point(GAP_SMALL, HEIGHT_TITLE)

        'Me.pictureBoxInitiative1.Location = New Point(3 * GAP_SMALL + 2 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative2.Location = New Point(4 * GAP_SMALL + 3 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative3.Location = New Point(5 * GAP_SMALL + 4 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative4.Location = New Point(6 * GAP_SMALL + 5 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative5.Location = New Point(7 * GAP_SMALL + 6 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative6.Location = New Point(8 * GAP_SMALL + 7 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative7.Location = New Point(9 * GAP_SMALL + 8 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative8.Location = New Point(10 * GAP_SMALL + 9 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative9.Location = New Point(11 * GAP_SMALL + 10 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative10.Location = New Point(12 * GAP_SMALL + 11 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative11.Location = New Point(13 * GAP_SMALL + 12 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative12.Location = New Point(14 * GAP_SMALL + 13 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative13.Location = New Point(15 * GAP_SMALL + 14 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
        'Me.pictureBoxInitiative14.Location = New Point(16 * GAP_SMALL + 15 * Me.pictureBoxInitiative1.Width, Me.pictureBoxMap.Location.Y)
    End Sub

#End Region

#Region "Events"
    Public Event btnNewMapClicked()
    Public Event LoggingNotification(txt As String)
#End Region
End Class
