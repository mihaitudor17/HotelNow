using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Viewmodels
{
    internal class OffersVM : BasePropertyChanged
    {
        public ObservableCollection<Offer> Offers { get; set; }
        private Offer selectedOffer = new Offer();
        public Offer SelectedOffer
        {
            get
            {
                return selectedOffer;
            }
            set
            {
                selectedOffer = value;
                NotifyPropertyChanged("SelectedOffer");
            }
        }
        public Room CurrentRoom { get; set; }
        public long User_id { get; set; }
        public OffersVM()
        {
            Offers = new ObservableCollection<Offer>();
            OfferBLL offerBLL = new OfferBLL();
            Offers = offerBLL.GetAllOffers();
            if(Offers.Count > 0)
            {
                SelectedOffer = Offers[0];
            }
        }
    }
}
