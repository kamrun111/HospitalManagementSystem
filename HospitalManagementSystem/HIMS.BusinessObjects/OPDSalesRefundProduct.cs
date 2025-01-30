using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OPDSalesRefundProduct
    {
         private int _opd_sales_refund_product_id;

        public int opd_sales_refund_product_id
        {
            get { return _opd_sales_refund_product_id; }
            set { _opd_sales_refund_product_id = value; }
        }

        private int _opd_sales_refund_id;

        public int opd_sales_refund_id
        {
            get { return _opd_sales_refund_id; }
            set { _opd_sales_refund_id = value; }
        }

        private int _product_id;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        private int _refund_qty;

        public int refund_qty
        {
            get { return _refund_qty; }
            set { _refund_qty = value; }
        }

     
        private decimal _unit_price;

        public decimal unit_price
        {
            get { return _unit_price; }
            set { _unit_price = value; }
        }

        private int _store_id;

        public int store_id
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

        private int _record_created_by;

        public int record_created_by
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

        private int _record_modified_by;

        public int record_modified_by
        {
            get { return _record_modified_by; }
            set { _record_modified_by = value; }
        }



      
        public OPDSalesRefundProduct()
		{ }

        public OPDSalesRefundProduct(int opd_sales_refund_product_id, int opd_sales_refund_id, int product_id, int refund_qty, decimal unit_price, int store_id, Nullable<DateTime> record_created_date, int record_created_by, Nullable<DateTime> record_modified_date, int record_modified_by)
        {
            this.opd_sales_refund_product_id = opd_sales_refund_product_id;
            this.opd_sales_refund_id = opd_sales_refund_id;
            this.product_id = product_id;
            this.refund_qty = refund_qty;
            this.unit_price = unit_price;
            this.store_id=store_id;
            this.record_created_date=record_created_date;
            this.record_created_by=record_created_by;
            this.record_modified_date=record_modified_date;
            this.record_modified_by=record_modified_by;

        }

        public override string ToString()
        {
            return "opd_sales_refund_product_id = " + opd_sales_refund_product_id.ToString() + ",opd_sales_refund_id = " + opd_sales_refund_id.ToString() + ",product_id=" + product_id.ToString() + ",refund_qty=" + refund_qty.ToString() + ",store_id=" + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class opd_sales_refund_product_idComparer : System.Collections.Generic.IComparer<OPDSalesRefundProduct>
        {
            public SorterMode SorterMode;
            public opd_sales_refund_product_idComparer()
            { }
            public opd_sales_refund_product_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<OPDSalesRefundProduct> Membres
            int System.Collections.Generic.IComparer<OPDSalesRefundProduct>.Compare(OPDSalesRefundProduct x, OPDSalesRefundProduct y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.opd_sales_refund_product_id.CompareTo(x.opd_sales_refund_product_id);
                }
                else
                {
                    return x.opd_sales_refund_product_id.CompareTo(y.opd_sales_refund_product_id);
                }
            }
            #endregion
        }


    }
}
