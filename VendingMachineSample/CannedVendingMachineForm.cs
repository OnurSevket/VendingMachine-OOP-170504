using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Abstractions.Machine;
using VendingMachine.Abstractions.Monetary;
using VendingMachineSample.Abstractions.Classes;

namespace VendingMachineSample
{
    public partial class CannedVendingMachineForm : Form
    {
        public CannedVendingMachineForm()
        {
            InitializeComponent();
        }

        CannedVendingMachine cannedVendingMachine;

        private void btnSelectCanned_Click(object sender, EventArgs e)
        {
            string selectedCannedDrink = txtProductCode.Text;

            foreach (var item in CannedVendingMachine.CannedList)
            {
                if (selectedCannedDrink==item.slotCode)
                {
                   
                }
            }
        }
    }
}
