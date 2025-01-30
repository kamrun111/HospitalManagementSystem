using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class SalesProduct
	{
        private int _sales_product_id;

        public int sales_product_id
        {
            get { return _sales_product_id; }
            set { _sales_product_id = value; }
        }

        private Nullable<int> _sales_id;

        public Nullable<int> sales_id
        {
            get { return _sales_id; }
            set { _sales_id = value; }
        }

        private Nullable<int> _receive_id;

        public Nullable<int> receive_id
        {
            get { return _receive_id; }
            set { _receive_id = value; }
        }

        private Nullable<int> _product_id;

        public Nullable<int> product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        private string _barcode;

        public string barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        private Nullable<int> _sales_qty;

        public Nullable<int> sales_qty
        {
            get { return _sales_qty; }
            set { _sales_qty = value; }
        }

        private Nullable<int> _refund_qty;

        public Nullable<int> refund_qty
        {
            get { return _refund_qty; }
            set { _refund_qty = value; }
        }

        private Nullable<Decimal> _unit_price;

        public Nullable<Decimal> unit_price
        {
            get { return _unit_price; }
            set { _unit_price = value; }
        }

        private Nullable<Decimal> _total_price;

        public Nullable<Decimal> total_price
        {
            get { return _total_price; }
            set { _total_price = value; }
        }

        private Nullable<int> _store_id;

        public Nullable<int> store_id
        {
            get { return _store_id; }
            set { _store_id = value; }
        }

        private int _refund_receive_qty;

        public int refund_receive_qty
        {
            get { return _refund_receive_qty; }
            set { _refund_receive_qty = value; }
        }
        private int _refund_inv_no;

        public int refund_inv_no
        {
            get { return _refund_inv_no; }
            set { _refund_inv_no = value; }
        }

        private int _is_refund;

        public int is_refund
        {
            get { return _is_refund; }
            set { _is_refund = value; }
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

        public SalesProduct()
        { }

        public SalesProduct(int sales_product_id, Nullable<int> sales_id, Nullable<int> receive_id, Nullable<int> product_id, string barcode, Nullable<int> sales_qty, Nullable<int> refund_qty,int refund_receive_qty,int refund_inv_no,int is_refund, Nullable<Decimal> unit_price, Nullable<Decimal> total_price, Nullable<int> store_id, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.sales_product_id = sales_product_id;
            this.sales_id = sales_id;
            this.receive_id = receive_id;
            this.product_id = product_id;
            this.barcode = barcode;
            this.sales_qty = sales_qty;
            this.refund_qty = refund_qty;
            this.unit_price = unit_price;
            this.refund_receive_qty=refund_receive_qty;
            this.refund_inv_no = refund_inv_no;
            this.is_refund=is_refund;
            this.total_price = total_price;
            this.store_id = store_id;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        }
        
        public override string ToString()
        {
            return "sales_product_id = " + sales_product_id.ToString() + ",sales_id = " + sales_id.ToString() + ",receive_id = " + receive_id.ToString() + ",product_id = " + product_id.ToString() + ",barcode=" + barcode + ",sales_qty = " + sales_qty.ToString() + ",refund_qty = " + refund_qty.ToString() + ",refund_inv_no = " + refund_inv_no.ToString() + ",unit_price = " + unit_price.ToString() + ",total_price = " + total_price.ToString() + ",store_id = " + store_id.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }

        public class sales_product_idComparer : System.Collections.Generic.IComparer<SalesProduct>
        {
            public SorterMode SorterMode;
            public sales_product_idComparer()
            { }
            public sales_product_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<sales_product> Membres
            int System.Collections.Generic.IComparer<SalesProduct>.Compare(SalesProduct x, SalesProduct y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.sales_product_id.CompareTo(x.sales_product_id);
                }
                else
                {
                    return x.sales_product_id.CompareTo(y.sales_product_id);
                }
            }
            #endregion
        }
	}
}
