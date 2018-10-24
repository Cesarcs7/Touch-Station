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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        private String userVorname;
        public Result(String result, String title, String vorname)
        {
            ShowsNavigationUI = false;
            InitializeComponent();
            this.userVorname = vorname;
            profileName.Text = vorname;
            date.Text = DateTime.Today.ToString("d");
            time.Text = DateTime.Now.ToString("h:mm:ss");
            post(result, title);
            
        }

        public void post(String result, String title)
        {
            if (title == "Athlet")
            {
                desciptionText.Text = "GLÜCKWUNSCH";
                desciptionSpan.Text = "DU BIST IN TOPFORM";
                statusImg.Source = new BitmapImage (new Uri("Resources/athlet.jpg",UriKind.Relative));
            }else if( title == "Active")
            {
                desciptionText.Text = "DA GIBT NOCH WAS";
                desciptionSpan.Text = "DU BIST NAH DRAN";
                statusImg.Source = new BitmapImage(new Uri("Resources/active.png", UriKind.Relative));

            }
            else if (title == "Starter")
            {
                desciptionText.Text = "LASS KNACKEN AUF";
                desciptionSpan.Text = "DU SOLLST WAS TUN";
                statusImg.Source = new BitmapImage(new Uri("Resources/starterMan.jpg", UriKind.Relative));

            }

            resultLabel.Text = result;
            titleLabel.Text = title.ToUpper();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Goodies nv = new Goodies(userVorname);
            NavigationService.Navigate(nv);
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
    }
}
