using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class IntakeSysBLL
	{
		private IntakeSysDAL _intake_sysDAL;

		public IntakeSysDAL intake_sysDAL
		{
			get { return _intake_sysDAL; }
			set { _intake_sysDAL = value; }
		}

		public IntakeSysBLL()
		{
			intake_sysDAL = new IntakeSysDAL();
		}
		public List<IntakeSys> Getintake_syssList()
		{
			try
			{
				return intake_sysDAL.Getintake_syssList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getintake_syss()
		{
			try
			{
				return intake_sysDAL.Getintake_syss();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public IntakeSys Getintake_sys(int intake_sys_id)
		{
			try
			{
				return intake_sysDAL.Getintake_sys(intake_sys_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addintake_sys(IntakeSys ointake_sys)
		{
			try
			{
				return intake_sysDAL.Addintake_sys(ointake_sys);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateintake_sys(IntakeSys ointake_sys)
		{
			try
			{
				return intake_sysDAL.Updateintake_sys(ointake_sys);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_sys(IntakeSys ointake_sys)
		{
			try
			{
				return intake_sysDAL.Removeintake_sys(ointake_sys);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_sys(int intake_sys_id)
		{
			try
			{
				return intake_sysDAL.Removeintake_sys(intake_sys_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<IntakeSys> Deserializeintake_syss(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<IntakeSys>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeintake_syss(string Path, List<IntakeSys> intake_syss)
		{
			try
			{
				GenericXmlSerializer<List<IntakeSys>>.Serialize(intake_syss, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
