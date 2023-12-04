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
    /// Interaction logic for Singuppage.xaml
    /// </summary>
    public partial class Singuppage : Page
    {
        AirportDBEntities db = new AirportDBEntities();
        Passenger pr = new Passenger();
        public Singuppage()
        {
            InitializeComponent();
        }

        private void Signupbtn_Click(object sender, RoutedEventArgs e)
        {
            TextBox tx = new TextBox();
            if (tx.Text == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else if(tx.Text != null)
            {
                pr.Passenger_Name = Nametxtbox.Text;
                pr.Passenger_Gender = Gendertxtbox.Text;
                pr.Passenger_Phone_Number = int.Parse(PhoneNumbertxtbox.Text);
                pr.Passenger_Nickname = Nicknametxtbox.Text;
                pr.Passenger_Age = int.Parse(Agetxtbox.Text);
                pr.Passenger_Passport = PassportNumbertxtbox.Text;
                pr.Passenger_Password = Passwordtxtbox.Text;
                pr.Passenger_Username = Usernametxtbox.Text;
                db.Passengers.Add(pr);
                db.SaveChanges();
                MessageBox.Show("Account Created Successfully :)");
                Loginpage lp = new Loginpage();
                NavigationService.Navigate(lp);
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }
    }
}
