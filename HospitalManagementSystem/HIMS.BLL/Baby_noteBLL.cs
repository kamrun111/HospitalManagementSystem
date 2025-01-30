using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;
using HIMS.DAL;

namespace HIMS.BLL
{
	public class Baby_noteBLL
	{
		private BabyNoteDAL _baby_noteDAL;

		public BabyNoteDAL baby_noteDAL
		{
			get { return _baby_noteDAL; }
			set { _baby_noteDAL = value; }
		}

		public Baby_noteBLL()
		{
			baby_noteDAL = new BabyNoteDAL();
		}
		public List<BabyNote> Getbaby_notesList()
		{
			try
			{
				return baby_noteDAL.Getbaby_notesList();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		public DataSet Getbaby_notes()
		{
			try
			{
				return baby_noteDAL.Getbaby_notes();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public DataSet BabynoteLoad(int admisionID)// sammi
        {
            try
            {
                return baby_noteDAL.BabynoteLoad(admisionID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int baby_noteAdd(BabyNote obaby_note, OperationNote ooperationNote)
		{
			try
			{
                return baby_noteDAL.baby_noteAdd(obaby_note, ooperationNote);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public int babyNoteupdate(BabyNote obaby_note)
        {
            try
            {
                return baby_noteDAL.babyNoteupdate(obaby_note);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		public List<BabyNote> Deserializebaby_notes(string Path)
		{
			try
			{
				return GenericXmlSerializer<List<BabyNote>>.Deserialize(Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public void Serializebaby_notes(string Path, List<BabyNote> baby_notes)
		{
			try
			{
				GenericXmlSerializer<List<BabyNote>>.Serialize(baby_notes, Path);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
