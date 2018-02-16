DECLARE @szMainMenu NVARCHAR (MAX) 
SELECT @szMainMenu = N'<hostmenu:PHostMenu xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
                      xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
                      xmlns:hostmenu="clr-namespace:PlantiT.Forms.Host.Menu;assembly=PlantiT.Forms.Host"
                      xmlns:hostcontrols="clr-namespace:PlantiT.Forms.Host.Controls;assembly=PlantiT.Forms.Host"
                      xmlns:PMarkup="clr-namespace:PlantiT.Visu.Core.Markup;assembly=PlantiT.Visu.Core">

  <hostmenu:PHostMenuGroup Header="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_PRODUCTION}" IsExpanded="True" HostId="groupProduction">
    <hostmenu:PHostMenuGroup.ToolTip>
        <hostcontrols:PHostToolTip ToolTipText="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_PRODUCTION_GROUP_DESCRIPTION}"/>
    </hostmenu:PHostMenuGroup.ToolTip>
    <hostmenu:PHostMenuButton HostCommand="PIT_VISUSCREEN" HostId="PIT_VISUSCREEN"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_JOBLIST" HostId="PIT_JOBLIST"/>
    <hostmenu:PHostMenuButton HostCommand="BIT_BATCHMATRIX" HostId="BIT_BATCHMATRIX"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_MESSAGEONLINE" HostId="PIT_MESSAGEONLINE"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_STATUSFILTER" HostId="PIT_STATUSFILTER" Visibility="Collapsed"/>
    <Separator/>
    <hostmenu:PHostMenuButton HostCommand="PMM_STOCKOVERVIEW" HostId="PMM_STOCKOVERVIEW"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIALOVERVIEW" HostId="PMM_MATERIALOVERVIEW"/>
    <Separator/>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIALINPUT" HostId="PMM_MATERIALINPUT"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIALOUTPUT" HostId="PMM_MATERIALOUTPUT"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIALLOCK" HostId="PMM_MATERIALLOCK"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIALRELEASE" HostId="PMM_MATERIALRELEASE"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIALMOVEMENT" HostId="PMM_MATERIALMOVEMENT"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIALREDECLARATION" HostId="PMM_MATERIALREDECLARATION"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_INVENTORY" HostId="PMM_INVENTORY"/>
  </hostmenu:PHostMenuGroup>
  <hostmenu:PHostMenuGroup Header="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_MASTER_DATA}" IsExpanded="True" HostId="groupMasterData">
    <hostmenu:PHostMenuGroup.ToolTip>
        <hostcontrols:PHostToolTip ToolTipText="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_MASTERDATA_GROUP_DESCRIPTION}"/>
    </hostmenu:PHostMenuGroup.ToolTip>
    <hostmenu:PHostMenuButton HostCommand="PMM_MATERIAL" HostId="PMM_MATERIAL"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_BOOKINGKEY" HostId="PMM_BOOKINGKEY"/>
    <hostmenu:PHostMenuButton HostCommand="BIT_DOSAGEPARAMETER" HostId="BIT_DOSAGEPARAMETER"/>
    <Separator/>
    <hostmenu:PHostMenuButton HostCommand="PIT_RECIPEOVERVIEW" HostId="PIT_RECIPEOVERVIEW"/>
    <hostmenu:PHostMenuButton HostCommand="LIT_PROCEDUREOVERVIEW" HostId="LIT_PROCEDUREOVERVIEW"/>
    <hostmenu:PHostMenuButton HostCommand="BIT_MATERIALLISTOVERVIEW" HostId="BIT_MATERIALLISTOVERVIEW"/>
    <hostmenu:PHostMenuButton HostCommand="BIT_PROCESSDESCRIPTIONOVERVIEW" HostId="BIT_PROCESSDESCRIPTIONOVERVIEW"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_GLOBALPROCESSVARIABLE" HostId="PIT_GLOBALPROCESSVARIABLE"/>
  </hostmenu:PHostMenuGroup>
  <hostmenu:PHostMenuGroup Header="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_INVESTIGATION}" IsExpanded="False" HostId="groupInvestigation">
    <hostmenu:PHostMenuGroup.ToolTip>
        <hostcontrols:PHostToolTip ToolTipText="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_INVESTIGATION_GROUP_DESCRIPTION}"/>
    </hostmenu:PHostMenuGroup.ToolTip>
    <hostmenu:PHostMenuButton HostCommand="PIT_ARCHIVEDJOBS" HostId="PIT_ARCHIVEDJOBS"/>
    <hostmenu:PHostMenuButton HostCommand="PMM_STOCKROTATION" HostId="PMM_STOCKROTATION"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_MESSAGEARCHIVE" HostId="PIT_MESSAGEARCHIVE"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_ACQUISITARCHIVE" HostId="PIT_ACQUISITARCHIVE"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_MAINTENANCE" HostId="PIT_MAINTENANCE"/>
    <hostmenu:PHostMenuButton HostCommand="PIT_MEASUREVIEWVIEWER" HostId="PIT_MEASUREVIEWVIEWER"/>
    <!--<hostmenu:PHostMenuButton HostCommand="PIC_2CA61228-2567-404B-A1CF-382F348B630D_PlantiT-UPS-AcquisiTMeasureView" HostId="PIC_2CA61228-2567-404B-A1CF-382F348B630D_PlantiT-UPS-AcquisiTMeasureView"/>-->
    <Separator/>
    <hostmenu:PHostMenuButton HostCommand="PIT_REPORTGENERICCALL" HostId="PIT_REPORTGENERICCALL"/>
  </hostmenu:PHostMenuGroup>
 <hostmenu:PHostMenuGroup Header="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_ADDONS}" IsExpanded="True" HostId="groupAddons">
    <hostmenu:PHostMenuGroup.ToolTip>
        <hostcontrols:PHostToolTip ToolTipText="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Forms.Host.dll, TextLink=TXT_ADDONS}"/>
    </hostmenu:PHostMenuGroup.ToolTip>
    <hostmenu:PHostMenuButton HostCommand="PIT_CHARTS_MVALINECHART" HostId="PIT_CHARTS_MVALINECHART"/>
  </hostmenu:PHostMenuGroup>   
  <hostmenu:PHostMenuGroup Header="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Integrate.Config.dll, TextLink=TXT_MENUTITEL}" IsExpanded="False" HostId="groupIntegrateConfig">
    <hostmenu:PHostMenuGroup.ToolTip>
        <hostcontrols:PHostToolTip ToolTipText="{PMarkup:PStringFromLngFile AssemblyName=PlantiT.Integrate.Config.dll, TextLink=TXT_APPTITEL}"/>
    </hostmenu:PHostMenuGroup.ToolTip>
    <hostmenu:PHostMenuButton HostCommand="PIC_CFG_SOURCESYSTEM" HostId="PIC_CFG_SOURCESYSTEM" />
    <hostmenu:PHostMenuButton HostCommand="PIC_CFG_TARGETSYSTEM" HostId="PIC_CFG_TARGETSYSTEM" />
    <Separator/>
    <hostmenu:PHostMenuButton HostCommand="PIC_CFG_ADMINSYSTEM" HostId="PIC_CFG_ADMINSYSTEM" />
  </hostmenu:PHostMenuGroup>
</hostmenu:PHostMenu>'

UPDATE  tblPiTHostConfiguration
	SET szMainMenu = @szMainMenu
WHERE nKey = -1


