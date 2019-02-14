using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCrashChecksum
{
    public partial class frmMain : Form
    {
        string currentMD5;
        public frmMain()
        {
            InitializeComponent();
            currentMD5 = String.Empty;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            currentMD5 = CalculateMD5($"{Directory.GetCurrentDirectory()}\\{AppDomain.CurrentDomain.FriendlyName}");
            using (var reader = new StreamReader($"{Directory.GetCurrentDirectory()}\\sum.txt"))
            {
                string oldMD5 = reader.ReadToEnd();
                if(currentMD5 != oldMD5)
                {
                    Application.Exit();
                }
                else
                {
                    Text = "bravo";
                }
            }
        }

        static string CalculateMD5(string fileName)
        {
            using (FileStream stream = File.OpenRead(fileName))
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
        }
    }
}
