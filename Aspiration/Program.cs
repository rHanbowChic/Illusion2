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
            if (File.Exists(currentPath + "\\Aspiration.lnk"))
                Process.Start("explorer.exe", " " + currentPath + "\\Aspiration.lnk");
            else
                MessageBox.Show("Aspiration.lnk is missing");

            //KeeP iT sImpLe aNd StUPid

        }
    }
}
