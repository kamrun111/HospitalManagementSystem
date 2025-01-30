using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class GuardianRelationBLL
	{
		private GuardianRelationDAL _guardian_relationDAL;

		public GuardianRelationDAL guardian_relationDAL
		{
			get { return _guardian_relationDAL; }
			set { _guardian_relationDAL = value; }
		}

		public GuardianRelationBLL()
		{
			guardian_relationDAL = new GuardianRelationDAL();
		}
        public List<GuardianRelation> Getguardian_relationsList()
		{
			try
			{
				return guardian_relationDAL.Getguardian_relationsList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getguardian_relations()
		{
			try
			{
				return guardian_relationDAL.Getguardian_relations();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public GuardianRelation Getguardian_relation(int guardian_relation_id)
		{
			try
			{
				return guardian_relationDAL.Getguardian_relation(guardian_relation_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
        public int Addguardian_relation(GuardianRelation oguardian_relation)
		{
			try
			{
				return guardian_relationDAL.Addguardian_relation(oguardian_relation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Updateguardian_relation(GuardianRelation oguardian_relation)
		{
			try
			{
				return guardian_relationDAL.Updateguardian_relation(oguardian_relation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public int Removeguardian_relation(GuardianRelation oguardian_relation)
		{
			try
			{
				return guardian_relationDAL.Removeguardian_relation(oguardian_relation);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeguardian_relation(int guardian_relation_id)
		{
			try
			{
				return guardian_relationDAL.Removeguardian_relation(guardian_relation_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public List<GuardianRelation> Deserializeguardian_relations(string Path)
		{
			try
			{
                return GenericXmlSerializer<List<GuardianRelation>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        public void Serializeguardian_relations(string Path, List<GuardianRelation> guardian_relations)
		{
			try
			{
                GenericXmlSerializer<List<GuardianRelation>>.Serialize(guardian_relations, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
