using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientMedicineBLL
	{
		private PatientMedicineDAL _patient_medicineDAL;

		public PatientMedicineDAL patient_medicineDAL
		{
			get { return _patient_medicineDAL; }
			set { _patient_medicineDAL = value; }
		}

		public PatientMedicineBLL()
		{
			patient_medicineDAL = new PatientMedicineDAL();
		}
		public List<PatientMedicine> Getpatient_medicinesList()
		{
			try
			{
				return patient_medicineDAL.Getpatient_medicinesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_medicines()
		{
			try
			{
				return patient_medicineDAL.Getpatient_medicines();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public PatientMedicine Getpatient_medicine(int patient_medicine_id)
		{
			try
			{
				return patient_medicineDAL.Getpatient_medicine(patient_medicine_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpatient_medicine(PatientMedicine opatient_medicine)
		{
			try
			{
				return patient_medicineDAL.Addpatient_medicine(opatient_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_medicine(PatientMedicine opatient_medicine)
		{
			try
			{
				return patient_medicineDAL.Updatepatient_medicine(opatient_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_medicine(PatientMedicine opatient_medicine)
		{
			try
			{
				return patient_medicineDAL.Removepatient_medicine(opatient_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_medicine(int patient_medicine_id)
		{
			try
			{
				return patient_medicineDAL.Removepatient_medicine(patient_medicine_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientMedicine> Deserializepatient_medicines(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientMedicine>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_medicines(string Path, List<PatientMedicine> patient_medicines)
		{
			try
			{
				GenericXmlSerializer<List<PatientMedicine>>.Serialize(patient_medicines, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
