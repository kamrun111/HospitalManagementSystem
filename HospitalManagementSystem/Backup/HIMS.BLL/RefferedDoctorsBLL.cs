using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class RefferedDoctorsBLL
	{
		private RefferedDoctorsDAL _reffered_doctorsDAL;

		public RefferedDoctorsDAL reffered_doctorsDAL
		{
			get { return _reffered_doctorsDAL; }
			set { _reffered_doctorsDAL = value; }
		}

		public RefferedDoctorsBLL()
		{
			reffered_doctorsDAL = new RefferedDoctorsDAL();
		}
        public List<RefferedDoctors> Getreffered_doctorssList()
		{
			try
			{
				return reffered_doctorsDAL.Getreffered_doctorssList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
        }//GetConsultantAll
		public DataSet Getreffered_doctorss()
		{
			try
			{
				return reffered_doctorsDAL.Getreffered_doctorss();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetConsultantAll()
        {
            try
            {
                return reffered_doctorsDAL.GetConsultantAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getconsultant(int specialistInID)
        {
            try
            {
                return reffered_doctorsDAL.getconsultant(specialistInID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet GetSConsultants(int specialistInID)
        {
            try
            {
                return reffered_doctorsDAL.GetSConsultants(specialistInID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet GetOutdoorConsultantPatient(int RefferedDoctorsID)
        {
            try
            {
                return reffered_doctorsDAL.GetOutdoorConsultantPatient(RefferedDoctorsID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetVisitRoom(int refferedDoctorsID)
        {
            try
            {
                return reffered_doctorsDAL.GetVisitRoom(refferedDoctorsID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataSet GetConsultantListInfo(int refferedDocID)
		{
			try
			{
                return reffered_doctorsDAL.GetConsultantListInfo(refferedDocID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public RefferedDoctors Getreffered_doctors(int reffered_doctors_id)
        {
            try
            {
                return reffered_doctorsDAL.Getreffered_doctors(reffered_doctors_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Addreffered_doctors(RefferedDoctors oreffered_doctors)
		{
			try
			{
				return reffered_doctorsDAL.Addreffered_doctors(oreffered_doctors);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatereffered_doctors(RefferedDoctors oreffered_doctors)
		{
			try
			{
				return reffered_doctorsDAL.Updatereffered_doctors(oreffered_doctors);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removereffered_doctors(RefferedDoctors oreffered_doctors)
		{
			try
			{
				return reffered_doctorsDAL.Removereffered_doctors(oreffered_doctors);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereffered_doctors(int reffered_doctors_id)
		{
			try
			{
				return reffered_doctorsDAL.Removereffered_doctors(reffered_doctors_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<RefferedDoctors> Deserializereffered_doctorss(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<RefferedDoctors>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializereffered_doctorss(string Path, List<RefferedDoctors> reffered_doctorss)
		{
			try
			{
                GenericXmlSerializer<List<RefferedDoctors>>.Serialize(reffered_doctorss, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
