using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OPDPayTableBLL
	{
        private OPDPayTableDAL _oPDPayTableDAL;

        public OPDPayTableDAL oPDPayTableDAL
		{
            get { return _oPDPayTableDAL; }
            set { _oPDPayTableDAL = value; }
		}

        public OPDPayTableBLL()
		{
            oPDPayTableDAL = new OPDPayTableDAL();
		}
        public int AddOPDPayTable(OPDPayTable  oPDPayTable)
        {
            try
            {
                return oPDPayTableDAL.AddOPDPayTable(oPDPayTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            }
		
	}
}
