using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class DeathCertificateBLL
    {
        private DeathCertificateDAL _deathCertificateDAL;
        public DeathCertificateDAL deathCertificateDAL
        {
            get { return _deathCertificateDAL; }
            set { _deathCertificateDAL = value; }
        }
        public DeathCertificateBLL()
        {
            deathCertificateDAL = new DeathCertificateDAL();
        }

        public int DeathCertificateAdd(DeathCertificateBO deathCertificateBO)
        {
            try
            {
                return deathCertificateDAL.DeathCertificateAdd(deathCertificateBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeathCertificateUpdate(DeathCertificateBO deathCertificateBO)
        {
            try
            {
                return deathCertificateDAL.DeathCertificateUpdate(deathCertificateBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
