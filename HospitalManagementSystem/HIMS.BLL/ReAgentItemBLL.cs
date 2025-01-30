using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReAgentItemBLL
	{
		private ReAgentItemDAL _ReAgentItemDAL;

		public ReAgentItemDAL ReAgentItemDAL
		{
            get { return _ReAgentItemDAL; }
            set { _ReAgentItemDAL = value; }
		}

        public ReAgentItemBLL()
		{
            ReAgentItemDAL = new ReAgentItemDAL();
		}

        public DataSet GetTestItem(int group_id)
        {
            try
            {
                return ReAgentItemDAL.GetTestItem(group_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetTestItemElement(int item_id)
        {
            try
            {
                return ReAgentItemDAL.GetTestItemElement(item_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ReagentCategory()
        {
            try
            {
                return ReAgentItemDAL.ReagentCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ReagentProduct(int category_id)
        {
            try
            {
                return ReAgentItemDAL.ReagentProduct(category_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ReagentProductinfo(int product_id)
        {
            try
            {
                return ReAgentItemDAL.ReagentProductinfo(product_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ReAgentItemAdd(List<ReAgentItem> lstReAgentItem, string test_item)
        {
            try
            {
                ReAgentItemDAL.ReAgentItemAdd(lstReAgentItem, test_item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetReAgents(string test_item)
        {
            try
            {
                return ReAgentItemDAL.GetReAgents(test_item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ReagentforTest(int test_itemID)
        {
            try
            {
                return ReAgentItemDAL.ReagentforTest(test_itemID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ReagentforInvestigationTest(int test_item_id)
        {
            try
            {
                return ReAgentItemDAL.ReagentforInvestigationTest(test_item_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
