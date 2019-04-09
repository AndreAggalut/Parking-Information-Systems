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
    public partial class UCMCustomersForm : Form
    {
        public UCMCustomersForm()
        {
            InitializeComponent();
        }

        private void UCMCustomersForm_Load(object sender, EventArgs e)
        {
            UCMIntermediaryClass ucmDataConnect = new UCMIntermediaryClass();
            userCustomerGridView.DataSource = ucmDataConnect.GetUCMStudent();
        }
    }
}
