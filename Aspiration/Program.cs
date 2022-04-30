using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aspiration
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            if(!File.Exists(currentPath + "\\Aspiration.cfg"))
            {
                MessageBox.Show("targetPath -> Aspiration.cfg", "Aspiration:Opener");
                return;
            }

            string targetPath = File.ReadAllText(currentPath + "\\Aspiration.cfg");
            Process p1 = new Process();
            if (targetPath.Substring(targetPath.Length - 3) == "exe")
            {
                /*p1.StartInfo.FileName = targetPath;
                p1.StartInfo.WorkingDirectory = Path.GetDirectoryName(targetPath);
                p1.StartInfo.UseShellExecute = false;
                p1.StartInfo.RedirectStandardInput = true;
                p1.StartInfo.RedirectStandardOutput = true;
                p1.StartInfo.RedirectStandardError = true;
                p1.StartInfo.CreateNoWindow = true;
                p1.Start();*/
                Process.Start("explorer.exe", targetPath);
            }
            else
            Process.Start("explorer.exe", targetPath);

        }
    }
}
