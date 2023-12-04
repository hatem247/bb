using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ResetPasswordpage.xaml
    /// </summary>
    public partial class ResetPasswordpage : Page
    {
        AirportDBEntities db = new AirportDBEntities();
        ForgetPasswordpage fpp = new ForgetPasswordpage();
        Loginpage lp = new Loginpage();
        public ResetPasswordpage()
        {
            InitializeComponent();
        }

        private void Confrimbtn_Click(object sender, RoutedEventArgs e)
        {
            if(fpp.UsertypeComBox.Text == "Passenger")
            {
                foreach(var x in db.Passengers)
                {
                    if(fpp.Usernametxtbox.Text == x.Passenger_Username)
                    {
                        if(Confirmtxtbox.Text == Passwordtxtbox.Text)
                        {
                            x.Passenger_Password = Passwordtxtbox.Text;
                            db.Passengers.AddOrUpdate(x);
                            db.SaveChanges();
                            MessageBox.Show("Password Reset Successfully :)");
                            NavigationService.Navigate(lp);
                        }
                        else if(Confirmtxtbox.Text != Passwordtxtbox.Text)
                        {
                            MessageBox.Show("Password not Matching");
                        }
                        else
                        {
                            MessageBox.Show("Something is wrong :(");
                        }
                    }
                    break;
                }
            }
            else if (fpp.UsertypeComBox.Text == "Admin")
            {
                foreach (var x in db.Staffs)
                {
                    if (fpp.Usernametxtbox.Text == x.Staff_Username)
                    {
                        if (Confirmtxtbox.Text == Passwordtxtbox.Text)
                        {
                            x.Staff_Password = Passwordtxtbox.Text;
                            db.Staffs.AddOrUpdate(x);
                            db.SaveChanges();
                            MessageBox.Show("Password Reset Successfully :)");
                            NavigationService.Navigate(lp);
                        }
                        else if (Confirmtxtbox.Text != Passwordtxtbox.Text)
                        {
                            MessageBox.Show("Password not Matching");
                        }
                        else
                        {
                            MessageBox.Show("Something is wrong :(");
                        }
                    }
                    break;
                }
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }
    }
}
