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
	public class RefundFaultyDAL
	{
		public RefundFaultyDAL()
		{
		}
		public List<RefundFaulty> Getrefund_faultysList()
		{
			SqlConnection conn = null;
			List<RefundFaulty> lstrefund_faultys = new List<RefundFaulty>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "refund_faultyGetAll", null, ref conn);
				while (dataReader.Read())
				{
					RefundFaulty orefund_faulty = new RefundFaulty();
					orefund_faulty.refund_faulty_id = Convert.ToInt32(dataReader["refund_faulty_id"]);

					if(dataReader["receive_id"] != DBNull.Value)
						orefund_faulty.receive_id = Convert.ToInt32(dataReader["receive_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						orefund_faulty.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						orefund_faulty.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

					if(dataReader["is_faulty"] != DBNull.Value)
						orefund_faulty.is_faulty = Convert.ToBoolean(dataReader["is_faulty"]);

					if(dataReader["store_id"] != DBNull.Value)
						orefund_faulty.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["remarks"] != DBNull.Value)
						orefund_faulty.remarks = Convert.ToString(dataReader["remarks"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						orefund_faulty.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						orefund_faulty.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						orefund_faulty.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						orefund_faulty.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstrefund_faultys.Add(orefund_faulty);
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
			return lstrefund_faultys;
		}
		public DataSet Getrefund_faultys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "refund_faultyGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public RefundFaulty Getrefund_faulty(int refund_faulty_id)
		{
			SqlConnection conn = null;
			RefundFaulty orefund_faulty = new RefundFaulty();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@refund_faulty_id", refund_faulty_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "refund_faultyGet", arParams, ref conn);
				while (dataReader.Read())
				{
					orefund_faulty.refund_faulty_id = Convert.ToInt32(dataReader["refund_faulty_id"]);

					if(dataReader["receive_id"] != DBNull.Value)
						orefund_faulty.receive_id = Convert.ToInt32(dataReader["receive_id"]);

					if(dataReader["product_id"] != DBNull.Value)
						orefund_faulty.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						orefund_faulty.refund_qty = Convert.ToInt32(dataReader["refund_qty"]);

					if(dataReader["is_faulty"] != DBNull.Value)
						orefund_faulty.is_faulty = Convert.ToBoolean(dataReader["is_faulty"]);

					if(dataReader["store_id"] != DBNull.Value)
						orefund_faulty.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["remarks"] != DBNull.Value)
						orefund_faulty.remarks = Convert.ToString(dataReader["remarks"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						orefund_faulty.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						orefund_faulty.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						orefund_faulty.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						orefund_faulty.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return orefund_faulty;
		}
		public int Addrefund_faulty(RefundFaulty orefund_faulty)
		{
			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@receive_id", orefund_faulty.receive_id);
				arParams[1] = new SqlParameter("@product_id", orefund_faulty.product_id);
				arParams[2] = new SqlParameter("@refund_qty", orefund_faulty.refund_qty);
				arParams[3] = new SqlParameter("@is_faulty", orefund_faulty.is_faulty);
				arParams[4] = new SqlParameter("@store_id", orefund_faulty.store_id);
				arParams[5] = new SqlParameter("@remarks", orefund_faulty.remarks);
				arParams[6] = new SqlParameter("@record_created_by", orefund_faulty.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", orefund_faulty.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "refund_faultyAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updaterefund_faulty(RefundFaulty orefund_faulty)
		{

			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@receive_id", orefund_faulty.receive_id);
				arParams[1] = new SqlParameter("@product_id", orefund_faulty.product_id);
				arParams[2] = new SqlParameter("@refund_qty", orefund_faulty.refund_qty);
				arParams[3] = new SqlParameter("@is_faulty", orefund_faulty.is_faulty);
				arParams[4] = new SqlParameter("@store_id", orefund_faulty.store_id);
				arParams[5] = new SqlParameter("@remarks", orefund_faulty.remarks);
				arParams[6] = new SqlParameter("@record_created_by", orefund_faulty.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", orefund_faulty.record_modified_by);
				arParams[8] = new SqlParameter("@refund_faulty_id", orefund_faulty.refund_faulty_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "refund_faultyUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerefund_faulty(RefundFaulty orefund_faulty)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@refund_faulty_id", orefund_faulty.refund_faulty_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "refund_faultyDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerefund_faulty(int refund_faulty_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@refund_faulty_id", refund_faulty_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "refund_faultyDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
