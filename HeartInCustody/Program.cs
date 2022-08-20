using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartInCustody
{
    class Program
    {
        static void CreateIlsTmp()
        {
            string tempPath = Path.GetTempPath();
            if (!Directory.Exists(tempPath + "\\Illusion"))
                Directory.CreateDirectory(tempPath + "\\Illusion");
        }
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Heart in Custody: PIL Tile Generator\r\nHeartInCustody targetPath r g b");
                return;
            }
            string targetPath = args[0];
            int r = Convert.ToInt32(args[1]);
            int g = Convert.ToInt32(args[2]);
            int b = Convert.ToInt32(args[3]);
            bool customIco = false;
            string customIcoPath = "";
            if (args.Length == 6)
            {
                if (args[4] == "-ico")
                {
                    customIco = true;
                    customIcoPath = args[5];
                }
            }
            string currentPath= Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location); ;
            string tempPath = Path.GetTempPath();
            string illusionTempPath = tempPath + "\\Illusion";
            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            string illusionDataPath = appdataPath + "\\Local\\Illusion\\";
            string pythonExePath= currentPath + "\\Pylib\\python.exe";
            string illusionRoamingPath = appdataPath + "\\Roaming\\illusion";


            ConfigObject config;
            string configText = File.ReadAllText(illusionRoamingPath + "\\Illusion.json");
            config = JsonConvert.DeserializeObject<ConfigObject>(configText);
            if (config.useCustomPython)
                pythonExePath = config.customPythonExePath;
            int sizeOffset = config.imgOffsetValue;
            CreateIlsTmp();
            Process p1 = new Process();
            if (customIco == false)
            {
                if (targetPath.Contains("Appx:"))
                    p1.StartInfo.FileName = currentPath + "\\ExtractAppxIcon.exe";
                else
                    p1.StartInfo.FileName = currentPath + "\\ExtractIcon.exe";
                p1.StartInfo.WorkingDirectory = currentPath;
                if (targetPath.Contains("Appx:"))
                    p1.StartInfo.Arguments = $" \"{targetPath.Substring(5)}\" \"{illusionTempPath}\\exeicon.png\"";
                else
                    p1.StartInfo.Arguments = $" \"{targetPath}\" \"{illusionTempPath}\\exeicon.png\"";
                Console.WriteLine($" \"{targetPath}\" \"{illusionTempPath}\\exeicon.png\"");
                p1.StartInfo.UseShellExecute = false;
                p1.StartInfo.RedirectStandardInput = true;
                p1.StartInfo.RedirectStandardOutput = true;
                p1.StartInfo.RedirectStandardError = true;
                p1.StartInfo.CreateNoWindow = true;
                Console.WriteLine($" \"{targetPath}\" \"{illusionTempPath}\\exeicon.png\"");
                p1.Start();
                p1.WaitForExit();
                p1.Close();
            }
            else
            {
                if (File.Exists($"{illusionTempPath}\\exeicon.png"))
                    File.Delete($"{illusionTempPath}\\exeicon.png");
                File.Copy(customIcoPath, $"{illusionTempPath}\\exeicon.png");

            }

            if (!File.Exists(illusionTempPath + "\\Heart.py"))
            {
                File.Copy(currentPath + "\\Heart.py", illusionTempPath + "\\Heart.py");
            }
            if (!File.Exists(illusionTempPath + "\\blank.png"))
            {
                File.Copy(currentPath + "\\blank.png", illusionTempPath + "\\blank.png");
            }
            if (!File.Exists(illusionTempPath + "\\blankSmall.png"))
            {
                File.Copy(currentPath + "\\blankSmall.png", illusionTempPath + "\\blankSmall.png");
            }
            Process p2 = new Process();
            p2.StartInfo.FileName = pythonExePath;
            p2.StartInfo.WorkingDirectory = illusionTempPath;
            p2.StartInfo.Arguments = $" \"{illusionTempPath}\\Heart.py\" {r} {g} {b} Aspiration {sizeOffset}";
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardInput = true;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.RedirectStandardError = true;
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            p2.WaitForExit();
            p2.Close();

        }

    }
}
