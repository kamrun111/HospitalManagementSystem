using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OPDSalesProduct
    {
        private int _opd_sales_product_id;

        public int opd_sales_product_id
        {
            get { return _opd_sales_product_id; }
            set { _opd_sales_product_id = value; }
        }

        private int _opd_sales_id;

        public int opd_sales_id
        {
            get { return _opd_sales_id; }
            set { _opd_sales_id = value; }
        }

        private int _product_id;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        private int _sales_qty;

        public int sales_qty
        {
            get { return _sales_qty; }
            set { _sales_qty = value; }
        }

        private decimal  _unit_sales_price;

        public decimal unit_sales_price
        {
            get { return _unit_sales_price; }
            set { _unit_sales_price = value; }
        }

        private Nullable<DateTime> _record_created_date;

        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }

        private Nullable<DateTime> _record_modified_date;

        public Nullable<DateTime> record_modified_date
        {
            get { return _record_modified_date; }
            set { _record_modified_date = value; }
        }

        private int _record_created_by;

        public int record_created_by
        {
            get { return _record_created_by; }
            set { _record_created_by = value; }
        }

        private int _record_modified_by;

        public int record_modified_by
        {
            get { return _record_modified_by; }
            set { _record_modified_by = value; }
        }

        public OPDSalesProduct()
		{ }

        public OPDSalesProduct(int opd_sales_product_id, int opd_sales_id, int product_id, int sales_qty, decimal unit_sales_price,Nullable<DateTime> record_created_date, int record_created_by, Nullable<DateTime> record_modified_date, int record_modified_by)
		{
            this.opd_sales_product_id = opd_sales_product_id;
            this.opd_sales_id = opd_sales_id;
            this.product_id = product_id;
            this.sales_qty = sales_qty;
            this.unit_sales_price = unit_sales_price;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "opd_sales_product_id = " + opd_sales_product_id.ToString() + ",opd_sales_id = " + opd_sales_id.ToString() + ",product_id = " + product_id.ToString() + ",sales_qty = " + sales_qty.ToString() + ",unit_sales_price = " + unit_sales_price.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ", record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

        public class opd_sales_product_idComparer : System.Collections.Generic.IComparer<OPDSalesProduct>
        {
            public SorterMode SorterMode;
            public opd_sales_product_idComparer()
            { }
            public opd_sales_product_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<opdSalesProduct> Membres
            int System.Collections.Generic.IComparer<OPDSalesProduct>.Compare(OPDSalesProduct x, OPDSalesProduct y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.opd_sales_product_id.CompareTo(x.opd_sales_product_id);
                }
                else
                {
                    return x.opd_sales_product_id.CompareTo(y.opd_sales_product_id);
                }
            }
            #endregion
        }
	
    }
}
