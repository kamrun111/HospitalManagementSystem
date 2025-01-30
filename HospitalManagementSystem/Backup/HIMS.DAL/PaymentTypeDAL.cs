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
	public class PaymentTypeDAL
	{
		public PaymentTypeDAL()
		{
		}
		public List<PaymentType> Getpayment_typesList()
		{
			SqlConnection conn = null;
            List<PaymentType> lstpayment_types = new List<PaymentType>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "payment_typeGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    PaymentType opayment_type = new PaymentType();
					opayment_type.payment_type_id = Convert.ToInt32(dataReader["payment_type_id"]);

					if(dataReader["payment_type"] != DBNull.Value)
						opayment_type.payment_type = Convert.ToString(dataReader["payment_type"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						opayment_type.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						opayment_type.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						opayment_type.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						opayment_type.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstpayment_types.Add(opayment_type);
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
            return lstpayment_types;
		}
		public DataSet Getpayment_types()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "payment_typeGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public int Addpayment_type(PaymentType opayment_type)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@payment_type", opayment_type.payment_type);
				arParams[1] = new SqlParameter("@record_created_by", opayment_type.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", opayment_type.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "payment_typeAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
