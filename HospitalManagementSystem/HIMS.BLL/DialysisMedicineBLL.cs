using System;
using System.Collections.Generic;
using System.Text;
using HIMS.DAL;
using HIMS.BusinessObjects;


namespace HIMS.BLL
{
    public class DialysisMedicineBLL
    {
        private DialysisMedicineDAL _dialysisMedicineDAL;

        public DialysisMedicineDAL dialysisMedicineDAL
		{
            get { return _dialysisMedicineDAL; }
            set { _dialysisMedicineDAL = value; }
		}

        public DialysisMedicineBLL()
		{
            dialysisMedicineDAL = new DialysisMedicineDAL();
		}

        public int AddDialysisMedicine(DialysisMedicineBO dialysisMedicineBO)
		{
			try
			{
                return dialysisMedicineDAL.AddDialysisMedicine(dialysisMedicineBO);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int UpdateDialysisMedicine(DialysisMedicineBO dialysisMedicineBO)
        {
            try
            {
                return dialysisMedicineDAL.UpdateDialysisMedicine(dialysisMedicineBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
