using Hotel_management.Models.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Hotel_management.Viewmodels
{
    internal class EditPhotoVM : BasePropertyChanged
    {
        public ObservableCollection<Photo> Photos { get; set; }
        public ObservableCollection<BitmapFrame> PhotosBitmap { get; set; }
        private BitmapFrame shownImage;
        public BitmapFrame ShownImage
        {
            get => shownImage;
            set
            {
                shownImage = value;
                NotifyPropertyChanged("ShownImage");
            }
        }
        public int index = 0;
        public long room_id;
        public EditPhotoVM(long room_id)
        {
            this.room_id = room_id;
            Photos = new ObservableCollection<Photo>();
            RoomBLL roomBLL = new RoomBLL();
            Photos = roomBLL.GetAllPhotosOfARoomWithIds(this.room_id);
            PhotosBitmap = new ObservableCollection<BitmapFrame>();
            PhotosBitmap = roomBLL.GetAllPhotosOfARoom(this.room_id);
            if (PhotosBitmap.Count > 0)
            {
                ShownImage = PhotosBitmap[0];
            }
        }
    }
}
