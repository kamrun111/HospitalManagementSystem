using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
    public class ExpenditureOrderBLL
    {
        private ExpenditureOrderDAL _expenditureOrderDAL;

        public ExpenditureOrderDAL expenditureOrderDAL
        {
            get { return _expenditureOrderDAL; }
            set { _expenditureOrderDAL = value; }
        }
        public ExpenditureOrderBLL()
        {
            expenditureOrderDAL = new ExpenditureOrderDAL();
        }

        public int expenditureOrderInsert(ExpenditureOrder expenditureOrder, List<Expenditure> listexpenditure)
        {
            try
            {
                return expenditureOrderDAL.expenditureOrderInsert(expenditureOrder, listexpenditure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExpenditureOrderInsertDialysis(ExpenditureOrder expenditureOrder, List<Expenditure> listexpenditure)
        {
            try
            {
                return expenditureOrderDAL.ExpenditureOrderInsertDialysis(expenditureOrder, listexpenditure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ExpenditureOrderList(DateTime From, DateTime To)
        {
            try
            {
                return expenditureOrderDAL.ExpenditureOrderList(From, To);  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ExpenditureOrderListDialysis(DateTime From, DateTime To)
        {
            try
            {
                return expenditureOrderDAL.ExpenditureOrderListDialysis(From, To);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Collection(DateTime From, DateTime To) 
        {
            try
            {
                return expenditureOrderDAL.Collection(From, To);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Balance(DateTime From, DateTime To)
        {
            try
            {
                return expenditureOrderDAL.Balance(From, To);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
