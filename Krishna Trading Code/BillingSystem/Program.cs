using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BillingSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //string message = "";
            //int returnValue=0;
            //SecurityHelper.EncryptionHelper encryptionHelper = new SecurityHelper.EncryptionHelper();
            //bool isRegister = encryptionHelper.CheckProduct(ref message, ref returnValue);

            //if (isRegister == false)
            //{
            //    if (message.Trim() != "")
            //    {
            //        MessageBox.Show(message);
            //    }
            //    Application.Run(new ClientApplication.GenerateKey());
            //}
            //else
            //{
                Application.Run(new frmGBSMain());
            //}
        }
    }
}
