using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class ReceiveBLL
	{
		private ReceiveDAL _receiveDAL;

		public ReceiveDAL receiveDAL
		{
			get { return _receiveDAL; }
			set { _receiveDAL = value; }
		}

		public ReceiveBLL()
		{
			receiveDAL = new ReceiveDAL();
		}
		public List<ReceiveBO> GetreceivesList()
		{
			try
			{
				return receiveDAL.GetreceivesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getreceives()
		{
			try
			{
				return receiveDAL.Getreceives();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetPurchasePopulationInfo()
        {
            try
            {
                return receiveDAL.GetPurchasePopulationInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public ReceiveBO Getreceive(int receive_id)
		{
			try
			{
				return receiveDAL.Getreceive(receive_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        //public int Addreceive(ReceiveBO oreceive)
        //{
        //    try
        //    {
        //        return receiveDAL.Addreceive(oreceive);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
		public int Updatereceive(ReceiveBO oreceive)
		{
			try
			{
				return receiveDAL.Updatereceive(oreceive);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive(ReceiveBO oreceive)
		{
			try
			{
				return receiveDAL.Removereceive(oreceive);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removereceive(int receive_id)
		{
			try
			{
				return receiveDAL.Removereceive(receive_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<ReceiveBO> Deserializereceives(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<ReceiveBO>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializereceives(string Path, List<ReceiveBO> receives)
		{
			try
			{
				GenericXmlSerializer<List<ReceiveBO>>.Serialize(receives, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int ReceiveProductInsert
           (
               ReceiveBO receiveBO,
               List<ReceiveProduct> lstReceiveProduct,
               List<PurchaseProduct> lstPurchaseProduct,
               List<InventoryBO> lstInventoryBO,
               List<ProductBO> lstProductBO

            )
        {
            try
            {
                return receiveDAL.ReceiveProductInsert(receiveBO, lstReceiveProduct, lstPurchaseProduct, lstInventoryBO, lstProductBO);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
	}
}
