using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Data_Acces_Layer
{
    internal class FeatureDAL
    {
        public void DeleteFeature(long id)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("DeleteFeature", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", id);
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddFeature(Feature feature)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("AddFeature", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@room_id", feature.room_id);
                SqlParameter paramName = new SqlParameter("@name", feature.name);
                SqlParameter paramPrice = new SqlParameter("@price", feature.price);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramPrice);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ModifyFeature(Feature feature)
        {
            using (SqlConnection con = DALHelper.Connection)
            {
                SqlCommand cmd = new SqlCommand("ModifyFeature", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter("@id", feature.id);
                SqlParameter paramRoomId = new SqlParameter("@room_id", feature.room_id);
                SqlParameter paramName = new SqlParameter("@name", feature.name);
                SqlParameter paramPrice = new SqlParameter("@price", feature.price);
                cmd.Parameters.Add(paramId);
                cmd.Parameters.Add(paramRoomId);
                cmd.Parameters.Add(paramName);
                cmd.Parameters.Add(paramPrice);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}