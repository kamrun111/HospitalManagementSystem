using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InvestigationBackBLL
	{
        private InvestagitionBackDAL _investagitionbackDAL;

        public InvestagitionBackDAL investagitionbackDAL
		{
            get { return _investagitionbackDAL; }
            set { _investagitionbackDAL = value; }
		}

        public InvestigationBackBLL()
		{
            investagitionbackDAL = new InvestagitionBackDAL();
		}
        public int investigationBackAdd(InvestigationBack oinvestagitionBack)
        {
            try
            {
                return investagitionbackDAL.investigationBackAdd(oinvestagitionBack);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet InvestigationListPopulate()
        {
            try
            {
                return investagitionbackDAL.InvestigationListPopulate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
