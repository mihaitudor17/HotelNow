using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

        public ObservableCollection<Photo> GetAllPhotosOfARoomWithIds(long id)
        {
            return roomDAL.GetAllPhotosOfARoom(id);
        }
        public ObservableCollection<BitmapFrame> GetAllPhotosOfARoom(long id)
        {
            ObservableCollection<BitmapFrame> result = new ObservableCollection<BitmapFrame>();
            var xd = roomDAL.GetAllPhotosOfARoom(id);
            for (int i = 0; i < xd.Count; i++)
            {
                using (var stream = new MemoryStream(xd[i].image))
                {
                    var bitmap = BitmapFrame.Create(stream,
                                            BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                    result.Add(bitmap);
                }
            }
            return result;
        }

        public ObservableCollection<DateTime> GetAllBookingsOfARoom(long id)
        {
            return roomDAL.GetAllBookingsOfARoom(id);
        }
        public void BookARoom(long room_id, long user_id, DateTime date)
        {
            roomDAL.BookARoom(room_id, user_id, date);
        }

        public ObservableCollection<Feature> GetAllFeaturesOfARoom(long id)
        {
            return roomDAL.GetAllFeaturesOfARoom(id);
        }

        public void ModifyRoom(Room room)
        {
            roomDAL.ModifyRoom(room);
        }

        public void DeleteRoom(long id)
        {
            roomDAL.DeleteRoom(id);
        }
        public void AddRoom(Room room)
        {
            roomDAL.AddRoom(room);
        }
    }
}