using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class VisitMedicineBLL
	{
		private VisitMedicineDAL _visit_medicineDAL;

		public VisitMedicineDAL visit_medicineDAL
		{
			get { return _visit_medicineDAL; }
			set { _visit_medicineDAL = value; }
		}

		public VisitMedicineBLL()
		{
			visit_medicineDAL = new VisitMedicineDAL();
		}
		public List<VisitMedicine> Getvisit_medicinesList()
		{
			try
			{
				return visit_medicineDAL.Getvisit_medicinesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getvisit_medicines()
		{
			try
			{
				return visit_medicineDAL.Getvisit_medicines();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetMedicineIndentInfo(int presID)
        {
            try
            {
                return visit_medicineDAL.GetMedicineIndentInfo(presID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet MedicineDetailsForDoctor(int VisitMedicineID)
        {
            try
            {
                return visit_medicineDAL.MedicineDetailsForDoctor(VisitMedicineID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetNewlyPrescribedFloor()
        {
            try
            {
                return visit_medicineDAL.GetNewlyPrescribedFloor();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public VisitMedicine Getvisit_medicine(int visit_medicine_id)
		{
			try
			{
				return visit_medicineDAL.Getvisit_medicine(visit_medicine_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addvisit_medicine(VisitMedicine ovisit_medicine)
		{
			try
			{
				return visit_medicineDAL.Addvisit_medicine(ovisit_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int visit_premedicineAdd(VisitMedicine ovisit_medicine)
        {
            try
            {
                return visit_medicineDAL.visit_premedicineAdd(ovisit_medicine);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updatevisit_medicine(VisitMedicine ovisit_medicine)
		{
			try
			{
				return visit_medicineDAL.Updatevisit_medicine(ovisit_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int Updatevisit_medicineAfterSubmit(VisitMedicine ovisit_medicine)
		{
			try
			{
                return visit_medicineDAL.Updatevisit_medicineAfterSubmit(ovisit_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int SetMedicineIsContinue(VisitMedicine ovisit_medicine)
		{
			try
			{
                return visit_medicineDAL.SetMedicineIsContinue(ovisit_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_medicine(VisitMedicine ovisit_medicine)
		{
			try
			{
				return visit_medicineDAL.Removevisit_medicine(ovisit_medicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_medicine(int visit_medicine_id)
		{
			try
			{
				return visit_medicineDAL.Removevisit_medicine(visit_medicine_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<VisitMedicine> Deserializevisit_medicines(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<VisitMedicine>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializevisit_medicines(string Path, List<VisitMedicine> visit_medicines)
		{
			try
			{
				GenericXmlSerializer<List<VisitMedicine>>.Serialize(visit_medicines, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
