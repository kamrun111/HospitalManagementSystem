using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OperationBLL
	{
		private OperationDAL _operationDAL;

		public OperationDAL operationDAL
		{
			get { return _operationDAL; }
			set { _operationDAL = value; }
		}

		public OperationBLL()
		{
			operationDAL = new OperationDAL();
		}
		public List<Operation> GetoperationsList()
		{
			try
			{
				return operationDAL.GetoperationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getoperations()
		{
			try
			{
				return operationDAL.Getoperations();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public Operation Getoperation(int operation_id)
        {
            try
            {
                return operationDAL.GetOperation(operation_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public int Addoperation(Operation ooperation)
		{
			try
			{
				return operationDAL.Addoperation(ooperation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int UpdateOperation(Operation operation)
        {
            try
            {
                return operationDAL.Updateoperation(operation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int RemoveOperation(Operation operation)
        {
            try
            {
                return operationDAL.RemoveOperation(operation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int RemoveOperation(int operation_id)
        {
            try
            {
                return operationDAL.RemoveOperation(operation_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		public List<Operation> Deserializeoperations(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Operation>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoperations(string Path, List<Operation> operations)
		{
			try
			{
				GenericXmlSerializer<List<Operation>>.Serialize(operations, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
