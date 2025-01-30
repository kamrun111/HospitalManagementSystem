using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
    public class OPDMedication
    {
        private int _TreatmentMedicinID;
        public int TreatmentMedicinID
        {
            get { return _TreatmentMedicinID; }
            set { _TreatmentMedicinID = value; }
        }
        private Nullable<int> _PrescriptionID;
        public Nullable<int> PrescriptionID
        {
            get { return _PrescriptionID; }
            set { _PrescriptionID = value; }
        }
        private string _MedicineName;
        public string MedicineName
        {
            get { return _MedicineName; }
            set { _MedicineName = value; }
        }
        private string _DoseQuantity;
        public string DoseQuantity
        {
            get { return _DoseQuantity; }
            set { _DoseQuantity = value; }
        }
        private string _Duration;
        public string Duration
        {
            get { return _Duration; }
            set { _Duration = value; }
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
        public OPDMedication()
        { }
        public OPDMedication(int TreatmentMedicinID, Nullable<int> PrescriptionID, string MedicineName, string DoseQuantity, string Duration, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
        {
            this.TreatmentMedicinID = TreatmentMedicinID;
            this.PrescriptionID = PrescriptionID;
            this.MedicineName = MedicineName;
            this.DoseQuantity = DoseQuantity;
            this.Duration = Duration;
            this.RecordeCreatedBy = RecordeCreatedBy;
            this.RecordeCreatedDate = RecordeCreatedDate;
            this.RecordeModifiedBy = RecordeModifiedBy;
            this.RecordeModifiedDate = RecordeModifiedDate;
        }
        public override string ToString()
        {
            return "TreatmentMedicinID = " + TreatmentMedicinID.ToString() + "PrescriptionID = " + PrescriptionID.ToString() + "MedicineName = " + MedicineName + "DoseQuantity = " + DoseQuantity + "Duration = " + Duration + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
        }
    }
}
