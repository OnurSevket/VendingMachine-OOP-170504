using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachineSample.Abstractions.Classes;
using VendingMachine.Abstractions.Machine;
using VendingMachineSample.Constants;

namespace VendingMachineSample
{
    public partial class EnterProducts : Form, IVendingMachineMaintenance
    {
        public EnterProducts()
        {
            InitializeComponent();
        }

        MachineState machineState = MachineState.On;
        DoorState doorState;

        public void SwitchOn()
        {
            if (MachineState.On == machineState)
                throw new Exception("Zaten açık");
            else
                machineState = MachineState.On;
        }

        public void SwitchOff()
        {
            if (MachineState.Off == machineState)
                throw new Exception("Zaten Kapali");
            else
                machineState = MachineState.Off;
        }

        public void OutOfOrder()
        {
            if (machineState == MachineState.OutOfOrder)
            {

            }

        }
        public bool OpenDoor(string keycode)
        {
            if (keycode == "1234")
            {
                if (DoorState.Opened == doorState)
                {
                    throw new Exception("Kapi zaten acik");
                }
                else
                {
                    doorState = DoorState.Opened;
                    return true;
                }
            }
            else
            {
                throw new Exception("Yanlis sifre girdiniz!");
            }

        }

        public bool LockDoor()
        {
            if (DoorState.Locked == doorState)
            {
                throw new Exception("Kapi zaten Kapali");
            }
            else
            {
                doorState = DoorState.Locked;
                return true;
            }
        }


        void AddStuff<TStuff>(TStuff stuff)
        {
            throw new Exception("burada hata var");
        }

        TStuff RemoveStuff<TStuff>(int amount)
        {
            throw new Exception("Buradada var");
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (doorState == DoorState.Locked)
            {
                throw new Exception("Kapi kapaliyken urun Ekleyemezsiniz!");
            }
            if (!(txtProductName.Text.Length > 0 && txtPrice.Text.Length > 0
                && txtAmount.Text.Length > 0 && txtSlotCode.Text.Length > 0))
            {
                MessageBox.Show("Lutfen bos deger birakmayiniz!");
                return;
            }
            else
            {
                decimal price;
                string input = txtPrice.Text;
                bool status = decimal.TryParse(input, out price);
                if (status == true)
                {
                    if (price <= 0)
                    {
                        MessageBox.Show("Fiyat 0dan kucuk olamaz!");
                        return;
                    }
                }
                Slot<Snack> product = new Slot<Snack>();
                product.Name = txtProductName.Text;
                product.Price = price;
                product.slotCode = txtSlotCode.Text;
                product.hasProduct = true;

                SnackVendingMachine snackMachine = new SnackVendingMachine(8);
                // snackMachine[slotCode];

                /*
                 * listenin içini gezecek 
                 * slotu kontrol edecek slot kodun olduğu alanda bakacak 
                 * alandaki ürün eklenen ürün ile aynı özellikte ise ekleyecek 
                 * 
                 */
                 if (cmbProductType.SelectedIndex == 1)
                 {
                    foreach (var item in CannedVendingMachine.CannedList)
                    {
                        if (item.slotCode == product.slotCode)
                        {
                            if(item==product)
                            {
                                this.AddProduct(product);
                                break;
                            }
                            else
                            {
                                throw new Exception("Bu ürün bu slot için uygun değil");
                            }
                        }
                      }
                     this.AddProduct(product);
                 }
                if (cmbProductType.SelectedIndex == 0)
                 {
                    foreach (var item in SnackVendingMachine.snackList)
                    {
                        if (item.slotCode == product.slotCode)
                        {
                            if(item==product)
                            {
                                this.AddProduct(product);
                                break;
                            }
                            else
                            {
                                throw new Exception("Bu ürün bu slot için uygun değil");
                            }
                        }
                      }
                     this.AddProduct(product);
                 }

              
                ClearControsTexts();
            }

        }

        private void AddProduct(Slot<Snack> slot)
        {
            if (cmbProductType.SelectedIndex == 0)
            {
                for (int i = 0; i < int.Parse(txtAmount.Text); i++)
                {
                    SnackVendingMachine.snackList.Add(slot);
                }
            }
            else
            {
                for (int i = 0; i < int.Parse(txtAmount.Text); i++)
                {
                    CannedVendingMachine.CannedList.Add(slot);
                }
            }


            if (cmbProductType.SelectedIndex == 0)
            {
                foreach (var item in SnackVendingMachine.snackList)
                {
                    lstShowProducts.Items.Add(item);
                }
            }
            else
            {
                foreach (var item in CannedVendingMachine.CannedList)
                {
                    lstShowProducts.Items.Add(item);
                }

            }
        }

        private void ClearControsTexts()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }

        private void EnterProducts_Load(object sender, EventArgs e)
        {
            foreach (var item in SnackVendingMachine.snackList)
            {
                lstShowProducts.Items.Add(item);
            }
            foreach (var item in CannedVendingMachine.CannedList)
            {
                lstShowProducts.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (doorState == DoorState.Locked)
            {
                throw new Exception("Kapi kapaliyken urun silemezsiniz!");
            }
            foreach (var item in SnackVendingMachine.snackList)
            {
                if (lstShowProducts.SelectedItem == item)
                {
                    lstShowProducts.Items.Remove(item);
                    SnackVendingMachine.snackList.Remove(item);
                    break;
                }


            }
            foreach (var item in CannedVendingMachine.CannedList)
            {
                if (lstShowProducts.SelectedItem == item)
                {
                    lstShowProducts.Items.Remove(item);
                    CannedVendingMachine.CannedList.Remove(item);
                    break;
                }

            }



        }




        void IVendingMachineMaintenance.SwitchOn()
        {
            this.SwitchOn(); ;
        }

        void IVendingMachineMaintenance.SwitchOff()
        {
            this.SwitchOff();
        }

        Constants.MachineState IVendingMachineMaintenance.MachineState
        {
            get { return machineState; }
        }

        bool IVendingMachineMaintenance.OpenDoor(string keycode)
        {
            return OpenDoor(keycode);
        }

        bool IVendingMachineMaintenance.LockDoor()
        {
            return LockDoor();
        }

        Constants.DoorState IVendingMachineMaintenance.DoorState
        {
            get { return doorState; }
        }

        void IVendingMachineMaintenance.AddStuff<TStuff>(TStuff stuff)
        {
            this.AddStuff<TStuff>(stuff);
        }

        TStuff IVendingMachineMaintenance.RemoveStuff<TStuff>(int amount)
        {
            return this.RemoveStuff<TStuff>(amount);
        }



        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            doorState = DoorState.Locked;
            foreach (Form item in this.MdiParent.MdiChildren)
            {
                item.Close();
            }
        }

        private void EnterProducts_FormClosing(object sender, FormClosingEventArgs e)
        {

            foreach (Form item in this.MdiParent.MdiChildren)
            {
                if (item is LogInScreen)
                {
                    foreach (Control control in item.Controls)
                    {
                        if (control is TextBox)
                        { control.Text = ""; }
                    }
                }
            }
        }
    }
}
