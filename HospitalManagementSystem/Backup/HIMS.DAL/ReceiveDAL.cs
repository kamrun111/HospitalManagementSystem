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
	public class ReceiveDAL
	{
		public ReceiveDAL()
		{
		}
		public List<Receive> GetreceivesList()
		{
			SqlConnection conn = null;
			List<Receive> lstreceives = new List<Receive>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "receiveGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Receive oreceive = new Receive();
					oreceive.receive_id = Convert.ToInt32(dataReader["receive_id"]);

					if(dataReader["barcode"] != DBNull.Value)
						oreceive.barcode = Convert.ToString(dataReader["barcode"]);

					if(dataReader["purchase_id"] != DBNull.Value)
						oreceive.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["invoice_no"] != DBNull.Value)
						oreceive.invoice_no = Convert.ToString(dataReader["invoice_no"]);

					if(dataReader["invoice_date"] != DBNull.Value)
						oreceive.invoice_date = Convert.ToDateTime(dataReader["invoice_date"]);

					if(dataReader["received_date"] != DBNull.Value)
						oreceive.received_date = Convert.ToDateTime(dataReader["received_date"]);

					if(dataReader["store_id"] != DBNull.Value)
						oreceive.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oreceive.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreceive.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oreceive.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oreceive.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstreceives.Add(oreceive);
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
			return lstreceives;
		}
		public DataSet Getreceives()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "receiveGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Receive Getreceive(int receive_id)
		{
			SqlConnection conn = null;
			Receive oreceive = new Receive();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_id", receive_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "receiveGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oreceive.receive_id = Convert.ToInt32(dataReader["receive_id"]);

					if(dataReader["barcode"] != DBNull.Value)
						oreceive.barcode = Convert.ToString(dataReader["barcode"]);

					if(dataReader["purchase_id"] != DBNull.Value)
						oreceive.purchase_id = Convert.ToInt32(dataReader["purchase_id"]);

					if(dataReader["invoice_no"] != DBNull.Value)
						oreceive.invoice_no = Convert.ToString(dataReader["invoice_no"]);

					if(dataReader["invoice_date"] != DBNull.Value)
						oreceive.invoice_date = Convert.ToDateTime(dataReader["invoice_date"]);

					if(dataReader["received_date"] != DBNull.Value)
						oreceive.received_date = Convert.ToDateTime(dataReader["received_date"]);

					if(dataReader["store_id"] != DBNull.Value)
						oreceive.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oreceive.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreceive.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oreceive.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oreceive.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oreceive;
		}
		public int Addreceive(Receive oreceive)
		{
			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@barcode", oreceive.barcode);
				arParams[1] = new SqlParameter("@purchase_id", oreceive.purchase_id);
				arParams[2] = new SqlParameter("@invoice_no", oreceive.invoice_no);
				arParams[3] = new SqlParameter("@invoice_date", oreceive.invoice_date);
				arParams[4] = new SqlParameter("@received_date", oreceive.received_date);
				arParams[5] = new SqlParameter("@store_id", oreceive.store_id);
				arParams[6] = new SqlParameter("@record_created_by", oreceive.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", oreceive.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatereceive(Receive oreceive)
		{

			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@barcode", oreceive.barcode);
				arParams[1] = new SqlParameter("@purchase_id", oreceive.purchase_id);
				arParams[2] = new SqlParameter("@invoice_no", oreceive.invoice_no);
				arParams[3] = new SqlParameter("@invoice_date", oreceive.invoice_date);
				arParams[4] = new SqlParameter("@received_date", oreceive.received_date);
				arParams[5] = new SqlParameter("@store_id", oreceive.store_id);
				arParams[6] = new SqlParameter("@record_created_by", oreceive.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", oreceive.record_modified_by);
				arParams[8] = new SqlParameter("@receive_id", oreceive.receive_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive(Receive oreceive)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_id", oreceive.receive_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive(int receive_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@receive_id", receive_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "receiveDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
