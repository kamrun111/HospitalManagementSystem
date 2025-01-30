using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PrescriptionBLL
	{
		private PrescriptionDAL _prescriptionDAL;

		public PrescriptionDAL prescriptionDAL
		{
			get { return _prescriptionDAL; }
			set { _prescriptionDAL = value; }
		}

		public PrescriptionBLL()
		{
			prescriptionDAL = new PrescriptionDAL();
		}
		public List<Prescription> GetprescriptionsList()
		{
			try
			{
				return prescriptionDAL.GetprescriptionsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getprescriptions()
		{
			try
			{
				return prescriptionDAL.Getprescriptions();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetPresIdByAdmbID(int admnID)
		{
			try
			{
                return prescriptionDAL.GetPresIdByAdmbID(admnID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Prescription Getprescription(int prescription_id)
		{
			try
			{
				return prescriptionDAL.Getprescription(prescription_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addprescription(Prescription oprescription)
		{
			try
			{
				return prescriptionDAL.Addprescription(oprescription);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int AdjustdoctorVisit(Prescription oprescription)
        {
            try
            {
                return prescriptionDAL.AdjustdoctorVisit(oprescription);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updateprescription(Prescription oprescription)
		{
			try
			{
				return prescriptionDAL.Updateprescription(oprescription);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeprescription(Prescription oprescription)
		{
			try
			{
				return prescriptionDAL.Removeprescription(oprescription);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeprescription(int prescription_id)
		{
			try
			{
				return prescriptionDAL.Removeprescription(prescription_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Prescription> Deserializeprescriptions(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Prescription>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeprescriptions(string Path, List<Prescription> prescriptions)
		{
			try
			{
				GenericXmlSerializer<List<Prescription>>.Serialize(prescriptions, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
