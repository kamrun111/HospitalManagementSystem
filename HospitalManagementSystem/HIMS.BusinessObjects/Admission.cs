using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class AdmissionBO
	{
		private int _admission_id;

		public int admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private string _admission_code;

		public string admission_code
		{
			get { return _admission_code; }
			set { _admission_code = value; }
		}

		private Nullable<DateTime> _admission_date;

		public Nullable<DateTime> admission_date
		{
			get { return _admission_date; }
			set { _admission_date = value; }
		}

        private Nullable<int> _case_no;

        public Nullable<int> case_no
        {
            get { return _case_no; }
            set { _case_no = value; }
        }

		private Nullable<int> _patient_id;

		public Nullable<int> patient_id
		{
			get { return _patient_id; }
			set { _patient_id = value; }
		}

		private Nullable<int> _cabin_id;

		public Nullable<int> cabin_id
		{
			get { return _cabin_id; }
			set { _cabin_id = value; }
		}

		private Nullable<Decimal> _deposit;

		public Nullable<Decimal> deposit
		{
			get { return _deposit; }
			set { _deposit = value; }
		}

		private string _remarks;

		public string remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}

        private string _nurse_remarks;

        public string nurse_remarks
        {
            get { return _nurse_remarks; }
            set { _nurse_remarks = value; }
        }

        private string _PCaseSummary;

        public string PCaseSummary
        {
            get { return _PCaseSummary; }
            set { _PCaseSummary = value; }
        }

        private string _APCaseSummary;

        public string APCaseSummary
        {
            get { return _APCaseSummary; }
            set { _APCaseSummary = value; }
        }
		private Nullable<int> _is_bill_clear;

		public Nullable<int> is_bill_clear
		{
			get { return _is_bill_clear; }
			set { _is_bill_clear = value; }
		}

		private Nullable<int> _is_discharged;

        public Nullable<int> is_discharged
		{
			get { return _is_discharged; }
			set { _is_discharged = value; }
		}

        private Nullable<int> _is_cc_written;

        public Nullable<int> is_cc_written
		{
			get { return _is_cc_written; }
			set { _is_cc_written = value; }
		}

        private Nullable<int> _is_history_written;

        public Nullable<int> is_history_written
		{
			get { return _is_history_written; }
			set { _is_history_written = value; }
		}

        private Nullable<int> _is_first_reqular_checkup_done;

        public Nullable<int> is_first_reqular_checkup_done
		{
			get { return _is_first_reqular_checkup_done; }
			set { _is_first_reqular_checkup_done = value; }
		}

        private Nullable<int> _is_biscount_clear;

        public Nullable<int> is_biscount_clear
        {
            get { return _is_biscount_clear; }
            set { _is_biscount_clear = value; }
        }

        private string _pt_type;

        public string pt_type
		{
            get { return _pt_type; }
            set { _pt_type = value; }
		}

        private int _insurance_type;

        public int insurance_type
        {
            get { return _insurance_type; }
            set { _insurance_type = value; }
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

        private Nullable<DateTime> _discharge_date;

        public Nullable<DateTime> discharge_date
        {
            get { return _discharge_date; }
            set { _discharge_date = value; }
        }

		public AdmissionBO()
		{ }

        public AdmissionBO(int admission_id, string admission_code, Nullable<DateTime> discharge_date, Nullable<DateTime> admission_date, Nullable<int> patient_id, Nullable<int> cabin_id, Nullable<Decimal> deposit, string remarks, string PCaseSummary, string APCaseSummary, Nullable<SByte> is_bill_clear, Nullable<SByte> is_discharged, Nullable<SByte> is_cc_written, Nullable<SByte> is_history_written, Nullable<SByte> is_first_reqular_checkup_done, Nullable<SByte> is_biscount_clear, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.admission_id = admission_id;
			this.admission_code = admission_code;
			this.admission_date = admission_date;
			this.patient_id = patient_id;
			this.cabin_id = cabin_id;
			this.deposit = deposit;
			this.remarks = remarks;
            this.PCaseSummary = PCaseSummary;
            this.APCaseSummary = APCaseSummary;
			this.is_bill_clear = is_bill_clear;
			this.is_discharged = is_discharged;
			this.is_cc_written = is_cc_written;
			this.is_history_written = is_history_written;
			this.is_first_reqular_checkup_done = is_first_reqular_checkup_done;
            this.is_biscount_clear = is_biscount_clear;
            this.discharge_date = discharge_date;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "admission_id = " + admission_id.ToString() + ",admission_code = " + admission_code + ",admission_date = " + admission_date.ToString() + ",patient_id = " + patient_id.ToString() + ",cabin_id = " + cabin_id.ToString() + ",deposit = " + deposit.ToString() + ",remarks = " + remarks + ",PCaseSummary = " + PCaseSummary + ",APCaseSummary= " + APCaseSummary + ",is_bill_clear = " + is_bill_clear.ToString() + ",is_discharged = " + is_discharged.ToString() + ",is_cc_written = " + is_cc_written.ToString() + ",is_history_written = " + is_history_written.ToString() + ",is_first_reqular_checkup_done = " + is_first_reqular_checkup_done.ToString() + ",is_biscount_clear= " + is_biscount_clear.ToString() + ",  record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",discharge_date=" + discharge_date.ToString() + ", record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class admission_idComparer : System.Collections.Generic.IComparer<AdmissionBO>
		{
			public SorterMode SorterMode;
			public admission_idComparer()
			{ }
			public admission_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<admission> Membres
			int System.Collections.Generic.IComparer<AdmissionBO>.Compare(AdmissionBO x, AdmissionBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.admission_id.CompareTo(x.admission_id);
				}
				else
				{
					return x.admission_id.CompareTo(y.admission_id);
				}
			}
			#endregion
		}
		public class admission_codeComparer : System.Collections.Generic.IComparer<AdmissionBO>
		{
			public SorterMode SorterMode;
			public admission_codeComparer()
			{ }
			public admission_codeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<admission> Membres
			int System.Collections.Generic.IComparer<AdmissionBO>.Compare(AdmissionBO x, AdmissionBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.admission_code.CompareTo(x.admission_code);
				}
				else
				{
					return x.admission_code.CompareTo(y.admission_code);
				}
			}
			#endregion
		}
		public class remarksComparer : System.Collections.Generic.IComparer<AdmissionBO>
		{
			public SorterMode SorterMode;
			public remarksComparer()
			{ }
			public remarksComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<admission> Membres
			int System.Collections.Generic.IComparer<AdmissionBO>.Compare(AdmissionBO x, AdmissionBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.remarks.CompareTo(x.remarks);
				}
				else
				{
					return x.remarks.CompareTo(y.remarks);
				}
			}
			#endregion
		}
	}
}
