using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class IndentBLL
	{
		private IndentDAL _indentDAL;

		public IndentDAL indentDAL
		{
			get { return _indentDAL; }
			set { _indentDAL = value; }
		}

		public IndentBLL()
		{
			indentDAL = new IndentDAL();
		}
		public List<Indent> GetindentsList()
		{
			try
			{
				return indentDAL.GetindentsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getindents()
		{
			try
			{
				return indentDAL.Getindents();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public Indent Getindent(int indent_id)
		{
			try
			{
				return indentDAL.Getindent(indent_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addindent(Indent oindent)
		{
			try
			{
				return indentDAL.Addindent(oindent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateindent(Indent oindent)
		{
			try
			{
				return indentDAL.Updateindent(oindent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeindent(Indent oindent)
		{
			try
			{
				return indentDAL.Removeindent(oindent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeindent(int indent_id)
		{
			try
			{
				return indentDAL.Removeindent(indent_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Indent> Deserializeindents(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<Indent>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeindents(string Path, List<Indent> indents)
		{
			try
			{
				GenericXmlSerializer<List<Indent>>.Serialize(indents, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
