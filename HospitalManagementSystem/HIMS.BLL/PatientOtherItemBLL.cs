using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientOtherItemBLL
	{
		private PatientOtherItemDAL _patient_other_itemDAL;

		public PatientOtherItemDAL patient_other_itemDAL
		{
			get { return _patient_other_itemDAL; }
			set { _patient_other_itemDAL = value; }
		}

		public PatientOtherItemBLL()
		{
			patient_other_itemDAL = new PatientOtherItemDAL();
		}
		public List<PatientOtherItem> Getpatient_other_itemsList()
		{
			try
			{
				return patient_other_itemDAL.Getpatient_other_itemsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_other_items()
		{
			try
			{
				return patient_other_itemDAL.Getpatient_other_items();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet GetPatientOtherItemByAdmnID(int admissionID)
		{
			try
			{
				return patient_other_itemDAL.GetPatientOtherItemByAdmnID(admissionID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		public PatientOtherItem Getpatient_other_item(int patient_other_item_id)
		{
			try
			{
				return patient_other_itemDAL.Getpatient_other_item(patient_other_item_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int OtherItemAddforOPD(PatientOtherItem opatient_other_item)
		{
			try
			{
				return patient_other_itemDAL.OtherItemAddforOPD(opatient_other_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Addpatient_other_item(PatientOtherItem opatient_other_item)   
        {
            try
            {
                return patient_other_itemDAL.Addpatient_other_item(opatient_other_item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Addpatient_other_itemDialysis(PatientOtherItem opatient_other_item)   
        {
            try
            {
                return patient_other_itemDAL.Addpatient_other_itemDialysis(opatient_other_item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Addpatient_other_itemICU(PatientOtherItem opatient_other_item)
        {
            try
            {
                return patient_other_itemDAL.Addpatient_other_itemICU(opatient_other_item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Updatepatient_other_item(PatientOtherItem opatient_other_item)
		{
			try
			{
				return patient_other_itemDAL.Updatepatient_other_item(opatient_other_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int patientotheritemQtyUpdate(PatientOtherItem opatient_other_item)
        {
            try
            {
                return patient_other_itemDAL.patientotheritemQtyUpdate(opatient_other_item);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
		public int Removepatient_other_item(PatientOtherItem opatient_other_item)
		{
			try
			{
				return patient_other_itemDAL.Removepatient_other_item(opatient_other_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_other_item(int patient_other_item_id)
		{
			try
			{
				return patient_other_itemDAL.Removepatient_other_item(patient_other_item_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientOtherItem> Deserializepatient_other_items(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientOtherItem>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_other_items(string Path, List<PatientOtherItem> patient_other_items)
		{
			try
			{
				GenericXmlSerializer<List<PatientOtherItem>>.Serialize(patient_other_items, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
