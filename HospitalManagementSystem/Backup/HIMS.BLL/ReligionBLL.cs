using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReligionBLL
	{
		private ReligionDAL _religionDAL;

		public ReligionDAL religionDAL
		{
			get { return _religionDAL; }
			set { _religionDAL = value; }
		}

		public ReligionBLL()
		{
			religionDAL = new ReligionDAL();
		}
		public List<Religion> GetreligionsList()
		{
			try
			{
				return religionDAL.GetreligionsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getreligions()
		{
			try
			{
				return religionDAL.Getreligions();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Religion Getreligion(int religion_id)
		{
			try
			{
				return religionDAL.Getreligion(religion_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addreligion(Religion oreligion)
		{
			try
			{
				return religionDAL.Addreligion(oreligion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatereligion(Religion oreligion)
		{
			try
			{
				return religionDAL.Updatereligion(oreligion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereligion(Religion oreligion)
		{
			try
			{
				return religionDAL.Removereligion(oreligion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereligion(int religion_id)
		{
			try
			{
				return religionDAL.Removereligion(religion_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Religion> Deserializereligions(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Religion>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializereligions(string Path, List<Religion> religions)
		{
			try
			{
				GenericXmlSerializer<List<Religion>>.Serialize(religions, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
