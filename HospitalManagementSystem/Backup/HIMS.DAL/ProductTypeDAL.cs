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
	public class ProductTypeDAL
	{
		public ProductTypeDAL()
		{
		}
		public List<ProductType> Getproduct_typesList()
		{
			SqlConnection conn = null;
			List<ProductType> lstproduct_types = new List<ProductType>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "product_typeGetAll", null, ref conn);
				while (dataReader.Read())
				{
					ProductType oproduct_type = new ProductType();
					oproduct_type.product_type_id = Convert.ToInt32(dataReader["product_type_id"]);

					if(dataReader["product_type"] != DBNull.Value)
						oproduct_type.product_type = Convert.ToString(dataReader["product_type"]);

					if(dataReader["store_id"] != DBNull.Value)
						oproduct_type.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oproduct_type.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oproduct_type.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oproduct_type.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oproduct_type.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstproduct_types.Add(oproduct_type);
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
			return lstproduct_types;
		}
		public DataSet Getproduct_types()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "product_typeGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public ProductType Getproduct_type(int product_type_id)
		{
			SqlConnection conn = null;
			ProductType oproduct_type = new ProductType();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_type_id", product_type_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "product_typeGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oproduct_type.product_type_id = Convert.ToInt32(dataReader["product_type_id"]);

					if(dataReader["product_type"] != DBNull.Value)
						oproduct_type.product_type = Convert.ToString(dataReader["product_type"]);

					if(dataReader["store_id"] != DBNull.Value)
						oproduct_type.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oproduct_type.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oproduct_type.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oproduct_type.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oproduct_type.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oproduct_type;
		}
		public int Addproduct_type(ProductType oproduct_type)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@product_type", oproduct_type.product_type);
				arParams[1] = new SqlParameter("@store_id", oproduct_type.store_id);
				arParams[2] = new SqlParameter("@record_created_by", oproduct_type.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", oproduct_type.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_typeAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateproduct_type(ProductType oproduct_type)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@product_type", oproduct_type.product_type);
				arParams[1] = new SqlParameter("@store_id", oproduct_type.store_id);
				arParams[2] = new SqlParameter("@record_created_by", oproduct_type.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", oproduct_type.record_modified_by);
				arParams[4] = new SqlParameter("@product_type_id", oproduct_type.product_type_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_typeUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeproduct_type(ProductType oproduct_type)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_type_id", oproduct_type.product_type_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_typeDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeproduct_type(int product_type_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_type_id", product_type_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_typeDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
