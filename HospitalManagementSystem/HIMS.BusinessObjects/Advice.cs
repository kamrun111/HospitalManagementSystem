using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Advice
	{
		private int _advice_id;

		public int advice_id
		{
			get { return _advice_id; }
			set { _advice_id = value; }
		}

        private string _advice_type;

        public string advice_type
		{
            get { return _advice_type; }
            set { _advice_type = value; }
		}

        private string _advice;

        public string advice
        {
            get { return _advice; }
            set { _advice = value; }
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
     
        private int _is_continue;

		public int is_continue
		{
			get { return _is_continue; }
			set { _is_continue = value; }
		}

		public Advice()
		{ }

		public Advice(int advice_id,string advice,string advice_type,int is_continue,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.advice_id = advice_id;
			this.advice = advice;
            this.advice_type = advice_type;
            this.is_continue = is_continue;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "advice_id = " + advice_id.ToString() + ",advice = " + advice + ",advice_type=" + advice_type + ",is_continue=" + is_continue.ToString() + ", record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class advice_idComparer : System.Collections.Generic.IComparer<Advice>
		{
			public SorterMode SorterMode;
			public advice_idComparer()
			{ }
			public advice_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Advice> Membres
			int System.Collections.Generic.IComparer<Advice>.Compare(Advice x, Advice y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.advice_id.CompareTo(x.advice_id);
				}
				else
				{
					return x.advice_id.CompareTo(y.advice_id);
				}
			}
			#endregion
		}
		public class adviceComparer : System.Collections.Generic.IComparer<Advice>
		{
			public SorterMode SorterMode;
			public adviceComparer()
			{ }
			public adviceComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Advice> Membres
			int System.Collections.Generic.IComparer<Advice>.Compare(Advice x, Advice y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.advice.CompareTo(x.advice);
				}
				else
				{
                    return x.advice.CompareTo(y.advice);
				}
			}
			#endregion
		}
	}
}
