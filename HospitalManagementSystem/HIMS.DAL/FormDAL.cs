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
	public class FormDAL
	{
		public FormDAL()
		{
		}

		public DataSet GetForms()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "FormGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public FormBO GetForm(int formID)
		{
			SqlConnection conn = null;
			FormBO form = new FormBO();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("FormID", formID);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "FormGet", arParams, ref conn);
				while (dataReader.Read())
				{
				form.form_id= Convert.ToInt32(dataReader["form_id"]);

					if(dataReader["form"] != DBNull.Value)
                        form.form = Convert.ToString(dataReader["form"]);

					

					
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
			return form;
		}
		public int AddForm(FormBO form)
		{
			SqlParameter[] arParams = new SqlParameter[1];
			try
			{
			
                arParams[0] = new SqlParameter("@form", form.form);
				
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "FormAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int UpdateForm(FormBO form)
		{

			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
                arParams[0] = new SqlParameter("@form_id", form.form_id);
                arParams[1] = new SqlParameter("@form", form.form);
						
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "FormUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int RemoveForm(ModuleForm form)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@form_id", form.form_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "FormDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int RemoveForm(int formID)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@form_id", formID);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "FormDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
