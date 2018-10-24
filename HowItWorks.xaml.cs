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

namespace SoftwareStation
{
    /// <summary>
    /// Interaction logic for HowItWorks.xaml
    /// </summary>
    public partial class HowItWorks : Page
    {
        public HowItWorks()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
            else
            {
                Start nv = new Start();
                NavigationService.Navigate(nv);
            }
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
    }
}
