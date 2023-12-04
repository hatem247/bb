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

namespace AirportMS
{
    /// <summary>
    /// Interaction logic for Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Page
    {
        AirportDBEntities db = new AirportDBEntities();
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            if(UsertypeComBox.Text == "Passenger")
            {
                foreach(var x in db.Passengers)
                {
                    if(Usernametxtbox.Text == x.Passenger_Username && Passwordtxtbox.Text == x.Passenger_Password)
                    {
                        Ticketpage tp = new Ticketpage();
                        NavigationService.Navigate(tp);
                    }
                    else if(Usernametxtbox.Text != x.Passenger_Username || Passwordtxtbox.Text != x.Passenger_Password)
                    {
                        MessageBox.Show("Username or Password is Wrong :(");
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong :(");
                    }
                    break;
                }
            }
            else if(UsertypeComBox.Text == "Admin")
            {
                foreach (var x in db.Staffs)
                {
                    if (Usernametxtbox.Text == x.Staff_Username && Passwordtxtbox.Text == x.Staff_Password)
                    {
                        Ticketpage tp = new Ticketpage();
                        NavigationService.Navigate(tp);
                    }
                    else if (Usernametxtbox.Text != x.Staff_Username || Passwordtxtbox.Text != x.Staff_Password)
                    {
                        MessageBox.Show("Username or Password is Wrong :(");
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong :(");
                    }
                    break;
                }
            }
            else if(UsertypeComBox.Text == "")
            {
                MessageBox.Show("Please choose the user type Firstlly :)");
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }

        private void CreateAccountbtn_Click(object sender, RoutedEventArgs e)
        {
            if(UsertypeComBox.Text == "Passenger")
            {
                Singuppage sup = new Singuppage();
                NavigationService.Navigate(sup);
            }
            else if(UsertypeComBox.Text == "Admin")
            {
                AdminSignuppage asup = new AdminSignuppage();
                NavigationService.Navigate(asup);
            }
            else if(UsertypeComBox.Text == "")
            {
                MessageBox.Show("Please choose the user type firstlly :)");
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }
    }
}
