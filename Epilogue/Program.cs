using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Epilogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string illusionTempPath = Path.GetTempPath() + "\\Illusion";
            string appdataPath = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            string illusionRoamingPath = appdataPath + "\\Roaming\\illusion";
            if (!Directory.Exists(illusionRoamingPath))
            {
                Directory.CreateDirectory(illusionRoamingPath);
            }
            if (!Directory.Exists(illusionTempPath))
            {
                Directory.CreateDirectory(illusionTempPath);
            }
            string applicationBase = illusionRoamingPath ;
            if (!File.Exists(applicationBase + "\\Illusion.json"))
            {
                File.WriteAllText(applicationBase + "\\Illusion.json", "{\"isWindows8\": false,\"sleepTime\": 5000}");
            }
            string configText = File.ReadAllText(applicationBase + "\\Illusion.json");
            ConfigObject config = JsonConvert.DeserializeObject<ConfigObject>(configText);
            int sleepTime = config.sleepTime;


            Random rd = new Random();
            int SessionID = rd.Next(1, 2147483647);

            if (!File.Exists(illusionTempPath + string.Format("\\{0}.working.lock", (object)SessionID)))
                File.Create(illusionTempPath + string.Format("\\{0}.working.lock", (object)SessionID)).Close();


            string str = Path.GetFileName(args[0]);
            File.Copy(args[0], illusionTempPath+ "\\"+str);
            File.Delete(args[0]);
            Thread.Sleep(sleepTime);
            File.Copy(illusionTempPath+str, args[0]);
            File.Delete(illusionTempPath+"\\"+str);


            if (File.Exists(illusionTempPath + string.Format("\\{0}.working.lock", (object)SessionID)))
                File.Delete(illusionTempPath + string.Format("\\{0}.working.lock", (object)SessionID));
        }
    }
}
