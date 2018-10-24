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
    /// Interaction logic for BuyGoody.xaml
    /// </summary>
    public partial class BuyGoody : Page
    {
        private String goodieUrl;
        private String goodieId;

        public BuyGoody(String goodieUrl, String goodieId, String vorname)
        {
            ShowsNavigationUI = false;
            this.goodieId = goodieId;
            this.goodieUrl = goodieUrl;
            InitializeComponent();
            profileName.Text = vorname;
            theGoody.Source = new BitmapImage(new Uri(goodieUrl, UriKind.Absolute));
        }

        private void Button_Click_kaufen(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(goodieId);
            navigate();
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

        public void navigate()
        {
            Danke nv = new Danke();
            NavigationService.Navigate(nv);
        }
    }
}
