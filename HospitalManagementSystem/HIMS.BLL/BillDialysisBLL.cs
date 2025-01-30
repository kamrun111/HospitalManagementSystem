using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class BillDialysisBLL
    {
        private BillDialysisDAL _billDialysisDAL;
        public BillDialysisDAL billDialysisDAL
        {
            get { return _billDialysisDAL; }
            set { _billDialysisDAL = value; }
        }
        public BillDialysisBLL()
        {
            billDialysisDAL = new BillDialysisDAL();
        }
        public int BillDialysisAdd(BillDialysisBO billDialysisBO)
        {
            try
            {
                return billDialysisDAL.BillDialysisAdd(billDialysisBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

    }
}
