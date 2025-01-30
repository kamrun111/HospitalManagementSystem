using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OtherIncomeBLL
    {
        private OtherIncomeDAL _otherIncomeDAL;

        public OtherIncomeDAL otherIncomeDAL
		{
            get { return _otherIncomeDAL; }
            set { _otherIncomeDAL = value; }
		}

        public OtherIncomeBLL()
		{
            otherIncomeDAL = new OtherIncomeDAL();
		}

        public DataSet IncomeHeadLoad()
        {
            try
            {
                return otherIncomeDAL.IncomeHeadLoad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OtherIncomeAdd(OtherIncomeBO otherIncomeBO)
        {
            try
            {
                return otherIncomeDAL.OtherIncomeAdd(otherIncomeBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
