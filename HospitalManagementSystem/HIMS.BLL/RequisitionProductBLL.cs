using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class RequisitionProductBLL
	{
		private RequisitionProductDAL _requisition_productDAL;

		public RequisitionProductDAL requisition_productDAL
		{
			get { return _requisition_productDAL; }
			set { _requisition_productDAL = value; }
		}

		public RequisitionProductBLL()
		{
			requisition_productDAL = new RequisitionProductDAL();
		}
		public List<RequisitionProduct> Getrequisition_productsList()
		{
			try
			{
				return requisition_productDAL.Getrequisition_productsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetrequisitionproductDelivery()//sami25 oct
        {
            try
            {
                return requisition_productDAL.GetrequisitionproductDelivery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetrequisitionproductsForDelivery(int RequisitionProductID)//sami 27 Oct
        {
            try
            {
                return requisition_productDAL.GetrequisitionproductsForDelivery(RequisitionProductID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int requisitionListUpdate(Requisition requisition, List<RequisitionProduct> lstrequisitionProduct, List<ProductBO> lstproductBO)
        {
            try
            {
                return requisition_productDAL.requisitionListUpdate(requisition, lstrequisitionProduct, lstproductBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
		public DataSet Getrequisition_products()
		{
			try
			{
				return requisition_productDAL.Getrequisition_products();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public RequisitionProduct Getrequisition_product(int requisition_product_id)
		{
			try
			{
				return requisition_productDAL.Getrequisition_product(requisition_product_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet requisitonProductCategoty(int productTypeID)//sami 27 dec
        {
            try
            {
                return requisition_productDAL.requisitonProductCategoty(productTypeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
		public int Updaterequisition_product(RequisitionProduct orequisition_product)
		{
			try
			{
				return requisition_productDAL.Updaterequisition_product(orequisition_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int requisition_productReceiveUpdate(Requisition requisiton,List<RequisitionProduct> lstrequisitionProduct)
        {
            try
            {
                return requisition_productDAL.requisition_productReceiveUpdate(requisiton,lstrequisitionProduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removerequisition_product(RequisitionProduct orequisition_product)
		{
			try
			{
				return requisition_productDAL.Removerequisition_product(orequisition_product);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerequisition_product(int requisition_product_id)
		{
			try
			{
				return requisition_productDAL.Removerequisition_product(requisition_product_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<RequisitionProduct> Deserializerequisition_products(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<RequisitionProduct>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializerequisition_products(string Path, List<RequisitionProduct> requisition_products)
		{
			try
			{
				GenericXmlSerializer<List<RequisitionProduct>>.Serialize(requisition_products, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
