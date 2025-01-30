using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;


namespace HIMS.BLL
{
    public class PatientOTMedicineBLL
    {
        private PatientOTMedicineDAL _patientOTMedicineDAL;
        public PatientOTMedicineDAL patientOTMedicineDAL
        {
            get { return _patientOTMedicineDAL; }
            set { _patientOTMedicineDAL = value; }
        }

        public PatientOTMedicineBLL()
        {
            patientOTMedicineDAL = new PatientOTMedicineDAL();
        }

        public int OTMedicineAdd(PatientOTMedicineBO patientOTMedicineBO, List<PatientOTMedicineDetailsBO> listPatientOTMedicineDetailsBO)
        {
            try
            {
                return patientOTMedicineDAL.PatientOTMedicineInsert(patientOTMedicineBO, listPatientOTMedicineDetailsBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
