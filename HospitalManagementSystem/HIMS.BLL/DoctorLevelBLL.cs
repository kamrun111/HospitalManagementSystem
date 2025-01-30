using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class DoctorLevelBLL
	{
		private DoctorLevelDAL _doctor_levelDAL;

		public DoctorLevelDAL doctor_levelDAL
		{
			get { return _doctor_levelDAL; }
			set { _doctor_levelDAL = value; }
		}

		public DoctorLevelBLL()
		{
			doctor_levelDAL = new DoctorLevelDAL();
		}
		public List<DoctorLevel> Getdoctor_levelsList()
		{
			try
			{
				return doctor_levelDAL.Getdoctor_levelsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getdoctor_levels()
		{
			try
			{
				return doctor_levelDAL.Getdoctor_levels();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DoctorLevel Getdoctor_level(int doctor_level_id)
		{
			try
			{
				return doctor_levelDAL.Getdoctor_level(doctor_level_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Adddoctor_level(DoctorLevel odoctor_level)
		{
			try
			{
				return doctor_levelDAL.Adddoctor_level(odoctor_level);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatedoctor_level(DoctorLevel odoctor_level)
		{
			try
			{
				return doctor_levelDAL.Updatedoctor_level(odoctor_level);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removedoctor_level(DoctorLevel odoctor_level)
		{
			try
			{
				return doctor_levelDAL.Removedoctor_level(odoctor_level);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedoctor_level(int doctor_level_id)
		{
			try
			{
				return doctor_levelDAL.Removedoctor_level(doctor_level_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<DoctorLevel> Deserializedoctor_levels(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<DoctorLevel>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializedoctor_levels(string Path, List<DoctorLevel> doctor_levels)
		{
			try
			{
                GenericXmlSerializer<List<DoctorLevel>>.Serialize(doctor_levels, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
