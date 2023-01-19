Public Class ComboboxBinder(Of t)
#Region "Enum"

#End Region

#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub New(cb As System.Windows.Forms.ComboBox, srcObj As Object, valueName As String)
        Dim binding = New Binding("SelectedIndex", srcObj, valueName, True, DataSourceUpdateMode.OnPropertyChanged)
        AddHandler binding.Format, AddressOf binding_Format
        AddHandler binding.Parse, AddressOf binding_Parse
        cb.DataBindings.Clear()
        cb.DataBindings.Add(binding)
    End Sub
#End Region

#Region "Private Sub"
    Private Sub binding_Parse(sender As Object, e As ConvertEventArgs)
        If e.DesiredType = GetType(t) Then
            e.Value = System.Enum.GetValues(GetType(t)).GetValue(CInt(e.Value))
        End If
    End Sub

    Private Sub binding_Format(sender As Object, e As ConvertEventArgs)
        If e.DesiredType = GetType(Integer) Then
            e.Value = Array.IndexOf(System.Enum.GetValues(GetType(t)), e.Value)
        End If
    End Sub
#End Region

#Region "Pubilc Sub"

#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region
End Class
