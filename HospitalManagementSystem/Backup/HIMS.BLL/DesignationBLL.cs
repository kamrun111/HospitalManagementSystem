using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class DesignationBLL
	{
		private DesignationDAL _designationDAL;

		public DesignationDAL designationDAL
		{
			get { return _designationDAL; }
			set { _designationDAL = value; }
		}

		public DesignationBLL()
		{
			designationDAL = new DesignationDAL();
		}
		public List<Designation> GetdesignationsList()
		{
			try
			{
				return designationDAL.GetdesignationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getdesignations()
		{
			try
			{
				return designationDAL.Getdesignations();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public Designation Getdesignation(int designation_id)
		{
			try
			{
				return designationDAL.Getdesignation(designation_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Adddesignation(Designation odesignation)
		{
			try
			{
				return designationDAL.Adddesignation(odesignation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updatedesignation(Designation odesignation)
		{
			try
			{
				return designationDAL.Updatedesignation(odesignation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removedesignation(Designation odesignation)
		{
			try
			{
				return designationDAL.Removedesignation(odesignation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removedesignation(int designation_id)
		{
			try
			{
				return designationDAL.Removedesignation(designation_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<Designation> Deserializedesignations(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<Designation>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializedesignations(string Path, List<Designation> designations)
		{
			try
			{
                GenericXmlSerializer<List<Designation>>.Serialize(designations, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
