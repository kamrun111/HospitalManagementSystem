using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OtsheduleBLL
    {
        private OtsheduleDAL _otsheduleDAL;

        public OtsheduleDAL otsheduleDAL
        {
            get { return _otsheduleDAL; }
            set { _otsheduleDAL = value; }
        }

        public OtsheduleBLL()
        {
            otsheduleDAL = new OtsheduleDAL();
        }

        public int OtsheduleADD(OTShedule oOtshedule)
        {
            try
            {
                return otsheduleDAL.OtsheduleADD(oOtshedule);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetSurgenOperation()
        {
            try
            {
                return otsheduleDAL.GetSurgenOperation();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOT(DateTime date1,DateTime date2)
        {
            try
            {
                return otsheduleDAL.GetOT(date1,date2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}