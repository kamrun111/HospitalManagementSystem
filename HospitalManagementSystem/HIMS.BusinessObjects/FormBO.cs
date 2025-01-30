using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class FormBO
	{
		private int _form_id;

        public int form_id
		{
            get { return _form_id; }
            set { _form_id = value; }
		}

        private string _form;

        public string form
		{
            get { return _form; }
            set { _form = value; }
		}

		

		public FormBO()
		{ }

        public FormBO(int form_id, string form)
		{
            this.form_id = form_id;
            this.form = form;
			
		}

		public override string ToString()
		{
			return "form_id = " + form_id.ToString() + ",form = " + form.ToString();
		}

		public class form_idComparer : System.Collections.Generic.IComparer<FormBO>
		{
			public SorterMode SorterMode;
			public form_idComparer()
			{ }
            public form_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<Form> Membres
            int System.Collections.Generic.IComparer<FormBO>.Compare(FormBO x, FormBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.form_id.CompareTo(x.form_id);
				}
				else
				{
                    return x.form_id.CompareTo(y.form_id);
				}
			}
			#endregion
		}
		public class formComparer : System.Collections.Generic.IComparer<FormBO>
		{
			public SorterMode SorterMode;
			public formComparer()
			{ }
            public formComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<Form> Membres
            int System.Collections.Generic.IComparer<FormBO>.Compare(FormBO x, FormBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.form.CompareTo(x.form);
				}
				else
				{
                    return x.form.CompareTo(y.form);
				}
			}
			#endregion
		}
	}
}
