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
	public class PrescriptionProductDAL
	{
        public PrescriptionProductDAL()
		{
		}
        public int newprescriptionproductAdd(PriscriptionProduct oproduct)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@product", oproduct.product);
                arParams[1] = new SqlParameter("@product_category_id", oproduct.product_category_id);
                arParams[2] = new SqlParameter("@record_created_by", oproduct.record_created_by);
                arParams[3] = new SqlParameter("@product_id", oproduct.prescription_product_id);
                arParams[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "newprescriptionproductAdd", arParams);
                result = Convert.ToInt32(arParams[3].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -1;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }
	}
}
