using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class DosePreQuantityBLL
	{
		private DosePerQuantityDAL _dose_p_quantityDAL;

		public DosePerQuantityDAL dose_p_quantityDAL
		{
			get { return _dose_p_quantityDAL; }
			set { _dose_p_quantityDAL = value; }
		}

		public DosePreQuantityBLL()
		{
			dose_p_quantityDAL = new DosePerQuantityDAL();
		}
		public List<DosePerQuantity> Getdose_p_quantitysList()
		{
			try
			{
				return dose_p_quantityDAL.Getdose_p_quantitysList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getdose_p_quantitys()
		{
			try
			{
				return dose_p_quantityDAL.Getdose_p_quantitys();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public DataSet DoseQuantity()
        {
            try
            {
                return dose_p_quantityDAL.DoseQuantity();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public DosePerQuantity Getdose_p_quantity(int dose_p_quantity_id)
		{
			try
			{
				return dose_p_quantityDAL.Getdose_p_quantity(dose_p_quantity_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Adddose_p_quantity(DosePerQuantity odose_p_quantity)
		{
			try
			{
				return dose_p_quantityDAL.Adddose_p_quantity(odose_p_quantity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int newDossQtyAdd(DosePerQuantity odose_p_quantity)
        {
            try
            {
                return dose_p_quantityDAL.newDossQtyAdd(odose_p_quantity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Updatedose_p_quantity(DosePerQuantity odose_p_quantity)
		{
			try
			{
				return dose_p_quantityDAL.Updatedose_p_quantity(odose_p_quantity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedose_p_quantity(DosePerQuantity odose_p_quantity)
		{
			try
			{
				return dose_p_quantityDAL.Removedose_p_quantity(odose_p_quantity);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedose_p_quantity(int dose_p_quantity_id)
		{
			try
			{
				return dose_p_quantityDAL.Removedose_p_quantity(dose_p_quantity_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<DosePerQuantity> Deserializedose_p_quantitys(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<DosePerQuantity>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializedose_p_quantitys(string Path, List<DosePerQuantity> dose_p_quantitys)
		{
			try
			{
				GenericXmlSerializer<List<DosePerQuantity>>.Serialize(dose_p_quantitys, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
