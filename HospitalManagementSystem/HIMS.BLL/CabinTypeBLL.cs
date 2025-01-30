using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class CabinTypeBLL
	{
		private CabinTypeDAL _cabin_typeDAL;

		public CabinTypeDAL cabin_typeDAL
		{
			get { return _cabin_typeDAL; }
			set { _cabin_typeDAL = value; }
		}

		public CabinTypeBLL()
		{
			cabin_typeDAL = new CabinTypeDAL();
		}
		public List<CabinType> Getcabin_typesList()
		{
			try
			{
				return cabin_typeDAL.Getcabin_typesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getcabin_types()
		{
			try
			{
				return cabin_typeDAL.Getcabin_types();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public CabinType Getcabin_type(int cabin_type_id)
		{
			try
			{
				return cabin_typeDAL.Getcabin_type(cabin_type_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addcabin_type(CabinType ocabin_type)
		{
			try
			{
				return cabin_typeDAL.Addcabin_type(ocabin_type);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatecabin_type(CabinType ocabin_type)
		{
			try
			{
				return cabin_typeDAL.Updatecabin_type(ocabin_type);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_type(CabinType ocabin_type)
		{
			try
			{
				return cabin_typeDAL.Removecabin_type(ocabin_type);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removecabin_type(int cabin_type_id)
		{
			try
			{
				return cabin_typeDAL.Removecabin_type(cabin_type_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<CabinType> Deserializecabin_types(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<CabinType>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializecabin_types(string Path, List<CabinType> cabin_types)
		{
			try
			{
				GenericXmlSerializer<List<CabinType>>.Serialize(cabin_types, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
