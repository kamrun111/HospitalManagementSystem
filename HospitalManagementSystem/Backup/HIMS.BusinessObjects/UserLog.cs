using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class UserLog
	{
        private int _user_log_id;

        public int user_log_id
		{
            get { return _user_log_id; }
            set { _user_log_id = value; }
		}

        private Nullable<int> _user_id;

        public Nullable<int> user_id
		{
            get { return _user_id; }
            set { _user_id = value; }
		}
        private Nullable<DateTime> _login_time;

        public Nullable<DateTime> login_time
        {
            get { return _login_time; }
            set { _login_time = value; }
        }

        private Nullable<DateTime> _logout_time;

        public Nullable<DateTime> logout_time
        {
            get { return _logout_time; }
            set { _logout_time = value; }
        }
	
 public UserLog()
		{ }

        public UserLog(int user_log_id, Nullable<int> user_id, Nullable<DateTime> login_time, Nullable<DateTime> logout_time)
		{
            this.user_log_id = user_log_id;
            this.user_id = user_id;
            this.login_time = login_time;
            this.logout_time = logout_time;
          
		}
		

		public override string ToString()
		{
            return "user_log_id = " + user_log_id.ToString() + " user_id = " + user_id.ToString() + " login_time = " + login_time.ToString() + "logout_time = " + logout_time.ToString();
		}

        public class user_log_idComparer : System.Collections.Generic.IComparer<UserLog>
		{
			public SorterMode SorterMode;
			public user_log_idComparer()
			{ }
            public user_log_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<UserLog> Membres
            int System.Collections.Generic.IComparer<UserLog>.Compare(UserLog x, UserLog y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.user_log_id.CompareTo(x.user_log_id);
				}
				else
				{
                    return x.user_log_id.CompareTo(y.user_log_id);
				}
			}
			#endregion
		}
       

	}
}
