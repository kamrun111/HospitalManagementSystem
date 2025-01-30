using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class InvestigtionTubeBLL
    {
        private InvestigtionTubeDAL _investigtionTubeDAL;

        public InvestigtionTubeDAL investigtionTubeDAL
		{
            get { return _investigtionTubeDAL; }
            set { _investigtionTubeDAL = value; }
		}

        public InvestigtionTubeBLL()
		{
            investigtionTubeDAL = new InvestigtionTubeDAL();
		}
        public int InvestigationTubeAdd(InvestigtionTubeBO oInvestigtionTubeBO)
        {
            try
            {
                return investigtionTubeDAL.InvestigationTubeAdd(oInvestigtionTubeBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
