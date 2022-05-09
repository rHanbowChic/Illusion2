using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HeavenlyThread
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("HeavenlyThread:Ultimate Threader\r\nHeavenlyThread name targetPath r g b showName defaultTheme");
                return;
            }
            string appName = args[0];
            string targetPath = args[1];
            string r = args[2];
            string g = args[3];
            string b = args[4];
            string showName = args[5];
            string defaultTheme = args[6];
            string tempPath = Path.GetTempPath();
            string illusionTempPath = tempPath + "\\Illusion";
            string currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string tilePath = illusionTempPath + "\\Aspiration.tile.png";
            string tileSmallPath = illusionTempPath + "\\Aspiration.tileSmall.png";
            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            string illusionDataPath = appdataPath + "\\Local\\Illusion\\";
            string illusionMenuPath = appdataPath + "\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Illusion\\";



            if (args.Length == 8)
            {
                tilePath = tileSmallPath = args[7];
            }
            Process p1 = new Process();
            p1.StartInfo.WorkingDirectory = currentPath;
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardInput = true;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.RedirectStandardError = true;
            p1.StartInfo.CreateNoWindow = true;

            p1.StartInfo.FileName = currentPath + "\\Prologue.exe";
            p1.StartInfo.Arguments = $" \"{targetPath}\" \"{appName}\"";
            
            p1.Start();
            p1.WaitForExit();
            p1.Close();

            p1.StartInfo.FileName = currentPath + "\\HeartInCustody.exe";
            p1.StartInfo.Arguments = $" \"{targetPath}\" {r} {g} {b}";

            p1.Start();
            p1.WaitForExit();
            p1.Close();

            XmlDocument vManifest = new XmlDocument();
            vManifest.Load("Template.xml");
            XmlElement xe = (XmlElement)vManifest.SelectSingleNode("Application/VisualElements");
            xe.SetAttribute("ForegroundText", defaultTheme);
            xe.SetAttribute("ShowNameOnSquare150x150Logo", showName);
            vManifest.Save(illusionDataPath + appName + "\\Aspiration.VisualElementsManifest.xml");

            if (File.Exists(illusionDataPath + appName + "\\Aspiration.tile.png"))
                File.Delete(illusionDataPath + appName + "\\Aspiration.tile.png");
            if (File.Exists(illusionDataPath + appName + "\\Aspiration.tileSmall.png"))
                File.Delete(illusionDataPath + appName + "\\Aspiration.tileSmall.png");
            File.Copy(tilePath, illusionDataPath + appName + "\\Aspiration.tile.png");
            File.Copy(tileSmallPath, illusionDataPath + appName + "\\Aspiration.tileSmall.png");
            
            p1.StartInfo.FileName = currentPath + "\\Epilogue.exe";
            p1.StartInfo.Arguments = $" \"{illusionMenuPath}{appName}.lnk\"";
            Console.WriteLine($" \"{illusionMenuPath}{appName}.lnk\"");
            p1.Start();
            p1.WaitForExit();
            p1.Close();
            
        }
    }
}
