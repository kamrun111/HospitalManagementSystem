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
	public class RegularCheckupDAL
	{
		public RegularCheckupDAL()
		{
		}
		public List<RegularCheckup> Getregular_checkupsList()
		{
			SqlConnection conn = null;
			List<RegularCheckup> lstregular_checkups = new List<RegularCheckup>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "regular_checkupGetAll", null, ref conn);
				while (dataReader.Read())
				{
					RegularCheckup oregular_checkup = new RegularCheckup();
					oregular_checkup.regular_checkup_id = Convert.ToInt32(dataReader["regular_checkup_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						oregular_checkup.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["temperature"] != DBNull.Value)
						oregular_checkup.temperature = Convert.ToDecimal(dataReader["temperature"]);

					if(dataReader["pulse"] != DBNull.Value)
						oregular_checkup.pulse = Convert.ToInt32(dataReader["pulse"]);

					if(dataReader["bp"] != DBNull.Value)
						oregular_checkup.bp = Convert.ToString(dataReader["bp"]);

					if(dataReader["respitation"] != DBNull.Value)
						oregular_checkup.respitation = Convert.ToInt32(dataReader["respitation"]);

					if(dataReader["stool"] != DBNull.Value)
						oregular_checkup.stool = Convert.ToString(dataReader["stool"]);

					if(dataReader["weight"] != DBNull.Value)
						oregular_checkup.weight = Convert.ToDecimal(dataReader["weight"]);

					if(dataReader["checkup_date"] != DBNull.Value)
						oregular_checkup.checkup_date = Convert.ToDateTime(dataReader["checkup_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oregular_checkup.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oregular_checkup.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oregular_checkup.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oregular_checkup.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstregular_checkups.Add(oregular_checkup);
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
			return lstregular_checkups;
		}

        public DataSet GetRegularCheckup(int admissionID)// samia 16Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetRegularCheckup", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }




		public DataSet Getregular_checkups()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "regular_checkupGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public RegularCheckup Getregular_checkup(int regular_checkup_id)
		{
			SqlConnection conn = null;
			RegularCheckup oregular_checkup = new RegularCheckup();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@regular_checkup_id", regular_checkup_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "regular_checkupGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oregular_checkup.regular_checkup_id = Convert.ToInt32(dataReader["regular_checkup_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						oregular_checkup.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["temperature"] != DBNull.Value)
						oregular_checkup.temperature = Convert.ToDecimal(dataReader["temperature"]);

					if(dataReader["pulse"] != DBNull.Value)
						oregular_checkup.pulse = Convert.ToInt32(dataReader["pulse"]);

					if(dataReader["bp"] != DBNull.Value)
						oregular_checkup.bp = Convert.ToString(dataReader["bp"]);

					if(dataReader["respitation"] != DBNull.Value)
						oregular_checkup.respitation = Convert.ToInt32(dataReader["respitation"]);

					if(dataReader["stool"] != DBNull.Value)
						oregular_checkup.stool = Convert.ToString(dataReader["stool"]);

					if(dataReader["weight"] != DBNull.Value)
						oregular_checkup.weight = Convert.ToDecimal(dataReader["weight"]);

					if(dataReader["checkup_date"] != DBNull.Value)
						oregular_checkup.checkup_date = Convert.ToDateTime(dataReader["checkup_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oregular_checkup.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oregular_checkup.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oregular_checkup.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oregular_checkup.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oregular_checkup;
		}
		public int Addregular_checkup(RegularCheckup oregular_checkup)
		{
			SqlParameter[] arParams = new SqlParameter[10];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", oregular_checkup.admission_id);
				arParams[1] = new SqlParameter("@temperature", oregular_checkup.temperature);
				arParams[2] = new SqlParameter("@pulse", oregular_checkup.pulse);
				arParams[3] = new SqlParameter("@bp", oregular_checkup.bp);
				arParams[4] = new SqlParameter("@respitation", oregular_checkup.respitation);
				arParams[5] = new SqlParameter("@stool", oregular_checkup.stool);
				arParams[6] = new SqlParameter("@weight", oregular_checkup.weight);
				arParams[7] = new SqlParameter("@checkup_date", oregular_checkup.checkup_date);
				arParams[8] = new SqlParameter("@record_created_by", oregular_checkup.record_created_by);
				arParams[9] = new SqlParameter("@record_modified_by", oregular_checkup.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "regular_checkupAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateregular_checkup(RegularCheckup oregular_checkup)
		{

			SqlParameter[] arParams = new SqlParameter[13];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", oregular_checkup.admission_id);
				arParams[1] = new SqlParameter("@temperature", oregular_checkup.temperature);
				arParams[2] = new SqlParameter("@pulse", oregular_checkup.pulse);
				arParams[3] = new SqlParameter("@bp", oregular_checkup.bp);
				arParams[4] = new SqlParameter("@respitation", oregular_checkup.respitation);
				arParams[5] = new SqlParameter("@stool", oregular_checkup.stool);
				arParams[6] = new SqlParameter("@weight", oregular_checkup.weight);
				arParams[7] = new SqlParameter("@checkup_date", oregular_checkup.checkup_date);
				arParams[8] = new SqlParameter("@record_created_date", oregular_checkup.record_created_date);
				arParams[9] = new SqlParameter("@record_created_by", oregular_checkup.record_created_by);
				arParams[10] = new SqlParameter("@record_modified_date", oregular_checkup.record_modified_date);
				arParams[11] = new SqlParameter("@record_modified_by", oregular_checkup.record_modified_by);
				arParams[12] = new SqlParameter("@regular_checkup_id", oregular_checkup.regular_checkup_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "regular_checkupUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeregular_checkup(RegularCheckup oregular_checkup)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@regular_checkup_id", oregular_checkup.regular_checkup_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "regular_checkupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeregular_checkup(int regular_checkup_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@regular_checkup_id", regular_checkup_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "regular_checkupDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
