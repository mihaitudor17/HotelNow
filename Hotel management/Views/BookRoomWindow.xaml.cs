using Hotel_management.Models.Business_Logic_Layer;
using Hotel_management.Viewmodels;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for BookRoomWindow.xaml
    /// </summary>
    public partial class BookRoomWindow : Window
    {
        public BookRoomWindow(Room room, long user_id, Offer offer)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            DataContext = new BookRoomVM(room, offer);
            var dc = DataContext as BookRoomVM;
            dc.User_id = user_id;
            if (offer == null)
            {
                dc.Offer = new Offer()
                {
                    name = "",
                    price_reduction = 0
                };
            }
            else
            {
                dc.Offer = offer;
                dc.Date = offer.start_date;
                Calendar.Visibility = Visibility.Hidden;
                DaysLabel.Visibility = Visibility.Hidden;
                DaysTextBox.Visibility = Visibility.Hidden;
                OfferPanel.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dc = (DataContext as BookRoomVM);
            int nr;
            if (int.TryParse(dc.NumberOfDays, out nr))
            {
                bool isVacant = true;
                for (int i = 0; i < nr; i++)
                {
                    var result = dc.Dates.FirstOrDefault(x =>
                    DateTime.Compare(x, dc.Date.AddDays(i)) == 0
                    );
                    if (result.Year != 1)
                    {
                        MessageBox.Show(dc.Date.AddDays(i).ToString() + " is already booked");
                        isVacant = false;
                        break;
                    }
                }
                if (isVacant)
                {
                    RoomBLL roomBLL = new RoomBLL();
                    for (int i = 0; i < nr; i++)
                    {
                        roomBLL.BookARoom(dc.CurrentRoom.id, dc.User_id, dc.Date.AddDays(i));
                    }
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a number!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as BookRoomVM;
            if (dc.Features.Count > 0)
            {
                var feature = dc.Features.First(x => x == dc.SelectedFeature);
                dc.FinalPrice += feature.Item2;
                dc.Features.Remove(feature);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as BookRoomVM;
            OffersView offersView = new OffersView(dc.CurrentRoom, dc.User_id);
            offersView.Show();
            Close();
        }
    }
}
