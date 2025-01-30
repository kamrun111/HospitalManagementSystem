using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OPDPayTable
{
    private int _PKID;
    public int PKID
    {
        get { return _PKID; }
        set { _PKID = value; }
    }
    private string _RegistrationID;
    public string RegistrationID
    {
        get { return _RegistrationID; }
        set { _RegistrationID = value; }
    }
    private Nullable<decimal> _Amount;
    public Nullable<decimal> Amount
    {
        get { return _Amount; }
        set { _Amount = value; }
    }
    private Nullable<int> _PaymentTypeID;
    public Nullable<int> PaymentTypeID
    {
        get { return _PaymentTypeID; }
        set { _PaymentTypeID = value; }
    }
    private string _Date;
    public string Date
    {
        get { return _Date; }
        set { _Date = value; }
    }
    private string _Time;
    public string Time
    {
        get { return _Time; }
        set { _Time = value; }
    }
    private Nullable<int> _RecordeCreatedBy;
    public Nullable<int> RecordeCreatedBy
    {
        get { return _RecordeCreatedBy; }
        set { _RecordeCreatedBy = value; }
    }
    private string _RecordeCreatedDate;
    public string RecordeCreatedDate
    {
        get { return _RecordeCreatedDate; }
        set { _RecordeCreatedDate = value; }
    }
    private Nullable<int> _RecordeModifiedBy;
    public Nullable<int> RecordeModifiedBy
    {
        get { return _RecordeModifiedBy; }
        set { _RecordeModifiedBy = value; }
    }
    private string _RecordeModifiedDate;
    public string RecordeModifiedDate
    {
        get { return _RecordeModifiedDate; }
        set { _RecordeModifiedDate = value; }
    }
    public OPDPayTable()
    { }
    public OPDPayTable(int PKID, string RegistrationID, Nullable<decimal> Amount, Nullable<int> PaymentTypeID, string Date, string Time, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
    {
        this.PKID = PKID;
        this.RegistrationID = RegistrationID;
        this.Amount = Amount;
        this.PaymentTypeID = PaymentTypeID;
        this.Date = Date;
        this.Time = Time;
        this.RecordeCreatedBy = RecordeCreatedBy;
        this.RecordeCreatedDate = RecordeCreatedDate;
        this.RecordeModifiedBy = RecordeModifiedBy;
        this.RecordeModifiedDate = RecordeModifiedDate;
    }
    public override string ToString()
    {
        return "PKID = " + PKID.ToString() + "RegistrationID = " + RegistrationID + "Amount = " + Amount.ToString() + "PaymentTypeID = " + PaymentTypeID.ToString() + "Date = " + Date + "Time = " + Time + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
    }
}
}
