using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class AdjustmentProduct
    {
        private int _adjustment_product_id;

         public int adjustment_product_id
        {
            get { return _adjustment_product_id; }
            set { _adjustment_product_id = value; }
        }

         private Nullable<int> _adjustment_id;

         public Nullable<int>  adjustment_id
         {
             get { return _adjustment_id; }
             set { _adjustment_id = value; }
         }

         private Nullable<int> _product_id;

         public Nullable<int> product_id
         {
             get { return _product_id; }
             set { _product_id = value; }
         }

         private Nullable<int> _stock;

         public Nullable<int> stock
         {
             get { return _stock; }
             set { _stock = value; }
         }
         private Nullable<int> _addloss;

         public Nullable<int> addloss
         {
             get { return _addloss; }
             set { _addloss = value; }
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

        public AdjustmentProduct()
		{ }
    }
}
