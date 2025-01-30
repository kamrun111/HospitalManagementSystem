using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class CityBLL
	{
		private CityDAL _cityDAL;

		public CityDAL cityDAL
		{
			get { return _cityDAL; }
			set { _cityDAL = value; }
		}

		public CityBLL()
		{
			cityDAL = new CityDAL();
		}
		public List<City> GetcitysList()
		{
			try
			{
				return cityDAL.GetcitysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getcitys()
		{
			try
			{
				return cityDAL.Getcitys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public City Getcity(int city_id)
		{
			try
			{
				return cityDAL.Getcity(city_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addcity(City ocity)
		{
			try
			{
				return cityDAL.Addcity(ocity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecity(City ocity)
		{
			try
			{
				return cityDAL.Updatecity(ocity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecity(City ocity)
		{
			try
			{
				return cityDAL.Removecity(ocity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecity(int city_id)
		{
			try
			{
				return cityDAL.Removecity(city_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<City> Deserializecitys(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<City>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializecitys(string Path, List<City> citys)
		{
			try
			{
				GenericXmlSerializer<List<City>>.Serialize(citys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
