using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;


namespace HIMS.BLL
{
    public class MedicineIssueBLL
    {
        private MedicineIssueDAL _medicineIssueDAL;

        public MedicineIssueDAL medicineIssueDAL
		{
            get { return _medicineIssueDAL; }
            set { _medicineIssueDAL = value; }
		}

        public MedicineIssueBLL()
		{
            medicineIssueDAL = new MedicineIssueDAL();
		}

        public int MedicineIssueAdd(MedicineIssueBO medicineIssueBO)
        {
            try
            {
                return medicineIssueDAL.MedicineIssueAdd(medicineIssueBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
