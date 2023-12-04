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
    /// Interaction logic for AdminSignuppage.xaml
    /// </summary>
    public partial class AdminSignuppage : Page
    {
        AirportDBEntities db = new AirportDBEntities();
        Staff sf = new Staff();
        public AdminSignuppage()
        {
            InitializeComponent();
        }

        private void Signupbtn_Click(object sender, RoutedEventArgs e)
        {
            TextBox tx = new TextBox();
            if(tx.Text == null)
            {
                MessageBox.Show("Please fill all fields");
            }
            else if(tx.Text != null)
            {
                sf.Staff_Position = Positionxtbox.Text;
                sf.Staff_Name = Nametxtbox.Text;
                sf.Staff_Username = Usernametxtbox.Text;
                sf.Staff_Password = Passwordtxtbox.Text;
                sf.Staff_Phone_Number = int.Parse(PhoneNumbertxtbox.Text);
                sf.Staff_Nickname = Nicknametxtbox.Text;
                db.Staffs.Add(sf);
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
