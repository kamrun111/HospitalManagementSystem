using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class Anaesthesia
	{
		private int _anaesthesia_id;

		public int anaesthesia_id
		{
			get { return _anaesthesia_id; }
			set { _anaesthesia_id = value; }
		}

		private string _anaesthesia_name;

		public string anaesthesia_name
		{
			get { return _anaesthesia_name; }
			set { _anaesthesia_name = value; }
		}

		private string _anaesthesia_nature;

		public string anaesthesia_nature
		{
			get { return _anaesthesia_nature; }
			set { _anaesthesia_nature = value; }
		}

		public Anaesthesia()
		{ }

		public Anaesthesia(int anaesthesia_id,string anaesthesia_name,string anaesthesia_nature)
		{
			this.anaesthesia_id = anaesthesia_id;
			this.anaesthesia_name = anaesthesia_name;
			this.anaesthesia_nature = anaesthesia_nature;
		}

		public override string ToString()
		{
			return "anaesthesia_id = " + anaesthesia_id.ToString() + ",anaesthesia_name = " + anaesthesia_name + ",anaesthesia_nature = " + anaesthesia_nature;
		}

		public class anaesthesia_idComparer : System.Collections.Generic.IComparer<Anaesthesia>
		{
			public SorterMode SorterMode;
			public anaesthesia_idComparer()
			{ }
			public anaesthesia_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<anaesthesia> Membres
			int System.Collections.Generic.IComparer<Anaesthesia>.Compare(Anaesthesia x, Anaesthesia y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.anaesthesia_id.CompareTo(x.anaesthesia_id);
				}
				else
				{
					return x.anaesthesia_id.CompareTo(y.anaesthesia_id);
				}
			}
			#endregion
		}
		public class anaesthesia_nameComparer : System.Collections.Generic.IComparer<Anaesthesia>
		{
			public SorterMode SorterMode;
			public anaesthesia_nameComparer()
			{ }
			public anaesthesia_nameComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<anaesthesia> Membres
			int System.Collections.Generic.IComparer<Anaesthesia>.Compare(Anaesthesia x, Anaesthesia y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.anaesthesia_name.CompareTo(x.anaesthesia_name);
				}
				else
				{
					return x.anaesthesia_name.CompareTo(y.anaesthesia_name);
				}
			}
			#endregion
		}
		public class anaesthesia_natureComparer : System.Collections.Generic.IComparer<Anaesthesia>
		{
			public SorterMode SorterMode;
			public anaesthesia_natureComparer()
			{ }
			public anaesthesia_natureComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<anaesthesia> Membres
			int System.Collections.Generic.IComparer<Anaesthesia>.Compare(Anaesthesia x, Anaesthesia y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.anaesthesia_nature.CompareTo(x.anaesthesia_nature);
				}
				else
				{
					return x.anaesthesia_nature.CompareTo(y.anaesthesia_nature);
				}
			}
			#endregion
		}
	}
}
