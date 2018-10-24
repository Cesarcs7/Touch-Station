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
    /// Interaction logic for Processing.xaml
    /// </summary>
    public partial class Processing : Page
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private float result;
        private Process detect;
        private String userId;
        private String userEmail;
        private String userName;
        private String userVorname;


        public Processing(String id, String email, String vorname, String name, Process detect)
        {
            ShowsNavigationUI = false;
            this.userName = name;
            this.userEmail = email;
            this.userId = id;
            this.userVorname = vorname;
            this.detect = detect;
            InitializeComponent();
            profileName.Text = vorname;
            timerSetup();              
        }

        public void timerSetup()
        {

            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public void waitReport()
        {
            while (!detect.HasExited)
            {
                detect.Refresh();
            }


            readReport();

        }

      

        public void timer_Tick(object sender, object e)
        {
            timer.Stop();
            waitReport();
           
        }


            public async void readReport()
        {
            ReportReader report = new ReportReader();
            report.read();
            result = report.getSum();
            PostResult post = new PostResult();
            RootObject response = await post.postResult("https://polar-bastion-52574.herokuapp.com/api/users/" + userId + "/result", userEmail, result.ToString());
            navigateConditions(result);
        }

        public void navigateConditions(float result)
        {
            Result nv;
            if (result >= 85)
            {
                String title = "Athlet";
                nv = new Result(result.ToString(), title, userVorname);
                NavigationService.Navigate(nv);

            }
            if (result < 85 && result >= 51)
            {
                String title = "Active";
                nv = new Result(result.ToString(), title, userVorname);
                NavigationService.Navigate(nv);

            }
            if (result < 51)
            {
                String title = "Starter";
                nv = new Result(result.ToString(), title, userVorname);
                NavigationService.Navigate(nv);

            }
        }
    }
}
