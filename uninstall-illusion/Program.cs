using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace uninstall_illusion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length==1 && args[0] == "uninstall")
            {
                string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                string tempPath = appdataPath + "\\Local\\Temp\\Illusion";
                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);
                string htmPath = tempPath + "\\IllusionUninstalled.html";
                if (File.Exists(htmPath))
                    File.Delete(htmPath);
                File.WriteAllText(htmPath, Properties.Resources.Document);
                Process.Start("explorer.exe", htmPath);
            }
            else
            {
                Console.WriteLine("This program will run on uninstall. Use \".\\uninstall-illusion uninstall\" to run it correctly.");
            }
        }
    }
}
