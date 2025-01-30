using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Sample
	{
        private int _sample_id;

        public int sample_id
		{
            get { return _sample_id; }
            set { _sample_id = value; }
		}

        private Nullable<int> _investigation_id;

        public Nullable<int> investigation_id
        {
            get { return _investigation_id; }
            set { _investigation_id = value; }
        }

        private string _sample_no;

        public string sample_no
        {
            get { return _sample_no; }
            set { _sample_no = value; }
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

		public Sample()
		{ }

        public Sample(int sample_id, Nullable<int> investigation_id, string sample_no, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
            this.sample_id = sample_id;
            this.investigation_id = investigation_id;
            this.sample_no = sample_no;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "sample_id = " + sample_id.ToString() + ",investigation_id = " + investigation_id.ToString() + ",sample_no=" + sample_no + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

        public class sample_idComparer : System.Collections.Generic.IComparer<Sample>
		{
			public SorterMode SorterMode;
			public sample_idComparer()
			{ }
            public sample_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<Sample> Membres
            int System.Collections.Generic.IComparer<Sample>.Compare(Sample x, Sample y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.sample_id.CompareTo(x.sample_id);
				}
				else
				{
                    return x.sample_id.CompareTo(y.sample_id);
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
