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
	public class ProductCategoryDAL
	{
		public ProductCategoryDAL()
		{
		}
		public List<ProductCategory> Getproduct_categorysList()
		{
			SqlConnection conn = null;
			List<ProductCategory> lstproduct_categorys = new List<ProductCategory>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "product_categoryGetAll", null, ref conn);
				while (dataReader.Read())
				{
					ProductCategory oproduct_category = new ProductCategory();
					oproduct_category.product_category_id = Convert.ToInt32(dataReader["product_category_id"]);

					if(dataReader["product_category"] != DBNull.Value)
						oproduct_category.product_category = Convert.ToString(dataReader["product_category"]);

					if(dataReader["store_id"] != DBNull.Value)
						oproduct_category.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oproduct_category.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oproduct_category.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oproduct_category.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oproduct_category.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstproduct_categorys.Add(oproduct_category);
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
			return lstproduct_categorys;
		}
		public DataSet Getproduct_categorys()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "product_categoryGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet GetMedicineType()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetMedicineType");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public ProductCategory Getproduct_category(int product_category_id)
		{
			SqlConnection conn = null;
			ProductCategory oproduct_category = new ProductCategory();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_category_id", product_category_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "product_categoryGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oproduct_category.product_category_id = Convert.ToInt32(dataReader["product_category_id"]);

					if(dataReader["product_category"] != DBNull.Value)
						oproduct_category.product_category = Convert.ToString(dataReader["product_category"]);

					if(dataReader["store_id"] != DBNull.Value)
						oproduct_category.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oproduct_category.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oproduct_category.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oproduct_category.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oproduct_category.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oproduct_category;
		}
		public int Addproduct_category(ProductCategory oproduct_category)
		{
			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@product_category", oproduct_category.product_category);
				arParams[1] = new SqlParameter("@store_id", oproduct_category.store_id);
				arParams[2] = new SqlParameter("@record_created_by", oproduct_category.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", oproduct_category.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_categoryAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateproduct_category(ProductCategory oproduct_category)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
				arParams[0] = new SqlParameter("@product_category", oproduct_category.product_category);
				arParams[1] = new SqlParameter("@store_id", oproduct_category.store_id);
				arParams[2] = new SqlParameter("@record_created_by", oproduct_category.record_created_by);
				arParams[3] = new SqlParameter("@record_modified_by", oproduct_category.record_modified_by);
				arParams[4] = new SqlParameter("@product_category_id", oproduct_category.product_category_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_categoryUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeproduct_category(ProductCategory oproduct_category)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_category_id", oproduct_category.product_category_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_categoryDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeproduct_category(int product_category_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_category_id", product_category_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "product_categoryDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
