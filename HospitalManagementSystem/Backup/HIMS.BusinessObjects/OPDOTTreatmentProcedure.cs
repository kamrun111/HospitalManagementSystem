using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
    public class OPDOTTreatmentProcedure
    {
        private int _OTTreatmentProcedureID;
        public int OTTreatmentProcedureID
        {
            get { return _OTTreatmentProcedureID; }
            set { _OTTreatmentProcedureID = value; }
        }
        private Nullable<int> _PrescriptionID;
        public Nullable<int> PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }
        private string _OTName;
        public string OTName
        {
            get { return _OTName; }
            set { _OTName = value; }
        }
        private string _OTTreatmentProcedure;
        public string OTTreatmentProcedure
        {
            get { return _OTTreatmentProcedure; }
            set { _OTTreatmentProcedure = value; }
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
        public OPDOTTreatmentProcedure()
        { }
        public OPDOTTreatmentProcedure(int OTTreatmentProcedureID, Nullable<int> PrescriptionID, string OTName, string OTTreatmentProcedure, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
        {
            this.OTTreatmentProcedureID = OTTreatmentProcedureID;
            this.PrescriptionID = PrescriptionID;
            this.OTName = OTName;
            this.OTTreatmentProcedure = OTTreatmentProcedure;
            this.RecordeCreatedBy = RecordeCreatedBy;
            this.RecordeCreatedDate = RecordeCreatedDate;
            this.RecordeModifiedBy = RecordeModifiedBy;
            this.RecordeModifiedDate = RecordeModifiedDate;
        }
        public override string ToString()
        {
            return "OTTreatmentProcedureID = " + OTTreatmentProcedureID.ToString() + "PrescriptionID = " + PrescriptionID.ToString() + "OTName = " + OTName + "OTTreatmentProcedure = " + OTTreatmentProcedure + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
        }
    }
}
