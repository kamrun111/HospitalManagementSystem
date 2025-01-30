using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ProductTypeBLL
	{
		private ProductTypeDAL _product_typeDAL;

		public ProductTypeDAL product_typeDAL
		{
			get { return _product_typeDAL; }
			set { _product_typeDAL = value; }
		}

		public ProductTypeBLL()
		{
			product_typeDAL = new ProductTypeDAL();
		}
		public List<ProductType> Getproduct_typesList()
		{
			try
			{
				return product_typeDAL.Getproduct_typesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getproduct_types()
		{
			try
			{
				return product_typeDAL.Getproduct_types();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public ProductType Getproduct_type(int product_type_id)
		{
			try
			{
				return product_typeDAL.Getproduct_type(product_type_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addproduct_type(ProductType oproduct_type)
		{
			try
			{
				return product_typeDAL.Addproduct_type(oproduct_type);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateproduct_type(ProductType oproduct_type)
		{
			try
			{
				return product_typeDAL.Updateproduct_type(oproduct_type);
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
				return product_typeDAL.Removeproduct_type(oproduct_type);
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
				return product_typeDAL.Removeproduct_type(product_type_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ProductType> Deserializeproduct_types(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<ProductType>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeproduct_types(string Path, List<ProductType> product_types)
		{
			try
			{
				GenericXmlSerializer<List<ProductType>>.Serialize(product_types, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
