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
	public class CabinDAL
	{
		public CabinDAL()
		{
		}
		public List<Cabin> GetcabinsList()
		{
			SqlConnection conn = null;
			List<Cabin> lstcabins = new List<Cabin>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabinGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Cabin ocabin = new Cabin();
					ocabin.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["cabin"] != DBNull.Value)
						ocabin.cabin = Convert.ToString(dataReader["cabin"]);

					if(dataReader["cabin_type_id"] != DBNull.Value)
						ocabin.cabin_type_id = Convert.ToInt32(dataReader["cabin_type_id"]);

					if(dataReader["air_conditioned"] != DBNull.Value)
						ocabin.air_conditioned = Convert.ToBoolean(dataReader["air_conditioned"]);

					if(dataReader["number_of_bed"] != DBNull.Value)
						ocabin.number_of_bed = Convert.ToInt32(dataReader["number_of_bed"]);

					if(dataReader["floor_id"] != DBNull.Value)
						ocabin.floor_id = Convert.ToInt32(dataReader["floor_id"]);

					if(dataReader["cabin_status_id"] != DBNull.Value)
						ocabin.cabin_status_id = Convert.ToInt32(dataReader["cabin_status_id"]);

					if(dataReader["cabin_rate"] != DBNull.Value)
						ocabin.cabin_rate = Convert.ToDecimal(dataReader["cabin_rate"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstcabins.Add(ocabin);
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
			return lstcabins;
		}
		public DataSet Getcabins()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "cabinGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public int UpdateForCabinTransfere(Cabin ocabin, AdmissionBO oadmission)
        {

            SqlParameter[] arParams = new SqlParameter[3];
            try
            {
                arParams[0] = new SqlParameter("@ToCabin_id", ocabin.cabin_id);
                arParams[1] = new SqlParameter("@FromCabin", ocabin.cabin);
                arParams[2] = new SqlParameter("@admission_id", oadmission.admission_id);
                ////arParams[2] = new SqlParameter("@record_modified_by", ocabin.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateForCabinTransfere", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateForCabinTransfereICU(Cabin ocabin, AdmissionBO oadmission)
        {

            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@ToCabin_id", ocabin.cabin_id);
                arParams[1] = new SqlParameter("@FromCabin", ocabin.cabin);
                arParams[2] = new SqlParameter("@admission_id", oadmission.admission_id);
                arParams[3] = new SqlParameter("@is_biscount_clear", oadmission.is_biscount_clear);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateForCabinTransfereICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public Cabin Getcabin(int cabin_id)
		{
			SqlConnection conn = null;
			Cabin ocabin = new Cabin();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_id", cabin_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "cabinGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ocabin.cabin_id = Convert.ToInt32(dataReader["cabin_id"]);

					if(dataReader["cabin"] != DBNull.Value)
						ocabin.cabin = Convert.ToString(dataReader["cabin"]);

					if(dataReader["cabin_type_id"] != DBNull.Value)
						ocabin.cabin_type_id = Convert.ToInt32(dataReader["cabin_type_id"]);

					if(dataReader["air_conditioned"] != DBNull.Value)
						ocabin.air_conditioned = Convert.ToBoolean(dataReader["air_conditioned"]);

					if(dataReader["number_of_bed"] != DBNull.Value)
						ocabin.number_of_bed = Convert.ToInt32(dataReader["number_of_bed"]);

					if(dataReader["floor_id"] != DBNull.Value)
						ocabin.floor_id = Convert.ToInt32(dataReader["floor_id"]);

					if(dataReader["cabin_status_id"] != DBNull.Value)
						ocabin.cabin_status_id = Convert.ToInt32(dataReader["cabin_status_id"]);

					if(dataReader["cabin_rate"] != DBNull.Value)
						ocabin.cabin_rate = Convert.ToDecimal(dataReader["cabin_rate"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ocabin.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ocabin.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ocabin.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ocabin.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ocabin;
		}
		public int Addcabin(Cabin ocabin)
		{
			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@cabin", ocabin.cabin);
				arParams[1] = new SqlParameter("@cabin_type_id", ocabin.cabin_type_id);
				arParams[2] = new SqlParameter("@air_conditioned", ocabin.air_conditioned);
				arParams[3] = new SqlParameter("@number_of_bed", ocabin.number_of_bed);
				arParams[4] = new SqlParameter("@floor_id", ocabin.floor_id);
				arParams[5] = new SqlParameter("@cabin_status_id", ocabin.cabin_status_id);
				arParams[6] = new SqlParameter("@cabin_rate", ocabin.cabin_rate);
				arParams[7] = new SqlParameter("@record_created_by", ocabin.record_created_by);				
				arParams[8] = new SqlParameter("@record_modified_by", ocabin.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabinAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecabin(Cabin ocabin)
		{

			SqlParameter[] arParams = new SqlParameter[10];
			try
			{
				arParams[0] = new SqlParameter("@cabin", ocabin.cabin);
				arParams[1] = new SqlParameter("@cabin_type_id", ocabin.cabin_type_id);
				arParams[2] = new SqlParameter("@air_conditioned", ocabin.air_conditioned);
				arParams[3] = new SqlParameter("@number_of_bed", ocabin.number_of_bed);
				arParams[4] = new SqlParameter("@floor_id", ocabin.floor_id);
				arParams[5] = new SqlParameter("@cabin_status_id", ocabin.cabin_status_id);
				arParams[6] = new SqlParameter("@cabin_rate", ocabin.cabin_rate);
				arParams[7] = new SqlParameter("@record_created_by", ocabin.record_created_by);
				arParams[8] = new SqlParameter("@record_modified_by", ocabin.record_modified_by);
				arParams[9] = new SqlParameter("@cabin_id", ocabin.cabin_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabinUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin(Cabin ocabin)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_id", ocabin.cabin_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabinDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin(int cabin_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@cabin_id", cabin_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "cabinDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
