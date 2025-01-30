using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class SpecialistInBLL
	{
		private SpecialistInDAL _specialist_inDAL;

		public SpecialistInDAL specialist_inDAL
		{
			get { return _specialist_inDAL; }
			set { _specialist_inDAL = value; }
		}

		public SpecialistInBLL()
		{
			specialist_inDAL = new SpecialistInDAL();
		}
		public List<SpecialistIn> Getspecialist_insList()
		{
			try
			{
				return specialist_inDAL.Getspecialist_insList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getspecialist_ins()
		{
			try
			{
				return specialist_inDAL.Getspecialist_ins();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public SpecialistIn Getspecialist_in(int specialist_in_id)
		{
			try
			{
				return specialist_inDAL.Getspecialist_in(specialist_in_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addspecialist_in(SpecialistIn ospecialist_in)
		{
			try
			{
				return specialist_inDAL.Addspecialist_in(ospecialist_in);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatespecialist_in(SpecialistIn ospecialist_in)
		{
			try
			{
				return specialist_inDAL.Updatespecialist_in(ospecialist_in);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removespecialist_in(SpecialistIn ospecialist_in)
		{
			try
			{
				return specialist_inDAL.Removespecialist_in(ospecialist_in);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removespecialist_in(int specialist_in_id)
		{
			try
			{
				return specialist_inDAL.Removespecialist_in(specialist_in_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<SpecialistIn> Deserializespecialist_ins(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<SpecialistIn>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializespecialist_ins(string Path, List<SpecialistIn> specialist_ins)
		{
			try
			{
				GenericXmlSerializer<List<SpecialistIn>>.Serialize(specialist_ins, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
