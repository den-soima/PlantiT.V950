using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantiT.Forms.Host.Models
{
    public class MeasuredViewModel
    {
        public List<MeasuredCurveModel> MessuredCurves { get; set; }
        public int Key { get; set; }
        public string ViewName { get; set; }
        public string LangName { get; set; }
        public int GroupLink { get; set; }
        public string GroupName { get; set; }
    }
}
