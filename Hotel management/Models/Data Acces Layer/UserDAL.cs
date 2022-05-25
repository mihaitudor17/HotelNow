using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Data_Acces_Layer
{
    internal class UserDAL
    {
        public ObservableCollection<User> GetAllUsers()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllUsers", con);
                ObservableCollection<User> result = new ObservableCollection<User>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User p = new User();
                    p.id = (long)reader[0];//reader.GetInt(0);
                    p.name = reader.GetString(1);//reader[1].ToString();
                    p.surname = reader.GetString(2);//reader[1].ToString();
                    p.password = reader.IsDBNull(3) ? null : reader[3].ToString();
                    p.type = reader.IsDBNull(4) ? null : reader[4].ToString();
                    p.deleted = (bool)reader[5];
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
        public void AddUser(User user)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramName = new SqlParameter("@name", user.name);
                SqlParameter paramSurname = new SqlParameter("@surname", user.surname);
                SqlParameter paramPassword = new SqlParameter("@password", user.password);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramSurname);
                cmd.Parameters.Add(paramPassword);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ObservableCollection<Tuple<long, DateTime, string>> GetAllBookingsOfAUser(long id)
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllBookingsOfAUser", con);
                ObservableCollection<Tuple<long, DateTime, string>> result = new ObservableCollection<Tuple<long, DateTime, string>>();
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@user_id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    long room_id = (long)reader[0];
                    DateTime date = (DateTime)reader[1];
                    string state = (string)reader[2];
                    result.Add(new Tuple<long, DateTime, string>(room_id, date, state));
                }
                reader.Close();
                return result;
            }
            finally
            {
                con.Close();
            }
        }

        public void ModifyUser(User user)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyUser", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", user.id);
                SqlParameter paramName = new SqlParameter("@name", user.name);
                SqlParameter paramSurname = new SqlParameter("@surname", user.surname);
                SqlParameter paramPassword = new SqlParameter("@password", user.password);
                SqlParameter paramType = new SqlParameter("@type", user.type);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramSurname);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramType);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteUser(long id)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteUser", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
