using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InvestigationTestBLL
	{
		private InvestigationTestDAL _investigation_testDAL;

		public InvestigationTestDAL investigation_testDAL
		{
			get { return _investigation_testDAL; }
			set { _investigation_testDAL = value; }
		}

		public InvestigationTestBLL()
		{
			investigation_testDAL = new InvestigationTestDAL();
		}
		public List<InvestigationTest> Getinvestigation_testsList()
		{
			try
			{
				return investigation_testDAL.Getinvestigation_testsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getinvestigation_tests()
		{
			try
			{
				return investigation_testDAL.Getinvestigation_tests();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetSampleCollectionInfo(string testDept,int value)
		{
			try
			{
                return investigation_testDAL.GetSampleCollectionInfo(testDept,value);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet TestInfoGet(string test_department, int ID,string Cabin,string Types,int SampleCollected)
        {
            try
            {
                return investigation_testDAL.TestInfoGet(test_department, ID, Cabin, Types, SampleCollected);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet InvestTestInfoByPIDForDelivery(int patientID)
		{
			try
			{
                return investigation_testDAL.InvestTestInfoByPIDForDelivery(patientID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetTestElementforDoc(int investigationID)
        {
            try
            {
                return investigation_testDAL.GetTestElementforDoc(investigationID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet  SampleCollectionInfoGetAll()
		{
			try
			{
                return investigation_testDAL. SampleCollectionInfoGetAll();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetInvestigationTestDeliveryInfo()
		{
			try
			{
                return investigation_testDAL.GetInvestigationTestDeliveryInfo();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public InvestigationTest Getinvestigation_test(int investigation_test_id)
		{
			try
			{
				return investigation_testDAL.Getinvestigation_test(investigation_test_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addinvestigation_test(InvestigationTest oinvestigation_test, int visitinvestigationID)
		{
			try
			{
                return investigation_testDAL.Addinvestigation_test(oinvestigation_test, visitinvestigationID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateinvestigation_test(InvestigationTest oinvestigation_test)
		{
			try
			{
				return investigation_testDAL.Updateinvestigation_test(oinvestigation_test);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int UpdateStickerPrint(InvestigationTest oinvestigation_test)
        {
            try
            {
                return investigation_testDAL.UpdateStickerPrint(oinvestigation_test);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int investigation_cancelation(InvestigationTest oinvestigation_test,int Cnl)
        {
            try
            {
                return investigation_testDAL.investigation_cancelation(oinvestigation_test, Cnl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet SearchTest(string testName)
        {
            try
            {
                return investigation_testDAL.SearchTest(testName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int investigationcancel(InvestigationTest oinvestigation_test)
        {
            try
            {
                return investigation_testDAL.investigationcancel(oinvestigation_test);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CancelTest(InvestigationTest investigationTest)
        {
            try
            {
                return investigation_testDAL.CancelTest(investigationTest);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Updateinvestigation_testAfterReportDone(InvestigationTest oinvestigation_test)
		{
			try
			{
                return investigation_testDAL.Updateinvestigation_testAfterReportDone(oinvestigation_test);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public void SetInvestigationReportDone(List<InvestigationTest> lstInvestigationTest)
		{
			try
			{
                investigation_testDAL.SetInvestigationReportDone(lstInvestigationTest);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int SetInvestigationDelivered(int investTestID)
		{
			try
			{
                return investigation_testDAL.SetInvestigationDelivered(investTestID);
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
				return investigation_testDAL.Removeinvestigation_test(oinvestigation_test);
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
				return investigation_testDAL.Removeinvestigation_test(investigation_test_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<InvestigationTest> Deserializeinvestigation_tests(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<InvestigationTest>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeinvestigation_tests(string Path, List<InvestigationTest> investigation_tests)
		{
			try
			{
				GenericXmlSerializer<List<InvestigationTest>>.Serialize(investigation_tests, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
