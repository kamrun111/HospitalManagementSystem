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
	public class SalesDAL
	{
		public SalesDAL()
		{
		}
		public List<Sales> GetsalessList()
		{
			SqlConnection conn = null;
			List<Sales> lstsaless = new List<Sales>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "salesGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Sales osales = new Sales();
					osales.sales_id = Convert.ToInt32(dataReader["sales_id"]);

					if(dataReader["customer_name"] != DBNull.Value)
						osales.customer_name = Convert.ToString(dataReader["customer_name"]);

					if(dataReader["adress"] != DBNull.Value)
						osales.adress = Convert.ToString(dataReader["adress"]);

					if(dataReader["phone"] != DBNull.Value)
						osales.phone = Convert.ToString(dataReader["phone"]);

					if(dataReader["sales_date"] != DBNull.Value)
						osales.sales_date = Convert.ToDateTime(dataReader["sales_date"]);

					if(dataReader["invoice_no"] != DBNull.Value)
						osales.invoice_no = Convert.ToString(dataReader["invoice_no"]);

					if(dataReader["payment_type_id"] != DBNull.Value)
						osales.payment_type_id = Convert.ToInt32(dataReader["payment_type_id"]);

					if(dataReader["is_inpatient"] != DBNull.Value)
						osales.is_inpatient = Convert.ToBoolean(dataReader["is_inpatient"]);

					if(dataReader["admission_id"] != DBNull.Value)
						osales.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["store_id"] != DBNull.Value)
						osales.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["remarks"] != DBNull.Value)
						osales.remarks = Convert.ToString(dataReader["remarks"]);

					if(dataReader["discount"] != DBNull.Value)
						osales.discount = Convert.ToDecimal(dataReader["discount"]);

					if(dataReader["grand_total"] != DBNull.Value)
						osales.grand_total = Convert.ToDecimal(dataReader["grand_total"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						osales.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						osales.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						osales.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						osales.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstsaless.Add(osales);
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
			return lstsaless;
		}
		public DataSet Getsaless()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "salesGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Sales Getsales(int sales_id)
		{
			SqlConnection conn = null;
			Sales osales = new Sales();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@sales_id", sales_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "salesGet", arParams, ref conn);
				while (dataReader.Read())
				{
					osales.sales_id = Convert.ToInt32(dataReader["sales_id"]);

					if(dataReader["customer_name"] != DBNull.Value)
						osales.customer_name = Convert.ToString(dataReader["customer_name"]);

					if(dataReader["adress"] != DBNull.Value)
						osales.adress = Convert.ToString(dataReader["adress"]);

					if(dataReader["phone"] != DBNull.Value)
						osales.phone = Convert.ToString(dataReader["phone"]);

					if(dataReader["sales_date"] != DBNull.Value)
						osales.sales_date = Convert.ToDateTime(dataReader["sales_date"]);

					if(dataReader["invoice_no"] != DBNull.Value)
						osales.invoice_no = Convert.ToString(dataReader["invoice_no"]);

					if(dataReader["payment_type_id"] != DBNull.Value)
						osales.payment_type_id = Convert.ToInt32(dataReader["payment_type_id"]);

					if(dataReader["is_inpatient"] != DBNull.Value)
						osales.is_inpatient = Convert.ToBoolean(dataReader["is_inpatient"]);

					if(dataReader["admission_id"] != DBNull.Value)
						osales.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["store_id"] != DBNull.Value)
						osales.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["remarks"] != DBNull.Value)
						osales.remarks = Convert.ToString(dataReader["remarks"]);

					if(dataReader["discount"] != DBNull.Value)
						osales.discount = Convert.ToDecimal(dataReader["discount"]);

					if(dataReader["grand_total"] != DBNull.Value)
						osales.grand_total = Convert.ToDecimal(dataReader["grand_total"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						osales.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						osales.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						osales.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						osales.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return osales;
		}
		public int Addsales(Sales osales)
		{
			SqlParameter[] arParams = new SqlParameter[16];
			try
			{
				arParams[0] = new SqlParameter("@customer_name", osales.customer_name);
				arParams[1] = new SqlParameter("@adress", osales.adress);
				arParams[2] = new SqlParameter("@phone", osales.phone);
				arParams[3] = new SqlParameter("@sales_date", osales.sales_date);
				arParams[4] = new SqlParameter("@invoice_no", osales.invoice_no);
				arParams[5] = new SqlParameter("@payment_type_id", osales.payment_type_id);
				arParams[6] = new SqlParameter("@is_inpatient", osales.is_inpatient);
				arParams[7] = new SqlParameter("@admission_id", osales.admission_id);
				arParams[8] = new SqlParameter("@store_id", osales.store_id);
				arParams[9] = new SqlParameter("@remarks", osales.remarks);
				arParams[10] = new SqlParameter("@discount", osales.discount);
				arParams[11] = new SqlParameter("@grand_total", osales.grand_total);
				arParams[12] = new SqlParameter("@record_created_by", osales.record_created_by);
				arParams[13] = new SqlParameter("@record_modified_by", osales.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "salesAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatesales(Sales osales)
		{

			SqlParameter[] arParams = new SqlParameter[15];
			try
			{
				arParams[0] = new SqlParameter("@customer_name", osales.customer_name);
				arParams[1] = new SqlParameter("@adress", osales.adress);
				arParams[2] = new SqlParameter("@phone", osales.phone);
				arParams[3] = new SqlParameter("@sales_date", osales.sales_date);
				arParams[4] = new SqlParameter("@invoice_no", osales.invoice_no);
				arParams[5] = new SqlParameter("@payment_type_id", osales.payment_type_id);
				arParams[6] = new SqlParameter("@is_inpatient", osales.is_inpatient);
				arParams[7] = new SqlParameter("@admission_id", osales.admission_id);
				arParams[8] = new SqlParameter("@store_id", osales.store_id);
				arParams[9] = new SqlParameter("@remarks", osales.remarks);
				arParams[10] = new SqlParameter("@discount", osales.discount);
				arParams[11] = new SqlParameter("@grand_total", osales.grand_total);
				arParams[12] = new SqlParameter("@record_created_by", osales.record_created_by);
				arParams[13] = new SqlParameter("@record_modified_by", osales.record_modified_by);
				arParams[14] = new SqlParameter("@sales_id", osales.sales_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "salesUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removesales(Sales osales)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@sales_id", osales.sales_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "salesDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removesales(int sales_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@sales_id", sales_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "salesDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
