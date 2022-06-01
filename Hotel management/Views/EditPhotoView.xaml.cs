using Hotel_management.Models.Business_Logic_Layer;
using Hotel_management.Viewmodels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_management.Views
{
    /// <summary>
    /// Interaction logic for EditPhotoView.xaml
    /// </summary>
    public partial class EditPhotoView : Window
    {
        public EditPhotoView(long room_id)
        {
            InitializeComponent();
            DataContext = new EditPhotoVM(room_id);
            var dc = DataContext as EditPhotoVM;
            dc.room_id = room_id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((DataContext as EditPhotoVM).PhotosBitmap.Count > 0)
            {
                var images = (DataContext as EditPhotoVM).PhotosBitmap;
                int indexOfLastImage = images.IndexOf((DataContext as EditPhotoVM).ShownImage);
                if (indexOfLastImage == 0)
                    indexOfLastImage = images.Count();
                (DataContext as EditPhotoVM).ShownImage = images[indexOfLastImage - 1];
                (DataContext as EditPhotoVM).index = indexOfLastImage - 1;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((DataContext as EditPhotoVM).PhotosBitmap.Count > 0)
            {
                var images = (DataContext as EditPhotoVM).PhotosBitmap;
                int indexOfLastImage = images.IndexOf((DataContext as EditPhotoVM).ShownImage);
                if (indexOfLastImage == images.Count() - 1)
                    indexOfLastImage = -1;
                (DataContext as EditPhotoVM).ShownImage = images[indexOfLastImage + 1];
                (DataContext as EditPhotoVM).index = indexOfLastImage + 1;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as EditPhotoVM;
            if (dc.Photos.Count > 0)
            {
                PhotoBLL photoBLL = new PhotoBLL();
                photoBLL.DeletePhoto(dc.Photos[dc.index].id);
                dc.PhotosBitmap.RemoveAt(dc.index);
                dc.Photos.RemoveAt(dc.index);
                dc.ShownImage = dc.PhotosBitmap[0];
                dc.index = 0;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PhotoBLL photoBLL = new PhotoBLL();
            var dc = DataContext as EditPhotoVM;
            OpenFileDialog ofd = new OpenFileDialog();
            string path = "";
            ofd.Filter = "All files|*.*|*.jpg|*.png";
            if (ofd.ShowDialog() == true)
            {
                path = ofd.FileName;
                photoBLL.AddPhoto(dc.room_id, path);
                byte[] b = File.ReadAllBytes(path);
                using (var stream = new MemoryStream(b))
                {
                    var bitmap = BitmapFrame.Create(stream,
                                            BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                    dc.PhotosBitmap.Add(bitmap);
                }
                RoomBLL roomBLL = new RoomBLL();
                dc.Photos = roomBLL.GetAllPhotosOfARoomWithIds(dc.room_id);
            }
        }
    }
}