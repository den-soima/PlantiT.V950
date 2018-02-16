using System;
using System.Data;
using PlantiT.Runtime.Database;

namespace PlantiT.Forms.Host
{
    internal static class DBHelper
    {
        public static PIdcDatabase IdcDatabase { get; set; }
        public static int UILanguageId { get; set; }

        public static DataTable GetMessuredViews()
        {
            DataTable tblResult = null;

            string strSQL = String.Format("EXEC {0} @nLangID  = {1}"
              , "dbIdc.dbo.sp_IdcGetMeasureViews"
              , UILanguageId
              );

            tblResult = IdcDatabase.ExecuteQuery(strSQL);

            return tblResult;
        }

        public static DataTable GetMessuredGroups()
        {
            DataTable tblResult = null;

            string strSQL = String.Format("EXEC {0} @nLangID  = {1}"
              , "dbIdc.dbo.sp_IdcGetMeasureViewGroups"
              , UILanguageId
              );

            tblResult = IdcDatabase.ExecuteQuery(strSQL);

            return tblResult;
        }
    }
}
