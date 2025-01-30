using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class HistoryTextGroupBLL
	{
		private HistoryTextGroupDAL _history_text_groupDAL;

		public HistoryTextGroupDAL history_text_groupDAL
		{
			get { return _history_text_groupDAL; }
			set { _history_text_groupDAL = value; }
		}

		public HistoryTextGroupBLL()
		{
			history_text_groupDAL = new HistoryTextGroupDAL();
		}
		public List<HistoryTextGroup> Gethistory_text_groupsList()
		{
			try
			{
				return history_text_groupDAL.Gethistory_text_groupsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Gethistory_text_groups()
		{
			try
			{
				return history_text_groupDAL.Gethistory_text_groups();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetHistoryItmGrpByHistoryGrp(string histItmGrp)

		{
			try
			{
				return history_text_groupDAL.GetHistoryItmGrpByHistoryGrp(histItmGrp);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public HistoryTextGroup Gethistory_text_group(int history_text_group_id)
		{
			try
			{
				return history_text_groupDAL.Gethistory_text_group(history_text_group_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addhistory_text_group(HistoryTextGroup ohistory_text_group)
		{
			try
			{
				return history_text_groupDAL.Addhistory_text_group(ohistory_text_group);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatehistory_text_group(HistoryTextGroup ohistory_text_group)
		{
			try
			{
				return history_text_groupDAL.Updatehistory_text_group(ohistory_text_group);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text_group(HistoryTextGroup ohistory_text_group)
		{
			try
			{
				return history_text_groupDAL.Removehistory_text_group(ohistory_text_group);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text_group(int history_text_group_id)
		{
			try
			{
				return history_text_groupDAL.Removehistory_text_group(history_text_group_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<HistoryTextGroup> Deserializehistory_text_groups(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<HistoryTextGroup>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializehistory_text_groups(string Path, List<HistoryTextGroup> history_text_groups)
		{
			try
			{
				GenericXmlSerializer<List<HistoryTextGroup>>.Serialize(history_text_groups, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
