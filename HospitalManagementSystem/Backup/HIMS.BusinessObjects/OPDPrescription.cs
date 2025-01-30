using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
    public class OPDPrescription
    {
        private int _PrescriptionID;
        public int PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }
        private string _RegID;
        public string RegID
        {
            get { return _RegID; }
            set { _RegID = value; }
        }
        private string _cc;
        public string cc
        {
            get { return _cc; }
            set { _cc = value; }
        }
        private string _PF;
        public string PF
        {
            get { return _PF; }
            set { _PF = value; }
        }
        private string _TreatmentDate;
        public string TreatmentDate
        {
            get { return _TreatmentDate; }
            set { _TreatmentDate = value; }
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
        public OPDPrescription()
        { }
        public OPDPrescription(int PrescriptionID, string RegID, string cc, string PF, string TreatmentDate, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
        {
            this.PrescriptionID = PrescriptionID;
            this.RegID = RegID;
            this.cc = cc;
            this.PF = PF;
            this.TreatmentDate = TreatmentDate;
            this.RecordeCreatedBy = RecordeCreatedBy;
            this.RecordeCreatedDate = RecordeCreatedDate;
            this.RecordeModifiedBy = RecordeModifiedBy;
            this.RecordeModifiedDate = RecordeModifiedDate;
        }
        public override string ToString()
        {
            return "PrescriptionID = " + PrescriptionID.ToString() + "RegID = " + RegID + "cc = " + cc + "PF = " + PF + "TreatmentDate = " + TreatmentDate + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
        }
    }
}
