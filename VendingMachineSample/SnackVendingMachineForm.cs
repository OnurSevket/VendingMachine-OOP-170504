using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachine.Abstractions.Monetary;
using VendingMachine.Abstractions.Machine;
using VendingMachineSample.Abstractions.Classes;

namespace VendingMachineSample
{
    public partial class SnackVendingMachineForm : Form
    {
        public SnackVendingMachineForm()
        {
            InitializeComponent();
        }        

        SnackVendingMachine snackvendingMachine;
        string temp;
        private void SnackVendingMachineForm_Load(object sender, EventArgs e)
        {
            snackvendingMachine = new SnackVendingMachine(8);

            foreach (var item in SnackVendingMachine.snackList)
            {
                if (temp == item.Name)
                {
                    continue;
                }
                ListViewItem listview = new ListViewItem();
                listview.Text = item.Name;
                temp = item.Name;

                listview.SubItems.Add(item.Price.ToString());
                listview.SubItems.Add(item.slotCode);
                listview.Tag = item;

                lwShowSnacks.Items.Add(listview);
            }
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            string input = txtEntereMoney.Text;
            decimal price = decimal.Parse(input);
            IEnumerable<Money> moneyEnum = GetMoney(price);
            Money enteredMoney = (Money)moneyEnum;

            snackvendingMachine.AddMoney(enteredMoney);

            lblenteredMoney.Text = snackvendingMachine.AccumulatedAmount.ToString();
        }

        IEnumerable<Money> GetMoney(decimal price)
        {

            Money money = null;
            money.Value = price;
            yield return money;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try {
                snackvendingMachine.OK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnSelectSnack_Click(object sender, EventArgs e)
        {
            string selectedSlotCode = txtProductCode.Text;

            foreach (var item in SnackVendingMachine.snackList)
            {
                if (selectedSlotCode == item.slotCode)
                {
                    snackvendingMachine.selectedProduct.Add(item);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                snackvendingMachine.Cancel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
