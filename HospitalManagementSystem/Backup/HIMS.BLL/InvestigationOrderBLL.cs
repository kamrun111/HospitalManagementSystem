using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InvestigationOrderBLL
	{
        private InvestigationOrderDAL _investigationOrderDAL;

        public InvestigationOrderDAL investigationOrderDAL
		{
            get { return _investigationOrderDAL; }
            set { _investigationOrderDAL = value; }
		}

        public InvestigationOrderBLL()
		{
            investigationOrderDAL = new InvestigationOrderDAL();
		}
        public int investigation_orderAdd(InvestigationOrder oinvestigationOrder, string DeptId)
        {
            try
            {
                return investigationOrderDAL.investigation_orderAdd(oinvestigationOrder, DeptId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OrdernoGet(int InvestigationID)
        {
            try
            {
                return investigationOrderDAL.OrdernoGet(InvestigationID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
