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
    /// Interaction logic for BrowseRooms.xaml
    /// </summary>
    public partial class BrowseRooms : Window
    {
        public BrowseRooms(User currentUser)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            (DataContext as BrowseRoomsVM).CurrentUser = new User()
            {
                id = currentUser.id,
                name = currentUser.name,
                password = currentUser.password,
                type = currentUser.type,
                deleted = currentUser.deleted,
            };
            if (currentUser.type == "Admin")
            {
                EditButton.Visibility = Visibility.Visible;
            }
            if (currentUser.type == "Guest")
            {
                BookButton.Visibility = Visibility.Hidden;
                BookedButton.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((DataContext as BrowseRoomsVM).Images.Count > 0)
            {
                var images = (DataContext as BrowseRoomsVM).Images;
                int indexOfLastImage = images.IndexOf((DataContext as BrowseRoomsVM).ShownImage);
                if (indexOfLastImage == 0)
                    indexOfLastImage = images.Count();
                (DataContext as BrowseRoomsVM).ShownImage = images[indexOfLastImage - 1];
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((DataContext as BrowseRoomsVM).Images.Count > 0)
            {
                var images = (DataContext as BrowseRoomsVM).Images;
                int indexOfLastImage = images.IndexOf((DataContext as BrowseRoomsVM).ShownImage);
                if (indexOfLastImage == images.Count() - 1)
                    indexOfLastImage = -1;
                (DataContext as BrowseRoomsVM).ShownImage = images[indexOfLastImage + 1];
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var rooms = (DataContext as BrowseRoomsVM).Rooms;
            int indexOfLastImage = rooms.IndexOf((DataContext as BrowseRoomsVM).ShownRoom);
            if (indexOfLastImage == rooms.Count() - 1)
                indexOfLastImage = -1;
            (DataContext as BrowseRoomsVM).ShownRoom = rooms[indexOfLastImage + 1];
            RoomBLL roomBLL = new RoomBLL();
            (DataContext as BrowseRoomsVM).Images =
                roomBLL.GetAllPhotosOfARoom((int)(DataContext as BrowseRoomsVM).ShownRoom.id);
            if ((DataContext as BrowseRoomsVM).Images.Count > 0)
            {
                (DataContext as BrowseRoomsVM).ShownImage = (DataContext as BrowseRoomsVM).Images[0];
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var rooms = (DataContext as BrowseRoomsVM).Rooms;
            int indexOfLastImage = rooms.IndexOf((DataContext as BrowseRoomsVM).ShownRoom);
            if (indexOfLastImage == 0)
                indexOfLastImage = rooms.Count();
            (DataContext as BrowseRoomsVM).ShownRoom = rooms[indexOfLastImage - 1];
            RoomBLL roomBLL = new RoomBLL();
            (DataContext as BrowseRoomsVM).Images =
                roomBLL.GetAllPhotosOfARoom((int)(DataContext as BrowseRoomsVM).ShownRoom.id);
            if ((DataContext as BrowseRoomsVM).Images.Count > 0)
            {
                (DataContext as BrowseRoomsVM).ShownImage = (DataContext as BrowseRoomsVM).Images[0];
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var currentRoom = (DataContext as BrowseRoomsVM).ShownRoom;
            BookRoomWindow bookRoomWindow = new BookRoomWindow(currentRoom, (DataContext as BrowseRoomsVM).CurrentUser.id, null);
            bookRoomWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as BrowseRoomsVM;
            BookedRoomsView bookedRoomsView = new BookedRoomsView(dc.CurrentUser.id);
            bookedRoomsView.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AdminView adminView = new AdminView();
            adminView.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            EditRoomView editRoomView = new EditRoomView();
            editRoomView.Show();
        }
    }
}
