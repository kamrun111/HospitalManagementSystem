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
	public class CabinTranferDAL
	{
		public CabinTranferDAL()
		{
		}
		public List<CabinTranfer> Getcabin_tranfersList()
		{
			SqlConnection conn = null;
			List<CabinTranfer> lstcabin_tranfers = new List<CabinTranfer>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabin_tranferGetAll", null, ref conn);
				while (dataReader.Read())
				{
					CabinTranfer ocabin_tranfer = new CabinTranfer();
					ocabin_tranfer.cabin_tranfer_id = Convert.ToInt32(dataReader["cabin_tranfer_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						ocabin_tranfer.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["cabin_id"] != DBNull.Value)
						ocabin_tranfer.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["from_date"] != DBNull.Value)
						ocabin_tranfer.from_date = Convert.ToDateTime(dataReader["from_date"]);

					if(dataReader["to_date"] != DBNull.Value)
						ocabin_tranfer.to_date = Convert.ToDateTime(dataReader["to_date"]);

					if(dataReader["amount"] != DBNull.Value)
						ocabin_tranfer.amount = Convert.ToDecimal(dataReader["amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin_tranfer.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin_tranfer.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin_tranfer.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin_tranfer.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstcabin_tranfers.Add(ocabin_tranfer);
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
			return lstcabin_tranfers;
		}

        public DataSet GetCabinTransferPopulationInfo(int patient_code, string cabin)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@patient_code", patient_code);
                arParams[1] = new SqlParameter("@cabin", cabin);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetCabinTransferPopulationInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }


        public DataSet GetNonOccupiedCabinInfo()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetNonOccupiedCabinInfo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet Getcabin_tranfers()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "cabin_tranferGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public CabinTranfer Getcabin_tranfer(int cabin_tranfer_id)
		{
			SqlConnection conn = null;
			CabinTranfer ocabin_tranfer = new CabinTranfer();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_tranfer_id", cabin_tranfer_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabin_tranferGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ocabin_tranfer.cabin_tranfer_id = Convert.ToInt32(dataReader["cabin_tranfer_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						ocabin_tranfer.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["cabin_id"] != DBNull.Value)
						ocabin_tranfer.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["from_date"] != DBNull.Value)
						ocabin_tranfer.from_date = Convert.ToDateTime(dataReader["from_date"]);

					if(dataReader["to_date"] != DBNull.Value)
						ocabin_tranfer.to_date = Convert.ToDateTime(dataReader["to_date"]);

					if(dataReader["amount"] != DBNull.Value)
						ocabin_tranfer.amount = Convert.ToDecimal(dataReader["amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin_tranfer.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin_tranfer.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin_tranfer.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin_tranfer.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ocabin_tranfer;
		}





		public int Addcabin_tranfer(CabinTranfer ocabin_tranfer)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", ocabin_tranfer.admission_id);
				arParams[1] = new SqlParameter("@cabin_id", ocabin_tranfer.cabin_id);
				arParams[2] = new SqlParameter("@record_created_by", ocabin_tranfer.record_created_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_tranferAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecabin_tranfer(CabinTranfer ocabin_tranfer)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", ocabin_tranfer.admission_id);
				arParams[1] = new SqlParameter("@cabin_id", ocabin_tranfer.cabin_id);
				arParams[2] = new SqlParameter("@from_date", ocabin_tranfer.from_date);
				arParams[3] = new SqlParameter("@to_date", ocabin_tranfer.to_date);
				arParams[4] = new SqlParameter("@amount", ocabin_tranfer.amount);
				arParams[5] = new SqlParameter("@record_created_by", ocabin_tranfer.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", ocabin_tranfer.record_modified_by);
				arParams[7] = new SqlParameter("@cabin_tranfer_id", ocabin_tranfer.cabin_tranfer_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_tranferUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_tranfer(CabinTranfer ocabin_tranfer)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_tranfer_id", ocabin_tranfer.cabin_tranfer_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_tranferDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_tranfer(int cabin_tranfer_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_tranfer_id", cabin_tranfer_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabin_tranferDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
