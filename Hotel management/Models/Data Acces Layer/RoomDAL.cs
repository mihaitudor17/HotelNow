using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Hotel_management.Models.Data_Acces_Layer
{
    internal class RoomDAL
    {
        public ObservableCollection<Room> GetAllRooms()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllRooms", con);
                ObservableCollection<Room> result = new ObservableCollection<Room>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Room p = new Room();
                    p.id = (long)reader[0];//reader.GetInt(0);
                    p.number = (long)reader[1];//reader.GetInt(0);
                    p.price = (double)reader[2];//reader.GetInt(0);
                    p.number_of_rooms = (long)reader[3];
                    result.Add(p);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
        public ObservableCollection<Photo> GetAllPhotosOfARoom(long id)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllPhotosOfARoom", con);
                ObservableCollection<Photo> result = new ObservableCollection<Photo>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@room_id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var tuc = reader[0];
                    Photo photo = new Photo()
                    {
                        //id = (long)reader[0],
                        image = (byte[])reader[0]
                    };
                    result.Add(photo);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public ObservableCollection<DateTime> GetAllBookingsOfARoom(long id)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllBookingsOfARoom", con);
                ObservableCollection<DateTime> result = new ObservableCollection<DateTime>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@room_id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime date = (DateTime)reader[0];
                    result.Add(date);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void BookARoom(long room_id, long user_id, DateTime date)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("BookARoom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramRoom = new SqlParameter("@room_id", room_id);
                SqlParameter paramUser = new SqlParameter("@user_id", user_id);
                SqlParameter paramDate = new SqlParameter("@date", date);
                cmd.Parameters.Add(paramRoom);
                cmd.Parameters.Add(paramUser);
                cmd.Parameters.Add(paramDate);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ObservableCollection<Feature> GetAllFeaturesOfARoom(long id)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllFeaturesOfARoom", con);
                ObservableCollection<Feature> result = new ObservableCollection<Feature>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@room_id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var turc = reader[0];
                    Feature feature = new Feature()
                    {
                        //id = (long)reader[0],
                        name = reader[0].ToString(),
                        price = (double)reader[1]
                    };
                    result.Add(feature);
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void AddRoom(Room room)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddRoom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramName = new SqlParameter("@number", room.number);
                SqlParameter paramRooms = new SqlParameter("@number_of_rooms", room.number_of_rooms);
                SqlParameter paramPrice = new SqlParameter("@price", room.price);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramRooms);
                cmd.Parameters.Add(paramPrice);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ModifyRoom(Room room)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyRoom", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", room.id);
                SqlParameter paramNumber = new SqlParameter("@number", room.number);
                SqlParameter paramRooms = new SqlParameter("@number_of_rooms", room.number_of_rooms);
                SqlParameter paramPrice = new SqlParameter("@price", room.price);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramNumber);
                cmd.Parameters.Add(paramRooms);
                cmd.Parameters.Add(paramPrice);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(long id)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteRoom", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}