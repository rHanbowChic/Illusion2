using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IllusionWF
{
    public partial class FormSplash:Form
    {
        public FormSplash()
        {
            InitializeComponent();

            
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            string illusionCfgPath = appdataPath + "\\Roaming\\illusion\\Illusion.json";
            if (File.Exists(illusionCfgPath))
            {
                Form form1 = new Form1();
                this.Hide();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
            else
            {
                int major = Environment.OSVersion.Version.Major;
                int minor = Environment.OSVersion.Version.Minor;
                int build = Environment.OSVersion.Version.Build;
                if (major > 6 || (major == 6 && (minor == 3 || minor == 2)))
                {
                    if (build >= 22000)
                    {
                        MessageBox.Show("您好像正在使用 Windows 11 或更高的版本。\r\n默认情况下磁贴不受支持，且不建议这样做。", "不支持的系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Form form1 = new Form1();
                    this.Hide();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();

                }
                else
                {
                    MessageBox.Show("确认您在使用 Windows 10 。", "不支持的系统", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }
    }
}
