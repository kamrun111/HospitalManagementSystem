using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class HistoryTextBLL
	{
		private HistoryTextDAL _history_textDAL;

		public HistoryTextDAL history_textDAL
		{
			get { return _history_textDAL; }
			set { _history_textDAL = value; }
		}

		public HistoryTextBLL()
		{
			history_textDAL = new HistoryTextDAL();
		}
		public List<HistoryText> Gethistory_textsList()
		{
			try
			{
				return history_textDAL.Gethistory_textsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Gethistory_texts()
		{
			try
			{
				return history_textDAL.Gethistory_texts();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetHistoryTextByHistoryTextGroup(int historyTextGroupID)
		{
			try
			{
                return history_textDAL.GetHistoryTextByHistoryTextGroup(historyTextGroupID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public HistoryText Gethistory_text(int history_text_id)
		{
			try
			{
				return history_textDAL.Gethistory_text(history_text_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addhistory_text(HistoryText ohistory_text)
		{
			try
			{
				return history_textDAL.Addhistory_text(ohistory_text);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatehistory_text(HistoryText ohistory_text)
		{
			try
			{
				return history_textDAL.Updatehistory_text(ohistory_text);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text(HistoryText ohistory_text)
		{
			try
			{
				return history_textDAL.Removehistory_text(ohistory_text);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text(int history_text_id)
		{
			try
			{
				return history_textDAL.Removehistory_text(history_text_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<HistoryText> Deserializehistory_texts(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<HistoryText>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializehistory_texts(string Path, List<HistoryText> history_texts)
		{
			try
			{
				GenericXmlSerializer<List<HistoryText>>.Serialize(history_texts, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
