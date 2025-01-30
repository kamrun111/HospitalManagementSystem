using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class VehicleLogBLL
    {

        private VehicleLogDAL _vehicleLogDAL;

        public VehicleLogDAL vehicleLogDAL
		{
            get { return _vehicleLogDAL; }
            set { _vehicleLogDAL = value; }
		}

        public VehicleLogBLL()
		{
            vehicleLogDAL = new VehicleLogDAL();
		}
        public DataSet GetVehicle(int vehicle_type_id)//khuku
        {
            try
            {
                return vehicleLogDAL.GetVehicle(vehicle_type_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int vehicleLogSave(VehicleLog oVehicleLog)
        {
            try
            {
                return vehicleLogDAL.vehicleLogSave(oVehicleLog);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
