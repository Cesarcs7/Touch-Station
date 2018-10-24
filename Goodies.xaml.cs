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
    /// Interaction logic for Goodies.xaml
    /// </summary>
    public partial class Goodies : Page
    {
        String goodie1Url = "C://Scann//werbung//goody.png";
        String goodie1Id = "12345";
        private String userVorname;
        public Goodies(String vorname)
        {
            ShowsNavigationUI = false;
            InitializeComponent();
            this.userVorname = vorname;
            profileName.Text = vorname;
            setGoddies();
        }

        public void setGoddies()
        {
            goodie1.Source = new BitmapImage(new Uri(goodie1Url, UriKind.Absolute));
            goodie2.Source = new BitmapImage(new Uri(goodie1Url, UriKind.Absolute));
            goodie3.Source = new BitmapImage(new Uri(goodie1Url, UriKind.Absolute));
            goodie4.Source = new BitmapImage(new Uri(goodie1Url, UriKind.Absolute));
            goodie5.Source = new BitmapImage(new Uri(goodie1Url, UriKind.Absolute));
            goodie6.Source = new BitmapImage(new Uri(goodie1Url, UriKind.Absolute));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Danke nv = new Danke();
            NavigationService.Navigate(nv);
        }

        


        private void goodie1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BuyGoody nv = new BuyGoody(goodie1Url, goodie1Id, userVorname);
            NavigationService.Navigate(nv);
        }

        private void goodie2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BuyGoody nv = new BuyGoody(goodie1Url, goodie1Id, userVorname);
            NavigationService.Navigate(nv);
        }

        private void goodie6_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BuyGoody nv = new BuyGoody(goodie1Url, goodie1Id, userVorname);
            NavigationService.Navigate(nv);
        }

        private void goodie5_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BuyGoody nv = new BuyGoody(goodie1Url, goodie1Id, userVorname);
            NavigationService.Navigate(nv);
        }

        private void goodie4_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BuyGoody nv = new BuyGoody(goodie1Url, goodie1Id, userVorname);
            NavigationService.Navigate(nv);
        }

        private void goodie3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BuyGoody nv = new BuyGoody(goodie1Url, goodie1Id, userVorname);
            NavigationService.Navigate(nv);
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
    }
}
