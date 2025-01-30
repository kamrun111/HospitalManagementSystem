using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class RegularCheckupBLL
	{
		private RegularCheckupDAL _regular_checkupDAL;

		public RegularCheckupDAL regular_checkupDAL
		{
			get { return _regular_checkupDAL; }
			set { _regular_checkupDAL = value; }
		}

		public RegularCheckupBLL()
		{
			regular_checkupDAL = new RegularCheckupDAL();
		}
		public List<RegularCheckup> Getregular_checkupsList()
		{
			try
			{
				return regular_checkupDAL.Getregular_checkupsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getregular_checkups()
		{
			try
			{
				return regular_checkupDAL.Getregular_checkups();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}




        public DataSet GetRegularCheckup(int admisionID)//samia 16 oct
        {
            try
            {
                return regular_checkupDAL.GetRegularCheckup(admisionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public RegularCheckup Getregular_checkup(int regular_checkup_id)
		{
			try
			{
				return regular_checkupDAL.Getregular_checkup(regular_checkup_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addregular_checkup(RegularCheckup oregular_checkup)
		{
			try
			{
				return regular_checkupDAL.Addregular_checkup(oregular_checkup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateregular_checkup(RegularCheckup oregular_checkup)
		{
			try
			{
				return regular_checkupDAL.Updateregular_checkup(oregular_checkup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeregular_checkup(RegularCheckup oregular_checkup)
		{
			try
			{
				return regular_checkupDAL.Removeregular_checkup(oregular_checkup);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeregular_checkup(int regular_checkup_id)
		{
			try
			{
				return regular_checkupDAL.Removeregular_checkup(regular_checkup_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}



        //public DataSet GetRegularCheckup(int admisionID)
        //{
        //    try
        //    {
        //        return regular_checkupDAL.GetRegularCheckup(admisionID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
		public List<RegularCheckup> Deserializeregular_checkups(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<RegularCheckup>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeregular_checkups(string Path, List<RegularCheckup> regular_checkups)
		{
			try
			{
				GenericXmlSerializer<List<RegularCheckup>>.Serialize(regular_checkups, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
