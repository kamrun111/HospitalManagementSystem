using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OutdoorPatientAdviceBLL
	{
		private OutdoorPatientAdviceDAL _outdoor_patient_adviceDAL;

		public OutdoorPatientAdviceDAL outdoor_patient_adviceDAL
		{
			get { return _outdoor_patient_adviceDAL; }
			set { _outdoor_patient_adviceDAL = value; }
		}

		public OutdoorPatientAdviceBLL()
		{
			outdoor_patient_adviceDAL = new OutdoorPatientAdviceDAL();
		}
		public List<OutdoorPatientAdvice> Getoutdoor_patient_advicesList()
		{
			try
			{
				return outdoor_patient_adviceDAL.Getoutdoor_patient_advicesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getoutdoor_patient_advices()
		{
			try
			{
				return outdoor_patient_adviceDAL.Getoutdoor_patient_advices();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public OutdoorPatientAdvice Getoutdoor_patient_advice(int outdoor_patient_advice_id)
		{
			try
			{
				return outdoor_patient_adviceDAL.Getoutdoor_patient_advice(outdoor_patient_advice_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addoutdoor_patient_advice(OutdoorPatientAdvice ooutdoor_patient_advice)
		{
			try
			{
				return outdoor_patient_adviceDAL.Addoutdoor_patient_advice(ooutdoor_patient_advice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_advice(OutdoorPatientAdvice ooutdoor_patient_advice)
		{
			try
			{
				return outdoor_patient_adviceDAL.Updateoutdoor_patient_advice(ooutdoor_patient_advice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_advice(OutdoorPatientAdvice ooutdoor_patient_advice)
		{
			try
			{
				return outdoor_patient_adviceDAL.Removeoutdoor_patient_advice(ooutdoor_patient_advice);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_advice(int outdoor_patient_advice_id)
		{
			try
			{
				return outdoor_patient_adviceDAL.Removeoutdoor_patient_advice(outdoor_patient_advice_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<OutdoorPatientAdvice> Deserializeoutdoor_patient_advices(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<OutdoorPatientAdvice>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoutdoor_patient_advices(string Path, List<OutdoorPatientAdvice> outdoor_patient_advices)
		{
			try
			{
				GenericXmlSerializer<List<OutdoorPatientAdvice>>.Serialize(outdoor_patient_advices, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetOutdoorAdvice(char outdoor_booking_id, DateTime record_created_date)
        {
            try
            {
                return outdoor_patient_adviceDAL.GetOutdoorAdvice(outdoor_booking_id, record_created_date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
