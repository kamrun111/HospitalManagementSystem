using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OutdoorPatientMedicationBLL
	{
		private OutdoorPatientMedicationDAL _outdoor_patient_medicationDAL;

		public OutdoorPatientMedicationDAL outdoor_patient_medicationDAL
		{
			get { return _outdoor_patient_medicationDAL; }
			set { _outdoor_patient_medicationDAL = value; }
		}

		public OutdoorPatientMedicationBLL()
		{
			outdoor_patient_medicationDAL = new OutdoorPatientMedicationDAL();
		}
		public List<OutdoorPatientMedication> Getoutdoor_patient_medicationsList()
		{
			try
			{
				return outdoor_patient_medicationDAL.Getoutdoor_patient_medicationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getoutdoor_patient_medications()
		{
			try
			{
				return outdoor_patient_medicationDAL.Getoutdoor_patient_medications();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public OutdoorPatientMedication Getoutdoor_patient_medication(int outdoor_patient_medication_id)
		{
			try
			{
				return outdoor_patient_medicationDAL.Getoutdoor_patient_medication(outdoor_patient_medication_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addoutdoor_patient_medication(OutdoorPatientMedication ooutdoor_patient_medication)
		{
			try
			{
				return outdoor_patient_medicationDAL.Addoutdoor_patient_medication(ooutdoor_patient_medication);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_medication(OutdoorPatientMedication ooutdoor_patient_medication)
		{
			try
			{
				return outdoor_patient_medicationDAL.Updateoutdoor_patient_medication(ooutdoor_patient_medication);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_medication(OutdoorPatientMedication ooutdoor_patient_medication)
		{
			try
			{
				return outdoor_patient_medicationDAL.Removeoutdoor_patient_medication(ooutdoor_patient_medication);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_medication(int outdoor_patient_medication_id)
		{
			try
			{
				return outdoor_patient_medicationDAL.Removeoutdoor_patient_medication(outdoor_patient_medication_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<OutdoorPatientMedication> Deserializeoutdoor_patient_medications(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<OutdoorPatientMedication>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoutdoor_patient_medications(string Path, List<OutdoorPatientMedication> outdoor_patient_medications)
		{
			try
			{
				GenericXmlSerializer<List<OutdoorPatientMedication>>.Serialize(outdoor_patient_medications, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetOutdoorMedicne(int outdoor_booking_id)
        {
            try
            {
                return outdoor_patient_medicationDAL.GetOutdoorMedicne(outdoor_booking_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int RemoveoutdoorpatientVisit(int outdoor_booking_id)
        {
            try
            {
                return outdoor_patient_medicationDAL.RemoveoutdoorpatientVisit(outdoor_booking_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
