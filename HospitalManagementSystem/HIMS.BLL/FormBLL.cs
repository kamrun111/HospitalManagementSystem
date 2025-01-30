using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class FormBLL
	{
		private FormDAL _FormDAL;

		public FormDAL FormDAL
		{
            get { return _FormDAL; }
            set { _FormDAL = value; }
		}

        public FormBLL()
		{
			FormDAL = new FormDAL();
		}

        public DataSet GetForms()
		{
			try
			{
                return FormDAL.GetForms();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public FormBO GetForm(int formID)
		{
			try
			{
                return FormDAL.GetForm(formID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int AddForm(FormBO form)
		{
			try
			{
                return FormDAL.AddForm(form);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateForm(FormBO form)
		{
			try
			{
                return FormDAL.UpdateForm(form);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveForm(FormBO form)
        {
            try
            {
                return FormDAL.RemoveForm(form.form_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int RemoveForm(int form_id)
		{
			try
			{
                return FormDAL.RemoveForm(form_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
	}
}
