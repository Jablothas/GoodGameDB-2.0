using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GoodGameDB
{
    internal class Logfile
    {
        string timestemp = "" + DateTime.Now;
        public static void Create(string report)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[" + DateTime.Now + "]" + report + "\n");
            File.AppendAllText(@"C:\temp\log.txt", sb.ToString());
            sb.Clear();
        }
    }
}
