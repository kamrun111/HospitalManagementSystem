using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OPDAdmissionBLL
	{
		private OPDAdmissionDAL _OPDAdmissionDAL;

		public OPDAdmissionDAL oPDAdmissionDAL
		{
			get { return _OPDAdmissionDAL; }
			set { _OPDAdmissionDAL = value; }
		}

        public OPDAdmissionBLL()
		{
            oPDAdmissionDAL = new OPDAdmissionDAL();
		}
        public string OPDadmissionAdd(OPDPatient  oPDPatient,OPDAdmission  oPDAdmission)
        {
            try
            {
                return oPDAdmissionDAL.OPDadmissionAdd(oPDPatient, oPDAdmission);
            }
            catch (Exception ex)
            {
            throw ex;
            }
        }
		
	}
}
