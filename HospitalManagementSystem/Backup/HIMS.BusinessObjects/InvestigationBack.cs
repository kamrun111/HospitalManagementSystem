using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class InvestigationBack
	{
        private int _investigation_back_id;

        public int investigation_back_id
		{
            get { return _investigation_back_id; }
            set { _investigation_back_id = value; }
		}

        private string _department;

        public string department
		{
            get { return _department; }
            set { _department = value; }
		}

        private string _groups;

        public string groups
        {
            get { return _groups; }
            set { _groups = value; }
        }

        private string _test_item;

        public string test_item
        {
            get { return _test_item; }
            set { _test_item = value; }
        }

        private Nullable<decimal> _charge;

        public Nullable<decimal> charge
        {
            get { return _charge; }
            set { _charge = value; }
        }

        private Nullable<int> _d_id;

        public Nullable<int> d_id
        {
            get { return _d_id; }
            set { _d_id = value; }
        }

        private Nullable<int> _g_id;

        public Nullable<int> g_id
        {
            get { return _g_id; }
            set { _g_id = value; }
        }

        private Nullable<int> _t_id;

        public Nullable<int> t_id
        {
            get { return _t_id; }
            set { _t_id = value; }
        }

        private Nullable<int> _reedoc_id;

        public Nullable<int> reedoc_id
        {
            get { return _reedoc_id; }
            set { _reedoc_id = value; }
        }

        private string _reffered_by;

        public string reffered_by
        {
            get { return _reffered_by; }
            set { _reffered_by = value; }
        }

        private Nullable<int> _specimen_id;

        public Nullable<int> specimen_id
        {
            get { return _specimen_id; }
            set { _specimen_id = value; }
        }

		private Nullable<DateTime> _record_created_date;

		public Nullable<DateTime> record_created_date
		{
			get { return _record_created_date; }
			set { _record_created_date = value; }
		}
        		
		public InvestigationBack()
		{ }

        public InvestigationBack(int investigation_back_id, string department, string groups, string test_item, Nullable<decimal> charge, Nullable<int> d_id, Nullable<int> g_id, Nullable<int> t_id, Nullable<int> reedoc_id, string reffered_by, Nullable<int> specimen_id)
		{
            this.investigation_back_id = investigation_back_id;
			this.department = department;
            this.groups = groups;
            this.test_item = test_item;
            this.charge = charge;
            this.d_id = d_id;
            this.g_id = g_id;
            this.t_id = t_id;
            this.reedoc_id = reedoc_id;
            this.reffered_by = reffered_by;
            this.specimen_id = specimen_id;
		}

		public override string ToString()
		{
            return "investigation_back_id = " + investigation_back_id.ToString() + ",department = " + department + ",groups = " + groups + ",test_item = " + test_item + ",charge = " + charge.ToString() + ",d_id = " + d_id.ToString() + ",g_id = " + g_id.ToString() + ",t_id=" + t_id.ToString() + ",reedoc_id=" + reedoc_id.ToString() + ",reffered_by=" + reffered_by + ",specimen_id=" + specimen_id.ToString();
		}

        public class investigation_back_idComparer : System.Collections.Generic.IComparer<InvestigationBack>
		{
			public SorterMode SorterMode;
			public investigation_back_idComparer()
			{ }
            public investigation_back_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<InvestigationBack> Membres
            int System.Collections.Generic.IComparer<InvestigationBack>.Compare(InvestigationBack x, InvestigationBack y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.investigation_back_id.CompareTo(x.investigation_back_id);
				}
				else
				{
                    return x.investigation_back_id.CompareTo(y.investigation_back_id);
				}
			}
			#endregion
		}
        public class departmentComparer : System.Collections.Generic.IComparer<InvestigationBack>
		{
			public SorterMode SorterMode;
			public departmentComparer()
			{ }
			public departmentComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<InvestigationBack> Membres
            int System.Collections.Generic.IComparer<InvestigationBack>.Compare(InvestigationBack x, InvestigationBack y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.department.CompareTo(x.department);
				}
				else
				{
                    return x.department.CompareTo(y.department);
				}
			}
			#endregion
		}
	}
}
