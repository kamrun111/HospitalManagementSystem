using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using HIMS.BLL;
using HIMS.BusinessObjects;
using HIMS.DAL;
using Microsoft.VisualBasic;


namespace NewHIMS.Forms.Configuration
{
    public partial class FrmConfiguration : BaseForm.FrmBase
    {
        public FrmConfiguration()
        {
            InitializeComponent();
        }
        


        //####################################### METHOD FOR GENERAL LISTVIEW FILLUP #####################################       

        private void FillUpListview(ListView lvw, DataSet ds)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[0].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < lvw.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }

        //#################################################################################################################  




  //***************************************** B E G I N   C I T Y   M O D U L E **************************************

        private void btnCitySave_Click(object sender, EventArgs e)
        {
            City city = new City();
            CityBLL cityBLL = new CityBLL();

            try
            {

                city.city = txtCity.Text.ToString();
             
                if (btnCitySave.Text == "Save")
                {
                    cityBLL.Addcity(city);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");
                    
                }
                else      // FOR UPDATE
                {
                    city.city_id = Convert.ToInt32(lvwCity.FocusedItem.Text);

                    cityBLL.Updatecity(city);
                    
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnCitySave.Text = "Save";

                }
                RefreshCity();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                city = null;
                cityBLL = null;
            }
       }



       
        void RefreshCity()
        {
            DataSet ds = new DataSet();
            CityBLL citybll = new CityBLL();
            ds = citybll.Getcitys();
            lvwCity.Items.Clear();
            FillUpListview(lvwCity,ds);

            citybll = null;
            ds = null;
            
        }

        private void btnDeleteCity_Click(object sender, EventArgs e)
        {
            CityBLL citybll = new CityBLL();
            int Remcity = Convert.ToInt32(lvwCity.FocusedItem.Text);
            citybll.Removecity(Remcity);
            MessageBox.Show(" data delete successfully", "NewHIMS");
            RefreshCity();
        }

        private void btnRefreshCity_Click(object sender, EventArgs e)
        {
            txtCity.Text = "";
            RefreshCity();

        }
        


        private void lvwCity_Click(object sender, EventArgs e)
        {

            if (lvwCity.FocusedItem.Text != "")
            {
                City city = new City();
                CityBLL citybll = new CityBLL();
                int cityid = Convert.ToInt32(lvwCity.FocusedItem.Text);
                city = citybll.Getcity(cityid);
                txtCity.Text = city.city.ToString();
                btnCitySave.Text = "Update";
                btnDeleteCity.Enabled = true;
            }
        }

        private void btnCloseCity_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void tabPageCity_Enter(object sender, EventArgs e)
        {
            RefreshCity();
        }

        //***************************************** E N D   C I T Y   M O D U L E **************************************




 //********************************Supplier Start********************************************


        private void btnSupplierSave_Click_1(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();
            SupplierBLL supplierBLL = new SupplierBLL();

            try
            {

                supplier.supplier_name = txtSupplierName.Text.ToString();
                supplier.contact_person = txtSupplierContactPerson.Text.ToString();
                supplier.contact_no = txtSupplierContactNo.Text.ToString();
                supplier.fax_no = txtSupplierFax.Text.ToString();
                supplier.address = txtSupplierAdrress.Text.ToString();
                DataSet ds = null;
                if (btnSupplierSave.Text == "Save")
                {
                    ds = supplierBLL.AddSupplierAndGetAll(supplier);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");
                    RefreshSupplier();

                }
                else      // FOR UPDATE
                {
                    supplier.supplier_id = Convert.ToInt32(lvwSupplier.FocusedItem.Text);

                    ds = supplierBLL.UpdateSupplier(supplier);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    RefreshSupplier();
                    btnSupplierSave.Text = "Save";

                }
                FillUpListview(this.lvwSupplier, ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                supplier = null;
                supplierBLL = null;
            }
        }

        private void btnSupplierRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshSupplier();
        }
       
        
        void RefreshSupplier()
        {
            txtSupplierName.Text = "";
            txtSupplierContactPerson.Text = "";
            txtSupplierContactNo.Text = "";
            txtSupplierFax.Text = "";
            txtSupplierAdrress.Text = "";
            btnSupplierSave.Text = "Save";
            btnSupplierDelete.Enabled = false;
            lvwSupplier.Items.Clear();
            SupplierBLL supplierBLL=new SupplierBLL();
            DataSet ds = supplierBLL.Getsuppliers();
            FillUpListview(lvwSupplier,ds);
            lblTotalSupplier2.Text = lvwSupplier.Items.Count.ToString();
            supplierBLL = null;
            ds = null;
        }

        private void btnSupplierDelete_Click(object sender, EventArgs e)
        {
            if (lvwSupplier.FocusedItem.Text != "")
            {
                SupplierBLL supplierBLL = new SupplierBLL();
                int supplierID = Convert.ToInt32(lvwSupplier.FocusedItem.Text);
                supplierBLL.Removesupplier(supplierID);
                btnSupplierDelete.Enabled = false;
                RefreshSupplier();
            }
        }




        private void lvwSupplier_Click(object sender, EventArgs e)
        {
            SupplierBLL supplierBLL = new SupplierBLL();
            Supplier supplier = new Supplier();

            int supplierID = Convert.ToInt32(lvwSupplier.FocusedItem.Text);

            supplier = supplierBLL.Getsupplier(supplierID);

            if (supplier.supplier_name != null)
                txtSupplierName.Text = supplier.supplier_name.ToString();
            else
                txtSupplierName.Text = "";

            if (supplier.contact_person == null)
                txtSupplierName.Text = "";
            else
                txtSupplierContactPerson.Text = supplier.contact_person.ToString();

            if (supplier.contact_no == null)
                txtSupplierContactNo.Text = "";
            else
                txtSupplierContactNo.Text = supplier.contact_no.ToString();

            if (supplier.fax_no == null)
                txtSupplierFax.Text = "";
            else
                txtSupplierFax.Text = supplier.fax_no.ToString();

            if (supplier.address == null)
                txtSupplierAdrress.Text = "";
            else
                txtSupplierAdrress.Text = supplier.address.ToString();

            btnSupplierDelete.Enabled = true;
            btnSupplierSave.Text = "Update";
        }



        private void tabPageSupplier_Enter(object sender, EventArgs e)
        {
            RefreshSupplier();
        }



        //********************************* E N D   S U P P L I E R   M O D U L E ****************************************






        //********************************* S T A R T   O C C U P A T I ON     M O D U L E ****************************************

        private void btnOccupationSave_Click(object sender, EventArgs e)
        {
            Occupation occupation = new Occupation();
            OccupationBLL occupationBLL = new OccupationBLL();

            try
            {
                occupation.occupation = txtOccupation.Text.ToString();

                if (btnOccupationSave.Text == "Save")
                {
                    occupationBLL.Addoccupation(occupation);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    occupation.occupation_id = Convert.ToInt32(lvwOccupation.FocusedItem.Text);

                    occupationBLL.Updateoccupation(occupation);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnOccupationSave.Text = "Save";

                }
                RefreshOccupation();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                occupation = null;
                occupationBLL = null;
            }
        }

        private void btnOccupationDelete_Click(object sender, EventArgs e)
        {
            OccupationBLL occupationBLL = new OccupationBLL();
            int RemoccupatonID= Convert.ToInt32(lvwOccupation.FocusedItem.Text);
            occupationBLL.Removeoccupation(RemoccupatonID);
            MessageBox.Show(" data delete successfully", "NewHIMS");
            //Refreshcity();
            RefreshOccupation();
        }

        void RefreshOccupation()
        {
            DataSet ds = new DataSet();
            OccupationBLL occupationBLL = new OccupationBLL();
            ds = occupationBLL.Getoccupations();

            btnOccupationDelete.Enabled = false;
            btnOccupationSave.Text = "Save";
            txtOccupation.Text = "";
            lvwOccupation.Items.Clear();
            FillUpListview(lvwOccupation,ds);

            occupationBLL = null;
            ds = null;
       }

        private void btnOccupationRefresh_Click(object sender, EventArgs e)
        {
            RefreshOccupation();

        }


        private void lvwOccupation_Click(object sender, EventArgs e)
        {
            if (lvwOccupation.FocusedItem.Text != "")
            {
                Occupation occupation = new Occupation();
                OccupationBLL occupationBLL = new OccupationBLL();
                int occupationid = Convert.ToInt32(lvwOccupation.FocusedItem.Text);
                occupation = occupationBLL.Getoccupation(occupationid);
                txtOccupation.Text = occupation.occupation.ToString();

                btnOccupationSave.Text = "Update";
                btnOccupationDelete.Enabled = true;
            }
        }

       
        
        private void btnOccupationClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tabPageOccupation_Enter(object sender, EventArgs e)
        {
            RefreshOccupation();
        }

       

       

  //*********************************   E N D  O F  O C C U P A T I O N  M O U U L E   ****************************************





  //********************************* S T A R T   D E S I G N A T I O N     M O D U L E ****************************************


        private void btnDesignationSave_Click(object sender, EventArgs e)
        {

            Designation designation = new Designation();
            DesignationBLL designationBLL = new DesignationBLL();

            try
            {
                designation.designation = txtDesignation.Text.ToString();

                if (btnDesignationSave.Text == "Save")
                {
                    designationBLL.Adddesignation(designation);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    designation.designation_id = Convert.ToInt32(lvwDesignation.FocusedItem.Text);

                    designationBLL.Updatedesignation(designation);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnDesignationSave.Text = "Save";

                }
                RefreshDesignation();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                designation = null;
                designationBLL = null;
            }

        }

        void RefreshDesignation() {

            DataSet ds = new DataSet();
            DesignationBLL designationBLL = new DesignationBLL();
            ds = designationBLL.Getdesignations();
            
            btnDesignationDelete.Enabled = false;
            btnDesignationSave.Text = "Save";
            txtDesignation.Text = "";
            lvwDesignation.Items.Clear();
            FillUpListview(lvwDesignation, ds);

            designationBLL = null;
            ds = null;
        }
        
        
        private void btnDesignationRefresh_Click(object sender, EventArgs e)
        {

            RefreshDesignation();
        }

        private void tabPageDesignation_Enter(object sender, EventArgs e)
        {
            RefreshDesignation();
        }

        private void lvwDesignation_Click(object sender, EventArgs e)
        {

            if (lvwDesignation.FocusedItem.Text != "")
            {
                Designation designation = new Designation();
                DesignationBLL designationBLL = new DesignationBLL();
                int designationid = Convert.ToInt32(lvwDesignation.FocusedItem.Text);
                designation = designationBLL.Getdesignation(designationid);
                if (designation.designation!=null)
                    txtDesignation.Text = designation.designation.ToString();

                btnDesignationSave.Text = "Update";
                btnDesignationDelete.Enabled = true;
            }
        }

        private void btnDesignationClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesignationDelete_Click(object sender, EventArgs e)
        {
            DesignationBLL designationBLL = new DesignationBLL();
            int RemoccupatonID = Convert.ToInt32(lvwDesignation.FocusedItem.Text);
            designationBLL.Removedesignation(RemoccupatonID);
            MessageBox.Show("Data Delete Successfully", "NewHIMS");
            //Refreshcity();
            RefreshDesignation();
        }

        
      






 //********************************* E  N D  D E S I G N A T I O N     M O D U L E ****************************************





       



        //********************************* S T A R T   D E S I G N A T I O N     M O D U L E ****************************************



        private void btnSpecialistInSave_Click(object sender, EventArgs e)
        {
            SpecialistIn specialistIn = new SpecialistIn();
            SpecialistInBLL specialistInBLL = new SpecialistInBLL();

            try
            {

                specialistIn.specialist_in= txtSpecialistIn.Text.ToString();

                if (btnSpecialistInSave.Text == "Save")
                {
                    specialistInBLL.Addspecialist_in(specialistIn);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    specialistIn.specialist_in_id = Convert.ToInt32(lvwSpecialistIn.FocusedItem.Text);

                    specialistInBLL.Updatespecialist_in(specialistIn);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnSpecialistInSave.Text = "Save";

                }
               RefreshSpecialistIn();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                specialistIn = null;
                specialistInBLL = null;
            }
        }

        private void btnSpecialistInRefresh_Click(object sender, EventArgs e)
        {
            RefreshSpecialistIn();
        }
        void RefreshSpecialistIn()
        {
            DataSet ds = new DataSet();
            SpecialistInBLL specialistInBLL = new SpecialistInBLL();
            ds = specialistInBLL.Getspecialist_ins();
            lvwSpecialistIn.Items.Clear();
            FillUpListview(lvwSpecialistIn, ds);
            btnSpecialistInDelete.Enabled = false;
            btnSpecialistInSave.Text = "Save";
            txtSpecialistIn.Text = "";
            specialistInBLL = null;
            ds = null;

        }

        private void tabPageSpecialistIn_Enter(object sender, EventArgs e)
        {
            RefreshSpecialistIn();
        }

        private void lvwSpecialistIn_Click(object sender, EventArgs e)
        {
            if (lvwSpecialistIn.FocusedItem.Text != "")
            {
                SpecialistIn specialistIn = new SpecialistIn();
                SpecialistInBLL specialistInBLL = new SpecialistInBLL();
                int specialistInID = Convert.ToInt32(lvwSpecialistIn.FocusedItem.Text);
                specialistIn = specialistInBLL.Getspecialist_in(specialistInID);
                txtSpecialistIn.Text = specialistIn.specialist_in.ToString();

                btnSpecialistInSave.Text = "Update";
                btnSpecialistInDelete.Enabled = true;
            }
        }

        private void btnSpecialistInDelete_Click(object sender, EventArgs e)
        {
            SpecialistInBLL specialistInBLL = new SpecialistInBLL();
            int specialistInID = Convert.ToInt32(lvwSpecialistIn.FocusedItem.Text);
            specialistInBLL.Removespecialist_in(specialistInID);
            MessageBox.Show("Data Deleted Successfully", "NewHIMS");
            RefreshSpecialistIn();
        }

        private void btnSpecialistInClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       




        //********************************* E  N D  D E S I G N A T I O N     M O D U L E ****************************************








        //********************************* S T A R T   D E P A R T M E N T     M O D U L E ****************************************



        private void btnDepartmentSave_Click(object sender, EventArgs e)
        {

            Department department = new Department();
            DepartmentBLL departmentBLL = new DepartmentBLL();

            try
            {

                department.department = txtDepartmentName.Text.ToString();

                if (btnDepartmentSave.Text == "Save")
                {
                    departmentBLL.Adddepartment(department);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    department.department_id = Convert.ToInt32(lvwDepartment.FocusedItem.Text);

                    departmentBLL.Updatedepartment(department);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnDepartmentSave.Text = "Save";

                }
                RefreshDepartment();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                department = null;
                departmentBLL = null;
            }
        }


        void RefreshDepartment(){
            DataSet ds = new DataSet();
            DepartmentBLL departmentBLL = new DepartmentBLL();
            ds = departmentBLL.Getdepartments();
            lvwDepartment.Items.Clear();
            FillUpListview(lvwDepartment, ds);
            btnDepartmentDelete.Enabled = false;
            btnDepartmentSave.Text = "Save";
            txtDepartmentName.Text = "";
            departmentBLL = null;
            ds = null;
    
    
    }

        private void btnDepartmentRefesh_Click(object sender, EventArgs e)
        {
            RefreshDepartment();

        }

        private void tabPageDepartment_Enter(object sender, EventArgs e)
        {
            RefreshDepartment();

        }

        private void btnDepartmentClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwDepartment_Click(object sender, EventArgs e)
        {
            if (lvwDepartment.FocusedItem.Text != "")
            {
                Department department = new Department();
                DepartmentBLL departmentBLL = new DepartmentBLL();
                int departmentID = Convert.ToInt32(lvwDepartment.FocusedItem.Text);
                department = departmentBLL.Getdepartment(departmentID);
                txtDepartmentName.Text = department.department.ToString();

                btnDepartmentSave.Text = "Update";
                btnDepartmentDelete.Enabled = true;
            }
        }

        private void btnDepartmentDelete_Click(object sender, EventArgs e)
        {
            DepartmentBLL departmentBLL = new DepartmentBLL();
            int departmentID = Convert.ToInt32(lvwDepartment.FocusedItem.Text);
            departmentBLL.Removedepartment(departmentID);
            MessageBox.Show("Data Deleted Successfully", "NewHIMS");
            RefreshDepartment();
        }

       





        //********************************* E  N D  D E P A R T M E N T     M O D U L E ****************************************






        //********************************* S T A R T   H I S T O R Y  T E X T     M O D U L E ****************************************


       








 //********************************* S T A R T   T R E A T E M E N T     M O D U L E ****************************************


        private void NumCheck(KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Input Correctly");
            }
        }
        private void FillUpListview1(ListView lvw, DataSet ds, int tableIndex)
        {
            lvw.Items.Clear();

            for (int i = 0; i < ds.Tables[tableIndex].Rows.Count; i++)
            {
                DataRow dataRow = ds.Tables[tableIndex].Rows[i];

                if (dataRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dataRow[0].ToString());
                    for (int j = 1; j < lvw.Columns.Count; j++)//gdgdg
                    {
                        lvi.SubItems.Add(dataRow[j].ToString());
                    }
                    lvw.Items.Add(lvi);
                }
            }
        }

        private void btnTreatmentSave_Click(object sender, EventArgs e)
        {
            Treatement treatement = new Treatement();
            TreatementBLL treatementBLL = new TreatementBLL();

            try
            {

                treatement.treatement = txtTreatment.Text.ToString();
                if (cmbTreatmentType.SelectedIndex >= 0)
                {
                   
                    treatement.treatment_type = cmbTreatmentType.Text.ToString();
                }
                if(txtTprocedure.Text!="")
                treatement.treatment_procedure = txtTprocedure.Text.ToString();
                if (txtCharge.Text!="")
                treatement.treatment_charge = Convert.ToDecimal(txtCharge.Text);
                if(txtPreProcedure.Text!="")
                    treatement.tretreatment_preprocedure = txtPreProcedure.Text.ToString();

                if (btnTreatmentSave.Text == "Save")
                {
                    treatementBLL.Addtreatement(treatement);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    treatement.treatement_id = Convert.ToInt32(lvwTreatment.FocusedItem.Text);


                    treatementBLL.Updatetreatement(treatement);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnTreatmentSave.Text = "Save";

                }
                RefreshTreatement();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                treatement = null;
                treatementBLL = null;
            }

        }


        void RefreshTreatement() 
        {
            DataSet ds = new DataSet();
            TreatementBLL treatementBLL = new TreatementBLL();
            ds = treatementBLL.Gettreatements();
            FillUpListview1(lvwTreatment, ds,0);
           // PopulateComboBox(cmbTreatmentType, ds, 1, "operation_name", "operation_id");
            cmbTreatmentType.DataSource = ds.Tables[1];
            cmbTreatmentType.DisplayMember = "treatment_type";
            txtCharge.Text = "";
            txtTprocedure.Text = "";
            txtPreProcedure.Text = "";
            
            btnTreatmentDelete.Enabled = false;
            btnTreatmentSave.Text = "Save";
            txtTreatment.Text = "";
            treatementBLL = null;
            ds = null;
        }

        private void btnTreatmentRefresh_Click(object sender, EventArgs e)
        {
            RefreshTreatement();
        }

        private void tabPageTreatement_Enter(object sender, EventArgs e)
        {
            RefreshTreatement();
        }

        private void btnTreatmentDelete_Click(object sender, EventArgs e)
        {
            TreatementBLL treatementBLL = new TreatementBLL();
            int treatementID = Convert.ToInt32(lvwTreatment.FocusedItem.Text);
            treatementBLL.Removetreatement(treatementID);
            MessageBox.Show("Data Deleted Successfully", "NewHIMS");
            RefreshTreatement();
        }

        private void btnTreatmentClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTreatment.FocusedItem.Text != "")
                {
                    Treatement treatement = new Treatement();
                    TreatementBLL treatementBLL = new TreatementBLL();
                    int treatementID = Convert.ToInt32(lvwTreatment.FocusedItem.Text);
                    treatement = treatementBLL.Gettreatement(treatementID);
                    if (treatement.treatement != null)
                        txtTreatment.Text = treatement.treatement.ToString();
                    else
                        txtTreatment.Text = "";


                    if (treatement.treatment_procedure!= null)
                        txtTprocedure.Text = treatement.treatment_procedure.ToString();
                    else
                        txtTprocedure.Text = "";
                    if (treatement.treatment_charge != null)
                        txtCharge.Text = treatement.treatment_charge.ToString();
                    else
                        txtCharge.Text = "";
                    if (treatement.treatment_type != null)
                        cmbTreatmentType.Text = treatement.treatment_type.ToString();
                    else
                        cmbTreatmentType.Text = "Genaral";
                    if (treatement.tretreatment_preprocedure != null)
                        txtPreProcedure.Text = treatement.tretreatment_preprocedure.ToString();
                    else
                        txtPreProcedure.Text = "";

                    btnTreatmentSave.Text = "Update";
                    btnTreatmentDelete.Enabled = true;
                }
            }
            catch
            { }
        }

       
 //********************************* E  N D    T R E A T E M E N T    M O D U L E ****************************************








//********************************* S T A R T   T E S T  D E P A R T M E N T     M O D U L E ****************************************



        private void btnTestDepartmentSave_Click(object sender, EventArgs e)
        {

            TestDepartment testDept = new TestDepartment();
            TestDepartmentBLL testDeptBLL = new TestDepartmentBLL();

            try
            {

                testDept.test_department = txtTestDepartment.Text.ToString();

                if (btnTestDepartmentSave.Text == "Save")
                {
                    testDeptBLL.Addtest_department(testDept);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    testDept.test_department_id = Convert.ToInt32(lvwTestDepartment.FocusedItem.Text);

                    testDeptBLL.Updatetest_department(testDept);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnTestDepartmentSave.Text = "Save";

                }
                RefreshTestDepartment();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                testDept = null;
                testDeptBLL = null;
            }
        }


        void RefreshTestDepartment() {
            DataSet ds = new DataSet();
            TestDepartmentBLL testDeptBLL = new TestDepartmentBLL();
            ds = testDeptBLL.Gettest_departments();
            FillUpListview(lvwTestDepartment, ds);
            btnTestDepartmentDelete.Enabled = false;
            btnTestDepartmentSave.Text = "Save";
            txtTestDepartment.Text = "";
            testDeptBLL = null;
            ds = null;
        }

        private void btnTestDepartmentRefresh_Click(object sender, EventArgs e)
        {
            RefreshTestDepartment();
        }

        private void tabPageTestDept_Enter(object sender, EventArgs e)
        {
            RefreshTestDepartment();
        }

        private void btnTestDepartmentDelete_Click(object sender, EventArgs e)
        {
            TestDepartmentBLL testDeptBLL = new TestDepartmentBLL();
            int testDeptID = Convert.ToInt32(lvwTestDepartment.FocusedItem.Text);
            testDeptBLL.Removetest_department(testDeptID);
            MessageBox.Show("Data Deleted Successfully", "NewHIMS");
            RefreshTestDepartment();
        }

        private void lvwTestDepartment_Click(object sender, EventArgs e)
        {
            if (lvwTestDepartment.FocusedItem.Text != "")
            {
                TestDepartment testDept = new TestDepartment();
                TestDepartmentBLL testDeptBLL = new TestDepartmentBLL();
                int testDeptID = Convert.ToInt32(lvwTestDepartment.FocusedItem.Text);
                testDept = testDeptBLL.Gettest_department(testDeptID);
                txtTestDepartment.Text = testDept.test_department.ToString();

                btnTestDepartmentSave.Text = "Update";
                btnTestDepartmentDelete.Enabled = true;
            }
        }

        private void btnTestDepartmentClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
  //********************************* E  N D   T E S T   D E P A R T M E N T    M O D U L E ****************************************









 //********************************* S T A R T   T E S T  G R O U P     M O D U L E ****************************************


        private void btnTestGroupSave_Click(object sender, EventArgs e)
        {

            TestGroup testGroup = new TestGroup();
            TestGroupBLL testGroupBLL = new TestGroupBLL();

            try
            {

                testGroup.test_group = txtTestGroup.Text.ToString();

                if (btnTestGroupSave.Text == "Save")
                {
                    testGroupBLL.Addtest_group(testGroup);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    testGroup.test_group_id = Convert.ToInt32(lvwTestGroup.FocusedItem.Text);

                    testGroupBLL.Updatetest_group(testGroup);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnTestGroupSave.Text = "Save";

                }
                RefreshTestGroup();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                testGroup = null;
                testGroupBLL = null;
            }
        }



        void RefreshTestGroup() {
            DataSet ds = new DataSet();
            TestGroupBLL testGroupBLL = new TestGroupBLL();
            ds = testGroupBLL.Gettest_groups();
            FillUpListview(lvwTestGroup, ds);
            btnTestGroupDelete.Enabled = false;
            btnTestGroupSave.Text = "Save";
            txtTestGroup.Text = "";
            testGroupBLL = null;
            ds = null;
        
        }

        private void btnTestGroupRefresh_Click(object sender, EventArgs e)
        {
            RefreshTestGroup();
        }

        private void tabPageTestGroup_Enter(object sender, EventArgs e)
        {
            RefreshTestGroup();
        }

        private void btnTestGroupClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestGroupDelete_Click(object sender, EventArgs e)
        {
            TestGroupBLL testGroupBLL = new TestGroupBLL();
            int testGroupID = Convert.ToInt32(lvwTestGroup.FocusedItem.Text);
            testGroupBLL.Removetest_group(testGroupID);
            MessageBox.Show("Data Deleted Successfully", "NewHIMS");
            RefreshTestGroup();
        }

        private void lvwTestGroup_Click(object sender, EventArgs e)
        {

            if (lvwTestGroup.FocusedItem.Text != "")
            {
                TestGroup testGroup = new TestGroup();
                TestGroupBLL testGroupBLL = new TestGroupBLL();
                int testGroupID = Convert.ToInt32(lvwTestGroup.FocusedItem.Text);
                testGroup = testGroupBLL.Gettest_group(testGroupID);
                txtTestGroup.Text = testGroup.test_group.ToString();

                btnTestGroupSave.Text = "Update";
                btnTestGroupDelete.Enabled = true;
            }
        }

        
 //********************************* E  N D   T E S T  G R O U P     M O D U L E ****************************************






 //********************************* S T A R T   O P E R A T I O N     M O D U L E ****************************************
      
        
        
        private void btnOperationSave_Click(object sender, EventArgs e)
        {

            Operation operation = new Operation();
            OperationBLL operationBLL = new OperationBLL();

            try
            {

                operation.operation_name = txtperationName.Text.ToString();
                operation.operation_procedure = txtProcedure.Text.ToString();
                if (btnOperationSave.Text == "Save")
                {
                    operationBLL.Addoperation(operation);
                    MessageBox.Show("Data Saved Successfully", "NewHIMS");

                }
                else      // FOR UPDATE
                {
                    operation.operation_id = Convert.ToInt32(lvwOperation.FocusedItem.Text);

                    operationBLL.UpdateOperation(operation);
                    MessageBox.Show("Data Updated Successfully", "NewHIMS");
                    btnOperationSave.Text = "Save";

                }
                RefreshOperation();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                operation = null;
                operationBLL = null;
            }
        }



        void RefreshOperation() {

            DataSet ds;
            OperationBLL operationBLL = new OperationBLL();
            ds = operationBLL.Getoperations();
            FillUpListview(lvwOperation, ds);
            btnOperationDelete.Enabled = false;
            btnOperationSave.Text = "Save";
            txtperationName.Text = "";
            txtProcedure.Text = "";
            operationBLL = null;
            ds = null;
        }

        private void btnOperationRefresh_Click(object sender, EventArgs e)
        {
            RefreshOperation();
        }

        private void tabPageOperationName_Enter(object sender, EventArgs e)
        {
            RefreshOperation();
        }

        private void btnOperationDelete_Click(object sender, EventArgs e)
        {
            OperationBLL operationBLL = new OperationBLL();
            int operationID = Convert.ToInt32(lvwOperation.FocusedItem.Text);
            operationBLL.RemoveOperation(operationID);
            MessageBox.Show("Data Deleted Successfully", "NewHIMS");
            RefreshOperation();
        }

        private void lvwOperation_Click(object sender, EventArgs e)
        {
            if (lvwOperation.FocusedItem.Text != "")
            {
                Operation operation = new Operation();
                OperationBLL operationBLL = new OperationBLL();
                int operationID = Convert.ToInt32(lvwOperation.FocusedItem.Text);
                operation = operationBLL.Getoperation(operationID);
                txtperationName.Text = operation.operation_name.ToString();
                txtProcedure.Text = operation.operation_procedure.ToString();
                btnOperationSave.Text = "Update";
                btnOperationDelete.Enabled = true;
            }
        }

        private void btnOperationClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupplierClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void PopulateComboBox(ComboBox combo, DataSet ds, int tableIndex, string displayMember, string valueMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
            combo.SelectedIndex = -1;
            combo.Text = "<Select>";
        }
       


        void PopulateCombo(ComboBox combo, DataSet ds, int tableIndex, string displayMember)
        {
            combo.DataSource = ds.Tables[tableIndex];
            combo.DisplayMember = displayMember;
            
            //combo.Text = "<Select>";
            if (combo.SelectedIndex > 0)
                combo.SelectedIndex = 0;//why -1
        }
        
        

        

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            ////{
            ////    MedicineBLL medicineBLL = new MedicineBLL();
            ////    DataSet ds = new DataSet();

            ////    ds = medicineBLL.GetmedicineType();
            ////    PopulateCombo(cmbMedicineType, ds, 0, "medicine_type");
            ////    cmbMedicineType.SelectedText = "";
            ////}

            //{
            //    //HistoryTextGroupBLL historyTextGroupBLL = new HistoryTextGroupBLL();
            //    //DataSet dss = new DataSet();
            //    //dss = historyTextGroupBLL.Gethistory_text_groups();
            //    //PopulateComboBox(cmbHistoryItemGroup, dss, 0, "history_text_group", "history_text_group_id");

            //}
            //{
            //    HistoryTextBLL historyTextBLL = new HistoryTextBLL();
            //    DataSet dsss = new DataSet();
            //    dsss= historyTextBLL.Gethistory_texts();
            //    PopulateComboBox(cmbHistoryItem, dsss, 0, "history_text", "history_text_id");

            //}

        }

       
        //********************************* E  N D   O P E R A T I O N     M O D U L E ****************************************


        

        //********************************* S T A R T   P A T I E N T     H I S T O R Y ****************************************


        public void PoulateHistoryItmGrpCombo() 
        {
            HistoryTextGroupBLL historyTextGroupBLL = new HistoryTextGroupBLL();
            DataSet ds = historyTextGroupBLL.Gethistory_text_groups();
            PopulateComboBox(cmbHistoryItemGroup, ds, 0, "history_text_group", "history_text_group_id");
        }
        
        public void PopulateHistoryItm() 
        {
            HistoryTextBLL historyTextBLL = new HistoryTextBLL();
            DataSet ds = historyTextBLL.Gethistory_texts();
            PopulateComboBox(cmbHistoryItem, ds, 0, "history_text", "history_text_id");
        }
        
        public void PopulateHistoryItmValue()
        {
            HistoryTextValueBLL historyTextValueBLL = new HistoryTextValueBLL();
            DataSet ds = historyTextValueBLL.Gethistory_text_values();
            PopulateComboBox(cmbHistoryItemValue, ds, 0, "history_text_value", "history_text_value_id");
        }
        
        public void RefreshPatientHistory() 
        {
            
            PoulateHistoryItmGrpCombo();
            PopulateHistoryItm();
            PopulateHistoryItmValue();
        }
        
        
        
        
        
        
        
        private void btnHistoryTextValueClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHistoryTextValueRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoryTextValueDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoryTextValueSave_Click(object sender, EventArgs e)
        {

        }

        private void tabPageHistoryTextGroup_Enter(object sender, EventArgs e)
        {
            RefreshPatientHistory();
        }

        private void cmbHistoryItemGroup_Leave(object sender, EventArgs e)
        {
            if(cmbHistoryItemGroup.Text!="")
            {
                string comboValue = cmbHistoryItemGroup.Text.ToString();
                HistoryTextGroup historyTextGroup = new HistoryTextGroup();
                HistoryTextGroupBLL historyTextGroupBLL = new HistoryTextGroupBLL();
                DataSet ds = historyTextGroupBLL.GetHistoryItmGrpByHistoryGrp(cmbHistoryItemGroup.Text.ToString());

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return;
                }
                else
                {
                    historyTextGroup.history_text_group = cmbHistoryItemGroup.Text.ToString();
                    historyTextGroupBLL.Addhistory_text_group(historyTextGroup);
                    PoulateHistoryItmGrpCombo();
                    this.cmbHistoryItemGroup.SelectedIndex = this.cmbHistoryItemGroup.FindString(comboValue);
                }
            }
        }

        private void txtCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumCheck(e);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

       

     
       


        //********************************* E  N D   P A T I E N T     H I S T O R Y ****************************************



    }  

}
        
 