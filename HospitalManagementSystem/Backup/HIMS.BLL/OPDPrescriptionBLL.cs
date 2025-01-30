using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OPDPrescriptionBLL
	{
		private OPDPrescriptionDAL _oPDPrescriptionDAL;

		public OPDPrescriptionDAL oPDPrescriptionDAL
		{
			get { return _oPDPrescriptionDAL; }
			set { _oPDPrescriptionDAL = value; }
		}

        public OPDPrescriptionBLL()
		{
            oPDPrescriptionDAL = new OPDPrescriptionDAL();
		}
		public int AddOPDMedication(OPDMedication  oPDMedication)
        {
            try
            {
                return oPDPrescriptionDAL.AddOPDMedication(oPDMedication);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddOPDPrescription(OPDPrescription oPDPrescription)
        {
            try
            {
                return oPDPrescriptionDAL.AddOPDPrescription(oPDPrescription);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddOPDAdvice(OPDAdvice oPDAdvice)
        {
            try
            {
                return oPDPrescriptionDAL.AddOPDAdvice(oPDAdvice);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddOPDOTTreatmentProcedure(OPDOTTreatmentProcedure oPDOTTreatmentProcedure)
        {
            try
            {
                return oPDPrescriptionDAL.AddOPDOTTreatmentProcedure(oPDOTTreatmentProcedure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet treatment_procedureGetAll()
        {
            try
            {
                return oPDPrescriptionDAL.treatment_procedureGetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOPDPrescriptionInfo(int PrescriptionID)
        {
            try
            {

                return oPDPrescriptionDAL.GetOPDPrescriptionInfo(PrescriptionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteOPDAdvice(int PrescriptionID)
        {
            try
            {
                return oPDPrescriptionDAL.DeleteOPDAdvice(PrescriptionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteOPDMedication(int PrescriptionID)
        {
            try
            {
                return oPDPrescriptionDAL.DeleteOPDMedication(PrescriptionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }



}
