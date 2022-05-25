using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Hotel_management.Viewmodels
{
    internal class BrowseRoomsVM : BasePropertyChanged
    {
        private User currentUser;
        public User CurrentUser {
            get => currentUser;
            set
            {
                currentUser = value;
                NotifyPropertyChanged("CurrentUser");
            }
        }
        public ObservableCollection<Room> Rooms { get; set; }
        private Room shownRoom;
        public Room ShownRoom {
            get => shownRoom;
            set
            {
                shownRoom = value;
                NotifyPropertyChanged("ShownRoom");
            }
        }

        public ObservableCollection<BitmapFrame> Images { get; set; }
        private BitmapFrame shownImage;
        public BitmapFrame ShownImage
        {
            get => shownImage;
            set
            {
                shownImage = value;
                NotifyPropertyChanged("ShownImage");
            }
        }
        public BrowseRoomsVM()
        {
            RoomBLL roomBLL = new RoomBLL();
            currentUser = new User();
            Rooms = new ObservableCollection<Room>();
            Rooms = roomBLL.GetAllRooms();
            ShownRoom = new Room();
            ShownRoom = Rooms[0];
            Images = new ObservableCollection<BitmapFrame>();
            Images = roomBLL.GetAllPhotosOfARoom((int)ShownRoom.id);
            if (Images.Count > 0)
            {
                ShownImage = Images[0];
            }
        }
    }
}
