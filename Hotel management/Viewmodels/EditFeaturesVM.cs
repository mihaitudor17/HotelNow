using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Viewmodels
{
    internal class EditFeaturesVM : BasePropertyChanged
    {
        public ObservableCollection<Feature> Features { get; set; }
        private Feature selectedFeature = new Feature();
        public Feature SelectedFeature
        {
            get
            {
                return selectedFeature;
            }
            set
            {
                selectedFeature = value;
                NotifyPropertyChanged("SelectedFeature");
            }
        }
        public long room_id;

        public EditFeaturesVM(long room_id)
        {
            this.room_id = room_id;
            Features = new ObservableCollection<Feature>();
            RoomBLL roomBLL = new RoomBLL();
            Features = roomBLL.GetAllFeaturesOfARoom(this.room_id);
        }
    }
}