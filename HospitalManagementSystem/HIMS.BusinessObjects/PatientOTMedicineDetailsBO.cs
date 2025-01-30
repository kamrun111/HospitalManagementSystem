using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class PatientOTMedicineDetailsBO
    {
        private int  _patient_ot_medicine_details_id;
	    public int patient_ot_medicine_details_id
	    {
		    get { return _patient_ot_medicine_details_id; }
		    set { _patient_ot_medicine_details_id = value; }
	    }
	    private Nullable<int>  _patient_ot_medicine_id;
	    public Nullable<int> patient_ot_medicine_id
	    {
		    get { return _patient_ot_medicine_id; }
		    set { _patient_ot_medicine_id = value; }
	    }
	    private Nullable<int>  _product_id;
	    public Nullable<int> product_id
	    {
		    get { return _product_id; }
		    set { _product_id = value; }
	    }
	    private Nullable<int>  _order_qty;
	    public Nullable<int> order_qty
	    {
		    get { return _order_qty; }
		    set { _order_qty = value; }
	    }
	    private Nullable<DateTime>  _record_created_date;
	    public Nullable<DateTime> record_created_date
	    {
		    get { return _record_created_date; }
		    set { _record_created_date = value; }
	    }
	    private Nullable<int>  _record_created_by;
	    public Nullable<int> record_created_by
	    {
		    get { return _record_created_by; }
		    set { _record_created_by = value; }
	    }
	    private Nullable<DateTime>  _record_modified_date;
	    public Nullable<DateTime> record_modified_date
	    {
		    get { return _record_modified_date; }
		    set { _record_modified_date = value; }
	    }
	    private Nullable<int>  _record_modified_by;
	    public Nullable<int> record_modified_by
	    {
		    get { return _record_modified_by; }
		    set { _record_modified_by = value; }
	    }
        public PatientOTMedicineDetailsBO()
	    { }
    }
}
