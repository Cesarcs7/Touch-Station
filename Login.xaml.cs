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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private String userId;
        private String userEmail;
        private String userVorname;
        private PostLogin post = new PostLogin();
        private Deserializer serializer = new Deserializer();
        private int emailE = 0;
        private int passwordE = 0;

        public Login()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            weiterLog.IsEnabled = false;
            postLogin();
        }

        public async void postLogin()
        {
            String userEmail = emailLogin.Text;
            String userPassword = passwordLogin.Text;

            RootObject response = await post.postLogin("https://polar-bastion-52574.herokuapp.com/api/auth/signin", userEmail, userPassword);
            if(emailE == 0 || passwordE == 0)
            {
                Error nv = new Error("empty");
                NavigationService.Navigate(nv);

            }else if (response.id == null )
            {
                Error nv = new Error("login");
                NavigationService.Navigate(nv);
            }
            else
            {
                Console.WriteLine(response.id);
                Console.WriteLine(response.email);
                this.userVorname = response.vorname;
                this.userId = response.id;
                this.userEmail = response.email;
                navigate();
            }



        }
        public void navigate()
        {
            weiterLog.IsEnabled = true;
            Console.WriteLine("passing" + userEmail + " " + userId+" "+userVorname);
            Data d = new Data(userId, userEmail, userVorname);
            NavigationService.Navigate(d, userId);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void emailLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            emailLogin.Text = "";
            emailE++;
        }

        private void passwordLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordLogin.Text = "";
            passwordE++;
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
    }
}
