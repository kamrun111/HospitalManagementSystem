using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OPDPatientBLL
	{
        private OPDPatientDAL _oPDPatientDAL;

        public OPDPatientDAL oPDPatientDAL
        {
            get { return _oPDPatientDAL; }
            set { _oPDPatientDAL = value; }
        }

        public OPDPatientBLL()
        {
            oPDPatientDAL = new OPDPatientDAL();
        }
        public DataSet PopulateOPDPatientInfo()
        {
            try
            {
                return oPDPatientDAL.PopulateOPDPatientInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOPDCategory()
        {
            try
            {
                return oPDPatientDAL.GetOPDCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOPDRefDoctor(string RegID)
        {
            try
            {

                return oPDPatientDAL.GetOPDRefDoctor(RegID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOPDHistoryHead()
        {
            try
            {
                return oPDPatientDAL.GetOPDHistoryHead();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddOPDPatientHistory(OPDHistoryTable oPDHistoryTable)
        {
            try
            {
                return oPDPatientDAL.AddOPDPatientHistory(oPDHistoryTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetOPDHistoryResult(string RegID)
        {
            try
            {

                return oPDPatientDAL.GetOPDHistoryResult(RegID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteOPDHistory(string RegID)
        {
            try
            {
                return oPDPatientDAL.DeleteOPDHistory(RegID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetPaymentInvoiceNoList(string RegID)
        {
            try
            {

                return oPDPatientDAL.GetPaymentInvoiceNoList(RegID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}