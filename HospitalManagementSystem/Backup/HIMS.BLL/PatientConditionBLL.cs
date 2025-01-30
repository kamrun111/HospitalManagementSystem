using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientConditionBLL
	{
		private PatientConditionDAL _patient_conditionDAL;

		public PatientConditionDAL patient_conditionDAL
		{
			get { return _patient_conditionDAL; }
			set { _patient_conditionDAL = value; }
		}

		public PatientConditionBLL()
		{
			patient_conditionDAL = new PatientConditionDAL();
		}
		public List<PatientCondition> Getpatient_conditionsList()
		{
			try
			{
				return patient_conditionDAL.Getpatient_conditionsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_conditions()
		{
			try
			{
				return patient_conditionDAL.Getpatient_conditions();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public PatientCondition Getpatient_condition(int patient_condition_id)
		{
			try
			{
				return patient_conditionDAL.Getpatient_condition(patient_condition_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpatient_condition(PatientCondition opatient_condition)
		{
			try
			{
				return patient_conditionDAL.Addpatient_condition(opatient_condition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatepatient_condition(PatientCondition opatient_condition)
		{
			try
			{
				return patient_conditionDAL.Updatepatient_condition(opatient_condition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_condition(PatientCondition opatient_condition)
		{
			try
			{
				return patient_conditionDAL.Removepatient_condition(opatient_condition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_condition(int patient_condition_id)
		{
			try
			{
				return patient_conditionDAL.Removepatient_condition(patient_condition_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientCondition> Deserializepatient_conditions(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientCondition>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_conditions(string Path, List<PatientCondition> patient_conditions)
		{
			try
			{
				GenericXmlSerializer<List<PatientCondition>>.Serialize(patient_conditions, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
