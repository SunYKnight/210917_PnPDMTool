Public Module BaseIdentificationNumber

#Region "Private Var"

#End Region

#Region "Properties"

#End Region

#Region "Init"

#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function GetNewID() As Long
        ' Locals
        Dim Generator As System.Random = New System.Random()
        Dim newID As Long

        ' Build ID
        newID = 0
        newID += Now.Year
        newID *= 13
        newID += Now.Month
        newID *= 32
        newID += Now.Day
        newID *= 24
        newID += Now.Hour
        newID *= (2 ^ 32)
        newID += Generator.Next

        Return newID
    End Function
#End Region

#Region "Events"

#End Region
End Module
