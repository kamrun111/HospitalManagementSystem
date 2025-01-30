using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class PatientDischargeBLL
    {
        private PatientDischargeDAL _patientDischargeDAL;

        public PatientDischargeDAL patientDischargeDAL
		{
            get { return _patientDischargeDAL; }
            set { _patientDischargeDAL = value; }
		}

        public PatientDischargeBLL()
		{
            patientDischargeDAL = new PatientDischargeDAL();
		}

        public DataSet dischargeMedicine(int admissionID)
        {
            try
            {
                return patientDischargeDAL.dischargeMedicine(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int medicineDichageADD(List<PatientDischarge> lstPatientDischarge)//sami
        {
            try
            {
                return patientDischargeDAL.medicineDichageADD(lstPatientDischarge);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
