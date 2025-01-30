using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class ProductCategory
	{
		private int _product_category_id;

		public int product_category_id
		{
			get { return _product_category_id; }
			set { _product_category_id = value; }
		}

		private string _product_category;

		public string product_category
		{
			get { return _product_category; }
			set { _product_category = value; }
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

		public ProductCategory()
		{ }

		public ProductCategory(int product_category_id,string product_category,Nullable<int> store_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.product_category_id = product_category_id;
			this.product_category = product_category;
			this.store_id = store_id;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "product_category_id = " + product_category_id.ToString() + ",product_category = " + product_category + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class product_category_idComparer : System.Collections.Generic.IComparer<ProductCategory>
		{
			public SorterMode SorterMode;
			public product_category_idComparer()
			{ }
			public product_category_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<ProductCategory> Membres
			int System.Collections.Generic.IComparer<ProductCategory>.Compare(ProductCategory x, ProductCategory y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.product_category_id.CompareTo(x.product_category_id);
				}
				else
				{
					return x.product_category_id.CompareTo(y.product_category_id);
				}
			}
			#endregion
		}
		public class product_categoryComparer : System.Collections.Generic.IComparer<ProductCategory>
		{
			public SorterMode SorterMode;
			public product_categoryComparer()
			{ }
			public product_categoryComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<ProductCategory> Membres
			int System.Collections.Generic.IComparer<ProductCategory>.Compare(ProductCategory x, ProductCategory y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.product_category.CompareTo(x.product_category);
				}
				else
				{
                    return x.product_category.CompareTo(y.product_category);
				}
			}
			#endregion
		}
	}
}
