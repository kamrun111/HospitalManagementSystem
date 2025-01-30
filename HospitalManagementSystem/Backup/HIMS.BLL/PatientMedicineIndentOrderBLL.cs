using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientMedicineIndentOrderBLL
	{
        private PatientMedicineIndentOrderDAL _patient_medicine_indent_orderDAL;

        public PatientMedicineIndentOrderDAL patient_medicine_indent_orderDAL
		{
			get { return _patient_medicine_indent_orderDAL; }
			set { _patient_medicine_indent_orderDAL = value;}
		}

        public PatientMedicineIndentOrderBLL()
		{
            patient_medicine_indent_orderDAL = new PatientMedicineIndentOrderDAL();
		}
        public int MedicineIndent(PatientMedicineIndentOrder opatientMedicineIndentOrder, List<PatientMedicineIndent> lstPatientMedicineIndent)
        {
            try
            {
                return patient_medicine_indent_orderDAL.MedicineIndent(opatientMedicineIndentOrder, lstPatientMedicineIndent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OtMedicineIndent(OperationNote ooperation_note, PatientMedicineIndentOrder opatientMedicineIndentOrder, List<PatientMedicineIndent> lstpatientMedicineIndent)
        {
            try
            {
                return patient_medicine_indent_orderDAL.OtMedicineIndent(ooperation_note, opatientMedicineIndentOrder,lstpatientMedicineIndent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet dischargemedicinereceive()
        {
            try
            {
                return patient_medicine_indent_orderDAL.dischargemedicinereceive();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OTmedicineReceived()
        {
            try
            {
                return patient_medicine_indent_orderDAL.OTmedicineReceived();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
