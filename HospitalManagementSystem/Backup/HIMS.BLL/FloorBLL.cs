using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class FloorBLL
	{
		private FloorDAL _floorDAL;

		public FloorDAL floorDAL
		{
			get { return _floorDAL; }
			set { _floorDAL = value; }
		}

		public FloorBLL()
		{
			floorDAL = new FloorDAL();
		}
		public List<Floor> GetfloorsList()
		{
			try
			{
				return floorDAL.GetfloorsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getfloors()
		{
			try
			{
				return floorDAL.Getfloors();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Floor Getfloor(int floor_id)
		{
			try
			{
				return floorDAL.Getfloor(floor_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addfloor(Floor ofloor)
		{
			try
			{
				return floorDAL.Addfloor(ofloor);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatefloor(Floor ofloor)
		{
			try
			{
				return floorDAL.Updatefloor(ofloor);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removefloor(Floor ofloor)
		{
			try
			{
				return floorDAL.Removefloor(ofloor);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removefloor(int floor_id)
		{
			try
			{
				return floorDAL.Removefloor(floor_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Floor> Deserializefloors(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Floor>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializefloors(string Path, List<Floor> floors)
		{
			try
			{
				GenericXmlSerializer<List<Floor>>.Serialize(floors, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
