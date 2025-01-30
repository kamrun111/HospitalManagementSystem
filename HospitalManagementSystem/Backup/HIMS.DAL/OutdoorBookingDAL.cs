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
	public class Outdoor_bookingDAL
	{
		public Outdoor_bookingDAL()
		{
		}
		public List<Outdoor_booking> Getoutdoor_bookingsList()
		{
			SqlConnection conn = null;
			List<Outdoor_booking> lstoutdoor_bookings = new List<Outdoor_booking>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_bookingGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Outdoor_booking ooutdoor_booking = new Outdoor_booking();
					ooutdoor_booking.outdoor_booking_id = Convert.ToInt32(dataReader["outdoor_booking_id"]);
					ooutdoor_booking.outdoor_patient_id = Convert.ToInt32(dataReader["outdoor_patient_id"]);

					if(dataReader["reffered_doctors_id"] != DBNull.Value)
						ooutdoor_booking.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["booking_date"] != DBNull.Value)
						ooutdoor_booking.booking_date = Convert.ToString(dataReader["booking_date"]);

					if(dataReader["booking_time"] != DBNull.Value)
						ooutdoor_booking.booking_time = Convert.ToString(dataReader["booking_time"]);

					if(dataReader["booking_serial_no"] != DBNull.Value)
						ooutdoor_booking.booking_serial_no = Convert.ToString(dataReader["booking_serial_no"]);

					if(dataReader["room_no"] != DBNull.Value)
						ooutdoor_booking.room_no = Convert.ToString(dataReader["room_no"]);

					if(dataReader["amount"] != DBNull.Value)
						ooutdoor_booking.amount = Convert.ToDecimal(dataReader["amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_booking.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_booking.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_booking.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_booking.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstoutdoor_bookings.Add(ooutdoor_booking);
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
			return lstoutdoor_bookings;
		}
		public DataSet Getoutdoor_bookings()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "outdoor_bookingGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet OPDPatientList(DateTime From,DateTime To)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@From", From);
                arParams[1] = new SqlParameter("@To", To);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OPDPatientList", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetOutdoorPopulationInfo()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutdoorPopulationInfo");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        

        public DataSet GetOutdoorConsultantAll()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutdoorConsultantAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetOutdoorConsultantPatient(int reffered_doctors_id)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@reffered_doctors_id", reffered_doctors_id);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutdoorConsultantPatient", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet ItemCharge(int item_id)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@ItemID", item_id);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "ItemCharge", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetOutdoorPatientHSN(int patient_code)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patient_code", patient_code);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutdoorPatientHSN", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet BookingPatientNameGet(int reffered_doctors_id, string booking_date)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@reffered_doctors_id", reffered_doctors_id);
                arParams[1] = new SqlParameter("@booking_date", booking_date);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "BookingPatientNameGet", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet GetOutDoorPatientInfo(int outdoor_booking_id)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@outdoor_booking_id", outdoor_booking_id);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetOutDoorPatientInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        

		public Outdoor_booking Getoutdoor_booking(int outdoor_booking_id)
		{
			SqlConnection conn = null;
			Outdoor_booking ooutdoor_booking = new Outdoor_booking();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_booking_id", outdoor_booking_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "outdoor_bookingGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ooutdoor_booking.outdoor_booking_id = Convert.ToInt32(dataReader["outdoor_booking_id"]);
					ooutdoor_booking.outdoor_patient_id = Convert.ToInt32(dataReader["outdoor_patient_id"]);

					if(dataReader["reffered_doctors_id"] != DBNull.Value)
						ooutdoor_booking.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["booking_date"] != DBNull.Value)
						ooutdoor_booking.booking_date = Convert.ToString(dataReader["booking_date"]);

					if(dataReader["booking_time"] != DBNull.Value)
						ooutdoor_booking.booking_time = Convert.ToString(dataReader["booking_time"]);

					if(dataReader["booking_serial_no"] != DBNull.Value)
						ooutdoor_booking.booking_serial_no = Convert.ToString(dataReader["booking_serial_no"]);

					if(dataReader["room_no"] != DBNull.Value)
						ooutdoor_booking.room_no = Convert.ToString(dataReader["room_no"]);

					if(dataReader["amount"] != DBNull.Value)
						ooutdoor_booking.amount = Convert.ToDecimal(dataReader["amount"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ooutdoor_booking.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ooutdoor_booking.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ooutdoor_booking.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ooutdoor_booking.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ooutdoor_booking;
		}
		public int Addoutdoor_booking(Outdoor_booking ooutdoor_booking)
		{
			SqlParameter[] arParams = new SqlParameter[9];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
			try
			{
				arParams[0] = new SqlParameter("@outdoor_patient_id", ooutdoor_booking.outdoor_patient_id);
				arParams[1] = new SqlParameter("@reffered_doctors_id", ooutdoor_booking.reffered_doctors_id);
				arParams[2] = new SqlParameter("@booking_date", ooutdoor_booking.booking_date);
				arParams[3] = new SqlParameter("@booking_time", ooutdoor_booking.booking_time);
				arParams[4] = new SqlParameter("@room_no", ooutdoor_booking.room_no);
				arParams[5] = new SqlParameter("@amount", ooutdoor_booking.amount);
				arParams[6] = new SqlParameter("@record_created_by", ooutdoor_booking.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", ooutdoor_booking.record_modified_by);
                arParams[8] = new SqlParameter("@outdoor_booking_id", SqlDbType.Int, 4);
                arParams[8].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "outdoor_bookingAdd", arParams);
                result = Convert.ToInt32(arParams[8].Value.ToString());
			}
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
		}

        public int Addoutdoor_ptient_booking(Outdoor_booking ooutdoor_booking)
        {
            SqlParameter[] arParams = new SqlParameter[11];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@outdoor_patient_id", ooutdoor_booking.outdoor_patient_id);
                arParams[1] = new SqlParameter("@reffered_doctors_id", ooutdoor_booking.reffered_doctors_id);
                arParams[2] = new SqlParameter("@booking_date", ooutdoor_booking.booking_date);
                arParams[3] = new SqlParameter("@booking_time", ooutdoor_booking.booking_time);
                arParams[4] = new SqlParameter("@room_no", ooutdoor_booking.room_no);
                arParams[5] = new SqlParameter("@amount", ooutdoor_booking.amount);
                arParams[6] = new SqlParameter("@discount", ooutdoor_booking.discount);
                arParams[7] = new SqlParameter("@vat", ooutdoor_booking.vat);
                arParams[8] = new SqlParameter("@outdoor_booking_id", ooutdoor_booking.outdoor_booking_id);
                arParams[9] = new SqlParameter("@record_created_by", ooutdoor_booking.record_created_by);
                arParams[10] = new SqlParameter("@record_modified_by", ooutdoor_booking.record_modified_by);                
                arParams[8].Direction = ParameterDirection.Output;
                
                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "OutdoorPatientAdd", arParams);
                result = Convert.ToInt32(arParams[8].Value.ToString());
            }
            catch (Exception ex)
            {
                result = -2;
                throw ex;
            }
            finally
            {
                DbHelper.CloseConnection(conn);
            }
            return result;
        }

		public int Updateoutdoor_booking(Outdoor_booking ooutdoor_booking)
		{

			SqlParameter[] arParams = new SqlParameter[10];
			try
			{
				arParams[0] = new SqlParameter("@outdoor_patient_id", ooutdoor_booking.outdoor_patient_id);
				arParams[1] = new SqlParameter("@reffered_doctors_id", ooutdoor_booking.reffered_doctors_id);
				arParams[2] = new SqlParameter("@booking_date", ooutdoor_booking.booking_date);
				arParams[3] = new SqlParameter("@booking_time", ooutdoor_booking.booking_time);
				arParams[4] = new SqlParameter("@booking_serial_no", ooutdoor_booking.booking_serial_no);
				arParams[5] = new SqlParameter("@room_no", ooutdoor_booking.room_no);
				arParams[6] = new SqlParameter("@amount", ooutdoor_booking.amount);
				arParams[8] = new SqlParameter("@record_created_by", ooutdoor_booking.record_created_by);
				arParams[9] = new SqlParameter("@record_modified_by", ooutdoor_booking.record_modified_by);
				arParams[10] = new SqlParameter("@outdoor_booking_id", ooutdoor_booking.outdoor_booking_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_bookingUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int OutdoorPaidAmount(Outdoor_booking ooutdoor_booking)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_booking.outdoor_booking_id);
                arParams[1] = new SqlParameter("@amount", ooutdoor_booking.amount);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OutdoorPaidAmount", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removeoutdoor_booking(Outdoor_booking ooutdoor_booking)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_booking_id", ooutdoor_booking.outdoor_booking_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_bookingDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeoutdoor_booking(int outdoor_booking_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@outdoor_booking_id", outdoor_booking_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "outdoor_bookingDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
