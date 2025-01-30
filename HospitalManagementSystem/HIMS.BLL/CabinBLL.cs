using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class CabinBLL
	{
		private CabinDAL _cabinDAL;

		public CabinDAL cabinDAL
		{
			get { return _cabinDAL; }
			set { _cabinDAL = value; }
		}

		public CabinBLL()
		{
			cabinDAL = new CabinDAL();
		}
		public List<Cabin> GetcabinsList()
		{
			try
			{
				return cabinDAL.GetcabinsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getcabins()
		{
			try
			{
				return cabinDAL.Getcabins();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Cabin Getcabin(int cabin_id)
		{
			try
			{
				return cabinDAL.Getcabin(cabin_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addcabin(Cabin ocabin)
		{
			try
			{
				return cabinDAL.Addcabin(ocabin);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateForCabinTransfere(Cabin ocabin, AdmissionBO oadmission)
        {
            try
            {
                return cabinDAL.UpdateForCabinTransfere(ocabin, oadmission);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateForCabinTransfereICU(Cabin ocabin, AdmissionBO oadmission)
        {
            try
            {
                return cabinDAL.UpdateForCabinTransfereICU(ocabin, oadmission);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Updatecabin(Cabin ocabin)
		{
			try
			{
				return cabinDAL.Updatecabin(ocabin);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin(Cabin ocabin)
		{
			try
			{
				return cabinDAL.Removecabin(ocabin);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin(int cabin_id)
		{
			try
			{
				return cabinDAL.Removecabin(cabin_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Cabin> Deserializecabins(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Cabin>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializecabins(string Path, List<Cabin> cabins)
		{
			try
			{
				GenericXmlSerializer<List<Cabin>>.Serialize(cabins, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
