using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class OperationNoteBLL
	{
		private Operation_noteDAL _operation_noteDAL;

		public Operation_noteDAL operation_noteDAL
		{
			get { return _operation_noteDAL; }
			set { _operation_noteDAL = value; }
		}

		public OperationNoteBLL()
		{
			operation_noteDAL = new Operation_noteDAL();
		}
		public List<OperationNote> Getoperation_notesList()
		{
			try
			{
				return operation_noteDAL.Getoperation_notesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getoperation_notes()
		{
			try
			{
				return operation_noteDAL.Getoperation_notes();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet GetOTNurseInfo()//sami 27 nov 2008
        {
            try
            {
                return operation_noteDAL.GetOTNurseInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet getprocedureforOT(int TreatmentID)// sammi
        {
            try
            {
                return operation_noteDAL.getprocedureforOT(TreatmentID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public int Addoperation_note(OperationNote ooperation_note)
		{
			try
			{
				return operation_noteDAL.Addoperation_note(ooperation_note);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int DoctotOTDeclare(OperationNote ooperation_note)//sami
        {
            try
            {
                return operation_noteDAL.DoctotOTDeclare(ooperation_note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public DataSet GetOTNoteInfo(int admisionID)// sammi
        {
            try
            {
                return operation_noteDAL.GetOTNoteInfo(admisionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet OTlink(int admisionID)// sammi 2 feb2008
        {
            try
            {
                return operation_noteDAL.OTlink(admisionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet OTNurseCmb(int admisionID)// sammi 30 nov
        {
            try
            {
                return operation_noteDAL.OTNurseCmb(admisionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTSubmit(OperationNote ooperation_note)//sami 1feb 2009
        {
            try
            {
                return operation_noteDAL.OTSubmit(ooperation_note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTNurseUpdate(OperationNote ooperation_note)
        {
            try
            {
                return operation_noteDAL.OTNurseUpdate(ooperation_note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int OperationBabyNoteUpdate(OperationNote ooperation_note)//sami 10th jan 2009
        {
            try
            {
                return operation_noteDAL.OperationBabyNoteUpdate(ooperation_note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTnoteMedicineUpdate(OperationNote ooperation_note)//sami 1 janu2009
        {
            try
            {
                return operation_noteDAL.OTnoteMedicineUpdate(ooperation_note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet OTNurseText(int admissionID)// sammi 30 nov 2008
        {
            try
            {
                return operation_noteDAL.OTNurseText(admissionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int OTnurseDischarge(OperationNote ooperation_note)//sami 14 janu2009
        {
            try
            {
                return operation_noteDAL.OTnurseDischarge(ooperation_note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<OperationNote> Deserializeoperation_notes(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<OperationNote>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializeoperation_notes(string Path, List<OperationNote> operation_notes)
		{
			try
			{
				GenericXmlSerializer<List<OperationNote>>.Serialize(operation_notes, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
