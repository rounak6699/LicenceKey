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
using Microsoft.Win32;

namespace LicenceKey
{
    public partial class keyValidation : Form
    {
        static string productName;
        static RegistryKey BaseFolderPath = Registry.CurrentUser;
        static string SubFolderPath = "secureCipher";

        Label status = new Label();
        

        public static void Registry_write(String txt)
        {
            RegistryKey RegKey = BaseFolderPath;
            RegistryKey SubKey = RegKey.CreateSubKey(SubFolderPath);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(SubFolderPath);

            //if it does exist, retrieve the stored values  
            
            if (key != null && key.GetValue(productName)!= null)
            {
                MessageBox.Show("Allready registerd.","Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                key.Close();
            }
            else
            {
                try
                {
                    SubKey.SetValue(productName, txt);
                    MessageBox.Show("Registered Successfully.");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Registry Fail!!." + e);
                }
            }
            
           
        }

        public static string Registry_read()
        {
            RegistryKey RegKey = BaseFolderPath;
            RegistryKey SubKey = RegKey.OpenSubKey(SubFolderPath);
            return SubKey.GetValue(productName).ToString();
        }

        public keyValidation()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registry_write(copyLicence.Text.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void fromKeyGeneration(string name)
        {
            productName = name;
        }


    }
}
