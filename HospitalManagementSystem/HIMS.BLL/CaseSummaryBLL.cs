using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class CaseSummaryBLL
    {
        private CaseSummaryDAL _caseSummaryDAL;

        public CaseSummaryDAL caseSummaryDAL
		{
            get { return _caseSummaryDAL; }
            set { _caseSummaryDAL = value; }
		}

        public CaseSummaryBLL()
		{
            caseSummaryDAL = new CaseSummaryDAL();
		}

        public int AddCaseSummary(CaseSummary caseSummary, AdmissionBO admission)
        {
            try
            {
                return caseSummaryDAL.AddCaseSummary(caseSummary, admission);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddCaseSummaryICU(CaseSummary caseSummary, AdmissionBO admission)
        {
            try
            {
                return caseSummaryDAL.AddCaseSummaryICU(caseSummary, admission);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CaseSummaryUpdate(CaseSummary caseSummary)
        {
            try
            {
                return caseSummaryDAL.CaseSummaryUpdate(caseSummary);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CaseSummaryUpdateICU(CaseSummary caseSummary)
        {
            try
            {
                return caseSummaryDAL.CaseSummaryUpdateICU(caseSummary);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
