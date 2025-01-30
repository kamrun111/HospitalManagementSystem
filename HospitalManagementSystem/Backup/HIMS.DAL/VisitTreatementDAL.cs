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
	public class VisitTreatementDAL
	{
		public VisitTreatementDAL()
		{
		}
		public List<VisitTreatement> Getvisit_treatementsList()
		{
			SqlConnection conn = null;
			List<VisitTreatement> lstvisit_treatements = new List<VisitTreatement>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_treatementGetAll", null, ref conn);
				while (dataReader.Read())
				{
					VisitTreatement ovisit_treatement = new VisitTreatement();
					ovisit_treatement.visit_treatement_id = Convert.ToInt32(dataReader["visit_treatement_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_treatement.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["treatement_id"] != DBNull.Value)
						ovisit_treatement.treatement_id = Convert.ToInt32(dataReader["treatement_id"]);

					if(dataReader["dose"] != DBNull.Value)
						ovisit_treatement.dose = Convert.ToString(dataReader["dose"]);

					if(dataReader["quantity"] != DBNull.Value)
						ovisit_treatement.quantity = Convert.ToDecimal(dataReader["quantity"]);

                    if (dataReader["qty_submitted"] != DBNull.Value)
                        ovisit_treatement.qty_submitted = Convert.ToDecimal(dataReader["qty_submitted"]);

					if(dataReader["application_procedure"] != DBNull.Value)
						ovisit_treatement.application_procedure = Convert.ToString(dataReader["application_procedure"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_treatement.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_treatement.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_treatement.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_treatement.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstvisit_treatements.Add(ovisit_treatement);
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
			return lstvisit_treatements;
		}
		public DataSet Getvisit_treatements()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "visit_treatementGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet VisitTreatementGetByAdmnID(int admnID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admnID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "VisitTreatementGetByAdmnID",arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

		public VisitTreatement Getvisit_treatement(int visit_treatement_id)
		{
			SqlConnection conn = null;
			VisitTreatement ovisit_treatement = new VisitTreatement();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_treatement_id", visit_treatement_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "visit_treatementGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ovisit_treatement.visit_treatement_id = Convert.ToInt32(dataReader["visit_treatement_id"]);

					if(dataReader["visit_prescription_id"] != DBNull.Value)
						ovisit_treatement.visit_prescription_id = Convert.ToInt32(dataReader["visit_prescription_id"]);

					if(dataReader["treatement_id"] != DBNull.Value)
						ovisit_treatement.treatement_id = Convert.ToInt32(dataReader["treatement_id"]);

					if(dataReader["dose"] != DBNull.Value)
						ovisit_treatement.dose = Convert.ToString(dataReader["dose"]);

					if(dataReader["quantity"] != DBNull.Value)
						ovisit_treatement.quantity = Convert.ToDecimal(dataReader["quantity"]);

                    if (dataReader["qty_submitted"] != DBNull.Value)
                        ovisit_treatement.qty_submitted = Convert.ToDecimal(dataReader["qty_submitted"]);

					if(dataReader["application_procedure"] != DBNull.Value)
						ovisit_treatement.application_procedure = Convert.ToString(dataReader["application_procedure"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ovisit_treatement.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ovisit_treatement.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ovisit_treatement.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ovisit_treatement.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ovisit_treatement;
		}
		public int Addvisit_treatement(VisitTreatement ovisit_treatement)
		{
			SqlParameter[] arParams = new SqlParameter[9];
			try
			{
				arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_treatement.visit_prescription_id);
				arParams[1] = new SqlParameter("@treatement_id", ovisit_treatement.treatement_id);
				arParams[2] = new SqlParameter("@dose", ovisit_treatement.dose);
				arParams[3] = new SqlParameter("@quantity", ovisit_treatement.quantity);
                arParams[4] = new SqlParameter("qty_submitted", ovisit_treatement.qty_submitted);
				arParams[5] = new SqlParameter("@application_procedure", ovisit_treatement.application_procedure);
                arParams[6] = new SqlParameter("@is_submit", 0);
				arParams[7] = new SqlParameter("@record_created_by", ovisit_treatement.record_created_by);
				arParams[8] = new SqlParameter("@record_modified_by", ovisit_treatement.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_treatementAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatevisit_treatement(VisitTreatement ovisit_treatement)
		{

			SqlParameter[] arParams = new SqlParameter[10];
			try
			{
				arParams[0] = new SqlParameter("@visit_prescription_id", ovisit_treatement.visit_prescription_id);
				arParams[1] = new SqlParameter("@treatement_id", ovisit_treatement.treatement_id);
				arParams[2] = new SqlParameter("@dose", ovisit_treatement.dose);
				arParams[3] = new SqlParameter("@quantity", ovisit_treatement.quantity);
                arParams[4] = new SqlParameter("qty_submitted", ovisit_treatement.qty_submitted);
                arParams[5] = new SqlParameter("@application_procedure", ovisit_treatement.application_procedure);
                arParams[6] = new SqlParameter("@is_submit", ovisit_treatement.is_submit);
                arParams[7] = new SqlParameter("@record_created_by", ovisit_treatement.record_created_by);
				arParams[8] = new SqlParameter("@record_modified_by", ovisit_treatement.record_modified_by);
				arParams[9] = new SqlParameter("@visit_treatement_id", ovisit_treatement.visit_treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_treatementUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int visit_doctortreatement(VisitTreatement ovisit_treatement)
        {

            SqlParameter[] arParams = new SqlParameter[2];
            try
            {
                arParams[0] = new SqlParameter("@record_modified_by", ovisit_treatement.record_modified_by);
                arParams[1] = new SqlParameter("@visit_treatement_id", ovisit_treatement.visit_treatement_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_doctortreatement", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int VisitTreatementSubmitSet(VisitTreatement ovisit_treatement)
		{
            SqlParameter[] arParams = new SqlParameter[4];
			try
			{
                arParams[0] = new SqlParameter("@is_submit", ovisit_treatement.is_submit);
                arParams[1] = new SqlParameter("@qty_submitted", ovisit_treatement.qty_submitted);
				arParams[2] = new SqlParameter("@record_modified_by", ovisit_treatement.record_modified_by);
				arParams[3] = new SqlParameter("@visit_treatement_id", ovisit_treatement.visit_treatement_id);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "VisitTreatementSubmitSet", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        
		public int Removevisit_treatement(VisitTreatement ovisit_treatement)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_treatement_id", ovisit_treatement.visit_treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_treatementDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removevisit_treatement(int visit_treatement_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@visit_treatement_id", visit_treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "visit_treatementDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
