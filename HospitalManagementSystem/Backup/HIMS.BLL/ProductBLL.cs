using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ProductBLL
	{
		private ProductDAL _productDAL;

		public ProductDAL productDAL
		{
			get { return _productDAL; }
			set { _productDAL = value; }
		}

		public ProductBLL()
		{
			productDAL = new ProductDAL();
		}
		public List<ProductBO> GetproductsList()
		{
			try
			{
				return productDAL.GetproductsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getproducts()
		{
			try
			{
				return productDAL.Getproducts();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetCategoryforOtherIndent(int TypeID)
        {
            try
            {
                return productDAL.GetCategoryforOtherIndent(TypeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetProductforOtherIndent(int CategoryID)
        {
            try
            {
                return productDAL.GetProductforOtherIndent(CategoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getMedecineStock(int productID)//sami
        {
            try
            {
                return productDAL.getMedecineStock(productID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int newproductAdd(ProductBO oproduct)
        {
            try
            {
                return productDAL.newproductAdd(oproduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OTMedicineLoad()
        {
            try
            {
                return productDAL.OTMedicineLoad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ProductlistforSales(int Product_CategoryID)
        {
            try
            {
                return productDAL.ProductlistforSales(Product_CategoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet OTmedicinebyADID(int admissionID)//sami
        {
            try
            {
                return productDAL.OTmedicinebyADID(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public ProductBO Getproduct(int product_id)
		{
			try
			{
				return productDAL.Getproduct(product_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addproduct(ProductBO oproduct)
		{
			try
			{
				return productDAL.Addproduct(oproduct);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateproduct(ProductBO oproduct)
		{
			try
			{
				return productDAL.Updateproduct(oproduct);
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
				return productDAL.Removeproduct(oproduct);
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
				return productDAL.Removeproduct(product_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ProductBO> Deserializeproducts(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<ProductBO>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeproducts(string Path, List<ProductBO> products)
		{
			try
			{
				GenericXmlSerializer<List<ProductBO>>.Serialize(products, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetMedicines()
        {
            try
            {
                return productDAL.GetMedicines();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

	}
}
