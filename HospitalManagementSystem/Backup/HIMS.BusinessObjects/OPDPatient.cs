using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OPDPatient
{
        private int _opd_patient_id;
        public int opd_patient_id
	{
        get { return _opd_patient_id; }
        set { _opd_patient_id = value; }
	}
	private string  _OPDPatientID;
	public string OPDPatientID
	{
		get { return _OPDPatientID; }
		set { _OPDPatientID = value; }
	}
	private string  _PatientName;
	public string PatientName
	{
		get { return _PatientName; }
		set { _PatientName = value; }
	}
	private string  _GardianName;
	public string GardianName
	{
		get { return _GardianName; }
		set { _GardianName = value; }
	}
	private Nullable<int>  _GardianRelationID;
	public Nullable<int> GardianRelationID
	{
		get { return _GardianRelationID; }
		set { _GardianRelationID = value; }
	}
	private Nullable<int>  _GenderID;
	public Nullable<int> GenderID
	{
		get { return _GenderID; }
		set { _GenderID = value; }
	}
	private Nullable<int>  _OcupationID;
	public Nullable<int> OcupationID
	{
		get { return _OcupationID; }
		set { _OcupationID = value; }
	}
	private string  _Address;
	public string Address
	{
		get { return _Address; }
		set { _Address = value; }
	}
	private string  _Phone;
	public string Phone
	{
		get { return _Phone; }
		set { _Phone = value; }
	}
	private string  _Age;
	public string Age
	{
		get { return _Age; }
		set { _Age = value; }
	}
	private Nullable<int>  _NationalityID;
	public Nullable<int> NationalityID
	{
		get { return _NationalityID; }
		set { _NationalityID = value; }
	}
	private Nullable<int>  _ReligionID;
	public Nullable<int> ReligionID
	{
		get { return _ReligionID; }
		set { _ReligionID = value; }
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
	public OPDPatient()
	{ }
        public OPDPatient(int opd_patient_id, string OPDPatientID, string PatientName, string GardianName, Nullable<int> GardianRelationID, Nullable<int> GenderID, Nullable<int> OcupationID, string Address, string Phone, string Age, Nullable<int> NationalityID, Nullable<int> ReligionID, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
	{
        this.opd_patient_id = opd_patient_id;
		this.OPDPatientID=  OPDPatientID;
		this.PatientName=  PatientName;
		this.GardianName=  GardianName;
		this.GardianRelationID=  GardianRelationID;
		this.GenderID=  GenderID;
		this.OcupationID=  OcupationID;
		this.Address=  Address;
		this.Phone=  Phone;
		this.Age=  Age;
		this.NationalityID=  NationalityID;
		this.ReligionID=  ReligionID;
		this.RecordeCreatedBy=  RecordeCreatedBy;
		this.RecordeCreatedDate=  RecordeCreatedDate;
		this.RecordeModifiedBy=  RecordeModifiedBy;
		this.RecordeModifiedDate=  RecordeModifiedDate;
	}
	public override string ToString()
	{
        return "PKID = " + opd_patient_id.ToString() + "OPDPatientID = " + OPDPatientID + "PatientName = " + PatientName + "GardianName = " + GardianName + "GardianRelationID = " + GardianRelationID.ToString() + "GenderID = " + GenderID.ToString() + "OcupationID = " + OcupationID.ToString() + "Address = " + Address + "Phone = " + Phone + "Age = " + Age + "NationalityID = " + NationalityID.ToString() + "ReligionID = " + ReligionID.ToString() + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
	}
}

}
