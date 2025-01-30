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
	public class SpecialistInDAL
	{
		public SpecialistInDAL()
		{
		}
		public List<SpecialistIn> Getspecialist_insList()
		{
			SqlConnection conn = null;
            List<SpecialistIn> lstspecialist_ins = new List<SpecialistIn>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "specialist_inGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    SpecialistIn ospecialist_in = new SpecialistIn();
					ospecialist_in.specialist_in_id = Convert.ToInt32(dataReader["specialist_in_id"]);

					if(dataReader["specialist_in"] != DBNull.Value)
                        ospecialist_in.specialist_in = Convert.ToString(dataReader["specialist_in"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ospecialist_in.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ospecialist_in.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ospecialist_in.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ospecialist_in.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstspecialist_ins.Add(ospecialist_in);
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
			return lstspecialist_ins;
		}
		public DataSet Getspecialist_ins()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "specialist_inGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public SpecialistIn Getspecialist_in(int specialist_in_id)
		{
			SqlConnection conn = null;
            SpecialistIn ospecialist_in = new SpecialistIn();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@specialist_in_id", specialist_in_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "specialist_inGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ospecialist_in.specialist_in_id = Convert.ToInt32(dataReader["specialist_in_id"]);

					if(dataReader["specialist_in"] != DBNull.Value)
                        ospecialist_in.specialist_in = Convert.ToString(dataReader["specialist_in"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ospecialist_in.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ospecialist_in.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ospecialist_in.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ospecialist_in.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ospecialist_in;
		}
        public int Addspecialist_in(SpecialistIn ospecialist_in)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
                arParams[0] = new SqlParameter("@specialist_in", ospecialist_in.specialist_in);
				arParams[1] = new SqlParameter("@record_created_by", ospecialist_in.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ospecialist_in.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "specialist_inAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatespecialist_in(SpecialistIn ospecialist_in)
		{

			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
                arParams[0] = new SqlParameter("@specialist_in", ospecialist_in.specialist_in);
				arParams[1] = new SqlParameter("@record_created_by", ospecialist_in.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ospecialist_in.record_modified_by);
				arParams[3] = new SqlParameter("@specialist_in_id", ospecialist_in.specialist_in_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "specialist_inUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removespecialist_in(SpecialistIn ospecialist_in)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@specialist_in_id", ospecialist_in.specialist_in_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "specialist_inDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removespecialist_in(int specialist_in_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@specialist_in_id", specialist_in_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "specialist_inDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
