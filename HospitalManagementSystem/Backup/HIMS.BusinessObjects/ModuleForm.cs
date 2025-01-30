using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class ModuleForm
	{
		private int _module_form_id;

        public int module_form_id
		{
            get { return _module_form_id; }
            set { _module_form_id = value; }
		}

        private Nullable<int> _module_id;

        public Nullable<int> module_id
		{
            get { return _module_id; }
            set { _module_id = value; }
		}

		private Nullable<int> _form_id;

        public Nullable<int> form_id
		{
            get { return _form_id; }
            set { _form_id = value; }
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





		public ModuleForm()
		{ }

        public ModuleForm(int module_form_id, Nullable<int> module_id, Nullable<int> form_id,Nullable<int> insert_permission,Nullable<int> edit_permission,Nullable<int> delete_permission,Nullable<int> view_permission)
		{
            this.module_form_id = module_form_id;
            this.module_id = module_id;
            this.form_id = form_id;
            this.insert_permission = insert_permission;
            this.edit_permission = edit_permission;
            this.delete_permission = delete_permission;
            this.view_permission = view_permission;
            
			
		}

		public override string ToString()
		{
            return "module_form_id = " + module_id.ToString() + ",module_id =" + module_id.ToString() + ",form_id = " + form_id.ToString() + " insert_permission = " + insert_permission.ToString() + " edit_permission = " + edit_permission.ToString() + "delete_permission = " + delete_permission.ToString() + " view_permission = " + view_permission.ToString();
		}

        public class module_form_idComparer : System.Collections.Generic.IComparer<ModuleForm>
		{
			public SorterMode SorterMode;
			public module_form_idComparer()
			{ }
            public module_form_idComparer(SorterMode SorterMode)
			{
				this.SorterMode = SorterMode;
            }
            #region IComparer<ModuleForm> Membres
            int System.Collections.Generic.IComparer<ModuleForm>.Compare(ModuleForm x, ModuleForm y)
			{
				if (SorterMode == SorterMode.Ascending)
				{
                    return y.module_form_id.CompareTo(x.module_form_id);
				}
				else
				{
                    return x.module_form_id.CompareTo(y.module_form_id);
				}
			}
			#endregion
		}
        

	}
}
