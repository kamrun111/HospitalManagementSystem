using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using HIMS.BusinessObjects;

namespace HIMS.BLL
{
	public class BLLManager
	{
		private VisitMedicineBLL _visit_medicineBLL;

		public VisitMedicineBLL visit_medicineBLL
		{
			get { return _visit_medicineBLL; }
			set { _visit_medicineBLL = value; }
		}

		private OutdoorPatientInvestigationBLL _outdoor_patient_investigationBLL;

		public OutdoorPatientInvestigationBLL outdoor_patient_investigationBLL
		{
			get { return _outdoor_patient_investigationBLL; }
			set { _outdoor_patient_investigationBLL = value; }
		}

		private UnitBLL _unitBLL;

		public UnitBLL unitBLL
		{
			get { return _unitBLL; }
			set { _unitBLL = value; }
		}

		private OutdoorPatientMedicationBLL _outdoor_patient_medicationBLL;

		public OutdoorPatientMedicationBLL outdoor_patient_medicationBLL
		{
			get { return _outdoor_patient_medicationBLL; }
			set { _outdoor_patient_medicationBLL = value; }
		}

		private GuardianRelationBLL _guardian_relationBLL;

		public GuardianRelationBLL guardian_relationBLL
		{
			get { return _guardian_relationBLL; }
			set { _guardian_relationBLL = value; }
		}

		private GenderBLL _genderBLL;

		public GenderBLL genderBLL
		{
			get { return _genderBLL; }
			set { _genderBLL = value; }
		}

		private DepartmentBLL _departmentBLL;

		public DepartmentBLL departmentBLL
		{
			get { return _departmentBLL; }
			set { _departmentBLL = value; }
		}

		private IndentBLL _indentBLL;

		public IndentBLL indentBLL
		{
			get { return _indentBLL; }
			set { _indentBLL = value; }
		}

		private OtherItemBLL _other_itemBLL;

		public OtherItemBLL other_itemBLL
		{
			get { return _other_itemBLL; }
			set { _other_itemBLL = value; }
		}

		private PurchaseBLL _purchaseBLL;

		public PurchaseBLL purchaseBLL
		{
			get { return _purchaseBLL; }
			set { _purchaseBLL = value; }
		}

		private OutdoorPatientAdviceBLL _outdoor_patient_adviceBLL;

		public OutdoorPatientAdviceBLL outdoor_patient_adviceBLL
		{
			get { return _outdoor_patient_adviceBLL; }
			set { _outdoor_patient_adviceBLL = value; }
		}

		private CityBLL _cityBLL;

		public CityBLL cityBLL
		{
			get { return _cityBLL; }
			set { _cityBLL = value; }
		}

		private NationalityBLL _nationalityBLL;

		public NationalityBLL nationalityBLL
		{
			get { return _nationalityBLL; }
			set { _nationalityBLL = value; }
		}

		private PatientStatusBLL _patient_statusBLL;

		public PatientStatusBLL patient_statusBLL
		{
			get { return _patient_statusBLL; }
			set { _patient_statusBLL = value; }
		}

		private OutdoorPatientVisitBLL _outdoor_patient_visitBLL;

		public OutdoorPatientVisitBLL outdoor_patient_visitBLL
		{
			get { return _outdoor_patient_visitBLL; }
			set { _outdoor_patient_visitBLL = value; }
		}

		private ReligionBLL _religionBLL;

		public ReligionBLL religionBLL
		{
			get { return _religionBLL; }
			set { _religionBLL = value; }
		}

		private PatientOtherItemBLL _patient_other_itemBLL;

		public PatientOtherItemBLL patient_other_itemBLL
		{
			get { return _patient_other_itemBLL; }
			set { _patient_other_itemBLL = value; }
		}

		private PurchaseProductBLL _purchase_productBLL;

		public PurchaseProductBLL purchase_productBLL
		{
			get { return _purchase_productBLL; }
			set { _purchase_productBLL = value; }
		}

		private InvestigationBLL _investigationBLL;

		public InvestigationBLL investigationBLL
		{
			get { return _investigationBLL; }
			set { _investigationBLL = value; }
		}

		private OccupationBLL _occupationBLL;

		public OccupationBLL occupationBLL
		{
			get { return _occupationBLL; }
			set { _occupationBLL = value; }
		}

		private HistoryTextValueBLL _history_text_valueBLL;

		public HistoryTextValueBLL history_text_valueBLL
		{
			get { return _history_text_valueBLL; }
			set { _history_text_valueBLL = value; }
		}

		private AnaesthesiaBLL _anaesthesiaBLL;

		public AnaesthesiaBLL anaesthesiaBLL
		{
			get { return _anaesthesiaBLL; }
			set { _anaesthesiaBLL = value; }
		}

		private PatientBLL _patientBLL;

		public PatientBLL patientBLL
		{
			get { return _patientBLL; }
			set { _patientBLL = value; }
		}

		private PatientHistoryBLL _patient_historyBLL;

		public PatientHistoryBLL patient_historyBLL
		{
			get { return _patient_historyBLL; }
			set { _patient_historyBLL = value; }
		}

		private TestDepartmentBLL _test_departmentBLL;

		public TestDepartmentBLL test_departmentBLL
		{
			get { return _test_departmentBLL; }
			set { _test_departmentBLL = value; }
		}

		private ReceiveBLL _receiveBLL;

		public ReceiveBLL receiveBLL
		{
			get { return _receiveBLL; }
			set { _receiveBLL = value; }
		}

		private MedicineBLL _medicineBLL;

		public MedicineBLL medicineBLL
		{
			get { return _medicineBLL; }
			set { _medicineBLL = value; }
		}

		private TestGroupBLL _test_groupBLL;

		public TestGroupBLL test_groupBLL
		{
			get { return _test_groupBLL; }
			set { _test_groupBLL = value; }
		}

		private DosePreQuantityBLL _dose_p_quantityBLL;

		public DosePreQuantityBLL dose_p_quantityBLL
		{
			get { return _dose_p_quantityBLL; }
			set { _dose_p_quantityBLL = value; }
		}

		private PatientConditionBLL _patient_conditionBLL;

		public PatientConditionBLL patient_conditionBLL
		{
			get { return _patient_conditionBLL; }
			set { _patient_conditionBLL = value; }
		}

		private SupplierBLL _supplierBLL;

		public SupplierBLL supplierBLL
		{
			get { return _supplierBLL; }
			set { _supplierBLL = value; }
		}

		private IntakeSysBLL _intake_sysBLL;

		public IntakeSysBLL intake_sysBLL
		{
			get { return _intake_sysBLL; }
			set { _intake_sysBLL = value; }
		}

		private PaymentTypeBLL _payment_typeBLL;

		public PaymentTypeBLL payment_typeBLL
		{
			get { return _payment_typeBLL; }
			set { _payment_typeBLL = value; }
		}

		private InvestigationItemUsageBLL _investigation_item_usageBLL;

		public InvestigationItemUsageBLL investigation_item_usageBLL
		{
			get { return _investigation_item_usageBLL; }
			set { _investigation_item_usageBLL = value; }
		}

		private IntakeOuttakeBLL _intake_outtakeBLL;

		public IntakeOuttakeBLL intake_outtakeBLL
		{
			get { return _intake_outtakeBLL; }
			set { _intake_outtakeBLL = value; }
		}

		private SalesBLL _salesBLL;

		public SalesBLL salesBLL
		{
			get { return _salesBLL; }
			set { _salesBLL = value; }
		}

		private ProductCategoryBLL _product_categoryBLL;

		public ProductCategoryBLL product_categoryBLL
		{
			get { return _product_categoryBLL; }
			set { _product_categoryBLL = value; }
		}

		private PatientCCBLL _patient_ccBLL;

		public PatientCCBLL patient_ccBLL
		{
			get { return _patient_ccBLL; }
			set { _patient_ccBLL = value; }
		}

		private RequisitionBLL _requisitionBLL;

		public RequisitionBLL requisitionBLL
		{
			get { return _requisitionBLL; }
			set { _requisitionBLL = value; }
		}

		private ProductTypeBLL _product_typeBLL;

		public ProductTypeBLL product_typeBLL
		{
			get { return _product_typeBLL; }
			set { _product_typeBLL = value; }
		}

		private InvestigationItemIndentBLL _investigation_item_indentBLL;

		public InvestigationItemIndentBLL investigation_item_indentBLL
		{
			get { return _investigation_item_indentBLL; }
			set { _investigation_item_indentBLL = value; }
		}

		private CabinStatusBLL _cabin_statusBLL;

		public CabinStatusBLL cabin_statusBLL
		{
			get { return _cabin_statusBLL; }
			set { _cabin_statusBLL = value; }
		}

		private CabinTypeBLL _cabin_typeBLL;

		public CabinTypeBLL cabin_typeBLL
		{
			get { return _cabin_typeBLL; }
			set { _cabin_typeBLL = value; }
		}

		private RequisitionProductBLL _requisition_productBLL;

		public RequisitionProductBLL requisition_productBLL
		{
			get { return _requisition_productBLL; }
			set { _requisition_productBLL = value; }
		}

		private InvestigationItemBLL _investigation_itemBLL;

		public InvestigationItemBLL investigation_itemBLL
		{
			get { return _investigation_itemBLL; }
			set { _investigation_itemBLL = value; }
		}

		private SalesProductBLL _sales_productBLL;

		public SalesProductBLL sales_productBLL
		{
			get { return _sales_productBLL; }
			set { _sales_productBLL = value; }
		}

		private AdviceBLL _adviceBLL;

		public AdviceBLL adviceBLL
		{
			get { return _adviceBLL; }
			set { _adviceBLL = value; }
		}

		private ProductBLL _productBLL;

		public ProductBLL productBLL
		{
			get { return _productBLL; }
			set { _productBLL = value; }
		}

		private TreatementBLL _treatementBLL;

		public TreatementBLL treatementBLL
		{
			get { return _treatementBLL; }
			set { _treatementBLL = value; }
		}

		private CabinTranferBLL _cabin_tranferBLL;

		public CabinTranferBLL cabin_tranferBLL
		{
			get { return _cabin_tranferBLL; }
			set { _cabin_tranferBLL = value; }
		}

		private HistoryTextBLL _history_textBLL;

		public HistoryTextBLL history_textBLL
		{
			get { return _history_textBLL; }
			set { _history_textBLL = value; }
		}

		private DoctorLevelBLL _doctor_levelBLL;

		public DoctorLevelBLL doctor_levelBLL
		{
			get { return _doctor_levelBLL; }
			set { _doctor_levelBLL = value; }
		}

		private CabinBLL _cabinBLL;

		public CabinBLL cabinBLL
		{
			get { return _cabinBLL; }
			set { _cabinBLL = value; }
		}

		private HistoryTextGroupBLL _history_text_groupBLL;

		public HistoryTextGroupBLL history_text_groupBLL
		{
			get { return _history_text_groupBLL; }
			set { _history_text_groupBLL = value; }
		}

		private SpecialistInBLL _specialist_inBLL;

		public SpecialistInBLL specialist_inBLL
		{
			get { return _specialist_inBLL; }
			set { _specialist_inBLL = value; }
		}

		private InventoryBLL _inventoryBLL;

		public InventoryBLL inventoryBLL
		{
			get { return _inventoryBLL; }
			set { _inventoryBLL = value; }
		}

		private DesignationBLL _designationBLL;

		public DesignationBLL designationBLL
		{
			get { return _designationBLL; }
			set { _designationBLL = value; }
		}

		private InvestigationTestBLL _investigation_testBLL;

		public InvestigationTestBLL investigation_testBLL
		{
			get { return _investigation_testBLL; }
			set { _investigation_testBLL = value; }
		}

		private ReceiveProductBLL _receive_productBLL;

		public ReceiveProductBLL receive_productBLL
		{
			get { return _receive_productBLL; }
			set { _receive_productBLL = value; }
		}

		private RegularCheckupBLL _regular_checkupBLL;

		public RegularCheckupBLL regular_checkupBLL
		{
			get { return _regular_checkupBLL; }
			set { _regular_checkupBLL = value; }
		}

		private Outdoor_bookingBLL _outdoor_bookingBLL;

		public Outdoor_bookingBLL outdoor_bookingBLL
		{
			get { return _outdoor_bookingBLL; }
			set { _outdoor_bookingBLL = value; }
		}

		private TestItemBLL _test_itemBLL;

		public TestItemBLL test_itemBLL
		{
			get { return _test_itemBLL; }
			set { _test_itemBLL = value; }
		}

		private RefundFaultyBLL _refund_faultyBLL;

		public RefundFaultyBLL refund_faultyBLL
		{
			get { return _refund_faultyBLL; }
			set { _refund_faultyBLL = value; }
		}

		private Baby_noteBLL _baby_noteBLL;

		public Baby_noteBLL baby_noteBLL
		{
			get { return _baby_noteBLL; }
			set { _baby_noteBLL = value; }
		}

		private FloorBLL _floorBLL;

		public FloorBLL floorBLL
		{
			get { return _floorBLL; }
			set { _floorBLL = value; }
		}

		private VisitInvestigationBLL _visit_investigationBLL;

		public VisitInvestigationBLL visit_investigationBLL
		{
			get { return _visit_investigationBLL; }
			set { _visit_investigationBLL = value; }
		}

		private OperationBLL _operationBLL;

		public OperationBLL operationBLL
		{
			get { return _operationBLL; }
			set { _operationBLL = value; }
		}

		private OperationNoteBLL _operation_noteBLL;

		public OperationNoteBLL operation_noteBLL
		{
			get { return _operation_noteBLL; }
			set { _operation_noteBLL = value; }
		}

		private MedicineTimingBLL _medicine_timingBLL;

		public MedicineTimingBLL medicine_timingBLL
		{
			get { return _medicine_timingBLL; }
			set { _medicine_timingBLL = value; }
		}

		private VisitTreatementBLL _visit_treatementBLL;

		public VisitTreatementBLL visit_treatementBLL
		{
			get { return _visit_treatementBLL; }
			set { _visit_treatementBLL = value; }
		}

		private RefferedDoctorsBLL _reffered_doctorsBLL;

		public RefferedDoctorsBLL reffered_doctorsBLL
		{
			get { return _reffered_doctorsBLL; }
			set { _reffered_doctorsBLL = value; }
		}

		private PatientMedicineBLL _patient_medicineBLL;

		public PatientMedicineBLL patient_medicineBLL
		{
			get { return _patient_medicineBLL; }
			set { _patient_medicineBLL = value; }
		}

		private PatientMedicineIndentBLL _patient_medicine_indentBLL;

		public PatientMedicineIndentBLL patient_medicine_indentBLL
		{
			get { return _patient_medicine_indentBLL; }
			set { _patient_medicine_indentBLL = value; }
		}

		private ImplicationWayBLL _implication_wayBLL;

		public ImplicationWayBLL implication_wayBLL
		{
			get { return _implication_wayBLL; }
			set { _implication_wayBLL = value; }
		}

		private PatientRefferedDoctorsBLL _patient_reffered_doctorsBLL;

		public PatientRefferedDoctorsBLL patient_reffered_doctorsBLL
		{
			get { return _patient_reffered_doctorsBLL; }
			set { _patient_reffered_doctorsBLL = value; }
		}

		private PatientTreatementBLL _patient_treatementBLL;

		public PatientTreatementBLL patient_treatementBLL
		{
			get { return _patient_treatementBLL; }
			set { _patient_treatementBLL = value; }
		}

		private VisitAdviceBLL _visit_adviceBLL;

		public VisitAdviceBLL visit_adviceBLL
		{
			get { return _visit_adviceBLL; }
			set { _visit_adviceBLL = value; }
		}

		private AdmissionBLL _admissionBLL;

		public AdmissionBLL admissionBLL
		{
			get { return _admissionBLL; }
			set { _admissionBLL = value; }
		}

		private PrescriptionBLL _prescriptionBLL;

		public PrescriptionBLL prescriptionBLL
		{
			get { return _prescriptionBLL; }
			set { _prescriptionBLL = value; }
		}

		public BLLManager()
		{
			visit_medicineBLL = new VisitMedicineBLL();
			outdoor_patient_investigationBLL = new OutdoorPatientInvestigationBLL();
			unitBLL = new UnitBLL();
			outdoor_patient_medicationBLL = new OutdoorPatientMedicationBLL();
			guardian_relationBLL = new GuardianRelationBLL();
			genderBLL = new GenderBLL();
			departmentBLL = new DepartmentBLL();
			indentBLL = new IndentBLL();
			other_itemBLL = new OtherItemBLL();
			purchaseBLL = new PurchaseBLL();
			outdoor_patient_adviceBLL = new OutdoorPatientAdviceBLL();
			cityBLL = new CityBLL();
			nationalityBLL = new NationalityBLL();
			patient_statusBLL = new PatientStatusBLL();
			outdoor_patient_visitBLL = new OutdoorPatientVisitBLL();
			religionBLL = new ReligionBLL();
			patient_other_itemBLL = new PatientOtherItemBLL();
			purchase_productBLL = new PurchaseProductBLL();
			investigationBLL = new InvestigationBLL();
			occupationBLL = new OccupationBLL();
			history_text_valueBLL = new HistoryTextValueBLL();
			anaesthesiaBLL = new AnaesthesiaBLL();
			patientBLL = new PatientBLL();
			patient_historyBLL = new PatientHistoryBLL();
			test_departmentBLL = new TestDepartmentBLL();
			receiveBLL = new ReceiveBLL();
			medicineBLL = new MedicineBLL();
			test_groupBLL = new TestGroupBLL();
			dose_p_quantityBLL = new DosePreQuantityBLL();
			patient_conditionBLL = new PatientConditionBLL();
			supplierBLL = new SupplierBLL();
			intake_sysBLL = new IntakeSysBLL();
			payment_typeBLL = new PaymentTypeBLL();
			investigation_item_usageBLL = new InvestigationItemUsageBLL();
			intake_outtakeBLL = new IntakeOuttakeBLL();
			salesBLL = new SalesBLL();
			product_categoryBLL = new ProductCategoryBLL();
			patient_ccBLL = new PatientCCBLL();
			requisitionBLL = new RequisitionBLL();
			product_typeBLL = new ProductTypeBLL();
			investigation_item_indentBLL = new InvestigationItemIndentBLL();
			cabin_statusBLL = new CabinStatusBLL();
			cabin_typeBLL = new CabinTypeBLL();
			requisition_productBLL = new RequisitionProductBLL();
			investigation_itemBLL = new InvestigationItemBLL();
			sales_productBLL = new SalesProductBLL();
			adviceBLL = new AdviceBLL();
			productBLL = new ProductBLL();
			treatementBLL = new TreatementBLL();
			cabin_tranferBLL = new CabinTranferBLL();
			history_textBLL = new HistoryTextBLL();
			doctor_levelBLL = new DoctorLevelBLL();
			cabinBLL = new CabinBLL();
			history_text_groupBLL = new HistoryTextGroupBLL();
			specialist_inBLL = new SpecialistInBLL();
			inventoryBLL = new InventoryBLL();
			designationBLL = new DesignationBLL();
			investigation_testBLL = new InvestigationTestBLL();
			receive_productBLL = new ReceiveProductBLL();
			regular_checkupBLL = new RegularCheckupBLL();
			outdoor_bookingBLL = new Outdoor_bookingBLL();
			test_itemBLL = new TestItemBLL();
			refund_faultyBLL = new RefundFaultyBLL();
			baby_noteBLL = new Baby_noteBLL();
			floorBLL = new FloorBLL();
			visit_investigationBLL = new VisitInvestigationBLL();
			operationBLL = new OperationBLL();
			operation_noteBLL = new OperationNoteBLL();
			medicine_timingBLL = new MedicineTimingBLL();
			visit_treatementBLL = new VisitTreatementBLL();
			reffered_doctorsBLL = new RefferedDoctorsBLL();
			patient_medicineBLL = new PatientMedicineBLL();
			patient_medicine_indentBLL = new PatientMedicineIndentBLL();
			implication_wayBLL = new ImplicationWayBLL();
			patient_reffered_doctorsBLL = new PatientRefferedDoctorsBLL();
			patient_treatementBLL = new PatientTreatementBLL();
			visit_adviceBLL = new VisitAdviceBLL();
			admissionBLL = new AdmissionBLL();
			prescriptionBLL = new PrescriptionBLL();
		}
	}
}
