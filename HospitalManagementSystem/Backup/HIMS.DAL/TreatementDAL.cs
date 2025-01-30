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
	public class TreatementDAL
	{
		public TreatementDAL()
		{
		}
		public List<Treatement> GettreatementsList()
		{
			SqlConnection conn = null;
			List<Treatement> lsttreatements = new List<Treatement>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "treatementGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Treatement otreatement = new Treatement();
					otreatement.treatement_id = Convert.ToInt32(dataReader["treatement_id"]);

					if(dataReader["treatement"] != DBNull.Value)
						otreatement.treatement = Convert.ToString(dataReader["treatement"]);

                    if (dataReader["treatment_type"] != DBNull.Value)
                        otreatement.treatement = Convert.ToString(dataReader["treatment_type"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otreatement.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otreatement.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otreatement.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otreatement.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lsttreatements.Add(otreatement);
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
			return lsttreatements;
		}
		public DataSet Gettreatements()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "treatementGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public DataSet OTDeclare(int TreatmentID)//sami 28 jan2009
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@TreatmentID", TreatmentID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTDeclare", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
		public Treatement Gettreatement(int treatement_id)
		{
			SqlConnection conn = null;
			Treatement otreatement = new Treatement();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@treatement_id", treatement_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "treatementGet", arParams, ref conn);
				while (dataReader.Read())
				{
					otreatement.treatement_id = Convert.ToInt32(dataReader["treatement_id"]);

					if(dataReader["treatement"] != DBNull.Value)
						otreatement.treatement = Convert.ToString(dataReader["treatement"]);

                    if (dataReader["treatment_type"] != DBNull.Value)
                        otreatement.treatment_type = Convert.ToString(dataReader["treatment_type"]);

                    if (dataReader["tretreatment_preprocedure"] != DBNull.Value)
                        otreatement.tretreatment_preprocedure = Convert.ToString(dataReader["tretreatment_preprocedure"]);

                     if (dataReader["treatment_procedure"] != DBNull.Value)
                         otreatement.treatment_procedure = Convert.ToString(dataReader["treatment_procedure"]);


                     if (dataReader["treatment_charge"] != DBNull.Value)
                         otreatement.treatment_charge = Convert.ToDecimal(dataReader["treatment_charge"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						otreatement.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						otreatement.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						otreatement.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						otreatement.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return otreatement;
		}
		public int Addtreatement(Treatement otreatement)
		{
			SqlParameter[] arParams = new SqlParameter[7];
			try
			{
				arParams[0] = new SqlParameter("@treatement", otreatement.treatement);
                arParams[1] = new SqlParameter("@treatement_type", otreatement.treatment_type);
                arParams[2] = new SqlParameter("@treatement_charge", otreatement.treatment_charge);
                arParams[3] = new SqlParameter("@treatement_procedure", otreatement.treatment_procedure);
				arParams[4] = new SqlParameter("@record_created_by", otreatement.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", otreatement.record_modified_by);
                arParams[6] = new SqlParameter("@pre_treatement_procedure", otreatement.tretreatment_preprocedure);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "treatementAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updatetreatement(Treatement otreatement)
		{

			SqlParameter[] arParams = new SqlParameter[8];
			try
			{
				arParams[0] = new SqlParameter("@treatement", otreatement.treatement);
                arParams[1] = new SqlParameter("@treatement_type", otreatement.treatment_type);
                arParams[2] = new SqlParameter("@treatement_charge", otreatement.treatment_charge);
                arParams[3] = new SqlParameter("@treatement_procedure", otreatement.treatment_procedure);
				arParams[4] = new SqlParameter("@record_created_by", otreatement.record_created_by);
				arParams[5] = new SqlParameter("@record_modified_by", otreatement.record_modified_by);
				arParams[6] = new SqlParameter("@treatement_id", otreatement.treatement_id);
                arParams[7] = new SqlParameter("@pre_treatement_procedure", otreatement.tretreatment_preprocedure);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "treatementUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetreatement(Treatement otreatement)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@treatement_id", otreatement.treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "treatementDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removetreatement(int treatement_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@treatement_id", treatement_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "treatementDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
