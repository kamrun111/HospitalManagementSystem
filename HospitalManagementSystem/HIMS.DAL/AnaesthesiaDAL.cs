using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using HIMS.BusinessObjects;

namespace HIMS.DAL
{
	public class AnaesthesiaDAL
	{
		public AnaesthesiaDAL()
		{
		}
		public List<Anaesthesia> GetanaesthesiasList()
		{
			SqlConnection conn = null;
			List<Anaesthesia> lstanaesthesias = new List<Anaesthesia>();
			try
			{
				SqlDataReader dataReader = DbHelper.ExecuteReader(CommandType.StoredProcedure, "anaesthesiaGetAll", null, ref conn);
				while (dataReader.Read())
				{
					Anaesthesia oanaesthesia = new Anaesthesia();
					oanaesthesia.anaesthesia_id = Convert.ToInt32(dataReader["anaesthesia_id"]);

					if(dataReader["anaesthesia_name"] != DBNull.Value)
						oanaesthesia.anaesthesia_name = Convert.ToString(dataReader["anaesthesia_name"]);

					if(dataReader["anaesthesia_nature"] != DBNull.Value)
						oanaesthesia.anaesthesia_nature = Convert.ToString(dataReader["anaesthesia_nature"]);
					lstanaesthesias.Add(oanaesthesia);
				}
				dataReader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				DbHelper.CloseConnection(conn);
			}
			return lstanaesthesias;
		}
		public DataSet Getanaesthesias()
		{
			try
			{
				return DbHelper.GetDataSet(CommandType.StoredProcedure, "anaesthesiaGetAll");
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
			}
		}
		public int Addanaesthesia(Anaesthesia oanaesthesia)
		{
			SqlParameter[] arParams = new SqlParameter[2];
			try
			{
				arParams[0] = new SqlParameter("@anaesthesia_name", oanaesthesia.anaesthesia_name);
				arParams[1] = new SqlParameter("@anaesthesia_nature", oanaesthesia.anaesthesia_nature);

				return DbHelper.ExecuteNonQuery(CommandType.StoredProcedure, "anaesthesiaAdd", arParams);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
