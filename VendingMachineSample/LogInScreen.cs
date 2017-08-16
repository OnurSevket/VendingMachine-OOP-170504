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
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void btnEnterPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text;

                EnterProducts enterproduct = new EnterProducts();
                enterproduct.MdiParent = this.MdiParent;
                bool result = enterproduct.OpenDoor(password);
                if (result)
                    enterproduct.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
