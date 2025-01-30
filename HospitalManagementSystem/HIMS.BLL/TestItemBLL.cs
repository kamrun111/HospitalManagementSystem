using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class TestItemBLL
	{
		private TestItemDAL _test_itemDAL;

		public TestItemDAL test_itemDAL
		{
			get { return _test_itemDAL; }
			set { _test_itemDAL = value; }
		}

		public TestItemBLL()
		{
			test_itemDAL = new TestItemDAL();
		}
		public List<TestItem> Gettest_itemsList()
		{
			try
			{
				return test_itemDAL.Gettest_itemsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
        
        public DataSet GetTestItemByTestGrpID(int testGrpID)
		{
			try
			{
				return test_itemDAL.GetTestItemByTestGrpID(testGrpID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        
        
        public DataSet Gettest_items()
		{
			try
			{
				return test_itemDAL.Gettest_items();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet testItemsList(int departmentID)//khuku
        {
            try
            {
                return test_itemDAL.testItemsList(departmentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet testlist(int departmentID, int GroupID)//khuku
        {
            try
            {
                return test_itemDAL.testlist(departmentID, GroupID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 
        public DataSet Testitemsget()
        {
            try
            {
                return test_itemDAL.Testitemsget();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public TestItem Gettest_item(int test_item_id)
		{
			try
			{
				return test_itemDAL.Gettest_item(test_item_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addtest_item(TestItem otest_item)
		{
			try
			{
				return test_itemDAL.Addtest_item(otest_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int TestitemAdd(TestItem otest_item)
        {
            try
            {
                return test_itemDAL.TestitemAdd(otest_item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updatetest_item(TestItem otest_item)
		{
			try
			{
				return test_itemDAL.Updatetest_item(otest_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_item(TestItem otest_item)
		{
			try
			{
				return test_itemDAL.Removetest_item(otest_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetest_item(int test_item_id)
		{
			try
			{
				return test_itemDAL.Removetest_item(test_item_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<TestItem> Deserializetest_items(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<TestItem>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializetest_items(string Path, List<TestItem> test_items)
		{
			try
			{
				GenericXmlSerializer<List<TestItem>>.Serialize(test_items, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
