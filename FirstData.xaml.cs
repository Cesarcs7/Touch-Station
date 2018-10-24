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
    /// Interaction logic for FirstData.xaml
    /// </summary>
    public partial class FirstData : Page
    {
        String userId;
        String userEmail;
        ValidInputs inp = new ValidInputs();
        PostFirsData post = new PostFirsData();
        GetHandler get = new GetHandler();
        CreateDatabase database;


        public FirstData(String id, String email)
        {
            InitializeComponent();
            this.userId = id;
            this.userEmail = email;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            weiterFD.IsEnabled = false;
            if (string.IsNullOrWhiteSpace(gewicht.Text) ||
                string.IsNullOrWhiteSpace(größe.Text) ||
                (weiblich.IsChecked == false && mänlich.IsChecked == false ))
            {
                weiterFD.IsEnabled = true;
                Error nv = new Error("empty");
                NavigationService.Navigate(nv);
            }
            else if(inp.validate(gewicht.Text) == false ||
                inp.validate(größe.Text) == false)
            {
                weiterFD.IsEnabled = true;
                Error nv = new Error("unvalid");
                NavigationService.Navigate(nv);
            }
            else
            {
                postData();
                navigate();
            }         
        }

       

        public async void postData()
        {
            
            String userGewicht = gewicht.Text;
            String userGröße = größe.Text;
            String userSex;
            if (weiblich.IsChecked == true)
            {
                userSex = "female";
            }
            else
            {
                userSex = "male";
            }
            String userBirthday;
            if (calendar.SelectedDate.HasValue)
            {
                userBirthday = calendar.SelectedDate.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                userBirthday = "default";
            }

            RootObject response = await post.postFirstData("https://polar-bastion-52574.herokuapp.com/api/users/" + userId, userEmail, userBirthday, userGewicht, userSex, userGröße);
            Console.WriteLine("posted");
            RootObjectGet gresponse = await get.get("https://polar-bastion-52574.herokuapp.com/api/users/" + userId);
            Console.WriteLine("makingdb");
            Console.WriteLine(gresponse.name);
            Console.WriteLine(gresponse.vorname);
            Console.WriteLine(gresponse.sex);
            Console.WriteLine(gresponse.birthday);
            Console.WriteLine(gresponse.height);
            Console.WriteLine(gresponse.weight);
            Console.WriteLine(gresponse._id);
            database = new CreateDatabase(gresponse.vorname + " " + gresponse.name, gresponse.sex, gresponse.birthday, gresponse.height, gresponse.weight, gresponse._id);
            database.createDB();
            database.createTables();
            database.insertIntoTables();
            this.userId = response.id;
            this.userEmail = response.email;

        }

        public void navigate()
        {
            weiterFD.IsEnabled = true;

            Einleitungen fd = new Einleitungen(userId);
            NavigationService.Navigate(fd, userId);
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
