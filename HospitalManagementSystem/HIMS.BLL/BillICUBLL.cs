using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class BillICUBLL
    {
        private BillICUDAL _billICUDAL;
        public BillICUDAL billICUDAL
        {
            get { return _billICUDAL; }
            set { _billICUDAL = value; }
        }
        public BillICUBLL()
        {
            billICUDAL = new BillICUDAL();
        }

        public int BillICUAdd(BillICUBO billICUBO)
        {
            try
            {
                return billICUDAL.BillICUAdd(billICUBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
