using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class GenderBLL
	{
		private GenderDAL _genderDAL;

		public GenderDAL genderDAL
		{
			get { return _genderDAL; }
			set { _genderDAL = value; }
		}

		public GenderBLL()
		{
			genderDAL = new GenderDAL();
		}
		public List<Gender> GetgendersList()
		{
			try
			{
				return genderDAL.GetgendersList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getgenders()
		{
			try
			{
				return genderDAL.Getgenders();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Gender Getgender(int gender_id)
		{
			try
			{
				return genderDAL.Getgender(gender_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addgender(Gender ogender)
		{
			try
			{
				return genderDAL.Addgender(ogender);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updategender(Gender ogender)
		{
			try
			{
				return genderDAL.Updategender(ogender);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removegender(Gender ogender)
		{
			try
			{
				return genderDAL.Removegender(ogender);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removegender(int gender_id)
		{
			try
			{
				return genderDAL.Removegender(gender_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Gender> Deserializegenders(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Gender>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializegenders(string Path, List<Gender> genders)
		{
			try
			{
				GenericXmlSerializer<List<Gender>>.Serialize(genders, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
