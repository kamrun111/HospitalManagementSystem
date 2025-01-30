using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;

namespace HIMS.DAL
{
	public class DoctorLevelDAL
	{
		public DoctorLevelDAL()
		{
		}
		public List<DoctorLevel> Getdoctor_levelsList()
		{
			SqlConnection conn = null;
            List<DoctorLevel> lstdoctor_levels = new List<DoctorLevel>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "doctor_levelGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    DoctorLevel odoctor_level = new DoctorLevel();
					odoctor_level.doctor_level_id = Convert.ToInt32(dataReader["doctor_level_id"]);

					if(dataReader["doctor_level"] != DBNull.Value)
						odoctor_level.doctor_level = Convert.ToString(dataReader["doctor_level"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odoctor_level.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odoctor_level.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odoctor_level.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odoctor_level.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstdoctor_levels.Add(odoctor_level);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return lstdoctor_levels;
		}
		public DataSet Getdoctor_levels()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "doctor_levelGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DoctorLevel Getdoctor_level(int doctor_level_id)
		{
			SqlConnection conn = null;
            DoctorLevel odoctor_level = new DoctorLevel();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@doctor_level_id", doctor_level_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "doctor_levelGet", arParams, ref conn);
				while (dataReader.Read())
				{
					odoctor_level.doctor_level_id = Convert.ToInt32(dataReader["doctor_level_id"]);

					if(dataReader["doctor_level"] != DBNull.Value)
						odoctor_level.doctor_level = Convert.ToString(dataReader["doctor_level"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odoctor_level.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odoctor_level.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odoctor_level.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odoctor_level.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return odoctor_level;
		}
        public int Adddoctor_level(DoctorLevel odoctor_level)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@doctor_level", odoctor_level.doctor_level);
				arParams[1] = new SqlParameter("@record_created_by", odoctor_level.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odoctor_level.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "doctor_levelAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatedoctor_level(DoctorLevel odoctor_level)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@doctor_level", odoctor_level.doctor_level);
				arParams[1] = new SqlParameter("@record_created_by", odoctor_level.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odoctor_level.record_modified_by);
				arParams[3] = new SqlParameter("@doctor_level_id", odoctor_level.doctor_level_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "doctor_levelUpdate", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@doctor_level_id", odoctor_level.doctor_level_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "doctor_levelDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@doctor_level_id", doctor_level_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "doctor_levelDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
