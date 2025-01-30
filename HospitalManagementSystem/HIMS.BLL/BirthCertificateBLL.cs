using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;


namespace HIMS.BLL
{
    public class BirthCertificateBLL
    {
        private BirthCertificateDAL _birthCertificateDAL;
        public BirthCertificateDAL birthCertificateDAL
        {
            get { return _birthCertificateDAL; }
            set { _birthCertificateDAL = value; }
        }
        public BirthCertificateBLL()
        {
            birthCertificateDAL = new BirthCertificateDAL();
        }

        public int BirthCertificateAdd(BirthCertificateBO birthCertificateBO)
        {
            try
            {
                return birthCertificateDAL.BirthCertificateAdd(birthCertificateBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BirthCertificateUpdate(BirthCertificateBO birthCertificateBO)
        {
            try
            {
                return birthCertificateDAL.BirthCertificateUpdate(birthCertificateBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
