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
	public class OperationDAL
	{
		public OperationDAL()
		{
		}
		public List<Operation> GetoperationsList()
		{
			SqlConnection conn = null;
			List<Operation> lstoperations = new List<Operation>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "operationGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Operation ooperation = new Operation();
					ooperation.operation_id = Convert.ToInt32(dataReader["operation_id"]);

					if(dataReader["operation_name"] != DBNull.Value)
						ooperation.operation_name = Convert.ToString(dataReader["operation_name"]);

					if(dataReader["operation_procedure"] != DBNull.Value)
						ooperation.operation_procedure = Convert.ToString(dataReader["operation_procedure"]);
					lstoperations.Add(ooperation);
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
			return lstoperations;
		}
		public DataSet Getoperations()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "operationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public Operation GetOperation(int operation_id)
        {
            SqlConnection conn = null;
            Operation operation = new Operation();
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@operation_id", operation_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "OperationGet", arParams, ref conn);
                while (dataReader.Read())
                {
                    operation.operation_id = Convert.ToInt32(dataReader["operation_id"]);

                    if (dataReader["operation_name"] != DBNull.Value)
                        operation.operation_name = Convert.ToString(dataReader["operation_name"]);
                    
                    if (dataReader["operation_procedure"] != DBNull.Value)
                        operation.operation_procedure = Convert.ToString(dataReader["operation_procedure"]);
                    
                    if (dataReader["record_created_date"] != DBNull.Value)
                        operation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

                    if (dataReader["record_created_by"] != DBNull.Value)
                        operation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    if (dataReader["record_modified_date"] != DBNull.Value)
                        operation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

                    if (dataReader["record_modified_by"] != DBNull.Value)
                        operation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return operation;
        }


		public int Addoperation(Operation ooperation)
		{
			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
				arParams[0] = new SqlParameter("@operation_name", ooperation.operation_name);
				arParams[1] = new SqlParameter("@operation_procedure", ooperation.operation_procedure);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "operationAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int Updateoperation(Operation operation)
        {

            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@operation_name", operation.operation_name);
                arParams[1] = new SqlParameter("@operation_procedure", operation.operation_procedure);
                arParams[2] = new SqlParameter("@record_created_by", operation.record_created_by);
                arParams[3] = new SqlParameter("@record_modified_by", operation.record_modified_by);
                arParams[4] = new SqlParameter("@operation_id", operation.operation_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "operationUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }


        public int RemoveOperation(Operation operation)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@operation_id", operation.operation_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OperationDelete", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int RemoveOperation(int operation_id)
        {

            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@operation_id", operation_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OperationDelete", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

	}
}
