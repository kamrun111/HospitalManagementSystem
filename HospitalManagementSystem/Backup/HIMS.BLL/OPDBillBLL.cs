using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OPDBillBLL
	{
        private OPDBillDAL _oPDBillDAL;

        public OPDBillDAL oPDBillDAL
		{
            get { return _oPDBillDAL; }
            set { _oPDBillDAL = value; }
		}

        public OPDBillBLL()
		{
            oPDBillDAL = new OPDBillDAL();
		}
        public DataSet OPDBillGetByRegID(string RegistrationID)
        {
            try
            {
                return oPDBillDAL.OPDBillGetByRegID(RegistrationID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OPDBillGet( )
        {
            try
            {
                return oPDBillDAL.OPDBillGet( );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int updateOPDBILL(OPDBill opdBill)
        {
            try
            {
                return oPDBillDAL.updateOPDBILL(opdBill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateOPDPatientBiLL(OPDBill opdBill)
        {
            try
            {
                return oPDBillDAL.UpdateOPDPatientBiLL(opdBill);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		
	}
}
