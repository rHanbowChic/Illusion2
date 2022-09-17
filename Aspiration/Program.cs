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
            if (targetPath.Contains(".exe "))
            {
                /*p1.StartInfo.FileName = targetPath;
                p1.StartInfo.WorkingDirectory = Path.GetDirectoryName(targetPath);
                p1.StartInfo.UseShellExecute = false;
                p1.StartInfo.RedirectStandardInput = true;
                p1.StartInfo.RedirectStandardOutput = true;
                p1.StartInfo.RedirectStandardError = true;
                p1.StartInfo.CreateNoWindow = true;
                p1.Start();*/
                
                string targetExe = targetPath;
                if (targetPath.Contains(".exe "))
                {
                    targetExe = targetPath.Substring(0, targetPath.IndexOf(".exe ")+4);
                }
                string targetArgs = "";
                if (targetPath.Contains(".exe "))
                {
                    targetArgs = targetPath.Substring(targetPath.IndexOf(".exe ")+5);
                }
                p1.StartInfo.FileName = targetExe;
                p1.StartInfo.WorkingDirectory = Path.GetDirectoryName(targetExe);
                p1.StartInfo.Arguments = targetArgs;
                p1.StartInfo.UseShellExecute = false;
                p1.StartInfo.RedirectStandardInput = true;
                p1.StartInfo.RedirectStandardOutput = true;
                p1.StartInfo.RedirectStandardError = true;
                p1.StartInfo.CreateNoWindow = true;
                p1.Start();
                p1.StandardInput.WriteLine(targetPath+" && exit");
                p1.WaitForExit();
                p1.Close();
            }
            else
            Process.Start("explorer.exe", " " + targetPath);

        }
    }
}
