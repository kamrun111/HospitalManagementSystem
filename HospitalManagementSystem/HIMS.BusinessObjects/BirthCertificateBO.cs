using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class BirthCertificateBO
    {
        private int  _birth_certificate_id;
	    public int birth_certificate_id
	    {
		    get { return _birth_certificate_id; }
		    set { _birth_certificate_id = value; }
	    }
	    private Nullable<int>  _admission_id;
	    public Nullable<int> admission_id
	    {
		    get { return _admission_id; }
		    set { _admission_id = value; }
	    }
	    private string  _mother_name;
	    public string mother_name
	    {
		    get { return _mother_name; }
		    set { _mother_name = value; }
	    }
	    private string  _father_name;
	    public string father_name
	    {
		    get { return _father_name; }
		    set { _father_name = value; }
	    }
	    private string  _baby_name;
	    public string baby_name
	    {
		    get { return _baby_name; }
		    set { _baby_name = value; }
	    }
	    private string  _reg_no;
	    public string reg_no
	    {
		    get { return _reg_no; }
		    set { _reg_no = value; }
	    }
	    private string  _patient_id;
	    public string patient_id
	    {
		    get { return _patient_id; }
		    set { _patient_id = value; }
	    }
	    private string  _gender;
	    public string gender
	    {
		    get { return _gender; }
		    set { _gender = value; }
	    }
	    private string  _religion;
	    public string religion
	    {
		    get { return _religion; }
		    set { _religion = value; }
	    }
	    private string  _weight;
	    public string weight
	    {
		    get { return _weight; }
		    set { _weight = value; }
	    }
	    private string  _address;
	    public string address
	    {
		    get { return _address; }
		    set { _address = value; }
	    }
	    private string  _consultant;
	    public string consultant
	    {
		    get { return _consultant; }
		    set { _consultant = value; }
	    }
	    private string  _delivery_date;
	    public string delivery_date
	    {
		    get { return _delivery_date; }
		    set { _delivery_date = value; }
	    }
	    private string  _identification_mark;
	    public string identification_mark
	    {
		    get { return _identification_mark; }
		    set { _identification_mark = value; }
	    }
	    private string  _birth_place;
	    public string birth_place
	    {
		    get { return _birth_place; }
		    set { _birth_place = value; }
	    }
	    private string  _record_doctor;
	    public string record_doctor
	    {
		    get { return _record_doctor; }
		    set { _record_doctor = value; }
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
        public BirthCertificateBO()
	    { }
    }
}
