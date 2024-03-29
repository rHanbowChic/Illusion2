﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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
            string appxFolder = args[7];
            string tempPath = Path.GetTempPath();
            string illusionTempPath = tempPath + "\\Illusion";
            string currentPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string tilePath = illusionTempPath + "\\Aspiration.tile.png";
            string tileSmallPath = illusionTempPath + "\\Aspiration.tileSmall.png";
            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            string illusionDataPath = appdataPath + "\\Local\\Illusion\\";
            string illusionMenuPath = appdataPath + "\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Illusion\\";
            bool customIco = false;
            string customIcoPath = "";



            if (args.Length == 9)
            {
                tilePath = tileSmallPath = args[8];
            }
            if (args.Length == 10)
            {
                if (args[9] == "-ico")
                {
                    customIco = true;
                    customIcoPath = args[8];
                }
            }
            bool appxMode = false;
            if (appxFolder != "None")
            {
                appxMode = true;
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
            Console.WriteLine(p1.StartInfo.Arguments);//DEBUG
            
            p1.Start();
            p1.WaitForExit();
            p1.Close();
            Thread.Sleep(200);


            string targetExe = targetPath;
            if (targetPath.Contains(".exe "))
            {
                targetExe = targetPath.Substring(0, targetPath.IndexOf(".exe ") + 4);
            }
            string targetArgs = "";
            if (targetPath.Contains(".exe "))
            {
                targetArgs = targetPath.Substring(targetPath.IndexOf(".exe ") + 5);
            }

            p1.StartInfo.FileName = currentPath + "\\HeartInCustody.exe";
            if (appxMode)
                if (customIco)
                    p1.StartInfo.Arguments = $" \"Appx:{appxFolder}\" {r} {g} {b} -ico \"{customIcoPath}\"";
                else
                    p1.StartInfo.Arguments = $" \"Appx:{appxFolder}\" {r} {g} {b}";
            else
                if (customIco)
                    p1.StartInfo.Arguments = $" \"{targetExe}\" {r} {g} {b} -ico \"{customIcoPath}\"";
                else
                    p1.StartInfo.Arguments = $" \"{targetExe}\" {r} {g} {b}";
            Console.WriteLine(p1.StartInfo.Arguments);
            Console.WriteLine(targetArgs);
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

            Thread.Sleep(100);
            p1.StartInfo.FileName = currentPath + "\\Epilogue.exe";
            p1.StartInfo.Arguments = $" \"{illusionMenuPath}{appName}.lnk\"";
            Console.WriteLine($" \"{illusionMenuPath}{appName}.lnk\"");
            p1.Start();
            p1.WaitForExit();
            p1.Close();
            
        }
    }
}
