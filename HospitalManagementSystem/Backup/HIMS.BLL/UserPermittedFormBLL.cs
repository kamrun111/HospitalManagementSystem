using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class UserPermittedFormBLL
	{
		private UserPermittedFormDAL _userPermittedFormDAL;

		public UserPermittedFormDAL userPermittedFormDAL
		{
            get { return _userPermittedFormDAL; }
            set { _userPermittedFormDAL = value; }
		}

        public UserPermittedFormBLL()
		{
			userPermittedFormDAL = new UserPermittedFormDAL();
		}
		
		public DataSet GetUserPermittedForms()
		{
			try
			{
				return userPermittedFormDAL.GetUserPermittedForms();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public UserPermittedForm GetUserPermittedForm(int userPermittedFormID)
		{
			try
			{
                return userPermittedFormDAL.GetUserPermittedForm(userPermittedFormID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int AddUserPermittedForm(UserPermittedForm userPermittedForm)
		{
			try
			{
                return userPermittedFormDAL.AddUserPermittedForm(userPermittedForm);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateUserPermittedForm(UserPermittedForm userPermittedForm)
		{
			try
			{
                return userPermittedFormDAL.UpdateUserPermittedForm(userPermittedForm);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUserPermittedForm(UserPermittedForm userPermittedForm)
		{
			try
			{
                return userPermittedFormDAL.RemoveUserPermittedForm(userPermittedForm);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveUserPermittedForm(int userPermittedFormID)
		{
			try
			{
                return userPermittedFormDAL.RemoveUserPermittedForm(userPermittedFormID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
	}
}
