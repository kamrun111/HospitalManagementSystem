using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ModuleFormBLL
	{
		private ModuleFormDAL _moduleFormDAL;

		public ModuleFormDAL moduleFormDAL
		{
            get { return _moduleFormDAL; }
            set { _moduleFormDAL = value; }
		}

        public ModuleFormBLL()
		{
			moduleFormDAL = new ModuleFormDAL();
		}
		
		public DataSet GetModuleForms()
		{
			try
			{
				return moduleFormDAL.GetModuleForms();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetFormByModuleID(int moduleID)
		{
			try
			{
				return moduleFormDAL. GetFormByModuleID(moduleID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public ModuleForm GetModuleForm(int moduleFormID)
		{
			try
			{
                return moduleFormDAL.GetModuleForm(moduleFormID);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int AddModuleForm(ModuleForm moduleForm)
		{
			try
			{
                return moduleFormDAL.AddModuleForm(moduleForm);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AddUserPermittedForm(ModuleForm moduleForm)
        {
            try
            {
                return moduleFormDAL.AddUserPermittedForm(moduleForm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      /*  public int UpdateUserPermittedForm(ModuleForm moduleForm)
        {
            try
            {
                return moduleFormDAL.UpdateUserPermittedForm(moduleForm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int RemoveUserPermittedForm(int module_id)
        {
            try
            {
                return moduleFormDAL.RemoveUserPermittedForm(module_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        */
        public int AddMultipleModuleForm(List<ModuleForm> lstModuleForm)
		{
			try
			{
                return moduleFormDAL.AddMultipleModuleForm(lstModuleForm);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateModuleForm(ModuleForm moduleForm)
		{
			try
			{
                return moduleFormDAL.UpdateModuleForm(moduleForm);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveModuleForm(ModuleForm moduleForm)
		{
			try
			{
                return moduleFormDAL.RemoveModuleForm(moduleForm);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int RemoveModuleForm(int moduleFormID)
		{
			try
			{
                return moduleFormDAL.RemoveModuleForm(moduleFormID);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
	}
}
