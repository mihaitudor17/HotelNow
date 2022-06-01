using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Viewmodels
{
    internal class EditRoomVM : BasePropertyChanged
    {
        public ObservableCollection<Room> Rooms { get; set; }
        public Room selectedRoom = new Room();
        public Room SelectedRoom
        {
            get
            {
                return selectedRoom;
            }
            set
            {
                selectedRoom = value;
                NotifyPropertyChanged("SelectedRoom");
            }
        }


        public EditRoomVM()
        {
            RoomBLL roomBLL = new RoomBLL();
            Rooms = new ObservableCollection<Room>();
            Rooms = roomBLL.GetAllRooms();
        }
    }
}