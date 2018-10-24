using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SoftwareStation
{
    /// <summary>
    /// Interaction logic for NoInternet.xaml
    /// </summary>
    public partial class NoInternet : Page
    {
        private InternetThread inter = new InternetThread();
        private Frame myFrame;

        
        public NoInternet(Frame myFrame)
        {
            ToolLäuft.timer.Stop();
            ScanVorbereitung.timer.Stop();
            ShowsNavigationUI = false;
            this.myFrame = myFrame;
            this.internetThread();
            InitializeComponent();

        }

        public void internetThread()
        {

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    if (inter.checkInternet() == true)
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            
                            myFrame.Content = new Start();

                        });
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No connection yet");

                    }
                    Thread.Sleep(2000);
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }
    }
}
