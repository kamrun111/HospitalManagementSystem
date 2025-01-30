using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class OPD_patient_medicine_orderBLL
    {
        private OPD_patient_medicine_orderDAL  _oPD_patient_medicine_orderDAL;

        public OPD_patient_medicine_orderDAL oPD_patient_medicine_orderDAL
		{
			get { return _oPD_patient_medicine_orderDAL; }
			set { _oPD_patient_medicine_orderDAL = value; }
		}

        public OPD_patient_medicine_orderBLL()
		{
            oPD_patient_medicine_orderDAL = new OPD_patient_medicine_orderDAL();
		}

        public int OPDmedicineIndent(OPD_patient_medicine_order OPDpatientMedicineIndentOrder, List<OPDpatientMedicineIndent> lstOPDpatientMedicineIndent)
        {
            try
            {
                return oPD_patient_medicine_orderDAL.OPDmedicineIndent(OPDpatientMedicineIndentOrder, lstOPDpatientMedicineIndent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int opdmedicinereceive(OPD_patient_medicine_order opd_patient_medicine_order)
        {
            try
            {
                return oPD_patient_medicine_orderDAL.opdmedicinereceive(opd_patient_medicine_order);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
