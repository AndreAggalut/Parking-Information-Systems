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
    public partial class ShowAllUserForm : Form
    {
        public ShowAllUserForm()
        {
            InitializeComponent();
        }

        private void ShowAllUserForm_Load(object sender, EventArgs e)
        {
            UCMIntermediaryClass ucmDataConnectClass = new UCMIntermediaryClass();
            
            dataGridView1.DataSource = ucmDataConnectClass.GetData();
        }
    }
}
