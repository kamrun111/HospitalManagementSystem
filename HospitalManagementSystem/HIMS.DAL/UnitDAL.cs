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
	public class UnitDAL
	{
		public UnitDAL()
		{
		}
		public List<Unit> GetunitsList()
		{
			SqlConnection conn = null;
			List<Unit> lstunits = new List<Unit>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "unitGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Unit ounit = new Unit();
					ounit.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["unit"] != DBNull.Value)
						ounit.unit = Convert.ToString(dataReader["unit"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ounit.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ounit.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ounit.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ounit.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstunits.Add(ounit);
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
			return lstunits;
		}
		public DataSet Getunits()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "unitGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Unit Getunit(int unit_id)
		{
			SqlConnection conn = null;
			Unit ounit = new Unit();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@unit_id", unit_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "unitGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ounit.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["unit"] != DBNull.Value)
						ounit.unit = Convert.ToString(dataReader["unit"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ounit.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ounit.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ounit.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ounit.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ounit;
		}
		public int Addunit(Unit ounit)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@unit", ounit.unit);
				arParams[1] = new SqlParameter("@record_created_by", ounit.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ounit.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "unitAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateunit(Unit ounit)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@unit", ounit.unit);
				arParams[1] = new SqlParameter("@record_created_by", ounit.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", ounit.record_modified_by);
				arParams[3] = new SqlParameter("@unit_id", ounit.unit_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "unitUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeunit(Unit ounit)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@unit_id", ounit.unit_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "unitDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeunit(int unit_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@unit_id", unit_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "unitDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
