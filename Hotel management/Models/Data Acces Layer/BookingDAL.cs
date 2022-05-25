using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Data_Acces_Layer
{
    internal class BookingDAL
    {
        public void ModifyBooking(Booking booking)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyBooking", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramUserId = new SqlParameter("@user_id", booking.user_id);
                SqlParameter paramRoomId = new SqlParameter("@room_id", booking.room_id);
                SqlParameter paramDate = new SqlParameter("@date", booking.date);
                SqlParameter paramState = new SqlParameter("@state", booking.state);
                SqlParameter paramDeleted = new SqlParameter("@deleted", booking.deleted);
                cmd.Parameters.Add(paramUserId);
                cmd.Parameters.Add(paramRoomId);
                cmd.Parameters.Add(paramDate);
                cmd.Parameters.Add(paramState);
                cmd.Parameters.Add(paramDeleted);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
