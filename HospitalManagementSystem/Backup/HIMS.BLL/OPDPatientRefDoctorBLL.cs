using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OPDPatientRefDoctorBLL
	{
        private OPDPatientRefDoctorDAL _oPDPatientRefDoctorDAL;

        public OPDPatientRefDoctorDAL oPDPatientRefDoctorDAL
		{
            get { return _oPDPatientRefDoctorDAL; }
            set { _oPDPatientRefDoctorDAL = value; }
		}

        public OPDPatientRefDoctorBLL()
		{
            oPDPatientRefDoctorDAL = new OPDPatientRefDoctorDAL();
		}
        public int OPDPatientRefDoctorADD(OPDPatientRefDoctor  oPDPatientRefDoctor)
        {
            try
            {
                return oPDPatientRefDoctorDAL.OPDPatientRefDoctorADD(oPDPatientRefDoctor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		
	}
}
