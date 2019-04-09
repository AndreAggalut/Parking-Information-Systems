using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Aggalut_UCMPARKING
{
    public partial class ShowParkingForm : Form
    {
       // private UcmParkingClassLibrary.UcmDataAccessClass ucmAccessClass = new UcmParkingClassLibrary.UcmDataAccessClass();
        private UcmParkingClassLibrary.Parking parkingAccessClass = new UcmParkingClassLibrary.Parking();
        string parking_location;



        public ShowParkingForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getCountButton_Click(object sender, EventArgs e)
        {
            int count = parkingAccessClass.GetCount();
            countLabel.Text = $"Count of Parking Lot : {count.ToString()}";
        }

        private void parkingButton_Click(object sender, EventArgs e)
        {
            if(parkingComboBox.SelectedIndex != -1)
            {
                parking_location = Convert.ToString(parkingComboBox.SelectedValue);
                DataTable parkingTable = new DataTable();
                parkingTable = parkingAccessClass.GetParking(parking_location);
                parkingGridView.DataSource = parkingTable;
                parkingGridView.ReadOnly = false;
                 
            }
            else
            {
                MessageBox.Show("Please Select a parking lot");

            }
        }

        private void ShowParkingForm_Load(object sender, EventArgs e)
        {
            //you use databinding so that when the forms loads the combobox gives you the data
            //you need.
            BindingSource ucmParkingBindingSource = new BindingSource();
            ucmParkingBindingSource.DataSource = parkingAccessClass.GetParkingInformation();

            parkingComboBox.Items.Clear();
            parkingComboBox.DataSource = ucmParkingBindingSource;
            parkingComboBox.DisplayMember = "parking_location";
            parkingComboBox.ValueMember = "parking_location";
            


        }

        private void parkingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
