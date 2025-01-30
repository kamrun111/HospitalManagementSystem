using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Operation
	{
		private int _operation_id;

		public int operation_id
		{
			get { return _operation_id; }
			set { _operation_id = value; }
		}

		private string _operation_name;

		public string operation_name
		{
			get { return _operation_name; }
			set { _operation_name = value; }
		}

		private string _operation_procedure;

		public string operation_procedure
		{
			get { return _operation_procedure; }
			set { _operation_procedure = value; }
		}

        private Nullable<decimal> _operation_charge;

        public Nullable<decimal> operation_charge
        {
            get { return _operation_charge; }
            set { _operation_charge = value; }
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


		public Operation()
		{ }

		public Operation(int operation_id,string operation_name,string operation_procedure,Nullable<decimal>operation_charge)
		{
			this.operation_id = operation_id;
			this.operation_name = operation_name;
			this.operation_procedure = operation_procedure;
            this.operation_charge = operation_charge;
		}

		public override string ToString()
		{
			return "operation_id = " + operation_id.ToString() + ",operation_name = " + operation_name + ",operation_procedure = " + operation_procedure+",operation_charge="+operation_charge.ToString();
		}

		public class operation_idComparer : System.Collections.Generic.IComparer<Operation>
		{
			public SorterMode SorterMode;
			public operation_idComparer()
			{ }
			public operation_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation> Membres
			int System.Collections.Generic.IComparer<Operation>.Compare(Operation x, Operation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.operation_id.CompareTo(x.operation_id);
				}
				else
				{
					return x.operation_id.CompareTo(y.operation_id);
				}
			}
			#endregion
		}
		public class operation_nameComparer : System.Collections.Generic.IComparer<Operation>
		{
			public SorterMode SorterMode;
			public operation_nameComparer()
			{ }
			public operation_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation> Membres
			int System.Collections.Generic.IComparer<Operation>.Compare(Operation x, Operation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.operation_name.CompareTo(x.operation_name);
				}
				else
				{
					return x.operation_name.CompareTo(y.operation_name);
				}
			}
			#endregion
		}
		public class operation_procedureComparer : System.Collections.Generic.IComparer<Operation>
		{
			public SorterMode SorterMode;
			public operation_procedureComparer()
			{ }
			public operation_procedureComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<operation> Membres
			int System.Collections.Generic.IComparer<Operation>.Compare(Operation x, Operation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.operation_procedure.CompareTo(x.operation_procedure);
				}
				else
				{
					return x.operation_procedure.CompareTo(y.operation_procedure);
				}
			}
			#endregion
		}
	}
}
