using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class ReceiveBO
	{
		private int _receive_id;

		public int receive_id
		{
			get { return _receive_id; }
			set { _receive_id = value; }
		}

		private string _barcode;

		public string barcode
		{
			get { return _barcode; }
			set { _barcode = value; }
		}

		private Nullable<int> _purchase_id;

		public Nullable<int> purchase_id
		{
			get { return _purchase_id; }
			set { _purchase_id = value; }
		}

		private string _invoice_no;

		public string invoice_no
		{
			get { return _invoice_no; }
			set { _invoice_no = value; }
		}

		private Nullable<DateTime> _invoice_date;

		public Nullable<DateTime> invoice_date
		{
			get { return _invoice_date; }
			set { _invoice_date = value; }
		}

		private Nullable<DateTime> _received_date;

		public Nullable<DateTime> received_date
		{
			get { return _received_date; }
			set { _received_date = value; }
		}

		private Nullable<int> _store_id;

		public Nullable<int> store_id
		{
			get { return _store_id; }
			set { _store_id = value; }
		}

        //private Nullable<DateTime> _record_created_date;

        //public Nullable<DateTime> record_created_date
        //{
        //    get { return _record_created_date; }
        //    set { _record_created_date = value; }
        //}

		private Nullable<int> _record_created_by;

		public Nullable<int> record_created_by
		{
			get { return _record_created_by; }
			set { _record_created_by = value; }
		}

        //private Nullable<DateTime> _record_modified_date;

        //public Nullable<DateTime> record_modified_date
        //{
        //    get { return _record_modified_date; }
        //    set { _record_modified_date = value; }
        //}

		private Nullable<int> _record_modified_by;

		public Nullable<int> record_modified_by
		{
			get { return _record_modified_by; }
			set { _record_modified_by = value; }
		}

		public ReceiveBO()
		{ }

		public ReceiveBO(int receive_id,string barcode,Nullable<int> purchase_id,string invoice_no,Nullable<DateTime> invoice_date,Nullable<DateTime> received_date,Nullable<int> store_id,Nullable<DateTime> record_created_date,Nullable<int> record_created_by,Nullable<DateTime> record_modified_date,Nullable<int> record_modified_by)
		{
			this.receive_id = receive_id;
			this.barcode = barcode;
			this.purchase_id = purchase_id;
			this.invoice_no = invoice_no;
			this.invoice_date = invoice_date;
			this.received_date = received_date;
			this.store_id = store_id;
            //this.record_created_date = record_created_date;
			this.record_created_by = record_created_by;
            //this.record_modified_date = record_modified_date;
			this.record_modified_by = record_modified_by;
		}

		public override string ToString()
		{
			return "receive_id = " + receive_id.ToString() + ",barcode = " + barcode + ",purchase_id = " + purchase_id.ToString() + ",invoice_no = " + invoice_no + ",invoice_date = " + invoice_date.ToString() + ",received_date = " + received_date.ToString() + ",store_id = " + store_id.ToString() +  ",record_created_by = " + record_created_by.ToString() +" ,record_modified_by = " + record_modified_by.ToString();
		}

		public class receive_idComparer : System.Collections.Generic.IComparer<ReceiveBO>
		{
			public SorterMode SorterMode;
			public receive_idComparer()
			{ }
			public receive_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<receive> Membres
			int System.Collections.Generic.IComparer<ReceiveBO>.Compare(ReceiveBO x, ReceiveBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.receive_id.CompareTo(x.receive_id);
				}
				else
				{
					return x.receive_id.CompareTo(y.receive_id);
				}
			}
			#endregion
		}
		public class barcodeComparer : System.Collections.Generic.IComparer<ReceiveBO>
		{
			public SorterMode SorterMode;
			public barcodeComparer()
			{ }
			public barcodeComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<receive> Membres
			int System.Collections.Generic.IComparer<ReceiveBO>.Compare(ReceiveBO x, ReceiveBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.barcode.CompareTo(x.barcode);
				}
				else
				{
					return x.barcode.CompareTo(y.barcode);
				}
			}
			#endregion
		}
		public class invoice_noComparer : System.Collections.Generic.IComparer<ReceiveBO>
		{
			public SorterMode SorterMode;
			public invoice_noComparer()
			{ }
			public invoice_noComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
			}
			#region IComparer<receive> Membres
			int System.Collections.Generic.IComparer<ReceiveBO>.Compare(ReceiveBO x, ReceiveBO y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
					return y.invoice_no.CompareTo(x.invoice_no);
				}
				else
				{
					return x.invoice_no.CompareTo(y.invoice_no);
				}
			}
			#endregion
		}
	}
}
