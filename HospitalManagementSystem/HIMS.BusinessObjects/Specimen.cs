using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Specimen
	{
		private int _specimen_id;

		public int specimen_id
		{
			get { return _specimen_id; }
			set { _specimen_id = value; }
		}

		private string _specimen_name;

		public string specimen_name
		{
			get { return _specimen_name; }
			set { _specimen_name = value; }
		}

		public Specimen()
		{ }

        public Specimen(int specimen_id, string specimen_name)
		{
			this.specimen_id = specimen_id;
			this.specimen_name = specimen_name;
			
		}

		public override string ToString()
		{
			return "specimen_id = " + specimen_id.ToString() + ",specimen_name = " + specimen_name + "";
        }

        public class specimen_idComparer : System.Collections.Generic.IComparer<Specimen>
		{
			public SorterMode SorterMode;
			public specimen_idComparer()
			{ }
			public specimen_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<Specimen> Membres
            int System.Collections.Generic.IComparer<Specimen>.Compare(Specimen x, Specimen y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.specimen_id.CompareTo(x.specimen_id);
				}
				else
				{
					return x.specimen_id.CompareTo(y.specimen_id);
				}
			}
			#endregion
		}
        public class specimen_nameComparer : System.Collections.Generic.IComparer<Specimen>
		{
			public SorterMode SorterMode;
			public specimen_nameComparer()
			{ }
			public specimen_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<Specimen> Membres
            int System.Collections.Generic.IComparer<Specimen>.Compare(Specimen x, Specimen y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.specimen_name.CompareTo(x.specimen_name);
				}
				else
				{
                    return x.specimen_name.CompareTo(y.specimen_name);
				}
			}
			#endregion
		}
	}
}
