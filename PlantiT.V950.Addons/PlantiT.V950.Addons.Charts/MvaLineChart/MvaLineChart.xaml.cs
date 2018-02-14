using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using PlantiT.Forms;
using PlantiT.Forms.Host;
using PlantiT.Runtime.Security;
using PlantiT.Runtime.Configuration;

namespace PlantiT.Forms.Host
{
    [PHostCommand(PHostCommandsAddonsCharts.PIT_CHARTS_MVALINECHART,
                Caption = "TXT_ARTICLEVIEW_SEMIFINISHED",
                Name = "TXT_ARTICLEVIEW_SEMIFINISHED",
                Description = "TXT_ARTICLEVIEW_SEMIFINISHED",
                Image = "material",
                AvailabilityCheckerType = typeof(MvaLineChartViewAvailabilityChecker),
                PolicyRightGuid = PHostRightAddonsCharts.PIT_CHARTS_RIGHT_MVALINECHART,
                Ribbon = typeof(MvaLineChartRibbon))]
    /// <summary>
    /// Interaction logic for MvaLineChart.xaml
    /// </summary>
    public partial class MvaLineChart : PUserControl
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

        public MvaLineChart()
        {
            InitializeComponent();
        }   
    }
}
