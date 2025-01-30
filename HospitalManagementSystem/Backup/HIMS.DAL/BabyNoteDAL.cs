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
	public class BabyNoteDAL
	{
		public BabyNoteDAL()
		{
		}
		public List<BabyNote> Getbaby_notesList()
		{
			SqlConnection conn = null;
			List<BabyNote> lstbaby_notes = new List<BabyNote>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "baby_noteGetAll", null, ref conn);
				while (dataReader.Read())
				{
					BabyNote obaby_note = new BabyNote();
					obaby_note.baby_note_id = Convert.ToInt32(dataReader["baby_note_id"]);

					if(dataReader["date_time"] != DBNull.Value)
						obaby_note.date_time = Convert.ToDateTime(dataReader["date_time"]);

					if(dataReader["a_s"] != DBNull.Value)
						obaby_note.a_s = Convert.ToString(dataReader["a_s"]);

					if(dataReader["sex"] != DBNull.Value)
						obaby_note.sex = Convert.ToInt16(dataReader["sex"]);

					if(dataReader["weight"] != DBNull.Value)
						obaby_note.weight = Convert.ToString(dataReader["weight"]);
					lstbaby_notes.Add(obaby_note);
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
			return lstbaby_notes;
		}
		public DataSet Getbaby_notes()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "baby_noteGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}

        public DataSet BabynoteLoad(int admissionID)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@admissionID", admissionID);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "BabynoteLoad", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int baby_noteAdd(BabyNote obaby_note, OperationNote ooperationNote)
		{
            int result = 0;
            SqlConnection conn = DbHelper.GetOpenConnection();
            SqlParameter[] arParams = new SqlParameter[9];
			
			try
			{
				arParams[0] = new SqlParameter("@date_time", obaby_note.date_time);
				arParams[1] = new SqlParameter("@a_s", obaby_note.a_s);
				arParams[2] = new SqlParameter("@sex", obaby_note.sex);
				arParams[3] = new SqlParameter("@weight", obaby_note.weight);
                arParams[4] = new SqlParameter("@baby_note_id", obaby_note.baby_note_id);
                arParams[5] = new SqlParameter("@record_created_by", obaby_note.record_created_by);
                arParams[6] = new SqlParameter("@admission_id", ooperationNote.admission_id);
                arParams[7] = new SqlParameter("@record_modified_by", ooperationNote.record_modified_by);
                arParams[8] = new SqlParameter("@c_a", obaby_note.c_a);
                arParams[4].Direction = ParameterDirection.Output;


                SqlHelper.ExecuteNonQuery(conn, CommandType.StoredProcedure, "baby_noteAdd", arParams);
                result = Convert.ToInt32(arParams[4].Value.ToString());

                //return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "baby_noteAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
            return result;
		}

        public int babyNoteupdate(BabyNote obaby_note)
        {
            SqlParameter[] arParams = new SqlParameter[7];
            try
            {
                arParams[0] = new SqlParameter("@date_time", obaby_note.date_time);
                arParams[1] = new SqlParameter("@a_s", obaby_note.a_s);
                arParams[2] = new SqlParameter("@sex", obaby_note.sex);
                arParams[3] = new SqlParameter("@weight", obaby_note.weight);
                arParams[4] = new SqlParameter("@baby_note_id", obaby_note.baby_note_id);
                arParams[5] = new SqlParameter("@record_modified_by", obaby_note.record_modified_by);
                arParams[6] = new SqlParameter("@c_a", obaby_note.c_a);
                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "babyNoteupdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
