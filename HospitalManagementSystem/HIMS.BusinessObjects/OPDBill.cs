using System;
using System.Text;

namespace HIMS.BusinessObjects
{
	[Serializable()]
	public class OPDBill
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
    private Nullable<decimal> _AdmissionFee;
    public Nullable<decimal> AdmissionFee
    {
        get { return _AdmissionFee; }
        set { _AdmissionFee = value; }
    }
    private Nullable<decimal> _MedicineBill;
    public Nullable<decimal> MedicineBill
    {
        get { return _MedicineBill; }
        set { _MedicineBill = value; }
    }
    private Nullable<decimal> _HospitalService;
    public Nullable<decimal> HospitalService
    {
        get { return _HospitalService; }
        set { _HospitalService = value; }
    }
    private Nullable<decimal> _NetAmount;
    public Nullable<decimal> NetAmount
    {
        get { return _NetAmount; }
        set { _NetAmount = value; }
    }
    private Nullable<decimal> _Vat;
    public Nullable<decimal> Vat
    {
        get { return _Vat; }
        set { _Vat = value; }
    }
    private Nullable<decimal> _NetPayble;
    public Nullable<decimal> NetPayble
    {
        get { return _NetPayble; }
        set { _NetPayble = value; }
    }
    private Nullable<decimal> _Gtotal;
    public Nullable<decimal> Gtotal
    {
        get { return _Gtotal; }
        set { _Gtotal = value; }
    }
    private Nullable<decimal> _Due;
    public Nullable<decimal> Due
    {
        get { return _Due; }
        set { _Due = value; }
    }
    private Nullable<decimal> _Discount;
    public Nullable<decimal> Discount
    {
        get { return _Discount; }
        set { _Discount = value; }
    }
    private Nullable<decimal> _Pay;
    public Nullable<decimal> Pay
    {
        get { return _Pay; }
        set { _Pay = value; }
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
    public OPDBill()
    { }
    public OPDBill(int PKID, string RegistrationID, Nullable<decimal> AdmissionFee, Nullable<decimal> MedicineBill, Nullable<decimal> HospitalService, Nullable<decimal> NetAmount, Nullable<decimal> Vat, Nullable<decimal> NetPayble, Nullable<decimal> Gtotal, Nullable<decimal> Due, Nullable<decimal> Discount, Nullable<decimal> Pay, Nullable<int> RecordeCreatedBy, string RecordeCreatedDate, Nullable<int> RecordeModifiedBy, string RecordeModifiedDate)
    {
        this.PKID = PKID;
        this.RegistrationID = RegistrationID;
        this.AdmissionFee = AdmissionFee;
        this.MedicineBill = MedicineBill;
        this.HospitalService = HospitalService;
        this.NetAmount = NetAmount;
        this.Vat = Vat;
        this.NetPayble = NetPayble;
        this.Gtotal = Gtotal;
        this.Due = Due;
        this.Discount = Discount;
        this.Pay = Pay;
        this.RecordeCreatedBy = RecordeCreatedBy;
        this.RecordeCreatedDate = RecordeCreatedDate;
        this.RecordeModifiedBy = RecordeModifiedBy;
        this.RecordeModifiedDate = RecordeModifiedDate;
    }
    public override string ToString()
    {
        return "PKID = " + PKID.ToString() + "RegistrationID = " + RegistrationID + "AdmissionFee = " + AdmissionFee.ToString() + "MedicineBill = " + MedicineBill.ToString() + "HospitalService = " + HospitalService.ToString() + "NetAmount = " + NetAmount.ToString() + "Vat = " + Vat.ToString() + "NetPayble = " + NetPayble.ToString() + "Gtotal = " + Gtotal.ToString() + "Due = " + Due.ToString() + "Discount = " + Discount.ToString() + "Pay = " + Pay.ToString() + "RecordeCreatedBy = " + RecordeCreatedBy.ToString() + "RecordeCreatedDate = " + RecordeCreatedDate + "RecordeModifiedBy = " + RecordeModifiedBy.ToString() + "RecordeModifiedDate = " + RecordeModifiedDate;
    }
}
}
