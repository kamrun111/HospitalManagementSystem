using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class IntakeOuttakeBLL
	{
		private IntakeOuttakeDAL _intake_outtakeDAL;

		public IntakeOuttakeDAL intake_outtakeDAL
		{
			get { return _intake_outtakeDAL; }
			set { _intake_outtakeDAL = value; }
		}

		public IntakeOuttakeBLL()
		{
			intake_outtakeDAL = new IntakeOuttakeDAL();
		}
		public List<IntakeOuttake> Getintake_outtakesList()
		{
			try
			{
				return intake_outtakeDAL.Getintake_outtakesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getintake_outtakes()
		{
			try
			{
				return intake_outtakeDAL.Getintake_outtakes();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}


        public DataSet GetIntakeOutTake(int admisionID)//samia 16 oct
        {
            try
            {
                return intake_outtakeDAL.GetIntakeOutTake(admisionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public IntakeOuttake Getintake_outtake(int intake_outtake_id)
		{
			try
			{
				return intake_outtakeDAL.Getintake_outtake(intake_outtake_id);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public int Addintake_outtake(IntakeOuttake ointake_outtake)
		{
			try
			{
				return intake_outtakeDAL.Addintake_outtake(ointake_outtake);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Updateintake_outtake(IntakeOuttake ointake_outtake)
		{
			try
			{
				return intake_outtakeDAL.Updateintake_outtake(ointake_outtake);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_outtake(IntakeOuttake ointake_outtake)
		{
			try
			{
				return intake_outtakeDAL.Removeintake_outtake(ointake_outtake);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int Removeintake_outtake(int intake_outtake_id)
		{
			try
			{
				return intake_outtakeDAL.Removeintake_outtake(intake_outtake_id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<IntakeOuttake> Deserializeintake_outtakes(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<IntakeOuttake>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeintake_outtakes(string Path, List<IntakeOuttake> intake_outtakes)
		{
			try
			{
				GenericXmlSerializer<List<IntakeOuttake>>.Serialize(intake_outtakes, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
