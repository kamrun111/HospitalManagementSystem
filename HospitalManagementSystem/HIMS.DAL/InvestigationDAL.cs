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
	public class InvestigationDAL
	{
		public InvestigationDAL()
		{
		}
		public List<InvestigationBO> GetinvestigationsList()
		{
			SqlConnection conn = null;
			List<InvestigationBO> lstinvestigations = new List<InvestigationBO>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigationGetAll", null, ref conn);
				while (dataReader.Read())
				{
					InvestigationBO oinvestigation = new InvestigationBO();
					oinvestigation.investigation_id = Convert.ToInt32(dataReader["investigation_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						oinvestigation.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["patient_id"] != DBNull.Value)
						oinvestigation.patient_id = Convert.ToInt32(dataReader["patient_id"]);

					if(dataReader["order_date"] != DBNull.Value)
						oinvestigation.order_date = Convert.ToDateTime(dataReader["order_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstinvestigations.Add(oinvestigation);
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
			return lstinvestigations;
		}

        public DataSet GetInvestigationPopulationInfo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetInvestigationPopulationInfo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet InvestigationList(DateTime From, DateTime To)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@From", From);
                arParams[1] = new SqlParameter("@To", To);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestigationList", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetIPDInvestigationPopulationInfo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetIPDInvestigationPopulationInfo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetIPDInvestigationPopulationInfoMember()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetIPDInvestigationPopulationInfoMember");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet getdocInfo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getdocInfo");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int donebypatient(VisitInvestigation ovisit_investigation)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@recordmodifivedby", ovisit_investigation.record_modified_by);
                arParams[1] = new SqlParameter("@visitInvestigationID", ovisit_investigation.visit_investigation_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "donebypatient", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet InvestigationSearch(int PateentID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patientID", PateentID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestigationSearch", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet spSearch(int testID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@test_item_id", testID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "sp", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet Getinvestigations()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "investigationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetTestElement(int investigation_testID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@investigation_testID", investigation_testID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetTestElement", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet GetTestElement2(int TestItemID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@test_itemID", TestItemID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetTestElement2", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public InvestigationBO Getinvestigation(int investigation_id)
		{
			SqlConnection conn = null;
			InvestigationBO oinvestigation = new InvestigationBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_id", investigation_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigationGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oinvestigation.investigation_id = Convert.ToInt32(dataReader["investigation_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						oinvestigation.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["patient_id"] != DBNull.Value)
						oinvestigation.patient_id = Convert.ToInt32(dataReader["patient_id"]);

					if(dataReader["order_date"] != DBNull.Value)
						oinvestigation.order_date = Convert.ToDateTime(dataReader["order_date"]);

                    if (dataReader["invest_ref_doctor_id"] != DBNull.Value)
                        oinvestigation.invest_ref_doctor_id = Convert.ToInt32(dataReader["invest_ref_doctor_id"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oinvestigation;
		}
		public int Addinvestigation(InvestigationBO oinvestigation)
		{
			SqlParameter[] arParams = new SqlParameter[7];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;

			try
			{
				arParams[0] = new SqlParameter("@admission_id", oinvestigation.admission_id);
				arParams[1] = new SqlParameter("@patient_id", oinvestigation.patient_id);
				arParams[2] = new SqlParameter("@order_date", oinvestigation.order_date);
                arParams[3] = new SqlParameter("@invest_ref_doctor_id", oinvestigation.invest_ref_doctor_id);
				arParams[4] = new SqlParameter("@record_created_by", oinvestigation.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", oinvestigation.record_modified_by);
                arParams[6] = new SqlParameter("@res", SqlDbType.Int, 4);
                arParams[6].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "investigationAdd", arParams);
                result = Convert.ToInt32(arParams[6].Value.ToString());
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

        public int Addinvestigations(Patient patient, InvestigationBO investigation)
        {
            SqlParameter[] arParams = new SqlParameter[19];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@patient_type", patient.patient_type);
                arParams[1] = new SqlParameter("@patient_name", patient.patient_name);
                arParams[2] = new SqlParameter("@gender_id", patient.gender_id);
                arParams[3] = new SqlParameter("@address", patient.address);
                arParams[4] = new SqlParameter("@city_id", patient.city_id);
                arParams[5] = new SqlParameter("@c_phone", patient.c_phone);
                arParams[6] = new SqlParameter("@dob", patient.dob);
                arParams[7] = new SqlParameter("@occupation_id", patient.occupation_id);
                arParams[8] = new SqlParameter("@nationality_id", patient.nationality_id);
                arParams[9] = new SqlParameter("@religion_id", patient.religion_id);
                arParams[10] = new SqlParameter("@patient_condition_id", patient.patient_condition_id);
                arParams[11] = new SqlParameter("@invest_ref_doctor_id", investigation.invest_ref_doctor_id);
                arParams[12] = new SqlParameter("@record_created_by", patient.record_created_by);
                arParams[13] = new SqlParameter("@record_modified_by", patient.record_modified_by);
                arParams[14] = new SqlParameter("@total_amount", investigation.total_amount);
                arParams[15] = new SqlParameter("@res", SqlDbType.Int, 4);
                arParams[15].Direction = ParameterDirection.Output;

                arParams[16] = new SqlParameter("@discount", investigation.discount);
                arParams[17] = new SqlParameter("@total_tube_amount", investigation.total_tube_amount);
                arParams[18] = new SqlParameter("@remarks", investigation.remarks);

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "InvestigationsAdd", arParams);
                result = Convert.ToInt32(arParams[15].Value.ToString());
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

        //public DataSet getdoctorspercentage(int docid,DateTime date1, DateTime date2)
        //{
        //    try
        //    {
        //        SqlParameter[] arParams = new SqlParameter[3];
        //        arParams[0] = new SqlParameter("@From", date1);
        //        arParams[1] = new SqlParameter("@To", date2);
        //        arParams[2] = new SqlParameter("@refdocID", docid);
        //        return DbHelper.GetDataSet(CommandType.StoredProcedure, "getdoctorspercentage", arParams);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //    }
        //}
        public int Investigationsupdate(Patient patient, InvestigationBO investigation)
        {
            SqlParameter[] arParams = new SqlParameter[16];
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;
            try
            {
                arParams[0] = new SqlParameter("@patient_code", patient.patient_code);
                arParams[1] = new SqlParameter("@patient_name", patient.patient_name);
                arParams[2] = new SqlParameter("@gender_id", patient.gender_id);
                arParams[3] = new SqlParameter("@address", patient.address);
                arParams[4] = new SqlParameter("@city_id", patient.city_id);
                arParams[5] = new SqlParameter("@c_phone", patient.c_phone);
                arParams[6] = new SqlParameter("@dob", patient.dob);
                arParams[7] = new SqlParameter("@occupation_id", patient.occupation_id);
                arParams[8] = new SqlParameter("@nationality_id", patient.nationality_id);
                arParams[9] = new SqlParameter("@religion_id", patient.religion_id);
                arParams[10] = new SqlParameter("@patient_condition_id", patient.patient_condition_id);
                arParams[11] = new SqlParameter("@invest_ref_doctor_id", investigation.invest_ref_doctor_id);
                arParams[12] = new SqlParameter("@record_created_by", patient.record_created_by);
                arParams[13] = new SqlParameter("@record_modified_by", patient.record_modified_by);
                arParams[14] = new SqlParameter("@total_amount", investigation.total_amount);
                arParams[15] = new SqlParameter("@res", SqlDbType.Int, 4);
                arParams[15].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "Investigationsupdate", arParams);
                result = Convert.ToInt32(arParams[15].Value.ToString());
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
        public DataSet getdoctorspercentage(int docID,DateTime date1, DateTime date2)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[3];
                arParams[0] = new SqlParameter("@refdocID", docID);
                arParams[1] = new SqlParameter("@From", date1);
                arParams[2] = new SqlParameter("@To", date2);
                

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "getdoctorspercentage", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

		public int Updateinvestigation(InvestigationBO oinvestigation)
		{

			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", oinvestigation.admission_id);
				arParams[1] = new SqlParameter("@patient_id", oinvestigation.patient_id);
				arParams[2] = new SqlParameter("@order_date", oinvestigation.order_date);
                arParams[3] = new SqlParameter("@invest_ref_doctor_id", oinvestigation.invest_ref_doctor_id);
				arParams[4] = new SqlParameter("@record_created_by", oinvestigation.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", oinvestigation.record_modified_by);
				arParams[6] = new SqlParameter("@investigation_id", oinvestigation.investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigationUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation(InvestigationBO oinvestigation)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_id", oinvestigation.investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation(int investigation_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_id", investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
