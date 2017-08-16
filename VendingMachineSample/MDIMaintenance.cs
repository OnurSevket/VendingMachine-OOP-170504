using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSample
{
    public partial class MDIMaintenance : Form
    {
        public MDIMaintenance()
        {
            InitializeComponent();
        }

        private void msiAddProdduct_Click(object sender, EventArgs e)
        {
            LogInScreen loginScreen = new LogInScreen();
            loginScreen.MdiParent = this;
            loginScreen.Show();

        }

        private void miBuySnack_Click(object sender, EventArgs e)
        {
            SnackVendingMachineForm snackVendingMachine = new SnackVendingMachineForm();
            snackVendingMachine.MdiParent = this;
            snackVendingMachine.Show();
        }

        private void miCannedDrinks_Click(object sender, EventArgs e)
        {
            CannedVendingMachineForm cannedVendingMachine = new CannedVendingMachineForm();
            cannedVendingMachine.MdiParent = this;
            cannedVendingMachine.Show();
        }
    }
}
