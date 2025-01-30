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
	public class InvestigationItemUsageDAL
	{
		public InvestigationItemUsageDAL()
		{
		}
		public List<InvestigationItemUsage> Getinvestigation_item_usagesList()
		{
			SqlConnection conn = null;
			List<InvestigationItemUsage> lstinvestigation_item_usages = new List<InvestigationItemUsage>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_item_usageGetAll", null, ref conn);
				while (dataReader.Read())
				{
					InvestigationItemUsage oinvestigation_item_usage = new InvestigationItemUsage();
					oinvestigation_item_usage.investigation_item_usage_id = Convert.ToInt32(dataReader["investigation_item_usage_id"]);

					if(dataReader["investigation_item_id"] != DBNull.Value)
						oinvestigation_item_usage.investigation_item_id = Convert.ToInt32(dataReader["investigation_item_id"]);

					if(dataReader["test_item_id"] != DBNull.Value)
						oinvestigation_item_usage.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["use_amount"] != DBNull.Value)
						oinvestigation_item_usage.use_amount = Convert.ToInt32(dataReader["use_amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_item_usage.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_item_usage.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_item_usage.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_item_usage.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstinvestigation_item_usages.Add(oinvestigation_item_usage);
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
			return lstinvestigation_item_usages;
		}
		public DataSet Getinvestigation_item_usages()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "investigation_item_usageGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public InvestigationItemUsage Getinvestigation_item_usage(int investigation_item_usage_id)
		{
			SqlConnection conn = null;
			InvestigationItemUsage oinvestigation_item_usage = new InvestigationItemUsage();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_usage_id", investigation_item_usage_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_item_usageGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oinvestigation_item_usage.investigation_item_usage_id = Convert.ToInt32(dataReader["investigation_item_usage_id"]);

					if(dataReader["investigation_item_id"] != DBNull.Value)
						oinvestigation_item_usage.investigation_item_id = Convert.ToInt32(dataReader["investigation_item_id"]);

					if(dataReader["test_item_id"] != DBNull.Value)
						oinvestigation_item_usage.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["use_amount"] != DBNull.Value)
						oinvestigation_item_usage.use_amount = Convert.ToInt32(dataReader["use_amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_item_usage.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_item_usage.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_item_usage.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_item_usage.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oinvestigation_item_usage;
		}
		public int Addinvestigation_item_usage(InvestigationItemUsage oinvestigation_item_usage)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@investigation_item_id", oinvestigation_item_usage.investigation_item_id);
				arParams[1] = new SqlParameter("@test_item_id", oinvestigation_item_usage.test_item_id);
				arParams[2] = new SqlParameter("@use_amount", oinvestigation_item_usage.use_amount);
				arParams[3] = new SqlParameter("@record_created_by", oinvestigation_item_usage.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", oinvestigation_item_usage.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_usageAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateinvestigation_item_usage(InvestigationItemUsage oinvestigation_item_usage)
		{

			SqlParameter[] arParams = new SqlParameter[6];
			try
			{
				arParams[0] = new SqlParameter("@investigation_item_id", oinvestigation_item_usage.investigation_item_id);
				arParams[1] = new SqlParameter("@test_item_id", oinvestigation_item_usage.test_item_id);
				arParams[2] = new SqlParameter("@use_amount", oinvestigation_item_usage.use_amount);
				arParams[3] = new SqlParameter("@record_created_by", oinvestigation_item_usage.record_created_by);
				arParams[4] = new SqlParameter("@record_modified_by", oinvestigation_item_usage.record_modified_by);
				arParams[5] = new SqlParameter("@investigation_item_usage_id", oinvestigation_item_usage.investigation_item_usage_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_usageUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_usage(InvestigationItemUsage oinvestigation_item_usage)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_usage_id", oinvestigation_item_usage.investigation_item_usage_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_usageDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_usage(int investigation_item_usage_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_usage_id", investigation_item_usage_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_usageDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
