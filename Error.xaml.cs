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
    /// Interaction logic for Error.xaml
    /// </summary>
    public partial class Error : Page
    {
        public Error(String error)
        {
            ShowsNavigationUI = false;
            InitializeComponent();
            showError(error);
        }

        public void showError(String error)
        {
            switch (error)
            {
                case "login":
                    errorText.Text = "Falsches email oder Passwort";
                    break;
                case "duplicated":
                    errorText.Text = "Ein Konto mit diesem Email exsistiert schon";
                    break;
                case "empty":
                    errorText.Text = "Alle Felder müssen ausgefüllt werden";
                    break;
                case "noMatch":
                    errorText.Text = "Passwort Bestätigung ist falsch";
                    break;
                case "unvalid":
                    errorText.Text = "bitte geben sie einen gültigen wert ein";
                    break;
            }

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
    }
}
