using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OPDotherItemBLL
    {
        private OPDotheritemDAL _opdOtheritemDAL;

        public OPDotheritemDAL opdOtheritemDAL
		{
            get { return _opdOtheritemDAL; }
            set { _opdOtheritemDAL = value; }
		}

        public OPDotherItemBLL()
		{
            opdOtheritemDAL = new OPDotheritemDAL();
		}

        public DataSet getopdOtherservices(int pkid)
        {
            try
            {
                return opdOtheritemDAL.getopdOtherservices(pkid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int otheritemadd(OPDotheritem otheritem)
        {
            try
            {
                return opdOtheritemDAL.otheritemadd(otheritem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
