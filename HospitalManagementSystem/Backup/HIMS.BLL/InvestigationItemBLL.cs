using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InvestigationItemBLL
	{
		private InvestigationItemDAL _investigation_itemDAL;

		public InvestigationItemDAL investigation_itemDAL
		{
			get { return _investigation_itemDAL; }
			set { _investigation_itemDAL = value; }
		}

		public InvestigationItemBLL()
		{
			investigation_itemDAL = new InvestigationItemDAL();
		}
		public List<InvestigationItem> Getinvestigation_itemsList()
		{
			try
			{
				return investigation_itemDAL.Getinvestigation_itemsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getinvestigation_items()
		{
			try
			{
				return investigation_itemDAL.Getinvestigation_items();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public InvestigationItem Getinvestigation_item(int investigation_item_id)
		{
			try
			{
				return investigation_itemDAL.Getinvestigation_item(investigation_item_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addinvestigation_item(InvestigationItem oinvestigation_item)
		{
			try
			{
				return investigation_itemDAL.Addinvestigation_item(oinvestigation_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updateinvestigation_item(InvestigationItem oinvestigation_item)
		{
			try
			{
				return investigation_itemDAL.Updateinvestigation_item(oinvestigation_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removeinvestigation_item(InvestigationItem oinvestigation_item)
		{
			try
			{
				return investigation_itemDAL.Removeinvestigation_item(oinvestigation_item);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item(int investigation_item_id)
		{
			try
			{
				return investigation_itemDAL.Removeinvestigation_item(investigation_item_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<InvestigationItem> Deserializeinvestigation_items(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<InvestigationItem>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializeinvestigation_items(string Path, List<InvestigationItem> investigation_items)
		{
			try
			{
                GenericXmlSerializer<List<InvestigationItem>>.Serialize(investigation_items, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
