using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    class StartDetect
    {
        private Process p = new Process();
        
        public StartDetect()
        {
            startProcess();
        }

        public void startProcess()
        {
            
            p.StartInfo = new ProcessStartInfo("C:\\Scann\\Detect.exe", " 1 2000 2000 1");
            p.StartInfo.CreateNoWindow = true;
            p.Start();
           
        }

        public Process getProcess()
        {
            return this.p;
        }
    }
}
