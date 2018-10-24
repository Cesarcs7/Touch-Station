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
    /// Interaction logic for Einleitungen.xaml
    /// </summary>
    public partial class Einleitungen : Page
    {
        RootObjectGet response;
        GetHandler get = new GetHandler();
        String userId;
        StartDetect detect;

        public Einleitungen(String userId)
        {
            ShowsNavigationUI = false;
            this.userId = userId;
            InitializeComponent();
         
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            detect = new StartDetect();
            this.response = await getData();
            navigate();
        }

        public async Task<RootObjectGet> getData()
        {
            RootObjectGet response = await get.get("https://polar-bastion-52574.herokuapp.com/api/users/" + userId);
            return response;
        }


        public void navigate()
        {
            ScanVorbereitung nav = new ScanVorbereitung(userId, response.email, response.vorname, response.name, detect.getProcess());
            NavigationService.Navigate(nav);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                Start nv = new Start();
                NavigationService.Navigate(nv);
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
    }
}
