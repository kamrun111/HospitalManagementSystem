using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{

    public class PayBLL
    {
        private PayDal _payDal;

        public PayDal payDal
        {
            get { return _payDal; }
            set { _payDal = value; }
        }

        public PayBLL()
        {
            payDal = new PayDal();
        }
        public DataSet PaymentType()
        {
            try
            {
                return payDal.PaymentType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Paymentinfo()
        {
            try
            {
                return payDal.Paymentinfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet PatientlistforPayment(string HospitalId)
        {
            try
            {
                return payDal.PatientlistforPayment(HospitalId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet DuepaymentAmount(int AdmissionID)
        {
            try
            {
                return payDal.DuepaymentAmount(AdmissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet PaymentTypeStatus(int PaymentTypeID)
        {
            try
            {
                return payDal.PaymentTypeStatus(PaymentTypeID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int paymentAdd(Pay opay)
        {
            try
            {
                return payDal.paymentAdd(opay);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
