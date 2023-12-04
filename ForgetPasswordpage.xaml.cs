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
    /// Interaction logic for ForgetPasswordpage.xaml
    /// </summary>
    public partial class ForgetPasswordpage : Page
    {
        AirportDBEntities db = new AirportDBEntities();
        public ForgetPasswordpage()
        {
            InitializeComponent();
        }

        private void SumbitNicknamebtn_Click(object sender, RoutedEventArgs e)
        {
            if (UsertypeComBox.Text == "Passenger")
            {
                foreach (var x in db.Passengers)
                {
                    if (Usernametxtbox.Text == x.Passenger_Username && Nicknametxtbox.Text == x.Passenger_Nickname)
                    {
                        ResetPasswordpage rpp = new ResetPasswordpage();
                        NavigationService.Navigate(rpp);
                    }
                    else if (Usernametxtbox.Text != x.Passenger_Username || Nicknametxtbox.Text != x.Passenger_Nickname)
                    {
                        MessageBox.Show("Username or Nickname is Wrong :(");
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong :(");
                    }
                    break;
                }
            }
            else if (UsertypeComBox.Text == "Admin")
            {
                foreach (var x in db.Staffs)
                {
                    if (Usernametxtbox.Text == x.Staff_Username && Nicknametxtbox.Text == x.Staff_Nickname)
                    {
                        ResetPasswordpage rpp = new ResetPasswordpage();
                        NavigationService.Navigate(rpp);
                    }
                    else if (Usernametxtbox.Text != x.Staff_Username || Nicknametxtbox.Text != x.Staff_Nickname)
                    {
                        MessageBox.Show("Username or Nickname is Wrong :(");
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong :(");
                    }
                    break;
                }
            }
            else if (UsertypeComBox.Text == "")
            {
                MessageBox.Show("Please choose the user type Firstlly :)");
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
