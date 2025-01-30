using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InventoryBLL
	{
		private InventoryDAL _inventoryDAL;

		public InventoryDAL inventoryDAL
		{
			get { return _inventoryDAL; }
			set { _inventoryDAL = value; }
		}

		public InventoryBLL()
		{
			inventoryDAL = new InventoryDAL();
		}
		public List<Inventory> GetinventorysList()
		{
			try
			{
				return inventoryDAL.GetinventorysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getinventorys()
		{
			try
			{
				return inventoryDAL.Getinventorys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Inventory Getinventory(int inventory_id)
		{
			try
			{
				return inventoryDAL.Getinventory(inventory_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addinventory(Inventory oinventory)
		{
			try
			{
				return inventoryDAL.Addinventory(oinventory);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateinventory(Inventory oinventory)
		{
			try
			{
				return inventoryDAL.Updateinventory(oinventory);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinventory(Inventory oinventory)
		{
			try
			{
				return inventoryDAL.Removeinventory(oinventory);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinventory(int inventory_id)
		{
			try
			{
				return inventoryDAL.Removeinventory(inventory_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Inventory> Deserializeinventorys(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Inventory>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeinventorys(string Path, List<Inventory> inventorys)
		{
			try
			{
				GenericXmlSerializer<List<Inventory>>.Serialize(inventorys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
