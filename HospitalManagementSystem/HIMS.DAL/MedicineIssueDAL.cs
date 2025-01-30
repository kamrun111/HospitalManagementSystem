using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;

namespace HIMS.DAL
{
    public class MedicineIssueDAL
    {
        public MedicineIssueDAL()
		{
		}

        public int MedicineIssueAdd(MedicineIssueBO medicineIssueBO)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@issue_date", medicineIssueBO.issue_date);
                arParams[1] = new SqlParameter("@amount", medicineIssueBO.amount);
                arParams[2] = new SqlParameter("@admission_id", medicineIssueBO.admission_id);
                arParams[3] = new SqlParameter("@record_created_by", medicineIssueBO.record_created_by);


                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "patient_medicine_issue", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
