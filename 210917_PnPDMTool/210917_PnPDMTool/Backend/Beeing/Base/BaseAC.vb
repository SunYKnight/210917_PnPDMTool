Public Class BaseAC
#Region "Enum"
    Public Const cUNLIMITED_BONUS = 100
#End Region

#Region "Private Var"
    Private _baseAC As Integer

    Private _maxBonusStr As Integer = 0
    Private _maxBonusDex As Integer = 0
    Private _maxBonusCon As Integer = 0
    Private _maxBonusWis As Integer = 0
    Private _maxBonusInt As Integer = 0
    Private _maxBonusCha As Integer = 0


#End Region

#Region "Properties"

#End Region

#Region "Init"

    Public Sub New()
        ' Set base value
        _baseAC = 10
        ' Set bonus
        _maxBonusStr = 0
        _maxBonusDex = cUNLIMITED_BONUS
        _maxBonusCon = 0
        _maxBonusWis = 0
        _maxBonusInt = 0
        _maxBonusCha = 0
    End Sub

    Public Sub New(baseAC As Integer)
        ' Set base value
        _baseAC = baseAC
        ' Set bonus
        _maxBonusStr = 0
        _maxBonusDex = 0
        _maxBonusCon = 0
        _maxBonusWis = 0
        _maxBonusInt = 0
        _maxBonusCha = 0
    End Sub

    Public Sub New(baseAC As Integer, maxBonusStr As Integer, maxBonusDex As Integer,
                   maxBonusCon As Integer, maxBonusWis As Integer, maxBonusInt As Integer, maxBonusCha As Integer)
        ' Set base value
        _baseAC = baseAC
        ' Set bonus
        _maxBonusStr = maxBonusStr
        _maxBonusDex = maxBonusDex
        _maxBonusCon = maxBonusCon
        _maxBonusWis = maxBonusWis
        _maxBonusInt = maxBonusInt
        _maxBonusCha = maxBonusCha
    End Sub
#End Region

#Region "Private Sub"

#End Region

#Region "Pubilc Sub"
    Public Function GetValue(strMod As Integer, dexMod As Integer,
                             conMod As Integer, intMod As Integer,
                             wisMod As Integer, chaMod As Integer)
        ' Locals
        Dim ret_val As Integer = _baseAC

        ' Add bonus
        If (strMod < _maxBonusStr) Then
            ret_val += strMod
        Else
            ret_val += _maxBonusStr
        End If

        If (dexMod < _maxBonusDex) Then
            ret_val += dexMod
        Else
            ret_val += _maxBonusDex
        End If

        If (conMod < _maxBonusCon) Then
            ret_val += conMod
        Else
            ret_val += _maxBonusCon
        End If

        If (intMod < _maxBonusInt) Then
            ret_val += intMod
        Else
            ret_val += _maxBonusInt
        End If

        If (wisMod < _maxBonusWis) Then
            ret_val += wisMod
        Else
            ret_val += _maxBonusWis
        End If

        If (chaMod < _maxBonusCha) Then
            ret_val += chaMod
        Else
            ret_val += _maxBonusCha
        End If

        Return ret_val

    End Function
#End Region

#Region "Events"

#End Region

#Region "GUI Handle"

#End Region

End Class
