using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class MedicineTimingBLL
	{
		private MedicineTimingDAL _medicine_timingDAL;

		public MedicineTimingDAL medicine_timingDAL
		{
			get { return _medicine_timingDAL; }
			set { _medicine_timingDAL = value; }
		}

		public MedicineTimingBLL()
		{
			medicine_timingDAL = new MedicineTimingDAL();
		}
        public List<MedicineTiming> Getmedicine_timingsList()
		{
			try
			{
                return _medicine_timingDAL.Getmedicine_timingsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getmedicine_timings()
		{
			try
			{
				return medicine_timingDAL.Getmedicine_timings();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public MedicineTiming Getmedicine_timing(int medicine_timing_id)
		{
			try
			{
                return _medicine_timingDAL.Getmedicine_timing(medicine_timing_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addmedicine_timing(MedicineTiming omedicine_timing)
		{
			try
			{
				return medicine_timingDAL.Addmedicine_timing(omedicine_timing);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatemedicine_timing(MedicineTiming omedicine_timing)
		{
			try
			{
				return medicine_timingDAL.Updatemedicine_timing(omedicine_timing);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removemedicine_timing(MedicineTiming omedicine_timing)
		{
			try
			{
				return medicine_timingDAL.Removemedicine_timing(omedicine_timing);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removemedicine_timing(int medicine_timing_id)
		{
			try
			{
				return medicine_timingDAL.Removemedicine_timing(medicine_timing_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<MedicineTiming> Deserializemedicine_timings(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<MedicineTiming>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializemedicine_timings(string Path, List<MedicineTiming> medicine_timings)
		{
			try
			{
                GenericXmlSerializer<List<MedicineTiming>>.Serialize(medicine_timings, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
