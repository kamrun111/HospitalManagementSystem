using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;

namespace HIMS.DAL
{
	public class ModuleFormDAL
	{
		public ModuleFormDAL()
		{
		}

		public DataSet GetModuleForms()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "ModuleFormGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet GetFormByModuleID(int moduleID)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@module_id", moduleID);

                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetFormByModuleID", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public ModuleForm GetModuleForm(int moduleFormID)
		{
			SqlConnection conn = null;
			ModuleForm moduleForm = new ModuleForm();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@moduleFormID", moduleFormID);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "ModuleFormGet", arParams, ref conn);
				while (dataReader.Read())
				{
					moduleForm.module_form_id = Convert.ToInt32(dataReader["module_form_id"]);

					if(dataReader["module_id"] != DBNull.Value)
                        moduleForm.module_id = Convert.ToInt32(dataReader["module_id"]);

					if(dataReader["form_id"] != DBNull.Value)
                        moduleForm.form_id = Convert.ToInt32(dataReader["form_id"]);

					
                }
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return moduleForm;
		}
		public int AddModuleForm(ModuleForm moduleForm)
		{
			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
				arParams[0] = new SqlParameter("@moduleID", moduleForm.module_id);
                arParams[1] = new SqlParameter("@formID", moduleForm.form_id);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleFormAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int AddUserPermittedForm(ModuleForm moduleForm)
        {
            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@module_id", moduleForm.module_id);
                arParams[1] = new SqlParameter("@form_id", moduleForm.form_id);
                arParams[2] = new SqlParameter("@insert_permission", moduleForm.insert_permission);
                arParams[3] = new SqlParameter("@edit_permission", moduleForm.edit_permission);
                arParams[4] = new SqlParameter("@delete_permission", moduleForm.delete_permission);
                arParams[5] = new SqlParameter("@view_permission", moduleForm.view_permission);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormAdd", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateUserPermittedForm(ModuleForm moduleForm)
        {

            SqlParameter[] arParams = new SqlParameter[6];
            try
            {
                arParams[0] = new SqlParameter("@module_id", moduleForm.module_id);
                arParams[1] = new SqlParameter("@form_id", moduleForm.form_id);
                arParams[2] = new SqlParameter("@insert_permission", moduleForm.insert_permission);
                arParams[3] = new SqlParameter("@edit_permission", moduleForm.edit_permission);
                arParams[4] = new SqlParameter("@delete_permission", moduleForm.delete_permission);
                arParams[5] = new SqlParameter("@view_permission", moduleForm.view_permission);



                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormUpdate", arParams);
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
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@module_id", module_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormDelete", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AddMultipleModuleForm(List<ModuleForm> lstModuleForm)
        {
            SqlConnection conn = DbHelper.GetOpenConnection();
            int result = 0;

            SqlTransaction trans = conn.BeginTransaction();
            SqlParameter[] arParams = new SqlParameter[2];

            try
            {
                foreach (ModuleForm element in lstModuleForm)
                {
                    arParams[0] = new SqlParameter("@module_id", element.module_id);
                    arParams[1] = new SqlParameter("@form_id", element.form_id);
                    result = SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "ModuleFormAdd", arParams);
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                result = -1;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
		public int UpdateModuleForm(ModuleForm moduleForm)
		{

			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
				arParams[0] = new SqlParameter("@module_id", moduleForm.module_id);
				arParams[1] = new SqlParameter("@form_id", moduleForm.form_id);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleFormUpdate", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@module_form_id", moduleForm.module_form_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleFormDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@module_form_id", moduleFormID);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "ModuleFormDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
