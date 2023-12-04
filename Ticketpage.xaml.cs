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
    /// Interaction logic for Ticketpage.xaml
    /// </summary>
    public partial class Ticketpage : Page
    {
        public Ticketpage()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            AirportDBEntities db = new AirportDBEntities();
            Loginpage lp = new Loginpage();
            int z = 0;
            foreach(var i in db.Passengers)
            {
                if (lp.Usernametxtbox.Text == i.Passenger_Username)
                {
                    z = i.Passenger_Id; break;
                }
                break;
            }
            if(SearchNametxtbox.Text == "" && ClassCombox.Text == "A")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 200 || x.Ticket_Price == 180 && x.Passenger_Id == z).ToList();
            }
            else if(SearchNametxtbox.Text == "" && ClassCombox.Text == "B")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 150 || x.Ticket_Price == 120 || x.Ticket_Price == 100 && x.Passenger_Id == z).ToList();
            }
            else if(SearchNametxtbox.Text == "" && ClassCombox.Text == "C")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 80 || x.Ticket_Price == 50 && x.Passenger_Id == z).ToList();
            }
            else if(SearchNametxtbox.Text != "" && ClassCombox.Text == "A")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 200 || x.Ticket_Price == 180 && x.Passenger_Name.Contains(SearchNametxtbox.Text) && x.Passenger_Id == z).ToList();
            }
            else if (SearchNametxtbox.Text != "" && ClassCombox.Text == "B")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 150 || x.Ticket_Price == 120 || x.Ticket_Price == 100 && x.Passenger_Name.Contains(SearchNametxtbox.Text) && x.Passenger_Id == z).ToList();
            }
            else if (SearchNametxtbox.Text != "" && ClassCombox.Text == "C")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 80 || x.Ticket_Price == 50 && x.Passenger_Name.Contains(SearchNametxtbox.Text) && x.Passenger_Id == z).ToList();
            }
            else if(SearchNametxtbox.Text != "" && ClassCombox.Text == "")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Passenger_Name.Contains(SearchNametxtbox.Text) && x.Passenger_Id == z).ToList();
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }

        private void ToreserveTicketButton_Click(object sender, RoutedEventArgs e)
        {
            BuyTicketpage btp = new BuyTicketpage();
            NavigationService.Navigate(btp);
        }
    }
}
