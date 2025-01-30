using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class PatientOTMedicineBO
    {
        private int  _patient_ot_medicine_id;
	    public int patient_ot_medicine_id
	    {
		    get { return _patient_ot_medicine_id; }
		    set { _patient_ot_medicine_id = value; }
	    }
	    private string  _invoice_no;
	    public string invoice_no
	    {
		    get { return _invoice_no; }
		    set { _invoice_no = value; }
	    }
	    private string  _requisition_no;
	    public string requisition_no
	    {
		    get { return _requisition_no; }
		    set { _requisition_no = value; }
	    }
	    private Nullable<int>  _admission_id;
	    public Nullable<int> admission_id
	    {
		    get { return _admission_id; }
		    set { _admission_id = value; }
	    }
	    private Nullable<int>  _status;
	    public Nullable<int> status
	    {
		    get { return _status; }
		    set { _status = value; }
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
        public PatientOTMedicineBO()
	    { }
    }
}
