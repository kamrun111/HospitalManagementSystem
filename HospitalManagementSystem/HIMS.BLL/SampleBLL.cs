using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class SampleBLL
	{
        private SampleDAL _sampleDAL;

        public SampleDAL sampleDAL
		{
            get { return _sampleDAL; }
            set { _sampleDAL = value; }
		}

        public SampleBLL()
		{
            sampleDAL = new SampleDAL();
		}
        public int sampleAdd(Sample osample, int SpecimenID)
        {
            try
            {
                return sampleDAL.sampleAdd(osample, SpecimenID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
