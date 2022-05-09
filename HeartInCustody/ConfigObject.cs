using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartInCustody
{

    public class ConfigObject
    {
        public int sleepTime { get; set; }
        public bool isWindows8 { get; set; }
        public bool useCustomPython { get; set; }
        public string customPythonExePath { get; set; }
        public int imgOffsetValue { get; set; } = 0;
    }

}
