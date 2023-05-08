Public Class BaseAC
#Region "Enum"
    Public Const cUNLIMITED_BONUS = 100
#End Region

#Region "Private Var"

#End Region

#Region "Properties"
    Public Property Base As Integer = 10
    Public Property MaxBonusStr As Integer = 0
    Public Property MaxBonusDex As Integer = 0
    Public Property MaxBonusCon As Integer = 0
    Public Property MaxBonusWis As Integer = 0
    Public Property MaxBonusInt As Integer = 0
    Public Property MaxBonusCha As Integer = 0
#End Region

#Region "Init"

    Public Sub New()

    End Sub

    Public Sub New(baseAC As Integer)
        ' Set base value
        Base = baseAC
    End Sub

    Public Sub New(baseAC As Integer, maxBonusStr As Integer, maxBonusDex As Integer,
                   maxBonusCon As Integer, maxBonusWis As Integer, maxBonusInt As Integer, maxBonusCha As Integer)

        ' Set base value
        Base = baseAC
        ' Set bonus
        Me.MaxBonusStr = maxBonusStr
        Me.MaxBonusDex = maxBonusDex
        Me.MaxBonusCon = maxBonusCon
        Me.MaxBonusWis = maxBonusWis
        Me.MaxBonusInt = maxBonusInt
        Me.MaxBonusCha = maxBonusCha

    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function GetValue(strMod As Integer, dexMod As Integer,
                             conMod As Integer, wisMod As Integer,
                             intMod As Integer, chaMod As Integer)
        ' Locals
        Dim ret_val As Integer = Base

        ' Add bonus
        If (strMod < MaxBonusStr) Then
            ret_val += strMod
        Else
            ret_val += MaxBonusStr
        End If

        If (dexMod < MaxBonusDex) Then
            ret_val += dexMod
        Else
            ret_val += MaxBonusDex
        End If

        If (conMod < MaxBonusCon) Then
            ret_val += conMod
        Else
            ret_val += MaxBonusCon
        End If

        If (wisMod < MaxBonusWis) Then
            ret_val += wisMod
        Else
            ret_val += MaxBonusWis
        End If

        If (intMod < MaxBonusInt) Then
            ret_val += wisMod
        Else
            ret_val += MaxBonusInt
        End If

        If (chaMod < MaxBonusCha) Then
            ret_val += chaMod
        Else
            ret_val += MaxBonusCha
        End If

        Return ret_val

    End Function
#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region

End Class
