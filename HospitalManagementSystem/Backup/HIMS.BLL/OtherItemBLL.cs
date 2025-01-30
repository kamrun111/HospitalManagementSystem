using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OtherItemBLL
	{
		private OtherItemDAL _other_itemDAL;

		public OtherItemDAL other_itemDAL
		{
			get { return _other_itemDAL; }
			set { _other_itemDAL = value; }
		}

		public OtherItemBLL()
		{
			other_itemDAL = new OtherItemDAL();
		}
		public List<OtherItem> Getother_itemsList()
		{
			try
			{
				return other_itemDAL.Getother_itemsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getother_items()
		{
			try
			{
				return other_itemDAL.Getother_items();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public OtherItem Getother_item(int other_item_id)
		{
			try
			{
				return other_itemDAL.Getother_item(other_item_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addother_item(OtherItem oother_item)
		{
			try
			{
				return other_itemDAL.Addother_item(oother_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateother_item(OtherItem oother_item)
		{
			try
			{
				return other_itemDAL.Updateother_item(oother_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeother_item(OtherItem oother_item)
		{
			try
			{
				return other_itemDAL.Removeother_item(oother_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeother_item(int other_item_id)
		{
			try
			{
				return other_itemDAL.Removeother_item(other_item_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<OtherItem> Deserializeother_items(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<OtherItem>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeother_items(string Path, List<OtherItem> other_items)
		{
			try
			{
				GenericXmlSerializer<List<OtherItem>>.Serialize(other_items, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
