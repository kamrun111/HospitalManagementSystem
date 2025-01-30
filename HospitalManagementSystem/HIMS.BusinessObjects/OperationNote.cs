using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OperationNote
	{
		private int _operation_note_id;

		public int operation_note_id
		{
			get { return _operation_note_id; }
			set { _operation_note_id = value; }
		}

		private Nullable<int> _admission_id;

		public Nullable<int> admission_id
		{
			get { return _admission_id; }
			set { _admission_id = value; }
		}

		private Nullable<DateTime> _expected_date;

		public Nullable<DateTime> expected_date
		{
			get { return _expected_date; }
			set { _expected_date = value; }
		}


        private Nullable<int> _p_day;

        public Nullable<int> p_day
        {
            get { return _p_day; }
            set { _p_day = value; }
        }

        private Nullable<int> _additional_time;

        public Nullable<int> additional_time
        {
            get { return _additional_time; }
            set { _additional_time = value; }
        }

        private Nullable<int> _anaesthesia_nature_id;

        public Nullable<int> anaesthesia_nature_id
        {
            get { return _anaesthesia_nature_id; }
            set { _anaesthesia_nature_id = value; }
        }


		private Nullable<DateTime> _operation_date;

		public Nullable<DateTime> operation_date
		{
			get { return _operation_date; }
			set { _operation_date = value; }
		}

		private Nullable<int> _reffered_doctors_id;

		public Nullable<int> reffered_doctors_id
		{
			get { return _reffered_doctors_id; }
			set { _reffered_doctors_id = value; }
		}

		private Nullable<int> _cabin_id;

		public Nullable<int> cabin_id
		{
			get { return _cabin_id; }
			set { _cabin_id = value; }
		}

        private Nullable<int> _Ot_cabin_id;

        public Nullable<int> Ot_cabin_id
        {
            get { return _Ot_cabin_id; }
            set { _Ot_cabin_id = value; }
        }

		private int _anaesthesia_id;

		public int anaesthesia_id
		{
			get { return _anaesthesia_id; }
			set { _anaesthesia_id = value; }
		}

		private int _first_asst;

		public int first_asst
		{
			get { return _first_asst; }
			set { _first_asst = value; }
		}

		private int _second_asst;

		public int second_asst
		{
			get { return _second_asst; }
			set { _second_asst = value; }
		}

		private int _third_asst;

		public int third_asst
		{
			get { return _third_asst; }
			set { _third_asst = value; }
		}

		private int _surgeon_name;

		public int surgeon_name
		{
			get { return _surgeon_name; }
			set { _surgeon_name = value; }
		}

        private string _ot_requisition_no;

        public string ot_requisition_no
        {
            get { return _ot_requisition_no; }
            set { _ot_requisition_no = value; }
        }

        private string _incision;

        public string incision
		{
            get { return _incision; }
            set { _incision = value; }
		}
        private string _indication;

        public string indication
        {
            get { return _indication; }
            set { _indication = value; }
        }
		

		private Nullable<int> _operation_id;

		public Nullable<int> operation_id
		{
			get { return _operation_id; }
			set { _operation_id = value; }
		}

		private Nullable<int> _baby_note_id;

		public Nullable<int> baby_note_id
		{
			get { return _baby_note_id; }
			set { _baby_note_id = value; }
		}

		private string _procedures;

		public string procedures
		{
			get { return _procedures; }
			set { _procedures = value; }
		}

		private Nullable<Decimal> _GroupPay;

        public Nullable<Decimal> GroupPay
		{
			get { return _GroupPay; }
			set { _GroupPay = value; }
		}

		private string _Remarks;

		public string Remarks
		{
			get { return _Remarks; }
			set { _Remarks = value; }
		}


        private int _is_submit;

        public int is_submit
        {
            get { return _is_submit; }
            set { _is_submit = value; }
        }


        private int _is_received;

        public int is_received
        {
            get { return _is_received; }
            set { _is_received = value; }
        }


        private int _ot_cancel;

        public int ot_cancel
        {
            get { return _ot_cancel; }
            set { _ot_cancel = value; }
        }


        private Nullable<decimal> _amount;

        public Nullable<decimal> amount
        {
            get { return _amount; }
            set { _amount = value; }

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


		public OperationNote()
		{ }

        public OperationNote(int operation_note_id, Nullable<int> admission_id, Nullable<int> Ot_cabin_id, Nullable<DateTime> expected_date, Nullable<DateTime> operation_date, Nullable<int> p_day, Nullable<int> additional_time, Nullable<int> anaesthesia_nature_id, Nullable<int> reffered_doctors_id, Nullable<int> cabin_id, int anaesthesia_id, int first_asst, int second_asst, int third_asst, int surgeon_name, string ot_requisition_no, string indication, string incision, Nullable<int> operation_id, Nullable<int> baby_note_id, string procedures, Nullable<decimal> GroupPay, string Remarks, int is_submit, int is_received,int ot_cancel, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		
		{
			this.operation_note_id = operation_note_id;
			this.admission_id = admission_id;
			this.expected_date = expected_date;
			this.operation_date = operation_date;
            this.p_day = p_day;
            this.additional_time = additional_time;
            this.Ot_cabin_id = Ot_cabin_id;
            this.anaesthesia_nature_id = anaesthesia_nature_id;
			this.reffered_doctors_id = reffered_doctors_id;
			this.cabin_id = cabin_id;
			this.anaesthesia_id = anaesthesia_id;
			this.first_asst = first_asst;
			this.second_asst = second_asst;
			this.third_asst = third_asst;
			this.surgeon_name = surgeon_name;
            this.ot_requisition_no = ot_requisition_no;
			this.indication = indication;
			this.incision = incision;
			this.operation_id = operation_id;
			this.baby_note_id = baby_note_id;
			this.procedures = procedures;
			this.GroupPay = GroupPay;
			this.Remarks = Remarks;
			this.is_submit = is_submit;
			this.is_received = is_received;
            this.ot_cancel = ot_cancel;
            this.amount = amount;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;

		}

		public override string ToString()
		{
            return "operation_note_id = " + operation_note_id.ToString() + ",admission_id = " + admission_id.ToString() + ",expected_date = " + expected_date.ToString() + ",operation_date = " + operation_date.ToString() + ",p_day= " + p_day.ToString() + ",additional_time= " + additional_time.ToString() + ",anaesthesia_nature_id=" + anaesthesia_nature_id.ToString() + ", reffered_doctors_id = " + reffered_doctors_id.ToString() + ",cabin_id = " + cabin_id.ToString() + ",anaesthesia_id = " + anaesthesia_id.ToString() + ",first_asst = " + first_asst.ToString() + ",second_asst = " + second_asst.ToString() + ",third_asst = " + third_asst.ToString() + ",surgeon_name = " + surgeon_name.ToString() + ",ot_requisition_no=" + ot_requisition_no + ", indication = " + indication + ",incision = " + incision + ",operation_id = " + operation_id.ToString() + ",baby_note_id = " + baby_note_id.ToString() + ",procedures = " + procedures + ",GroupPay = " + GroupPay.ToString() + ",Remarks = " + Remarks + ",is_submit = " + is_submit.ToString() + ",is_received = " + is_received.ToString() + ",ot_cancel= " + ot_cancel.ToString()+ ", amount = " + amount.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class operation_note_idComparer : System.Collections.Generic.IComparer<OperationNote>
		{
			public SorterMode SorterMode;
			public operation_note_idComparer()
			{ }
			public operation_note_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation_note> Membres
			int System.Collections.Generic.IComparer<OperationNote>.Compare(OperationNote x, OperationNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.operation_note_id.CompareTo(x.operation_note_id);
				}
				else
				{
					return x.operation_note_id.CompareTo(y.operation_note_id);
				}
			}
			#endregion
		}
		public class indicationComparer : System.Collections.Generic.IComparer<OperationNote>
		{
			public SorterMode SorterMode;
			public indicationComparer()
			{ }
			public indicationComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation_note> Membres
			int System.Collections.Generic.IComparer<OperationNote>.Compare(OperationNote x, OperationNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.indication.CompareTo(x.indication);
				}
				else
				{
					return x.indication.CompareTo(y.indication);
				}
			}
			#endregion
		}
		public class incisionComparer : System.Collections.Generic.IComparer<OperationNote>
		{
			public SorterMode SorterMode;
			public incisionComparer()
			{ }
			public incisionComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation_note> Membres
			int System.Collections.Generic.IComparer<OperationNote>.Compare(OperationNote x, OperationNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.incision.CompareTo(x.incision);
				}
				else
				{
					return x.incision.CompareTo(y.incision);
				}
			}
			#endregion
		}
		public class proceduresComparer : System.Collections.Generic.IComparer<OperationNote>
		{
			public SorterMode SorterMode;
			public proceduresComparer()
			{ }
			public proceduresComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation_note> Membres
			int System.Collections.Generic.IComparer<OperationNote>.Compare(OperationNote x, OperationNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.procedures.CompareTo(x.procedures);
				}
				else
				{
					return x.procedures.CompareTo(y.procedures);
				}
			}
			#endregion
		}
		public class RemarksComparer : System.Collections.Generic.IComparer<OperationNote>
		{
			public SorterMode SorterMode;
			public RemarksComparer()
			{ }
			public RemarksComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation_note> Membres
			int System.Collections.Generic.IComparer<OperationNote>.Compare(OperationNote x, OperationNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.Remarks.CompareTo(x.Remarks);
				}
				else
				{
					return x.Remarks.CompareTo(y.Remarks);
				}
			}
			#endregion
		}
		public class is_submitComparer : System.Collections.Generic.IComparer<OperationNote>
		{
			public SorterMode SorterMode;
			public is_submitComparer()
			{ }
			public is_submitComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation_note> Membres
			int System.Collections.Generic.IComparer<OperationNote>.Compare(OperationNote x, OperationNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.is_submit.CompareTo(x.is_submit);
				}
				else
				{
					return x.is_submit.CompareTo(y.is_submit);
				}
			}
			#endregion
		}
		public class is_receivedComparer : System.Collections.Generic.IComparer<OperationNote>
		{
			public SorterMode SorterMode;
			public is_receivedComparer()
			{ }
			public is_receivedComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation_note> Membres
			int System.Collections.Generic.IComparer<OperationNote>.Compare(OperationNote x, OperationNote y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.is_received.CompareTo(x.is_received);
				}
				else
				{
					return x.is_received.CompareTo(y.is_received);
				}
			}
			#endregion
		}
	}
}
