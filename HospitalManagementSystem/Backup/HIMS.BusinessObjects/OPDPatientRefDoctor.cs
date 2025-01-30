using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OPDPatientRefDoctor
{
	private int   _PKID;
	public int  PKID
	{
		get { return _PKID; }
		set { _PKID = value; }
	}
	private string  _RegistrationID;
	public string RegistrationID
	{
		get { return _RegistrationID; }
		set { _RegistrationID = value; }
	}
	private Nullable<int>  _RefDoctorID;
	public Nullable<int> RefDoctorID
	{
		get { return _RefDoctorID; }
		set { _RefDoctorID = value; }
	}
	private Nullable<int>  _RecordeCreatedBy;
	public Nullable<int> RecordeCreatedBy
	{
		get { return _RecordeCreatedBy; }
		set { _RecordeCreatedBy = value; }
	}
	private string  _RecordeCreatedDate;
	public string RecordeCreatedDate
	{
		get { return _RecordeCreatedDate; }
		set { _RecordeCreatedDate = value; }
	}
	private Nullable<int>  _RecordeModifiedBy;
	public Nullable<int> RecordeModifiedBy
	{
		get { return _RecordeModifiedBy; }
		set { _RecordeModifiedBy = value; }
	}
	private string  _RecordeModifiedDate;
	public string RecordeModifiedDate
	{
		get { return _RecordeModifiedDate; }
		set { _RecordeModifiedDate = value; }
	}
	public OPDPatientRefDoctor()
	{ }
	public OPDPatientRefDoctor(int   PKID,string  RegistrationID,Nullable<int>   RefDoctorID,Nullable<int>   RecordeCreatedBy,string  RecordeCreatedDate,Nullable<int>   RecordeModifiedBy,string  RecordeModifiedDate)
	{
		this.PKID=  PKID;
		this.RegistrationID=  RegistrationID;
		this.RefDoctorID=  RefDoctorID;
		this.RecordeCreatedBy=  RecordeCreatedBy;
		this.RecordeCreatedDate=  RecordeCreatedDate;
		this.RecordeModifiedBy=  RecordeModifiedBy;
		this.RecordeModifiedDate=  RecordeModifiedDate;
	}
	public override string ToString()
	{
		return "PKID = " +  PKID.ToString() +"RegistrationID = " +  RegistrationID +"RefDoctorID = " +  RefDoctorID.ToString() +"RecordeCreatedBy = " +  RecordeCreatedBy.ToString() +"RecordeCreatedDate = " +  RecordeCreatedDate +"RecordeModifiedBy = " +  RecordeModifiedBy.ToString() +"RecordeModifiedDate = " +  RecordeModifiedDate;
	}
}

}
