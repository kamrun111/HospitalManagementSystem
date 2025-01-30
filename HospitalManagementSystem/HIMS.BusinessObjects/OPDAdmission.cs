using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
    public class OPDAdmission
    {
        private int _PKID;
        public int PKID
        {
            get { return _PKID; }
            set { _PKID = value; }
        }
        private string _RegistrationID;
        public string RegistrationID
        {
            get { return _RegistrationID; }
            set { _RegistrationID = value; }
        }
        private string _AdmissionDate;
        public string AdmissionDate
        {
            get { return _AdmissionDate; }
            set { _AdmissionDate = value; }
        }
        private string _AdmissionTime;
        public string AdmissionTime
        {
            get { return _AdmissionTime; }
            set { _AdmissionTime = value; }
        }
        private Nullable<int> _CaseNO;
        public Nullable<int> CaseNO
        {
            get { return _CaseNO; }
            set { _CaseNO = value; }
        }
        private string _PatientID;
        public string PatientID
        {
            get { return _PatientID; }
            set { _PatientID = value; }
        }
        private Nullable<int> _IsDischarged;
        public Nullable<int> IsDischarged
        {
            get { return _IsDischarged; }
            set { _IsDischarged = value; }
        }
        private Nullable<int> _IsBillClear;
        public Nullable<int> IsBillClear
        {
            get { return _IsBillClear; }
            set { _IsBillClear = value; }
        }
        private string _DischargedDate;
        public string DischargedDate
        {
            get { return _DischargedDate; }
            set { _DischargedDate = value; }
        }
        private string _Dischargetime;
        public string Dischargetime
        {
            get { return _Dischargetime; }
            set { _Dischargetime = value; }
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
        public OPDAdmission()
        { }
        public OPDAdmission(int PKID, string RegistrationID, string AdmissionDate, string AdmissionTime, Nullable<int> CaseNO, string PatientID, Nullable<int> IsDischarged, Nullable<int> IsBillClear, string DischargedDate, string Dischargetime, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
        {
            this.PKID = PKID;
            this.RegistrationID = RegistrationID;
            this.AdmissionDate = AdmissionDate;
            this.AdmissionTime = AdmissionTime;
            this.CaseNO = CaseNO;
            this.PatientID = PatientID;
            this.IsDischarged = IsDischarged;
            this.IsBillClear = IsBillClear;
            this.DischargedDate = DischargedDate;
            this.Dischargetime = Dischargetime;
            this.RecordeCreatedBy = RecordeCreatedBy;
            this.RecordeCreatedDate = RecordeCreatedDate;
            this.RecordeModifiedBy = RecordeModifiedBy;
            this.RecordeModifiedDate = RecordeModifiedDate;
        }
        public override string ToString()
        {
            return "PKID = " + PKID.ToString() + "RegistrationID = " + RegistrationID + "AdmissionDate = " + AdmissionDate + "AdmissionTime = " + AdmissionTime + "CaseNO = " + CaseNO.ToString() + "PatientID = " + PatientID + "IsDischarged = " + IsDischarged.ToString() + "IsBillClear = " + IsBillClear.ToString() + "DischargedDate = " + DischargedDate + "Dischargetime = " + Dischargetime + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
        }
    }
}
