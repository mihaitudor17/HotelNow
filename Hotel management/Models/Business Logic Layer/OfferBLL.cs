using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Business_Logic_Layer
{
    internal class OfferBLL
    {
        public ObservableCollection<Offer> OfferList { get; set; }

        OfferDAL offerDAL = new OfferDAL();
        public OfferBLL()
        {
            OfferList = new ObservableCollection<Offer>();
        }

        public ObservableCollection<Offer> GetAllOffers()
        {
            return offerDAL.GetAllOffers();
        }
    }
}
