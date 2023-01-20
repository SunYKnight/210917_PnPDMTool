Imports System.Diagnostics.Metrics
Imports System.Security.Cryptography
Imports System.Xml
Imports System.Xml.Serialization

Public Class xml(Of t)
    Public Sub Serialize(obj As t, desc As String, path As String)
        ' Locals
        Dim wset As New XmlWriterSettings()
        Dim serializer As New XmlSerializer(GetType(t), desc)

        ' Set Settings
        wset.Indent = True

        ' Write File
        Using xmlW As XmlWriter = XmlWriter.Create(path, wset)
            serializer.Serialize(xmlW, obj)
        End Using
    End Sub

    Public Function Deserialize(path As String, desc As String) As t
        ' Locals
        Dim serializer As New XmlSerializer(GetType(t), desc)
        Dim obj As t

        ' Read File
        Using xmlR As XmlReader = XmlReader.Create(path)
            obj = serializer.Deserialize(xmlR)
        End Using

        Return obj
    End Function
End Class
