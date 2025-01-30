using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OTInformationBLL
    {
        private OTInformationDAL _oTInformationDAL;

        public OTInformationDAL oTInformationDAL
		{
            get { return _oTInformationDAL; }
            set { _oTInformationDAL = value; }
		}

        public OTInformationBLL()
		{
            oTInformationDAL = new OTInformationDAL();
		}
        public DataSet OTInformationLoad(int admission_id)
        {
            try
            {
                return oTInformationDAL.OTInformationLoad(admission_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet OTInformationLoadICU(int admission_id)
        {
            try
            {
                return oTInformationDAL.OTInformationLoadICU(admission_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTInformationAdd(OTInformation oTInformation)
        {
            try
            {
                return oTInformationDAL.OTInformationAdd(oTInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTInformationAddICU(OTInformation oTInformation)
        {
            try
            {
                return oTInformationDAL.OTInformationAddICU(oTInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTInformationUpdate(OTInformation oTInformation)
        {
            try
            {
                return oTInformationDAL.OTInformationUpdate(oTInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int OTInformationUpdateICU(OTInformation oTInformation)
        {
            try
            {
                return oTInformationDAL.OTInformationUpdateICU(oTInformation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
