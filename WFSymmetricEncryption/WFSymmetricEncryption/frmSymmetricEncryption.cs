using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSymmetricEncryption
{
    public partial class frmSymmetricEncryption : Form
    {
        string decryptedText;
        string encryptedText;
        
        static TripleDESCryptoServiceProvider TDES;

        static byte[] iv;
        static byte[] key;
        public frmSymmetricEncryption()
        {
            InitializeComponent();

            decryptedText = String.Empty;
            encryptedText = String.Empty;

            TDES = new TripleDESCryptoServiceProvider();

            iv = TDES.IV;
            key = new byte[] { };

            
        }

        private void BtnHashCode_Click(object sender, EventArgs e)
        {
            key = GetHash(tbxCode.Text);

            tbxCode.Text = String.Empty;
            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;
            btnHashCode.Enabled = false;
            tbxHashedCode.Text = GetHashString(key);
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            decryptedText = tbxDecryptedText.Text;
            if (decryptedText.Length > 0)
            {
                encryptedText = EncryptTextWithTDES(decryptedText);
            }


            tbxEncryptedText.Text = encryptedText;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            encryptedText = tbxEncryptedText.Text;
            if (encryptedText.Length > 0)
            {
                decryptedText = DecrypTextWithTDES(encryptedText);
            }

            tbxDecryptedText.Text = decryptedText;
        }

        private void TbxCode_TextChanged(object sender, EventArgs e)
        {
            tbxHashedCode.Text = String.Empty;
            btnHashCode.Enabled = true;
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
        }

        private string EncryptTextWithTDES(string inputText)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(inputText);
            ICryptoTransform encryptor = TDES.CreateEncryptor(key, iv);
            byte[] cryptedTextAsByte = encryptor.TransformFinalBlock(textAsByte, 0, textAsByte.Length);

            return Convert.ToBase64String(cryptedTextAsByte);
        }

        static string DecrypTextWithTDES(string cryptedText)
        {
            byte[] cryptedTextAsByte = Convert.FromBase64String(cryptedText);
            ICryptoTransform decryptor = TDES.CreateDecryptor(key, iv);
            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            return Encoding.Default.GetString(decryptedTextAsByte);
        }

        public static byte[] GetHash(string inputString)
        {
            byte[] hash = { };
            using(HashAlgorithm algorithm = MD5.Create())
            {
                hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            }

            return hash;
        }

        public static string GetHashString(byte[] inputHash)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in inputHash)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString().ToLower();
        }
    }
}
