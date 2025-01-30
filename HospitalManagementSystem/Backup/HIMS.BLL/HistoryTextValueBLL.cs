using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class HistoryTextValueBLL
	{
		private HistoryTextValueDAL _history_text_valueDAL;

		public HistoryTextValueDAL history_text_valueDAL
		{
			get { return _history_text_valueDAL; }
			set { _history_text_valueDAL = value; }
		}

		public HistoryTextValueBLL()
		{
			history_text_valueDAL = new HistoryTextValueDAL();
		}
		public List<HistoryTextValue> Gethistory_text_valuesList()
		{
			try
			{
				return history_text_valueDAL.Gethistory_text_valuesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Gethistory_text_values()
		{
			try
			{
				return history_text_valueDAL.Gethistory_text_values();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GeHTextValueByHText(string historyText)
		{
			try
			{
				return history_text_valueDAL.GeHTextValueByHText(historyText);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GeHTextValueByAdmnIDAndHText(int admnID, string historyText)

		{
			try
			{
				return history_text_valueDAL.GeHTextValueByAdmnIDAndHText(admnID,historyText);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet CheckAndSaveHTextValueAndPHistory(string historyTextValue, int historyTextID, int admnID)

		{
			try
			{
                return history_text_valueDAL.CheckAndSaveHTextValueAndPHistory(historyTextValue, historyTextID, admnID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public HistoryTextValue Gethistory_text_value(int history_text_value_id)
		{
			try
			{
				return history_text_valueDAL.Gethistory_text_value(history_text_value_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addhistory_text_value(HistoryTextValue ohistory_text_value)
		{
			try
			{
				return history_text_valueDAL.Addhistory_text_value(ohistory_text_value);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatehistory_text_value(HistoryTextValue ohistory_text_value)
		{
			try
			{
				return history_text_valueDAL.Updatehistory_text_value(ohistory_text_value);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removehistory_text_value(HistoryTextValue ohistory_text_value)
		{
			try
			{
				return history_text_valueDAL.Removehistory_text_value(ohistory_text_value);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removehistory_text_value(int history_text_value_id)
		{
			try
			{
				return history_text_valueDAL.Removehistory_text_value(history_text_value_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<HistoryTextValue> Deserializehistory_text_values(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<HistoryTextValue>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializehistory_text_values(string Path, List<HistoryTextValue> history_text_values)
		{
			try
			{
                GenericXmlSerializer<List<HistoryTextValue>>.Serialize(history_text_values, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
