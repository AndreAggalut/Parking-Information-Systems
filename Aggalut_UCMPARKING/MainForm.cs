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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBoxForm = new AboutBox1();
            aboutBoxForm.MdiParent = this;
            aboutBoxForm.Show();
        }

        private void showParkingLotStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowParkingForm showParkingForm = new ShowParkingForm();
            showParkingForm.MdiParent = this;
            showParkingForm.Show();
        }

        private void purchaseCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseCreditForm purchaseForm = new PurchaseCreditForm();
            purchaseForm.MdiParent = this;
            purchaseForm.Show();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllUserForm editForm = new ShowAllUserForm();
            editForm.MdiParent = this;
            editForm.Show();
        }

        private void createUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.MdiParent = this;
            createUserForm.Show();
        }

        private void showAllUCMCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCMCustomersForm ucmCustomerForm = new UCMCustomersForm();
            ucmCustomerForm.MdiParent = this;
            ucmCustomerForm.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteForm = new DeleteUserForm();
            deleteForm.MdiParent = this;
            deleteForm.Show();
        }
    }
}
