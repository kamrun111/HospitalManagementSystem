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
	public class RefferedDoctorsDAL
	{
		public RefferedDoctorsDAL()
		{
		}
		public List<RefferedDoctors> Getreffered_doctorssList()
		{
			SqlConnection conn = null;
            List<RefferedDoctors> lstreffered_doctorss = new List<RefferedDoctors>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "reffered_doctorsGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    RefferedDoctors oreffered_doctors = new RefferedDoctors();
					oreffered_doctors.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["reffered_doctors"] != DBNull.Value)
						oreffered_doctors.reffered_doctors = Convert.ToString(dataReader["reffered_doctors"]);

					if(dataReader["d_c"] != DBNull.Value)
						oreffered_doctors.d_c = Convert.ToString(dataReader["d_c"]);

					if(dataReader["degree"] != DBNull.Value)
						oreffered_doctors.degree = Convert.ToString(dataReader["degree"]);

					if(dataReader["doctor_level_id"] != DBNull.Value)
						oreffered_doctors.doctor_level_id = Convert.ToInt32(dataReader["doctor_level_id"]);

					if(dataReader["specialist_in_id"] != DBNull.Value)
						oreffered_doctors.specialist_in_id = Convert.ToInt32(dataReader["specialist_in_id"]);

					if(dataReader["designation_id"] != DBNull.Value)
						oreffered_doctors.designation_id = Convert.ToInt32(dataReader["designation_id"]);

					if(dataReader["gender_id"] != DBNull.Value)
						oreffered_doctors.gender_id = Convert.ToInt32(dataReader["gender_id"]);

					if(dataReader["attachment"] != DBNull.Value)
						oreffered_doctors.attachment = Convert.ToString(dataReader["attachment"]);

					if(dataReader["contact_no"] != DBNull.Value)
						oreffered_doctors.contact_no = Convert.ToString(dataReader["contact_no"]);

					if(dataReader["mobile"] != DBNull.Value)
						oreffered_doctors.mobile = Convert.ToString(dataReader["mobile"]);

					if(dataReader["address"] != DBNull.Value)
						oreffered_doctors.address = Convert.ToString(dataReader["address"]);

					if(dataReader["city_id"] != DBNull.Value)
						oreffered_doctors.city_id = Convert.ToInt32(dataReader["city_id"]);

					if(dataReader["visit_charge"] != DBNull.Value)
						oreffered_doctors.visit_charge = Convert.ToDecimal(dataReader["visit_charge"]);

					if(dataReader["sergery_charge"] != DBNull.Value)
						oreffered_doctors.sergery_charge = Convert.ToDecimal(dataReader["sergery_charge"]);

					if(dataReader["dressing_charge"] != DBNull.Value)
						oreffered_doctors.dressing_charge = Convert.ToDecimal(dataReader["dressing_charge"]);

					if(dataReader["is_consultant"] != DBNull.Value)
						oreffered_doctors.is_consultant = Convert.ToSByte(dataReader["is_consultant"]);

					if(dataReader["room_no"] != DBNull.Value)
						oreffered_doctors.room_no = Convert.ToString(dataReader["room_no"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oreffered_doctors.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oreffered_doctors.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oreffered_doctors.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oreffered_doctors.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstreffered_doctorss.Add(oreffered_doctors);
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
            return lstreffered_doctorss;
		}
		public DataSet Getreffered_doctorss()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "reffered_doctorsGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet getconsultant(int flag)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@flag", flag);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getconsultant", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetConsultantAll()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetConsultantAll");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetSConsultants(int specialistInID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@specialist_in_id", specialistInID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetSConsultants", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetOutdoorConsultantPatient(int RefferedDoctorsID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@reffered_doctors_id", RefferedDoctorsID);
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

        public DataSet GetVisitRoom(int refferedDoctorsID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@reffered_doctors_id", refferedDoctorsID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetVisitRoom", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }



        public DataSet GetConsultantListInfo(int refferedDocID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@reffered_doctors_id", refferedDocID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetConsultantListInfo", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public RefferedDoctors Getreffered_doctors(int reffered_doctors_id)  //Modified by Kaysar (17-09-08)
		{
			SqlConnection conn = null;
            RefferedDoctors oreffered_doctors = new RefferedDoctors();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@reffered_doctors_id", reffered_doctors_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "reffered_doctorsGet", arParams, ref conn);
                while (dataReader.Read())
                {
                    oreffered_doctors.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

                    if (dataReader["reffered_doctors"] != DBNull.Value)
                        oreffered_doctors.reffered_doctors = Convert.ToString(dataReader["reffered_doctors"]);

                    if (dataReader["d_c"] != DBNull.Value)
                        oreffered_doctors.d_c = Convert.ToString(dataReader["d_c"]);

                    if (dataReader["degree"] != DBNull.Value)
                        oreffered_doctors.degree = Convert.ToString(dataReader["degree"]);

                    if (dataReader["doctor_level_id"] != DBNull.Value)
                        oreffered_doctors.doctor_level_id = Convert.ToInt32(dataReader["doctor_level_id"]);

                    if (dataReader["specialist_in_id"] != DBNull.Value)
                        oreffered_doctors.specialist_in_id = Convert.ToInt32(dataReader["specialist_in_id"]);

                    if (dataReader["designation_id"] != DBNull.Value)
                        oreffered_doctors.designation_id = Convert.ToInt32(dataReader["designation_id"]);

                    if (dataReader["gender_id"] != DBNull.Value)
                        oreffered_doctors.gender_id = Convert.ToInt32(dataReader["gender_id"]);

                    if (dataReader["attachment"] != DBNull.Value)
                        oreffered_doctors.attachment = Convert.ToString(dataReader["attachment"]);

                    if (dataReader["contact_no"] != DBNull.Value)
                        oreffered_doctors.contact_no = Convert.ToString(dataReader["contact_no"]);

                    if (dataReader["mobile"] != DBNull.Value)
                        oreffered_doctors.mobile = Convert.ToString(dataReader["mobile"]);

                    if (dataReader["address"] != DBNull.Value)
                        oreffered_doctors.address = Convert.ToString(dataReader["address"]);

                    if (dataReader["city_id"] != DBNull.Value)
                        oreffered_doctors.city_id = Convert.ToInt32(dataReader["city_id"]);

                    if (dataReader["visit_charge"] != DBNull.Value)
                        oreffered_doctors.visit_charge = Convert.ToDecimal(dataReader["visit_charge"]);

                    if (dataReader["sergery_charge"] != DBNull.Value)
                        oreffered_doctors.sergery_charge = Convert.ToDecimal(dataReader["sergery_charge"]);

                    if (dataReader["dressing_charge"] != DBNull.Value)
                        oreffered_doctors.dressing_charge = Convert.ToDecimal(dataReader["dressing_charge"]);

                    if (dataReader["is_consultant"] != DBNull.Value)
                        oreffered_doctors.is_consultant = Convert.ToSByte(dataReader["is_consultant"]);

                    if (dataReader["room_no"] != DBNull.Value)
                        oreffered_doctors.room_no = Convert.ToString(dataReader["room_no"]);

                    if (dataReader["record_created_date"] != DBNull.Value)
                        oreffered_doctors.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

                    if (dataReader["record_created_by"] != DBNull.Value)
                        oreffered_doctors.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

                    if (dataReader["record_modified_date"] != DBNull.Value)
                        oreffered_doctors.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

                    if (dataReader["record_modified_by"] != DBNull.Value)
                        oreffered_doctors.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
            return oreffered_doctors;
		}
        public int Addreffered_doctors(RefferedDoctors oreffered_doctors)
		{
			SqlParameter[] arParams = new SqlParameter[19];
			try
			{
				arParams[0] = new SqlParameter("@reffered_doctors", oreffered_doctors.reffered_doctors);
				arParams[1] = new SqlParameter("@d_c", oreffered_doctors.d_c);
				arParams[2] = new SqlParameter("@degree", oreffered_doctors.degree);
				arParams[3] = new SqlParameter("@doctor_level_id", oreffered_doctors.doctor_level_id);
				arParams[4] = new SqlParameter("@specialist_in_id", oreffered_doctors.specialist_in_id);
				arParams[5] = new SqlParameter("@designation_id", oreffered_doctors.designation_id);
				arParams[6] = new SqlParameter("@gender_id", oreffered_doctors.gender_id);
				arParams[7] = new SqlParameter("@attachment", oreffered_doctors.attachment);
				arParams[8] = new SqlParameter("@contact_no", oreffered_doctors.contact_no);
				arParams[9] = new SqlParameter("@mobile", oreffered_doctors.mobile);
				arParams[10] = new SqlParameter("@address", oreffered_doctors.address);
				arParams[11] = new SqlParameter("@city_id", oreffered_doctors.city_id);
				arParams[12] = new SqlParameter("@visit_charge", oreffered_doctors.visit_charge);
				arParams[13] = new SqlParameter("@sergery_charge", oreffered_doctors.sergery_charge);
				arParams[14] = new SqlParameter("@dressing_charge", oreffered_doctors.dressing_charge);
				arParams[15] = new SqlParameter("@is_consultant", 1);
				arParams[16] = new SqlParameter("@room_no", oreffered_doctors.room_no);
				arParams[17] = new SqlParameter("@record_created_by", oreffered_doctors.record_created_by);
				arParams[18] = new SqlParameter("@record_modified_by", oreffered_doctors.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "reffered_doctorsAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatereffered_doctors(RefferedDoctors oreffered_doctors)
		{

			SqlParameter[] arParams = new SqlParameter[19];
			try
			{
				arParams[0] = new SqlParameter("@reffered_doctors", oreffered_doctors.reffered_doctors);
				arParams[1] = new SqlParameter("@d_c", oreffered_doctors.d_c);
				arParams[2] = new SqlParameter("@degree", oreffered_doctors.degree);
				arParams[3] = new SqlParameter("@doctor_level_id", oreffered_doctors.doctor_level_id);
				arParams[4] = new SqlParameter("@specialist_in_id", oreffered_doctors.specialist_in_id);
				arParams[5] = new SqlParameter("@designation_id", oreffered_doctors.designation_id);
				arParams[6] = new SqlParameter("@gender_id", oreffered_doctors.gender_id);
				arParams[7] = new SqlParameter("@attachment", oreffered_doctors.attachment);
				arParams[8] = new SqlParameter("@contact_no", oreffered_doctors.contact_no);
				arParams[9] = new SqlParameter("@mobile", oreffered_doctors.mobile);
				arParams[10] = new SqlParameter("@address", oreffered_doctors.address);
				arParams[11] = new SqlParameter("@city_id", oreffered_doctors.city_id);
				arParams[12] = new SqlParameter("@visit_charge", oreffered_doctors.visit_charge);
				arParams[13] = new SqlParameter("@sergery_charge", oreffered_doctors.sergery_charge);
				arParams[14] = new SqlParameter("@dressing_charge", oreffered_doctors.dressing_charge);
				arParams[15] = new SqlParameter("@is_consultant", 1);
				arParams[16] = new SqlParameter("@room_no", oreffered_doctors.room_no);
				arParams[17] = new SqlParameter("@reffered_doctors_id", oreffered_doctors.reffered_doctors_id);
                arParams[18] = new SqlParameter("@record_modified_by", oreffered_doctors.record_modified_by);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "reffered_doctorsUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removereffered_doctors(RefferedDoctors oreffered_doctors)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@reffered_doctors_id", oreffered_doctors.reffered_doctors_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "reffered_doctorsDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereffered_doctors(int reffered_doctors_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@reffered_doctors_id", reffered_doctors_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "reffered_doctorsDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
