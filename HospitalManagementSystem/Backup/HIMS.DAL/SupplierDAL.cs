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
	public class SupplierDAL
	{
		public SupplierDAL()
		{
		}
		public List<Supplier> GetsuppliersList()
		{
			SqlConnection conn = null;
			List<Supplier> lstsuppliers = new List<Supplier>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "supplierGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Supplier osupplier = new Supplier();
					osupplier.supplier_id = Convert.ToInt32(dataReader["supplier_id"]);

					if(dataReader["supplier_name"] != DBNull.Value)
						osupplier.supplier_name = Convert.ToString(dataReader["supplier_name"]);

					if(dataReader["contact_person"] != DBNull.Value)
						osupplier.contact_person = Convert.ToString(dataReader["contact_person"]);

					if(dataReader["contact_no"] != DBNull.Value)
						osupplier.contact_no = Convert.ToString(dataReader["contact_no"]);

					if(dataReader["fax_no"] != DBNull.Value)
						osupplier.fax_no = Convert.ToString(dataReader["fax_no"]);

					if(dataReader["address"] != DBNull.Value)
						osupplier.address = Convert.ToString(dataReader["address"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						osupplier.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						osupplier.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						osupplier.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						osupplier.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstsuppliers.Add(osupplier);
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
			return lstsuppliers;
		}
		public DataSet Getsuppliers()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "supplierGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public Supplier Getsupplier(int supplier_id)
		{
			SqlConnection conn = null;
			Supplier osupplier = new Supplier();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@supplier_id", supplier_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "supplierGet", arParams, ref conn);
				while (dataReader.Read())
				{
					osupplier.supplier_id = Convert.ToInt32(dataReader["supplier_id"]);

					if(dataReader["supplier_name"] != DBNull.Value)
						osupplier.supplier_name = Convert.ToString(dataReader["supplier_name"]);

					if(dataReader["contact_person"] != DBNull.Value)
						osupplier.contact_person = Convert.ToString(dataReader["contact_person"]);

					if(dataReader["contact_no"] != DBNull.Value)
						osupplier.contact_no = Convert.ToString(dataReader["contact_no"]);

					if(dataReader["fax_no"] != DBNull.Value)
						osupplier.fax_no = Convert.ToString(dataReader["fax_no"]);

					if(dataReader["address"] != DBNull.Value)
						osupplier.address = Convert.ToString(dataReader["address"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						osupplier.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						osupplier.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						osupplier.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						osupplier.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return osupplier;
		}
		public int Addsupplier(Supplier osupplier)
		{
			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@supplier_name", osupplier.supplier_name);
				arParams[1] = new SqlParameter("@contact_person", osupplier.contact_person);
				arParams[2] = new SqlParameter("@contact_no", osupplier.contact_no);
				arParams[3] = new SqlParameter("@fax_no", osupplier.fax_no);
				arParams[4] = new SqlParameter("@address", osupplier.address);
				arParams[5] = new SqlParameter("@record_created_by", osupplier.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", osupplier.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "supplierAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public DataSet AddSupplierAndGetAll(Supplier osupplier)
        {
            DataSet ds = null;
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                arParams[0] = new SqlParameter("@supplier_name", osupplier.supplier_name);
                arParams[1] = new SqlParameter("@contact_person", osupplier.contact_person);
                arParams[2] = new SqlParameter("@contact_no", osupplier.contact_no);
                arParams[3] = new SqlParameter("@fax_no", osupplier.fax_no);
                arParams[4] = new SqlParameter("@address", osupplier.address);
                arParams[5] = new SqlParameter("@record_created_by", osupplier.record_created_by);
                arParams[6] = new SqlParameter("@record_modified_by", osupplier.record_modified_by);

                ds= DbHelper.GetDataSet(CommandType.StoredProcedure, "supplierAdd", arParams);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
		public DataSet UpdateSupplier(Supplier osupplier)
		{
            DataSet ds = null;
			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@supplier_name", osupplier.supplier_name);
				arParams[1] = new SqlParameter("@contact_person", osupplier.contact_person);
				arParams[2] = new SqlParameter("@contact_no", osupplier.contact_no);
				arParams[3] = new SqlParameter("@fax_no", osupplier.fax_no);
				arParams[4] = new SqlParameter("@address", osupplier.address);
				arParams[5] = new SqlParameter("@record_created_by", osupplier.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", osupplier.record_modified_by);
				arParams[7] = new SqlParameter("@supplier_id", osupplier.supplier_id);
				ds= DbHelper.GetDataSet(CommandType.StoredProcedure, "supplierUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
            return ds;
		}
		public int Removesupplier(Supplier osupplier)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@supplier_id", osupplier.supplier_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "supplierDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@supplier_id", supplier_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "supplierDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}



        //public int Countsupplier()
        //{

        //    try
        //    {
        //        return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "suppliersCount", null);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
	}
}
