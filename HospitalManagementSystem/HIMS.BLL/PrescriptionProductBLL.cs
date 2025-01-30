using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PrescriptionProductBLL
	{
        private PrescriptionProductDAL _prescriptionproductDAL;

        public PrescriptionProductDAL prescriptionproductDAL
		{
            get { return _prescriptionproductDAL; }
            set { _prescriptionproductDAL = value; }
		}

        public PrescriptionProductBLL()
		{
            prescriptionproductDAL = new PrescriptionProductDAL();
		}
        public int newprescriptionproductAdd(PriscriptionProduct oproduct)
        {
            try
            {
                return prescriptionproductDAL.newprescriptionproductAdd(oproduct);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
