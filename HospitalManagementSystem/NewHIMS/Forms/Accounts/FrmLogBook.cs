using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HIMS.BLL;
using HIMS.BusinessObjects;
using System.Data.Common;
using NewHIMS.Reports;
using CrystalDecisions.CrystalReports.Engine;

namespace NewHIMS.Forms.Accounts
{
    public partial class FrmLogBook : BaseForm.FrmBase
    {
        public FrmLogBook()
        {
            InitializeComponent();
        }


        private void FrmLogBook_Load(object sender, EventArgs e)
        {
            this.vehicleComboBox.SelectedIndexChanged -= this.vehicleComboBox_SelectedIndexChanged;
            fuelTypeComboBox.DataSource = Enum.GetValues(typeof(EnumClass.FuelType));
            vehicleComboBox.DataSource = Enum.GetValues(typeof(EnumClass.VehicalType));
            this.vehicleComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleComboBox_SelectedIndexChanged);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleLog oVehicleLog = new VehicleLog();
                VehicleLogBLL oVehicleLogBLL = new VehicleLogBLL();
                oVehicleLog.vehicle_no = vehicleComboBox.SelectedItem.ToString();
                oVehicleLog.starting_date = Convert.ToDateTime(startDateTimePicker.Text);
                oVehicleLog.ending_date = Convert.ToDateTime(endDateTimePicker.Text);
                oVehicleLog.staring_km = Convert.ToInt32(startTextBox.Text);
                oVehicleLog.end_km = Convert.ToInt32(startTextBox.Text);
                oVehicleLog.destination = destinationTextBox.Text;
                oVehicleLog.total_amount = Convert.ToDecimal(totalAmountTextbox.Text);
                oVehicleLog.fuel_typeId = Convert.ToInt32(fuelTypeComboBox.SelectedValue);
                oVehicleLog.quantity = Convert.ToDecimal(quantityTextBox.Text);
                oVehicleLog.remarks = remarksTextBox.Text;
                oVehicleLog.driver = driverTextBox.Text;
                oVehicleLog.customer_name = customerNameTextBox.Text;
                oVehicleLog.record_created_by = ApplicatinLauncher._userId;
                oVehicleLogBLL.vehicleLogSave(oVehicleLog);
                MessageBox.Show("Data Saved Successfully");
            }
            catch
            {
            }
            


        }

        private void vehicleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (vehicleComboBox.SelectedIndex != -1)
                {
                    VehicleLogBLL oVehicleLogBLL = new VehicleLogBLL();
                    DataSet ds = oVehicleLogBLL.GetVehicle(Convert.ToInt32(vehicleComboBox.SelectedValue));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        vehicleNoComboBox.DataSource = ds.Tables[0];
                        vehicleNoComboBox.DisplayMember = "vehicle_no";
                        vehicleNoComboBox.ValueMember = "vehicle_type_id";
                    }
                }
            }
            catch
            {
            }
        }

    }
}
