using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientCCBLL
	{
		private PatientCCDAL _patient_ccDAL;

		public PatientCCDAL patient_ccDAL
		{
			get { return _patient_ccDAL; }
			set { _patient_ccDAL = value; }
		}

		public PatientCCBLL()
		{
			patient_ccDAL = new PatientCCDAL();
		}
		public List<PatientCC> Getpatient_ccsList()
		{
			try
			{
				return patient_ccDAL.Getpatient_ccsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_ccs()
		{
			try
			{
				return patient_ccDAL.Getpatient_ccs();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet PatientCCGetByAdmnID(int admnID)
		{
			try
			{
				return patient_ccDAL.PatientCCGetByAdmnID(admnID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public PatientCC Getpatient_cc(int patient_cc_id)
		{
			try
			{
				return patient_ccDAL.Getpatient_cc(patient_cc_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpatient_cc(PatientCC opatient_cc)
		{
			try
			{
				return patient_ccDAL.Addpatient_cc(opatient_cc);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_cc(PatientCC opatient_cc)
		{
			try
			{
				return patient_ccDAL.Updatepatient_cc(opatient_cc);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_cc(PatientCC opatient_cc)
		{
			try
			{
				return patient_ccDAL.Removepatient_cc(opatient_cc);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_cc(int patient_cc_id)
		{
			try
			{
				return patient_ccDAL.Removepatient_cc(patient_cc_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientCC> Deserializepatient_ccs(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientCC>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_ccs(string Path, List<PatientCC> patient_ccs)
		{
			try
			{
				GenericXmlSerializer<List<PatientCC>>.Serialize(patient_ccs, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
