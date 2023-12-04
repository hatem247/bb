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
    /// Interaction logic for Homepage.xaml
    /// </summary>
    public partial class Homepage : Page
    {
        AirportDBEntities db = new AirportDBEntities();
        Passenger pr = new Passenger();
        public Homepage()
        {
            InitializeComponent();
        }
        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            AirportDBEntities db = new AirportDBEntities();
            if (SearchNametxtbox.Text == "" && ClassCombox.Text == "A")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 200 || x.Ticket_Price == 180).ToList();
            }
            else if (SearchNametxtbox.Text == "" && ClassCombox.Text == "B")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 150 || x.Ticket_Price == 120 || x.Ticket_Price == 100).ToList();
            }
            else if (SearchNametxtbox.Text == "" && ClassCombox.Text == "C")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 80 || x.Ticket_Price == 50).ToList();
            }
            else if (SearchNametxtbox.Text != "" && ClassCombox.Text == "A")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 200 || x.Ticket_Price == 180 && x.Passenger_Name.Contains(SearchNametxtbox.Text)).ToList();
            }
            else if (SearchNametxtbox.Text != "" && ClassCombox.Text == "B")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 150 || x.Ticket_Price == 120 || x.Ticket_Price == 100 && x.Passenger_Name.Contains(SearchNametxtbox.Text)).ToList();
            }
            else if (SearchNametxtbox.Text != "" && ClassCombox.Text == "C")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Ticket_Price == 80 || x.Ticket_Price == 50 && x.Passenger_Name.Contains(SearchNametxtbox.Text)).ToList();
            }
            else if (SearchNametxtbox.Text != "" && ClassCombox.Text == "")
            {
                Dataview.ItemsSource = db.Tickets.Where(x => x.Passenger_Name.Contains(SearchNametxtbox.Text)).ToList();
            }
            else
            {
                MessageBox.Show("Something is wrong :(");
            }
        }
    }
}
