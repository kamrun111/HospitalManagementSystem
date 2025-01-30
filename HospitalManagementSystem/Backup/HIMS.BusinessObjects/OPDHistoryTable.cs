using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
    public class OPDHistoryTable
    {
        private int _PKID;
        public int PKID
        {
            get { return _PKID; }
            set { _PKID = value; }
        }
        private string _OPDRegID;
        public string OPDRegID
        {
            get { return _OPDRegID; }
            set { _OPDRegID = value; }
        }
        private string _HistoryTitle;
        public string HistoryTitle
        {
            get { return _HistoryTitle; }
            set { _HistoryTitle = value; }
        }
        private string _HistoryResult;
        public string HistoryResult
        {
            get { return _HistoryResult; }
            set { _HistoryResult = value; }
        }
        private Nullable<int> _RecordeCreatedBy;
        public Nullable<int> RecordeCreatedBy
        {
            get { return _RecordeCreatedBy; }
            set { _RecordeCreatedBy = value; }
        }
        private string _RecordeCreatedDate;
        public string RecordeCreatedDate
        {
            get { return _RecordeCreatedDate; }
            set { _RecordeCreatedDate = value; }
        }
        private Nullable<int> _RecordeModifiedBy;
        public Nullable<int> RecordeModifiedBy
        {
            get { return _RecordeModifiedBy; }
            set { _RecordeModifiedBy = value; }
        }
        private string _RecordeModifiedDate;
        public string RecordeModifiedDate
        {
            get { return _RecordeModifiedDate; }
            set { _RecordeModifiedDate = value; }
        }
        public OPDHistoryTable()
        { }
        public OPDHistoryTable(int PKID, string OPDRegID, string HistoryTitle, string HistoryResult, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
        {
            this.PKID = PKID;
            this.OPDRegID = OPDRegID;
            this.HistoryTitle = HistoryTitle;
            this.HistoryResult = HistoryResult;
            this.RecordeCreatedBy = RecordeCreatedBy;
            this.RecordeCreatedDate = RecordeCreatedDate;
            this.RecordeModifiedBy = RecordeModifiedBy;
            this.RecordeModifiedDate = RecordeModifiedDate;
        }
        public override string ToString()
        {
            return "PKID = " + PKID.ToString() + "OPDRegID = " + OPDRegID + "HistoryTitle = " + HistoryTitle + "HistoryResult = " + HistoryResult + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
        }
    }
}
