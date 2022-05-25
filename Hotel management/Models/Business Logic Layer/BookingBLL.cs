using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Business_Logic_Layer
{
    internal class BookingBLL
    {
        BookingDAL bookingDAL = new BookingDAL();
        public void ModifyBooking(Booking booking)
        {
            bookingDAL.ModifyBooking(booking);
        }
    }
}
