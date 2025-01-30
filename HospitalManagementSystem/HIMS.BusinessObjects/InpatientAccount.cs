using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class InpatientAccount
    {
        private int _inpatient_account_id;

        public int inpatient_account_id
        {
            get { return _inpatient_account_id; }
            set { _inpatient_account_id = value; }
        }
        private Nullable<int> _admission_id;

        public Nullable<int> admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }

        }
        private Nullable<decimal> _admission_fee;

        public Nullable<decimal> admission_fee
        {
            get { return _admission_fee; }
            set { _admission_fee = value; }
        }
        private Nullable<decimal> _room_rent;

        public Nullable<decimal> room_rent
        {
            get { return _room_rent; }
            set { _room_rent = value; }
        }
        private Nullable<decimal> _cabin_service_charge;

        public Nullable<decimal> cabin_service_charge
        {
            get { return _cabin_service_charge; }
            set { _cabin_service_charge = value; }
        }
        private Nullable<decimal> _Pathology;

        public Nullable<decimal> Pathology
        {
            get { return _Pathology; }
            set { _Pathology = value; }
        }
        private Nullable<decimal> _X_Ray;

        public Nullable<decimal> X_Ray
        {
            get { return _X_Ray; }
            set { _X_Ray = value; }
        }
        private Nullable<decimal> _USG;

        public Nullable<decimal> USG
        {
            get { return _USG; }
            set { _USG = value; }
        }
        private Nullable<decimal> _ECG;

        public Nullable<decimal> ECG
        {
            get { return _ECG; }
            set { _ECG = value; }
        }

        private Nullable<decimal> _ECO;

        public Nullable<decimal> ECO
        {
            get { return _ECO; }
            set { _ECO = value; }
        }

        private Nullable<decimal> _other_fee;

        public Nullable<decimal> other_fee
        {
            get { return _other_fee; }
            set { _other_fee = value; }
        }
        private Nullable<decimal> _doctors_fee;

        public Nullable<decimal> doctors_fee
        {
            get { return _doctors_fee; }
            set { _doctors_fee = value; }
        }

        private int _is_done_by_account;

        public int is_done_by_account
        {
            get { return _is_done_by_account; }
            set { _is_done_by_account = value; }
        }
        private Nullable<DateTime> _record_created_date;
                 
        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }

        private Nullable<int> _record_created_by;

        public Nullable<int> record_created_by
        {
            get { return _record_created_by; }
            set { _record_created_by = value; }
        }
        public InpatientAccount()
        { }

        public InpatientAccount(int inpatient_account_id, Nullable<int> admission_id, Nullable<decimal> admission_fee, Nullable<decimal> room_rent, Nullable<decimal> cabin_service_charge, Nullable<decimal> Pathology, Nullable<Decimal> X_Ray, Nullable<decimal> USG, Nullable<decimal> ECG, Nullable<decimal> other_fee,int is_done_by_account, Nullable<DateTime> record_created_date, Nullable<int> record_created_by)
        {
            this.inpatient_account_id = inpatient_account_id;
            this.admission_id = admission_id;
            this.admission_fee = admission_fee;
            this.room_rent = room_rent;
            this.cabin_service_charge = cabin_service_charge;
            this.Pathology = Pathology;
            this.X_Ray = X_Ray;
            this.USG = USG;
            this.ECG = ECG;
            this.other_fee = other_fee;
            this.is_done_by_account = is_done_by_account;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
         
        }
        public override string ToString()
        {
            return "inpatient_account_id = " + inpatient_account_id.ToString() + ",admission_id = " + admission_id.ToString() + ",admission_fee = " + admission_fee.ToString() + ",admission_fee = " + admission_fee.ToString() + ",room_rent = " + room_rent.ToString() + ",cabin_service_charge = " + cabin_service_charge.ToString() + ",Pathology=" + Pathology.ToString() + ",X_Ray= " + X_Ray.ToString() + ",USG= " + USG.ToString() + ",ECG= " + ECG.ToString() + ",other_fee=" + other_fee.ToString() + ",is_done_by_account=" +is_done_by_account.ToString()+", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString();
        }


      
    }
}
