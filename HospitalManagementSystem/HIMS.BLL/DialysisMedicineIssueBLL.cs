using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;


namespace HIMS.BLL
{
    public class DialysisMedicineIssueBLL
    {
        private DialysisMedicineIssueDAL _dialysisMedicineIssueDAL;
        public DialysisMedicineIssueDAL dialysisMedicineIssueDAL
        {
            get { return _dialysisMedicineIssueDAL; }
            set { _dialysisMedicineIssueDAL = value; }
        }

        public DialysisMedicineIssueBLL()
        {
            dialysisMedicineIssueDAL = new DialysisMedicineIssueDAL();
        }

        public int DialysisMedicineIssueAdd(DialysisMedicineIssueBO dialysisMedicineIssueBO, List<DialysisMedicineIssueDetailsBO> listDialysisMedicineIssueDetailsBO)
        {
            try
            {
                return dialysisMedicineIssueDAL.DialysisMedicineIssueInsert(dialysisMedicineIssueBO, listDialysisMedicineIssueDetailsBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
