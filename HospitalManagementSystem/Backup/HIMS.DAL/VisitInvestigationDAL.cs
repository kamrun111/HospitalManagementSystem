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
	public class VisitInvestigationDAL
	{
		public VisitInvestigationDAL()
		{
		}
		public List<VisitInvestigation> Getvisit_investigationsList()
		{
			SqlConnection conn = null;
			List<VisitInvestigation> lstvisit_investigations = new List<VisitInvestigation>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_investigationGetAll", null, ref conn);
				while (dataReader.Read())
				{
					VisitInvestigation ovisit_investigation = new VisitInvestigation();
					ovisit_investigation.visit_investigation_id = Convert.ToInt32(dataReader["visit_investigation_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_investigation.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["test_department_id"] != DBNull.Value)
						ovisit_investigation.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["test_group_id"] != DBNull.Value)
						ovisit_investigation.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["test_item_id"] != DBNull.Value)
						ovisit_investigation.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["indent_given"] != DBNull.Value)
						ovisit_investigation.indent_given = Convert.ToSByte(dataReader["indent_given"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_investigation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_investigation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_investigation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_investigation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstvisit_investigations.Add(ovisit_investigation);
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
			return lstvisit_investigations;
		}
		public DataSet Getvisit_investigations()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "visit_investigationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public int donebypatient(VisitInvestigation ovisit_investigation)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@recordmodifivedby", ovisit_investigation.record_modified_by);
                arParams[1] = new SqlParameter("@visitInvestigationID", ovisit_investigation.visit_investigation_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "donebypatient", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int visitinvetigationcancel(VisitInvestigation ovisit_investigation)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@userID", ovisit_investigation.record_modified_by);
                arParams[1] = new SqlParameter("@visitinvetigationID", ovisit_investigation.visit_investigation_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visitinvetigationcancel", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetInvestigationIndentInfo(int admnID)
		{
			try
			{
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@AdmissionID", admnID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetInvestigationIndentInfo", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public VisitInvestigation Getvisit_investigation(int visit_investigation_id)
		{
			SqlConnection conn = null;
			VisitInvestigation ovisit_investigation = new VisitInvestigation();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_investigation_id", visit_investigation_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_investigationGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ovisit_investigation.visit_investigation_id = Convert.ToInt32(dataReader["visit_investigation_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_investigation.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["test_department_id"] != DBNull.Value)
						ovisit_investigation.test_department_id = Convert.ToInt32(dataReader["test_department_id"]);

					if(dataReader["test_group_id"] != DBNull.Value)
						ovisit_investigation.test_group_id = Convert.ToInt32(dataReader["test_group_id"]);

					if(dataReader["test_item_id"] != DBNull.Value)
						ovisit_investigation.test_item_id = Convert.ToInt32(dataReader["test_item_id"]);

					if(dataReader["indent_given"] != DBNull.Value)
						ovisit_investigation.indent_given = Convert.ToSByte(dataReader["indent_given"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_investigation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_investigation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_investigation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_investigation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ovisit_investigation;
		}
		public int Addvisit_investigation(VisitInvestigation ovisit_investigation)
		{
			SqlParameter[] arParams = new SqlParameter[9];//
			try
			{
				arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_investigation.visit_prescription_id);
				arParams[1] = new SqlParameter("@test_department_id", ovisit_investigation.test_department_id);
				arParams[2] = new SqlParameter("@test_group_id", ovisit_investigation.test_group_id);
				arParams[3] = new SqlParameter("@test_item_id", ovisit_investigation.test_item_id);
				arParams[4] = new SqlParameter("@indent_given", ovisit_investigation.indent_given);
                arParams[5] = new SqlParameter("@investigation_date", ovisit_investigation.investigation_date);
				arParams[6] = new SqlParameter("@record_created_by", ovisit_investigation.record_created_by);
				arParams[7] = new SqlParameter("@record_modified_by", ovisit_investigation.record_modified_by);
                arParams[8] = new SqlParameter("@baby_test", ovisit_investigation.baby_test);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_investigationAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatevisit_investigation(VisitInvestigation ovisit_investigation)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_investigation.visit_prescription_id);
				arParams[1] = new SqlParameter("@test_department_id", ovisit_investigation.test_department_id);
				arParams[2] = new SqlParameter("@test_group_id", ovisit_investigation.test_group_id);
				arParams[3] = new SqlParameter("@test_item_id", ovisit_investigation.test_item_id);
				arParams[4] = new SqlParameter("@indent_given", ovisit_investigation.indent_given);
				arParams[5] = new SqlParameter("@record_created_by", ovisit_investigation.record_created_by);
				arParams[6] = new SqlParameter("@record_modified_by", ovisit_investigation.record_modified_by);
				arParams[7] = new SqlParameter("@visit_investigation_id", ovisit_investigation.visit_investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_investigationUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public int SetVisitInvestigationIndentGiven(int visitInvestigationID,int indentGiven,int userID)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
                arParams[0] = new SqlParameter("@visit_investigation_id", visitInvestigationID);
                arParams[1] = new SqlParameter("@indent_given", indentGiven);
                arParams[2] = new SqlParameter("@user_id", userID);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SetVisitInvestigationIndentGiven", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int Removevisit_investigation(VisitInvestigation ovisit_investigation)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_investigation_id", ovisit_investigation.visit_investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_investigationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_investigation(int visit_investigation_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_investigation_id", visit_investigation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_investigationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
