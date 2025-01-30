using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class IntakeSys
	{
		private int _intake_sys_id;

		public int intake_sys_id
		{
			get { return _intake_sys_id; }
			set { _intake_sys_id = value; }
		}

		private string _intake_sys;

		public string intake_sys
		{
			get { return _intake_sys; }
			set { _intake_sys = value; }
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

		public IntakeSys()
		{ }

		public IntakeSys(int intake_sys_id,string intake_sys,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.intake_sys_id = intake_sys_id;
			this.intake_sys = intake_sys;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "intake_sys_id = " + intake_sys_id.ToString() + ",intake_sys = " + intake_sys + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class intake_sys_idComparer : System.Collections.Generic.IComparer<IntakeSys>
		{
			public SorterMode SorterMode;
			public intake_sys_idComparer()
			{ }
			public intake_sys_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<IntakeSys> Membres
			int System.Collections.Generic.IComparer<IntakeSys>.Compare(IntakeSys x, IntakeSys y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.intake_sys_id.CompareTo(x.intake_sys_id);
				}
				else
				{
					return x.intake_sys_id.CompareTo(y.intake_sys_id);
				}
			}
			#endregion
		}
		public class intake_sysComparer : System.Collections.Generic.IComparer<IntakeSys>
		{
			public SorterMode SorterMode;
			public intake_sysComparer()
			{ }
			public intake_sysComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<IntakeSys> Membres
			int System.Collections.Generic.IComparer<IntakeSys>.Compare(IntakeSys x, IntakeSys y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.intake_sys.CompareTo(x.intake_sys);
				}
				else
				{
                    return x.intake_sys.CompareTo(y.intake_sys);
				}
			}
			#endregion
		}
	}
}
