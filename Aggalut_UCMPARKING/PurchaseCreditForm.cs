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
    public partial class PurchaseCreditForm : Form
    {
        public PurchaseCreditForm()
        {
            InitializeComponent();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            UcmParkingClassLibrary.UserClass creditAccess = new UcmParkingClassLibrary.UserClass();
            int ucmid;
            decimal credit;

            try
            {
                if (!int.TryParse(ucmTextBox.Text, out ucmid))
                {
                    MessageBox.Show("Enter proper UCM ID");
                    return;
                }
                if (!decimal.TryParse(amountTextBox.Text, out credit))
                {
                    MessageBox.Show("Enter proper amount");
                    return;
                }

                creditAccess.PurchaseCredit(ucmid, credit);
                billAddedLabel.Text = $"You will be billed ${credit} on your UCM account";
                ucmTextBox.Text = "";
                amountTextBox.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");

            }
        }
    }

}
