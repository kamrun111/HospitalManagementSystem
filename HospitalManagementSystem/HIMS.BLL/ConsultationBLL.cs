using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BusinessObjects
{
    public class ConsultationBLL
    {
        private ConsultationDAL _consultationDAL;

        public ConsultationDAL consultationDAL
		{
            get { return _consultationDAL; }
            set { _consultationDAL = value; }
		}

        public ConsultationBLL()
		{
            consultationDAL = new ConsultationDAL();
		}

        public DataSet getconsultation(int patientID)
        {
            try
            {
                return consultationDAL.getconsultation(patientID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
