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
	public class RequisitionDAL
	{
		public RequisitionDAL()
		{
		}
		public List<Requisition> GetrequisitionsList()
		{
			SqlConnection conn = null;
			List<Requisition> lstrequisitions = new List<Requisition>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "requisitionGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Requisition orequisition = new Requisition();
					orequisition.requisition_id = Convert.ToInt32(dataReader["requisition_id"]);

					if(dataReader["requisition_no"] != DBNull.Value)
						orequisition.requisition_no = Convert.ToString(dataReader["requisition_no"]);

					if(dataReader["department_id"] != DBNull.Value)
						orequisition.department_id = Convert.ToInt32(dataReader["department_id"]);

					if(dataReader["product_type_id"] != DBNull.Value)
						orequisition.product_type_id = Convert.ToInt32(dataReader["product_type_id"]);

					if(dataReader["store_id"] != DBNull.Value)
						orequisition.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["requisition_date"] != DBNull.Value)
						orequisition.requisition_date = Convert.ToDateTime(dataReader["requisition_date"]);

                    //if(dataReader["record_created_date"] != DBNull.Value)
                    //    orequisition.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						orequisition.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    //if(dataReader["record_modified_date"] != DBNull.Value)
                    //    orequisition.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						orequisition.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstrequisitions.Add(orequisition);
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
			return lstrequisitions;
		}
        public DataSet Productlist(int Product_CategoryID)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@product_categoryID", Product_CategoryID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "Productlist", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetRequisitionLoad()//sami24Oct
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetRequisitionLoad");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

		public DataSet Getrequisitions()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "requisitionGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}



        public DataSet GetRequisitionReceive(int departmentID)//DAL nov 18 2008 
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@departmentID", departmentID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetRequisitionReceive", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet requisitionReceiveload(int departmentID)//DAL nov 18 2008 
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@departmentID", departmentID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "requisitionReceiveload", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetDepartment()//sami 18 nov 2008
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetDepartment");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

		public Requisition Getrequisition(int requisition_id)
		{
			SqlConnection conn = null;
			Requisition orequisition = new Requisition();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@requisition_id", requisition_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "requisitionGet", arParams, ref conn);
				while (dataReader.Read())
				{
					orequisition.requisition_id = Convert.ToInt32(dataReader["requisition_id"]);

					if(dataReader["requisition_no"] != DBNull.Value)
						orequisition.requisition_no = Convert.ToString(dataReader["requisition_no"]);

					if(dataReader["department_id"] != DBNull.Value)
						orequisition.department_id = Convert.ToInt32(dataReader["department_id"]);

					if(dataReader["product_type_id"] != DBNull.Value)
						orequisition.product_type_id = Convert.ToInt32(dataReader["product_type_id"]);

					if(dataReader["store_id"] != DBNull.Value)
						orequisition.store_id = Convert.ToInt32(dataReader["store_id"]);

					if(dataReader["requisition_date"] != DBNull.Value)
						orequisition.requisition_date = Convert.ToDateTime(dataReader["requisition_date"]);

                    //if(dataReader["record_created_date"] != DBNull.Value)
                    //    orequisition.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						orequisition.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    //if(dataReader["record_modified_date"] != DBNull.Value)
                    //    orequisition.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						orequisition.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return orequisition;
		}
        public int RequisitionProductInsert(Requisition requisition, List<RequisitionProduct> lstRequisitionProduct, int Flag)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            int requisitionID = 0;

            try
            {
                requisitionID = AddRequisitionAutoID(trans, requisition, Flag);
                Addrequisition_product(trans, requisitionID, lstRequisitionProduct);

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                requisitionID = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return requisitionID;
        }

        public int AddRequisitionAutoID(SqlTransaction trans, Requisition orequisition, int flag)//sami24Oct
        {
            int result = 0;
            SqlParameter[] arParams = new SqlParameter[8];
            try
            {
                arParams[0] = new SqlParameter("@department_id", orequisition.department_id);
                arParams[1] = new SqlParameter("@product_type_id", orequisition.product_type_id);
                arParams[2] = new SqlParameter("@store_id", orequisition.store_id);
                arParams[3] = new SqlParameter("@requisition_date", orequisition.requisition_date);
                arParams[4] = new SqlParameter("@record_created_by", orequisition.record_created_by);
                arParams[5] = new SqlParameter("@record_modified_by", orequisition.record_modified_by);
                arParams[6] = new SqlParameter("@flag", flag);
                arParams[7] = new SqlParameter("@requisition_id", orequisition.requisition_id);
                arParams[7].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "AddRequisitionAutoID", arParams);
                result = Convert.ToInt32(arParams[7].Value.ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public void Addrequisition_product(SqlTransaction trans, int requisitionID, List<RequisitionProduct> lstRequisitionProduct)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                foreach (RequisitionProduct element in lstRequisitionProduct)
                {
                    arParams[0] = new SqlParameter("@requisition_id", requisitionID);
                    arParams[1] = new SqlParameter("@product_id", element.product_id);
                    arParams[2] = new SqlParameter("@order_qty", element.order_qty);
                    arParams[3] = new SqlParameter("@delivery_qty", element.delivery_qty);
                    arParams[4] = new SqlParameter("@receive_qty", element.receive_qty);
                    arParams[5] = new SqlParameter("@refund_qty", element.refund_qty);
                    arParams[6] = new SqlParameter("@store_id", element.store_id);
                    arParams[7] = new SqlParameter("@is_complete", element.is_complete);
                    arParams[8] = new SqlParameter("@record_created_by", element.record_created_by);
                    arParams[9] = new SqlParameter("@record_modified_by", element.record_modified_by);

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "requisition_productAdd", arParams);
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
        //public int ADDGeneralRequisitionAutoID(Requisition orequisition)//sami24Oct
        //{
        //    int result = 0;
        //    SqlConnection conn = DbHelper.GetOpenConnection();
        //    SqlParameter[] arParams = new SqlParameter[7];
        //    try
        //    {
        //        arParams[0] = new SqlParameter("@department_id", orequisition.department_id);
        //        arParams[1] = new SqlParameter("@product_type_id", orequisition.product_type_id);
        //        arParams[2] = new SqlParameter("@store_id", orequisition.store_id);
        //        arParams[3] = new SqlParameter("@requisition_date", orequisition.requisition_date);
        //        arParams[4] = new SqlParameter("@record_created_by", orequisition.record_created_by);
        //        arParams[5] = new SqlParameter("@record_modified_by", orequisition.record_modified_by);
        //        arParams[6] = new SqlParameter("@requisition_id", orequisition.requisition_id);
        //        arParams[6].Direction = ParameterDirection.Output;


        //        SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "ADDGeneralRequisitionAutoID", arParams);
        //        result = Convert.ToInt32(arParams[6].Value.ToString());

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return result;
        //}
		public int Addrequisition(Requisition orequisition)
		{
			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@requisition_no", orequisition.requisition_no);
				arParams[1] = new SqlParameter("@department_id", orequisition.department_id);
				arParams[2] = new SqlParameter("@product_type_id", orequisition.product_type_id);
				arParams[3] = new SqlParameter("@store_id", orequisition.store_id);
				arParams[4] = new SqlParameter("@requisition_date", orequisition.requisition_date);
				arParams[5] = new SqlParameter("@record_created_by", orequisition.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", orequisition.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "requisitionAdd", arParams);
			}
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
		public int Updaterequisition(Requisition orequisition)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@requisition_no", orequisition.requisition_no);
				arParams[1] = new SqlParameter("@department_id", orequisition.department_id);
				arParams[2] = new SqlParameter("@product_type_id", orequisition.product_type_id);
				arParams[3] = new SqlParameter("@store_id", orequisition.store_id);
				arParams[4] = new SqlParameter("@requisition_date", orequisition.requisition_date);
				arParams[5] = new SqlParameter("@record_created_by", orequisition.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", orequisition.record_modified_by);
				arParams[7] = new SqlParameter("@requisition_id", orequisition.requisition_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "requisitionUpdate", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@requisition_id", orequisition.requisition_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "requisitionDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@requisition_id", requisition_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "requisitionDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
