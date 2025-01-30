using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class PatientConsultantBLL
    {
        private PatientConsultantDAL _patientConsultantDAL;

        public PatientConsultantDAL patientConsultantDAL
		{
            get { return _patientConsultantDAL; }
            set { _patientConsultantDAL = value; }
		}

        public PatientConsultantBLL()
		{
            patientConsultantDAL = new PatientConsultantDAL();
		}

        public int patientconsultationADD(Patient patient,PatientConsultantBO  patientConsultantBO,List<ConsultationBO> lstConsultationBO)
        {
            try
            {
                return patientConsultantDAL.patientconsultationADD(patient, patientConsultantBO, lstConsultationBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int patientconsultationUpdate(Patient patient, PatientConsultantBO patientConsultantBO, List<ConsultationBO> lstConsultationBO)
        {
            try
            {
                return patientConsultantDAL.patientconsultationUpdate(patient, patientConsultantBO, lstConsultationBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
