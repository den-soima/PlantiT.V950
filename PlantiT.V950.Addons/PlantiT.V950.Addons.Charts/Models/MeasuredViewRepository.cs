using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantiT.Runtime.Database;

namespace PlantiT.Forms.Host.Models
{
    public class MeasuredViewRepository
    {
        private readonly List<MeasuredViewGroupModel> mvGroupsRepository;
        private readonly List<MeasuredViewModel> mvItemsRepository;        

        public MeasuredViewRepository()
        {
            mvGroupsRepository = new List<MeasuredViewGroupModel>();
            mvItemsRepository = new List<MeasuredViewModel>();

            DataTable tblMeasuredViewGroups = DBHelper.GetMessuredGroups();
            mvGroupsRepository = GetMeasureViewGroups(tblMeasuredViewGroups);

            DataTable tblMeasuredViews = DBHelper.GetMessuredViews();
            mvItemsRepository = GetMeasureViews(tblMeasuredViews);
        }

        public IList<MeasuredViewModel> MessuredViews
        { 
            get { return mvItemsRepository; }
        }

        public IList<MeasuredViewGroupModel> MessuredViewGroups
        {
            get { return mvGroupsRepository; }
        }

        private List<MeasuredViewGroupModel> GetMeasureViewGroups(DataTable tbl)
        {
            List<MeasuredViewGroupModel> list = new List<MeasuredViewGroupModel>();
            foreach (DataRow row in tbl.Rows)
            {                
                MeasuredViewGroupModel mvGroup = new MeasuredViewGroupModel() {
                    Key = row.Field<int>("nKey"),
                    Name = row.Field<string>("szName"),
                    LangName = row.Field<string>("szLangName")
                };
                list.Add(mvGroup);
            }
            return list;
        }

        private List<MeasuredViewModel> GetMeasureViews(DataTable tbl)
        {
            List<MeasuredViewModel> list = new List<MeasuredViewModel>();
            foreach (DataRow row in tbl.Rows)
            {
                MeasuredViewModel mvItem = new MeasuredViewModel()
                {
                    Key = row.Field<int>("nKey"),
                    ViewName = row.Field<string>("szViewName"),
                    LangName = row.Field<string>("szLangName"),
                    GroupLink = row.Field<int>("nGroupLink"),
                    GroupName = row.Field<string>("szGroupName"),
                };
                list.Add(mvItem);
            }
            return list;
        }
    }
}
