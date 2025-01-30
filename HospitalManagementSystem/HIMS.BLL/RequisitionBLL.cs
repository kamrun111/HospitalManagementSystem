using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class RequisitionBLL
	{
		private RequisitionDAL _requisitionDAL;

		public RequisitionDAL requisitionDAL
		{
			get { return _requisitionDAL; }
			set { _requisitionDAL = value; }
		}

		public RequisitionBLL()
		{
			requisitionDAL = new RequisitionDAL();
		}
		public List<Requisition> GetrequisitionsList()
		{
			try
			{
				return requisitionDAL.GetrequisitionsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetProductType()
        {
            try
            {
                return requisitionDAL.GetProductType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetRequisitionReceive(int departmentID)// nov 18 2008 
        {
            try
            {
                return requisitionDAL.GetRequisitionReceive(departmentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet requisitionReceiveload(int departmentID)// nov 18 2008 
        {
            try
            {
                return requisitionDAL.requisitionReceiveload(departmentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Productlist(int Product_CategoryID)
        {
            try
            {
                return requisitionDAL.Productlist(Product_CategoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int RequisitionProductInsert(Requisition requisition, List<RequisitionProduct> lstRequisitionProduct, int Flag)
        {
            try
            {
                return requisitionDAL.RequisitionProductInsert(requisition, lstRequisitionProduct, Flag);
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
                return requisitionDAL.ProductlistforSales(Product_CategoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetRequisition(DateTime date1, DateTime date2)
        {
            try
            {
                return requisitionDAL.GetRequisition(date1, date2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetDepartment()//sami 18 nov
        {
            try
            {
                return requisitionDAL.GetDepartment();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetRequisitionLoad()//sami 24OCt
        {
            try
            {
                return requisitionDAL.GetRequisitionLoad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public DataSet Getrequisitions()
		{
			try
			{
				return requisitionDAL.Getrequisitions();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Requisition Getrequisition(int requisition_id)
		{
			try
			{
				return requisitionDAL.Getrequisition(requisition_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
       
		public int Addrequisition(Requisition orequisition)
		{
			try
			{
				return requisitionDAL.Addrequisition(orequisition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updaterequisition(Requisition orequisition)
		{
			try
			{
				return requisitionDAL.Updaterequisition(orequisition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerequisition(Requisition orequisition)
		{
			try
			{
				return requisitionDAL.Removerequisition(orequisition);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removerequisition(int requisition_id)
		{
			try
			{
				return requisitionDAL.Removerequisition(requisition_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Requisition> Deserializerequisitions(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Requisition>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializerequisitions(string Path, List<Requisition> requisitions)
		{
			try
			{
				GenericXmlSerializer<List<Requisition>>.Serialize(requisitions, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
