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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SoftwareStation
{
    /// <summary>
    /// Interaction logic for ToolLäuft.xaml
    /// </summary>
    public partial class ToolLäuft : Page
    {
        public static DispatcherTimer timer = new DispatcherTimer();
        private Process detect;
        private String userId;
        private String userEmail;
        private String userName;
        private String userVorname;
        private int counter = 60;

        private List<String> publicities = new List<String>()
        {
            "C:\\Scann\\werbung\\werbung1.mp4",
            "C:\\Scann\\werbung\\werbung2.jpg",
            "C:\\Scann\\werbung\\werbung3.jpg",

        };
     

        public ToolLäuft(String id, String email,String vorname, String name, Process detect)
        {
            ShowsNavigationUI = false;
            this.userName = name;
            this.userEmail = email;
            this.userVorname = vorname;
            this.userId = id;
            this.detect = detect;
            this.InitializeComponent();
            timerSetup();
        }

        public void timerSetup()
        {
            
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += timer_Tick;
            timer.Start();
            loadBar();

        }
        public void timer_Tick(object sender, object e)
        {
            if (counter != 0)
            {
                watch.Text = counter.ToString();
                counter--;
                if(counter == 59 ||
                    counter == 39 ||
                    counter == 19)
                {
                    Console.WriteLine(counter);
                    proofPublicity();
                }
                
            }
            else
            {
                timeEnds();
                
            }

        }

        public void timeEnds()
        {
            timer.Stop();
            navigate();
        }

        public void loadBar()
        {
            Duration duration = new Duration(TimeSpan.FromSeconds(61));
            DoubleAnimation doubleanimation = new DoubleAnimation(100.0, duration);
            bar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
        }

      

        public void proofPublicity()
        {
            if(counter >= 40)
            {
                Scannvideo.Source = new Uri(publicities[0], UriKind.Absolute);
                spot.Text = "SPOT 1";

            }
            else if(counter >= 20 && counter < 40)
            {
                Scannvideo.Visibility = Visibility.Hidden;
                Scannbanner.Source = new BitmapImage(new Uri(publicities[1], UriKind.Absolute));
                spot.Text = "SPOT 2";



            }
            else if(counter < 20)
            {
                Scannbanner.Source = new BitmapImage(new Uri(publicities[2], UriKind.Absolute));
                spot.Text = "SPOT 3";


            }
        }
    
        public void navigate()
        {
            Processing nv = new Processing(userId, userEmail, userVorname, userName, detect);
            NavigationService.Navigate(nv);
        }
    }
}
