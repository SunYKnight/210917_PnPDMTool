Public Class DiceType
    ' Würfel abstraktion
#Region "Enum"
    Public Enum EThrowType
        Normal
        Advantage
        Disadvantage
    End Enum
#End Region


#Region "Private Var"
    Private roll_history As Integer()
#End Region

#Region "Properties"
    Private Property Eyes As Integer

#End Region

#Region "Init"
    Public Sub New(eyes As Integer)
        ' Save class parameter
        Me.Eyes = eyes

        ' Init privates
        roll_history = New Integer(eyes) {}

        For i = 1 To eyes
            roll_history(i - 1) = 0
        Next
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Evaluate(count As Integer, type As EThrowType) As Integer
        ' Locals
        Dim Generator As System.Random = New System.Random()
        Dim result As Integer
        Dim result1 As Integer
        Dim result2 As Integer
        Dim sum As Integer = 0

        For i = 0 To count - 1

            ' Get result
            result1 = Generator.Next(1, Eyes + 1)

            ' Save Result
            roll_history(result1 - 1) += 1
            ' Notify
            RaiseEvent DiceRolled(Me, result1)

            ' relect roll type
            Select Case type
                Case EThrowType.Advantage
                    ' Get second roll
                    result2 = Generator.Next(1, Eyes + 1)
                    ' Save Result
                    roll_history(result2 - 1) += 1
                    ' Notify
                    RaiseEvent DiceRolled(Me, result2)

                    ' Check result
                    If (result1 > result2) Then
                        result = result1
                    Else
                        result = result2
                    End If


                Case EThrowType.Disadvantage
                    ' Get second roll
                    result2 = Generator.Next(1, Eyes + 1)
                    ' Save Result
                    roll_history(result2 - 1) += 1
                    ' Notify
                    RaiseEvent DiceRolled(Me, result2)

                    ' Check result
                    If (result1 < result2) Then
                        result = result1
                    Else
                        result = result2
                    End If


                Case EThrowType.Normal
                    ' Set result
                    result = result1

            End Select

            ' Evaluate Set
            sum += result

        Next

        System.Console.WriteLine(count.ToString & " D" & Eyes.ToString & "rolled: " & sum.ToString())

        Return sum

    End Function


#End Region

#Region "Events"
    Public Event DiceRolled(dice As DiceType, result As Integer)
#End Region
End Class



