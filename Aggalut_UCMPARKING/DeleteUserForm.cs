using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggalut_UCMPARKING
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UcmParkingClassLibrary.UserClass ucmAccessClass = new UcmParkingClassLibrary.UserClass();
            int ucmid;
             

            try
            {
                if(!int.TryParse(deleteTextBox.Text, out ucmid))
                {
                    MessageBox.Show("Please enter proper UCM ID");
                    return;


                }
                DialogResult dr = MessageBox.Show("You sure you wanted to delete?", "caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr== DialogResult.Yes)
                {

                    ucmAccessClass.DeleteUser(ucmid);
                    deleteLabel.Text = "Successfully deleted customer.";
                    deleteTextBox.Text = "";
                    return;
                }
                else if(dr == DialogResult.No)
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
