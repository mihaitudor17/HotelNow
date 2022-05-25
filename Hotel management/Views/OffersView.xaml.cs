using Hotel_management.Viewmodels;
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
using System.Windows.Shapes;

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for OffersView.xaml
    /// </summary>
    public partial class OffersView : Window
    {
        public OffersView(Room room, long user_id)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            var dc = DataContext as OffersVM;
            dc.CurrentRoom = room;
            dc.User_id = user_id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as OffersVM;
            BookRoomWindow bookRoomWindow = new BookRoomWindow(dc.CurrentRoom, dc.User_id, dc.SelectedOffer);
            bookRoomWindow.Show();
            Close();
        }
    }
}
