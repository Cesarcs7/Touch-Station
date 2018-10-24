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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        private String userId;
        private String userEmail;
        PostRegister post = new PostRegister();
        private int nameE;
        private int vornameE;
        private int passwordBE;
        private int passwordE;
        private int emailE;


        public Register()
        {
            ShowsNavigationUI = false;
            InitializeComponent();
            weiterReg.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            weiterReg.IsEnabled = false;
            if (string.IsNullOrWhiteSpace(name.Text) ||
                (nameE == 0) ||
                string.IsNullOrWhiteSpace(vorname.Text) ||
                (vornameE == 0) ||
                string.IsNullOrWhiteSpace(passwordB.Text) ||
                (passwordBE == 0) ||
                string.IsNullOrWhiteSpace(password.Text) ||
                (passwordE == 0) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                (emailE == 0))
            {
                weiterReg.IsEnabled = true;
                Error nv = new Error("empty");
                NavigationService.Navigate(nv);
            }else if(passwordB.Text != password.Text)
            {
                weiterReg.IsEnabled = true;
                Error nv = new Error("noMatch");
                NavigationService.Navigate(nv);
            }
            else
            {
                postRegister();
            }            
        }

        public async void postRegister()
        {
            String userName = name.Text;
            String userVorname = vorname.Text;
            String userEmail = email.Text;
            String userPassword = password.Text;

            RootObject response = await post.postRegister("https://polar-bastion-52574.herokuapp.com/api/auth/signup", userName, userVorname, userEmail, userPassword);
            if (response.id == null)
            {
                Error nv = new Error("duplicated");
                NavigationService.Navigate(nv);
            }
            else
            {
                this.userId = response.id;
                this.userEmail = response.email;

                navigate();
            }
        }

        public void navigate()
        {
            weiterReg.IsEnabled = true;
            FirstData fd = new FirstData(userId, userEmail);
            NavigationService.Navigate(fd, userId);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            nameE++;
        }

        private void vorname_GotFocus(object sender, RoutedEventArgs e)
        {
            vorname.Text = "";
            vornameE++;
        }

        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            email.Text = "";
            emailE++;
        }

        private void password_GotFocus(object sender, RoutedEventArgs e)
        {
            password.Text = "";
            passwordE++;
        }

        private void passwordB_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordB.Text = "";
            passwordBE++;
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
    }
}
