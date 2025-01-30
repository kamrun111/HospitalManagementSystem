using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class UnitBLL
	{
		private UnitDAL _unitDAL;

		public UnitDAL unitDAL
		{
			get { return _unitDAL; }
			set { _unitDAL = value; }
		}

		public UnitBLL()
		{
			unitDAL = new UnitDAL();
		}
		public List<Unit> GetunitsList()
		{
			try
			{
				return unitDAL.GetunitsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getunits()
		{
			try
			{
				return unitDAL.Getunits();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Unit Getunit(int unit_id)
		{
			try
			{
				return unitDAL.Getunit(unit_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addunit(Unit ounit)
		{
			try
			{
				return unitDAL.Addunit(ounit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateunit(Unit ounit)
		{
			try
			{
				return unitDAL.Updateunit(ounit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeunit(Unit ounit)
		{
			try
			{
				return unitDAL.Removeunit(ounit);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeunit(int unit_id)
		{
			try
			{
				return unitDAL.Removeunit(unit_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Unit> Deserializeunits(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Unit>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeunits(string Path, List<Unit> units)
		{
			try
			{
				GenericXmlSerializer<List<Unit>>.Serialize(units, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
