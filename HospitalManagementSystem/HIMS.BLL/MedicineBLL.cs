using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class MedicineBLL
	{
		private MedicineDAL _medicineDAL;

		public MedicineDAL medicineDAL
		{
			get { return _medicineDAL; }
			set { _medicineDAL = value; }
		}

		public MedicineBLL()
		{
			medicineDAL = new MedicineDAL();
		}
		public List<Medicine> GetmedicinesList()
		{
			try
			{
				return medicineDAL.GetmedicinesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet Getmedicines(int product_category_id)
        {
            try
            {
                return medicineDAL.Getmedicines(product_category_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public DataSet GetmedicineType()
        //{
        //    try
        //    {
        //        return medicineDAL.Getmedicine_type();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public Medicine Getmedicine(int medicine_id)
		{
			try
			{
				return medicineDAL.Getmedicine(medicine_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addmedicine(Medicine omedicine)
		{
			try
			{
				return medicineDAL.Addmedicine(omedicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatemedicine(Medicine omedicine)
		{
			try
			{
				return medicineDAL.Updatemedicine(omedicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removemedicine(Medicine omedicine)
		{
			try
			{
				return medicineDAL.Removemedicine(omedicine);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removemedicine(int medicine_id)
		{
			try
			{
				return medicineDAL.Removemedicine(medicine_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<Medicine> Deserializemedicines(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<Medicine>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializemedicines(string Path, List<Medicine> medicines)
		{
			try
			{
                GenericXmlSerializer<List<Medicine>>.Serialize(medicines, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
