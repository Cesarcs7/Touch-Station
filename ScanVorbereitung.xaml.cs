using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for ScanVorbereitung.xaml
    /// </summary>
    public partial class ScanVorbereitung : Page
    {
        public static DispatcherTimer timer = new DispatcherTimer();
        private Process detect;
        private String userId;
        private String userEmail;
        private String userName;
        private String userVorname;
        


        public ScanVorbereitung(String id, String email, String vorname, String name, Process detect)
        {
            ShowsNavigationUI = false;
            this.userName = name;
            this.userEmail = email;
            this.userVorname = vorname;
            this.userId = id;
            this.detect = detect;
            InitializeComponent();
            timerSetup();
        }

        public void timerSetup()
        {

            timer.Interval = new TimeSpan(0, 0, 15);
            timer.Tick += timer_Tick;
            timer.Start();
           
        }

        public void timer_Tick(object sender, object e)
        {
            timer.Stop();
            navigate();
        }

        public void navigate()
        {
            ToolLäuft nav = new ToolLäuft(userId, userEmail, userVorname, userName, detect);
            NavigationService.Navigate(nav);
        }

    }
}
