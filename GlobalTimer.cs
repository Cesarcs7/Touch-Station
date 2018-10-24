using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SoftwareStation
{
    public static class GlobalTimer
    {
        public static DispatcherTimer timer = new DispatcherTimer();
        public static Boolean finished = false;
        public static int counter;

        public static void timerSetup(int span)
        {

            timer.Interval = new TimeSpan(0, 0, span);
            timer.Tick += tic;
            timer.Start();

        }

        static void tic(object sender, object e)
        {
            Console.WriteLine("hee");
            counter--;
            Console.WriteLine(counter);
        }
    }
}
