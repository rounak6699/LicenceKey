using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace LicenceKey
{
    public partial class KeyGeneration : Form
    {
        public KeyGeneration()
        {
            InitializeComponent();
            String machineCode = machineText.Text + Environment.MachineName;
            machineText.Text = machineCode;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        
        private void generatedKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void KeyGeneration_Load(object sender, EventArgs e)
        {

        }

        private void validate_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            String productName = productText.Text.ToString();
            var machineCode = machineText.Text+Environment.MachineName;
            //String version = versionText.Text.ToString();
            String inputString = productName + machineCode ;
            var encryptedString = KeyGeneration.EncryptString(key, inputString);
            var Result = KeyGeneration.Base64Encode(encryptedString).ToUpper();
            var format = String.Format(FormatLicenseKey(Result));
            generatedKey.Text = format;
        }

        private void productText_TextChanged(object sender, EventArgs e)
        {

        }

        private void machineText_TextChanged(object sender, EventArgs e)
        {
            
        }
        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }


        public static string Base64Encode(string encryptedString)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(encryptedString);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        static string GenerateLicenseKey(string Result)
        {
            return FormatLicenseKey(Base64Encode(Result));
        }
        static string FormatLicenseKey(string Result)
        {
            Result = Result.Substring(0, 32).ToUpper();
            char[] serialArray = Result.ToCharArray();
            StringBuilder licenseKey = new StringBuilder();

            int j = 0;
            for (int i = 0; i < 32; i++)
            {
                for (j = i; j < 4 + i; j++)
                {
                    licenseKey.Append(serialArray[j]);
                }
                if (j == 32)
                {
                    break;
                }
                else
                {
                    i = (j) - 1;
                    licenseKey.Append("-");
                }
            }
            return licenseKey.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void machineText_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatedKey.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            keyValidation f2 = new keyValidation();
            f2.fromKeyGeneration(productText.Text.ToString());
            f2.Show();
        }
    }
}
