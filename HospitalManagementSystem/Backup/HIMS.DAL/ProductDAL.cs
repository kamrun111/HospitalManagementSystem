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
	public class ProductDAL
	{
		public ProductDAL()
		{
		}
		public List<ProductBO> GetproductsList()
		{
			SqlConnection conn = null;
			List<ProductBO> lstproducts = new List<ProductBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "productGetAll", null, ref conn);
				while (dataReader.Read())
				{
					ProductBO oproduct = new ProductBO();
					oproduct.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["product"] != DBNull.Value)
						oproduct.product = Convert.ToString(dataReader["product"]);

					if(dataReader["generic_name"] != DBNull.Value)
						oproduct.generic_name = Convert.ToString(dataReader["generic_name"]);

					if(dataReader["product_category_id"] != DBNull.Value)
						oproduct.product_category_id = Convert.ToInt32(dataReader["product_category_id"]);

					if(dataReader["product_type_id"] != DBNull.Value)
						oproduct.product_type_id = Convert.ToInt32(dataReader["product_type_id"]);

					if(dataReader["unit_id"] != DBNull.Value)
						oproduct.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["default_sales_price"] != DBNull.Value)
						oproduct.default_sales_price = Convert.ToDecimal(dataReader["default_sales_price"]);

					if(dataReader["re_order_level"] != DBNull.Value)
						oproduct.re_order_level = Convert.ToInt32(dataReader["re_order_level"]);

					if(dataReader["consider_level"] != DBNull.Value)
						oproduct.consider_level = Convert.ToInt32(dataReader["consider_level"]);

					if(dataReader["store_id"] != DBNull.Value)
						oproduct.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oproduct.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oproduct.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oproduct.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oproduct.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstproducts.Add(oproduct);
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
			return lstproducts;
		}
		public DataSet Getproducts()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "productGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public int newproductAdd(ProductBO oproduct)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@product", oproduct.product);
                arParams[1] = new SqlParameter("@product_category_id ", oproduct.product_category_id);
                arParams[2] = new SqlParameter("@record_created_by", oproduct.record_created_by);
                arParams[3] = new SqlParameter("@product_id", oproduct.product_id);
                arParams[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "newproductAdd", arParams);
                result = Convert.ToInt32(arParams[3].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }
        public DataSet OTMedicineLoad()// sami 1 dec 2008
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTMedicineLoad");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet ProductlistforSales(int Product_CategoryID)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@product_categoryID", Product_CategoryID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ProductlistforSales", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetCategoryforOtherIndent(int TypeID)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@product_typeID", TypeID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetCategoryforOtherIndent", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetProductforOtherIndent(int CategoryID)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@product_categoryID", CategoryID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetProductforOtherIndent", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet getMedecineStock(int ProductID)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@productID", ProductID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getMedecineStock", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }


		public ProductBO Getproduct(int product_id)
		{
			SqlConnection conn = null;
			ProductBO oproduct = new ProductBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_id", product_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "productGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oproduct.product_id = Convert.ToInt32(dataReader["product_id"]);

					if(dataReader["product"] != DBNull.Value)
						oproduct.product = Convert.ToString(dataReader["product"]);

					if(dataReader["generic_name"] != DBNull.Value)
						oproduct.generic_name = Convert.ToString(dataReader["generic_name"]);

					if(dataReader["product_category_id"] != DBNull.Value)
						oproduct.product_category_id = Convert.ToInt32(dataReader["product_category_id"]);

					if(dataReader["product_type_id"] != DBNull.Value)
						oproduct.product_type_id = Convert.ToInt32(dataReader["product_type_id"]);

					if(dataReader["unit_id"] != DBNull.Value)
						oproduct.unit_id = Convert.ToInt32(dataReader["unit_id"]);

					if(dataReader["default_sales_price"] != DBNull.Value)
						oproduct.default_sales_price = Convert.ToDecimal(dataReader["default_sales_price"]);

					if(dataReader["re_order_level"] != DBNull.Value)
						oproduct.re_order_level = Convert.ToInt32(dataReader["re_order_level"]);

					if(dataReader["consider_level"] != DBNull.Value)
						oproduct.consider_level = Convert.ToInt32(dataReader["consider_level"]);

					if(dataReader["store_id"] != DBNull.Value)
						oproduct.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oproduct.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oproduct.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oproduct.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oproduct.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oproduct;
		}
		public int Addproduct(ProductBO oproduct)
		{
			SqlParameter[] arParams = new SqlParameter[11];
			try
			{
				arParams[0] = new SqlParameter("@product", oproduct.product);
				arParams[1] = new SqlParameter("@generic_name", oproduct.generic_name);
				arParams[2] = new SqlParameter("@product_category_id", oproduct.product_category_id);
				arParams[3] = new SqlParameter("@product_type_id", oproduct.product_type_id);
				arParams[4] = new SqlParameter("@unit_id", oproduct.unit_id);
				arParams[5] = new SqlParameter("@default_sales_price", oproduct.default_sales_price);
				arParams[6] = new SqlParameter("@re_order_level", oproduct.re_order_level);
				arParams[7] = new SqlParameter("@consider_level", oproduct.consider_level);
				arParams[8] = new SqlParameter("@store_id", oproduct.store_id);
				arParams[9] = new SqlParameter("@record_created_by", oproduct.record_created_by);
				arParams[10] = new SqlParameter("@record_modified_by", oproduct.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "productAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateproduct(ProductBO oproduct)
		{

			SqlParameter[] arParams = new SqlParameter[12];
			try
			{
				arParams[0] = new SqlParameter("@product", oproduct.product);
				arParams[1] = new SqlParameter("@generic_name", oproduct.generic_name);
				arParams[2] = new SqlParameter("@product_category_id", oproduct.product_category_id);
				arParams[3] = new SqlParameter("@product_type_id", oproduct.product_type_id);
				arParams[4] = new SqlParameter("@unit_id", oproduct.unit_id);
				arParams[5] = new SqlParameter("@default_sales_price", oproduct.default_sales_price);
				arParams[6] = new SqlParameter("@re_order_level", oproduct.re_order_level);
				arParams[7] = new SqlParameter("@consider_level", oproduct.consider_level);
				arParams[8] = new SqlParameter("@store_id", oproduct.store_id);
				arParams[9] = new SqlParameter("@record_created_by", oproduct.record_created_by);
				arParams[10] = new SqlParameter("@record_modified_by", oproduct.record_modified_by);
				arParams[11] = new SqlParameter("@product_id", oproduct.product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "productUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeproduct(ProductBO oproduct)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_id", oproduct.product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "productDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeproduct(int product_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@product_id", product_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "productDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet OTmedicinebyADID(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admissionID", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTmedicinebyADID", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetMedicines()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetMedicines");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

	}
}
