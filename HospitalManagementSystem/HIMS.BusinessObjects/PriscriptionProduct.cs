using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class PriscriptionProduct
	{
        private int _prescription_product_id;

        public int prescription_product_id
        {
            get { return _prescription_product_id; }
            set { _prescription_product_id = value; }
        }

        private string _product;

        public string product
        {
            get { return _product; }
            set { _product = value; }
        }

        private string _generic_name;

        public string generic_name
        {
            get { return _generic_name; }
            set { _generic_name = value; }
        }

        private Nullable<int> _product_category_id;

        public Nullable<int> product_category_id
        {
            get { return _product_category_id; }
            set { _product_category_id = value; }
        }

        private Nullable<int> _product_type_id;

        public Nullable<int> product_type_id
        {
            get { return _product_type_id; }
            set { _product_type_id = value; }
        }

        private Nullable<int> _unit_id;

        public Nullable<int> unit_id
        {
            get { return _unit_id; }
            set { _unit_id = value; }
        }

        private Nullable<Decimal> _default_sales_price;

        public Nullable<Decimal> default_sales_price
        {
            get { return _default_sales_price; }
            set { _default_sales_price = value; }
        }

        private Nullable<int> _re_order_level;

        public Nullable<int> re_order_level
        {
            get { return _re_order_level; }
            set { _re_order_level = value; }
        }

        private Nullable<int> _consider_level;

        public Nullable<int> consider_level
        {
            get { return _consider_level; }
            set { _consider_level = value; }
        }

        private Nullable<int> _current_stock;

        public Nullable<int> current_stock
        {
            get { return _current_stock; }
            set { _current_stock = value; }
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

        public PriscriptionProduct()
        { }

        public PriscriptionProduct(int prescription_product_id, string product, string generic_name, Nullable<int> product_category_id, Nullable<int> product_type_id, Nullable<int> unit_id, Nullable<Decimal> default_sales_price, Nullable<int> re_order_level, Nullable<int> consider_level, Nullable<int> current_stock, Nullable<int> store_id, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.prescription_product_id = prescription_product_id;
            this.product = product;
            this.generic_name = generic_name;
            this.product_category_id = product_category_id;
            this.product_type_id = product_type_id;
            this.unit_id = unit_id;
            this.default_sales_price = default_sales_price;
            this.re_order_level = re_order_level;
            this.consider_level = consider_level;
            this.current_stock = current_stock;
            this.store_id = store_id;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        }

        public override string ToString()
        {
            return "prescription_product_id = " + prescription_product_id.ToString() + ",product = " + product + ",generic_name = " + generic_name + ",product_category_id = " + product_category_id.ToString() + ",product_type_id = " + product_type_id.ToString() + ",unit_id = " + unit_id.ToString() + ",default_sales_price = " + default_sales_price.ToString() + ",re_order_level = " + re_order_level.ToString() + ",consider_level = " + consider_level.ToString() + ",current_stock=" + current_stock.ToString() + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class prescription_product_idComparer : System.Collections.Generic.IComparer<PriscriptionProduct>
        {
            public SorterMode SorterMode;
            public prescription_product_idComparer()
            { }
            public prescription_product_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Product> Membres
            int System.Collections.Generic.IComparer<PriscriptionProduct>.Compare(PriscriptionProduct x, PriscriptionProduct y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.prescription_product_id.CompareTo(x.prescription_product_id);
                }
                else
                {
                    return x.prescription_product_id.CompareTo(y.prescription_product_id);
                }
            }
            #endregion
        }
        public class productComparer : System.Collections.Generic.IComparer<PriscriptionProduct>
        {
            public SorterMode SorterMode;
            public productComparer()
            { }
            public productComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Product> Membres
            int System.Collections.Generic.IComparer<PriscriptionProduct>.Compare(PriscriptionProduct x, PriscriptionProduct y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.product.CompareTo(x.product);
                }
                else
                {
                    return x.product.CompareTo(y.product);
                }
            }
            #endregion
        }
        public class generic_nameComparer : System.Collections.Generic.IComparer<PriscriptionProduct>
        {
            public SorterMode SorterMode;
            public generic_nameComparer()
            { }
            public generic_nameComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<Product> Membres
            int System.Collections.Generic.IComparer<PriscriptionProduct>.Compare(PriscriptionProduct x, PriscriptionProduct y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.generic_name.CompareTo(x.generic_name);
                }
                else
                {
                    return x.generic_name.CompareTo(y.generic_name);
                }
            }
            #endregion
        }
	}
}
