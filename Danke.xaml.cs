using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SoftwareStation
{
    /// <summary>
    /// Interaction logic for Danke.xaml
    /// </summary>
    public partial class Danke : Page
    {
        private DispatcherTimer timer = new DispatcherTimer();

        public Danke()
        {
            ShowsNavigationUI = false;
            InitializeComponent();
            timerSetup();
        }

        public void timerSetup()
        {

            timer.Interval = new TimeSpan(0, 0, 10);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void timer_Tick(object sender, object e)
        {
            timer.Stop();
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
       
    }
}
