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
    public class VehicleLogDAL
    {
        public VehicleLogDAL()
        {
        }
        public DataSet GetVehicle(int vehicle_type_id)
        {
            try
            {
                SqlParameter[] arParams = new SqlParameter[1];
                arParams[0] = new SqlParameter("@vehicle_type_id", vehicle_type_id);
                return DbHelper.GetDataSet(CommandType.StoredProcedure, "GetVehicle", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
        public int vehicleLogSave(VehicleLog oVehicleLog)
        {
            SqlParameter[] arParams = new SqlParameter[13];
            try
            {
                arParams[0] = new SqlParameter("@vehicle_no", oVehicleLog.vehicle_no);
                arParams[1] = new SqlParameter("@starting_date", oVehicleLog.starting_date);
                arParams[2] = new SqlParameter("@ending_date", oVehicleLog.ending_date);
                arParams[3] = new SqlParameter("@start_km", oVehicleLog.staring_km);
                arParams[4] = new SqlParameter("@end_km", oVehicleLog.end_km);
                arParams[5] = new SqlParameter("@destination", oVehicleLog.destination);
                arParams[6] = new SqlParameter("@total_amount", oVehicleLog.total_amount);
                arParams[7] = new SqlParameter("@fual_typeID", oVehicleLog.fuel_typeId);
                arParams[8] = new SqlParameter("@quantity", oVehicleLog.quantity);
                arParams[9] = new SqlParameter("@remarks", oVehicleLog.remarks);
                arParams[10] = new SqlParameter("@driver", oVehicleLog.driver);
                arParams[11] = new SqlParameter("@customer_name", oVehicleLog.customer_name);
                arParams[12] = new SqlParameter("@record_created_by", oVehicleLog.record_created_by);


                return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "vehicleLogSave", arParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
