using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Requisition
	{
		private int _requisition_id;

		public int requisition_id
		{
			get { return _requisition_id; }
			set { _requisition_id = value; }
		}

		private string _requisition_no;

		public string requisition_no
		{
			get { return _requisition_no; }
			set { _requisition_no = value; }
		}

		private Nullable<int> _department_id;

		public Nullable<int> department_id
		{
			get { return _department_id; }
			set { _department_id = value; }
		}

		private Nullable<int> _product_type_id;

		public Nullable<int> product_type_id
		{
			get { return _product_type_id; }
			set { _product_type_id = value; }
		}

		private Nullable<int> _store_id;

		public Nullable<int> store_id
		{
			get { return _store_id; }
			set { _store_id = value; }
		}

		private Nullable<DateTime> _requisition_date;

		public Nullable<DateTime> requisition_date
		{
			get { return _requisition_date; }
			set { _requisition_date = value; }
		}

        //private Nullable<DateTime> _record_created_date;

        //public Nullable<DateTime> record_created_date
        //{
        //    get { return _record_created_date; }
        //    set { _record_created_date = value; }
        //}

		private Nullable<int> _record_created_by;

		public Nullable<int> record_created_by
		{
			get { return _record_created_by; }
			set { _record_created_by = value; }
		}

        //private Nullable<DateTime> _record_modified_date;

        //public Nullable<DateTime> record_modified_date
        //{
        //    get { return _record_modified_date; }
        //    set { _record_modified_date = value; }
        //}

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}

		public Requisition()
		{ }

		public Requisition(int requisition_id,string requisition_no,Nullable<int> department_id,Nullable<int> product_type_id,Nullable<int> store_id,Nullable<DateTime> requisition_date,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.requisition_id = requisition_id;
			this.requisition_no = requisition_no;
			this.department_id = department_id;
			this.product_type_id = product_type_id;
			this.store_id = store_id;
			this.requisition_date = requisition_date;
			this.record_created_by = record_created_by;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "requisition_id = " + requisition_id.ToString() + ",requisition_no = " + requisition_no + ",department_id = " + department_id.ToString() + ",product_type_id = " + product_type_id.ToString() + ",store_id = " + store_id.ToString() + ",requisition_date = " + requisition_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class requisition_idComparer : System.Collections.Generic.IComparer<Requisition>
		{
			public SorterMode SorterMode;
			public requisition_idComparer()
			{ }
			public requisition_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<requisition> Membres
			int System.Collections.Generic.IComparer<Requisition>.Compare(Requisition x, Requisition y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.requisition_id.CompareTo(x.requisition_id);
				}
				else
				{
					return x.requisition_id.CompareTo(y.requisition_id);
				}
			}
			#endregion
		}
		public class requisition_noComparer : System.Collections.Generic.IComparer<Requisition>
		{
			public SorterMode SorterMode;
			public requisition_noComparer()
			{ }
			public requisition_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<requisition> Membres
			int System.Collections.Generic.IComparer<Requisition>.Compare(Requisition x, Requisition y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.requisition_no.CompareTo(x.requisition_no);
				}
				else
				{
					return x.requisition_no.CompareTo(y.requisition_no);
				}
			}
			#endregion
		}
	}
}
