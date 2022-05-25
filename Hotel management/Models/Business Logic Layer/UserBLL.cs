using Hotel_management.Models.Data_Acces_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management.Models.Business_Logic_Layer
{
    public class UserBLL
    {
        public ObservableCollection<User> UserList { get; set; }

        UserDAL userDAL = new UserDAL();
        public UserBLL()
        {
            UserList = new ObservableCollection<User>();
        }

        public ObservableCollection<User> GetAllUsers()
        {
            return userDAL.GetAllUsers();
        }

        public void AddUser(User user)
        {
            userDAL.AddUser(user);
            UserList.Add(user);
        }

        public ObservableCollection<Tuple<long, DateTime, string>> GetAllBookingsOfAUser(long id)
        {
            return userDAL.GetAllBookingsOfAUser(id);
        }


        public void ModifyUser(User user)
        {
            userDAL.ModifyUser(user);
        }

        public void DeleteUser(long id)
        {
            userDAL.DeleteUser(id);
        }
    }
}
