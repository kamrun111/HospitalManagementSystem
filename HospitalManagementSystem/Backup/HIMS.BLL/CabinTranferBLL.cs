using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class CabinTranferBLL
	{
		private CabinTranferDAL _cabin_tranferDAL;

		public CabinTranferDAL cabin_tranferDAL
		{
			get { return _cabin_tranferDAL; }
			set { _cabin_tranferDAL = value; }
		}

		public CabinTranferBLL()
		{
			cabin_tranferDAL = new CabinTranferDAL();
		}
		public List<CabinTranfer> Getcabin_tranfersList()
		{
			try
			{
				return cabin_tranferDAL.Getcabin_tranfersList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}



        public DataSet GetCabinTransferPopulationInfo(int patient_code, string cabin)
		{
			try
			{
                return cabin_tranferDAL.GetCabinTransferPopulationInfo(patient_code, cabin);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetNonOccupiedCabinInfo()
		{
			try
			{
                return cabin_tranferDAL.GetNonOccupiedCabinInfo();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet Getcabin_tranfers()
		{
			try
			{
				return cabin_tranferDAL.Getcabin_tranfers();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public CabinTranfer Getcabin_tranfer(int cabin_tranfer_id)
		{
			try
			{
				return cabin_tranferDAL.Getcabin_tranfer(cabin_tranfer_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addcabin_tranfer(CabinTranfer ocabin_tranfer)
		{
			try
			{
				return cabin_tranferDAL.Addcabin_tranfer(ocabin_tranfer);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecabin_tranfer(CabinTranfer ocabin_tranfer)
		{
			try
			{
				return cabin_tranferDAL.Updatecabin_tranfer(ocabin_tranfer);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_tranfer(CabinTranfer ocabin_tranfer)
		{
			try
			{
				return cabin_tranferDAL.Removecabin_tranfer(ocabin_tranfer);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_tranfer(int cabin_tranfer_id)
		{
			try
			{
				return cabin_tranferDAL.Removecabin_tranfer(cabin_tranfer_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<CabinTranfer> Deserializecabin_tranfers(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<CabinTranfer>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializecabin_tranfers(string Path, List<CabinTranfer> cabin_tranfers)
		{
			try
			{
				GenericXmlSerializer<List<CabinTranfer>>.Serialize(cabin_tranfers, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
