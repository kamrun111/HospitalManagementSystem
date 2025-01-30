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
	public class IntakeOuttakeDAL
	{
		public IntakeOuttakeDAL()
		{
		}
		public List<IntakeOuttake> Getintake_outtakesList()
		{
			SqlConnection conn = null;
			List<IntakeOuttake> lstintake_outtakes = new List<IntakeOuttake>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "intake_outtakeGetAll", null, ref conn);
				while (dataReader.Read())
				{
					IntakeOuttake ointake_outtake = new IntakeOuttake();
					ointake_outtake.intake_outtake_id = Convert.ToInt32(dataReader["intake_outtake_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						ointake_outtake.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["in_date_time"] != DBNull.Value)
						ointake_outtake.in_date_time = Convert.ToDateTime(dataReader["in_date_time"]);

					if(dataReader["in_oral"] != DBNull.Value)
						ointake_outtake.in_oral = Convert.ToDecimal(dataReader["in_oral"]);

					if(dataReader["in_parenteral"] != DBNull.Value)
						ointake_outtake.in_parenteral = Convert.ToDecimal(dataReader["in_parenteral"]);

					if(dataReader["in_urinary_bladder_wash"] != DBNull.Value)
						ointake_outtake.in_urinary_bladder_wash = Convert.ToDecimal(dataReader["in_urinary_bladder_wash"]);

					if(dataReader["in_total"] != DBNull.Value)
						ointake_outtake.in_total = Convert.ToDecimal(dataReader["in_total"]);

					if(dataReader["out_nasogastric"] != DBNull.Value)
						ointake_outtake.out_nasogastric = Convert.ToDecimal(dataReader["out_nasogastric"]);

					if(dataReader["out_drainage_tube"] != DBNull.Value)
						ointake_outtake.out_drainage_tube = Convert.ToDecimal(dataReader["out_drainage_tube"]);

					if(dataReader["out_urine"] != DBNull.Value)
						ointake_outtake.out_urine = Convert.ToDecimal(dataReader["out_urine"]);

					if(dataReader["out_t_tube"] != DBNull.Value)
						ointake_outtake.out_t_tube = Convert.ToDecimal(dataReader["out_t_tube"]);

					if(dataReader["out_stool"] != DBNull.Value)
						ointake_outtake.out_stool = Convert.ToDecimal(dataReader["out_stool"]);

					if(dataReader["invisible_loss"] != DBNull.Value)
						ointake_outtake.invisible_loss = Convert.ToDecimal(dataReader["invisible_loss"]);

					if(dataReader["out_total"] != DBNull.Value)
						ointake_outtake.out_total = Convert.ToDecimal(dataReader["out_total"]);

					if(dataReader["balance"] != DBNull.Value)
						ointake_outtake.balance = Convert.ToDecimal(dataReader["balance"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ointake_outtake.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ointake_outtake.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ointake_outtake.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ointake_outtake.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
					lstintake_outtakes.Add(ointake_outtake);
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
			return lstintake_outtakes;
		}
		public DataSet Getintake_outtakes()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "intake_outtakeGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}

		}





        public DataSet GetIntakeOutTake(int admissionID)// samia 16Oct
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admission_id", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetIntakeOutTake", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

		public IntakeOuttake Getintake_outtake(int intake_outtake_id)
		{
			SqlConnection conn = null;
			IntakeOuttake ointake_outtake = new IntakeOuttake();
			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@intake_outtake_id", intake_outtake_id);
                SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "intake_outtakeGet", arParams, ref conn);
				while (dataReader.Read())
				{
					ointake_outtake.intake_outtake_id = Convert.ToInt32(dataReader["intake_outtake_id"]);

					if(dataReader["admission_id"] != DBNull.Value)
						ointake_outtake.admission_id = Convert.ToInt32(dataReader["admission_id"]);

					if(dataReader["in_date_time"] != DBNull.Value)
						ointake_outtake.in_date_time = Convert.ToDateTime(dataReader["in_date_time"]);

					if(dataReader["in_oral"] != DBNull.Value)
						ointake_outtake.in_oral = Convert.ToDecimal(dataReader["in_oral"]);

					if(dataReader["in_parenteral"] != DBNull.Value)
						ointake_outtake.in_parenteral = Convert.ToDecimal(dataReader["in_parenteral"]);

					if(dataReader["in_urinary_bladder_wash"] != DBNull.Value)
						ointake_outtake.in_urinary_bladder_wash = Convert.ToDecimal(dataReader["in_urinary_bladder_wash"]);

					if(dataReader["in_total"] != DBNull.Value)
						ointake_outtake.in_total = Convert.ToDecimal(dataReader["in_total"]);

					if(dataReader["out_nasogastric"] != DBNull.Value)
						ointake_outtake.out_nasogastric = Convert.ToDecimal(dataReader["out_nasogastric"]);

					if(dataReader["out_drainage_tube"] != DBNull.Value)
						ointake_outtake.out_drainage_tube = Convert.ToDecimal(dataReader["out_drainage_tube"]);

					if(dataReader["out_urine"] != DBNull.Value)
						ointake_outtake.out_urine = Convert.ToDecimal(dataReader["out_urine"]);

					if(dataReader["out_t_tube"] != DBNull.Value)
						ointake_outtake.out_t_tube = Convert.ToDecimal(dataReader["out_t_tube"]);

					if(dataReader["out_stool"] != DBNull.Value)
						ointake_outtake.out_stool = Convert.ToDecimal(dataReader["out_stool"]);

					if(dataReader["invisible_loss"] != DBNull.Value)
						ointake_outtake.invisible_loss = Convert.ToDecimal(dataReader["invisible_loss"]);

					if(dataReader["out_total"] != DBNull.Value)
						ointake_outtake.out_total = Convert.ToDecimal(dataReader["out_total"]);

					if(dataReader["balance"] != DBNull.Value)
						ointake_outtake.balance = Convert.ToDecimal(dataReader["balance"]);

					if(dataReader["record_created_date"] != DBNull.Value)
						ointake_outtake.record_created_date = Convert.ToDateTime(dataReader["record_created_date"]);

					if(dataReader["record_created_by"] != DBNull.Value)
						ointake_outtake.record_created_by = Convert.ToInt32(dataReader["record_created_by"]);

					if(dataReader["record_modified_date"] != DBNull.Value)
						ointake_outtake.record_modified_date = Convert.ToDateTime(dataReader["record_modified_date"]);

					if(dataReader["record_modified_by"] != DBNull.Value)
						ointake_outtake.record_modified_by = Convert.ToInt32(dataReader["record_modified_by"]);
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
			return ointake_outtake;
		}
		public int Addintake_outtake(IntakeOuttake ointake_outtake)
		{
			SqlParameter[] arParams = new SqlParameter[16];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", ointake_outtake.admission_id);
				arParams[1] = new SqlParameter("@in_date_time", ointake_outtake.in_date_time);
				arParams[2] = new SqlParameter("@in_oral", ointake_outtake.in_oral);
				arParams[3] = new SqlParameter("@in_parenteral", ointake_outtake.in_parenteral);
				arParams[4] = new SqlParameter("@in_urinary_bladder_wash", ointake_outtake.in_urinary_bladder_wash);
				arParams[5] = new SqlParameter("@in_total", ointake_outtake.in_total);
				arParams[6] = new SqlParameter("@out_nasogastric", ointake_outtake.out_nasogastric);
				arParams[7] = new SqlParameter("@out_drainage_tube", ointake_outtake.out_drainage_tube);
				arParams[8] = new SqlParameter("@out_urine", ointake_outtake.out_urine);
				arParams[9] = new SqlParameter("@out_t_tube", ointake_outtake.out_t_tube);
				arParams[10] = new SqlParameter("@out_stool", ointake_outtake.out_stool);
				arParams[11] = new SqlParameter("@invisible_loss", ointake_outtake.invisible_loss);
				arParams[12] = new SqlParameter("@out_total", ointake_outtake.out_total);
				arParams[13] = new SqlParameter("@balance", ointake_outtake.balance);
				arParams[14] = new SqlParameter("@record_created_by", ointake_outtake.record_created_by);
				arParams[15] = new SqlParameter("@record_modified_by", ointake_outtake.record_modified_by);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_outtakeAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateintake_outtake(IntakeOuttake ointake_outtake)
		{

			SqlParameter[] arParams = new SqlParameter[19];
			try
			{
				arParams[0] = new SqlParameter("@admission_id", ointake_outtake.admission_id);
				arParams[1] = new SqlParameter("@in_date_time", ointake_outtake.in_date_time);
				arParams[2] = new SqlParameter("@in_oral", ointake_outtake.in_oral);
				arParams[3] = new SqlParameter("@in_parenteral", ointake_outtake.in_parenteral);
				arParams[4] = new SqlParameter("@in_urinary_bladder_wash", ointake_outtake.in_urinary_bladder_wash);
				arParams[5] = new SqlParameter("@in_total", ointake_outtake.in_total);
				arParams[6] = new SqlParameter("@out_nasogastric", ointake_outtake.out_nasogastric);
				arParams[7] = new SqlParameter("@out_drainage_tube", ointake_outtake.out_drainage_tube);
				arParams[8] = new SqlParameter("@out_urine", ointake_outtake.out_urine);
				arParams[9] = new SqlParameter("@out_t_tube", ointake_outtake.out_t_tube);
				arParams[10] = new SqlParameter("@out_stool", ointake_outtake.out_stool);
				arParams[11] = new SqlParameter("@invisible_loss", ointake_outtake.invisible_loss);
				arParams[12] = new SqlParameter("@out_total", ointake_outtake.out_total);
				arParams[13] = new SqlParameter("@balance", ointake_outtake.balance);
				arParams[14] = new SqlParameter("@record_created_date", ointake_outtake.record_created_date);
				arParams[15] = new SqlParameter("@record_created_by", ointake_outtake.record_created_by);
				arParams[16] = new SqlParameter("@record_modified_date", ointake_outtake.record_modified_date);
				arParams[17] = new SqlParameter("@record_modified_by", ointake_outtake.record_modified_by);
				arParams[18] = new SqlParameter("@intake_outtake_id", ointake_outtake.intake_outtake_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_outtakeUpdate", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_outtake(IntakeOuttake ointake_outtake)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@intake_outtake_id", ointake_outtake.intake_outtake_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_outtakeDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_outtake(int intake_outtake_id)
		{

			try
			{
				SqlParameter[] arParams = new SqlParameter[1];
				arParams[0] = new SqlParameter("@intake_outtake_id", intake_outtake_id);
				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "intake_outtakeDelete", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
