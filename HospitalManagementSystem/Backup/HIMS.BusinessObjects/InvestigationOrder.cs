using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InvestigationOrder
	{
        private int _investigation_order_id;

        public int investigation_order_id
		{
            get { return _investigation_order_id; }
            set { _investigation_order_id = value; }
		}

        private Nullable<int> _investigation_id;

        public Nullable<int> investigation_id
        {
            get { return _investigation_id; }
            set { _investigation_id = value; }
        }

        private string _order_no;

        public string order_no
        {
            get { return _order_no; }
            set { _order_no = value; }
        }

        private Nullable<Decimal> _total_amount;

        public Nullable<Decimal> total_amount
        {
            get { return _total_amount; }
            set { _total_amount = value; }
        }

        private Nullable<Decimal> _discount;

        public Nullable<Decimal> discount
        {
            get { return _discount; }
            set { _discount = value; }
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

		public InvestigationOrder()
		{ }

        public InvestigationOrder(int investigation_order_id, Nullable<int> investigation_id, string order_no,Nullable<Decimal> total_amount,Nullable<Decimal> discount, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.investigation_order_id = investigation_order_id;
            this.investigation_id = investigation_id;
            this.order_no = order_no;
            this.total_amount = total_amount;
            this.discount = discount;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "investigation_order_id = " + investigation_order_id.ToString() + ",investigation_id = " + investigation_id.ToString() + ",order_no=" + order_no + ",total_amount=" + total_amount.ToString() + ",discount=" + discount.ToString()+ ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

        public class investigation_order_idComparer : System.Collections.Generic.IComparer<InvestigationOrder>
		{
			public SorterMode SorterMode;
			public investigation_order_idComparer()
			{ }
            public investigation_order_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<InvestigationOrder> Membres
            int System.Collections.Generic.IComparer<InvestigationOrder>.Compare(InvestigationOrder x, InvestigationOrder y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.investigation_order_id.CompareTo(x.investigation_order_id);
				}
				else
				{
                    return x.investigation_order_id.CompareTo(y.investigation_order_id);
				}
			}
			#endregion
		}
        //public class departmentComparer : System.Collections.Generic.IComparer<InvestigationOrder>
        //{
        //    public SorterMode SorterMode;
        //    public departmentComparer()
        //    { }
        //    public departmentComparer(SorterMode SorterMode)
        //    {
        //        this.SorterMode = SorterMode;
        //    }
        //    #region IComparer<Department> Membres
        //    int System.Collections.Generic.IComparer<Department>.Compare(Department x, Department y)
        //    {
        //        if (SorterMode == SorterMode.Ascending)
        //        {
        //            return y.department.CompareTo(x.department);
        //        }
        //        else
        //        {
        //            return x.department.CompareTo(y.department);
        //        }
        //    }
        //    #endregion
        //}
	}
}
