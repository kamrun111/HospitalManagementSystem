using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OtherserviceBLL
    {
        private OtherserviceDAL _otherserviceDAL;

        public OtherserviceDAL otherserviceDAL
		{
            get { return _otherserviceDAL; }
            set { _otherserviceDAL = value; }
		}

        public OtherserviceBLL()
		{
            otherserviceDAL = new OtherserviceDAL();
		}

        public int patientserviceADD(Patient patient, OtherserviceBO otherserviceBO, List<OtherServiceListBO> lstOtherServiceListBO)
        {
            try
            {
                return otherserviceDAL.patientserviceADD(patient, otherserviceBO, lstOtherServiceListBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int patientupdateADD(Patient patient, OtherserviceBO otherserviceBO, List<OtherServiceListBO> lstOtherServiceListBO)
        {
            try
            {
                return otherserviceDAL.patientupdateADD(patient, otherserviceBO, lstOtherServiceListBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getservices(int patientID)
        {
            try
            {
                return otherserviceDAL.getservices(patientID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
