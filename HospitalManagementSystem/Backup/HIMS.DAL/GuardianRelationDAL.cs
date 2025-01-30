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
	public class GuardianRelationDAL
	{
		public GuardianRelationDAL()
		{
		}
		public List<GuardianRelation> Getguardian_relationsList()
		{
			SqlConnection conn = null;
            List<GuardianRelation> lstguardian_relations = new List<GuardianRelation>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "guardian_relationGetAll", null, ref conn);
				while (dataReader.Read())
				{
                    GuardianRelation oguardian_relation = new GuardianRelation();
					oguardian_relation.guardian_relation_id = Convert.ToInt32(dataReader["guardian_relation_id"]);

					if(dataReader["guardian_relation"] != DBNull.Value)
						oguardian_relation.guardian_relation = Convert.ToString(dataReader["guardian_relation"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oguardian_relation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oguardian_relation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oguardian_relation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oguardian_relation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstguardian_relations.Add(oguardian_relation);
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
			return lstguardian_relations;
		}
		public DataSet Getguardian_relations()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "guardian_relationGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
        public GuardianRelation Getguardian_relation(int guardian_relation_id)
		{
			SqlConnection conn = null;
            GuardianRelation oguardian_relation = new GuardianRelation();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@guardian_relation_id", guardian_relation_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "guardian_relationGet", arParams, ref conn);
				while (dataReader.Read())
				{
					oguardian_relation.guardian_relation_id = Convert.ToInt32(dataReader["guardian_relation_id"]);

					if(dataReader["guardian_relation"] != DBNull.Value)
						oguardian_relation.guardian_relation = Convert.ToString(dataReader["guardian_relation"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						oguardian_relation.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						oguardian_relation.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						oguardian_relation.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						oguardian_relation.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return oguardian_relation;
		}
        public int Addguardian_relation(GuardianRelation oguardian_relation)
		{
			SqlParameter[] arParams = new SqlParameter[3];
			try
			{
				arParams[0] = new SqlParameter("@guardian_relation", oguardian_relation.guardian_relation);
				arParams[1] = new SqlParameter("@record_created_by", oguardian_relation.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", oguardian_relation.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "guardian_relationAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updateguardian_relation(GuardianRelation oguardian_relation)
		{

			SqlParameter[] arParams = new SqlParameter[4];
			try
			{
				arParams[0] = new SqlParameter("@guardian_relation", oguardian_relation.guardian_relation);
				arParams[1] = new SqlParameter("@record_created_by", oguardian_relation.record_created_by);
				arParams[2] = new SqlParameter("@record_modified_by", oguardian_relation.record_modified_by);
				arParams[3] = new SqlParameter("@guardian_relation_id", oguardian_relation.guardian_relation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "guardian_relationUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removeguardian_relation(GuardianRelation oguardian_relation)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@guardian_relation_id", oguardian_relation.guardian_relation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "guardian_relationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeguardian_relation(int guardian_relation_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@guardian_relation_id", guardian_relation_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "guardian_relationDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
