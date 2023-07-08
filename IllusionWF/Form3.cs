using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace IllusionWF
{
    public partial class Form3 : MaterialForm
    {
        ConfigObject config;
        string illusionRoamingPath;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            
            illusionRoamingPath = appdataPath + "\\Roaming\\illusion";
            if (!Directory.Exists(illusionRoamingPath))
            {
                Directory.CreateDirectory(illusionRoamingPath);
            }
            if (!File.Exists(illusionRoamingPath + "\\Illusion.json"))
            {
                File.WriteAllText(illusionRoamingPath + "\\Illusion.json", "{\"isWindows8\": false,\"sleepTime\": 5000}");
            }
            string configText = File.ReadAllText(illusionRoamingPath + "\\Illusion.json");
            config = JsonConvert.DeserializeObject<ConfigObject>(configText);
            int sleepTime = config.sleepTime;
            sleepTimeBox.Text = sleepTime.ToString();
            usePythonBox.Checked = config.useCustomPython;
            pythonExePathBox.Text = config.customPythonExePath;
            sizeOffsetBox.Text = config.imgOffsetValue.ToString();
        }

        private void sleepTimeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        

        private void resetButton_Click(object sender, EventArgs e)
        {
            string illusionTempPath = Path.GetTempPath() + "\\Illusion";
            if (Directory.Exists(illusionTempPath))
            {
                Directory.Delete(illusionTempPath,true);
            }
            Process.Start(".\\IllusionWF.exe");
            Application.Exit();

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sleepTimeBox.Text != "")
            {
                int sleepTime;
                if (sleepTimeBox.Text.Length < 10)//2147483647 has 10 digits
                {
                    sleepTime = Convert.ToInt32(sleepTimeBox.Text);
                    if (sleepTime > 15000)
                        sleepTime = 15000;
                }
                else
                    sleepTime = 15000;
                config.sleepTime = sleepTime;
            }
            config.useCustomPython = usePythonBox.Checked;
            if (File.Exists(pythonExePathBox.Text))
            {
                config.customPythonExePath = pythonExePathBox.Text;
            }
            if (!File.Exists(config.customPythonExePath))
                config.useCustomPython = false;
            
            bool IsDigitsOnly(string str)//strings like "-", "--" will bypass this, but I don't want to TRY!
            {
                foreach (char c in str)
                {
                    if ((c < '0' || c > '9') && c!='-')
                        return false;
                }

                return true;
            }
            if (IsDigitsOnly(sizeOffsetBox.Text) && sizeOffsetBox.Text!="")
            {
                int sizeOffset;
                if (sizeOffsetBox.Text.Length < 10)
                {
                    sizeOffset = Convert.ToInt32(sizeOffsetBox.Text);
                    if (sizeOffset < -23)
                        sizeOffset = -23;
                    if (sizeOffset > 227)//227 was a wonderful number :3
                        sizeOffset = 227;//227 is a wonderful number :3
                }
                else
                    sizeOffset = 227;//227 will always be a wonderful number :3
                config.imgOffsetValue = sizeOffset;
            }
            string configText = JsonConvert.SerializeObject(config);
            File.WriteAllText(illusionRoamingPath + "\\Illusion.json", configText);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(illusionRoamingPath+"\\Illusion.json"))
                System.Diagnostics.Process.Start("explorer.exe", illusionRoamingPath+"\\Illusion.json");

        }
    }
}
