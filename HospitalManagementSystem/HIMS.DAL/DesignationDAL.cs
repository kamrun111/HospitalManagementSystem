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
	public class DesignationDAL
	{
		public DesignationDAL()
		{
		}
        public List<Designation> GetdesignationsList()
		{
			SqlConnection conn = null;
            List<Designation> lstdesignations = new List<Designation>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "designationGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    Designation odesignation = new Designation();
					odesignation.designation_id = Convert.ToInt32(dataReader["designation_id"]);

					if(dataReader["designation"] != DBNull.Value)
						odesignation.designation = Convert.ToString(dataReader["designation"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odesignation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odesignation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odesignation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odesignation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstdesignations.Add(odesignation);
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
			return lstdesignations;
		}
		public DataSet Getdesignations()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "designationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Designation Getdesignation(int designation_id)
		{
			SqlConnection conn = null;
            Designation odesignation = new Designation();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@designation_id", designation_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "designationGet", arParams, ref conn);
				while (dataReader.Read())
				{
					odesignation.designation_id = Convert.ToInt32(dataReader["designation_id"]);

					if(dataReader["designation"] != DBNull.Value)
						odesignation.designation = Convert.ToString(dataReader["designation"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						odesignation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						odesignation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						odesignation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						odesignation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return odesignation;
		}
        public int Adddesignation(Designation odesignation)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@designation", odesignation.designation);
				arParams[1] = new SqlParameter("@record_created_by", odesignation.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odesignation.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "designationAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatedesignation(Designation odesignation)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@designation", odesignation.designation);
				arParams[1] = new SqlParameter("@record_created_by", odesignation.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", odesignation.record_modified_by);
				arParams[3] = new SqlParameter("@designation_id", odesignation.designation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "designationUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removedesignation(Designation odesignation)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@designation_id", odesignation.designation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "designationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedesignation(int designation_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@designation_id", designation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "designationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
