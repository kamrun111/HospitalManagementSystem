using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class PreOperativeCheckListBLL
    {
        private PreOperativeCheckListDAL _preOperativeCheckListDAL;
        public PreOperativeCheckListDAL preOperativeCheckListDAL
        {
            get { return _preOperativeCheckListDAL; }
            set { _preOperativeCheckListDAL = value; }
        }

        public PreOperativeCheckListBLL()
        {
            preOperativeCheckListDAL = new PreOperativeCheckListDAL();
        }

        public int PreOperativeCheckListAdd(PreOperativeCheckListBO preOperativeCheckListBO, List<PreOperativeCheckListDetailsBO> listPreOperativeCheckListDetailsBO)
        {
            try
            {
                return preOperativeCheckListDAL.PreOperativeCheckListInsert(preOperativeCheckListBO, listPreOperativeCheckListDetailsBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
