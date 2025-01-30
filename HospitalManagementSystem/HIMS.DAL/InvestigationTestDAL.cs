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
	public class InvestigationTestDAL
	{
		public InvestigationTestDAL()
		{
		}
		public List<InvestigationTest> Getinvestigation_testsList()
		{
			SqlConnection conn = null;
			List<InvestigationTest> lstinvestigation_tests = new List<InvestigationTest>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_testGetAll", null, ref conn);
				while (dataReader.Read())
				{
					InvestigationTest oinvestigation_test = new InvestigationTest();
					oinvestigation_test.investigation_test_id = Convert.ToInt32(dataReader["investigation_test_id"]);

					if(dataReader["investigation_id"] != DBNull.Value)
						oinvestigation_test.investigation_id = Convert.ToInt32(dataReader["investigation_id"]);

					if(dataReader["test_department_id"] != DBNull.Value)
						oinvestigation_test.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["test_group_id"] != DBNull.Value)
						oinvestigation_test.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["test_item_id"] != DBNull.Value)
						oinvestigation_test.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["charge"] != DBNull.Value)
						oinvestigation_test.charge = Convert.ToDecimal(dataReader["charge"]);

					if(dataReader["result"] != DBNull.Value)
						oinvestigation_test.result = Convert.ToString(dataReader["result"]);

					if(dataReader["reffered_doctors_id"] != DBNull.Value)
						oinvestigation_test.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["delivery_date"] != DBNull.Value)
						oinvestigation_test.delivery_date = Convert.ToDateTime(dataReader["delivery_date"]);

					if(dataReader["report_done"] != DBNull.Value)
						oinvestigation_test.report_done = Convert.ToSByte(dataReader["report_done"]);

					if(dataReader["delivered"] != DBNull.Value)
						oinvestigation_test.delivered = Convert.ToSByte(dataReader["delivered"]);

					if(dataReader["user_id"] != DBNull.Value)
						oinvestigation_test.user_id = Convert.ToInt32(dataReader["user_id"]);

					if(dataReader["actual_delivery_date"] != DBNull.Value)
						oinvestigation_test.actual_delivery_date = Convert.ToDateTime(dataReader["actual_delivery_date"]);

					if(dataReader["sample_collected"] != DBNull.Value)
						oinvestigation_test.sample_collected = Convert.ToSByte(dataReader["sample_collected"]);

					if(dataReader["sample_collection_date"] != DBNull.Value)
						oinvestigation_test.sample_collection_date = Convert.ToDateTime(dataReader["sample_collection_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_test.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_test.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_test.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_test.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstinvestigation_tests.Add(oinvestigation_test);
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
			return lstinvestigation_tests;
		}
		public DataSet Getinvestigation_tests()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "investigation_testGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetSampleCollectionInfo(string testDept,int value)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[2];
                arParams[0] = new SqlParameter("@test_department", testDept);
                arParams[1] = new SqlParameter("@sampleCollection", value);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "SampleCollectionInfoGet", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet SampleCollectionInfoGetAll()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "SampleCollectionInfoGetAll");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }


        public DataSet GetInvestigationTestDeliveryInfo()
        {
            try
            {
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestigationTestDeliveryInfoGet");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }


        public DataSet InvestTestInfoByPIDForDelivery(int patientID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@patient_id", patientID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "InvestTestInfoByPIDForDelivery", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet GetTestElementforDoc(int investigationID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@investigation_testID", investigationID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetTestElementforDoc", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public DataSet TestInfoGet(string test_department, int ID, string Cabin, string Types,int SampleCollected)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[5];
                arParams[0] = new SqlParameter("@test_department", test_department);
                arParams[1] = new SqlParameter("@ID", ID);
                arParams[2] = new SqlParameter("@CabinNo", Cabin);
                arParams[3] = new SqlParameter("@Types", Types);
                arParams[4] = new SqlParameter("@SampleCollected", SampleCollected);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "TestInfoGet", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public InvestigationTest Getinvestigation_test(int investigation_test_id)
		{
			SqlConnection conn = null;
			InvestigationTest oinvestigation_test = new InvestigationTest();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_test_id", investigation_test_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "investigation_testGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oinvestigation_test.investigation_test_id = Convert.ToInt32(dataReader["investigation_test_id"]);

					if(dataReader["investigation_id"] != DBNull.Value)
						oinvestigation_test.investigation_id = Convert.ToInt32(dataReader["investigation_id"]);

					if(dataReader["test_department_id"] != DBNull.Value)
						oinvestigation_test.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["test_group_id"] != DBNull.Value)
						oinvestigation_test.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["test_item_id"] != DBNull.Value)
						oinvestigation_test.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["charge"] != DBNull.Value)
						oinvestigation_test.charge = Convert.ToDecimal(dataReader["charge"]);

					if(dataReader["result"] != DBNull.Value)
						oinvestigation_test.result = Convert.ToString(dataReader["result"]);

					if(dataReader["reffered_doctors_id"] != DBNull.Value)
						oinvestigation_test.reffered_doctors_id = Convert.ToInt32(dataReader["reffered_doctors_id"]);

					if(dataReader["delivery_date"] != DBNull.Value)
						oinvestigation_test.delivery_date = Convert.ToDateTime(dataReader["delivery_date"]);

					if(dataReader["report_done"] != DBNull.Value)
						oinvestigation_test.report_done = Convert.ToSByte(dataReader["report_done"]);

					if(dataReader["delivered"] != DBNull.Value)
						oinvestigation_test.delivered = Convert.ToSByte(dataReader["delivered"]);

					if(dataReader["user_id"] != DBNull.Value)
						oinvestigation_test.user_id = Convert.ToInt32(dataReader["user_id"]);

					if(dataReader["actual_delivery_date"] != DBNull.Value)
						oinvestigation_test.actual_delivery_date = Convert.ToDateTime(dataReader["actual_delivery_date"]);

					if(dataReader["sample_collected"] != DBNull.Value)
						oinvestigation_test.sample_collected = Convert.ToSByte(dataReader["sample_collected"]);

					if(dataReader["sample_collection_date"] != DBNull.Value)
						oinvestigation_test.sample_collection_date = Convert.ToDateTime(dataReader["sample_collection_date"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oinvestigation_test.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oinvestigation_test.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oinvestigation_test.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oinvestigation_test.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oinvestigation_test;
		}
		public int Addinvestigation_test(InvestigationTest oinvestigation_test,int visitinvestigationID)
		{
			SqlParameter[] arParams = new SqlParameter[21];
			try
			{
				arParams[0] = new SqlParameter("@investigation_id", oinvestigation_test.investigation_id);
				arParams[1] = new SqlParameter("@test_department_id", oinvestigation_test.test_department_id);
				arParams[2] = new SqlParameter("@test_group_id", oinvestigation_test.test_group_id);
				arParams[3] = new SqlParameter("@test_item_id", oinvestigation_test.test_item_id);
                arParams[4] = new SqlParameter("@test_element_id", oinvestigation_test.test_element_id);
                arParams[5] = new SqlParameter("@order_no", oinvestigation_test.order_no);
                arParams[6] = new SqlParameter("@sample_serial_no", oinvestigation_test.sample_serial_no);
				arParams[7] = new SqlParameter("@charge", oinvestigation_test.charge);
				arParams[8] = new SqlParameter("@result", oinvestigation_test.result);
				arParams[9] = new SqlParameter("@reffered_doctors_id", oinvestigation_test.reffered_doctors_id);
				arParams[10] = new SqlParameter("@delivery_date", oinvestigation_test.delivery_date);
				arParams[11] = new SqlParameter("@report_done", oinvestigation_test.report_done);
				arParams[12] = new SqlParameter("@delivered", oinvestigation_test.delivered);
				arParams[13] = new SqlParameter("@user_id", oinvestigation_test.user_id);
                arParams[14] = new SqlParameter("@for_baby", oinvestigation_test.for_baby);
				arParams[15] = new SqlParameter("@actual_delivery_date", oinvestigation_test.actual_delivery_date);
				arParams[16] = new SqlParameter("@sample_collected", oinvestigation_test.sample_collected);
				arParams[17] = new SqlParameter("@sample_collection_date", oinvestigation_test.sample_collection_date);
				arParams[18] = new SqlParameter("@record_created_by", oinvestigation_test.record_created_by);
				arParams[19] = new SqlParameter("@record_modified_by", oinvestigation_test.record_modified_by);
                arParams[20] = new SqlParameter("@visitinvestigationID", visitinvestigationID);


				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_testAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        //public int Updateinvestigation_test(InvestigationTest oinvestigation_test)
        //{

        //    SqlParameter[] arParams = new SqlParameter[17];
        //    try
        //    {
        //        arParams[0] = new SqlParameter("@investigation_id", oinvestigation_test.investigation_id);
        //        arParams[1] = new SqlParameter("@test_department_id", oinvestigation_test.test_department_id);
        //        arParams[2] = new SqlParameter("@test_group_id", oinvestigation_test.test_group_id);
        //        arParams[3] = new SqlParameter("@test_item_id", oinvestigation_test.test_item_id);
        //        arParams[4] = new SqlParameter("@charge", oinvestigation_test.charge);
        //        arParams[5] = new SqlParameter("@result", oinvestigation_test.result);
        //        arParams[6] = new SqlParameter("@reffered_doctors_id", oinvestigation_test.reffered_doctors_id);
        //        arParams[7] = new SqlParameter("@delivery_date", oinvestigation_test.delivery_date);
        //        arParams[8] = new SqlParameter("@report_done", oinvestigation_test.report_done);
        //        arParams[9] = new SqlParameter("@delivered", oinvestigation_test.delivered);
        //        arParams[10] = new SqlParameter("@user_id", oinvestigation_test.user_id);
        //        arParams[11] = new SqlParameter("@actual_delivery_date", oinvestigation_test.actual_delivery_date);
        //        arParams[12] = new SqlParameter("@sample_collected", oinvestigation_test.sample_collected);
        //        arParams[13] = new SqlParameter("@sample_collection_date", oinvestigation_test.sample_collection_date);
        //        arParams[14] = new SqlParameter("@record_created_by", oinvestigation_test.record_created_by);
        //        arParams[15] = new SqlParameter("@record_modified_by", oinvestigation_test.record_modified_by);
        //        arParams[16] = new SqlParameter("@investigation_test_id", oinvestigation_test.investigation_test_id);
        //        return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_testUpdate", arParams);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        
        public int Updateinvestigation_testAfterReportDone(InvestigationTest oinvestigation_test)
        {
            SqlParameter[] arParams = new SqlParameter[4];
            try
            {   
                arParams[0] = new SqlParameter("@reffered_doctors_id", oinvestigation_test.reffered_doctors_id);
                arParams[1] = new SqlParameter("@result", oinvestigation_test.result);
                arParams[2] = new SqlParameter("@record_modified_by", oinvestigation_test.record_modified_by);
                arParams[3] = new SqlParameter("@investigation_test_id", oinvestigation_test.investigation_test_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_testUpdateAfterReportDone", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Updateinvestigation_test(InvestigationTest oinvestigation_test)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@record_modified_by", oinvestigation_test.record_modified_by);
                arParams[1] = new SqlParameter("@investigation_test_id", oinvestigation_test.investigation_test_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_testUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateStickerPrint(InvestigationTest oinvestigation_test)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@sticker_printed", oinvestigation_test.sticker_printed);
                arParams[1] = new SqlParameter("@test_department_id", oinvestigation_test.test_department_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UpdateStickerPrint", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet SearchTest(string test_name)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@test_name", test_name);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "SearchTest", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int investigation_cancelation(InvestigationTest oinvestigation_test,int Cnl)
        {

            SqlParameter[] arParams = new SqlParameter[4];
            try
            {
                arParams[0] = new SqlParameter("@cancelation", Cnl);
                arParams[1] = new SqlParameter("@record_modified_by", oinvestigation_test.record_modified_by);
                arParams[2] = new SqlParameter("@investigation_id", oinvestigation_test.investigation_id);
                arParams[3] = new SqlParameter("@test_item_id", oinvestigation_test.test_item_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_cancelation", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int investigationcancel(InvestigationTest oinvestigation_test)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@investigationtestID", oinvestigation_test.investigation_test_id);
                arParams[1] = new SqlParameter("@record_modified_by", oinvestigation_test.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigationcancel", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CancelTest(InvestigationTest investigationTest)
        {

            SqlParameter[] arParams = new SqlParameter[5];
            try
            {
                arParams[0] = new SqlParameter("@test_department_id", investigationTest.test_department_id);
                arParams[1] = new SqlParameter("@investigation_id", investigationTest.investigation_id);
                arParams[2] = new SqlParameter("@charge", investigationTest.charge);
                arParams[3] = new SqlParameter("@vat", investigationTest.vat);
                arParams[4] = new SqlParameter("@record_modified_by", investigationTest.record_modified_by);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "InvestigationCancelOutdoor", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SetInvestigationReportDone(List<InvestigationTest> lstInvestigationTest)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlTransaction trans = conn.BeginTransaction();
            
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                foreach (InvestigationTest element in lstInvestigationTest)
                {
                    arParams[0] = new SqlParameter("@investigation_test_id", element.investigation_test_id);
                    SqlHelper.ExecuteNonQuery(trans,CommandType.StoredProcedure, "SetInvestigationReportDone", arParams);
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }



        public int SetInvestigationDelivered(int investTestID)
        {

            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@investigation_test_id", investTestID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SetInvestigationDelivered", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Removeinvestigation_test(InvestigationTest oinvestigation_test)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_test_id", oinvestigation_test.investigation_test_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_testDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_test(int investigation_test_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@investigation_test_id", investigation_test_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "investigation_testDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
