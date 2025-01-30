using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class DoctorsPaymentDetailsBLL
    {
        private DoctorsPaymentDetailsDAL _doctorsPaymentDetailsDAL;

        public DoctorsPaymentDetailsDAL doctorsPaymentDetailsDAL
		{
            get { return _doctorsPaymentDetailsDAL; }
            set { _doctorsPaymentDetailsDAL = value; }
		}

        public DoctorsPaymentDetailsBLL()
		{
            doctorsPaymentDetailsDAL = new DoctorsPaymentDetailsDAL();
		}

        public DataSet getdoctorpaymentbill(int paymentID)//sami 27 Oct
        {
            try
            {
                return doctorsPaymentDetailsDAL.getdoctorpaymentbill(paymentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int doctorsBillpayment(DoctorsPayment doctorsPayment, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)
        {
            try
            {
                return doctorsPaymentDetailsDAL.doctorsBillpayment(doctorsPayment, listDoctorsPaymentDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
