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
	public class InvestigationItemIndentDAL
	{
		public InvestigationItemIndentDAL()
		{
		}
		public List<InvestigationItemIndent> Getinvestigation_item_indentsList()
		{
			SqlConnection conn = null;
			List<InvestigationItemIndent> lstinvestigation_item_indents = new List<InvestigationItemIndent>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_item_indentGetAll", null, ref conn);
				while (dataReader.Read())
				{
					InvestigationItemIndent oinvestigation_item_indent = new InvestigationItemIndent();
					oinvestigation_item_indent.investigation_item_indent_id = Convert.ToInt32(dataReader["investigation_item_indent_id"]);

					if(dataReader["investigation_item_id"] != DBNull.Value)
						oinvestigation_item_indent.investigation_item_id = Convert.ToInt32(dataReader["investigation_item_id"]);

					if(dataReader["order_qty"] != DBNull.Value)
						oinvestigation_item_indent.order_qty = Convert.ToDecimal(dataReader["order_qty"]);

					if(dataReader["receive_qty"] != DBNull.Value)
						oinvestigation_item_indent.receive_qty = Convert.ToDecimal(dataReader["receive_qty"]);

					if(dataReader["delivery_qty"] != DBNull.Value)
						oinvestigation_item_indent.delivery_qty = Convert.ToDecimal(dataReader["delivery_qty"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						oinvestigation_item_indent.refund_qty = Convert.ToDecimal(dataReader["refund_qty"]);

					if(dataReader["indent_date"] != DBNull.Value)
						oinvestigation_item_indent.indent_date = Convert.ToDateTime(dataReader["indent_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_item_indent.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_item_indent.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_item_indent.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_item_indent.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstinvestigation_item_indents.Add(oinvestigation_item_indent);
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
			return lstinvestigation_item_indents;
		}

        public DataSet GetInvestigationItemindentWithItems()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestigationItemindentGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet Getinvestigation_item_indents()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "investigation_item_indentGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public InvestigationItemIndent Getinvestigation_item_indent(int investigation_item_indent_id)
		{
			SqlConnection conn = null;
			InvestigationItemIndent oinvestigation_item_indent = new InvestigationItemIndent();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_indent_id", investigation_item_indent_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_item_indentGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oinvestigation_item_indent.investigation_item_indent_id = Convert.ToInt32(dataReader["investigation_item_indent_id"]);

					if(dataReader["investigation_item_id"] != DBNull.Value)
						oinvestigation_item_indent.investigation_item_id = Convert.ToInt32(dataReader["investigation_item_id"]);

					if(dataReader["order_qty"] != DBNull.Value)
						oinvestigation_item_indent.order_qty = Convert.ToDecimal(dataReader["order_qty"]);

					if(dataReader["receive_qty"] != DBNull.Value)
						oinvestigation_item_indent.receive_qty = Convert.ToDecimal(dataReader["receive_qty"]);

					if(dataReader["delivery_qty"] != DBNull.Value)
						oinvestigation_item_indent.delivery_qty = Convert.ToDecimal(dataReader["delivery_qty"]);

					if(dataReader["refund_qty"] != DBNull.Value)
						oinvestigation_item_indent.refund_qty = Convert.ToDecimal(dataReader["refund_qty"]);

					if(dataReader["indent_date"] != DBNull.Value)
						oinvestigation_item_indent.indent_date = Convert.ToDateTime(dataReader["indent_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_item_indent.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_item_indent.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_item_indent.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_item_indent.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oinvestigation_item_indent;
		}
		public int Addinvestigation_item_indent(InvestigationItemIndent oinvestigation_item_indent)
		{
			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@investigation_item_id", oinvestigation_item_indent.investigation_item_id);
				arParams[1] = new SqlParameter("@order_qty", oinvestigation_item_indent.order_qty);
				arParams[2] = new SqlParameter("@receive_qty", oinvestigation_item_indent.receive_qty);
				arParams[3] = new SqlParameter("@delivery_qty", oinvestigation_item_indent.delivery_qty);
				arParams[4] = new SqlParameter("@refund_qty", oinvestigation_item_indent.refund_qty);
				arParams[5] = new SqlParameter("@indent_date", oinvestigation_item_indent.indent_date);
				arParams[6] = new SqlParameter("@record_created_by", oinvestigation_item_indent.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", oinvestigation_item_indent.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_indentAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateinvestigation_item_indent(InvestigationItemIndent oinvestigation_item_indent)
		{

			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@investigation_item_id", oinvestigation_item_indent.investigation_item_id);
				arParams[1] = new SqlParameter("@order_qty", oinvestigation_item_indent.order_qty);
				arParams[2] = new SqlParameter("@receive_qty", oinvestigation_item_indent.receive_qty);
				arParams[3] = new SqlParameter("@delivery_qty", oinvestigation_item_indent.delivery_qty);
				arParams[4] = new SqlParameter("@refund_qty", oinvestigation_item_indent.refund_qty);
				arParams[5] = new SqlParameter("@indent_date", oinvestigation_item_indent.indent_date);
				arParams[6] = new SqlParameter("@record_created_by", oinvestigation_item_indent.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", oinvestigation_item_indent.record_modified_by);
				arParams[8] = new SqlParameter("@investigation_item_indent_id", oinvestigation_item_indent.investigation_item_indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_indentUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_indent(InvestigationItemIndent oinvestigation_item_indent)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_indent_id", oinvestigation_item_indent.investigation_item_indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_indentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_indent(int investigation_item_indent_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_item_indent_id", investigation_item_indent_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_item_indentDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
