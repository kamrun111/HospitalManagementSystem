using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class DosePerQuantity
	{
		private int _dose_p_quantity_id;

		public int dose_p_quantity_id
		{
			get { return _dose_p_quantity_id; }
			set { _dose_p_quantity_id = value; }
		}

		private string _dose_p_quantity;

		public string dose_p_quantity
		{
			get { return _dose_p_quantity; }
			set { _dose_p_quantity = value; }
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

		public DosePerQuantity()
		{ }

		public DosePerQuantity(int dose_p_quantity_id,string dose_p_quantity,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.dose_p_quantity_id = dose_p_quantity_id;
			this.dose_p_quantity = dose_p_quantity;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "dose_p_quantity_id = " + dose_p_quantity_id.ToString() + ",dose_p_quantity = " + dose_p_quantity + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class dose_p_quantity_idComparer : System.Collections.Generic.IComparer<DosePerQuantity>
		{
			public SorterMode SorterMode;
			public dose_p_quantity_idComparer()
			{ }
			public dose_p_quantity_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<DosePerQuantity> Membres
			int System.Collections.Generic.IComparer<DosePerQuantity>.Compare(DosePerQuantity x, DosePerQuantity y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.dose_p_quantity_id.CompareTo(x.dose_p_quantity_id);
				}
				else
				{
					return x.dose_p_quantity_id.CompareTo(y.dose_p_quantity_id);
				}
			}
			#endregion
		}
		public class dose_p_quantityComparer : System.Collections.Generic.IComparer<DosePerQuantity>
		{
			public SorterMode SorterMode;
			public dose_p_quantityComparer()
			{ }
			public dose_p_quantityComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<DosePerQuantity> Membres
            int System.Collections.Generic.IComparer<DosePerQuantity>.Compare(DosePerQuantity x, DosePerQuantity y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.dose_p_quantity.CompareTo(x.dose_p_quantity);
				}
				else
				{
                    return x.dose_p_quantity.CompareTo(y.dose_p_quantity);
				}
			}
			#endregion
		}
	}
}
