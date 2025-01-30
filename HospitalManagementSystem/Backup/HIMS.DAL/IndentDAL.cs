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
	public class IndentDAL
	{
		public IndentDAL()
		{
		}
		public List<Indent> GetindentsList()
		{
			SqlConnection conn = null;
			List<Indent> lstindents = new List<Indent>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "indentGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Indent oindent = new Indent();
					oindent.indent_id = Convert.ToInt32(dataReader["indent_id"]);

					if(dataReader["item_id"] != DBNull.Value)
						oindent.item_id = Convert.ToInt32(dataReader["item_id"]);

					if(dataReader["quantity_ordered"] != DBNull.Value)
						oindent.quantity_ordered = Convert.ToDecimal(dataReader["quantity_ordered"]);

					if(dataReader["quantity_delivered"] != DBNull.Value)
						oindent.quantity_delivered = Convert.ToDecimal(dataReader["quantity_delivered"]);

					if(dataReader["quantity_received"] != DBNull.Value)
						oindent.quantity_received = Convert.ToDecimal(dataReader["quantity_received"]);

					if(dataReader["quantity_refunded"] != DBNull.Value)
						oindent.quantity_refunded = Convert.ToDecimal(dataReader["quantity_refunded"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oindent.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oindent.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oindent.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oindent.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstindents.Add(oindent);
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
			return lstindents;
		}
		public DataSet Getindents()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "indentGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Indent Getindent(int indent_id)
		{
			SqlConnection conn = null;
			Indent oindent = new Indent();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@indent_id", indent_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "indentGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oindent.indent_id = Convert.ToInt32(dataReader["indent_id"]);

					if(dataReader["item_id"] != DBNull.Value)
						oindent.item_id = Convert.ToInt32(dataReader["item_id"]);

					if(dataReader["quantity_ordered"] != DBNull.Value)
						oindent.quantity_ordered = Convert.ToDecimal(dataReader["quantity_ordered"]);

					if(dataReader["quantity_delivered"] != DBNull.Value)
						oindent.quantity_delivered = Convert.ToDecimal(dataReader["quantity_delivered"]);

					if(dataReader["quantity_received"] != DBNull.Value)
						oindent.quantity_received = Convert.ToDecimal(dataReader["quantity_received"]);

					if(dataReader["quantity_refunded"] != DBNull.Value)
						oindent.quantity_refunded = Convert.ToDecimal(dataReader["quantity_refunded"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oindent.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oindent.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oindent.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oindent.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oindent;
		}
		public int Addindent(Indent oindent)
		{
			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@item_id", oindent.item_id);
				arParams[1] = new SqlParameter("@quantity_ordered", oindent.quantity_ordered);
				arParams[2] = new SqlParameter("@quantity_delivered", oindent.quantity_delivered);
				arParams[3] = new SqlParameter("@quantity_received", oindent.quantity_received);
				arParams[4] = new SqlParameter("@quantity_refunded", oindent.quantity_refunded);
				arParams[5] = new SqlParameter("@record_created_by", oindent.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", oindent.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "indentAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateindent(Indent oindent)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@item_id", oindent.item_id);
				arParams[1] = new SqlParameter("@quantity_ordered", oindent.quantity_ordered);
				arParams[2] = new SqlParameter("@quantity_delivered", oindent.quantity_delivered);
				arParams[3] = new SqlParameter("@quantity_received", oindent.quantity_received);
				arParams[4] = new SqlParameter("@quantity_refunded", oindent.quantity_refunded);
				arParams[5] = new SqlParameter("@record_created_by", oindent.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", oindent.record_modified_by);
				arParams[7] = new SqlParameter("@indent_id", oindent.indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "indentUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeindent(Indent oindent)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@indent_id", oindent.indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "indentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeindent(int indent_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@indent_id", indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "indentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
