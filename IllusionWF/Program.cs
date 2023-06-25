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
                    MessageBox.Show("您好像正在使用 Windows 11 或更高的版本。\r\n默认情况下磁贴不受支持，且不建议这样做。", "不支持的系统",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("确认您在使用 Windows 10 。", "不支持的系统",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
