using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Treatement
	{
		private int _treatement_id;

		public int treatement_id
		{
			get { return _treatement_id; }
			set { _treatement_id = value; }
		}

		private string _treatement;

		public string treatement
		{
			get { return _treatement; }
			set { _treatement = value; }
		}


        private string _treatment_type;

        public string treatment_type
        {
            get { return _treatment_type; }
            set { _treatment_type = value; }
        }

        private string _tretreatment_preprocedure;

        public string tretreatment_preprocedure
        {
            get { return _tretreatment_preprocedure; }
            set { _tretreatment_preprocedure = value; }
        }

        private string _treatment_procedure;

        public string treatment_procedure
        {
            get { return _treatment_procedure; }
            set { _treatment_procedure = value; }
        }


        private Nullable<decimal> _treatment_charge;

        public Nullable<decimal> treatment_charge
        {
            get { return _treatment_charge; }
            set { _treatment_charge = value; }
        }

        private Nullable<decimal> _additional_charge;

        public Nullable<decimal> additional_charge
        {
            get { return _additional_charge; }
            set { _additional_charge = value; }
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

		public Treatement()
		{ }

        public Treatement(int treatement_id, string treatement, string treatment_type,string tretreatment_preprocedure, string treatment_procedure, Nullable<decimal> treatment_charge, Nullable<decimal> additional_charge, Nullable<DateTime> record_created_date, Nullable<int> record_created_by, Nullable<DateTime> record_modified_date, Nullable<int> record_modified_by)
		{
			this.treatement_id = treatement_id;
			this.treatement = treatement;
            this.treatment_type = treatment_type;
            this.tretreatment_preprocedure = tretreatment_preprocedure;
            this.treatment_procedure = treatment_procedure;
            this.treatment_charge = treatment_charge;
            this.additional_charge = additional_charge;
			this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
			this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
            return "treatement_id = " + treatement_id.ToString() + ",treatement = " + treatement + ",treatment_type= " + treatment_type + ",tretreatment_preprocedure="+tretreatment_preprocedure.ToString()+",treatment_procedure=" + treatment_procedure + ",  treatment_charge= " + treatment_charge.ToString() + ", additional_charge= " + additional_charge.ToString() + ",record_created_date = " + record_created_date.ToString() + ",record_created_by = " + record_created_by.ToString() + ",record_modified_date = " + record_modified_date.ToString() + ",record_modified_by = " + record_modified_by.ToString();
		}

		public class treatement_idComparer : System.Collections.Generic.IComparer<Treatement>
		{
			public SorterMode SorterMode;
			public treatement_idComparer()
			{ }
			public treatement_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Treatement> Membres
			int System.Collections.Generic.IComparer<Treatement>.Compare(Treatement x, Treatement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.treatement_id.CompareTo(x.treatement_id);
				}
				else
				{
					return x.treatement_id.CompareTo(y.treatement_id);
				}
			}
			#endregion
		}
		public class treatementComparer : System.Collections.Generic.IComparer<Treatement>
		{
			public SorterMode SorterMode;
			public treatementComparer()
			{ }
			public treatementComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<Treatement> Membres
			int System.Collections.Generic.IComparer<Treatement>.Compare(Treatement x, Treatement y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.treatement.CompareTo(x.treatement);
				}
				else
				{
                    return x.treatement.CompareTo(y.treatement);
				}
			}
			#endregion
		}
	}
}
