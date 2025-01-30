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
    public class OTInformationDAL
    {
        public OTInformationDAL()
        {
        }
        public DataSet OTInformationLoad(int admission_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", admission_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTInformationLoad", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataSet OTInformationLoadICU(int admission_id)
        {
            SqlParameter[] arParams = new SqlParameter[1];
            try
            {
                arParams[0] = new SqlParameter("@admission_id", admission_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "OTInformationLoad_ICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public int OTInformationAdd(OTInformation oTInformation)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                //arParams[0] = new SqlParameter("@admission_id", oTInformation.admission_id);
                //arParams[1] = new SqlParameter("@ot_reg", oTInformation.ot_reg);
                arParams[0] = new SqlParameter("@ot_name", oTInformation.ot_name);
                arParams[1] = new SqlParameter("@ot_date", oTInformation.ot_date);
                arParams[2] = new SqlParameter("@start_time", oTInformation.start_time);
                arParams[3] = new SqlParameter("@finish_time", oTInformation.finish_time);
                arParams[4] = new SqlParameter("@anaesthesia_type", oTInformation.anaesthesia_type);
                arParams[5] = new SqlParameter("@blood_transfusion", oTInformation.blood_transfusion);
                arParams[6] = new SqlParameter("@baby_note", oTInformation.baby_note);
                arParams[7] = new SqlParameter("@others", oTInformation.others);
                arParams[8] = new SqlParameter("@record_created_by", oTInformation.record_created_by);
                arParams[9] = new SqlParameter("@admission_id", oTInformation.admission_id);
                


                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTInformationAdd", arParams);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTInformationAddICU(OTInformation oTInformation)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                //arParams[0] = new SqlParameter("@admission_id", oTInformation.admission_id);
                //arParams[1] = new SqlParameter("@ot_reg", oTInformation.ot_reg);
                arParams[0] = new SqlParameter("@ot_name", oTInformation.ot_name);
                arParams[1] = new SqlParameter("@ot_date", oTInformation.ot_date);
                arParams[2] = new SqlParameter("@start_time", oTInformation.start_time);
                arParams[3] = new SqlParameter("@finish_time", oTInformation.finish_time);
                arParams[4] = new SqlParameter("@anaesthesia_type", oTInformation.anaesthesia_type);
                arParams[5] = new SqlParameter("@blood_transfusion", oTInformation.blood_transfusion);
                arParams[6] = new SqlParameter("@baby_note", oTInformation.baby_note);
                arParams[7] = new SqlParameter("@others", oTInformation.others);
                arParams[8] = new SqlParameter("@record_created_by", oTInformation.record_created_by);
                arParams[9] = new SqlParameter("@admission_id", oTInformation.admission_id);



                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTInformationAddICU", arParams);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTInformationUpdate(OTInformation oTInformation)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                arParams[0] = new SqlParameter("@ot_information_id", oTInformation.ot_information_id);
                arParams[1] = new SqlParameter("@ot_name", oTInformation.ot_name);
                arParams[2] = new SqlParameter("@ot_date", oTInformation.ot_date);
                arParams[3] = new SqlParameter("@start_time", oTInformation.start_time);
                arParams[4] = new SqlParameter("@finish_time", oTInformation.finish_time);
                arParams[5] = new SqlParameter("@anaesthesia_type", oTInformation.anaesthesia_type);
                arParams[6] = new SqlParameter("@blood_transfusion", oTInformation.blood_transfusion);
                arParams[7] = new SqlParameter("@baby_note", oTInformation.baby_note);
                arParams[8] = new SqlParameter("@others", oTInformation.others);
                arParams[9] = new SqlParameter("@record_modified_by", oTInformation.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTInformationUpdate", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTInformationUpdateICU(OTInformation oTInformation)
        {
            SqlParameter[] arParams = new SqlParameter[10];
            try
            {
                arParams[0] = new SqlParameter("@ot_information_id", oTInformation.ot_information_id);
                arParams[1] = new SqlParameter("@ot_name", oTInformation.ot_name);
                arParams[2] = new SqlParameter("@ot_date", oTInformation.ot_date);
                arParams[3] = new SqlParameter("@start_time", oTInformation.start_time);
                arParams[4] = new SqlParameter("@finish_time", oTInformation.finish_time);
                arParams[5] = new SqlParameter("@anaesthesia_type", oTInformation.anaesthesia_type);
                arParams[6] = new SqlParameter("@blood_transfusion", oTInformation.blood_transfusion);
                arParams[7] = new SqlParameter("@baby_note", oTInformation.baby_note);
                arParams[8] = new SqlParameter("@others", oTInformation.others);
                arParams[9] = new SqlParameter("@record_modified_by", oTInformation.record_modified_by);

                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "OTInformationUpdateICU", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
