using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Business_Logic_Layer
{
    internal class PhotoBLL
    {
        PhotoDAL photoDAL = new PhotoDAL();
        public void DeletePhoto(long id)
        {
            photoDAL.DeletePhoto(id);
        }

        public void AddPhoto(long room_id, string path)
        {
            byte[] b = File.ReadAllBytes(path);
            photoDAL.AddPhoto(new Photo()
            {
                room_id = room_id,
                image = b
            });
        }
    }
}