using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class SalesProductBLL
	{
		private SalesProductDAL _sales_productDAL;

        public SalesProductDAL sales_productDAL
        {
            get { return _sales_productDAL; }
            set { _sales_productDAL = value; }
        }

        public SalesProductBLL()
        {
            sales_productDAL = new SalesProductDAL();
        }
        public List<SalesProduct> Getsales_productsList()
        {
            try
            {
                return sales_productDAL.Getsales_productsList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Getsales_products()
        {
            try
            {
                return sales_productDAL.Getsales_products();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetRefundInvNo()
        {
            try
            {
                return sales_productDAL.GetRefundInvNo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetSalesRefund(string InvoiceNO, int flag)//sami 2nov
        {
            try
            {
                return sales_productDAL.GetSalesRefund(InvoiceNO, flag);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public SalesProduct Getsales_product(int sales_product_id)
        {
            try
            {
                return sales_productDAL.Getsales_product(sales_product_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Addsales_product(SalesProduct osales_product)
        {
            try
            {
                return sales_productDAL.Addsales_product(osales_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateSalesProductStoreID(SalesProduct osales_product)
        {
            try
            {
                return sales_productDAL.UpdateSalesProductStoreID(osales_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SalesRefundADD(SalesProduct osales_product, ProductBO oproduct)
        {
            try
            {
                return sales_productDAL.SalesRefundADD(osales_product, oproduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Updatesales_product(SalesProduct osales_product)
        {
            try
            {
                return sales_productDAL.Updatesales_product(osales_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Removesales_product(SalesProduct osales_product)
        {
            try
            {
                return sales_productDAL.Removesales_product(osales_product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Removesales_product(int sales_product_id)
        {
            try
            {
                return sales_productDAL.Removesales_product(sales_product_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SalesProduct> Deserializesales_products(string Path)
        {
            try
            {
                return GenericXmlSerializer<List<SalesProduct>>.Deserialize(Path);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Serializesales_products(string Path, List<SalesProduct> sales_products)
        {
            try
            {
                GenericXmlSerializer<List<SalesProduct>>.Serialize(sales_products, Path);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
