using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InvestigationTest
	{
		private int _investigation_test_id;

		public int investigation_test_id
		{
			get { return _investigation_test_id; }
			set { _investigation_test_id = value; }
		}

		private Nullable<int> _investigation_id;

		public Nullable<int> investigation_id
		{
			get { return _investigation_id; }
			set { _investigation_id = value; }
		}

		private Nullable<int> _test_department_id;

		public Nullable<int> test_department_id
		{
			get { return _test_department_id; }
			set { _test_department_id = value; }
		}

		private Nullable<int> _test_group_id;

		public Nullable<int> test_group_id
		{
			get { return _test_group_id; }
			set { _test_group_id = value; }
		}

		private Nullable<int> _test_item_id;

		public Nullable<int> test_item_id
		{
			get { return _test_item_id; }
			set { _test_item_id = value; }
		}

        private Nullable<int> _test_element_id;

        public Nullable<int> test_element_id
        {
            get { return _test_element_id; }
            set { _test_element_id = value; }
        }
        private Nullable<int> _order_no;

        public Nullable<int> order_no
        {
            get { return _order_no; }
            set { _order_no = value; }
        }
        private Nullable<int> _sample_serial_no;

        public Nullable<int> sample_serial_no
        {
            get { return _sample_serial_no; }
            set { _sample_serial_no = value; }
        }

		private Nullable<Decimal> _charge;

		public Nullable<Decimal> charge
		{
			get { return _charge; }
			set { _charge = value; }
		}
        private Nullable<Decimal> _vat;

        public Nullable<Decimal> vat
        {
            get { return _vat; }
            set { _vat = value; }
        }

		private string _result;

		public string result
		{
			get { return _result; }
			set { _result = value; }
		}

		private Nullable<int> _reffered_doctors_id;

		public Nullable<int> reffered_doctors_id
		{
			get { return _reffered_doctors_id; }
			set { _reffered_doctors_id = value; }
		}

		private Nullable<DateTime> _delivery_date;

		public Nullable<DateTime> delivery_date
		{
			get { return _delivery_date; }
			set { _delivery_date = value; }
		}

		private Nullable<int> _report_done;

        public Nullable<int> report_done
		{
			get { return _report_done; }
			set { _report_done = value; }
		}

        private Nullable<int> _delivered;

        public Nullable<int> delivered
		{
			get { return _delivered; }
			set { _delivered = value; }
		}

		private Nullable<int> _user_id;

		public Nullable<int> user_id
		{
			get { return _user_id; }
			set { _user_id = value; }
		}

		private Nullable<DateTime> _actual_delivery_date;

		public Nullable<DateTime> actual_delivery_date
		{
			get { return _actual_delivery_date; }
			set { _actual_delivery_date = value; }
		}

        private Nullable<int> _sticker_id;

        public Nullable<int> sticker_id
        {
            get { return _sticker_id; }
            set { _sticker_id = value; }
        }

        private Nullable<int> _for_baby;

        public Nullable<int> for_baby
        {
            get { return _for_baby; }
            set { _for_baby = value; }
        }

        private Nullable<int> _sample_collected;

        public Nullable<int> sample_collected
		{
			get { return _sample_collected; }
			set { _sample_collected = value; }
		}

		private Nullable<DateTime> _sample_collection_date;

		public Nullable<DateTime> sample_collection_date
		{
			get { return _sample_collection_date; }
			set { _sample_collection_date = value; }
		}

        private Nullable<int> _sticker_printed;

        public Nullable<int> sticker_printed
        {
            get { return _sticker_printed; }
            set { _sticker_printed = value; }
        }

        private Nullable<int> _is_cancel;

        public Nullable<int> is_cancel
        {
            get { return _is_cancel; }
            set { _is_cancel = value; }
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

		public InvestigationTest()
		{ }

        public InvestigationTest(int investigation_test_id, Nullable<int> investigation_id, Nullable<int> test_department_id, Nullable<int> test_group_id, Nullable<int> test_item_id, Nullable<int> test_element_id, Nullable<int> order_no, Nullable<int> sample_serial_no, Nullable<Decimal> charge, string result, Nullable<int> reffered_doctors_id, Nullable<DateTime> delivery_date, Nullable<SByte> report_done, Nullable<SByte> delivered, Nullable<int> user_id, Nullable<DateTime> actual_delivery_date, Nullable<int> sticker_id, Nullable<int> for_baby, Nullable<SByte> sample_collected, Nullable<DateTime> sample_collection_date, Nullable<SByte> sticker_printed, Nullable<SByte> is_cancel, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.investigation_test_id = investigation_test_id;
			this.investigation_id = investigation_id;
			this.test_department_id = test_department_id;
			this.test_group_id = test_group_id;
			this.test_item_id = test_item_id;
            this.test_element_id = test_element_id;
            this.order_no = order_no;
            this.sample_serial_no = sample_serial_no;
			this.charge = charge;
            this.vat = vat;
			this.result = result;
			this.reffered_doctors_id = reffered_doctors_id;
			this.delivery_date = delivery_date;
			this.report_done = report_done;
			this.delivered = delivered;
			this.user_id = user_id;
			this.actual_delivery_date = actual_delivery_date;
            this.sticker_id = sticker_id;
            this.for_baby = for_baby;
			this.sample_collected = sample_collected;
			this.sample_collection_date = sample_collection_date;
            this.sticker_printed = sticker_printed;
            this.is_cancel = is_cancel;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "investigation_test_id = " + investigation_test_id.ToString() + ",investigation_id = " + investigation_id.ToString() + ",test_department_id = " + test_department_id.ToString() + ",test_group_id = " + test_group_id.ToString() + ",test_item_id = " + test_item_id.ToString() + ",test_element_id = " + test_element_id.ToString() + ",order_no=" + order_no .ToString()+ ",sample_serial_no=" + sample_serial_no.ToString() + ",charge = " + charge.ToString() + ",vat = " + vat.ToString() + ",result = " + result + ",reffered_doctors_id = " + reffered_doctors_id.ToString() + ",delivery_date = " + delivery_date.ToString() + ",report_done = " + report_done.ToString() + ",delivered = " + delivered.ToString() + ",user_id = " + user_id.ToString() + ",actual_delivery_date = " + actual_delivery_date.ToString() + ",sticker_id=" + sticker_id.ToString() + ",for_baby=" + for_baby.ToString() + ",sample_collected = " + sample_collected.ToString() + ",sample_collection_date = " + sample_collection_date.ToString() + ",sticker_printed = " + sticker_printed.ToString() + ",is_cancel = " + is_cancel.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class investigation_test_idComparer : System.Collections.Generic.IComparer<InvestigationTest>
		{
			public SorterMode SorterMode;
			public investigation_test_idComparer()
			{ }
			public investigation_test_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<investigation_test> Membres
			int System.Collections.Generic.IComparer<InvestigationTest>.Compare(InvestigationTest x, InvestigationTest y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.investigation_test_id.CompareTo(x.investigation_test_id);
				}
				else
				{
					return x.investigation_test_id.CompareTo(y.investigation_test_id);
				}
			}
			#endregion
		}
		public class resultComparer : System.Collections.Generic.IComparer<InvestigationTest>
		{
			public SorterMode SorterMode;
			public resultComparer()
			{ }
			public resultComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<investigation_test> Membres
			int System.Collections.Generic.IComparer<InvestigationTest>.Compare(InvestigationTest x, InvestigationTest y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.result.CompareTo(x.result);
				}
				else
				{
					return x.result.CompareTo(y.result);
				}
			}
			#endregion
		}
	}
}
