using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InvestigationItemUsageBLL
	{
		private InvestigationItemUsageDAL _investigation_item_usageDAL;

		public InvestigationItemUsageDAL investigation_item_usageDAL
		{
			get { return _investigation_item_usageDAL; }
			set { _investigation_item_usageDAL = value; }
		}

		public InvestigationItemUsageBLL()
		{
			investigation_item_usageDAL = new InvestigationItemUsageDAL();
		}
		public List<InvestigationItemUsage> Getinvestigation_item_usagesList()
		{
			try
			{
				return investigation_item_usageDAL.Getinvestigation_item_usagesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getinvestigation_item_usages()
		{
			try
			{
				return investigation_item_usageDAL.Getinvestigation_item_usages();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public InvestigationItemUsage Getinvestigation_item_usage(int investigation_item_usage_id)
		{
			try
			{
				return investigation_item_usageDAL.Getinvestigation_item_usage(investigation_item_usage_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addinvestigation_item_usage(InvestigationItemUsage oinvestigation_item_usage)
		{
			try
			{
				return investigation_item_usageDAL.Addinvestigation_item_usage(oinvestigation_item_usage);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateinvestigation_item_usage(InvestigationItemUsage oinvestigation_item_usage)
		{
			try
			{
				return investigation_item_usageDAL.Updateinvestigation_item_usage(oinvestigation_item_usage);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_usage(InvestigationItemUsage oinvestigation_item_usage)
		{
			try
			{
				return investigation_item_usageDAL.Removeinvestigation_item_usage(oinvestigation_item_usage);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_usage(int investigation_item_usage_id)
		{
			try
			{
				return investigation_item_usageDAL.Removeinvestigation_item_usage(investigation_item_usage_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<InvestigationItemUsage> Deserializeinvestigation_item_usages(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<InvestigationItemUsage>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeinvestigation_item_usages(string Path, List<InvestigationItemUsage> investigation_item_usages)
		{
			try
			{
				GenericXmlSerializer<List<InvestigationItemUsage>>.Serialize(investigation_item_usages, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
