using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
    public class OPDAdvice
    {
        private int _AdviceID;
        public int AdviceID
        {
            get { return _AdviceID; }
            set { _AdviceID = value; }
        }
        private Nullable<int> _PrescriptionID;
        public Nullable<int> PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }
        private string _Advice;
        public string Advice
        {
            get { return _Advice; }
            set { _Advice = value; }
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
        public OPDAdvice()
        { }
        public OPDAdvice(int AdviceID, Nullable<int> PrescriptionID, string Advice, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
        {
            this.AdviceID = AdviceID;
            this.PrescriptionID = PrescriptionID;
            this.Advice = Advice;
            this.RecordeCreatedBy = RecordeCreatedBy;
            this.RecordeCreatedDate = RecordeCreatedDate;
            this.RecordeModifiedBy = RecordeModifiedBy;
            this.RecordeModifiedDate = RecordeModifiedDate;
        }
        public override string ToString()
        {
            return "AdviceID = " + AdviceID.ToString() + "PrescriptionID = " + PrescriptionID.ToString() + "Advice = " + Advice + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
        }
    }
}
