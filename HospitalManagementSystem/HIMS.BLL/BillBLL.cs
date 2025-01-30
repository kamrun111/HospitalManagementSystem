using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class BillBLL
	{
		private BillDAL _billDAL;

		public BillDAL billDAL
		{
			get { return _billDAL; }
			set { _billDAL = value; }
		}

        public BillBLL()
		{
            billDAL = new BillDAL();
		}
        public List<BillBO> GetbillList()
		{
			try
			{
                return billDAL.GetbillList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet GetDiscountPatient()
        {
            try
            {
                return billDAL.GetDiscountPatient();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getexpences()
        {
            try
            {
                return billDAL.getexpences();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet IPDPayDetails(int admissionID)
        {
            try
            {
                return billDAL.IPDPayDetails(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet InvestigationBill(int admissionID)
        {
            try
            {
                return billDAL.InvestigationBill(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet advance(int admissionID)
        {
            try
            {
                return billDAL.advance(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet InvestigationBill1(int admissionID)
        {
            try
            {
                return billDAL.InvestigationBill1(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet populatePatientbill(int admissionID)
        {
            try
            {
                return billDAL.populatePatientbill(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet BillAmount(int admissionID)
        {
            try
            {
                return billDAL.BillAmount(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public int BillAdd(BillBO obill)
        //{
        //    try
        //    {
        //        return billDAL.BillAdd(obill);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int BillInsert(BillBO billBO, AdmissionBO admissionBO, List<DoctorsBillBO> lstDoctorsBillBO, Pay opay)
        {
            try
            {
                return billDAL.BillInsert(billBO, admissionBO, lstDoctorsBillBO, opay);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int NewBillAdd(BillBO billBO, AdmissionBO admissionBO, InpatientAccount inpatientAccount)
        {
            try
            {
                return billDAL.NewBillAdd(billBO, admissionBO, inpatientAccount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int NewBillaccount(BillBO billBO, AdmissionBO admissionBO, InpatientAccount inpatientAccount)
        {
            try
            {
                return billDAL.NewBillaccount(billBO, admissionBO, inpatientAccount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void BillUpdate(BillBO billBO, AdmissionBO admissionBO, List<DoctorsBillBO> lstDoctorsBillBO, Pay opay)
        {
            try
            {
                 billDAL.BillUpdate(billBO, admissionBO, lstDoctorsBillBO, opay);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void NewBillUpdate(BillBO billBO, AdmissionBO admissionBO)
        {
            try
            {
                billDAL.NewBillUpdate(billBO, admissionBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DiscountBillUpdate(BillBO billBO)
        {
            try
            {
                return billDAL.DiscountBillUpdate(billBO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void NewBillaccountUpdate(BillBO billBO, AdmissionBO admissionBO, InpatientAccount inpatientAccount)
        {
            try
            {
                billDAL.NewBillaccountUpdate(billBO, admissionBO, inpatientAccount);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
