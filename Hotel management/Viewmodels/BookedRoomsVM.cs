using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel_management.Viewmodels
{
    internal class BookedRoomsVM
    {
        public ObservableCollection<Tuple<long, DateTime, string>> RoomTime { get; set; }
        public ObservableCollection<Tuple<long,DateTime, DateTime, string>> BookTime { get; set; }
        public Tuple<long, DateTime,DateTime, string> HighlightedBooking { get; set; }
        public long CurrentUserId;
        public BookedRoomsVM(long user_id)
        {
            CurrentUserId = user_id;
            RoomTime = new ObservableCollection<Tuple<long, DateTime, string>>();
            BookTime = new ObservableCollection<Tuple<long, DateTime, DateTime, string>>();
            UserBLL userBLL = new UserBLL();
            RoomTime = userBLL.GetAllBookingsOfAUser(CurrentUserId);
            if (RoomTime.Count > 0)
            {
                for(int i = 0; i < RoomTime.Count-2; i++)
                {
                    int j = i + 1;
                    DateTime start = RoomTime[i].Item2;
                    DateTime end = RoomTime[j].Item2;
                    while ((RoomTime[j].Item2-RoomTime[j-1].Item2).TotalDays==1 &&j<RoomTime.Count-1)
                    {
                        j++;
                        end=RoomTime[j].Item2;
                    }
                    var temp = Tuple.Create(RoomTime[j].Item1, start, end, RoomTime[j].Item3);
                    BookTime.Add(temp);
                    i = j;
                }
                HighlightedBooking = BookTime[0];
            }

            //MessageBox.Show(RoomTime[0].Item1.ToString() + RoomTime[0].Item2.ToString());
        }
    }
}
