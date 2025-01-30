using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Supplier
	{
		private int _supplier_id;

		public int supplier_id
		{
			get { return _supplier_id; }
			set { _supplier_id = value; }
		}

		private string _supplier_name;

		public string supplier_name
		{
			get { return _supplier_name; }
			set { _supplier_name = value; }
		}

		private string _contact_person;

		public string contact_person
		{
			get { return _contact_person; }
			set { _contact_person = value; }
		}

		private string _contact_no;

		public string contact_no
		{
			get { return _contact_no; }
			set { _contact_no = value; }
		}

		private string _fax_no;

		public string fax_no
		{
			get { return _fax_no; }
			set { _fax_no = value; }
		}

		private string _address;

		public string address
		{
			get { return _address; }
			set { _address = value; }
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

		public Supplier()
		{ }

		public Supplier(int supplier_id,string supplier_name,string contact_person,string contact_no,string fax_no,string address,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.supplier_id = supplier_id;
			this.supplier_name = supplier_name;
			this.contact_person = contact_person;
			this.contact_no = contact_no;
			this.fax_no = fax_no;
			this.address = address;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "supplier_id = " + supplier_id.ToString() + ",supplier_name = " + supplier_name + ",contact_person = " + contact_person + ",contact_no = " + contact_no + ",fax_no = " + fax_no + ",address = " + address + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class supplier_idComparer : System.Collections.Generic.IComparer<Supplier>
		{
			public SorterMode SorterMode;
			public supplier_idComparer()
			{ }
			public supplier_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<supplier> Membres
			int System.Collections.Generic.IComparer<Supplier>.Compare(Supplier x, Supplier y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.supplier_id.CompareTo(x.supplier_id);
				}
				else
				{
					return x.supplier_id.CompareTo(y.supplier_id);
				}
			}
			#endregion
		}
		public class supplier_nameComparer : System.Collections.Generic.IComparer<Supplier>
		{
			public SorterMode SorterMode;
			public supplier_nameComparer()
			{ }
			public supplier_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<supplier> Membres
			int System.Collections.Generic.IComparer<Supplier>.Compare(Supplier x, Supplier y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.supplier_name.CompareTo(x.supplier_name);
				}
				else
				{
					return x.supplier_name.CompareTo(y.supplier_name);
				}
			}
			#endregion
		}
		public class contact_personComparer : System.Collections.Generic.IComparer<Supplier>
		{
			public SorterMode SorterMode;
			public contact_personComparer()
			{ }
			public contact_personComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<supplier> Membres
			int System.Collections.Generic.IComparer<Supplier>.Compare(Supplier x, Supplier y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.contact_person.CompareTo(x.contact_person);
				}
				else
				{
					return x.contact_person.CompareTo(y.contact_person);
				}
			}
			#endregion
		}
		public class contact_noComparer : System.Collections.Generic.IComparer<Supplier>
		{
			public SorterMode SorterMode;
			public contact_noComparer()
			{ }
			public contact_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<supplier> Membres
			int System.Collections.Generic.IComparer<Supplier>.Compare(Supplier x, Supplier y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.contact_no.CompareTo(x.contact_no);
				}
				else
				{
					return x.contact_no.CompareTo(y.contact_no);
				}
			}
			#endregion
		}
		public class fax_noComparer : System.Collections.Generic.IComparer<Supplier>
		{
			public SorterMode SorterMode;
			public fax_noComparer()
			{ }
			public fax_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<supplier> Membres
			int System.Collections.Generic.IComparer<Supplier>.Compare(Supplier x, Supplier y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.fax_no.CompareTo(x.fax_no);
				}
				else
				{
					return x.fax_no.CompareTo(y.fax_no);
				}
			}
			#endregion
		}
		public class addressComparer : System.Collections.Generic.IComparer<Supplier>
		{
			public SorterMode SorterMode;
			public addressComparer()
			{ }
			public addressComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<supplier> Membres
			int System.Collections.Generic.IComparer<Supplier>.Compare(Supplier x, Supplier y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.address.CompareTo(x.address);
				}
				else
				{
					return x.address.CompareTo(y.address);
				}
			}
			#endregion
		}
	}
}
