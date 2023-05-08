Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports _210917_PnPDMTool.C
Imports _210917_PnPDMTool.ucAttributCollection

Public Class ucBStats

#Region "Private Var"
    Friend WithEvents _ucLanguageList As ucItemList(Of eLanguages)
    Friend WithEvents _ucDmgResistanceList As ucItemList(Of eDmgType)
    Friend WithEvents _ucDmgImmunityList As ucItemList(Of eDmgType)
    Friend WithEvents _ucDmgVunrabilityList As ucItemList(Of eDmgType)
    Friend WithEvents _ucConditionImmunityList As ucItemList(Of eCondidtion)
    Friend WithEvents _ucSavingThrowProfiecenies As ucItemList(Of eAttribut)
    Friend WithEvents _ucSkillProfiecencies As ucItemList(Of eSkills)
    Friend WithEvents _ucSkillExpertieses As ucItemList(Of eSkills)

    Friend WithEvents _ucProficencyTools As ucItemList(Of eTools)
    Friend WithEvents _ucProficencyWeapons As ucItemList(Of eWeapons)
    Friend WithEvents _ucProficencyArmours As ucItemList(Of eArmours)
#End Region

#Region "Properties"
    Public Property Beeing As BeeingType
#End Region

#Region "Init"

    Public Sub New(beeing As BeeingType)

        Me.Beeing = beeing

        ' Call common Constructor
        NewCommon()
    End Sub

    Public Sub NewCommon()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' DmgImmunity
        _ucProficencyTools = New ucItemList(Of eTools)(Beeing.Stats.ToolsProficencies, "Tools Proficencies", True)
        _ucProficencyTools.Location = New Point(250, 20)
        Me.Controls.Add(Me._ucProficencyTools)

        ' DmgResistance
        _ucProficencyWeapons = New ucItemList(Of eWeapons)(Beeing.Stats.WeaponProficencies, "Weapon Proficencies", True)
        _ucProficencyWeapons.Location = New Point(250, 190)
        Me.Controls.Add(Me._ucProficencyWeapons)

        ' DmgVulnerability
        _ucProficencyArmours = New ucItemList(Of eArmours)(Beeing.Stats.ArmourProficencies, "Armour Proficencies", True)
        _ucProficencyArmours.Location = New Point(250, 360)
        Me.Controls.Add(Me._ucProficencyArmours)



        ' SavingThrowProficencies
        _ucSavingThrowProfiecenies = New ucItemList(Of eAttribut)(Beeing.Stats.SavingThrowProficencies, "Saving Throws", True)
        _ucSavingThrowProfiecenies.Location = New Point(400, 20)
        Me.Controls.Add(Me._ucSavingThrowProfiecenies)

        ' Languages
        _ucLanguageList = New ucItemList(Of eLanguages)(Beeing.Stats.KnownLanguages, "Languages", True)
        _ucLanguageList.Location = New Point(400, 190)
        Me.Controls.Add(Me._ucLanguageList)



        ' ConditionImmunity
        _ucConditionImmunityList = New ucItemList(Of eCondidtion)(Beeing.Stats.ConditionImmunities, "Condition Immunity", True)
        _ucConditionImmunityList.Location = New Point(550, 20)
        Me.Controls.Add(Me._ucConditionImmunityList)

        ' SkillProficencies
        _ucSkillProfiecencies = New ucItemList(Of eSkills)(Beeing.Stats.SkillProficencies, "Skill Proficencies", True)
        _ucSkillProfiecencies.Location = New Point(550, 190)
        Me.Controls.Add(Me._ucSkillProfiecencies)

        ' SkillProficencies
        _ucSkillExpertieses = New ucItemList(Of eSkills)(Beeing.Stats.SkillExpertieses, "Skill Expertieses", True)
        _ucSkillExpertieses.Location = New Point(550, 360)
        Me.Controls.Add(Me._ucSkillExpertieses)



        ' DmgImmunity
        _ucDmgImmunityList = New ucItemList(Of eDmgType)(Beeing.Stats.DmgImmunities, "DMG Immunities", True)
        _ucDmgImmunityList.Location = New Point(700, 20)
        Me.Controls.Add(Me._ucDmgImmunityList)

        ' DmgResistance
        _ucDmgResistanceList = New ucItemList(Of eDmgType)(Beeing.Stats.DmgResistances, "DMG Resistance", True)
        _ucDmgResistanceList.Location = New Point(700, 190)
        Me.Controls.Add(Me._ucDmgResistanceList)

        ' DmgVulnerability
        _ucDmgVunrabilityList = New ucItemList(Of eDmgType)(Beeing.Stats.DmgVulnerabilites, "DMG Vulnerability", True)
        _ucDmgVunrabilityList.Location = New Point(700, 360)
        Me.Controls.Add(Me._ucDmgVunrabilityList)

        ' Update data
        UpdateDatabinding()

    End Sub

#End Region

#Region "Private Sub"

    Private Sub SetDatabinding(ByRef cbc As ControlBindingsCollection, dest As String, src As String)
        cbc.Clear()
        cbc.Add(New Binding(dest, Beeing, src))
    End Sub


    Private Sub UpdateDatabinding()
        ' Locals
        Dim prop_name As String

        ' Handle Stats
        prop_name = "Stats."

        ' Bonus
        SetDatabinding(NumericUpDown_bonus_hp.DataBindings, "Value", prop_name + "BonusAC")
        SetDatabinding(NumericUpDown_bonus_speed_burrow.DataBindings, "Value", prop_name + "BonusSpeed.Burrow")
        SetDatabinding(NumericUpDown_bonus_speed_climb.DataBindings, "Value", prop_name + "BonusSpeed.Climb")
        SetDatabinding(NumericUpDown_bonus_speed_fly.DataBindings, "Value", prop_name + "BonusSpeed.Fly")
        SetDatabinding(NumericUpDown_bonus_speed_swim.DataBindings, "Value", prop_name + "BonusSpeed.Swim")
        SetDatabinding(NumericUpDown_bonus_speed_walk.DataBindings, "Value", prop_name + "BonusSpeed.Walk")
        SetDatabinding(NumericUpDown_bonus_ac.DataBindings, "Value", prop_name + "BonusAC")
        SetDatabinding(NumericUpDown_bonus_str.DataBindings, "Value", prop_name + "BonusStrength")
        SetDatabinding(NumericUpDown_bonus_dex.DataBindings, "Value", prop_name + "BonusDexterity")
        SetDatabinding(NumericUpDown_bonus_con.DataBindings, "Value", prop_name + "BonusConstitution")
        SetDatabinding(NumericUpDown_bonus_wis.DataBindings, "Value", prop_name + "BonusWisdom")
        SetDatabinding(NumericUpDown_bonus_int.DataBindings, "Value", prop_name + "BonusIntelligence")
        SetDatabinding(NumericUpDown_bonus_cha.DataBindings, "Value", prop_name + "BonusCharisma")

        ' Base
        SetDatabinding(NumericUpDown_base_speed_burrow.DataBindings, "Value", prop_name + "BaseSpeed.Burrow")
        SetDatabinding(NumericUpDown_base_speed_climb.DataBindings, "Value", prop_name + "BaseSpeed.Climb")
        SetDatabinding(NumericUpDown_base_speed_fly.DataBindings, "Value", prop_name + "BaseSpeed.Fly")
        SetDatabinding(NumericUpDown_base_speed_swim.DataBindings, "Value", prop_name + "BaseSpeed.Swim")
        SetDatabinding(NumericUpDown_base_speed_walk.DataBindings, "Value", prop_name + "BaseSpeed.Walk")
        SetDatabinding(NumericUpDown_base_str.DataBindings, "Value", prop_name + "Strength.Value")
        SetDatabinding(NumericUpDown_base_dex.DataBindings, "Value", prop_name + "Dexterity.Value")
        SetDatabinding(NumericUpDown_base_con.DataBindings, "Value", prop_name + "Constitution.Value")
        SetDatabinding(NumericUpDown_base_wis.DataBindings, "Value", prop_name + "Wisdom.Value")
        SetDatabinding(NumericUpDown_base_int.DataBindings, "Value", prop_name + "Intelligence.Value")
        SetDatabinding(NumericUpDown_base_cha.DataBindings, "Value", prop_name + "Charisma.Value")
        SetDatabinding(NumericUpDown_base_ac.DataBindings, "Value", prop_name + "AC.Base")
        SetDatabinding(NumericUpDown_base_ac_bonus_str.DataBindings, "Value", prop_name + "AC.MaxBonusStr")
        SetDatabinding(NumericUpDown_base_ac_bonus_dex.DataBindings, "Value", prop_name + "AC.MaxBonusDex")
        SetDatabinding(NumericUpDown_base_ac_bonus_con.DataBindings, "Value", prop_name + "AC.MaxBonusCon")
        SetDatabinding(NumericUpDown_base_ac_bonus_wis.DataBindings, "Value", prop_name + "AC.MaxBonusWis")
        SetDatabinding(NumericUpDown_base_ac_bonus_int.DataBindings, "Value", prop_name + "AC.MaxBonusInt")
        SetDatabinding(NumericUpDown_base_ac_bonus_cha.DataBindings, "Value", prop_name + "AC.MaxBonusCha")


    End Sub
#End Region

#Region "Pubilc Sub"

    Private Sub ResizeHandle(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim labelSize = New Size(WIDTH_TEXT_MEDIUM, HEIGHT_TEXT_BOX)
        Dim textBoxSize = New Size(WIDTH_TEXT_SMALL, HEIGHT_TEXT_BOX)


        '' Attributs
        'Me.UcAttributCollection1.Size = C.CalcRelativeSize(Me.Size, 0.25, 0.8, Me.UcAttributCollection1.MinimumSize)
        'Me.UcAttributCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcAttributCollection1.Size, 0.6, 0.85)

        'Me.UcSavingThrowCollection1.Size = C.CalcRelativeSize(Me.Size, 0.175, 0.2, Me.UcSavingThrowCollection1.MinimumSize)
        'Me.UcSavingThrowCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSavingThrowCollection1.Size, 0.6, 0.2)

        'Me.UcSkillCollection1.Size = C.CalcRelativeSize(Me.Size, 0.1, 0.7, Me.UcSkillCollection1.MinimumSize)
        'Me.UcSkillCollection1.Location = C.CalcRelativeLocation(Me.Size, Me.UcSkillCollection1.Size, 0.85, 0.5)

        'Me.TextBox_name.Location = C.CalcRelativeLocation(Me.Size, Me.TextBox_name.Size, 0.15, 0.1)
        'Me.ComboBox_Size.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_Size.Size, 0.15, 0.15)
        'Me.ComboBox_aligment_personality.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_aligment_personality.Size, 0.2, 0.15)
        'Me.ComboBox_aligment_behaviour.Location = C.CalcRelativeLocation(Me.Size, Me.ComboBox_aligment_behaviour.Size, 0.2, 0.2)
        'Me.PictureBox_image.Location = C.CalcRelativeLocation(Me.Size, Me.PictureBox_image.Size, 0.15, 0.5)

    End Sub



#End Region

#Region "Events"

#End Region

End Class
