using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InvestigationBLL
	{
		private InvestigationDAL _investigationDAL;

		public InvestigationDAL investigationDAL
		{
			get { return _investigationDAL; }
			set { _investigationDAL = value; }
		}

		public InvestigationBLL()
		{
			investigationDAL = new InvestigationDAL();
		}
		public List<InvestigationBO> GetinvestigationsList()
		{
			try
			{
				return investigationDAL.GetinvestigationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
        public DataSet GetInvestigationPopulationInfo()
		{
			try
			{
                return investigationDAL.GetInvestigationPopulationInfo();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetIPDInvestigationPopulationInfo()
        {
            try
            {
                return investigationDAL.GetIPDInvestigationPopulationInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetIPDInvestigationPopulationInfoMember()
        {
            try
            {
                return investigationDAL.GetIPDInvestigationPopulationInfoMember();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet getdocInfo()
        {
            try
            {
                return investigationDAL.getdocInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet InvestigationList(DateTime From, DateTime To)
        {
            try
            {
                return investigationDAL.InvestigationList(From, To);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public DataSet spSearch(int testID)
        {
            try
            {
                return investigationDAL.spSearch(testID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet InvestigationSearch(int patientID)
        {
            try
            {
                return investigationDAL.InvestigationSearch(patientID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetTestElement(int investigation_testID)
		{
			try
			{
                return investigationDAL.GetTestElement(investigation_testID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet GetTestElement2(int TestItemID)
        {
            try
            {
                return investigationDAL.GetTestElement2(TestItemID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Getinvestigations()
        {
            try
            {
                return investigationDAL.Getinvestigations();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public InvestigationBO Getinvestigation(int investigation_id)
		{
			try
			{
				return investigationDAL.Getinvestigation(investigation_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addinvestigation(InvestigationBO oinvestigation)
		{
			try
			{
				return investigationDAL.Addinvestigation(oinvestigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int Addinvestigations(Patient patient, InvestigationBO investigation)
		{
			try
			{
                return investigationDAL.Addinvestigations(patient, investigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Investigationsupdate(Patient patient, InvestigationBO investigation)
        {
            try
            {
                return investigationDAL.Investigationsupdate(patient, investigation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public DataSet getdoctorspercentage(int docID, DateTime date1, DateTime date2)
        //{
        //    try
        //    {
        //        return investigationDAL.getdoctorspercentage(docID,date1, date2);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

		public int Updateinvestigation(InvestigationBO oinvestigation)
		{
			try
			{
				return investigationDAL.Updateinvestigation(oinvestigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public DataSet getdoctorspercentage(int docID, DateTime date1, DateTime date2)
        {
            try
            {
                return investigationDAL.getdoctorspercentage(docID,date1, date2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Removeinvestigation(InvestigationBO oinvestigation)
		{
			try
			{
				return investigationDAL.Removeinvestigation(oinvestigation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation(int investigation_id)
		{
			try
			{
				return investigationDAL.Removeinvestigation(investigation_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<InvestigationBO> Deserializeinvestigations(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<InvestigationBO>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeinvestigations(string Path, List<InvestigationBO> investigations)
		{
			try
			{
				GenericXmlSerializer<List<InvestigationBO>>.Serialize(investigations, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
