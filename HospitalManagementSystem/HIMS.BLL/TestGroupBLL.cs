using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class TestGroupBLL
	{
		private TestGroupDAL _test_groupDAL;

		public TestGroupDAL test_groupDAL
		{
			get { return _test_groupDAL; }
			set { _test_groupDAL = value; }
		}

		public TestGroupBLL()
		{
			test_groupDAL = new TestGroupDAL();
		}
		public List<TestGroup> Gettest_groupsList()
		{
			try
			{
				return test_groupDAL.Gettest_groupsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Gettest_groups()
		{
			try
			{
				return test_groupDAL.Gettest_groups();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet gettestdepartment()
        {
            try
            {
                return test_groupDAL.gettestdepartment();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetTestGroupsByTestDeptID(int testGroupID)
        {
            try
            {
                return test_groupDAL.GetTestGroupsByTestDeptID(testGroupID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TestGroup Gettest_group(int test_group_id)
		{
			try
			{
				return test_groupDAL.Gettest_group(test_group_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addtest_group(TestGroup otest_group)
		{
			try
			{
				return test_groupDAL.Addtest_group(otest_group);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatetest_group(TestGroup otest_group)
		{
			try
			{
				return test_groupDAL.Updatetest_group(otest_group);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet testelementget(int testitemID)//sami 27 Oct
        {
            try
            {
                return test_groupDAL.testelementget(testitemID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int Removetest_group(TestGroup otest_group)
		{
			try
			{
				return test_groupDAL.Removetest_group(otest_group);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_group(int test_group_id)
		{
			try
			{
				return test_groupDAL.Removetest_group(test_group_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<TestGroup> Deserializetest_groups(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<TestGroup>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializetest_groups(string Path, List<TestGroup> test_groups)
		{
			try
			{
                GenericXmlSerializer<List<TestGroup>>.Serialize(test_groups, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
