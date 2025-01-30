using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class PatientInventoryBLL
    {
        private PatientInventoryDAL _patientInventoryDAl;

        public PatientInventoryDAL patientInventoryDAl
		{
            get { return _patientInventoryDAl; }
            set { _patientInventoryDAl = value; }
		}

        public PatientInventoryBLL()
		{
            patientInventoryDAl = new PatientInventoryDAL();
		}
    }
}
