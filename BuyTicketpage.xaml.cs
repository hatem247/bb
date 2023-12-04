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
    /// Interaction logic for BuyTicketpage.xaml
    /// </summary>
    public partial class BuyTicketpage : Page
    {
        AirportDBEntities db = new AirportDBEntities();
        Ticket t = new Ticket();
        TextBox tb = new TextBox();
        Loginpage lp = new Loginpage();
        public BuyTicketpage()
        {
            InitializeComponent();
        }

        private void Confirmbtn_Click(object sender, RoutedEventArgs e)
        {   
            int x = 0;
            foreach (var y in db.Passengers)
            {
                if(lp.Usernametxtbox.Text == y.Passenger_Username)
                {
                    x = y.Passenger_Id;
                }
                else
                {
                    MessageBox.Show("Something is wrong :(");
                }
                break;
            }
            if(tb.Text != null)
            {
                t.Passenger_Name = PassengerNametxtbox.Text;
                t.Ticket_Status = "Confirmed";
                foreach(var c in db.Tickets)
                {
                    if(Convert.ToInt32(SeatNumbertxtbox.Text) != c.Seat_Number)
                    {
                        t.Seat_Number = int.Parse(SeatNumbertxtbox.Text);
                    }
                    else if(Convert.ToInt32(SeatNumbertxtbox.Text) == c.Seat_Number)
                    {
                        MessageBox.Show("There is another passenger in the same seat :)");
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong :(");
                    }
                }
                t.Passenger_Id = x;
                t.Ticket_Price = int.Parse(TicketPriceCompobox.Text);
                db.Tickets.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ticket Registered successfully :)");
                Ticketpage tp = new Ticketpage();
                NavigationService.Navigate(tp);
            }
            else if(tb.Text == null)
            {
                MessageBox.Show("Please fill all fields :)");
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var c in db.Tickets)
            {
                if (Convert.ToInt32(SeatNumbertxtbox.Text) == c.Seat_Number)
                {
                    t.Ticket_Status = "Cancelled";
                    db.Tickets.AddOrUpdate(t);
                    db.SaveChanges();
                    MessageBox.Show("Cancelled :)");
                }
                else if (Convert.ToInt32(SeatNumbertxtbox.Text) != c.Seat_Number)
                {
                    MessageBox.Show("There is no ticket registered in this seat :)");
                }
                else
                {
                    MessageBox.Show("Something is wrong :(");
                }
            }
        }
    }
}
