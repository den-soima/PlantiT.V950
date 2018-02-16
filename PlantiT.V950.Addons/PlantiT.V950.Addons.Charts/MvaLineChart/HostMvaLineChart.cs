using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlantiT.Forms.Host;
using PlantiT.Forms;
using PlantiT.Runtime.Language;
using PlantiT.Core;
using PlantiT.Runtime.Database;
using PlantiT.Runtime.Security;
using PlantiT.Runtime.Configuration;
using PlantiT.Forms.Host.AddIns;

namespace PlantiT.Forms.Host
{
    [PHostCommand(PHostCommandsAddonsCharts.PIT_CHARTS_MVALINECHART,
               Caption = "TXT_CHARTS_MVALINECHART",
               Name = "TXT_CHARTS_MVALINECHART",
               Description = "TXT_CHARTS_MVALINECHART",
               Image = "material",
               AvailabilityCheckerType = typeof(MvaLineChartViewAvailabilityChecker),
               PolicyRightGuid = PHostRightAddonsCharts.PIT_CHARTS_RIGHT_MVALINECHART,
               Ribbon = typeof(MvaLineChartRibbon))]

    public partial class HostMvaLineChart : PAddInControl
    {
        public class MvaLineChartViewAvailabilityChecker : PHostCommandAvailabilityChecker
        {
            /// <summary>
            /// Prüft, ob der übergebene Host-Befehl im aktuellen Kontext ausgeführt werden kann.
            /// </summary>
            /// <param name="strCommand">Der Host-Befehl.</param>
            /// <param name="extraParam">Der zusätzliche Parameter des Befehls.</param>
            /// <param name="processArea">Der Prozessbereich, wo der Befehl ausgeführt werden muss.</param>
            /// <returns>True - der Host-Befehl darf ausgeführt werden, sonst false.</returns>
            public override bool IsAvailable(string strCommand, object extraParam, PlantiT.Forms.Host.Data.PProcessArea processArea)
            {
                IPHostInstallationSettingsService hostSettings = PServiceContainer.GetGlobalService<IPHostInstallationSettingsService>();
                bool bReturnValue = true;
                if (null != hostSettings)
                {
                    bReturnValue = !hostSettings.CheckSetupWSRole(PSystemConfiguration.PPlantiTWSRole.RUNTIME);
                }

                if (bReturnValue)
                    bReturnValue = PSecurityAccess.CheckPolicyAccess(new Guid(PHostRightAddonsCharts.PIT_CHARTS_RIGHT_MVALINECHART), processArea.Key);

                return processArea.IsGlobal && bReturnValue;
            }
        }

        public const string HOSTID_CHARTS_MVALINECHART_DATA = "DATA";
        public const string HOSTID_CHARTS_MVALINECHART_REFRESH = "HOSTID_LMS_ARTICLEDETAILS_REFRESH";

        public const string RIGHT_MVALINECHART_REFRESH = "RIGHT_MVALINECHART_REFRESH";
        public const string RIGHT_MVALINECHART_REFRESH_GUID = "09A7CB8F-D8B6-433F-A220-1B64479ED5FD";       

        public HostMvaLineChart()
        {
            DBHelper.IdcDatabase = this.Database;
            DBHelper.UILanguageId = this.UILanguageId;
            InitializeComponent();           
        }
    }
}
