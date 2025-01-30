using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class CaseSummary
	{
        private int _CaseSummaryID;

        public int CaseSummaryID
		{
            get { return _CaseSummaryID; }
            set { _CaseSummaryID = value; }
        }

        private string _discharge_code;

        public string discharge_code
        {
            get { return _discharge_code; }
            set { _discharge_code = value; }
        }
        private string _hospital_medication;

        public string hospital_medication
        {
            get { return _hospital_medication; }
            set { _hospital_medication = value; }
        }

		private string _PreCaseSummary;

		public string PreCaseSummary
		{
			get { return _PreCaseSummary; }
			set { _PreCaseSummary = value; }
		}
        private string _AftCaseSummary;
        	public string AftCaseSummary
		{
			get { return _AftCaseSummary; }
			set { _AftCaseSummary = value; }
		}
        private string _chiefcomplain;
        public string chiefcomplain
        {
            get { return _chiefcomplain; }
            set { _chiefcomplain = value; }
        }

        private string _present_status;
        public string present_status
		{
            get { return _present_status; }
            set { _present_status = value; }
		}

        private string _medication;
        public string medication
        {
            get { return _medication; }
            set { _medication = value; }
        }

        private string _advice;
        public string advice
        {
            get { return _advice; }
            set { _advice = value; }
        }

        private string _treatment;
        public string treatment
        {
            get { return _treatment; }
            set { _treatment = value; }
        }

        private string _treatment_procedure;
        public string treatment_procedure
        {
            get { return _treatment_procedure; }
            set { _treatment_procedure = value; }
        }

        private string _duty_doctor_name;
        public string duty_doctor_name
        {
            get { return _duty_doctor_name; }
            set { _duty_doctor_name = value; }
        }

        private string _dis_type_remarks;
        public string dis_type_remarks
        {
            get { return _dis_type_remarks; }
            set { _dis_type_remarks = value; }
        }

        private string _dis_type;
        public string dis_type
        {
            get { return _dis_type; }
            set { _dis_type = value; }
        }

        private Nullable<int> _record_created_by;
        public Nullable<int> record_created_by
        {
            get { return _record_created_by; }
            set { _record_created_by = value; }
        }

        private Nullable<DateTime> _record_modified_date;

        public Nullable<DateTime> record_modified_date
        {
            get { return _record_modified_date; }
            set { _record_modified_date = value; }
        }

        private Nullable<int> _record_modified_by;

        public Nullable<int> record_modified_by
        {
            get { return _record_modified_by; }
            set { _record_modified_by = value; }
        }

        private Nullable<DateTime> _record_created_date;

        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }

		

		public CaseSummary()
		{ }

        public CaseSummary(int CaseSummaryID,string discharge_code,string hospital_medication, string PreCaseSummary, string AftCaseSummary, string chiefcomplain, string present_status, string medication, string advice, string treatment, string treatment_procedure, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.CaseSummaryID = CaseSummaryID;
            this.hospital_medication = hospital_medication;
            this.discharge_code = discharge_code;
            this.PreCaseSummary = PreCaseSummary;
            this.AftCaseSummary = AftCaseSummary;
            this.chiefcomplain = chiefcomplain;
            this.present_status = present_status;
            this.medication = medication;
            this.advice = advice;
            this.treatment = treatment;
            this.treatment_procedure = treatment_procedure;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
			
		}

		public override string ToString()
		{
            return "CaseSummaryID = " + CaseSummaryID.ToString() + ",discharge_code=" + discharge_code + ",hospital_medication=" +hospital_medication +", PreCaseSummary = " + PreCaseSummary + ",AftCaseSummary = " + AftCaseSummary;
		}

		public class CaseSummaryIDComparer : System.Collections.Generic.IComparer<CaseSummary>
		{
			public SorterMode SorterMode;
			public CaseSummaryIDComparer()
			{ }
            public CaseSummaryIDComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<CaseSummary> Membres
            int System.Collections.Generic.IComparer<CaseSummary>.Compare(CaseSummary x, CaseSummary y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.CaseSummaryID.CompareTo(x.CaseSummaryID);
				}
				else
				{
                    return x.CaseSummaryID.CompareTo(y.CaseSummaryID);
				}
			}
			#endregion
		}

	}
}
