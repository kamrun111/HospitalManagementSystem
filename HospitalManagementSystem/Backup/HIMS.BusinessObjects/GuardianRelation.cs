using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class GuardianRelation
	{
		private int _guardian_relation_id;

		public int guardian_relation_id
		{
			get { return _guardian_relation_id; }
			set { _guardian_relation_id = value; }
		}

		private string _guardian_relation;

		public string guardian_relation
		{
			get { return _guardian_relation; }
			set { _guardian_relation = value; }
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

		public GuardianRelation()
		{ }

		public GuardianRelation(int guardian_relation_id,string guardian_relation,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.guardian_relation_id = guardian_relation_id;
			this.guardian_relation = guardian_relation;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "guardian_relation_id = " + guardian_relation_id.ToString() + ",guardian_relation = " + guardian_relation + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class guardian_relation_idComparer : System.Collections.Generic.IComparer<GuardianRelation>
		{
			public SorterMode SorterMode;
			public guardian_relation_idComparer()
			{ }
			public guardian_relation_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<GuardianRelation> Membres
			int System.Collections.Generic.IComparer<GuardianRelation>.Compare(GuardianRelation x, GuardianRelation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.guardian_relation_id.CompareTo(x.guardian_relation_id);
				}
				else
				{
					return x.guardian_relation_id.CompareTo(y.guardian_relation_id);
				}
			}
			#endregion
		}
		public class guardian_relationComparer : System.Collections.Generic.IComparer<GuardianRelation>
		{
			public SorterMode SorterMode;
			public guardian_relationComparer()
			{ }
			public guardian_relationComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<GuardianRelation> Membres
			int System.Collections.Generic.IComparer<GuardianRelation>.Compare(GuardianRelation x, GuardianRelation y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.guardian_relation.CompareTo(x.guardian_relation);
				}
				else
				{
                    return x.guardian_relation.CompareTo(y.guardian_relation);
				}
			}
			#endregion
		}
	}
}
