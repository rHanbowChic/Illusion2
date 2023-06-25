using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IllusionWF
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/rHanbowChic/Illusion2");
            this.Height = 430;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            if (File.Exists(currentPath + "\\Readme.txt"))
                System.Diagnostics.Process.Start("explorer.exe", currentPath + "\\Readme.txt");
            else
                linkLabel2.Text = "咦咦咦？这个文件好像不存在的样子...";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
