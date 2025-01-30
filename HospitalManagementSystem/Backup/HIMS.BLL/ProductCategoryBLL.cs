using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ProductCategoryBLL
	{
		private ProductCategoryDAL _product_categoryDAL;

		public ProductCategoryDAL product_categoryDAL
		{
			get { return _product_categoryDAL; }
			set { _product_categoryDAL = value; }
		}

		public ProductCategoryBLL()
		{
			product_categoryDAL = new ProductCategoryDAL();
		}
		public List<ProductCategory> Getproduct_categorysList()
		{
			try
			{
				return product_categoryDAL.Getproduct_categorysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getproduct_categorys()
		{
			try
			{
				return product_categoryDAL.Getproduct_categorys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetMedicineType()
        {
            try
            {
                return product_categoryDAL.GetMedicineType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public ProductCategory Getproduct_category(int product_category_id)
		{
			try
			{
				return product_categoryDAL.Getproduct_category(product_category_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addproduct_category(ProductCategory oproduct_category)
		{
			try
			{
				return product_categoryDAL.Addproduct_category(oproduct_category);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateproduct_category(ProductCategory oproduct_category)
		{
			try
			{
				return product_categoryDAL.Updateproduct_category(oproduct_category);
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
				return product_categoryDAL.Removeproduct_category(oproduct_category);
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
				return product_categoryDAL.Removeproduct_category(product_category_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ProductCategory> Deserializeproduct_categorys(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<ProductCategory>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeproduct_categorys(string Path, List<ProductCategory> product_categorys)
		{
			try
			{
				GenericXmlSerializer<List<ProductCategory>>.Serialize(product_categorys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
