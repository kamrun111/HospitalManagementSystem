using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class CaseSummary
	{
        private int _CaseSummaryID;

        public int CaseSummaryID
		{
            get { return _CaseSummaryID; }
            set { _CaseSummaryID = value; }
		}

		private string _PreCaseSummary;

		public string PreCaseSummary
		{
			get { return _PreCaseSummary; }
			set { _PreCaseSummary = value; }
		}
        private string _AftCaseSummary;
        	public string AftCaseSummary
		{
			get { return _AftCaseSummary; }
			set { _AftCaseSummary = value; }
		}

		

		public CaseSummary()
		{ }

        public CaseSummary(int CaseSummaryID, string PreCaseSummary, string AftCaseSummary)
		{
            this.CaseSummaryID = CaseSummaryID;
            this.PreCaseSummary = PreCaseSummary;
            this.AftCaseSummary = AftCaseSummary;
			
		}

		public override string ToString()
		{
            return "CaseSummaryID = " + CaseSummaryID.ToString() + ",PreCaseSummary = " + PreCaseSummary + ",AftCaseSummary = " + AftCaseSummary;
		}

		public class CaseSummaryIDComparer : System.Collections.Generic.IComparer<CaseSummary>
		{
			public SorterMode SorterMode;
			public CaseSummaryIDComparer()
			{ }
            public CaseSummaryIDComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<CaseSummary> Membres
            int System.Collections.Generic.IComparer<CaseSummary>.Compare(CaseSummary x, CaseSummary y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.CaseSummaryID.CompareTo(x.CaseSummaryID);
				}
				else
				{
                    return x.CaseSummaryID.CompareTo(y.CaseSummaryID);
				}
			}
			#endregion
		}

	}
}
