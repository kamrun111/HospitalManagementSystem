using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class DoctorsPaymentBLL
    {
        private DoctorsPaymentDAL _doctorsPaymentDAL;

        public DoctorsPaymentDAL doctorsPaymentDAL
		{
            get { return _doctorsPaymentDAL; }
            set { _doctorsPaymentDAL = value; }
		}

        public DoctorsPaymentBLL()
		{
            doctorsPaymentDAL = new DoctorsPaymentDAL();
		}
        public DataSet SearchPatient(int admissionCode)
        {
            try
            {
                return doctorsPaymentDAL.SearchPatient(admissionCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int doctorspaymentAdd(DoctorsPayment doctorsPayment, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)
        {
            try
            {
                return doctorsPaymentDAL.doctorspaymentAdd(doctorsPayment, listDoctorsPaymentDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int doctorpaymentUpdate(DoctorsPayment doctorsPayment, List<DoctorsPaymentDetails> listDoctorsPaymentDetails)
        {
            try
            {
                return doctorsPaymentDAL.doctorpaymentUpdate(doctorsPayment,listDoctorsPaymentDetails);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int doctorspaymentmodify(DoctorsPayment doctorsPayment)//this will be change
        {
            try
            {
                return doctorsPaymentDAL.doctorspaymentmodify(doctorsPayment);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
