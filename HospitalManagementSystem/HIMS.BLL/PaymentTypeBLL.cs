using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class PaymentTypeBLL
	{
		private PaymentTypeDAL _payment_typeDAL;

		public PaymentTypeDAL payment_typeDAL
		{
			get { return _payment_typeDAL; }
			set { _payment_typeDAL = value; }
		}

		public PaymentTypeBLL()
		{
			payment_typeDAL = new PaymentTypeDAL();
		}
		public List<PaymentType> Getpayment_typesList()
		{
			try
			{
				return payment_typeDAL.Getpayment_typesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getpayment_types()
		{
			try
			{
				return payment_typeDAL.Getpayment_types();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addpayment_type(PaymentType opayment_type)
		{
			try
			{
				return payment_typeDAL.Addpayment_type(opayment_type);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<PaymentType> Deserializepayment_types(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<PaymentType>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializepayment_types(string Path, List<PaymentType> payment_types)
		{
			try
			{
                GenericXmlSerializer<List<PaymentType>>.Serialize(payment_types, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
