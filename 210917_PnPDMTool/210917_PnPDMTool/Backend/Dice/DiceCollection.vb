Imports _210917_PnPDMTool.C
Public Class DiceCollection

#Region "Private Var"
    Public Property D4Count As Integer = 0
    Public Property D6Count As Integer = 0
    Public Property D8Count As Integer = 0
    Public Property D12Count As Integer = 0
    Public Property D20Count As Integer = 0
    Public Property D100Count As Integer = 0

#End Region

#Region "Properties"

#End Region

#Region "Init"
    Public Sub Init()

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function Evaluate(diceSet As DiceSet, type As DiceType.EThrowType)
        ' Locals
        Dim ret_val As Integer = 0

        ' Roll all dice
        ret_val += diceSet.D4.Evaluate(D4Count, type)
        ret_val += diceSet.D6.Evaluate(D4Count, type)
        ret_val += diceSet.D8.Evaluate(D4Count, type)
        ret_val += diceSet.D12.Evaluate(D4Count, type)
        ret_val += diceSet.D20.Evaluate(D4Count, type)
        ret_val += diceSet.D100.Evaluate(D4Count, type)

        Return ret_val

    End Function


#End Region

#Region "Events"

#End Region
End Class
