using Hotel_management.Models.Business_Logic_Layer;
using Hotel_management.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for BookedRoomsView.xaml
    /// </summary>
    public partial class BookedRoomsView : Window
    {
        public BookedRoomsView(long user_id)
        {
            InitializeComponent();
            DataContext = new BookedRoomsVM(user_id);
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as BookedRoomsVM).HighlightedBooking = (sender as ListBox).SelectedItem as Tuple<long, DateTime,DateTime, string>;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookingBLL bookingBLL = new BookingBLL();
            var dc = DataContext as BookedRoomsVM;
            bookingBLL.ModifyBooking(new Booking()
            {
                id = 0,
                room_id = dc.HighlightedBooking.Item1,
                date = dc.HighlightedBooking.Item3,
                user_id = dc.CurrentUserId,
                state = "canceled",
                deleted = false
            }); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
