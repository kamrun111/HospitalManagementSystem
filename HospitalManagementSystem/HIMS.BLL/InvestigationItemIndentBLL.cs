using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class InvestigationItemIndentBLL
	{
		private InvestigationItemIndentDAL _investigation_item_indentDAL;

		public InvestigationItemIndentDAL investigation_item_indentDAL
		{
			get { return _investigation_item_indentDAL; }
			set { _investigation_item_indentDAL = value; }
		}

		public InvestigationItemIndentBLL()
		{
			investigation_item_indentDAL = new InvestigationItemIndentDAL();
		}
		public List<InvestigationItemIndent> Getinvestigation_item_indentsList()
		{
			try
			{
				return investigation_item_indentDAL.Getinvestigation_item_indentsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet GetInvestigationItemindentWithItems()
		{
			try
			{
                return investigation_item_indentDAL.GetInvestigationItemindentWithItems();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
            
            public DataSet Getinvestigation_item_indents()
		{
			try
			{
				return investigation_item_indentDAL.Getinvestigation_item_indents();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public InvestigationItemIndent Getinvestigation_item_indent(int investigation_item_indent_id)
		{
			try
			{
				return investigation_item_indentDAL.Getinvestigation_item_indent(investigation_item_indent_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addinvestigation_item_indent(InvestigationItemIndent oinvestigation_item_indent)
		{
			try
			{
				return investigation_item_indentDAL.Addinvestigation_item_indent(oinvestigation_item_indent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateinvestigation_item_indent(InvestigationItemIndent oinvestigation_item_indent)
		{
			try
			{
				return investigation_item_indentDAL.Updateinvestigation_item_indent(oinvestigation_item_indent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_indent(InvestigationItemIndent oinvestigation_item_indent)
		{
			try
			{
				return investigation_item_indentDAL.Removeinvestigation_item_indent(oinvestigation_item_indent);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeinvestigation_item_indent(int investigation_item_indent_id)
		{
			try
			{
				return investigation_item_indentDAL.Removeinvestigation_item_indent(investigation_item_indent_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<InvestigationItemIndent> Deserializeinvestigation_item_indents(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<InvestigationItemIndent>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeinvestigation_item_indents(string Path, List<InvestigationItemIndent> investigation_item_indents)
		{
			try
			{
				GenericXmlSerializer<List<InvestigationItemIndent>>.Serialize(investigation_item_indents, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
