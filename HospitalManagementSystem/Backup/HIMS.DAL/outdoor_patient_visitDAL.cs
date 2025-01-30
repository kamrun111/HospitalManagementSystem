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
	public class outdoor_patient_visitDAL
	{
		public outdoor_patient_visitDAL()
		{
		}
		public List<OutdoorPatientVisit> Getoutdoor_patient_visitsList()
		{
			SqlConnection conn = null;
			List<OutdoorPatientVisit> lstoutdoor_patient_visits = new List<OutdoorPatientVisit>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_visitGetAll", null, ref conn);
				while (dataReader.Read())
				{
					OutdoorPatientVisit ooutdoor_patient_visit = new OutdoorPatientVisit();
					ooutdoor_patient_visit.outdoor_patient_visit_id = Convert.ToInt32(dataReader["outdoor_patient_visit_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
						ooutdoor_patient_visit.outdoor_booking_id = Convert.ToString(dataReader["outdoor_booking_id"]);

					if(dataReader["visited_date"] != DBNull.Value)
						ooutdoor_patient_visit.visited_date = Convert.ToDateTime(dataReader["visited_date"]);

					if(dataReader["patient_bp"] != DBNull.Value)
                        ooutdoor_patient_visit.patient_bp = Convert.ToString(dataReader["patient_bp"]);

					if(dataReader["patient_pulse"] != DBNull.Value)
						ooutdoor_patient_visit.patient_pulse = Convert.ToInt32(dataReader["patient_pulse"]);

					if(dataReader["patient_height"] != DBNull.Value)
						ooutdoor_patient_visit.patient_height = Convert.ToDouble(dataReader["patient_height"]);

					if(dataReader["patient_weight"] != DBNull.Value)
						ooutdoor_patient_visit.patient_weight = Convert.ToInt32(dataReader["patient_weight"]);

					if(dataReader["patient_temp"] != DBNull.Value)
						ooutdoor_patient_visit.patient_temp = Convert.ToDouble(dataReader["patient_temp"]);

					if(dataReader["patient_cc"] != DBNull.Value)
						ooutdoor_patient_visit.patient_cc = Convert.ToString(dataReader["patient_cc"]);

					if(dataReader["patient_primary_diagonosis"] != DBNull.Value)
						ooutdoor_patient_visit.patient_primary_diagonosis = Convert.ToString(dataReader["patient_primary_diagonosis"]);

					if(dataReader["next_visit_date"] != DBNull.Value)
						ooutdoor_patient_visit.next_visit_date = Convert.ToDateTime(dataReader["next_visit_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_visit.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_visit.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_visit.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_visit.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstoutdoor_patient_visits.Add(ooutdoor_patient_visit);
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
			return lstoutdoor_patient_visits;
		}
		public DataSet Getoutdoor_patient_visits()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "outdoor_patient_visitGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public OutdoorPatientVisit Getoutdoor_patient_visit(int outdoor_patient_visit_id)
		{
			SqlConnection conn = null;
			OutdoorPatientVisit ooutdoor_patient_visit = new OutdoorPatientVisit();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_visit_id", outdoor_patient_visit_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_patient_visitGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ooutdoor_patient_visit.outdoor_patient_visit_id = Convert.ToInt32(dataReader["outdoor_patient_visit_id"]);

					if(dataReader["outdoor_booking_id"] != DBNull.Value)
						ooutdoor_patient_visit.outdoor_booking_id = Convert.ToString(dataReader["outdoor_booking_id"]);

					if(dataReader["visited_date"] != DBNull.Value)
						ooutdoor_patient_visit.visited_date = Convert.ToDateTime(dataReader["visited_date"]);

					if(dataReader["patient_bp"] != DBNull.Value)
                        ooutdoor_patient_visit.patient_bp = Convert.ToString(dataReader["patient_bp"]);

					if(dataReader["patient_pulse"] != DBNull.Value)
						ooutdoor_patient_visit.patient_pulse = Convert.ToInt32(dataReader["patient_pulse"]);

					if(dataReader["patient_height"] != DBNull.Value)
						ooutdoor_patient_visit.patient_height = Convert.ToDouble(dataReader["patient_height"]);

					if(dataReader["patient_weight"] != DBNull.Value)
						ooutdoor_patient_visit.patient_weight = Convert.ToInt32(dataReader["patient_weight"]);

					if(dataReader["patient_temp"] != DBNull.Value)
						ooutdoor_patient_visit.patient_temp = Convert.ToDouble(dataReader["patient_temp"]);

					if(dataReader["patient_cc"] != DBNull.Value)
						ooutdoor_patient_visit.patient_cc = Convert.ToString(dataReader["patient_cc"]);

					if(dataReader["patient_primary_diagonosis"] != DBNull.Value)
						ooutdoor_patient_visit.patient_primary_diagonosis = Convert.ToString(dataReader["patient_primary_diagonosis"]);

					if(dataReader["next_visit_date"] != DBNull.Value)
						ooutdoor_patient_visit.next_visit_date = Convert.ToDateTime(dataReader["next_visit_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_patient_visit.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_patient_visit.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_patient_visit.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_patient_visit.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ooutdoor_patient_visit;
		}
		public int Addoutdoor_patient_visit(OutdoorPatientVisit ooutdoor_patient_visit)
		{
			SqlParameter[] arParams = new SqlParameter[12];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_visit.outdoor_booking_id);
				arParams[1] = new SqlParameter("@visited_date", ooutdoor_patient_visit.visited_date);
				arParams[2] = new SqlParameter("@patient_bp", ooutdoor_patient_visit.patient_bp);
				arParams[3] = new SqlParameter("@patient_pulse", ooutdoor_patient_visit.patient_pulse);
				arParams[4] = new SqlParameter("@patient_height", ooutdoor_patient_visit.patient_height);
				arParams[5] = new SqlParameter("@patient_weight", ooutdoor_patient_visit.patient_weight);
				arParams[6] = new SqlParameter("@patient_temp", ooutdoor_patient_visit.patient_temp);
				arParams[7] = new SqlParameter("@patient_cc", ooutdoor_patient_visit.patient_cc);
				arParams[8] = new SqlParameter("@patient_primary_diagonosis", ooutdoor_patient_visit.patient_primary_diagonosis);
				arParams[9] = new SqlParameter("@next_visit_date", ooutdoor_patient_visit.next_visit_date);
				arParams[10] = new SqlParameter("@record_created_by", ooutdoor_patient_visit.record_created_by);
				arParams[11] = new SqlParameter("@record_modified_by", ooutdoor_patient_visit.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_visitAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateoutdoor_patient_visit(OutdoorPatientVisit ooutdoor_patient_visit)
		{

			SqlParameter[] arParams = new SqlParameter[13];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_patient_visit.outdoor_booking_id);
				arParams[1] = new SqlParameter("@visited_date", ooutdoor_patient_visit.visited_date);
				arParams[2] = new SqlParameter("@patient_bp", ooutdoor_patient_visit.patient_bp);
				arParams[3] = new SqlParameter("@patient_pulse", ooutdoor_patient_visit.patient_pulse);
				arParams[4] = new SqlParameter("@patient_height", ooutdoor_patient_visit.patient_height);
				arParams[5] = new SqlParameter("@patient_weight", ooutdoor_patient_visit.patient_weight);
				arParams[6] = new SqlParameter("@patient_temp", ooutdoor_patient_visit.patient_temp);
				arParams[7] = new SqlParameter("@patient_cc", ooutdoor_patient_visit.patient_cc);
				arParams[8] = new SqlParameter("@patient_primary_diagonosis", ooutdoor_patient_visit.patient_primary_diagonosis);
				arParams[9] = new SqlParameter("@next_visit_date", ooutdoor_patient_visit.next_visit_date);
				arParams[10] = new SqlParameter("@record_created_by", ooutdoor_patient_visit.record_created_by);
				arParams[11] = new SqlParameter("@record_modified_by", ooutdoor_patient_visit.record_modified_by);
				arParams[12] = new SqlParameter("@outdoor_patient_visit_id", ooutdoor_patient_visit.outdoor_patient_visit_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_visitUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_visit(OutdoorPatientVisit ooutdoor_patient_visit)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_visit_id", ooutdoor_patient_visit.outdoor_patient_visit_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_visitDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_patient_visit(int outdoor_patient_visit_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_patient_visit_id", outdoor_patient_visit_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_patient_visitDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
