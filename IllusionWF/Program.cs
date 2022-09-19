using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IllusionWF
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            int major = Environment.OSVersion.Version.Major;
            int minor = Environment.OSVersion.Version.Minor;
            int build = Environment.OSVersion.Version.Build;
            if (major > 6 || (major == 6 && (minor == 3 || minor == 2)))
            {
                if (build >= 22000)
                {
                    MessageBox.Show("It looks like you are using Windows 11.\r\nSadly it does not suppport \'Start\' tiles if you haven't use some methods.", "Wow!");
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Make sure you are using Windows 8 or higher\r\nIllusion need an OS that supports \'Start\' tiles.", "Unsupported OS");
            }
        }
    }
}
