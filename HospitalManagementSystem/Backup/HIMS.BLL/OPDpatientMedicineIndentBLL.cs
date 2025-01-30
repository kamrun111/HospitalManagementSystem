using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OPDpatientMedicineIndentBLL
    {
        private OPDpatientMedicineIndentDAL _opdpatientMedicineIndentDAL;

        public OPDpatientMedicineIndentDAL opdpatientMedicineIndentDAL
		{
			get { return _opdpatientMedicineIndentDAL; }
			set { _opdpatientMedicineIndentDAL = value; }
		}

        public OPDpatientMedicineIndentBLL()
		{
            opdpatientMedicineIndentDAL = new OPDpatientMedicineIndentDAL();
		}

        public DataSet getopdinfo(int opdid)
        {
            try
            {
                return opdpatientMedicineIndentDAL.getopdinfo(opdid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getallcharge(int pkid)
        {
            try
            {
                return opdpatientMedicineIndentDAL.getallcharge(pkid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet getmedicinedelivery(int pkid)
        {
            try
            {
                return opdpatientMedicineIndentDAL.getmedicinedelivery(pkid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataSet getopdmedicinedelivery(int pkid)
        {
            try
            {
                return opdpatientMedicineIndentDAL.getopdmedicinedelivery(pkid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

       
    }
}
