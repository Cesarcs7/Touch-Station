using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InternetThread inter = new InternetThread();

        public MainWindow()
        {
            InitializeComponent();
            this.internetThread();
            myFrame.Content = new Start();
        }

  
        
        public void internetThread()
        {

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    if (inter.checkInternet() == true)
                    {
                        Console.WriteLine("connected");
                    }
                    else
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            Console.WriteLine("Disconnected");
                            myFrame.Content = new NoInternet(myFrame);

                        });
                        
                    }
                    Thread.Sleep(2000);
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //KillExplorer();
        }

        void KillExplorer()
        {
            // Create a ProcessStartInfo, otherwise Explorer comes back to haunt you.
            ProcessStartInfo TaskKillPSI = new ProcessStartInfo("taskkill", "/F /IM explorer.exe");
            // Don't show a window
            TaskKillPSI.WindowStyle = ProcessWindowStyle.Hidden;
            // Create and start the process, then wait for it to exit.
            Process process = new Process();
            process.StartInfo = TaskKillPSI;
            process.Start();
            process.WaitForExit();
        }
    }
}
