using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OtherItemReceiveBLL
    {
        private OtherItemReceiveDAL _otherItemReceiveDAL;

        public OtherItemReceiveDAL otherItemReceiveDAL
		{
            get { return _otherItemReceiveDAL; }
            set { _otherItemReceiveDAL = value; }
		}

        public OtherItemReceiveBLL()
		{
            otherItemReceiveDAL = new OtherItemReceiveDAL();
		}
        public DataSet OtherItemReceiveLoad()
        {
            try
            {
                return otherItemReceiveDAL.OtherItemReceiveLoad();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int OtherItemReceiveAdd(OtherItemReceive otherItemReceive, List<OtherItemReceiveDetails> listOtherItemReceiveDetails, List<OtherItem> listOtherItem)
        {
            try
            {
                return otherItemReceiveDAL.OtherItemReceiveAdd(otherItemReceive, listOtherItemReceiveDetails, listOtherItem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
