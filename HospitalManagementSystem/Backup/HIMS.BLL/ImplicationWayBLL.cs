using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ImplicationWayBLL
	{
		private ImplicationWayDAL _implication_wayDAL;

		public ImplicationWayDAL implication_wayDAL
		{
			get { return _implication_wayDAL; }
			set { _implication_wayDAL = value; }
		}

		public ImplicationWayBLL()
		{
			implication_wayDAL = new ImplicationWayDAL();
		}
		public List<ImplicationWay> Getimplication_waysList()
		{
			try
			{
				return implication_wayDAL.Getimplication_waysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getimplication_ways()
		{
			try
			{
				return implication_wayDAL.Getimplication_ways();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public ImplicationWay Getimplication_way(int implication_way_id)
		{
			try
			{
				return implication_wayDAL.Getimplication_way(implication_way_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addimplication_way(ImplicationWay oimplication_way)
		{
			try
			{
				return implication_wayDAL.Addimplication_way(oimplication_way);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updateimplication_way(ImplicationWay oimplication_way)
		{
			try
			{
				return implication_wayDAL.Updateimplication_way(oimplication_way);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removeimplication_way(ImplicationWay oimplication_way)
		{
			try
			{
				return implication_wayDAL.Removeimplication_way(oimplication_way);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeimplication_way(int implication_way_id)
		{
			try
			{
				return implication_wayDAL.Removeimplication_way(implication_way_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<ImplicationWay> Deserializeimplication_ways(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<ImplicationWay>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializeimplication_ways(string Path, List<ImplicationWay> implication_ways)
		{
			try
			{
                GenericXmlSerializer<List<ImplicationWay>>.Serialize(implication_ways, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
