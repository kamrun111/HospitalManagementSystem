using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.BusinessObjects
{
    public class DeathCertificateBO
    {
        private int _death_certificate_id;

        public int death_certificate_id
		{
            get { return _death_certificate_id; }
            set { _death_certificate_id = value; }
		}

        private int _admission_id;

        public int admission_id
        {
            get { return _admission_id; }
            set { _admission_id = value; }
        }

        private string _patient_id;

        public string patient_id
		{
            get { return _patient_id; }
            set { _patient_id = value; }
		}

        private string _reg_no;

        public string reg_no
        {
            get { return _reg_no; }
            set { _reg_no = value; }
        }

        private string _patient_name;

        public string patient_name
        {
            get { return _patient_name; }
            set { _patient_name = value; }
        }

        private string _age;

        public string age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _gender;

        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _gurdian_name;

        public string gurdian_name
        {
            get { return _gurdian_name; }
            set { _gurdian_name = value; }
        }

        private string _relation;

        public string relation
        {
            get { return _relation; }
            set { _relation = value; }
        }

        private string _address;

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _admission_date;

        public string admission_date
        {
            get { return _admission_date; }
            set { _admission_date = value; }
        }

        private string _consultant;

        public string consultant
        {
            get { return _consultant; }
            set { _consultant = value; }
        }

        private string _clinical_diagnosis;

        public string clinical_diagnosis
        {
            get { return _clinical_diagnosis; }
            set { _clinical_diagnosis = value; }
        }

        private string _cause_of_death;

        public string cause_of_death
        {
            get { return _cause_of_death; }
            set { _cause_of_death = value; }
        }

        private string _death_date;

        public string death_date
        {
            get { return _death_date; }
            set { _death_date = value; }
        }

        private string _doctor_attending;

        public string doctor_attending
        {
            get { return _doctor_attending; }
            set { _doctor_attending = value; }
        }

        private string _report_created_doctor;

        public string report_created_doctor
        {
            get { return _report_created_doctor; }
            set { _report_created_doctor = value; }
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

        public DeathCertificateBO()
		{ }
    }
}
