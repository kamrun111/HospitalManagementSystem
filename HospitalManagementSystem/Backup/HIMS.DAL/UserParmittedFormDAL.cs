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
	public class UserPermittedFormDAL
	{
        public UserPermittedFormDAL()
		{
		}

        public DataSet GetUserPermittedForms()
		{
			try
			{
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "UserPermittedFormGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public UserPermittedForm GetUserPermittedForm(int userPermittedFormID)
		{
			SqlConnection conn = null;
            UserPermittedForm userPermittedForm = new UserPermittedForm();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@userPermittedFormID", userPermittedFormID);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "userPermittedFormGetAll", arParams, ref conn);
				while (dataReader.Read())
				{
                    userPermittedForm.user_permitted_form_id = Convert.ToInt32(dataReader["user_permitted_form_id"]);

					
                    if (dataReader["module_id "] != DBNull.Value)
                        userPermittedForm.module_id = Convert.ToInt32(dataReader["module_id "]);

                    if (dataReader["insert_permission"] != DBNull.Value)
                        userPermittedForm.insert_permission = Convert.ToSByte(dataReader["insert_permission"]);
                    if (dataReader["edit_permission"] != DBNull.Value)
                        userPermittedForm.edit_permission = Convert.ToSByte(dataReader["edit_permission"]);

                    if (dataReader["delete_permission"] != DBNull.Value)
                        userPermittedForm.delete_permission = Convert.ToSByte(dataReader["delete_permission"]);

                    if (dataReader["view_permission"] != DBNull.Value)
                        userPermittedForm.insert_permission = Convert.ToSByte(dataReader["view_permission"]);


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
            return userPermittedForm;
		}
        public int AddUserPermittedForm(UserPermittedForm userPermittedForm)
		{
			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
                arParams[0] = new SqlParameter("@module_id", userPermittedForm.module_id);
                arParams[1] = new SqlParameter("@insert_permission", userPermittedForm.insert_permission);
                arParams[2] = new SqlParameter("@edit_permission", userPermittedForm.edit_permission);
                arParams[3] = new SqlParameter("@delete_permission", userPermittedForm.delete_permission);
                arParams[4] = new SqlParameter("@view_permission", userPermittedForm.view_permission);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateUserPermittedForm(UserPermittedForm userPermittedForm)
		{

			SqlParameter[] arParams = new SqlParameter[5];
			try
			{
                arParams[0] = new SqlParameter("@module_id", userPermittedForm.module_id);
                arParams[1] = new SqlParameter("@insert_permission", userPermittedForm.insert_permission);
                arParams[2] = new SqlParameter("@edit_permission", userPermittedForm.edit_permission);
                arParams[3] = new SqlParameter("@delete_permission", userPermittedForm.delete_permission);
                arParams[4] = new SqlParameter("@view_permission", userPermittedForm.view_permission);


                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormUpdate", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@user_permitted_rorm_id", userPermittedForm.user_permitted_form_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormDelete", arParams);
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
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@userPermittedFormID", userPermittedFormID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "UserPermittedFormDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
