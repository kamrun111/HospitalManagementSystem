using System;
using System.Text;

namespace HIMS.BusinessObjects
{
    [Serializable()]
    public class OPDpatientMedicineIndent
    {
        private int _opd_patient_medicine_indent_id;

        public int opd_patient_medicine_indent_id
        {
            get { return _opd_patient_medicine_indent_id; }
            set { _opd_patient_medicine_indent_id = value; }
        }

        private int _opd_order_id;

        public int opd_order_id
        {
            get { return _opd_order_id; }
            set { _opd_order_id = value; }
        }

        private int _product_id;

        public int product_id
        {
            get { return _product_id; }
            set { _product_id = value; }
        }

        private int _qty_ordered;

        public int qty_ordered
        {
            get { return _qty_ordered; }
            set { _qty_ordered = value; }
        }

        private int _qty_received;

        public int qty_received
        {
            get { return _qty_received; }
            set { _qty_received = value; }
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

        private Nullable<DateTime> _record_created_date;

        public Nullable<DateTime> record_created_date
        {
            get { return _record_created_date; }
            set { _record_created_date = value; }
        }

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}


        public OPDpatientMedicineIndent()
		{ }

        public OPDpatientMedicineIndent(int opd_patient_medicine_indent_id,int opd_order_id, int product_id, int qty_ordered, int qty_received, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
        {
            this.opd_patient_medicine_indent_id=opd_patient_medicine_indent_id;
            this.opd_order_id = opd_order_id;
            this.product_id = product_id;
            this.qty_ordered = qty_ordered;
            this.qty_received=qty_received;
            this.record_created_date = record_created_date;
            this.record_created_by = record_created_by;
            this.record_modified_date = record_modified_date;
            this.record_modified_by = record_modified_by;
        }

        public override string ToString()
        {
            return "opd_patient_medicine_indent_id = " + opd_patient_medicine_indent_id.ToString() + ",opd_order_id= " + opd_order_id.ToString() +", product_id = " + product_id.ToString() + ",qty_ordered = " + qty_ordered.ToString() + ",qty_received = " + qty_received.ToString() + ",record_created_date= " + record_created_date.ToString() + ",record_created_by=" + record_created_by.ToString() + ", record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
        }
        public class opd_patient_medicine_indent_idComparer : System.Collections.Generic.IComparer<OPDpatientMedicineIndent>
        {
            public SorterMode SorterMode;
            public opd_patient_medicine_indent_idComparer()
            { }
            public opd_patient_medicine_indent_idComparer(SorterMode SorterMode)
            {
                this.SorterMode = SorterMode;
            }
            #region IComparer<opdpatientMedicineIndent> Membres
            int System.Collections.Generic.IComparer<OPDpatientMedicineIndent>.Compare(OPDpatientMedicineIndent x, OPDpatientMedicineIndent y)
            {
                if (SorterMode == SorterMode.Ascending)
                {
                    return y.opd_patient_medicine_indent_id.CompareTo(x.opd_patient_medicine_indent_id);
                }
                else
                {
                    return x.opd_patient_medicine_indent_id.CompareTo(y.opd_patient_medicine_indent_id);
                }
            }
            #endregion
        }
    }
}
