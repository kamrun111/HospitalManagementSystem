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
	public class IntakeSysDAL
	{
		public IntakeSysDAL()
		{
		}
		public List<IntakeSys> Getintake_syssList()
		{
			SqlConnection conn = null;
			List<IntakeSys> lstintake_syss = new List<IntakeSys>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "intake_sysGetAll", null, ref conn);
				while (dataReader.Read())
				{
					IntakeSys ointake_sys = new IntakeSys();
					ointake_sys.intake_sys_id = Convert.ToInt32(dataReader["intake_sys_id"]);

					if(dataReader["intake_sys"] != DBNull.Value)
						ointake_sys.intake_sys = Convert.ToString(dataReader["intake_sys"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ointake_sys.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ointake_sys.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ointake_sys.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ointake_sys.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstintake_syss.Add(ointake_sys);
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
			return lstintake_syss;
		}
		public DataSet Getintake_syss()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "intake_sysGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public IntakeSys Getintake_sys(int intake_sys_id)
		{
			SqlConnection conn = null;
			IntakeSys ointake_sys = new IntakeSys();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@intake_sys_id", intake_sys_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "intake_sysGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ointake_sys.intake_sys_id = Convert.ToInt32(dataReader["intake_sys_id"]);

					if(dataReader["intake_sys"] != DBNull.Value)
						ointake_sys.intake_sys = Convert.ToString(dataReader["intake_sys"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ointake_sys.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ointake_sys.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ointake_sys.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ointake_sys.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ointake_sys;
		}
		public int Addintake_sys(IntakeSys ointake_sys)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@intake_sys", ointake_sys.intake_sys);
				arParams[1] = new SqlParameter("@record_created_by", ointake_sys.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ointake_sys.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_sysAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateintake_sys(IntakeSys ointake_sys)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@intake_sys", ointake_sys.intake_sys);
				arParams[1] = new SqlParameter("@record_created_by", ointake_sys.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_date", ointake_sys.record_modified_date);
				arParams[3] = new SqlParameter("@intake_sys_id", ointake_sys.intake_sys_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_sysUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_sys(IntakeSys ointake_sys)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@intake_sys_id", ointake_sys.intake_sys_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_sysDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_sys(int intake_sys_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@intake_sys_id", intake_sys_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_sysDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
