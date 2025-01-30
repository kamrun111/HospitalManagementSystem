using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReceiveProductBLL
	{
		private ReceiveProductDAL _receive_productDAL;

		public ReceiveProductDAL receive_productDAL
		{
			get { return _receive_productDAL; }
			set { _receive_productDAL = value; }
		}

		public ReceiveProductBLL()
		{
			receive_productDAL = new ReceiveProductDAL();
		}
		public List<ReceiveProduct> Getreceive_productsList()
		{
			try
			{
				return receive_productDAL.Getreceive_productsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getreceive_products()
		{
			try
			{
				return receive_productDAL.Getreceive_products();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		public ReceiveProduct Getreceive_product(int receive_product_id)
		{
			try
			{
				return receive_productDAL.Getreceive_product(receive_product_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet receive_productGet(int product_typeID,string invoiceno)
        {
            try
            {
                return receive_productDAL.receive_productGet(product_typeID, invoiceno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ProductSales(int ProductID)
        {
            try
            {
                return receive_productDAL.ProductSales(ProductID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetProductID(string Product)
        {
            try
            {
                return receive_productDAL.GetProductID(Product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReceiveLoad(int purchaseID)
        {
            try
            {
                return receive_productDAL.GetReceiveLoad(purchaseID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetFaultyItem(int Barcode)//sami28 Oct
        {
            try
            {
                return receive_productDAL.GetFaultyItem(Barcode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int receiveproductAdd(ReceiveProduct oreceive_product)
        {
            try
            {
                return receive_productDAL.receiveproductAdd(oreceive_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
		public string Addreceive_product( ReceiveProduct oreceive_product)
		{
			try
			{
				return receive_productDAL.Addreceive_product(oreceive_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int ReceiveProductAdd(ReceiveBO oreceive, ReceiveProduct oreceive_product)
        {
            try
            {
                return receive_productDAL.ReceiveProductAdd(oreceive, oreceive_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateReceiveStoreID(ReceiveProduct oreceive_product)
        {
            try
            {
                return receive_productDAL.UpdateReceiveStoreID(oreceive_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updatereceive_product(ReceiveProduct oreceive_product)
		{
			try
			{
				return receive_productDAL.Updatereceive_product(oreceive_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int receive_product_refundUpdate(ReceiveProduct oreceive_product)
        {
            try
            {
                return receive_productDAL.receive_product_refundUpdate(oreceive_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removereceive_product(ReceiveProduct oreceive_product)
		{
			try
			{
				return receive_productDAL.Removereceive_product(oreceive_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive_product(int receive_product_id)
		{
			try
			{
				return receive_productDAL.Removereceive_product(receive_product_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ReceiveProduct> Deserializereceive_products(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<ReceiveProduct>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializereceive_products(string Path, List<ReceiveProduct> receive_products)
		{
			try
			{
				GenericXmlSerializer<List<ReceiveProduct>>.Serialize(receive_products, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
