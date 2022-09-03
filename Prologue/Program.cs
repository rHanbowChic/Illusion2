using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shell32;

namespace Prologue
{
    class Program
        
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Prologue:Program Generator\r\nPrologue targetPath appName");
                return;
            }
            string currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string targetPath = args[0];
            string appName = args[1];
            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            string illusionDataPath = appdataPath + "\\Local\\Illusion\\";
            string startmenuPath = appdataPath + "\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs";
            string illusionMenuPath = startmenuPath + "\\Illusion\\";
            string aspiraCfg = targetPath;

            if (!Directory.Exists(illusionDataPath))
                Directory.CreateDirectory(illusionDataPath);
            if (!Directory.Exists(illusionDataPath + appName))
                Directory.CreateDirectory(illusionDataPath + appName);
            if (File.Exists(illusionDataPath + appName + "\\Aspiration.exe"))
                File.Delete(illusionDataPath + appName + "\\Aspiration.exe");
            File.Copy(currentPath + "\\Aspiration.exe", illusionDataPath + appName + "\\Aspiration.exe");

            File.WriteAllText(illusionDataPath + appName + "\\Aspiration.cfg", aspiraCfg);

            if (!Directory.Exists(illusionMenuPath))
                Directory.CreateDirectory(illusionMenuPath);
            File.WriteAllBytes(illusionMenuPath + appName + ".lnk", new byte[0]);
            Shell shl = new Shell();
            Folder fdr = shl.NameSpace(illusionMenuPath);
            FolderItem itm = fdr.Items().Item(appName + ".lnk");
            ShellLinkObject lnkobj = (ShellLinkObject)itm.GetLink;
            lnkobj.Path = illusionDataPath + appName + "\\Aspiration.exe";
            lnkobj.WorkingDirectory = illusionDataPath + appName;
            lnkobj.Save();
        }
    }
}
