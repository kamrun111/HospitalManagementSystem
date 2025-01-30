using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class NationalityBLL
	{
		private NationalityDAL _nationalityDAL;

		public NationalityDAL nationalityDAL
		{
			get { return _nationalityDAL; }
			set { _nationalityDAL = value; }
		}

		public NationalityBLL()
		{
			nationalityDAL = new NationalityDAL();
		}
		public List<Nationality> GetnationalitysList()
		{
			try
			{
				return nationalityDAL.GetnationalitysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getnationalitys()
		{
			try
			{
				return nationalityDAL.Getnationalitys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Nationality Getnationality(int nationality_id)
		{
			try
			{
				return nationalityDAL.Getnationality(nationality_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addnationality(Nationality onationality)
		{
			try
			{
				return nationalityDAL.Addnationality(onationality);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatenationality(Nationality onationality)
		{
			try
			{
				return nationalityDAL.Updatenationality(onationality);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removenationality(Nationality onationality)
		{
			try
			{
				return nationalityDAL.Removenationality(onationality);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removenationality(int nationality_id)
		{
			try
			{
				return nationalityDAL.Removenationality(nationality_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Nationality> Deserializenationalitys(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Nationality>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializenationalitys(string Path, List<Nationality> nationalitys)
		{
			try
			{
				GenericXmlSerializer<List<Nationality>>.Serialize(nationalitys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
