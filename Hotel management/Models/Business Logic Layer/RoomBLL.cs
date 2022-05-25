using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Hotel_management.Models.Business_Logic_Layer
{
    internal class RoomBLL
    {
        public ObservableCollection<Room> RoomList { get; set; }

        RoomDAL roomDAL = new RoomDAL();

        public ObservableCollection<Room> GetAllRooms()
        {
            return roomDAL.GetAllRooms();
        }

        public ObservableCollection<BitmapFrame> GetAllPhotosOfARoom(int id)
        {
            return roomDAL.GetAllPhotosOfARoom(id);
        }

        public ObservableCollection<DateTime> GetAllBookingsOfARoom(long id)
        {
            return roomDAL.GetAllBookingsOfARoom(id);
        }
        public void BookARoom(long room_id, long user_id, DateTime date)
        {
            roomDAL.BookARoom(room_id, user_id, date);
        }

        public ObservableCollection<Tuple<string,double>> GetAllFeaturesOfARoom(long id)
        {
            return roomDAL.GetAllFeaturesOfARoom(id);
        }
    }
}
