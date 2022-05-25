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
    internal class OfferDAL
    {
        public ObservableCollection<Offer> GetAllOffers()
        {
            SqlConnection con = DALHelper.Connection;
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllOffers", con);
                ObservableCollection<Offer> result = new ObservableCollection<Offer>();
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Offer offer = new Offer();
                    offer.id = (long)reader[0];
                    offer.name = reader[1].ToString();//reader.GetInt(0);
                    offer.start_date = (DateTime)reader[2];//reader.GetInt(0);
                    offer.number_of_days = (int)reader[3];
                    offer.price_reduction = (double)reader[4];
                    offer.deleted = false;
                    result.Add(offer);
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
