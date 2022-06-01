using Hotel_management.Models.Business_Logic_Layer;
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
    /// Interaction logic for EditRoomView.xaml
    /// </summary>
    public partial class EditRoomView : Window
    {
        public EditRoomView()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as EditRoomVM;
            RoomBLL roomBLL = new RoomBLL();

            Room room = new Room()
            {
                number = dc.SelectedRoom.number,
                number_of_rooms = dc.SelectedRoom.number_of_rooms,
                price = dc.SelectedRoom.price,
            };
            dc.Rooms.Add(room);
            roomBLL.AddRoom(room);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as EditRoomVM;
            if (dc.SelectedRoom != null)
            {
                RoomBLL roomBLL = new RoomBLL();
                var newRoom = new Room();
                newRoom = dc.SelectedRoom;
                var user = dc.Rooms.First(x => x.id == newRoom.id);
                dc.Rooms[dc.Rooms.IndexOf(user)] = newRoom;
                roomBLL.ModifyRoom(newRoom);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RoomBLL roomBLL = new RoomBLL();
            var dc = DataContext as EditRoomVM;
            var newRoom = new Room();
            newRoom = dc.SelectedRoom;
            var room = dc.Rooms.First(x => x.id == newRoom.id);
            dc.Rooms.Remove(room);
            roomBLL.DeleteRoom(newRoom.id);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as EditRoomVM;
            EditPhotoView editPhotoView = new EditPhotoView(dc.SelectedRoom.id);
            editPhotoView.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as EditRoomVM;
            EditFeaturesView editPhotoView = new EditFeaturesView(dc.SelectedRoom.id);
            editPhotoView.Show();
            Close();
        }
    }
}
