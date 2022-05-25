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

        public ObservableCollection<BitmapFrame> GetAllPhotosOfARoom(int id)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllPhotosOfARoom", con);
                ObservableCollection<BitmapFrame> result = new ObservableCollection<BitmapFrame>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@room_id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    byte[] img = (byte[])reader[0];

                    using (var stream = new MemoryStream(img))
                    {
                        var bitmap = BitmapFrame.Create(stream,
                                                BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                        result.Add(bitmap);
                    }

                    //result.Add(reader[0].ToString());
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
                    DateTime date= (DateTime)reader[0];
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

        public ObservableCollection<Tuple<string, double>> GetAllFeaturesOfARoom(long id)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllFeaturesOfARoom", con);
                ObservableCollection<Tuple<string, double>> result = new ObservableCollection<Tuple<string, double>>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@room_id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader[0].ToString();
                    double price = (double)reader[1];
                    result.Add(new Tuple<string, double>(name, price));
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
