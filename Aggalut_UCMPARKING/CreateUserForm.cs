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
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            UcmParkingClassLibrary.UserClass customerAccess = new UcmParkingClassLibrary.UserClass();
            int customer_ucmid;
            decimal credit;
            
            
             

            try
            {
                if (!int.TryParse(ucmIdTextBox.Text, out customer_ucmid))
                {
                    MessageBox.Show("Please Enter A Valid UCM ID");
                    return;
                }//end if
                if(!decimal.TryParse(creditTextBox.Text, out credit))
                {
                    MessageBox.Show("Please input proper credit");
                    return;
                }
                DialogResult dr = MessageBox.Show("You sure you wanted to add?", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    customerAccess.CreateUser(customer_ucmid, statusTextBox.Text, credit);

                    ucmIdTextBox.Text = "";
                    statusTextBox.Text = "";
                    creditTextBox.Text = "";
                    ucmIdTextBox.Text = "";

                    resultLabel.Text = "1 UCM CUSTOMER ADDED SUCCESSFULLY";
                    return;
                }
                else if (dr == DialogResult.No)
                {
                    this.Close();
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
