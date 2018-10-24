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
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Page
    {
        String userId;
        String userEmail;
        String userVorname;
        ValidInputs inp = new ValidInputs();
        PostData post = new PostData();
        GetHandler get = new GetHandler();
        CreateDatabase database;
        

        public Data(String id, String email, String vorname)
        {
            ShowsNavigationUI = false;
           
            InitializeComponent();
            this.userEmail = email;
            this.userId = id;
            this.userVorname = vorname;
            vornameText.Text = vorname;
        }

        
        public async void postData()
        {
            
            RootObject response = await post.postData("https://polar-bastion-52574.herokuapp.com/api/users/" + userId+"/put", userEmail, loggedGewicht.Text, loggedGröße.Text);
        }

        public async void makeDataBase()
        {
            RootObjectGet response = await get.get("https://polar-bastion-52574.herokuapp.com/api/users/" + userId);
           
            
            database = new CreateDatabase(response.vorname + " " + response.name, response.sex, response.birthday, response.weight, response.height, response._id);
            database.createDB();
            database.createTables();
            database.insertIntoTables();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            weiterD.IsEnabled = false;
            if (string.IsNullOrWhiteSpace(loggedGewicht.Text) ||
                string.IsNullOrWhiteSpace(loggedGröße.Text))
            {
                weiterD.IsEnabled = true;
                Error nv = new Error("empty");
                NavigationService.Navigate(nv);
            }
            else if (inp.validate(loggedGewicht.Text) == false ||
                inp.validate(loggedGröße.Text) == false)
            {
                weiterD.IsEnabled = true;
                Error nv = new Error("unvalid");
                NavigationService.Navigate(nv);
            }
            else
            {
                postData();
                makeDataBase();
                navigate();
            }
          
        }

        public void navigate()
        {
            weiterD.IsEnabled = true;

            Einleitungen fd = new Einleitungen(userId);
            NavigationService.Navigate(fd, userId);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }

        private void Image_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Start nv = new Start();
            NavigationService.Navigate(nv);
        }
    }
}
