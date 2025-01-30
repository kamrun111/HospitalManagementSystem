using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
    public class UserPermittedForm
	{
        private int _user_permitted_form_id;

        public int user_permitted_form_id
		{
            get { return _user_permitted_form_id; }
            set { _user_permitted_form_id = value; }
		}

       
        private Nullable<int> _module_id;

        public Nullable<int> module_id
        {
            get { return _module_id; }
            set { _module_id = value; }
        }

        private Nullable<int> _insert_permission;

        public Nullable<int> insert_permission
        {
            get { return _insert_permission; }
            set { _insert_permission = value; }
        }

        private Nullable<int> _edit_permission;

        public Nullable<int> edit_permission
        {
            get { return _edit_permission; }
            set { _edit_permission = value; }
        }
        private Nullable<int> _delete_permission;

        public Nullable<int> delete_permission
        {
            get { return _delete_permission; }
            set { _delete_permission = value; }
        }
        private Nullable<int> _view_permission;

        public Nullable<int> view_permission
        {
            get { return _view_permission; }
            set { _view_permission = value; }
        }
		
        public UserPermittedForm()
		{ }

        public UserPermittedForm(int user_permitted_form_id, Nullable<int> module_id)
		{
            this.user_permitted_form_id = user_permitted_form_id;
            this.module_id = module_id;
            
  
		}

		public override string ToString()
		{
            return "user_permitted_form_id = " + user_permitted_form_id.ToString()  + " module_id = " + module_id.ToString() ;
		}

        public class user_permitted_form_idComparer : System.Collections.Generic.IComparer<UserPermittedForm>
		{
			public SorterMode SorterMode;
			public user_permitted_form_idComparer()
			{ }
            public user_permitted_form_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<UserLog> Membres
            int System.Collections.Generic.IComparer<UserPermittedForm>.Compare(UserPermittedForm x, UserPermittedForm y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.user_permitted_form_id.CompareTo(x.user_permitted_form_id);
				}
				else
				{
                    return x.user_permitted_form_id.CompareTo(y.user_permitted_form_id);
				}
			}
			#endregion
		}
        
       
	}
}
