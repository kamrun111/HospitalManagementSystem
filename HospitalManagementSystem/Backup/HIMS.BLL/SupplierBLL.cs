using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class SupplierBLL
	{
		private SupplierDAL _supplierDAL;

        public SupplierDAL supplierDAL
		{
			get { return _supplierDAL; }
			set { _supplierDAL = value; }
		}

		public SupplierBLL()
		{
			supplierDAL = new SupplierDAL();
		}
		public List<Supplier> GetsuppliersList()
		{
			try
			{
				return supplierDAL.GetsuppliersList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getsuppliers()
		{
			try
			{
				return supplierDAL.Getsuppliers();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Supplier Getsupplier(int supplier_id)
		{
			try
			{
				return supplierDAL.Getsupplier(supplier_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addsupplier(Supplier osupplier)
		{
			try
			{
				return supplierDAL.Addsupplier(osupplier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet AddSupplierAndGetAll(Supplier osupplier)
        {
            try
            {
                return supplierDAL.AddSupplierAndGetAll(osupplier);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public DataSet UpdateSupplier(Supplier osupplier)
		{
			try
			{
				return supplierDAL.UpdateSupplier(osupplier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removesupplier(Supplier osupplier)
		{
			try
			{
				return supplierDAL.Removesupplier(osupplier);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removesupplier(int supplier_id)
		{
			try
			{
				return supplierDAL.Removesupplier(supplier_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Supplier> Deserializesuppliers(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Supplier>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializesuppliers(string Path, List<Supplier> suppliers)
		{
			try
			{
				GenericXmlSerializer<List<Supplier>>.Serialize(suppliers, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
