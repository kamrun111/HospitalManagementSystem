using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class ProductType
	{
		private int _product_type_id;

		public int product_type_id
		{
			get { return _product_type_id; }
			set { _product_type_id = value; }
		}

		private string _product_type;

		public string product_type
		{
			get { return _product_type; }
			set { _product_type = value; }
		}

		private Nullable<int> _store_id;

		public Nullable<int> store_id
		{
			get { return _store_id; }
			set { _store_id = value; }
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

		public ProductType()
		{ }

		public ProductType(int product_type_id,string product_type,Nullable<int> store_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.product_type_id = product_type_id;
			this.product_type = product_type;
			this.store_id = store_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "product_type_id = " + product_type_id.ToString() + ",product_type = " + product_type + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class product_type_idComparer : System.Collections.Generic.IComparer<ProductType>
		{
			public SorterMode SorterMode;
			public product_type_idComparer()
			{ }
			public product_type_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<ProductType> Membres
			int System.Collections.Generic.IComparer<ProductType>.Compare(ProductType x, ProductType y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.product_type_id.CompareTo(x.product_type_id);
				}
				else
				{
					return x.product_type_id.CompareTo(y.product_type_id);
				}
			}
			#endregion
		}
		public class product_typeComparer : System.Collections.Generic.IComparer<ProductType>
		{
			public SorterMode SorterMode;
			public product_typeComparer()
			{ }
			public product_typeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<ProductType> Membres
			int System.Collections.Generic.IComparer<ProductType>.Compare(ProductType x, ProductType y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.product_type.CompareTo(x.product_type);
				}
				else
				{
                    return x.product_type.CompareTo(y.product_type);
				}
			}
			#endregion
		}
	}
}
