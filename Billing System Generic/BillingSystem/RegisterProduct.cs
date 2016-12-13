using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.IO;
using SecurityHelper;

namespace ClientApplication
{
    public partial class GenerateKey : Form
    {
        public GenerateKey()
        {
            InitializeComponent();
        }
        private void CustomerKey_Click(object sender, EventArgs e)
        {
            string customerKey = "";
            string message = "";
            EncryptionHelper encryptionHelper = new EncryptionHelper();
            bool isRegister = encryptionHelper.GenerateProductKey(ref customerKey, ref message);

            if (isRegister)
            {
                CutomerKey.Text = customerKey;
                CutomerKey.Visible = true;
                labelProductKey.Visible = true;
            }
            else
            {
                CutomerKey.Visible = false;
                labelProductKey.Visible = false;
                MessageBox.Show(message);
                return;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GenerateKey.ActiveForm.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (RegisterProductKeyTxt.Text == "")
            {
                MessageBox.Show("Please enter register key ...");
                RegisterProductKeyTxt.Focus();
                return;
            }

            string message = "";

            EncryptionHelper encryptionHelper = new EncryptionHelper();
            bool isRegister = encryptionHelper.RegisterProduct(RegisterProductKeyTxt.Text, ref message);

            if (isRegister)
            {
                MessageBox.Show("Congratulations !!! Product regsiter successfully... Please relogin ...");
                Application.Exit();
            }
            else
            {
                MessageBox.Show(message);
                return;
            }
        }
    }
}
