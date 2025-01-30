using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class ReAgentItem
	{
		private int _re_agent_item_id;

		public int re_agent_item_id
		{
			get { return _re_agent_item_id; }
			set { _re_agent_item_id = value; }
		}

		private Nullable<int> _product_id;

		public Nullable<int> product_id
		{
			get { return _product_id; }
			set { _product_id = value; }
		}

        private Nullable<int> _test_item_id;

		public Nullable<int> test_item_id
		{
			get { return _test_item_id; }
			set { _test_item_id = value; }
		}

        private Nullable<decimal> _required_qty;

		public Nullable<decimal> required_qty
		{
			get { return _required_qty; }
			set { _required_qty = value; }
		}

        private Nullable<int> _unit_id;

		public Nullable<int> unit_id
		{
			get { return _unit_id; }
			set { _unit_id = value; }
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

		private Nullable<DateTime> _recore_modified_date;

		public Nullable<DateTime> recore_modified_date
		{
			get { return _recore_modified_date; }
			set { _recore_modified_date = value; }
		}

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}

		public ReAgentItem()
		{ }

        public ReAgentItem(int re_agent_item_id, Nullable<int> product_id, Nullable<int> test_item_id, Nullable<decimal> required_qty, Nullable<int> unit_id, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> recore_modified_date, Nullable<int> record_modified_by)
		{

            this.re_agent_item_id = re_agent_item_id;
            this.product_id = product_id;
            this.test_item_id = test_item_id;
            this.required_qty = required_qty;
            this.unit_id = unit_id;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.recore_modified_date = recore_modified_date;
            this.record_modified_by = record_modified_by;
		}

        public override string ToString()
        {
            return "re_agent_item_id = " + re_agent_item_id.ToString() + ",product_id = " + product_id.ToString() + ",test_item_id = " + test_item_id.ToString() + ",required_qty = " + required_qty.ToString() + ",unit_id = " + unit_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",recore_modified_date = " + recore_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class re_agent_item_idComparer : System.Collections.Generic.IComparer<ReAgentItem>
        {
            public SorterMode SorterMode;
            public re_agent_item_idComparer()
            { }
            public re_agent_item_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<ReAgentItem> Membres
            int System.Collections.Generic.IComparer<ReAgentItem>.Compare(ReAgentItem x, ReAgentItem y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.re_agent_item_id.CompareTo(x.re_agent_item_id);
                }
                else
                {
                    return x.re_agent_item_id.CompareTo(y.re_agent_item_id);
                }
            }
            #endregion
        }
       
	}
}
