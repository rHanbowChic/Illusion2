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
    public partial class Form3 : Form
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
            if (!File.Exists(illusionRoamingPath + "\\Illusion.json"))
            {
                File.WriteAllText(illusionRoamingPath + "\\Illusion.json", "{\"isWindows8\": false,\"sleepTime\": 5000}");
            }
            string configText = File.ReadAllText(illusionRoamingPath + "\\Illusion.json");
            config = JsonConvert.DeserializeObject<ConfigObject>(configText);
            int sleepTime = config.sleepTime;
            sleepTimeBox.Text = sleepTime.ToString();
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

        protected override void WndProc(ref Message msg)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            //MICROSOFT's API.
            if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
            {
                int sleepTime = Convert.ToInt32(sleepTimeBox.Text);
                config.sleepTime = sleepTime;
                string configText = JsonConvert.SerializeObject(config);
                File.WriteAllText(illusionRoamingPath + "\\Illusion.json", configText);
            }
            base.WndProc(ref msg);
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
            int sleepTime = Convert.ToInt32(sleepTimeBox.Text);
            config.sleepTime = sleepTime;
            string configText = JsonConvert.SerializeObject(config);
            File.WriteAllText(illusionRoamingPath + "\\Illusion.json", configText);
        }
    }
}
