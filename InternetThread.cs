using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareStation
{
    public class InternetThread
    {
        WebClient client = new WebClient();
        Ping ping = new Ping();
        public bool checkInternet()
        {
            try
            {
                var reply = ping.Send("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
    
