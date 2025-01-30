using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PatientMedicineIndentBLL
	{
		private PatientMedicineIndentDAL _patient_medicine_indentDAL;

		public PatientMedicineIndentDAL patient_medicine_indentDAL
		{
			get { return _patient_medicine_indentDAL; }
			set { _patient_medicine_indentDAL = value; }
		}

		public PatientMedicineIndentBLL()
		{
			patient_medicine_indentDAL = new PatientMedicineIndentDAL();
		}
		public List<PatientMedicineIndent> Getpatient_medicine_indentsList()
		{
			try
			{
				return patient_medicine_indentDAL.Getpatient_medicine_indentsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpatient_medicine_indents()
		{
			try
			{
				return patient_medicine_indentDAL.Getpatient_medicine_indents();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetMedicineReceive(int admnID)
        {
            try
            {
                return patient_medicine_indentDAL.GetMedicineReceive(admnID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OrderListforReceive(int admnID)
        {
            try
            {
                return patient_medicine_indentDAL.OrderListforReceive(admnID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ReceiveDetailforNurse(int OrderID)
        {
            try
            {
                return patient_medicine_indentDAL.ReceiveDetailforNurse(OrderID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int medicineNursereceive(List<PatientMedicineIndent> lstpatient_medicine_indent)
        {
            try
            {
                return patient_medicine_indentDAL.medicineNursereceive(lstpatient_medicine_indent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet PatientMedicineIndentPopulate(int admnID)
		{
			try
			{
				return patient_medicine_indentDAL.PatientMedicineIndentPopulate( admnID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet PatientOtherItemIndentPopulate(int admnID, int cabinID)
        {
            try
            {
                return patient_medicine_indentDAL.PatientOtherItemIndentPopulate(admnID, cabinID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public PatientMedicineIndent Getpatient_medicine_indent(int patient_medicine_indent_id)
		{
			try
			{
				return patient_medicine_indentDAL.Getpatient_medicine_indent(patient_medicine_indent_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addpatient_medicine_indent(PatientMedicineIndent opatient_medicine_indent)
		{
			try
			{
				return patient_medicine_indentDAL.Addpatient_medicine_indent(opatient_medicine_indent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet OtherItemsLoad(int admnID, int cabinID)
        {
            try
            {
                return patient_medicine_indentDAL.OtherItemsLoad(admnID, cabinID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddotheritemPatientMedicineIndent(List<PatientMedicineIndent> lstPatientMedicineIndent)//sami
        {
            try
            {
                return patient_medicine_indentDAL.AddotheritemPatientMedicineIndent(lstPatientMedicineIndent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int AddPatientMedicineIndent(List<PatientMedicineIndent> lstPatientMedicineIndent)//sami
		{
			try
			{
                return patient_medicine_indentDAL.AddPatientMedicineIndent(lstPatientMedicineIndent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int patient_medicine_indentUpdateList(List<PatientMedicineIndent> patientMedicineIndentUP)//sami
        {
            try
            {
                return patient_medicine_indentDAL.patient_medicine_indentUpdateList(patientMedicineIndentUP);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int patient_medicine_indentUpdateReceiveList(List<PatientMedicineIndent> patientMedicineIndentUPRec)//sami
        {
            try
            {
                return patient_medicine_indentDAL.patient_medicine_indentUpdateReceiveList(patientMedicineIndentUPRec);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Updatepatient_medicine_indent(PatientMedicineIndent opatient_medicine_indent)
        {
            try
            {
                return patient_medicine_indentDAL.Updatepatient_medicine_indent(opatient_medicine_indent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removepatient_medicine_indent(PatientMedicineIndent opatient_medicine_indent)
		{
			try
			{
				return patient_medicine_indentDAL.Removepatient_medicine_indent(opatient_medicine_indent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removepatient_medicine_indent(int patient_medicine_indent_id)
		{
			try
			{
				return patient_medicine_indentDAL.Removepatient_medicine_indent(patient_medicine_indent_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<PatientMedicineIndent> Deserializepatient_medicine_indents(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<PatientMedicineIndent>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializepatient_medicine_indents(string Path, List<PatientMedicineIndent> patient_medicine_indents)
		{
			try
			{
				GenericXmlSerializer<List<PatientMedicineIndent>>.Serialize(patient_medicine_indents, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
